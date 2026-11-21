using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044D7 RID: 17623
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigMarkItemView : MarkItemView
	{
		// Token: 0x0602C861 RID: 182369 RVA: 0x00C81231 File Offset: 0x00C7F431
		public ConfigMarkItemView(ConfigMarkItem holder) : base(holder)
		{
		}

		// Token: 0x0602C862 RID: 182370 RVA: 0x00C8123A File Offset: 0x00C7F43A
		protected override void OnDataInitialized(MarkItem holder)
		{
			if (this.LevelSequencer == null)
			{
				this.LevelSequencer = new LevelSequencePlayer(this.RootItem);
			}
		}

		// Token: 0x0602C863 RID: 182371 RVA: 0x00C81258 File Offset: 0x00C7F458
		public override void RegisterEvents()
		{
			Entity teleportEntity = this.GetTeleportEntity();
			if (teleportEntity != null)
			{
				EventSystem.Instance.AddWithTarget<int, bool>(teleportEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			}
			EventSystem.Instance.Add(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemShowStateChange));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C864 RID: 182372 RVA: 0x00C812DC File Offset: 0x00C7F4DC
		public override void UnRegisterEvents()
		{
			Entity teleportEntity = this.GetTeleportEntity();
			if (teleportEntity != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(teleportEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			}
			EventSystem.Instance.Remove(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemShowStateChange));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x0602C865 RID: 182373 RVA: 0x00C81360 File Offset: 0x00C7F560
		[NullableContext(2)]
		private Entity GetTeleportEntity()
		{
			if (!MapConfig.Instance.GetIsInstanceTeleporterExist(this.Holder.MarkId))
			{
				return null;
			}
			InstEntityTeleporter? instEntityTeleportConfigById = MapConfig.Instance.GetInstEntityTeleportConfigById(this.Holder.MarkId);
			if (instEntityTeleportConfigById == null)
			{
				return null;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(instEntityTeleportConfigById.Value.EntityConfigId);
			if (entityByPbDataId == null)
			{
				return null;
			}
			return entityByPbDataId.Entity;
		}

		// Token: 0x0602C866 RID: 182374 RVA: 0x00C813CB File Offset: 0x00C7F5CB
		protected override void OnViewRefresh()
		{
			this.UpdateMultiMapFloorSelectState(true);
			(this.Holder as ConfigMarkItem).UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x0602C867 RID: 182375 RVA: 0x00C813F8 File Offset: 0x00C7F5F8
		public void UpdateMultiMapFloorSelectState(bool isForceUpdate = false)
		{
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap && !isForceUpdate)
			{
				return;
			}
			ConfigMarkItem configMarkItem = this.Holder as ConfigMarkItem;
			bool isSelectThisFloor = configMarkItem.IsSelectThisFloor;
			configMarkItem.IsSelectThisFloor = configMarkItem.GetIsSelectThisFloor();
			if (isSelectThisFloor != configMarkItem.IsSelectThisFloor)
			{
				this.OnIconPathChanged(configMarkItem.IconPath);
			}
		}

		// Token: 0x0602C868 RID: 182376 RVA: 0x00C81454 File Offset: 0x00C7F654
		public override UniTask PlayUnlockSequence()
		{
			ConfigMarkItemView.<PlayUnlockSequence>d__9 <PlayUnlockSequence>d__;
			<PlayUnlockSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockSequence>d__.<>4__this = this;
			<PlayUnlockSequence>d__.<>1__state = -1;
			<PlayUnlockSequence>d__.<>t__builder.Start<ConfigMarkItemView.<PlayUnlockSequence>d__9>(ref <PlayUnlockSequence>d__);
			return <PlayUnlockSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602C869 RID: 182377 RVA: 0x00C81497 File Offset: 0x00C7F697
		protected override void OnBeforeDestroy()
		{
			if (this.UnlockUiEffect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.UnlockUiEffect.GetOwner(), true);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0602C86A RID: 182378 RVA: 0x00C814B8 File Offset: 0x00C7F6B8
		public override void OnIconPathChanged(string iconPath)
		{
			if (!base.IsViewReady)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(1);
			base.LoadIcon(sprite, iconPath);
			base.MarkItemChildIconHandle.Update();
			base.MarkItemChildIconHandle.ApplyModified();
			base.MarkItemTopRightIconHandle.Update();
			base.MarkItemTopRightIconHandle.ApplyModified();
		}

		// Token: 0x0602C86B RID: 182379 RVA: 0x00C8150C File Offset: 0x00C7F70C
		public virtual void UpdateIcon()
		{
			string iconPath = this.Holder.IconPath;
			this.OnIconPathChanged(iconPath);
		}

		// Token: 0x0602C86C RID: 182380 RVA: 0x00C8152C File Offset: 0x00C7F72C
		public override void RefreshGamePlayStateView()
		{
			this.UpdateIcon();
		}

		// Token: 0x0602C86D RID: 182381 RVA: 0x00C81534 File Offset: 0x00C7F734
		private void OnEntityStateChange(int stateId, bool _)
		{
			(this.Holder as ConfigMarkItem).UpdateIconPath();
			this.UpdateIcon();
		}

		// Token: 0x0602C86E RID: 182382 RVA: 0x00C8154C File Offset: 0x00C7F74C
		private void OnMarkItemShowStateChange(int markId)
		{
			if (markId != this.Holder.MarkId)
			{
				return;
			}
			this.UpdateIcon();
		}

		// Token: 0x0602C86F RID: 182383 RVA: 0x00C81563 File Offset: 0x00C7F763
		protected virtual void OnSubMapChanged(int floorIndex)
		{
			ConfigMarkItem configMarkItem = this.Holder as ConfigMarkItem;
			if (configMarkItem == null)
			{
				return;
			}
			configMarkItem.ChangeSubMap(floorIndex);
		}

		// Token: 0x04017E8C RID: 97932
		[Nullable(2)]
		private UUIItem UnlockUiEffect;

		// Token: 0x04017E8D RID: 97933
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencer;
	}
}
