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
	// Token: 0x02005504 RID: 21764
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigMarkItemView : MarkItemView
	{
		// Token: 0x06037992 RID: 227730 RVA: 0x00D3324D File Offset: 0x00D3144D
		public ConfigMarkItemView(ConfigMarkItem holder) : base(holder)
		{
		}

		// Token: 0x1700859D RID: 34205
		// (get) Token: 0x06037993 RID: 227731 RVA: 0x00D33256 File Offset: 0x00D31456
		public MapMark? MarkConfig
		{
			get
			{
				return ((ConfigMarkItem)this.Holder).MarkConfig;
			}
		}

		// Token: 0x06037994 RID: 227732 RVA: 0x00D33268 File Offset: 0x00D31468
		protected override void OnDataInitialized(MarkItem holder)
		{
			if (this.LevelSequencer == null)
			{
				this.LevelSequencer = new LevelSequencePlayer(this.RootItem);
			}
		}

		// Token: 0x06037995 RID: 227733 RVA: 0x00D33284 File Offset: 0x00D31484
		public override void RegisterEvents()
		{
			Entity teleportEntity = this.GetTeleportEntity();
			if (teleportEntity != null)
			{
				EventSystem.Instance.AddWithTarget<int, bool>(teleportEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			}
			EventSystem.Instance.Add(EEventName.LevelPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayMarkGamePlayStateUpdate));
			EventSystem.Instance.Add(EEventName.CommonPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayMarkGamePlayStateUpdate));
			EventSystem.Instance.Add(EEventName.OnFlagChallengeUpdateStrongholdData, new Action(this.OnFlagChallengeUpdateStrongholdData));
			EventSystem.Instance.Add(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnLevelPlayMarkGamePlayStateUpdate));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x06037996 RID: 227734 RVA: 0x00D3335C File Offset: 0x00D3155C
		public override void UnRegisterEvents()
		{
			Entity teleportEntity = this.GetTeleportEntity();
			if (teleportEntity != null)
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(teleportEntity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnEntityStateChange));
			}
			EventSystem.Instance.Remove(EEventName.LevelPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayMarkGamePlayStateUpdate));
			EventSystem.Instance.Remove(EEventName.CommonPlayMarkGamePlayStateUpdate, new Action<int>(this.OnLevelPlayMarkGamePlayStateUpdate));
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeUpdateStrongholdData, new Action(this.OnFlagChallengeUpdateStrongholdData));
			EventSystem.Instance.Remove(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnLevelPlayMarkGamePlayStateUpdate));
			MarkItem holder = this.Holder;
			if (holder != null && holder.MapType == EMapType.WorldMap)
			{
				EventSystem.Instance.Remove<int>(EEventName.WorldMapSubMapChangedFromUpdate, new Action<int>(this.OnSubMapChanged));
			}
		}

		// Token: 0x06037997 RID: 227735 RVA: 0x00D33434 File Offset: 0x00D31634
		[NullableContext(2)]
		private Entity GetTeleportEntity()
		{
			if (!MapConfig.Instance.GetIsInstanceTeleporterExist(this.MarkConfig.Value.MarkId))
			{
				return null;
			}
			InstEntityTeleporter? instEntityTeleportConfigById = MapConfig.Instance.GetInstEntityTeleportConfigById(this.MarkConfig.Value.MarkId);
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

		// Token: 0x06037998 RID: 227736 RVA: 0x00D334B7 File Offset: 0x00D316B7
		protected override void OnViewRefresh()
		{
			this.UpdateMultiMapFloorSelectState(true);
			(this.Holder as ConfigMarkItem).UpdateIconPath();
			this.OnIconPathChanged(this.Holder.IconPath);
		}

		// Token: 0x06037999 RID: 227737 RVA: 0x00D334E4 File Offset: 0x00D316E4
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

		// Token: 0x0603799A RID: 227738 RVA: 0x00D33540 File Offset: 0x00D31740
		public override UniTask PlayUnlockSequence()
		{
			ConfigMarkItemView.<PlayUnlockSequence>d__11 <PlayUnlockSequence>d__;
			<PlayUnlockSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockSequence>d__.<>4__this = this;
			<PlayUnlockSequence>d__.<>1__state = -1;
			<PlayUnlockSequence>d__.<>t__builder.Start<ConfigMarkItemView.<PlayUnlockSequence>d__11>(ref <PlayUnlockSequence>d__);
			return <PlayUnlockSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603799B RID: 227739 RVA: 0x00D33583 File Offset: 0x00D31783
		protected override void OnBeforeDestroy()
		{
			if (this.UnlockUiEffect != null)
			{
				ULGUIBPLibrary.DestroyActorWithHierarchy(this.UnlockUiEffect.GetOwner(), true);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603799C RID: 227740 RVA: 0x00D335A4 File Offset: 0x00D317A4
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

		// Token: 0x0603799D RID: 227741 RVA: 0x00D335F8 File Offset: 0x00D317F8
		public virtual void UpdateIcon()
		{
			string iconPath = this.Holder.IconPath;
			this.OnIconPathChanged(iconPath);
		}

		// Token: 0x0603799E RID: 227742 RVA: 0x00D33618 File Offset: 0x00D31818
		private void OnEntityStateChange(int stateId, bool _)
		{
			(this.Holder as ConfigMarkItem).UpdateIconPath();
			this.UpdateIcon();
		}

		// Token: 0x0603799F RID: 227743 RVA: 0x00D33630 File Offset: 0x00D31830
		private void OnFlagChallengeUpdateStrongholdData()
		{
			if (this.Holder != null)
			{
				this.OnIconPathChanged(this.Holder.IconPath);
			}
		}

		// Token: 0x060379A0 RID: 227744 RVA: 0x00D3364C File Offset: 0x00D3184C
		private void OnLevelPlayMarkGamePlayStateUpdate(int markId)
		{
			if (markId != this.MarkConfig.Value.MarkId)
			{
				return;
			}
			this.UpdateIcon();
		}

		// Token: 0x060379A1 RID: 227745 RVA: 0x00D33679 File Offset: 0x00D31879
		protected virtual void OnSubMapChanged(int floorIndex)
		{
			ConfigMarkItem configMarkItem = this.Holder as ConfigMarkItem;
			if (configMarkItem == null)
			{
				return;
			}
			configMarkItem.ChangeSubMap(floorIndex);
		}

		// Token: 0x0401D408 RID: 119816
		[Nullable(2)]
		private UUIItem UnlockUiEffect;

		// Token: 0x0401D409 RID: 119817
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencer;
	}
}
