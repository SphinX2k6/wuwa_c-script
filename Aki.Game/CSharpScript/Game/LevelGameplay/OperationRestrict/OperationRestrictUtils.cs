using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.OperationRestrict
{
	// Token: 0x02005C38 RID: 23608
	[NullableContext(1)]
	[Nullable(0)]
	public class OperationRestrictUtils : Singleton
	{
		// Token: 0x06039FAD RID: 237485 RVA: 0x0104EB3C File Offset: 0x0104CD3C
		public void SetOperationRestrictByOption(SetPlayerOperationRestriction option)
		{
			switch (option.Type)
			{
			case EPlayerOperationType.EnableAll:
				this.SetOperationRestrictEnableAll();
				return;
			case EPlayerOperationType.DisableAll:
				this.SetOperationRestrictByDisableOption(option as IDisableAllPlayerOperation);
				return;
			case EPlayerOperationType.DisableModule:
				this.SetOperationRestrictByDisableSectionalOption(option as IDisableModulePlayerOperation);
				return;
			default:
				return;
			}
		}

		// Token: 0x06039FAE RID: 237486 RVA: 0x0104EB84 File Offset: 0x0104CD84
		public void SetOperationRestrictEnableAll()
		{
			this.SetInputUnlock();
			this.ClearInputLimitView();
			this.SetBattleUiEnableAll(false);
			this.SetInputBlockRestrict(false);
			this.SetMoveEnableAll();
			this.SetInteractEnable(false);
			this.SetSkillEnableAll();
			InputDistributeController.Instance.RefreshInputTag();
			LevelGamePlayModel.Instance.LevelRestrictOperationBlockAll = false;
			PhoneMsgController.Instance.IsPhoneMsgTipEnable = true;
			EventSystem.Instance.Emit(EEventName.OnNewPhoneMsgNeedShowTips);
		}

		// Token: 0x06039FAF RID: 237487 RVA: 0x0104EBF0 File Offset: 0x0104CDF0
		public void SetOperationRestrictByDisableOption(IDisableAllPlayerOperation option)
		{
			this.SetInputDisableAll();
			this.ClearInputLimitView();
			if (option.DisplayMode.GetValueOrDefault() == EDisplayModeInPlayerOp.HideUi)
			{
				this.SetBattleUiDisableAll(true, option.IsUiFadeEffect.GetValueOrDefault());
			}
			else
			{
				this.SetBattleUiEnableAll(false);
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.BattleView))
			{
				this.SetInputBlockRestrict(true);
			}
			else
			{
				this.SetInputBlockRestrict(false);
			}
			this.SetMoveDisableAll();
			this.SetInteractDisable(true);
			this.SetSkillDisableAll();
			InputDistributeController.Instance.RefreshInputTag();
			LevelGamePlayModel.Instance.LevelRestrictOperationBlockAll = true;
			PhoneMsgController.Instance.IsPhoneMsgTipEnable = false;
		}

		// Token: 0x06039FB0 RID: 237488 RVA: 0x0104EC8C File Offset: 0x0104CE8C
		public void SetOperationRestrictByDisableSectionalOption(IDisableModulePlayerOperation option)
		{
			this.SetInputEnableAll();
			this.SetBattleUiEnableAll(false);
			this.ClearInputLimitView();
			this.SetBattleUiRestrictByUiOption(option.UiOption);
			this.SetInputBlockRestrict(false);
			this.SetMoveRestrictByMoveOption(option.MoveOption);
			this.SetCameraRestrictByCameraOption(option.CameraOption);
			this.SetInteractRestrictByInteractOption(option.SceneInteractionOption);
			this.SetSkillRestrictBySkillOption(option.SkillOption);
			InputDistributeController.Instance.RefreshInputTag();
			LevelGamePlayModel.Instance.LevelRestrictOperationBlockAll = false;
		}

		// Token: 0x06039FB1 RID: 237489 RVA: 0x0104ED04 File Offset: 0x0104CF04
		public void SetInputUnlock()
		{
			LevelEventLockInputState.Instance.Unlock();
		}

		// Token: 0x06039FB2 RID: 237490 RVA: 0x0104ED10 File Offset: 0x0104CF10
		public void SetInputLimitView(EUiViewName viewName, bool enable)
		{
			int num = LevelEventLockInputState.Instance.InputLimitView.IndexOf(viewName);
			bool flag = num != -1;
			if (enable)
			{
				if (!flag)
				{
					LevelEventLockInputState.Instance.InputLimitView.Add(viewName);
					return;
				}
			}
			else if (flag)
			{
				LevelEventLockInputState.Instance.InputLimitView.RemoveAt(num);
			}
		}

		// Token: 0x06039FB3 RID: 237491 RVA: 0x0104ED60 File Offset: 0x0104CF60
		public void ClearInputLimitView()
		{
			LevelEventLockInputState.Instance.InputLimitEsc = false;
			LevelEventLockInputState.Instance.InputLimitView.Clear();
		}

		// Token: 0x06039FB4 RID: 237492 RVA: 0x0104ED7C File Offset: 0x0104CF7C
		public void SetInputEnableAll()
		{
			List<string> list = new List<string>
			{
				"FightInputRoot",
				"UiInputRoot",
				"InteractionRoot"
			};
			if (!LevelEventLockInputState.Instance.RealLockInput)
			{
				LevelEventLockInputState.Instance.Lock(list);
				return;
			}
			LevelEventLockInputState.Instance.InputTagNames = list;
		}

		// Token: 0x06039FB5 RID: 237493 RVA: 0x0104EDD3 File Offset: 0x0104CFD3
		public void SetInputDisableAll()
		{
			if (!LevelEventLockInputState.Instance.RealLockInput)
			{
				LevelEventLockInputState.Instance.Lock(new List<string>());
				return;
			}
			LevelEventLockInputState.Instance.InputTagNames.Clear();
		}

		// Token: 0x06039FB6 RID: 237494 RVA: 0x0104EE00 File Offset: 0x0104D000
		public void SetInputRestrictByTag(string targetTagName, bool enable)
		{
			if (!LevelEventLockInputState.Instance.RealLockInput)
			{
				LevelEventLockInputState.Instance.Lock(new List<string>
				{
					"FightInputRoot",
					"UiInputRoot",
					"InteractionRoot"
				});
			}
			InputTagModifyUtils.Instance.SetEnableInputTag(LevelEventLockInputState.Instance.InputTagNames, targetTagName, enable);
		}

		// Token: 0x06039FB7 RID: 237495 RVA: 0x0104EE5F File Offset: 0x0104D05F
		public bool GetInputEnableByTag(string targetTagName)
		{
			return !LevelEventLockInputState.Instance.RealLockInput || InputTagModifyUtils.Instance.GetIsInputTagEnable(LevelEventLockInputState.Instance.InputTagNames, targetTagName, false);
		}

		// Token: 0x06039FB8 RID: 237496 RVA: 0x0104EE85 File Offset: 0x0104D085
		public void SetExploreSkillInputRestrict(bool enable)
		{
			BattleInputModel.Instance.SetInputEnable(AkiClient.Game.Aki.Character.Input.Enum.EInputAction.幻象1, !enable, EBattleInputReason.LevelEvent);
		}

		// Token: 0x06039FB9 RID: 237497 RVA: 0x0104EE9C File Offset: 0x0104D09C
		public void SetBattleUiEnableAll(bool bLockInput)
		{
			this.SetBattleUiVisibleAsync(true, false).Forget();
			if (bLockInput)
			{
				this.SetInputRestrictByTag("UiInputRoot.ShortcutKeyTag", true);
				LevelEventLockInputState.Instance.InputLimitEsc = false;
				ViewHotKeyHandle[] allViewHotKeyHandle = InputManager.Instance.GetAllViewHotKeyHandle();
				for (int i = 0; i < allViewHotKeyHandle.Length; i++)
				{
					EUiViewName? viewName = allViewHotKeyHandle[i].ViewName;
					if (viewName != null)
					{
						this.SetInputLimitView(viewName.Value, false);
					}
				}
			}
		}

		// Token: 0x06039FBA RID: 237498 RVA: 0x0104EF0C File Offset: 0x0104D10C
		public void SetBattleUiDisableAll(bool bLockInput, bool isUiFadeEffect = false)
		{
			this.SetBattleUiVisibleAsync(false, isUiFadeEffect).Forget();
			if (bLockInput)
			{
				this.SetInputRestrictByTag("UiInputRoot.ShortcutKeyTag", false);
				LevelEventLockInputState.Instance.InputLimitEsc = true;
				ViewHotKeyHandle[] allViewHotKeyHandle = InputManager.Instance.GetAllViewHotKeyHandle();
				for (int i = 0; i < allViewHotKeyHandle.Length; i++)
				{
					EUiViewName? viewName = allViewHotKeyHandle[i].ViewName;
					if (viewName != null)
					{
						this.SetInputLimitView(viewName.Value, true);
					}
				}
			}
		}

		// Token: 0x06039FBB RID: 237499 RVA: 0x0104EF7C File Offset: 0x0104D17C
		private UniTask SetBattleUiVisibleAsync(bool visible, bool isUiFadeEffect = false)
		{
			OperationRestrictUtils.<SetBattleUiVisibleAsync>d__20 <SetBattleUiVisibleAsync>d__;
			<SetBattleUiVisibleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetBattleUiVisibleAsync>d__.<>4__this = this;
			<SetBattleUiVisibleAsync>d__.visible = visible;
			<SetBattleUiVisibleAsync>d__.isUiFadeEffect = isUiFadeEffect;
			<SetBattleUiVisibleAsync>d__.<>1__state = -1;
			<SetBattleUiVisibleAsync>d__.<>t__builder.Start<OperationRestrictUtils.<SetBattleUiVisibleAsync>d__20>(ref <SetBattleUiVisibleAsync>d__);
			return <SetBattleUiVisibleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039FBC RID: 237500 RVA: 0x0104EFCF File Offset: 0x0104D1CF
		[NullableContext(2)]
		public void SetBattleUiRestrictByUiOption(IUiOperationType uiOption)
		{
			if (uiOption != null && uiOption.Type == EUiOperationType.Disable)
			{
				this.SetBattleUiRestrictByDisableUiOption(uiOption as IDisableUiOperation);
				return;
			}
			if (uiOption != null && uiOption.Type == EUiOperationType.EnableSectionalUi)
			{
				this.SetBattleUiRestrictByEnableSectionalUiOption(uiOption as IEnableSectionalUi);
				return;
			}
			this.SetBattleUiRestrictByEnableUiOption(uiOption as IEnableUiOperation);
		}

		// Token: 0x06039FBD RID: 237501 RVA: 0x0104F010 File Offset: 0x0104D210
		[NullableContext(2)]
		public void SetBattleUiRestrictByEnableUiOption(IEnableUiOperation uiOption)
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, this.BattleUiChildrenControlledByUiOption, true, true, 1);
			if (LevelEventLockInputState.Instance.RealLockInput)
			{
				this.SetInputRestrictByTag("UiInputRoot.ShortcutKeyTag", true);
				LevelEventLockInputState.Instance.InputLimitEsc = false;
				ViewHotKeyHandle[] allViewHotKeyHandle = InputManager.Instance.GetAllViewHotKeyHandle();
				for (int i = 0; i < allViewHotKeyHandle.Length; i++)
				{
					EUiViewName? viewName = allViewHotKeyHandle[i].ViewName;
					if (viewName != null)
					{
						this.SetInputLimitView(viewName.Value, false);
					}
				}
			}
		}

		// Token: 0x06039FBE RID: 237502 RVA: 0x0104F094 File Offset: 0x0104D294
		public void SetBattleUiRestrictByDisableUiOption(IDisableUiOperation uiOption)
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, this.BattleUiChildrenControlledByUiOption, false, true, 1);
			this.SetInputRestrictByTag("UiInputRoot.ShortcutKeyTag", false);
			LevelEventLockInputState.Instance.InputLimitEsc = true;
			ViewHotKeyHandle[] allViewHotKeyHandle = InputManager.Instance.GetAllViewHotKeyHandle();
			for (int i = 0; i < allViewHotKeyHandle.Length; i++)
			{
				EUiViewName? viewName = allViewHotKeyHandle[i].ViewName;
				if (viewName != null)
				{
					this.SetInputLimitView(viewName.Value, true);
				}
			}
		}

		// Token: 0x06039FBF RID: 237503 RVA: 0x0104F10C File Offset: 0x0104D30C
		public void SetBattleUiRestrictByEnableSectionalUiOption(IEnableSectionalUi uiOption)
		{
			HashSet<EBattleUiChild> hashSet = new HashSet<EBattleUiChild>();
			HashSet<EBattleUiChild> hashSet2 = new HashSet<EBattleUiChild>();
			if (uiOption.ShowEsc.GetValueOrDefault())
			{
				hashSet.Add(EBattleUiChild.ExitButton);
			}
			else
			{
				hashSet2.Add(EBattleUiChild.ExitButton);
				LevelEventLockInputState.Instance.InputLimitEsc = true;
			}
			if (uiOption.ShowMiniMap.GetValueOrDefault())
			{
				hashSet.Add(EBattleUiChild.MiniMap);
			}
			else
			{
				hashSet2.Add(EBattleUiChild.MiniMap);
				this.SetInputLimitView(EUiViewName.WorldMapView, true);
			}
			if (uiOption.ShowQuestTrack.GetValueOrDefault())
			{
				hashSet.Add(EBattleUiChild.Mission);
				hashSet.Add(EBattleUiChild.BattleHud);
			}
			else
			{
				hashSet2.Add(EBattleUiChild.Mission);
				hashSet2.Add(EBattleUiChild.BattleHud);
			}
			if (uiOption.ShowScreenEffect.GetValueOrDefault())
			{
				hashSet.Add(EBattleUiChild.ScreenEffect);
			}
			else
			{
				hashSet2.Add(EBattleUiChild.ScreenEffect);
			}
			if (uiOption.ShowPositionOfficial.GetValueOrDefault())
			{
				hashSet.Add(EBattleUiChild.PositionOfficial);
			}
			else
			{
				hashSet2.Add(EBattleUiChild.PositionOfficial);
			}
			if (uiOption.ShowSystem.GetValueOrDefault())
			{
				hashSet.Add(EBattleUiChild.TopButton);
				hashSet.Add(EBattleUiChild.HomeButton);
				hashSet.Add(EBattleUiChild.Chat);
			}
			else
			{
				hashSet2.Add(EBattleUiChild.TopButton);
				hashSet2.Add(EBattleUiChild.HomeButton);
				hashSet2.Add(EBattleUiChild.Chat);
				ViewHotKeyHandle[] allViewHotKeyHandle = InputManager.Instance.GetAllViewHotKeyHandle();
				for (int i = 0; i < allViewHotKeyHandle.Length; i++)
				{
					EUiViewName? viewName = allViewHotKeyHandle[i].ViewName;
					if (viewName != null && viewName != EUiViewName.WorldMapView)
					{
						this.SetInputLimitView(viewName.Value, true);
					}
				}
			}
			if (uiOption.ShowOther.GetValueOrDefault())
			{
				foreach (EBattleUiChild item in this.BattleUiChildrenControlledByUiOption)
				{
					if (!hashSet2.Contains(item) && !hashSet.Contains(item))
					{
						hashSet.Add(item);
					}
				}
			}
			else
			{
				bool? showOther = uiOption.ShowOther;
				bool flag = false;
				if (showOther.GetValueOrDefault() == flag & showOther != null)
				{
					foreach (EBattleUiChild item2 in this.BattleUiChildrenControlledByUiOption)
					{
						if (!hashSet2.Contains(item2) && !hashSet.Contains(item2))
						{
							hashSet2.Add(item2);
						}
					}
					hashSet2.Add(EBattleUiChild.GuideTipsView);
				}
				else
				{
					if (uiOption.ShowRoleFormation.GetValueOrDefault())
					{
						hashSet.Add(EBattleUiChild.Formation);
						hashSet.Add(EBattleUiChild.GamepadFormation);
					}
					else
					{
						hashSet2.Add(EBattleUiChild.Formation);
						hashSet2.Add(EBattleUiChild.GamepadFormation);
					}
					if (uiOption.ShowRoleStatus.GetValueOrDefault())
					{
						hashSet.Add(EBattleUiChild.RoleState);
					}
					else
					{
						hashSet2.Add(EBattleUiChild.RoleState);
					}
					if (uiOption.ShowBossStatus.GetValueOrDefault())
					{
						hashSet.Add(EBattleUiChild.BossState);
					}
					else
					{
						hashSet2.Add(EBattleUiChild.BossState);
					}
					if (uiOption.ShowMonsterHpBar.GetValueOrDefault())
					{
						hashSet.Add(EBattleUiChild.HeadState);
						hashSet.Add(EBattleUiChild.PartState);
					}
					else
					{
						hashSet2.Add(EBattleUiChild.HeadState);
						hashSet2.Add(EBattleUiChild.PartState);
					}
					if (uiOption.ShowDamageText.GetValueOrDefault())
					{
						hashSet.Add(EBattleUiChild.DamageView);
					}
					else
					{
						hashSet2.Add(EBattleUiChild.DamageView);
					}
					if (uiOption.ShowGuideLayer.GetValueOrDefault())
					{
						hashSet.Add(EBattleUiChild.GuideTipsView);
					}
					else
					{
						hashSet2.Add(EBattleUiChild.GuideTipsView);
					}
					foreach (EBattleUiChild item3 in this.BattleUiChildrenControlledByUiOption)
					{
						if (!hashSet2.Contains(item3) && !hashSet.Contains(item3))
						{
							hashSet2.Add(item3);
						}
					}
				}
			}
			if (uiOption.AlwaysShowUiSections != null)
			{
				using (List<EUiElement>.Enumerator enumerator = uiOption.AlwaysShowUiSections.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == EUiElement.Guide)
						{
							hashSet2.Remove(EBattleUiChild.GuideTipsView);
							hashSet.Add(EBattleUiChild.GuideTipsView);
						}
					}
				}
			}
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, hashSet2, false, true, 1);
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, hashSet, true, true, 1);
		}

		// Token: 0x06039FC0 RID: 237504 RVA: 0x0104F520 File Offset: 0x0104D720
		[NullableContext(2)]
		public void SetBattleUiRestrictByUiChildType(EBattleUiChild[] uiShow, EBattleUiChild[] uiHide)
		{
			if (uiHide != null && uiHide.Length != 0)
			{
				BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, uiHide, false, true, 1);
			}
			if (uiShow != null && uiShow.Length != 0)
			{
				BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, uiShow, true, true, 1);
			}
		}

		// Token: 0x17006E6C RID: 28268
		// (get) Token: 0x06039FC1 RID: 237505 RVA: 0x0104F558 File Offset: 0x0104D758
		private EBattleUiChild[] BattleUiChildrenControlledByUiOption
		{
			get
			{
				if (this.BattleUiChildrenControlledByUiOptionCache != null)
				{
					return this.BattleUiChildrenControlledByUiOptionCache;
				}
				this.BattleUiChildrenControlledByUiOptionCache = new List<EBattleUiChild>().ToArray();
				List<EBattleUiChild> list = new List<EBattleUiChild>();
				for (int i = 0; i < 46; i++)
				{
					if (i != 12 && i != 18 && i != 19 && i != 9 && i != 10 && i != 39 && i != 40 && i != 20 && i != 21)
					{
						list.Add((EBattleUiChild)i);
					}
				}
				this.BattleUiChildrenControlledByUiOptionCache = list.ToArray();
				return this.BattleUiChildrenControlledByUiOptionCache;
			}
		}

		// Token: 0x06039FC2 RID: 237506 RVA: 0x0104F5DD File Offset: 0x0104D7DD
		public void SetInputBlockRestrict(bool enable)
		{
			LevelEventLockMaskModule.SetLockMask(enable);
		}

		// Token: 0x06039FC3 RID: 237507 RVA: 0x0104F5E5 File Offset: 0x0104D7E5
		[NullableContext(2)]
		public void SetMoveRestrictByMoveOption(IMoveOperationType moveOption)
		{
			if (moveOption != null && moveOption.Type == EMoveOperationType.Disable)
			{
				this.SetMoveRestrictByDisableMoveOption((IDisableMoveOperation)moveOption);
				return;
			}
			this.SetMoveEnableAll();
		}

		// Token: 0x06039FC4 RID: 237508 RVA: 0x0104F608 File Offset: 0x0104D808
		public void SetMoveEnableAll()
		{
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"], false);
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"], false);
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"], false);
		}

		// Token: 0x06039FC5 RID: 237509 RVA: 0x0104F665 File Offset: 0x0104D865
		public void SetMoveDisableAll()
		{
			InputController.Instance.SetMoveControlEnabled(false, false, false, false);
		}

		// Token: 0x06039FC6 RID: 237510 RVA: 0x0104F675 File Offset: 0x0104D875
		public void SetSwitchTeamRoleRestrict(bool enable)
		{
			this.SetPlayerRestrictTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"], enable);
		}

		// Token: 0x06039FC7 RID: 237511 RVA: 0x0104F690 File Offset: 0x0104D890
		public void SetMoveRestrictByDisableMoveOption(IDisableMoveOperation moveOption)
		{
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"], moveOption.ForbidSprint.GetValueOrDefault());
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"], moveOption.ForceWalk.GetValueOrDefault());
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"], !moveOption.ForceWalk.GetValueOrDefault() && moveOption.ForceJog.GetValueOrDefault());
			InputController.Instance.SetMoveControlEnabled(moveOption.Forward, moveOption.Back, moveOption.Left, moveOption.Right);
		}

		// Token: 0x06039FC8 RID: 237512 RVA: 0x0104F73B File Offset: 0x0104D93B
		private void SetMoveRestrictTag(int tagId, bool enable)
		{
			this.SetPlayerRestrictTag(tagId, enable);
		}

		// Token: 0x06039FC9 RID: 237513 RVA: 0x0104F748 File Offset: 0x0104D948
		private unsafe void SetPlayerRestrictTag(int tagId, bool enable)
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[OperationRestrictUtils.SetPlayerRestrictTag] 找不到当前玩家";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", playerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagName", GameplayTagUtils.GetNameByTagId(tagId));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (enable)
			{
				if (!FormationDataController.Instance.HasPlayerTag(playerId, tagId, true))
				{
					FormationDataController.Instance.AddPlayerTag(playerId, new int?(tagId));
					return;
				}
			}
			else if (FormationDataController.Instance.HasPlayerTag(playerId, tagId, true))
			{
				FormationDataController.Instance.RemovePlayerTag(playerId, new int?(tagId));
			}
		}

		// Token: 0x06039FCA RID: 237514 RVA: 0x0104F80F File Offset: 0x0104DA0F
		[NullableContext(2)]
		public void SetInteractRestrictByInteractOption(ISceneInteractionOperationType interactOption)
		{
			if (interactOption != null && interactOption.Type == ESceneInteractionOperationType.Disable)
			{
				this.SetInteractDisable(true);
				return;
			}
			this.SetInteractEnable(true);
		}

		// Token: 0x06039FCB RID: 237515 RVA: 0x0104F82C File Offset: 0x0104DA2C
		public void SetInteractEnable(bool bLockInput)
		{
			if (bLockInput)
			{
				this.SetInputRestrictByTag("InteractionRoot", true);
			}
			this.SetBattleUiRestrictByUiChildType(new EBattleUiChild[]
			{
				EBattleUiChild.InteractionHint
			}, null);
		}

		// Token: 0x06039FCC RID: 237516 RVA: 0x0104F84F File Offset: 0x0104DA4F
		public void SetInteractDisable(bool bLockInput)
		{
			if (bLockInput)
			{
				this.SetInputRestrictByTag("InteractionRoot", false);
			}
			this.SetBattleUiRestrictByUiChildType(null, new EBattleUiChild[]
			{
				EBattleUiChild.InteractionHint
			});
		}

		// Token: 0x06039FCD RID: 237517 RVA: 0x0104F872 File Offset: 0x0104DA72
		[NullableContext(2)]
		public void SetCameraRestrictByCameraOption(ICameraOperationType cameraOption)
		{
			if (cameraOption != null && cameraOption.Type == ECameraOperationType.Disable)
			{
				this.SetCameraDisable();
				return;
			}
			if (cameraOption != null && cameraOption.Type == ECameraOperationType.EnableSection)
			{
				this.SetCameraDisable();
				this.SetCameraEnableSection((IEnableSectionalCameraOperation)cameraOption);
				return;
			}
			this.SetCameraEnable();
		}

		// Token: 0x06039FCE RID: 237518 RVA: 0x0104F8AC File Offset: 0x0104DAAC
		public void SetCameraEnable()
		{
			this.SetInputRestrictByTag("FightInputRoot.FightInput.AxisInput.CameraInput", true);
		}

		// Token: 0x06039FCF RID: 237519 RVA: 0x0104F8BA File Offset: 0x0104DABA
		public void SetCameraDisable()
		{
			this.SetInputRestrictByTag("FightInputRoot.FightInput.AxisInput.CameraInput", false);
		}

		// Token: 0x06039FD0 RID: 237520 RVA: 0x0104F8C8 File Offset: 0x0104DAC8
		public void SetCameraEnableSection(IEnableSectionalCameraOperation cameraOption)
		{
			if (cameraOption.EnableRotate.GetValueOrDefault())
			{
				this.SetInputRestrictByTag("FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation", true);
			}
			if (cameraOption.EnableZoom.GetValueOrDefault())
			{
				this.SetInputRestrictByTag("FightInputRoot.FightInput.AxisInput.CameraInput.CameraZoom", true);
			}
		}

		// Token: 0x06039FD1 RID: 237521 RVA: 0x0104F90D File Offset: 0x0104DB0D
		public void SetMiniMapEnable(bool enable)
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, new EBattleUiChild[]
			{
				EBattleUiChild.MiniMap
			}, enable, true, 4);
			OperationRestrictUtils.Instance.SetInputLimitView(EUiViewName.WorldMapView, !enable);
		}

		// Token: 0x06039FD2 RID: 237522 RVA: 0x0104F940 File Offset: 0x0104DB40
		[NullableContext(2)]
		public void SetSkillRestrictBySkillOption(ISkillOperationType skillOption)
		{
			if (skillOption == null || (skillOption != null && skillOption.Type == ESkillOperationType.Enable))
			{
				this.SetSkillEnableAll();
				return;
			}
			if (skillOption != null && skillOption.Type == ESkillOperationType.DisableSection)
			{
				this.SetSkillRestrictByDisableSectionalSkillOption((IDisableSectionalSkillOperation)skillOption);
				return;
			}
			if (skillOption != null && skillOption.Type == ESkillOperationType.Disable)
			{
				this.SetSkillRestrictByDisableSkillOption((IDisableSkillOperation)skillOption);
			}
		}

		// Token: 0x06039FD3 RID: 237523 RVA: 0x0104F994 File Offset: 0x0104DB94
		public void SetSkillEnableAll()
		{
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette, true);
			CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.SetDisabled(false, "SetSkillEnableAll");
			CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.ClearSkillIdRestrictions("SetSkillEnableAll");
			ExploreSkillFlagModel.Instance.EnableAllExploreSkillFlag();
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.TempTeleporterPlacement, true);
			this.SetSwitchTeamRoleRestrict(false);
			this.SetBattleUiRestrictByUiChildType(this.SkillButtonUiChildTypeList, null);
			BattleInputModel.Instance.SetAllInputEnable(true, EBattleInputReason.LevelEvent);
		}

		// Token: 0x06039FD4 RID: 237524 RVA: 0x0104FA10 File Offset: 0x0104DC10
		public void SetSkillDisableAll()
		{
			this.SetInputRestrictByTag("FightInputRoot.FightInput.ActionInput", false);
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette, false);
			CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.SetDisabled(true, "SetSkillDisableAll");
			ExploreSkillFlagModel.Instance.DisableAllExploreSkillFlag();
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.TempTeleporterPlacement, false);
			this.SetBattleUiRestrictByUiChildType(null, this.SkillButtonUiChildTypeList);
			BattleInputModel.Instance.SetAllInputEnable(false, EBattleInputReason.LevelEvent);
		}

		// Token: 0x06039FD5 RID: 237525 RVA: 0x0104FA7C File Offset: 0x0104DC7C
		public void SetSkillRestrictByDisableSkillOption(IDisableSkillOperation skillOption)
		{
			this.SetInputRestrictByTag("FightInputRoot.FightInput.ActionInput", false);
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette, !skillOption.DisableSkillWheel.GetValueOrDefault());
			CharacterExploreModel.Instance.MotorcycleHookDetectRestriction.SetDisabled(true, "SetSkillDisableAll");
			ExploreSkillFlagModel.Instance.DisableAllExploreSkillFlag();
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.TempTeleporterPlacement, false);
			if (skillOption.DisplayMode.GetValueOrDefault() == EDisplayModeInSkillOp.Hide)
			{
				this.SetBattleUiRestrictByUiChildType(null, this.SkillButtonUiChildTypeList);
				BattleInputModel.Instance.SetAllInputEnable(false, EBattleInputReason.LevelEvent);
				return;
			}
			EDisplayModeInSkillOp? displayMode = skillOption.DisplayMode;
			EDisplayModeInSkillOp edisplayModeInSkillOp = EDisplayModeInSkillOp.Ashen;
			if (displayMode.GetValueOrDefault() == edisplayModeInSkillOp & displayMode != null)
			{
				this.SetBattleUiRestrictByUiChildType(this.SkillButtonUiChildTypeList, null);
				BattleInputModel.Instance.SetAllInputEnable(false, EBattleInputReason.LevelEvent);
				return;
			}
			if (skillOption.DisplayMode == null)
			{
				this.SetBattleUiRestrictByUiChildType(this.SkillButtonUiChildTypeList, null);
				BattleInputModel.Instance.SetAllInputEnable(true, EBattleInputReason.LevelEvent);
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[OperationRestrictUtils.SetSkillRestrictByDisableSkillOption] 配置出错";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillOption", skillOption);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06039FD6 RID: 237526 RVA: 0x0104FB90 File Offset: 0x0104DD90
		public void SetSkillRestrictByDisableSectionalSkillOption(IDisableSectionalSkillOperation skillOption)
		{
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette, !skillOption.DisableSkillWheel.GetValueOrDefault());
			IDisableExploreSkill disableExploreSkill = skillOption.DisableExploreSkill;
			List<EExploreSkillType> list = (disableExploreSkill != null) ? disableExploreSkill.ExploreSkillList : null;
			IDisableExploreSkill disableExploreSkill2 = skillOption.DisableExploreSkill;
			bool valueOrDefault = ((disableExploreSkill2 != null) ? disableExploreSkill2.IsComplementary : null).GetValueOrDefault();
			MotorcycleHookDetectRestriction motorcycleHookDetectRestriction = CharacterExploreModel.Instance.MotorcycleHookDetectRestriction;
			string reason = "SetSkillRestrictByDisableSectionalSkillOption";
			motorcycleHookDetectRestriction.SetDisabled(false, reason);
			foreach (EExploreSkillType eexploreSkillType in ExploreSkillFlagDefine.levelOperationRestrictExploreSkillTypes)
			{
				bool flag = list != null && list.Contains(eexploreSkillType);
				bool flag2 = valueOrDefault ? flag : (!flag);
				if (motorcycleHookDetectRestriction.CanHandleSkillId((int)eexploreSkillType))
				{
					motorcycleHookDetectRestriction.SetDisabledBySkillId((int)eexploreSkillType, !flag2, reason);
				}
				else
				{
					ExploreSkillFlagModel.Instance.SetExploreSkillFlagEnable(eexploreSkillType, flag2);
				}
			}
			bool flag3 = list != null && list.Contains(EExploreSkillType.PlaceTemporaryTeleport);
			bool enable = valueOrDefault ? flag3 : (!flag3);
			LevelFuncFlagModel.Instance.SetFuncFlagEnable(ELevelFuncFlagId.TempTeleporterPlacement, enable);
			this.SetSwitchTeamRoleRestrict(skillOption.DisableSwitchRole.GetValueOrDefault());
			HashSet<int> hashSet = new HashSet<int>();
			IDisableBattleSkillOptions disableBattleSkill = skillOption.DisableBattleSkill;
			if (disableBattleSkill != null && disableBattleSkill.IsDisableCharacterSkill.GetValueOrDefault())
			{
				this.AddDisableCharacterSectionalSkillsToSet(new IDisableCharacterSectionalSkillOption
				{
					DisableJump = new bool?(true),
					DisableShowClimb = new bool?(true),
					DisableAttack = new bool?(true),
					DisableDodge = new bool?(true),
					DisableSkill1 = new bool?(true),
					DisableUltimateSkill = new bool?(true),
					DisableSwitchRole1 = new bool?(true),
					DisableSwitchRole2 = new bool?(true),
					DisableSwitchRole3 = new bool?(true),
					DisableLock = new bool?(true),
					DisableAim = new bool?(true)
				}, hashSet);
			}
			IDisableBattleSkillOptions disableBattleSkill2 = skillOption.DisableBattleSkill;
			if (disableBattleSkill2 != null && disableBattleSkill2.IsDisablePhantomSkill.GetValueOrDefault())
			{
				hashSet.Add(9);
			}
			IDisableBattleSkillOptions disableBattleSkill3 = skillOption.DisableBattleSkill;
			if (((disableBattleSkill3 != null) ? disableBattleSkill3.IsDisableCharacterSectionalSkill : null) != null)
			{
				this.AddDisableCharacterSectionalSkillsToSet(skillOption.DisableBattleSkill.IsDisableCharacterSectionalSkill, hashSet);
			}
			if (skillOption.DisplayMode != null && skillOption.DisplayMode.GetValueOrDefault() != EDisplayModeInSkillOp.Disable)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[OperationRestrictUtils.SetSkillRestrictByDisableSectionalSkillOption] 配置出错";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillOption", skillOption);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.SetBattleUiRestrictByUiChildType(this.SkillButtonUiChildTypeList, null);
			if (hashSet.Count <= 0)
			{
				BattleInputModel.Instance.SetAllInputEnable(true, EBattleInputReason.LevelEvent);
				return;
			}
			BattleInputModel.Instance.SetAllInputEnableWithIgnoreSet(true, hashSet, EBattleInputReason.LevelEvent);
		}

		// Token: 0x06039FD7 RID: 237527 RVA: 0x0104FE3C File Offset: 0x0104E03C
		private void AddDisableCharacterSectionalSkillsToSet(IDisableCharacterSectionalSkillOption sectionalSkillOption, HashSet<int> disableInputAction)
		{
			if (sectionalSkillOption.DisableJump.GetValueOrDefault())
			{
				disableInputAction.Add(1);
			}
			if (sectionalSkillOption.DisableShowClimb.GetValueOrDefault())
			{
				disableInputAction.Add(2);
			}
			if (sectionalSkillOption.DisableAttack.GetValueOrDefault())
			{
				disableInputAction.Add(4);
			}
			if (sectionalSkillOption.DisableDodge.GetValueOrDefault())
			{
				disableInputAction.Add(5);
			}
			if (sectionalSkillOption.DisableSkill1.GetValueOrDefault())
			{
				disableInputAction.Add(6);
			}
			if (sectionalSkillOption.DisableUltimateSkill.GetValueOrDefault())
			{
				disableInputAction.Add(8);
			}
			if (sectionalSkillOption.DisableExploreInput.GetValueOrDefault())
			{
				disableInputAction.Add(7);
			}
			if (sectionalSkillOption.DisableSwitchRole1.GetValueOrDefault())
			{
				disableInputAction.Add(10);
			}
			if (sectionalSkillOption.DisableSwitchRole2.GetValueOrDefault())
			{
				disableInputAction.Add(11);
			}
			if (sectionalSkillOption.DisableSwitchRole3.GetValueOrDefault())
			{
				disableInputAction.Add(12);
			}
			if (sectionalSkillOption.DisableLock.GetValueOrDefault())
			{
				disableInputAction.Add(13);
			}
			if (sectionalSkillOption.DisableAim.GetValueOrDefault())
			{
				disableInputAction.Add(14);
			}
		}

		// Token: 0x17006E6D RID: 28269
		// (get) Token: 0x06039FD8 RID: 237528 RVA: 0x0104FF6E File Offset: 0x0104E16E
		public static OperationRestrictUtils Instance
		{
			get
			{
				if (OperationRestrictUtils._instance == null)
				{
					OperationRestrictUtils._instance = new OperationRestrictUtils();
					OperationRestrictUtils._instance.OnInit();
				}
				return OperationRestrictUtils._instance;
			}
		}

		// Token: 0x06039FD9 RID: 237529 RVA: 0x0104FF91 File Offset: 0x0104E191
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039FDA RID: 237530 RVA: 0x0104FF93 File Offset: 0x0104E193
		public static void ResetStaticDefaultValue()
		{
			OperationRestrictUtils instance = OperationRestrictUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			OperationRestrictUtils._instance = null;
		}

		// Token: 0x06039FDB RID: 237531 RVA: 0x0104FFAC File Offset: 0x0104E1AC
		static OperationRestrictUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(OperationRestrictUtils.CreateStaticDefaultValue), new Action(OperationRestrictUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA67 RID: 125543
		private readonly EBattleUiChild[] SkillButtonUiChildTypeList = new EBattleUiChild[]
		{
			EBattleUiChild.SkillButton,
			EBattleUiChild.GamepadSkillButton,
			EBattleUiChild.MotorcycleMobileSkillButton
		};

		// Token: 0x0401EA68 RID: 125544
		[Nullable(2)]
		private EBattleUiChild[] BattleUiChildrenControlledByUiOptionCache;

		// Token: 0x0401EA69 RID: 125545
		private int BattleUiVisibilityRequestId;

		// Token: 0x0401EA6A RID: 125546
		private bool? PendingBattleUiVisible;

		// Token: 0x0401EA6B RID: 125547
		[Nullable(2)]
		private UiBehaviorLevelSequence FadeHiddenBattleViewSequence;

		// Token: 0x0401EA6C RID: 125548
		private readonly ISkillOptionToInputAction[] SkillOptionToInputAction = new ISkillOptionToInputAction[]
		{
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableJump",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.跳跃
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableShowClimb",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.攀爬
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableAttack",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.攻击
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableDodge",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.闪避
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableSkill1",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.技能1
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableUltimateSkill",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.大招
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableExploreInput",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.幻象1
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableSwitchRole1",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.切换角色1
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableSwitchRole2",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.切换角色2
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableSwitchRole3",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.切换角色3
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableLock",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.锁定目标
			},
			new ISkillOptionToInputAction
			{
				OptionKey = "DisableAim",
				InputAction = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.瞄准
			}
		};

		// Token: 0x0401EA6D RID: 125549
		[Nullable(2)]
		private static OperationRestrictUtils _instance;
	}
}
