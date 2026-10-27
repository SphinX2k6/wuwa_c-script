using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200584B RID: 22603
	public static class LongPressInteractRestrictSwordRider
	{
		// Token: 0x06039764 RID: 235364 RVA: 0x00DA4158 File Offset: 0x00DA2358
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static LongPressInteractRestrictSwordRider()
		{
			int num = 3;
			List<EBattleUiChild> list = new List<EBattleUiChild>(num);
			CollectionsMarshal.SetCount<EBattleUiChild>(list, num);
			Span<EBattleUiChild> span = CollectionsMarshal.AsSpan<EBattleUiChild>(list);
			int num2 = 0;
			*span[num2] = EBattleUiChild.SkillButton;
			num2++;
			*span[num2] = EBattleUiChild.GamepadSkillButton;
			num2++;
			*span[num2] = EBattleUiChild.MotorcycleMobileSkillButton;
			LongPressInteractRestrictSwordRider.swordRiderHiddenSkillButtons = list;
			num2 = 10;
			List<EInputAction> list2 = new List<EInputAction>(num2);
			CollectionsMarshal.SetCount<EInputAction>(list2, num2);
			Span<EInputAction> span2 = CollectionsMarshal.AsSpan<EInputAction>(list2);
			num = 0;
			*span2[num] = EInputAction.跳跃;
			num++;
			*span2[num] = EInputAction.攀爬;
			num++;
			*span2[num] = EInputAction.攻击;
			num++;
			*span2[num] = EInputAction.闪避;
			num++;
			*span2[num] = EInputAction.技能1;
			num++;
			*span2[num] = EInputAction.幻象1;
			num++;
			*span2[num] = EInputAction.大招;
			num++;
			*span2[num] = EInputAction.幻象2;
			num++;
			*span2[num] = EInputAction.锁定目标;
			num++;
			*span2[num] = EInputAction.瞄准;
			LongPressInteractRestrictSwordRider.swordRiderDisabledInputActions = list2;
		}

		// Token: 0x0401E0D7 RID: 123095
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly List<EBattleUiChild> swordRiderHiddenSkillButtons;

		// Token: 0x0401E0D8 RID: 123096
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly List<EInputAction> swordRiderDisabledInputActions;

		// Token: 0x0200BA6D RID: 47725
		public class SwordRiderLongPressRestriction : ILongPressInteractRestriction
		{
			// Token: 0x0604F8A4 RID: 325796 RVA: 0x01548422 File Offset: 0x01546622
			public void Enter(EInputAction? triggerAction)
			{
				this.SetReadyRestrict(triggerAction, true);
			}

			// Token: 0x0604F8A5 RID: 325797 RVA: 0x0154842C File Offset: 0x0154662C
			public void Press(EInputAction? triggerAction)
			{
				if (this.IsPressingRestrictApplied)
				{
					return;
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[LongPress] 御剑长按交互-锁定玩家操作";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("触发键", triggerAction);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				OperationRestrictUtils.Instance.SetOperationRestrictByOption(this.BuildPressingRestrict(triggerAction));
				this.IsPressingRestrictApplied = true;
			}

			// Token: 0x0604F8A6 RID: 325798 RVA: 0x0154848C File Offset: 0x0154668C
			public void Release(EInputAction? triggerAction)
			{
				if (!this.IsPressingRestrictApplied)
				{
					return;
				}
				this.IsPressingRestrictApplied = false;
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "[LongPress] 御剑长按交互-解锁玩家操作";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("触发键", triggerAction);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				OperationRestrictUtils.Instance.SetOperationRestrictEnableAll();
			}

			// Token: 0x0604F8A7 RID: 325799 RVA: 0x015484E2 File Offset: 0x015466E2
			public void Exit(EInputAction? triggerAction)
			{
				if (this.IsPressingRestrictApplied)
				{
					this.IsPressingRestrictApplied = false;
					OperationRestrictUtils.Instance.SetOperationRestrictEnableAll();
				}
				this.SetReadyRestrict(triggerAction, false);
			}

			// Token: 0x0604F8A8 RID: 325800 RVA: 0x01548508 File Offset: 0x01546708
			private void SetReadyRestrict(EInputAction? triggerAction, bool restrict)
			{
				BattleUiModel instance = BattleUiModel.Instance;
				if (instance != null)
				{
					BattleUiChildViewData childViewData = instance.ChildViewData;
					if (childViewData != null)
					{
						childViewData.SetChildrenVisible(EBattleUiVisibleReason.SwordRiderInteract, LongPressInteractRestrictSwordRider.swordRiderHiddenSkillButtons, !restrict, true, 0);
					}
				}
				foreach (EInputAction einputAction in LongPressInteractRestrictSwordRider.swordRiderDisabledInputActions)
				{
					if (!restrict || !(einputAction == triggerAction))
					{
						BattleInputModel instance2 = BattleInputModel.Instance;
						if (instance2 != null)
						{
							instance2.SetInputEnable(einputAction, !restrict, EBattleInputReason.SwordRiderInteract);
						}
					}
				}
			}

			// Token: 0x0604F8A9 RID: 325801 RVA: 0x015485B4 File Offset: 0x015467B4
			[NullableContext(1)]
			private IDisableModulePlayerOperation BuildPressingRestrict(EInputAction? triggerAction)
			{
				return new IDisableModulePlayerOperation
				{
					Type = EPlayerOperationType.DisableModule,
					MoveOption = new IDisableMoveOperation
					{
						Type = EMoveOperationType.Disable,
						Forward = false,
						Back = false,
						Left = false,
						Right = false
					},
					SkillOption = new IDisableSectionalSkillOperation
					{
						Type = ESkillOperationType.DisableSection,
						DisplayMode = new EDisplayModeInSkillOp?(EDisplayModeInSkillOp.Disable),
						DisableBattleSkill = new IDisableBattleSkillOptions
						{
							IsDisablePhantomSkill = new bool?(triggerAction != EInputAction.幻象2),
							IsDisableCharacterSectionalSkill = new IDisableCharacterSectionalSkillOption
							{
								DisableShowClimb = new bool?(triggerAction != EInputAction.攀爬),
								DisableAttack = new bool?(triggerAction != EInputAction.攻击),
								DisableDodge = new bool?(triggerAction != EInputAction.闪避),
								DisableSkill1 = new bool?(triggerAction != EInputAction.技能1),
								DisableUltimateSkill = new bool?(triggerAction != EInputAction.大招),
								DisableExploreInput = new bool?(triggerAction != EInputAction.幻象1),
								DisableLock = new bool?(triggerAction != EInputAction.锁定目标),
								DisableAim = new bool?(triggerAction != EInputAction.瞄准),
								DisableJump = new bool?(triggerAction != EInputAction.跳跃),
								DisableSwitchRole1 = new bool?(triggerAction != EInputAction.切换角色1),
								DisableSwitchRole2 = new bool?(triggerAction != EInputAction.切换角色2),
								DisableSwitchRole3 = new bool?(triggerAction != EInputAction.切换角色3)
							}
						},
						DisableSwitchRole = new bool?(true)
					},
					CameraOption = new IDisableCameraOperation
					{
						Type = ECameraOperationType.Disable
					},
					UiOption = new IDisableUiOperation
					{
						Type = EUiOperationType.Disable
					},
					SceneInteractionOption = new IEnableSceneInteractionOperation
					{
						Type = ESceneInteractionOperationType.Enable
					}
				};
			}

			// Token: 0x040385C2 RID: 230850
			private bool IsPressingRestrictApplied;
		}
	}
}
