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
	// Token: 0x02004CC1 RID: 19649
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillConfigLongPressItem : UiPanelBase
	{
		// Token: 0x060311E6 RID: 201190 RVA: 0x00DB7030 File Offset: 0x00DB5230
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

		// Token: 0x060311E7 RID: 201191 RVA: 0x00DB7184 File Offset: 0x00DB5384
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

		// Token: 0x060311E8 RID: 201192 RVA: 0x00DB724B File Offset: 0x00DB544B
		protected override void OnBeforeShow()
		{
			if (this.InputHandler != null)
			{
				InputController.Instance.AddInputHandler(this.InputHandler);
			}
		}

		// Token: 0x060311E9 RID: 201193 RVA: 0x00DB7265 File Offset: 0x00DB5465
		protected override void OnAfterHide()
		{
			if (this.InputHandler != null)
			{
				InputController.Instance.RemoveInputHandler(this.InputHandler);
			}
		}

		// Token: 0x060311EA RID: 201194 RVA: 0x00DB7280 File Offset: 0x00DB5480
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

		// Token: 0x060311EB RID: 201195 RVA: 0x00DB72D4 File Offset: 0x00DB54D4
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

		// Token: 0x060311EC RID: 201196 RVA: 0x00DB7365 File Offset: 0x00DB5565
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

		// Token: 0x060311ED RID: 201197 RVA: 0x00DB7380 File Offset: 0x00DB5580
		private bool IsValidAction(EInputAction action)
		{
			return (this.ExtraActions != null && this.ExtraActions.Contains(action)) || !(this.Action != action);
		}

		// Token: 0x060311EE RID: 201198 RVA: 0x00DB73CC File Offset: 0x00DB55CC
		public void SetDuration(float duration)
		{
			this.Duration = duration * (float)TimeUtil.Instance.InverseMillisecond;
		}

		// Token: 0x060311EF RID: 201199 RVA: 0x00DB73E1 File Offset: 0x00DB55E1
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

		// Token: 0x060311F0 RID: 201200 RVA: 0x00DB7401 File Offset: 0x00DB5601
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

		// Token: 0x060311F1 RID: 201201 RVA: 0x00DB7428 File Offset: 0x00DB5628
		private void StartProgress()
		{
			this.StartTime = (float)Time.Instance.WorldTime;
		}

		// Token: 0x060311F2 RID: 201202 RVA: 0x00DB743B File Offset: 0x00DB563B
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

		// Token: 0x060311F3 RID: 201203 RVA: 0x00DB7460 File Offset: 0x00DB5660
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

		// Token: 0x060311F4 RID: 201204 RVA: 0x00DB74E0 File Offset: 0x00DB56E0
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

		// Token: 0x060311F5 RID: 201205 RVA: 0x00DB7578 File Offset: 0x00DB5778
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

		// Token: 0x060311F6 RID: 201206 RVA: 0x00DB75CC File Offset: 0x00DB57CC
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

		// Token: 0x060311F7 RID: 201207 RVA: 0x00DB761C File Offset: 0x00DB581C
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

		// Token: 0x060311F8 RID: 201208 RVA: 0x00DB7728 File Offset: 0x00DB5928
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

		// Token: 0x060311F9 RID: 201209 RVA: 0x00DB7778 File Offset: 0x00DB5978
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

		// Token: 0x060311FA RID: 201210 RVA: 0x00DB7850 File Offset: 0x00DB5A50
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

		// Token: 0x0401A07F RID: 106623
		private BattleSkillInputHandler InputHandler;

		// Token: 0x0401A080 RID: 106624
		private BattleSkillConfigLongPressItem.EState CurState;

		// Token: 0x0401A081 RID: 106625
		public bool TargetActive;

		// Token: 0x0401A082 RID: 106626
		private UUITexture ProgressTexA;

		// Token: 0x0401A083 RID: 106627
		private EInputAction? Action;

		// Token: 0x0401A084 RID: 106628
		private float Duration;

		// Token: 0x0401A085 RID: 106629
		private float StartTime;

		// Token: 0x0401A086 RID: 106630
		private bool IsFirstShow = true;

		// Token: 0x0401A087 RID: 106631
		[Nullable(1)]
		private BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401A088 RID: 106632
		private List<EInputAction> ExtraActions;

		// Token: 0x0401A089 RID: 106633
		private bool EnableBarB;

		// Token: 0x0401A08A RID: 106634
		private BattleSkillConfigLongPressItem.ESkillButtonHoldFxRestoreMode UpdateRestoreMode;

		// Token: 0x0401A08B RID: 106635
		private SkillButtonData SkillButtonData;

		// Token: 0x0401A08C RID: 106636
		private UUITexture ProgressTexB;

		// Token: 0x0401A08D RID: 106637
		private UUISprite FlagBg;

		// Token: 0x0401A08E RID: 106638
		private float InitEnergyB;

		// Token: 0x0401A08F RID: 106639
		private float EnergyMaxB = 1f;

		// Token: 0x0401A090 RID: 106640
		[Nullable(1)]
		private readonly MotorcyclePercentMachine RestoreMachine = new MotorcyclePercentMachine();

		// Token: 0x0401A091 RID: 106641
		[StaticVariableRuleIgnore]
		private static FColor FlagColorDefault;

		// Token: 0x0401A092 RID: 106642
		[StaticVariableRuleIgnore]
		private static FColor FlagColorGray;

		// Token: 0x0401A093 RID: 106643
		[StaticVariableRuleIgnore]
		private static bool IsFlagColorInited;

		// Token: 0x0401A094 RID: 106644
		private bool FlagState = true;

		// Token: 0x0200A93D RID: 43325
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034494 RID: 214164
			ProgressTexA,
			// Token: 0x04034495 RID: 214165
			PnlFlagA,
			// Token: 0x04034496 RID: 214166
			PnlFlagB,
			// Token: 0x04034497 RID: 214167
			FlagNumB,
			// Token: 0x04034498 RID: 214168
			AniFlagSwitch,
			// Token: 0x04034499 RID: 214169
			PnlBarA,
			// Token: 0x0403449A RID: 214170
			PnlBarB,
			// Token: 0x0403449B RID: 214171
			ProgressTexB,
			// Token: 0x0403449C RID: 214172
			FlagBg
		}

		// Token: 0x0200A93E RID: 43326
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403449E RID: 214174
			StateA,
			// Token: 0x0403449F RID: 214175
			StateB
		}

		// Token: 0x0200A93F RID: 43327
		[NullableContext(0)]
		private enum ESkillButtonHoldFxRestoreMode
		{
			// Token: 0x040344A1 RID: 214177
			WithSimulate,
			// Token: 0x040344A2 RID: 214178
			WithAttribute
		}
	}
}
