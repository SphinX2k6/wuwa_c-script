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
	// Token: 0x02004D00 RID: 19712
	[NullableContext(2)]
	[Nullable(0)]
	public class BreakWeaknessPanel : UiPanelBase
	{
		// Token: 0x06031615 RID: 202261 RVA: 0x00DCD43C File Offset: 0x00DCB63C
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

		// Token: 0x06031616 RID: 202262 RVA: 0x00DCD518 File Offset: 0x00DCB718
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

		// Token: 0x06031617 RID: 202263 RVA: 0x00DCD56C File Offset: 0x00DCB76C
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

		// Token: 0x06031618 RID: 202264 RVA: 0x00DCD660 File Offset: 0x00DCB860
		protected override UniTask OnBeforeStartAsync()
		{
			BreakWeaknessPanel.<OnBeforeStartAsync>d__46 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BreakWeaknessPanel.<OnBeforeStartAsync>d__46>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031619 RID: 202265 RVA: 0x00DCD6A4 File Offset: 0x00DCB8A4
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

		// Token: 0x0603161A RID: 202266 RVA: 0x00DCD6E7 File Offset: 0x00DCB8E7
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TexIcon = base.GetTexture(1);
			if (this.TagComponent != null)
			{
				this.OnDisableTagChanged(0, false);
			}
		}

		// Token: 0x0603161B RID: 202267 RVA: 0x00DCD718 File Offset: 0x00DCB918
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

		// Token: 0x0603161C RID: 202268 RVA: 0x00DCD766 File Offset: 0x00DCB966
		protected override void OnAfterHide()
		{
			this.TempMonsterEntityHandle = null;
			this.TempTargetSocket = null;
		}

		// Token: 0x0603161D RID: 202269 RVA: 0x00DCD77C File Offset: 0x00DCB97C
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

		// Token: 0x0603161E RID: 202270 RVA: 0x00DCD7FC File Offset: 0x00DCB9FC
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

		// Token: 0x0603161F RID: 202271 RVA: 0x00DCD8B4 File Offset: 0x00DCBAB4
		protected override UniTask OnBeforeHideAsync()
		{
			BreakWeaknessPanel.<OnBeforeHideAsync>d__53 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<BreakWeaknessPanel.<OnBeforeHideAsync>d__53>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031620 RID: 202272 RVA: 0x00DCD8F7 File Offset: 0x00DCBAF7
		private void OnCloseAnimTimerEnd(float _)
		{
			this.CloseTimer = null;
			this.Promise.SetResult();
			this.Promise = null;
		}

		// Token: 0x06031621 RID: 202273 RVA: 0x00DCD914 File Offset: 0x00DCBB14
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

		// Token: 0x06031622 RID: 202274 RVA: 0x00DCD984 File Offset: 0x00DCBB84
		private void AddEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.BindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x06031623 RID: 202275 RVA: 0x00DCD9D4 File Offset: 0x00DCBBD4
		private void RemoveEvents()
		{
			if (!Info.Instance.IsInTouch())
			{
				InputDistributeController.Instance.UnBindAction("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
			this.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleChildVisibleChanged));
		}

		// Token: 0x06031624 RID: 202276 RVA: 0x00DCDA21 File Offset: 0x00DCBC21
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.OnInteract();
			}
		}

		// Token: 0x06031625 RID: 202277 RVA: 0x00DCDA2D File Offset: 0x00DCBC2D
		private void OnClickSkillButton()
		{
			this.OnInteract();
		}

		// Token: 0x06031626 RID: 202278 RVA: 0x00DCDA38 File Offset: 0x00DCBC38
		private unsafe void OnInteract()
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "破弱按钮按下", default(ReadOnlySpan<ValueTuple<string, object>>));
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle == null || !monsterEntityHandle.Valid)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "怪物已销毁，不执行破弱", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.OnRemove();
				return;
			}
			this.RefreshEntityDistanceValid();
			if (!this.DistanceValid)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "破弱距离过远，不执行破弱", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.RefreshVisible();
				return;
			}
			this.RefreshLogicVisible();
			if (!this.IsLogicVisible())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "破弱按钮不可见，不执行破弱";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChildVisible", this.ChildVisible);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagVisible", this.TagVisible);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SkillAnimVisible", this.SkillAnimVisible);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			PawnInteractBaseComponent component = this.MonsterEntityHandle.Entity.GetComponent<PawnInteractBaseComponent>();
			if (component == null || !component.IsPawnInteractive())
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "怪物不可交互，不执行破弱", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "开始执行破弱交互", default(ReadOnlySpan<ValueTuple<string, object>>));
			component.InteractPawn(-1, null);
			this.IsClicked = true;
		}

		// Token: 0x06031627 RID: 202279 RVA: 0x00DCDBD2 File Offset: 0x00DCBDD2
		private void OnBattleChildVisibleChanged()
		{
			this.ChildVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			this.RefreshVisible();
		}

		// Token: 0x06031628 RID: 202280 RVA: 0x00DCDBF0 File Offset: 0x00DCBDF0
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

		// Token: 0x06031629 RID: 202281 RVA: 0x00DCDC5A File Offset: 0x00DCBE5A
		public void HideByEntity(int entityId)
		{
			EntityHandle monsterEntityHandle = this.MonsterEntityHandle;
			if (monsterEntityHandle == null || monsterEntityHandle.Id != entityId)
			{
				return;
			}
			this.OnRemove();
		}

		// Token: 0x0603162A RID: 202282 RVA: 0x00DCDC7D File Offset: 0x00DCBE7D
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

		// Token: 0x0603162B RID: 202283 RVA: 0x00DCDCA0 File Offset: 0x00DCBEA0
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

		// Token: 0x0603162C RID: 202284 RVA: 0x00DCDD1E File Offset: 0x00DCBF1E
		private void OnAdd()
		{
			this.RefreshEntityDistanceValid();
			this.RefreshPlayerEntity();
			this.AddTimer();
			this.RemoveInteractionShowTimer(false);
			BattleUiModel.Instance.SetExecutionInteractEnable(true);
			BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, false, true, 0);
		}

		// Token: 0x0603162D RID: 202285 RVA: 0x00DCDD5C File Offset: 0x00DCBF5C
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

		// Token: 0x0603162E RID: 202286 RVA: 0x00DCDE04 File Offset: 0x00DCC004
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

		// Token: 0x0603162F RID: 202287 RVA: 0x00DCDEF1 File Offset: 0x00DCC0F1
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

		// Token: 0x06031630 RID: 202288 RVA: 0x00DCDF31 File Offset: 0x00DCC131
		[NullableContext(1)]
		private void OnRemoveEntity(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
		{
			this.OnRemove();
		}

		// Token: 0x06031631 RID: 202289 RVA: 0x00DCDF3C File Offset: 0x00DCC13C
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

		// Token: 0x06031632 RID: 202290 RVA: 0x00DCDF98 File Offset: 0x00DCC198
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

		// Token: 0x06031633 RID: 202291 RVA: 0x00DCE004 File Offset: 0x00DCC204
		private void OnSkillAnimTagChanged(int tagId, bool tagExist)
		{
			this.RefreshSkillAnimVisible();
		}

		// Token: 0x06031634 RID: 202292 RVA: 0x00DCE00C File Offset: 0x00DCC20C
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

		// Token: 0x06031635 RID: 202293 RVA: 0x00DCE089 File Offset: 0x00DCC289
		private void AddCharAnimBreakPointListener()
		{
			if (this.IsListeningCharAnimBreakPoint)
			{
				return;
			}
			EventSystem.Instance.Add<int>(EEventName.CharAnimBreakPoint, new Action<int>(this.OnCharAnimBreakPoint));
			this.IsListeningCharAnimBreakPoint = true;
		}

		// Token: 0x06031636 RID: 202294 RVA: 0x00DCE0B4 File Offset: 0x00DCC2B4
		private void RemoveCharAnimBreakPointListener()
		{
			if (!this.IsListeningCharAnimBreakPoint)
			{
				return;
			}
			EventSystem.Instance.Remove<int>(EEventName.CharAnimBreakPoint, new Action<int>(this.OnCharAnimBreakPoint));
			this.IsListeningCharAnimBreakPoint = false;
		}

		// Token: 0x06031637 RID: 202295 RVA: 0x00DCE0DF File Offset: 0x00DCC2DF
		private void OnCharAnimBreakPoint(int charId)
		{
			this.RefreshSkillAnimVisible();
		}

		// Token: 0x06031638 RID: 202296 RVA: 0x00DCE0E7 File Offset: 0x00DCC2E7
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

		// Token: 0x06031639 RID: 202297 RVA: 0x00DCE118 File Offset: 0x00DCC318
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

		// Token: 0x0603163A RID: 202298 RVA: 0x00DCE14C File Offset: 0x00DCC34C
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

		// Token: 0x0603163B RID: 202299 RVA: 0x00DCE1B8 File Offset: 0x00DCC3B8
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

		// Token: 0x0603163C RID: 202300 RVA: 0x00DCE228 File Offset: 0x00DCC428
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

		// Token: 0x0603163D RID: 202301 RVA: 0x00DCE2BC File Offset: 0x00DCC4BC
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

		// Token: 0x0603163E RID: 202302 RVA: 0x00DCE364 File Offset: 0x00DCC564
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

		// Token: 0x0603163F RID: 202303 RVA: 0x00DCE3C1 File Offset: 0x00DCC5C1
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

		// Token: 0x06031640 RID: 202304 RVA: 0x00DCE3E5 File Offset: 0x00DCC5E5
		private void AddNextTick()
		{
			if (this.NextTick != null)
			{
				return;
			}
			this.NextTick = TimerSystem.Instance.Next(new TTimerAction(this.OnNextTick), null, null);
		}

		// Token: 0x06031641 RID: 202305 RVA: 0x00DCE40E File Offset: 0x00DCC60E
		private void RemoveNextTick()
		{
			if (this.NextTick == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.NextTick);
			this.NextTick = null;
		}

		// Token: 0x06031642 RID: 202306 RVA: 0x00DCE434 File Offset: 0x00DCC634
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

		// Token: 0x06031643 RID: 202307 RVA: 0x00DCE4AB File Offset: 0x00DCC6AB
		private void AddTimer()
		{
			if (this.Timer != null)
			{
				return;
			}
			this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimer), 200f, 1f, null, null, true);
		}

		// Token: 0x06031644 RID: 202308 RVA: 0x00DCE4DF File Offset: 0x00DCC6DF
		private void RemoveTimer()
		{
			if (this.Timer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}

		// Token: 0x06031645 RID: 202309 RVA: 0x00DCE502 File Offset: 0x00DCC702
		private void OnTimer(float _)
		{
			bool distanceValid = this.DistanceValid;
			this.RefreshEntityDistanceValid();
			if (distanceValid != this.DistanceValid)
			{
				this.RefreshVisible();
			}
		}

		// Token: 0x06031646 RID: 202310 RVA: 0x00DCE520 File Offset: 0x00DCC720
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

		// Token: 0x06031647 RID: 202311 RVA: 0x00DCE61F File Offset: 0x00DCC81F
		private bool IsLogicVisible()
		{
			return this.LogicVisible;
		}

		// Token: 0x06031648 RID: 202312 RVA: 0x00DCE627 File Offset: 0x00DCC827
		private bool CameraSeqVisible()
		{
			return this.ChildViewData.GetVisibleByReason(EBattleUiChild.BattleHud, EBattleUiVisibleReason.CameraSeq);
		}

		// Token: 0x06031649 RID: 202313 RVA: 0x00DCE638 File Offset: 0x00DCC838
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

		// Token: 0x0603164A RID: 202314 RVA: 0x00DCE6AD File Offset: 0x00DCC8AD
		private void AddInteractionShowTimer()
		{
			this.RemoveInteractionShowTimer(false);
			this.InteractionShowTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				BattleUiModel.Instance.ChildViewData.SetChildVisible(EBattleUiVisibleReason.Custom, EBattleUiChild.InteractionHint, true, true, 0);
				this.InteractionShowTimer = null;
			}, this.InteractionShowDelay, null, null, true, 1f);
		}

		// Token: 0x0603164B RID: 202315 RVA: 0x00DCE6E0 File Offset: 0x00DCC8E0
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

		// Token: 0x0401A27B RID: 107131
		private const float CLOSE_ANIM_TIME = 300f;

		// Token: 0x0401A27C RID: 107132
		private const EBattleUiChild ChildType = EBattleUiChild.BattleHud;

		// Token: 0x0401A27D RID: 107133
		private static readonly int ultimateTag = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"];

		// Token: 0x0401A27E RID: 107134
		private static readonly int qteTag = GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.QTE"];

		// Token: 0x0401A27F RID: 107135
		private readonly FName hitCaseSocket = new FName("HitCase");

		// Token: 0x0401A280 RID: 107136
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A281 RID: 107137
		[Nullable(1)]
		private readonly Vector2D ScreenPos = new Vector2D();

		// Token: 0x0401A282 RID: 107138
		private EntityHandle MonsterEntityHandle;

		// Token: 0x0401A283 RID: 107139
		private int LastMonsterEntityId;

		// Token: 0x0401A284 RID: 107140
		private MonsterWeaknessComponent MonsterWeaknessComp;

		// Token: 0x0401A285 RID: 107141
		private BaseTagComponent TagComponent;

		// Token: 0x0401A286 RID: 107142
		private BaseSkillComponent SkillComponent;

		// Token: 0x0401A287 RID: 107143
		[Nullable(1)]
		private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

		// Token: 0x0401A288 RID: 107144
		private bool IsListeningCharAnimBreakPoint;

		// Token: 0x0401A289 RID: 107145
		private UUITexture TexIcon;

		// Token: 0x0401A28A RID: 107146
		private InputMultiKeyItem KeyItem;

		// Token: 0x0401A28B RID: 107147
		private TimerHandle CloseTimer;

		// Token: 0x0401A28C RID: 107148
		private CustomPromise Promise;

		// Token: 0x0401A28D RID: 107149
		private BattleUiChildViewData ChildViewData;

		// Token: 0x0401A28E RID: 107150
		private bool ChildVisible = true;

		// Token: 0x0401A28F RID: 107151
		private bool TagVisible = true;

		// Token: 0x0401A290 RID: 107152
		private bool SkillAnimVisible = true;

		// Token: 0x0401A291 RID: 107153
		private BehaviorCommonButton? ButtonConfig;

		// Token: 0x0401A292 RID: 107154
		private bool IsClicked;

		// Token: 0x0401A293 RID: 107155
		private string SkillIconPath;

		// Token: 0x0401A294 RID: 107156
		private int SetTextureHandleId;

		// Token: 0x0401A295 RID: 107157
		private bool IsLoadingSkillIcon;

		// Token: 0x0401A296 RID: 107158
		private bool IsInScreen;

		// Token: 0x0401A297 RID: 107159
		private EntityHandle TempMonsterEntityHandle;

		// Token: 0x0401A298 RID: 107160
		private FName? TempTargetSocket;

		// Token: 0x0401A299 RID: 107161
		private TimerHandle InteractionShowTimer;

		// Token: 0x0401A29A RID: 107162
		private bool CurVisible;

		// Token: 0x0401A29B RID: 107163
		private bool TargetVisible;

		// Token: 0x0401A29C RID: 107164
		private TimerHandle NextTick;

		// Token: 0x0401A29D RID: 107165
		private TimerHandle Timer;

		// Token: 0x0401A29E RID: 107166
		private bool DistanceValid;

		// Token: 0x0401A29F RID: 107167
		private float InteractionShowDelay;

		// Token: 0x0401A2A0 RID: 107168
		private float HorizontalDistance;

		// Token: 0x0401A2A1 RID: 107169
		private float UpDistance;

		// Token: 0x0401A2A2 RID: 107170
		private float DownDistance;

		// Token: 0x0401A2A3 RID: 107171
		private bool LogicVisible;

		// Token: 0x0200A9A1 RID: 43425
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040346B0 RID: 214704
			SkillButton,
			// Token: 0x040346B1 RID: 214705
			TexIcon
		}

		// Token: 0x0200A9A2 RID: 43426
		[NullableContext(0)]
		private enum EDesktopType
		{
			// Token: 0x040346B3 RID: 214707
			KeyItem
		}
	}
}
