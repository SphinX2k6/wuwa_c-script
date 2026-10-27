using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005524 RID: 21796
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskMarkItemView : ServerMarkItemView
	{
		// Token: 0x06037A71 RID: 227953 RVA: 0x00D35D38 File Offset: 0x00D33F38
		public TaskMarkItemView(ServerMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A72 RID: 227954 RVA: 0x00D35D41 File Offset: 0x00D33F41
		public override void RegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x06037A73 RID: 227955 RVA: 0x00D35D76 File Offset: 0x00D33F76
		public override void UnRegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x06037A74 RID: 227956 RVA: 0x00D35DAB File Offset: 0x00D33FAB
		private void OnSubMapChanged(int floorIndex)
		{
			TaskMarkItem taskMarkItem = this.Holder as TaskMarkItem;
			if (taskMarkItem == null)
			{
				return;
			}
			taskMarkItem.UpdateMultiMapFloorSelectedState();
		}

		// Token: 0x06037A75 RID: 227957 RVA: 0x00D35DC2 File Offset: 0x00D33FC2
		public void UpdateIcon()
		{
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x06037A76 RID: 227958 RVA: 0x00D35DDC File Offset: 0x00D33FDC
		protected override void OnViewRefresh()
		{
			base.GetSprite(1).SetUIActive(true);
			base.MarkItemRangeHandle.SetVisible(false);
			this.Refresh();
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				((TaskMarkItem)this.Holder).UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x06037A77 RID: 227959 RVA: 0x00D35E2F File Offset: 0x00D3402F
		private void Refresh()
		{
			this.InitRangeImage();
			this.OnIconPathChanged(this.Holder.IconPath);
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}

		// Token: 0x06037A78 RID: 227960 RVA: 0x00D35E60 File Offset: 0x00D34060
		private void InitRangeImage()
		{
			this.IsCanShowRangeImage = false;
			float rangeSize = this.Holder.MarkItemEntity.Resource.RangeSize;
			this.IsRangeTrack = (rangeSize > 0f);
			if (rangeSize <= 0f)
			{
				return;
			}
			this.UpdateRangeShow(GeneralLogicTreeUtil.Instance.GetPlayerLocation() ?? global::Vector.ZeroVectorProxy, false);
			this.Flag = true;
		}

		// Token: 0x06037A79 RID: 227961 RVA: 0x00D35EC2 File Offset: 0x00D340C2
		protected override IMarkItemHandle CreateRangeHandle<[Nullable(0)] T>(IMarkItemComponentContext markComponentContext)
		{
			return new TaskMarkItemRangeHandle(markComponentContext);
		}

		// Token: 0x06037A7A RID: 227962 RVA: 0x00D35ECA File Offset: 0x00D340CA
		protected override void OnSafeUpdate(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				this.Refresh();
			}
			this.UpdateRangeShow(playerLocation, bDragging);
		}

		// Token: 0x06037A7B RID: 227963 RVA: 0x00D35EF1 File Offset: 0x00D340F1
		public bool IsRangeImageActive()
		{
			return this.Holder.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.Range, false);
		}

		// Token: 0x06037A7C RID: 227964 RVA: 0x00D35F0C File Offset: 0x00D3410C
		private void UpdateRangeShow(global::Vector playerLocation, bool bDragging = false)
		{
			if (!this.IsRangeTrack)
			{
				base.MarkItemTrackHandle.SetVisible(this.Holder.IsTracked && !bDragging);
				return;
			}
			if (!this.Holder.IsCanShowView)
			{
				this.UpdateRangeImageActive(false);
				return;
			}
			TaskMarkItem taskMarkItem = (TaskMarkItem)this.Holder;
			double rangeMarkShowDis = taskMarkItem.RangeMarkShowDis;
			double num = rangeMarkShowDis + 2.0;
			bool flag = true;
			double num3;
			bool flag2;
			if (taskMarkItem.RangeMarkShowDisUp != 0.0 || taskMarkItem.RangeMarkShowDisDown != 0.0)
			{
				double num2 = (playerLocation.Z - this.Holder.WorldPosition.Z) * 0.009999999776482582;
				num3 = global::Vector.Dist2D(playerLocation, this.Holder.WorldPosition) * 0.009999999776482582;
				flag = (num2 < taskMarkItem.RangeMarkShowDisUp && num2 > taskMarkItem.RangeMarkShowDisDown);
				flag2 = (num3 > rangeMarkShowDis && num2 > taskMarkItem.RangeMarkShowDisUp && num2 < taskMarkItem.RangeMarkShowDisDown);
			}
			else
			{
				num3 = global::Vector.Dist(playerLocation, this.Holder.WorldPosition) * 0.009999999776482582;
				flag2 = (num3 > rangeMarkShowDis);
			}
			base.MarkItemTrackHandle.SetVisible(flag2 && this.Holder.IsTracked);
			if (this.Flag)
			{
				this.UpdateRangeImageActive(!flag2);
				this.Flag = false;
				return;
			}
			this.UpdateRangeImageActive(num3 < num && flag);
		}

		// Token: 0x06037A7D RID: 227965 RVA: 0x00D36088 File Offset: 0x00D34288
		private void UpdateRangeImageActive(bool active)
		{
			TaskMarkItem taskMarkItem = (TaskMarkItem)this.Holder;
			int? num = (taskMarkItem != null) ? new int?(taskMarkItem.RawInstanceDungeonId) : null;
			int num2 = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(num2);
			if (config != null && config.GetValueOrDefault().EntranceEntitiesLength > 0)
			{
				num2 = config.Value.EntranceEntities(0).Value.DungeonId;
			}
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				int? num3 = num;
				int num4 = num2;
				bool flag = !(num3.GetValueOrDefault() == num4 & num3 != null);
				this.SetRangeImageActive(active && !flag);
				return;
			}
			this.SetRangeImageActive(active);
		}

		// Token: 0x06037A7E RID: 227966 RVA: 0x00D36164 File Offset: 0x00D34364
		private void SetRangeImageActive(bool active)
		{
			if (!this.IsRangeTrack)
			{
				return;
			}
			if (this.IsCanShowRangeImage == active)
			{
				MarkItem holder = this.Holder;
				if (holder != null && holder.MapType == EMapType.MiniMap)
				{
					return;
				}
			}
			this.IsCanShowRangeImage = active;
			base.MarkItemRangeHandle.SetVisible(active);
			if (this.Holder.MarkItemEntity.ViewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.Range) && this.Holder.MapType == EMapType.MiniMap)
			{
				TaskMarkItem taskMarkItem = (TaskMarkItem)this.Holder;
				EventSystem.Instance.Emit<ETrackSource, long, int, int, bool>(EEventName.TaskRangeTrackStateChange, taskMarkItem.TrackSource, taskMarkItem.TreeIncId.Value, taskMarkItem.NodeId, taskMarkItem.MarkId, active);
			}
			bool flag = this.Holder.IsOutOfBound || !active;
			base.GetSprite(1).SetUIActive(flag);
			this.IsShowIcon = flag;
			if (!flag)
			{
				base.MarkItemChildIconHandle.SetVisible(false);
			}
		}

		// Token: 0x0401D42D RID: 119853
		public readonly int QuestStepId;

		// Token: 0x0401D42E RID: 119854
		private bool IsRangeTrack;

		// Token: 0x0401D42F RID: 119855
		private bool IsCanShowRangeImage;

		// Token: 0x0401D430 RID: 119856
		private bool Flag;
	}
}
