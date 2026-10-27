using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.OperationRestrict
{
	// Token: 0x02006AC0 RID: 27328
	[NullableContext(1)]
	[Nullable(0)]
	public class OperationRestrictUtils : Singleton
	{
		// Token: 0x06043E66 RID: 278118 RVA: 0x010A550C File Offset: 0x010A370C
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

		// Token: 0x06043E67 RID: 278119 RVA: 0x010A5554 File Offset: 0x010A3754
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

		// Token: 0x06043E68 RID: 278120 RVA: 0x010A55C0 File Offset: 0x010A37C0
		public void SetOperationRestrictByDisableOption(IDisableAllPlayerOperation option)
		{
			this.SetInputDisableAll();
			this.ClearInputLimitView();
			if (option.DisplayMode.GetValueOrDefault() == EDisplayModeInPlayerOp.HideUi)
			{
				this.SetBattleUiDisableAll(true);
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

		// Token: 0x06043E69 RID: 278121 RVA: 0x010A5650 File Offset: 0x010A3850
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

		// Token: 0x06043E6A RID: 278122 RVA: 0x010A56C8 File Offset: 0x010A38C8
		public void SetInputUnlock()
		{
			LevelEventLockInputState.Instance.Unlock();
		}

		// Token: 0x06043E6B RID: 278123 RVA: 0x010A56D4 File Offset: 0x010A38D4
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

		// Token: 0x06043E6C RID: 278124 RVA: 0x010A5724 File Offset: 0x010A3924
		public void ClearInputLimitView()
		{
			LevelEventLockInputState.Instance.InputLimitEsc = false;
			LevelEventLockInputState.Instance.InputLimitView.Clear();
		}

		// Token: 0x06043E6D RID: 278125 RVA: 0x010A5740 File Offset: 0x010A3940
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

		// Token: 0x06043E6E RID: 278126 RVA: 0x010A5797 File Offset: 0x010A3997
		public void SetInputDisableAll()
		{
			if (!LevelEventLockInputState.Instance.RealLockInput)
			{
				LevelEventLockInputState.Instance.Lock(new List<string>());
				return;
			}
			LevelEventLockInputState.Instance.InputTagNames.Clear();
		}

		// Token: 0x06043E6F RID: 278127 RVA: 0x010A57C4 File Offset: 0x010A39C4
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

		// Token: 0x06043E70 RID: 278128 RVA: 0x010A5823 File Offset: 0x010A3A23
		public bool GetInputEnableByTag(string targetTagName)
		{
			return !LevelEventLockInputState.Instance.RealLockInput || InputTagModifyUtils.Instance.GetIsInputTagEnable(LevelEventLockInputState.Instance.InputTagNames, targetTagName, false);
		}

		// Token: 0x06043E71 RID: 278129 RVA: 0x010A5849 File Offset: 0x010A3A49
		public void SetExploreSkillInputRestrict(bool enable)
		{
			BattleInputModel.Instance.SetInputEnable(AkiClient.Game.Aki.Character.Input.Enum.EInputAction.幻象1, !enable, EBattleInputReason.LevelEvent);
		}

		// Token: 0x06043E72 RID: 278130 RVA: 0x010A5860 File Offset: 0x010A3A60
		public void SetBattleUiEnableAll(bool bLockInput)
		{
			BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.LevelEvent, 1);
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

		// Token: 0x06043E73 RID: 278131 RVA: 0x010A58D4 File Offset: 0x010A3AD4
		public void SetBattleUiDisableAll(bool bLockInput)
		{
			BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.LevelEvent, null, 1);
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

		// Token: 0x06043E74 RID: 278132 RVA: 0x010A5946 File Offset: 0x010A3B46
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

		// Token: 0x06043E75 RID: 278133 RVA: 0x010A5988 File Offset: 0x010A3B88
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

		// Token: 0x06043E76 RID: 278134 RVA: 0x010A5A0C File Offset: 0x010A3C0C
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

		// Token: 0x06043E77 RID: 278135 RVA: 0x010A5A84 File Offset: 0x010A3C84
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
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, hashSet2.ToArray<EBattleUiChild>(), false, true, 1);
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.LevelEvent, hashSet.ToArray<EBattleUiChild>(), true, true, 1);
		}

		// Token: 0x06043E78 RID: 278136 RVA: 0x010A5EA0 File Offset: 0x010A40A0
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

		// Token: 0x17009969 RID: 39273
		// (get) Token: 0x06043E79 RID: 278137 RVA: 0x010A5ED8 File Offset: 0x010A40D8
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

		// Token: 0x06043E7A RID: 278138 RVA: 0x010A5F5D File Offset: 0x010A415D
		public void SetInputBlockRestrict(bool enable)
		{
			LevelEventLockMaskModule.SetLockMask(enable);
		}

		// Token: 0x06043E7B RID: 278139 RVA: 0x010A5F65 File Offset: 0x010A4165
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

		// Token: 0x06043E7C RID: 278140 RVA: 0x010A5F88 File Offset: 0x010A4188
		public void SetMoveEnableAll()
		{
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"], false);
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"], false);
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"], false);
		}

		// Token: 0x06043E7D RID: 278141 RVA: 0x010A5FE5 File Offset: 0x010A41E5
		public void SetMoveDisableAll()
		{
			InputController.Instance.SetMoveControlEnabled(false, false, false, false);
		}

		// Token: 0x06043E7E RID: 278142 RVA: 0x010A5FF5 File Offset: 0x010A41F5
		public void SetSwitchTeamRoleRestrict(bool enable)
		{
			this.SetPlayerRestrictTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"], enable);
		}

		// Token: 0x06043E7F RID: 278143 RVA: 0x010A6010 File Offset: 0x010A4210
		public void SetMoveRestrictByDisableMoveOption(IDisableMoveOperation moveOption)
		{
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"], moveOption.ForbidSprint.GetValueOrDefault());
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制行走"], moveOption.ForceWalk.GetValueOrDefault());
			this.SetMoveRestrictTag(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.强制慢跑"], !moveOption.ForceWalk.GetValueOrDefault() && moveOption.ForceJog.GetValueOrDefault());
			InputController.Instance.SetMoveControlEnabled(moveOption.Forward, moveOption.Back, moveOption.Left, moveOption.Right);
		}

		// Token: 0x06043E80 RID: 278144 RVA: 0x010A60BB File Offset: 0x010A42BB
		private void SetMoveRestrictTag(int tagId, bool enable)
		{
			this.SetPlayerRestrictTag(tagId, enable);
		}

		// Token: 0x06043E81 RID: 278145 RVA: 0x010A60C8 File Offset: 0x010A42C8
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

		// Token: 0x06043E82 RID: 278146 RVA: 0x010A618F File Offset: 0x010A438F
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

		// Token: 0x06043E83 RID: 278147 RVA: 0x010A61AC File Offset: 0x010A43AC
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

		// Token: 0x06043E84 RID: 278148 RVA: 0x010A61CF File Offset: 0x010A43CF
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

		// Token: 0x06043E85 RID: 278149 RVA: 0x010A61F2 File Offset: 0x010A43F2
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

		// Token: 0x06043E86 RID: 278150 RVA: 0x010A622C File Offset: 0x010A442C
		public void SetCameraEnable()
		{
			this.SetInputRestrictByTag("FightInputRoot.FightInput.AxisInput.CameraInput", true);
		}

		// Token: 0x06043E87 RID: 278151 RVA: 0x010A623A File Offset: 0x010A443A
		public void SetCameraDisable()
		{
			this.SetInputRestrictByTag("FightInputRoot.FightInput.AxisInput.CameraInput", false);
		}

		// Token: 0x06043E88 RID: 278152 RVA: 0x010A6248 File Offset: 0x010A4448
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

		// Token: 0x06043E89 RID: 278153 RVA: 0x010A6290 File Offset: 0x010A4490
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

		// Token: 0x06043E8A RID: 278154 RVA: 0x010A62E4 File Offset: 0x010A44E4
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

		// Token: 0x06043E8B RID: 278155 RVA: 0x010A6360 File Offset: 0x010A4560
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

		// Token: 0x06043E8C RID: 278156 RVA: 0x010A63CC File Offset: 0x010A45CC
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

		// Token: 0x06043E8D RID: 278157 RVA: 0x010A64E0 File Offset: 0x010A46E0
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

		// Token: 0x06043E8E RID: 278158 RVA: 0x010A678C File Offset: 0x010A498C
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

		// Token: 0x1700996A RID: 39274
		// (get) Token: 0x06043E8F RID: 278159 RVA: 0x010A68BE File Offset: 0x010A4ABE
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

		// Token: 0x06043E90 RID: 278160 RVA: 0x010A68E1 File Offset: 0x010A4AE1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043E91 RID: 278161 RVA: 0x010A68E3 File Offset: 0x010A4AE3
		public static void ResetStaticDefaultValue()
		{
			OperationRestrictUtils instance = OperationRestrictUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			OperationRestrictUtils._instance = null;
		}

		// Token: 0x06043E92 RID: 278162 RVA: 0x010A68FC File Offset: 0x010A4AFC
		static OperationRestrictUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(OperationRestrictUtils.CreateStaticDefaultValue), new Action(OperationRestrictUtils.ResetStaticDefaultValue));
		}

		// Token: 0x040237CA RID: 145354
		private readonly EBattleUiChild[] SkillButtonUiChildTypeList = new EBattleUiChild[]
		{
			EBattleUiChild.SkillButton,
			EBattleUiChild.GamepadSkillButton,
			EBattleUiChild.MotorcycleMobileSkillButton
		};

		// Token: 0x040237CB RID: 145355
		[Nullable(2)]
		private EBattleUiChild[] BattleUiChildrenControlledByUiOptionCache;

		// Token: 0x040237CC RID: 145356
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

		// Token: 0x040237CD RID: 145357
		[Nullable(2)]
		private static OperationRestrictUtils _instance;
	}
}
