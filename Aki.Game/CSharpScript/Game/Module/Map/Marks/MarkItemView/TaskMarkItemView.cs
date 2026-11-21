using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F7 RID: 17655
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskMarkItemView : ServerMarkItemView
	{
		// Token: 0x0602C941 RID: 182593 RVA: 0x00C83B44 File Offset: 0x00C81D44
		public TaskMarkItemView(ServerMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C942 RID: 182594 RVA: 0x00C83B4D File Offset: 0x00C81D4D
		public override void RegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C943 RID: 182595 RVA: 0x00C83B82 File Offset: 0x00C81D82
		public override void UnRegisterEvents()
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C944 RID: 182596 RVA: 0x00C83BB7 File Offset: 0x00C81DB7
		private void OnSubMapChanged(int floorIndex)
		{
			TaskMarkItem taskMarkItem = this.Holder as TaskMarkItem;
			if (taskMarkItem == null)
			{
				return;
			}
			taskMarkItem.UpdateMultiMapFloorSelectedState();
		}

		// Token: 0x0602C945 RID: 182597 RVA: 0x00C83BCE File Offset: 0x00C81DCE
		public void UpdateIcon()
		{
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
		}

		// Token: 0x0602C946 RID: 182598 RVA: 0x00C83BE8 File Offset: 0x00C81DE8
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

		// Token: 0x0602C947 RID: 182599 RVA: 0x00C83C3B File Offset: 0x00C81E3B
		private void Refresh()
		{
			this.InitRangeImage();
			this.OnIconPathChanged(this.Holder.IconPath);
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}

		// Token: 0x0602C948 RID: 182600 RVA: 0x00C83C6C File Offset: 0x00C81E6C
		private void InitRangeImage()
		{
			this.IsCanShowRangeImage = false;
			float rangeSize = this.Holder.RangeSize;
			this.IsRangeTrack = (rangeSize > 0f);
			if (rangeSize <= 0f)
			{
				return;
			}
			this.UpdateRangeShow(GeneralLogicTreeUtil.Instance.GetPlayerLocation() ?? Vector.ZeroVectorProxy, false);
			this.Flag = true;
		}

		// Token: 0x0602C949 RID: 182601 RVA: 0x00C83CC4 File Offset: 0x00C81EC4
		protected override IMarkItemHandle CreateRangeHandle<[Nullable(0)] T>(IMarkItemComponentContext markComponentContext)
		{
			return new TaskMarkItemRangeHandle(markComponentContext);
		}

		// Token: 0x0602C94A RID: 182602 RVA: 0x00C83CCC File Offset: 0x00C81ECC
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				this.Refresh();
			}
			this.UpdateRangeShow(playerLocation, bDragging);
		}

		// Token: 0x0602C94B RID: 182603 RVA: 0x00C83CF3 File Offset: 0x00C81EF3
		public bool IsRangeImageActive()
		{
			return base.MarkItemRangeHandle.IsVisible;
		}

		// Token: 0x0602C94C RID: 182604 RVA: 0x00C83D00 File Offset: 0x00C81F00
		private void UpdateRangeShow(Vector playerLocation, bool bDragging = false)
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
				num3 = Vector.Dist2D(playerLocation, this.Holder.WorldPosition) * 0.009999999776482582;
				flag = (num2 < taskMarkItem.RangeMarkShowDisUp && num2 > taskMarkItem.RangeMarkShowDisDown);
				flag2 = (num3 > rangeMarkShowDis && num2 > taskMarkItem.RangeMarkShowDisUp && num2 < taskMarkItem.RangeMarkShowDisDown);
			}
			else
			{
				num3 = Vector.Dist(playerLocation, this.Holder.WorldPosition) * 0.009999999776482582;
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

		// Token: 0x0602C94D RID: 182605 RVA: 0x00C83E6C File Offset: 0x00C8206C
		private void UpdateRangeImageActive(bool active)
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				bool flag = ((TaskMarkItem)this.Holder).IsCrossInstanceDungeon();
				this.SetRangeImageActive(active && !flag);
				return;
			}
			this.SetRangeImageActive(active);
		}

		// Token: 0x0602C94E RID: 182606 RVA: 0x00C83EBC File Offset: 0x00C820BC
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
			if (base.MarkItemRangeHandle.IsVisibleDirty && this.Holder.MapType == EMapType.MiniMap)
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

		// Token: 0x04017EB0 RID: 97968
		public readonly int QuestStepId;

		// Token: 0x04017EB1 RID: 97969
		private bool IsRangeTrack;

		// Token: 0x04017EB2 RID: 97970
		private bool IsCanShowRangeImage;

		// Token: 0x04017EB3 RID: 97971
		private bool Flag;
	}
}
