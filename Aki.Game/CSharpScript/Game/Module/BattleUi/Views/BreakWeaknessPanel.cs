using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D1E RID: 23838
	[NullableContext(2)]
	[Nullable(0)]
	public class BreakWeaknessPanel : UiPanelBase
	{
		// Token: 0x0603C6BC RID: 247484 RVA: 0x00E7CDBC File Offset: 0x00E7AFBC
		[NullableContext(1)]
		public void Init(UUIItem parentItem, [Nullable(2)] UUIItem rootItem)
		{
			this.CurVisible = false;
			this.TargetVisible = false;
			this.ChildViewData = BattleUiModel.Instance.ChildViewData;
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			this.ButtonConfig = SkillButtonConfig.Instance.GetBehaviorCommonButtonConfig(2004);
			this.InteractionShowDelay = ConfigCommonParamById.GetFloatConfig("WeaknessInteractionShowDelay").Value;
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("WeaknessDistanceLimit");
			this.HorizontalDistance = (float)((intArrayConfig != null && intArrayConfig.Count > 0) ? intArrayConfig[0] : 0);
			this.UpDistance = (float)((intArrayConfig != null && intArrayConfig.Count > 1) ? intArrayConfig[1] : 0);
			this.DownDistance = (float)((intArrayConfig != null && intArrayConfig.Count > 2) ? intArrayConfig[2] : 0);
			this.Initialize(parentItem, rootItem).Forget();
		}

		// Token: 0x0603C6BD RID: 247485 RVA: 0x00E7CE98 File Offset: 0x00E7B098
		[NullableContext(1)]
		public UniTask Initialize(UUIItem parentItem, [Nullable(2)] UUIItem rootItem)
		{
			BreakWeaknessPanel.<Initialize>d__44 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.parentItem = parentItem;
			<Initialize>d__.rootItem = rootItem;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<BreakWeaknessPanel.<Initialize>d__44>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0603C6BE RID: 247486 RVA: 0x00E7CEEC File Offset: 0x00E7B0EC
		protected unsafe override void OnRegisterComponent()
		{
			int num;
			Span<ValueTuple<int, Type>> span;
			int num2;
			if (Info.Instance.IsInTouch())
			{
				num = 2;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
				this.ComponentRegisterInfos = list;
				num2 = 1;
				List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
				Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
				num = 0;
				*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickSkillButton));
				this.BtnBindInfo = list2;
				return;
			}
			num = 1;
			List<ValueTuple<int, Type>> list3 = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list3, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list3);
			num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list3;
		}

		// Token: 0x0603C6BF RID: 247487 RVA: 0x00E7CFE0 File Offset: 0x00E7B1E0
		protected override UniTask OnBeforeStartAsync()
		{
			BreakWeaknessPanel.<OnBeforeStartAsync>d__46 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BreakWeaknessPanel.<OnBeforeStartAsync>d__46>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C6C0 RID: 247488 RVA: 0x00E7D024 File Offset: 0x00E7B224
		[NullableContext(0)]
		private UniTask<bool> NewKeyItem()
		{
			BreakWeaknessPanel.<NewKeyItem>d__47 <NewKeyItem>d__;
			<NewKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<NewKeyItem>d__.<>4__this = this;
			<NewKeyItem>d__.<>1__state = -1;
			<NewKeyItem>d__.<>t__builder.Start<BreakWeaknessPanel.<NewKeyItem>d__47>(ref <NewKeyItem>d__);
			return <NewKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C6C1 RID: 247489 RVA: 0x00E7D067 File Offset: 0x00E7B267
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TexIcon = base.GetTexture(1);
			if (this.TagComponent != null)
			{
				this.OnDisableTagChanged(0, false);
			}
		}

		// Token: 0x0603C6C2 RID: 247490 RVA: 0x00E7D098 File Offset: 0x00E7B298
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopPlayingSequence(false, true);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
			}
			this.IsClicked = false;
			this.RefreshIcon();
		}

		// Token: 0x0603C6C3 RID: 247491 RVA: 0x00E7D0E6 File Offset: 0x00E7B2E6
		protected override void OnAfterHide()
		{
			this.TempMonsterEntityHandle = null;
			this.TempTargetSocket = null;
		}

		// Token: 0x0603C6C4 RID: 247492 RVA: 0x00E7D0FC File Offset: 0x00E7B2FC
		private void RefreshIcon()
		{
			if (this.TexIcon == null)
			{
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				return;
			}
			RoleInfo? roleConfig = getCurrentEntity.Entity.GetComponent<CreatureDataComponent>().GetRoleConfig();
			int num = (roleConfig != null) ? roleConfig.GetValueOrDefault().WeaponType : 1;
			string skillIcon = this.ButtonConfig.Value.SkillIcons(num - 1);
			this.SetSkillIcon(skillIcon);
		}

		// Token: 0x0603C6C5 RID: 247493 RVA: 0x00E7D17C File Offset: 0x00E7B37C
		[NullableContext(1)]
		private void SetSkillIcon(string skillIconPath)
		{
			if (string.IsNullOrEmpty(skillIconPath))
			{
				return;
			}
			if (this.SkillIconPath == skillIconPath)
			{
				return;
			}
			if (this.SetTextureHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SetTextureHandleId);
			}
			this.IsLoadingSkillIcon = true;
			this.SkillIconPath = skillIconPath;
			this.SetTextureHandleId = ResourceSystem.Instance.LoadAsync<UTexture>(skillIconPath, delegate([Nullable(2)] UTexture textureData, string _)
			{
				this.IsLoadingSkillIcon = false;
				if (this.TexIcon == null || this.SkillIconPath != skillIconPath)
				{
					return;
				}
				if (textureData == null)
				{
					this.TexIcon.SetUIActive(false);
					return;
				}
				this.TexIcon.SetTexture(textureData);
				this.TexIcon.SetUIActive(true);
			}, 103, "js_undefined");
			this.SkillIconPath = skillIconPath;
			if (this.IsLoadingSkillIcon)
			{
				this.TexIcon.SetUIActive(false);
			}
		}

		// Token: 0x0603C6C6 RID: 247494 RVA: 0x00E7D234 File Offset: 0x00E7B434
		protected override UniTask OnBeforeHideAsync()
		{
			BreakWeaknessPanel.<OnBeforeHideAsync>d__53 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<BreakWeaknessPanel.<OnBeforeHideAsync>d__53>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C6C7 RID: 247495 RVA: 0x00E7D277 File Offset: 0x00E7B477
		private void OnCloseAnimTimerEnd(float _)
		{
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}

		// Token: 0x0603C6C8 RID: 247496 RVA: 0x00E7D294 File Offset: 0x00E7B494
		protected override void OnBeforeDestroy()
		{
			if (this.MonsterEntityHandle != null)
			{
				this.OnRemove();
			}
			if (this.CloseTimer != null)
			{
				TimerSystem.Instance.Remove(this.CloseTimer);
				this.CloseTimer = null;
				this.Promise.SetResult();
				this.Promise = null;
			}
			this.TexIcon = null;
			this.TempMonsterEntityHandle = null;
			this.RemoveEvents();
			this.RemoveNextTick();
			this.RemoveInteractionShowTimer(true);
		}

		// Token: 0x0603C6C9 RID: 247497 RVA: 0x00E7D304 File Offset: 0x00E7B504
		private void AddEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x0603C6CA RID: 247498 RVA: 0x00E7D354 File Offset: 0x00E7B554
		private void RemoveEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x0603C6CB RID: 247499 RVA: 0x00E7D3A1 File Offset: 0x00E7B5A1
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.OnInteract();
			}
		}

		// Token: 0x0603C6CC RID: 247500 RVA: 0x00E7D3AD File Offset: 0x00E7B5AD
		private void OnClickSkillButton()
		{
			this.OnInteract();
		}

		// Token: 0x0603C6CD RID: 247501 RVA: 0x00E7D3B8 File Offset: 0x00E7B5B8
		private void OnInteract()
		{
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle == null || !monsterEntityHandle.Valid)
			{
				this.OnRemove();
				return;
			}
			this.RefreshEntityDistanceValid();
			if (!this.DistanceValid)
			{
				this.RefreshVisible();
				return;
			}
			this.RefreshLogicVisible();
			if (!this.IsLogicVisible())
			{
				return;
			}
			PawnInteractBaseComponent component = this.MonsterEntityHandle.Entity.GetComponent<PawnInteractBaseComponent>();
			if (component == null || !component.IsPawnInteractive())
			{
				return;
			}
			component.InteractPawn(-1, null);
			this.IsClicked = true;
		}

		// Token: 0x0603C6CE RID: 247502 RVA: 0x00E7D43A File Offset: 0x00E7B63A
		private void OnBattleChildVisibleChanged()
		{
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			this.RefreshVisible();
		}

		// Token: 0x0603C6CF RID: 247503 RVA: 0x00E7D458 File Offset: 0x00E7B658
		public void ShowByEntity(int entityId, ECustomOptionType? optionType)
		{
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle != null && monsterEntityHandle.Id == entityId)
			{
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null)
			{
				this.OnRemove();
				return;
			}
			this.RemoveEntityEvents();
			this.MonsterEntityHandle = entityById;
			this.MonsterWeaknessComp = this.MonsterEntityHandle.Entity.GetComponent<MonsterWeaknessComponent>();
			this.OnAdd();
			this.RefreshIcon();
		}

		// Token: 0x0603C6D0 RID: 247504 RVA: 0x00E7D4C2 File Offset: 0x00E7B6C2
		public void HideByEntity(int entityId)
		{
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle == null || monsterEntityHandle.Id != entityId)
			{
				return;
			}
			this.OnRemove();
		}

		// Token: 0x0603C6D1 RID: 247505 RVA: 0x00E7D4E5 File Offset: 0x00E7B6E5
		public void ChangeRole()
		{
			if (this.MonsterEntityHandle == null)
			{
				return;
			}
			this.ClearAllTagCountChangedCallback();
			this.RemoveCharAnimBreakPointListener();
			this.RefreshPlayerEntity();
			this.RefreshIcon();
		}

		// Token: 0x0603C6D2 RID: 247506 RVA: 0x00E7D508 File Offset: 0x00E7B708
		private void RefreshPlayerEntity()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				this.TagComponent = null;
				this.SkillComponent = null;
				this.RefreshVisible();
				return;
			}
			this.TagComponent = getCurrentEntity.Entity.GetComponent<BaseTagComponent>();
			this.SkillComponent = getCurrentEntity.Entity.GetComponent<BaseSkillComponent>();
			this.AddEntityEvents();
			this.OnDisableTagChanged(0, false);
			this.OnHiddenTagChanged(0, false);
			this.OnSkillAnimTagChanged(0, false);
		}

		// Token: 0x0603C6D3 RID: 247507 RVA: 0x00E7D586 File Offset: 0x00E7B786
		private void OnAdd()
		{
			this.RefreshEntityDistanceValid();
			this.RefreshPlayerEntity();
			this.AddTimer();
			this.RemoveInteractionShowTimer(false);
			BattleUiModel.Instance.SetExecutionInteractEnable(true);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, false, true, 0);
		}

		// Token: 0x0603C6D4 RID: 247508 RVA: 0x00E7D5C4 File Offset: 0x00E7B7C4
		private void OnRemove()
		{
			this.RemoveEntityEvents();
			this.RemoveTimer();
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle != null && monsterEntityHandle.Valid)
			{
				this.TempMonsterEntityHandle = this.MonsterEntityHandle;
				MonsterWeaknessComponent monsterWeaknessComp = this.MonsterWeaknessComp;
				string text = (monsterWeaknessComp != null) ? monsterWeaknessComp.TargetSocket : null;
				this.TempTargetSocket = new FName?((!string.IsNullOrEmpty(text)) ? new FName(text) : this.hitCaseSocket);
			}
			this.MonsterEntityHandle = null;
			this.MonsterWeaknessComp = null;
			this.TagComponent = null;
			this.SkillComponent = null;
			this.DistanceValid = false;
			this.RefreshVisible();
			this.AddInteractionShowTimer();
			BattleUiModel.Instance.SetExecutionInteractEnable(false);
		}

		// Token: 0x0603C6D5 RID: 247509 RVA: 0x00E7D66C File Offset: 0x00E7B86C
		private void AddEntityEvents()
		{
			if (this.MonsterEntityHandle == null)
			{
				return;
			}
			if (!EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(this.MonsterEntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.MonsterEntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
			BehaviorCommonButton value = this.ButtonConfig.Value;
			for (int i = 0; i < value.DisableTagsLength; i++)
			{
				this.ListenForTagAddOrRemoveChanged(value.DisableTags(i), new BaseTagComponent.TTagSwitchedCallback(this.OnDisableTagChanged));
			}
			for (int j = 0; j < value.HiddenTagsLength; j++)
			{
				this.ListenForTagAddOrRemoveChanged(value.HiddenTags(j), new BaseTagComponent.TTagSwitchedCallback(this.OnHiddenTagChanged));
			}
			this.ListenForTagAddOrRemoveChanged(BreakWeaknessPanel.ultimateTag, new BaseTagComponent.TTagSwitchedCallback(this.OnSkillAnimTagChanged));
			this.ListenForTagAddOrRemoveChanged(BreakWeaknessPanel.qteTag, new BaseTagComponent.TTagSwitchedCallback(this.OnSkillAnimTagChanged));
		}

		// Token: 0x0603C6D6 RID: 247510 RVA: 0x00E7D759 File Offset: 0x00E7B959
		private void RemoveEntityEvents()
		{
			this.ClearAllTagCountChangedCallback();
			this.RemoveCharAnimBreakPointListener();
			this.SkillAnimVisible = true;
			if (this.MonsterEntityHandle == null)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTarget(this.MonsterEntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}

		// Token: 0x0603C6D7 RID: 247511 RVA: 0x00E7D799 File Offset: 0x00E7B999
		[NullableContext(1)]
		private void OnRemoveEntity(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
		{
			this.OnRemove();
		}

		// Token: 0x0603C6D8 RID: 247512 RVA: 0x00E7D7A4 File Offset: 0x00E7B9A4
		private void OnDisableTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				this.SetEnable(false);
				return;
			}
			BehaviorCommonButton value = this.ButtonConfig.Value;
			for (int i = 0; i < value.DisableTagsLength; i++)
			{
				if (this.TagComponent.HasTag(value.DisableTags(i)))
				{
					this.SetEnable(false);
					return;
				}
			}
			this.SetEnable(true);
		}

		// Token: 0x0603C6D9 RID: 247513 RVA: 0x00E7D800 File Offset: 0x00E7BA00
		private void OnHiddenTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				this.TagVisible = false;
				this.RefreshVisible();
				return;
			}
			BehaviorCommonButton value = this.ButtonConfig.Value;
			for (int i = 0; i < value.HiddenTagsLength; i++)
			{
				if (this.TagComponent.HasTag(value.HiddenTags(i)))
				{
					this.TagVisible = false;
					this.RefreshVisible();
					return;
				}
			}
			this.TagVisible = true;
			this.RefreshVisible();
		}

		// Token: 0x0603C6DA RID: 247514 RVA: 0x00E7D86C File Offset: 0x00E7BA6C
		private void OnSkillAnimTagChanged(int tagId, bool tagExist)
		{
			this.RefreshSkillAnimVisible();
		}

		// Token: 0x0603C6DB RID: 247515 RVA: 0x00E7D874 File Offset: 0x00E7BA74
		private void RefreshSkillAnimVisible()
		{
			if (this.TagComponent == null)
			{
				return;
			}
			if (this.TagComponent.HasTag(BreakWeaknessPanel.ultimateTag) || this.TagComponent.HasTag(BreakWeaknessPanel.qteTag))
			{
				BaseSkillComponent skillComponent = this.SkillComponent;
				this.SkillAnimVisible = (skillComponent == null || skillComponent.IsMainSkillReadyEnd);
				this.RefreshVisible();
				if (!this.SkillAnimVisible)
				{
					this.AddCharAnimBreakPointListener();
					return;
				}
			}
			else
			{
				this.RemoveCharAnimBreakPointListener();
				this.SkillAnimVisible = true;
				this.RefreshVisible();
			}
		}

		// Token: 0x0603C6DC RID: 247516 RVA: 0x00E7D8F1 File Offset: 0x00E7BAF1
		private void AddCharAnimBreakPointListener()
		{
			if (this.IsListeningCharAnimBreakPoint)
			{
				return;
			}
			EventSystem.Instance.Add<int>(EEventName.CharAnimBreakPoint, new Action<int>(this.OnCharAnimBreakPoint));
			this.IsListeningCharAnimBreakPoint = true;
		}

		// Token: 0x0603C6DD RID: 247517 RVA: 0x00E7D91C File Offset: 0x00E7BB1C
		private void RemoveCharAnimBreakPointListener()
		{
			if (!this.IsListeningCharAnimBreakPoint)
			{
				return;
			}
			EventSystem.Instance.Remove<int>(EEventName.CharAnimBreakPoint, new Action<int>(this.OnCharAnimBreakPoint));
			this.IsListeningCharAnimBreakPoint = false;
		}

		// Token: 0x0603C6DE RID: 247518 RVA: 0x00E7D947 File Offset: 0x00E7BB47
		private void OnCharAnimBreakPoint(int charId)
		{
			this.RefreshSkillAnimVisible();
		}

		// Token: 0x0603C6DF RID: 247519 RVA: 0x00E7D94F File Offset: 0x00E7BB4F
		private void SetEnable(bool value)
		{
			if (this.RootItem == null)
			{
				return;
			}
			if (value)
			{
				this.RootItem.SetAlpha(1f);
				return;
			}
			this.RootItem.SetAlpha(0.5f);
		}

		// Token: 0x0603C6E0 RID: 247520 RVA: 0x00E7D980 File Offset: 0x00E7BB80
		[NullableContext(1)]
		private void ListenForTagAddOrRemoveChanged(int tagId, BaseTagComponent.TTagSwitchedCallback onTagChange)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null)
			{
				return;
			}
			ITagTask item = tagComponent.ListenForTagAddOrRemove(new int?(tagId), onTagChange, null);
			this.TagTaskList.Add(item);
		}

		// Token: 0x0603C6E1 RID: 247521 RVA: 0x00E7D9B4 File Offset: 0x00E7BBB4
		private void ClearAllTagCountChangedCallback()
		{
			if (this.TagTaskList.Count > 0)
			{
				foreach (ITagTask tagTask in this.TagTaskList)
				{
					tagTask.EndTask();
				}
				this.TagTaskList.Clear();
			}
		}

		// Token: 0x0603C6E2 RID: 247522 RVA: 0x00E7DA20 File Offset: 0x00E7BC20
		public void Tick(float delta)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			if (base.IsShowOrShowing || base.IsHiding)
			{
				this.RefreshActiveAndPosition();
				if (!this.IsInScreen && this.TargetVisible)
				{
					this.SetVisible(false);
				}
				return;
			}
			if (this.IsLogicVisible() && this.ChildVisible)
			{
				this.RefreshActiveAndPosition();
				if (this.IsInScreen)
				{
					this.SetVisible(true);
				}
				return;
			}
		}

		// Token: 0x0603C6E3 RID: 247523 RVA: 0x00E7DA90 File Offset: 0x00E7BC90
		private void RefreshActiveAndPosition()
		{
			if (this.RootItem == null)
			{
				return;
			}
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle == null || !monsterEntityHandle.Valid)
			{
				EntityHandle tempMonsterEntityHandle = this.TempMonsterEntityHandle;
				if (tempMonsterEntityHandle == null || !tempMonsterEntityHandle.Valid)
				{
					return;
				}
			}
			FVectorDouble? worldLocation = this.GetWorldLocation();
			if (worldLocation == null)
			{
				return;
			}
			this.IsInScreen = HudUnitUtils.PositionUtil.ProjectWorldToScreen(worldLocation.Value, this.ScreenPos);
			if (!this.IsInScreen)
			{
				return;
			}
			this.RootItem.SetAnchorOffset(this.ScreenPos.ToUeVector2D(false));
		}

		// Token: 0x0603C6E4 RID: 247524 RVA: 0x00E7DB24 File Offset: 0x00E7BD24
		private FVectorDouble? GetWorldLocation()
		{
			EntityHandle entityHandle = this.MonsterEntityHandle ?? this.TempMonsterEntityHandle;
			if (entityHandle == null)
			{
				return null;
			}
			TsBaseCharacter tsBaseCharacter = entityHandle.Entity.GetComponent<BaseActorComponent>().Owner as TsBaseCharacter;
			if (tsBaseCharacter == null)
			{
				return null;
			}
			USceneComponent mesh = tsBaseCharacter.Mesh;
			MonsterWeaknessComponent monsterWeaknessComp = this.MonsterWeaknessComp;
			string text = (monsterWeaknessComp != null) ? monsterWeaknessComp.TargetSocket : null;
			FName inSocketName = (!string.IsNullOrEmpty(text)) ? new FName(text) : (this.TempTargetSocket ?? this.hitCaseSocket);
			return new FVectorDouble?(mesh.D_GetSocketLocation(inSocketName));
		}

		// Token: 0x0603C6E5 RID: 247525 RVA: 0x00E7DBCC File Offset: 0x00E7BDCC
		private void RefreshVisible()
		{
			this.RefreshLogicVisible();
			if (!this.IsLogicVisible() || !this.ChildVisible)
			{
				this.SetVisible(false);
				return;
			}
			if (!Info.Instance.IsInTouch())
			{
				this.RefreshActiveAndPosition();
			}
			else
			{
				this.IsInScreen = true;
			}
			if (this.IsInScreen)
			{
				this.SetVisible(true);
				return;
			}
			this.SetVisible(false);
		}

		// Token: 0x0603C6E6 RID: 247526 RVA: 0x00E7DC29 File Offset: 0x00E7BE29
		private void SetVisible(bool value)
		{
			this.TargetVisible = value;
			if (this.TargetVisible == this.CurVisible)
			{
				this.RemoveNextTick();
				return;
			}
			this.AddNextTick();
		}

		// Token: 0x0603C6E7 RID: 247527 RVA: 0x00E7DC4D File Offset: 0x00E7BE4D
		private void AddNextTick()
		{
			if (this.NextTick != null)
			{
				return;
			}
			this.NextTick = TimerSystem.Instance.Next(new TTimerAction(this.OnNextTick), null, null);
		}

		// Token: 0x0603C6E8 RID: 247528 RVA: 0x00E7DC76 File Offset: 0x00E7BE76
		private void RemoveNextTick()
		{
			if (this.NextTick == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.NextTick);
			this.NextTick = null;
		}

		// Token: 0x0603C6E9 RID: 247529 RVA: 0x00E7DC9C File Offset: 0x00E7BE9C
		private void OnNextTick(float _)
		{
			this.NextTick = null;
			if (this.CurVisible != this.TargetVisible)
			{
				this.CurVisible = this.TargetVisible;
				if (this.CurVisible)
				{
					base.Show(null);
					if (this.CloseTimer != null)
					{
						TimerSystem.Instance.Remove(this.CloseTimer);
						this.CloseTimer = null;
						this.Promise.SetResult();
						this.Promise = null;
						return;
					}
				}
				else
				{
					base.Hide(null);
				}
			}
		}

		// Token: 0x0603C6EA RID: 247530 RVA: 0x00E7DD13 File Offset: 0x00E7BF13
		private void AddTimer()
		{
			if (this.Timer != null)
			{
				return;
			}
			this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimer), 200f, 1f, null, null, true);
		}

		// Token: 0x0603C6EB RID: 247531 RVA: 0x00E7DD47 File Offset: 0x00E7BF47
		private void RemoveTimer()
		{
			if (this.Timer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}

		// Token: 0x0603C6EC RID: 247532 RVA: 0x00E7DD6A File Offset: 0x00E7BF6A
		private void OnTimer(float _)
		{
			bool distanceValid = this.DistanceValid;
			this.RefreshEntityDistanceValid();
			if (distanceValid != this.DistanceValid)
			{
				this.RefreshVisible();
			}
		}

		// Token: 0x0603C6ED RID: 247533 RVA: 0x00E7DD88 File Offset: 0x00E7BF88
		private void RefreshEntityDistanceValid()
		{
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle == null || !monsterEntityHandle.Valid || this.MonsterWeaknessComp == null)
			{
				this.DistanceValid = false;
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.Valid)
			{
				this.DistanceValid = false;
				return;
			}
			global::Vector actorLocationProxy = getCurrentEntity.Entity.GetComponent<BaseActorComponent>().ActorLocationProxy;
			FVectorDouble? worldLocation = this.GetWorldLocation();
			if (worldLocation == null)
			{
				this.DistanceValid = false;
				return;
			}
			FVectorDouble value = worldLocation.Value;
			double num = actorLocationProxy.Z - value.Z;
			if (num < (double)(-(double)this.UpDistance) || num > (double)this.DownDistance)
			{
				this.DistanceValid = false;
				return;
			}
			double num2 = actorLocationProxy.X - value.X;
			double num3 = actorLocationProxy.Y - value.Y;
			double num4 = num2 * num2 + num3 * num3;
			float horizontalDistance = this.HorizontalDistance;
			if (num4 > (double)(horizontalDistance * horizontalDistance))
			{
				this.DistanceValid = false;
				return;
			}
			this.DistanceValid = true;
		}

		// Token: 0x0603C6EE RID: 247534 RVA: 0x00E7DE87 File Offset: 0x00E7C087
		private bool IsLogicVisible()
		{
			return this.LogicVisible;
		}

		// Token: 0x0603C6EF RID: 247535 RVA: 0x00E7DE8F File Offset: 0x00E7C08F
		private bool CameraSeqVisible()
		{
			return this.ChildViewData.GetVisibleByReason(EBattleUiChild.BattleHud, EBattleUiVisibleReason.CameraSeq);
		}

		// Token: 0x0603C6F0 RID: 247536 RVA: 0x00E7DEA0 File Offset: 0x00E7C0A0
		private void RefreshLogicVisible()
		{
			bool flag = this.DistanceValid && this.CameraSeqVisible() && this.TagVisible && this.SkillAnimVisible;
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			int num = (monsterEntityHandle != null) ? monsterEntityHandle.Id : 0;
			if (flag == this.LogicVisible && this.LastMonsterEntityId == num)
			{
				return;
			}
			this.LogicVisible = flag;
			this.LastMonsterEntityId = num;
			EventSystem.Instance.Emit<bool, int>(EEventName.BreakWeaknessPanelLogicVisibleChange, flag, num);
		}

		// Token: 0x0603C6F1 RID: 247537 RVA: 0x00E7DF15 File Offset: 0x00E7C115
		private void AddInteractionShowTimer()
		{
			this.RemoveInteractionShowTimer(false);
			this.InteractionShowTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 0);
				this.InteractionShowTimer = null;
			}, this.InteractionShowDelay, null, null, true, 1f);
		}

		// Token: 0x0603C6F2 RID: 247538 RVA: 0x00E7DF48 File Offset: 0x00E7C148
		private void RemoveInteractionShowTimer(bool resetVisible = false)
		{
			if (this.InteractionShowTimer != null)
			{
				TimerSystem.Instance.Remove(this.InteractionShowTimer);
				this.InteractionShowTimer = null;
				if (resetVisible)
				{
					BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 0);
				}
			}
		}

		// Token: 0x0401F7C2 RID: 128962
		private const float CLOSE_ANIM_TIME = 300f;

		// Token: 0x0401F7C3 RID: 128963
		private const EBattleUiChild ChildType = EBattleUiChild.BattleHud;

		// Token: 0x0401F7C4 RID: 128964
		private static readonly int ultimateTag = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"];

		// Token: 0x0401F7C5 RID: 128965
		private static readonly int qteTag = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.QTE"];

		// Token: 0x0401F7C6 RID: 128966
		private readonly FName hitCaseSocket = new FName("HitCase");

		// Token: 0x0401F7C7 RID: 128967
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F7C8 RID: 128968
		[Nullable(1)]
		private readonly Vector2D ScreenPos = new Vector2D();

		// Token: 0x0401F7C9 RID: 128969
		private EntityHandle MonsterEntityHandle;

		// Token: 0x0401F7CA RID: 128970
		private int LastMonsterEntityId;

		// Token: 0x0401F7CB RID: 128971
		private MonsterWeaknessComponent MonsterWeaknessComp;

		// Token: 0x0401F7CC RID: 128972
		private BaseTagComponent TagComponent;

		// Token: 0x0401F7CD RID: 128973
		private BaseSkillComponent SkillComponent;

		// Token: 0x0401F7CE RID: 128974
		[Nullable(1)]
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0401F7CF RID: 128975
		private bool IsListeningCharAnimBreakPoint;

		// Token: 0x0401F7D0 RID: 128976
		private UUITexture TexIcon;

		// Token: 0x0401F7D1 RID: 128977
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401F7D2 RID: 128978
		private TimerHandle CloseTimer;

		// Token: 0x0401F7D3 RID: 128979
		private CustomPromise Promise;

		// Token: 0x0401F7D4 RID: 128980
		private BattleUiChildViewData ChildViewData;

		// Token: 0x0401F7D5 RID: 128981
		private bool ChildVisible = true;

		// Token: 0x0401F7D6 RID: 128982
		private bool TagVisible = true;

		// Token: 0x0401F7D7 RID: 128983
		private bool SkillAnimVisible = true;

		// Token: 0x0401F7D8 RID: 128984
		private BehaviorCommonButton? ButtonConfig;

		// Token: 0x0401F7D9 RID: 128985
		private bool IsClicked;

		// Token: 0x0401F7DA RID: 128986
		private string SkillIconPath;

		// Token: 0x0401F7DB RID: 128987
		private int SetTextureHandleId;

		// Token: 0x0401F7DC RID: 128988
		private bool IsLoadingSkillIcon;

		// Token: 0x0401F7DD RID: 128989
		private bool IsInScreen;

		// Token: 0x0401F7DE RID: 128990
		private EntityHandle TempMonsterEntityHandle;

		// Token: 0x0401F7DF RID: 128991
		private FName? TempTargetSocket;

		// Token: 0x0401F7E0 RID: 128992
		private TimerHandle InteractionShowTimer;

		// Token: 0x0401F7E1 RID: 128993
		private bool CurVisible;

		// Token: 0x0401F7E2 RID: 128994
		private bool TargetVisible;

		// Token: 0x0401F7E3 RID: 128995
		private TimerHandle NextTick;

		// Token: 0x0401F7E4 RID: 128996
		private TimerHandle Timer;

		// Token: 0x0401F7E5 RID: 128997
		private bool DistanceValid;

		// Token: 0x0401F7E6 RID: 128998
		private float InteractionShowDelay;

		// Token: 0x0401F7E7 RID: 128999
		private float HorizontalDistance;

		// Token: 0x0401F7E8 RID: 129000
		private float UpDistance;

		// Token: 0x0401F7E9 RID: 129001
		private float DownDistance;

		// Token: 0x0401F7EA RID: 129002
		private bool LogicVisible;

		// Token: 0x0200BF9B RID: 49051
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039CEE RID: 236782
			SkillButton,
			// Token: 0x04039CEF RID: 236783
			TexIcon
		}

		// Token: 0x0200BF9C RID: 49052
		[NullableContext(0)]
		private enum EDesktopType
		{
			// Token: 0x04039CF1 RID: 236785
			KeyItem
		}
	}
}
