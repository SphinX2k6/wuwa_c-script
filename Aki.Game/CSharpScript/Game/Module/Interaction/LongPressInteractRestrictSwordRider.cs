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
	// Token: 0x02004823 RID: 18467
	public static class LongPressInteractRestrictSwordRider
	{
		// Token: 0x0602E680 RID: 190080 RVA: 0x00CF2E18 File Offset: 0x00CF1018
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

		// Token: 0x04018B74 RID: 101236
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly List<EBattleUiChild> swordRiderHiddenSkillButtons;

		// Token: 0x04018B75 RID: 101237
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly List<EInputAction> swordRiderDisabledInputActions;

		// Token: 0x0200A484 RID: 42116
		public class SwordRiderLongPressRestriction : ILongPressInteractRestriction
		{
			// Token: 0x06045E32 RID: 286258 RVA: 0x015018C6 File Offset: 0x014FFAC6
			public void Enter(EInputAction? triggerAction)
			{
				this.SetReadyRestrict(triggerAction, true);
			}

			// Token: 0x06045E33 RID: 286259 RVA: 0x015018D0 File Offset: 0x014FFAD0
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

			// Token: 0x06045E34 RID: 286260 RVA: 0x01501930 File Offset: 0x014FFB30
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

			// Token: 0x06045E35 RID: 286261 RVA: 0x01501986 File Offset: 0x014FFB86
			public void Exit(EInputAction? triggerAction)
			{
				if (this.IsPressingRestrictApplied)
				{
					this.IsPressingRestrictApplied = false;
					OperationRestrictUtils.Instance.SetOperationRestrictEnableAll();
				}
				this.SetReadyRestrict(triggerAction, false);
			}

			// Token: 0x06045E36 RID: 286262 RVA: 0x015019AC File Offset: 0x014FFBAC
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

			// Token: 0x06045E37 RID: 286263 RVA: 0x01501A58 File Offset: 0x014FFC58
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

			// Token: 0x04032FBA RID: 208826
			private bool IsPressingRestrictApplied;
		}
	}
}
