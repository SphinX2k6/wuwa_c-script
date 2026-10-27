using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CDF RID: 23775
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillConfigLongPressItem : UiPanelBase
	{
		// Token: 0x0603C290 RID: 246416 RVA: 0x00E66A7C File Offset: 0x00E64C7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C291 RID: 246417 RVA: 0x00E66BD0 File Offset: 0x00E64DD0
		protected override void OnStart()
		{
			this.ProgressTexA = base.GetTexture(0);
			this.ProgressTexA.SetFillAmount(0f);
			this.TweenAnimPlayer.InitTweenAnim(4, base.GetItem(4), false);
			this.SetComponentActive(this.TargetActive);
			this.InputHandler = new BattleSkillInputHandler();
			this.InputHandler.InitCallback(new Action<EInputAction>(this.OnSkillLongPressStart), new Action<EInputAction>(this.OnSkillLongPressEnd));
			if (this.Action != null)
			{
				this.InputHandler.SetActionType(this.Action.Value);
				this.InputHandler.AddActionTypes(this.ExtraActions);
			}
			this.InitBarB();
			this.SetState(BattleSkillConfigLongPressItem.EState.StateA, true);
			this.SetEnableBarB(this.EnableBarB, true);
		}

		// Token: 0x0603C292 RID: 246418 RVA: 0x00E66C97 File Offset: 0x00E64E97
		protected override void OnBeforeShow()
		{
			if (this.InputHandler != null)
			{
				InputController.Instance.AddInputHandler(this.InputHandler);
			}
		}

		// Token: 0x0603C293 RID: 246419 RVA: 0x00E66CB1 File Offset: 0x00E64EB1
		protected override void OnAfterHide()
		{
			if (this.InputHandler != null)
			{
				InputController.Instance.RemoveInputHandler(this.InputHandler);
			}
		}

		// Token: 0x0603C294 RID: 246420 RVA: 0x00E66CCC File Offset: 0x00E64ECC
		public void SetComponentActive(bool visibility)
		{
			if (this.TargetActive == visibility && !this.IsFirstShow)
			{
				return;
			}
			this.TargetActive = visibility;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.IsFirstShow = false;
			this.SetActive(visibility);
			UUITexture progressTexA = this.ProgressTexA;
			if (progressTexA == null)
			{
				return;
			}
			progressTexA.SetFillAmount(0f);
		}

		// Token: 0x0603C295 RID: 246421 RVA: 0x00E66D20 File Offset: 0x00E64F20
		public void SetAction(in EInputAction action)
		{
			if (this.Action == action)
			{
				return;
			}
			this.Action = new EInputAction?(action);
			BattleSkillInputHandler inputHandler = this.InputHandler;
			if (inputHandler != null)
			{
				inputHandler.SetActionType(action);
			}
			BattleSkillInputHandler inputHandler2 = this.InputHandler;
			if (inputHandler2 != null)
			{
				inputHandler2.AddActionTypes(this.ExtraActions);
			}
			this.StopProgressA();
			UUITexture progressTexA = this.ProgressTexA;
			if (progressTexA == null)
			{
				return;
			}
			progressTexA.SetFillAmount(0f);
		}

		// Token: 0x0603C296 RID: 246422 RVA: 0x00E66DB1 File Offset: 0x00E64FB1
		public void SetSharedFxActions(List<EInputAction> actions)
		{
			this.ExtraActions = actions;
			BattleSkillInputHandler inputHandler = this.InputHandler;
			if (inputHandler == null)
			{
				return;
			}
			inputHandler.AddActionTypes(actions);
		}

		// Token: 0x0603C297 RID: 246423 RVA: 0x00E66DCC File Offset: 0x00E64FCC
		private bool IsValidAction(EInputAction action)
		{
			return (this.ExtraActions != null && this.ExtraActions.Contains(action)) || !(this.Action != action);
		}

		// Token: 0x0603C298 RID: 246424 RVA: 0x00E66E18 File Offset: 0x00E65018
		public void SetDuration(float duration)
		{
			this.Duration = duration * (float)TimeUtil.Instance.InverseMillisecond;
		}

		// Token: 0x0603C299 RID: 246425 RVA: 0x00E66E2D File Offset: 0x00E6502D
		private void OnSkillLongPressStart(EInputAction action)
		{
			if (!this.IsValidAction(action))
			{
				return;
			}
			if (this.Duration <= 0f)
			{
				return;
			}
			this.StartProgress();
		}

		// Token: 0x0603C29A RID: 246426 RVA: 0x00E66E4D File Offset: 0x00E6504D
		private void OnSkillLongPressEnd(EInputAction action)
		{
			if (!this.IsValidAction(action))
			{
				return;
			}
			this.StopProgressA();
			UUITexture progressTexA = this.ProgressTexA;
			if (progressTexA == null)
			{
				return;
			}
			progressTexA.SetFillAmount(0f);
		}

		// Token: 0x0603C29B RID: 246427 RVA: 0x00E66E74 File Offset: 0x00E65074
		private void StartProgress()
		{
			this.StartTime = (float)Time.Instance.WorldTime;
		}

		// Token: 0x0603C29C RID: 246428 RVA: 0x00E66E87 File Offset: 0x00E65087
		private void StopProgressA()
		{
			this.StartTime = 0f;
			UUITexture progressTexA = this.ProgressTexA;
			if (progressTexA == null)
			{
				return;
			}
			progressTexA.SetFillAmount(0f);
		}

		// Token: 0x0603C29D RID: 246429 RVA: 0x00E66EAC File Offset: 0x00E650AC
		public void Tick(float delta)
		{
			if (this.CurState != BattleSkillConfigLongPressItem.EState.StateA)
			{
				this.TickProgressB(delta);
				return;
			}
			if (this.StartTime <= 0f || this.Duration <= 0f)
			{
				return;
			}
			float num = (float)Time.Instance.WorldTime - this.StartTime;
			float num2 = Math.Min(1f, num / this.Duration);
			if (num2 == 1f)
			{
				this.StopProgressA();
				return;
			}
			UUITexture progressTexA = this.ProgressTexA;
			if (progressTexA == null)
			{
				return;
			}
			progressTexA.SetFillAmount(num2);
		}

		// Token: 0x0603C29E RID: 246430 RVA: 0x00E66F2C File Offset: 0x00E6512C
		private void SetState(BattleSkillConfigLongPressItem.EState state, bool force = false)
		{
			if (this.CurState == state && !force)
			{
				return;
			}
			bool flag = state == BattleSkillConfigLongPressItem.EState.StateA;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (state == BattleSkillConfigLongPressItem.EState.StateA)
			{
				UUITexture progressTexA = this.ProgressTexA;
				if (progressTexA != null)
				{
					progressTexA.SetFillAmount(0f);
				}
			}
			else
			{
				UUIText text = base.GetText(3);
				if (text != null)
				{
					text.SetText("0", true);
				}
				UUITexture progressTexB = this.ProgressTexB;
				if (progressTexB != null)
				{
					progressTexB.SetFillAmount(0f);
				}
			}
			this.CurState = state;
		}

		// Token: 0x0603C29F RID: 246431 RVA: 0x00E66FC4 File Offset: 0x00E651C4
		private void SetEnableBarB(bool enableBarB, bool force = false)
		{
			if (this.EnableBarB == enableBarB && !force)
			{
				return;
			}
			this.EnableBarB = enableBarB;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!this.EnableBarB);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(this.EnableBarB);
		}

		// Token: 0x0603C2A0 RID: 246432 RVA: 0x00E67018 File Offset: 0x00E65218
		private void InitBarB()
		{
			if (this.ProgressTexB == null)
			{
				this.ProgressTexB = base.GetTexture(7);
				base.GetText(3).SetText("0", true);
				this.FlagBg = base.GetSprite(8);
			}
			this.RefreshAttributeValue(this.InitEnergyB);
		}

		// Token: 0x0603C2A1 RID: 246433 RVA: 0x00E67068 File Offset: 0x00E65268
		public void SetCustomLogicParam(SkillButtonData skillButtonData, int from = -1, int param = 0)
		{
			if (skillButtonData == null)
			{
				return;
			}
			this.SkillButtonData = skillButtonData;
			bool flag = skillButtonData.AttributeUsageMode == ESkillButtonAttributeUsageMode.RecoverWithStack;
			this.SetEnableBarB(flag, false);
			if (!flag)
			{
				this.SetState(BattleSkillConfigLongPressItem.EState.StateA, false);
				return;
			}
			if (from == 7 || skillButtonData.HasHoldRingFxRestore())
			{
				this.UpdateRestoreMode = BattleSkillConfigLongPressItem.ESkillButtonHoldFxRestoreMode.WithSimulate;
				if (param > 0 || skillButtonData.HasHoldRingFxRestore())
				{
					ValueTuple<float, float> holdRingFxRestoreInfo = skillButtonData.GetHoldRingFxRestoreInfo();
					float item = holdRingFxRestoreInfo.Item1;
					float item2 = holdRingFxRestoreInfo.Item2;
					this.RestoreMachine.Init(item, new float?(item2));
					this.RestoreMachine.SetTargetPercent(1f);
				}
				else
				{
					this.RestoreMachine.Init(0f, new float?(0.001f));
					this.RestoreMachine.SetTargetPercent(0f);
					this.ProgressTexB.SetFillAmount(0f);
				}
			}
			else
			{
				this.UpdateRestoreMode = BattleSkillConfigLongPressItem.ESkillButtonHoldFxRestoreMode.WithAttribute;
			}
			int[] attributeUsageParams = skillButtonData.AttributeUsageParams;
			this.EnergyMaxB = (float)((attributeUsageParams != null) ? Math.Max(attributeUsageParams[0], 1) : 1);
			this.RefreshAttributeValue(skillButtonData.GetAttribute());
			this.TickProgressB(0f);
		}

		// Token: 0x0603C2A2 RID: 246434 RVA: 0x00E67174 File Offset: 0x00E65374
		private void TickProgressB(float delta)
		{
			if (this.CurState != BattleSkillConfigLongPressItem.EState.StateB)
			{
				return;
			}
			if (this.UpdateRestoreMode == BattleSkillConfigLongPressItem.ESkillButtonHoldFxRestoreMode.WithSimulate && this.RestoreMachine.Update(delta * Time.Instance.TimeDilation))
			{
				this.ProgressTexB.SetFillAmount(this.RestoreMachine.GetCurPercent());
			}
		}

		// Token: 0x0603C2A3 RID: 246435 RVA: 0x00E671C4 File Offset: 0x00E653C4
		public void RefreshAttributeValue(float curEnergy)
		{
			if (!this.EnableBarB)
			{
				return;
			}
			if (this.ProgressTexB == null)
			{
				this.InitEnergyB = curEnergy;
				return;
			}
			float num = curEnergy / this.EnergyMaxB;
			if (num >= 1f)
			{
				this.SetState(BattleSkillConfigLongPressItem.EState.StateA, false);
			}
			else
			{
				this.SetState(BattleSkillConfigLongPressItem.EState.StateB, false);
			}
			this.SetFlagEnable(num >= 1f);
			if (this.CurState == BattleSkillConfigLongPressItem.EState.StateB && this.UpdateRestoreMode == BattleSkillConfigLongPressItem.ESkillButtonHoldFxRestoreMode.WithAttribute)
			{
				this.ProgressTexB.SetFillAmount(num);
			}
			int num2 = (int)Math.Floor((double)(curEnergy / this.EnergyMaxB));
			SkillButtonData skillButtonData = this.SkillButtonData;
			if (((skillButtonData != null) ? skillButtonData.HoldRingFxRestoreFxNum : 0) < num2)
			{
				BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
				if (tweenAnimPlayer != null)
				{
					tweenAnimPlayer.PlayTweenAnim(4);
				}
			}
			base.GetText(3).SetText(num2.ToString(), true);
			if (this.SkillButtonData != null)
			{
				this.SkillButtonData.HoldRingFxRestoreFxNum = num2;
			}
		}

		// Token: 0x0603C2A4 RID: 246436 RVA: 0x00E6729C File Offset: 0x00E6549C
		private void SetFlagEnable(bool enable)
		{
			if (!this.EnableBarB)
			{
				return;
			}
			if (this.FlagBg == null)
			{
				return;
			}
			if (!BattleSkillConfigLongPressItem.IsFlagColorInited)
			{
				BattleSkillConfigLongPressItem.FlagColorGray = FColor.FromHex(ConfigCommonParamById.GetStringConfig("SkillButton_HoldFx_Flag_Gray"));
				BattleSkillConfigLongPressItem.FlagColorDefault = this.FlagBg.GetColor();
				BattleSkillConfigLongPressItem.IsFlagColorInited = true;
			}
			if (this.FlagState != enable)
			{
				this.FlagState = enable;
				this.FlagBg.SetColor(enable ? BattleSkillConfigLongPressItem.FlagColorDefault : BattleSkillConfigLongPressItem.FlagColorGray);
			}
		}

		// Token: 0x0401F5C6 RID: 128454
		private BattleSkillInputHandler InputHandler;

		// Token: 0x0401F5C7 RID: 128455
		private BattleSkillConfigLongPressItem.EState CurState;

		// Token: 0x0401F5C8 RID: 128456
		public bool TargetActive;

		// Token: 0x0401F5C9 RID: 128457
		private UUITexture ProgressTexA;

		// Token: 0x0401F5CA RID: 128458
		private EInputAction? Action;

		// Token: 0x0401F5CB RID: 128459
		private float Duration;

		// Token: 0x0401F5CC RID: 128460
		private float StartTime;

		// Token: 0x0401F5CD RID: 128461
		private bool IsFirstShow = true;

		// Token: 0x0401F5CE RID: 128462
		[Nullable(1)]
		private BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401F5CF RID: 128463
		private List<EInputAction> ExtraActions;

		// Token: 0x0401F5D0 RID: 128464
		private bool EnableBarB;

		// Token: 0x0401F5D1 RID: 128465
		private BattleSkillConfigLongPressItem.ESkillButtonHoldFxRestoreMode UpdateRestoreMode;

		// Token: 0x0401F5D2 RID: 128466
		private SkillButtonData SkillButtonData;

		// Token: 0x0401F5D3 RID: 128467
		private UUITexture ProgressTexB;

		// Token: 0x0401F5D4 RID: 128468
		private UUISprite FlagBg;

		// Token: 0x0401F5D5 RID: 128469
		private float InitEnergyB;

		// Token: 0x0401F5D6 RID: 128470
		private float EnergyMaxB = 1f;

		// Token: 0x0401F5D7 RID: 128471
		[Nullable(1)]
		private readonly MotorcyclePercentMachine RestoreMachine = new MotorcyclePercentMachine();

		// Token: 0x0401F5D8 RID: 128472
		[StaticVariableRuleIgnore]
		private static FColor FlagColorDefault;

		// Token: 0x0401F5D9 RID: 128473
		[StaticVariableRuleIgnore]
		private static FColor FlagColorGray;

		// Token: 0x0401F5DA RID: 128474
		[StaticVariableRuleIgnore]
		private static bool IsFlagColorInited;

		// Token: 0x0401F5DB RID: 128475
		private bool FlagState = true;

		// Token: 0x0200BF37 RID: 48951
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039AD2 RID: 236242
			ProgressTexA,
			// Token: 0x04039AD3 RID: 236243
			PnlFlagA,
			// Token: 0x04039AD4 RID: 236244
			PnlFlagB,
			// Token: 0x04039AD5 RID: 236245
			FlagNumB,
			// Token: 0x04039AD6 RID: 236246
			AniFlagSwitch,
			// Token: 0x04039AD7 RID: 236247
			PnlBarA,
			// Token: 0x04039AD8 RID: 236248
			PnlBarB,
			// Token: 0x04039AD9 RID: 236249
			ProgressTexB,
			// Token: 0x04039ADA RID: 236250
			FlagBg
		}

		// Token: 0x0200BF38 RID: 48952
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04039ADC RID: 236252
			StateA,
			// Token: 0x04039ADD RID: 236253
			StateB
		}

		// Token: 0x0200BF39 RID: 48953
		[NullableContext(0)]
		private enum ESkillButtonHoldFxRestoreMode
		{
			// Token: 0x04039ADF RID: 236255
			WithSimulate,
			// Token: 0x04039AE0 RID: 236256
			WithAttribute
		}
	}
}
