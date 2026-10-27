using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DDE RID: 24030
	public class SpecialEnergyBarJingRan : SpecialEnergyBarBase
	{
		// Token: 0x0603D145 RID: 250181 RVA: 0x00EB21B0 File Offset: 0x00EB03B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 23;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D146 RID: 250182 RVA: 0x00EB24DD File Offset: 0x00EB06DD
		protected override void OnInitData()
		{
			this.YangConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(SpecialEnergyBarJingRan.YANG_CONFIG_ID);
			this.YinConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(SpecialEnergyBarJingRan.YIN_CONFIG_ID);
		}

		// Token: 0x0603D147 RID: 250183 RVA: 0x00EB2514 File Offset: 0x00EB0714
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJingRan.StateYinTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJingRan.StateYangTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForAttributeChanged(SpecialEnergyBarJingRan.FishEnergyAttrId, new Action<EAttributeType, float, float>(this.OnFishEnergyChanged));
			base.ListenForAttributeChanged(SpecialEnergyBarJingRan.FishEnergyMaxAttrId, new Action<EAttributeType, float, float>(this.OnFishEnergyChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJingRan.StateStrengthTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStrengthTagChange));
		}

		// Token: 0x0603D148 RID: 250184 RVA: 0x00EB259C File Offset: 0x00EB079C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarJingRan.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarJingRan.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D149 RID: 250185 RVA: 0x00EB25E0 File Offset: 0x00EB07E0
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarJingRan.<InitBarItem>d__34 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarJingRan.<InitBarItem>d__34>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D14A RID: 250186 RVA: 0x00EB2624 File Offset: 0x00EB0824
		[NullableContext(1)]
		protected UniTask InitFishItem(int index, UUIItem slotItem)
		{
			SpecialEnergyBarJingRan.<InitFishItem>d__35 <InitFishItem>d__;
			<InitFishItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFishItem>d__.<>4__this = this;
			<InitFishItem>d__.index = index;
			<InitFishItem>d__.slotItem = slotItem;
			<InitFishItem>d__.<>1__state = -1;
			<InitFishItem>d__.<>t__builder.Start<SpecialEnergyBarJingRan.<InitFishItem>d__35>(ref <InitFishItem>d__);
			return <InitFishItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D14B RID: 250187 RVA: 0x00EB2678 File Offset: 0x00EB0878
		protected override void OnStart()
		{
			base.InitTweenAnim(22);
			this.RefreshState();
			this.OnBarPercentChanged();
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(18);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			this.UpdateBarBgStyle();
			this.RefreshFireState(true);
			BaseTagComponent tagComponent = this.TagComponent;
			bool tagExist = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarJingRan.StateStrengthTagId);
			this.OnStrengthTagChange(SpecialEnergyBarJingRan.StateStrengthTagId, tagExist);
		}

		// Token: 0x0603D14C RID: 250188 RVA: 0x00EB26F4 File Offset: 0x00EB08F4
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.IsWaitingSlotAnim || this.IsStateDirty)
			{
				this.RefreshState();
			}
			SpecialEnergyBarJingRanSlot barItemA = this.BarItemA;
			if (barItemA != null)
			{
				barItemA.Tick(delta);
			}
			SpecialEnergyBarJingRanSlot barItemB = this.BarItemB;
			if (barItemB != null)
			{
				barItemB.Tick(delta);
			}
			this.TryRotFishPanel(delta);
			if (!this.IsInStrengthState)
			{
				this.PlayWarnAnim(false);
				return;
			}
			this.RefreshBuff();
			if (this.Buff != null)
			{
				this.PlayWarnAnim(this.Buff.GetRemainDuration() < this.Config.ExtraFloatParams[2]);
				return;
			}
			this.PlayWarnAnim(false);
		}

		// Token: 0x0603D14D RID: 250189 RVA: 0x00EB2793 File Offset: 0x00EB0993
		private void OnStateTagChange(int tagId, bool tagExist)
		{
			this.IsStateDirty = true;
			SpecialEnergyBarJingRanSlot barItemA = this.BarItemA;
			if (barItemA != null)
			{
				barItemA.MarkStateChange();
			}
			SpecialEnergyBarJingRanSlot barItemB = this.BarItemB;
			if (barItemB == null)
			{
				return;
			}
			barItemB.MarkStateChange();
		}

		// Token: 0x0603D14E RID: 250190 RVA: 0x00EB27BD File Offset: 0x00EB09BD
		private void OnStrengthTagChange(int tagId, bool tagExist)
		{
			this.IsInStrengthState = tagExist;
			SpecialEnergyBarJingRanSlot barItemA = this.BarItemA;
			if (barItemA != null)
			{
				barItemA.SetStrengthState(tagExist);
			}
			SpecialEnergyBarJingRanSlot barItemB = this.BarItemB;
			if (barItemB == null)
			{
				return;
			}
			barItemB.SetStrengthState(tagExist);
		}

		// Token: 0x0603D14F RID: 250191 RVA: 0x00EB27E9 File Offset: 0x00EB09E9
		private void OnFishEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateFishEnergy();
		}

		// Token: 0x0603D150 RID: 250192 RVA: 0x00EB27F1 File Offset: 0x00EB09F1
		protected override void OnAttributeChanged()
		{
			this.UpdateBarBgStyle();
		}

		// Token: 0x0603D151 RID: 250193 RVA: 0x00EB27F9 File Offset: 0x00EB09F9
		protected override void OnMaxAttributeChanged()
		{
			this.UpdateBarBgStyle();
		}

		// Token: 0x0603D152 RID: 250194 RVA: 0x00EB2804 File Offset: 0x00EB0A04
		private void UpdateBarBgStyle()
		{
			bool flag = this.AttributeComponent.GetCurrentValue(this.AttributeId) > 0f;
			if (flag == this.IsLightState)
			{
				return;
			}
			this.IsLightState = flag;
			UUIItem item = base.GetItem(19);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(17);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			this.RefreshFireState(false);
		}

		// Token: 0x0603D153 RID: 250195 RVA: 0x00EB286C File Offset: 0x00EB0A6C
		private bool IsCurItemPlayingAnim()
		{
			SpecialEnergyBarJingRan.EState curState = this.CurState;
			if (curState == SpecialEnergyBarJingRan.EState.Yin)
			{
				SpecialEnergyBarJingRanSlot barItemB = this.BarItemB;
				return barItemB != null && barItemB.IsPlayingConsumeAnim();
			}
			if (curState == SpecialEnergyBarJingRan.EState.Yang)
			{
				SpecialEnergyBarJingRanSlot barItemA = this.BarItemA;
				return barItemA != null && barItemA.IsPlayingConsumeAnim();
			}
			return false;
		}

		// Token: 0x0603D154 RID: 250196 RVA: 0x00EB28AC File Offset: 0x00EB0AAC
		private void RefreshState()
		{
			if (this.IsCurItemPlayingAnim())
			{
				this.IsWaitingSlotAnim = true;
				return;
			}
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarJingRan.StateYangTagId))
			{
				this.SetState(SpecialEnergyBarJingRan.EState.Yang);
			}
			else
			{
				this.SetState(SpecialEnergyBarJingRan.EState.Yin);
			}
			this.IsStateDirty = false;
			this.IsWaitingSlotAnim = false;
		}

		// Token: 0x0603D155 RID: 250197 RVA: 0x00EB2900 File Offset: 0x00EB0B00
		private void SetState(SpecialEnergyBarJingRan.EState state)
		{
			if (state == this.CurState)
			{
				return;
			}
			this.CurState = state;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(state == SpecialEnergyBarJingRan.EState.Yang);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(state == SpecialEnergyBarJingRan.EState.Yin);
			}
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetUIActive(state == SpecialEnergyBarJingRan.EState.Yang);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 != null)
			{
				item4.SetUIActive(state == SpecialEnergyBarJingRan.EState.Yin);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(13);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(state == SpecialEnergyBarJingRan.EState.Yang);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(7);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(state == SpecialEnergyBarJingRan.EState.Yin);
			}
			this.UpdateFishEnergy();
		}

		// Token: 0x0603D156 RID: 250198 RVA: 0x00EB29AC File Offset: 0x00EB0BAC
		private void UpdateFishEnergy()
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(SpecialEnergyBarJingRan.FishEnergyAttrId) : 0f;
			BaseAttributeComponent attributeComponent2 = this.AttributeComponent;
			float num2 = (attributeComponent2 != null) ? attributeComponent2.GetCurrentValue(SpecialEnergyBarJingRan.FishEnergyMaxAttrId) : 0f;
			if (MathUtils.Instance.IsNearlyEqual((double)num2, 0.0, null))
			{
				return;
			}
			float num3 = num2 / (float)SpecialEnergyBarJingRan.MAX_FISH_NUM / 2f;
			float num4 = num2 / (float)SpecialEnergyBarJingRan.MAX_FISH_NUM;
			float num5 = num / num4;
			float curFishNum = this.CurFishNum;
			this.CurFishNum = num5;
			bool isZeroEnergy = MathUtils.Instance.IsNearlyEqual((double)num, 0.0, null) || MathUtils.Instance.IsNearlyEqual((double)num2, 0.0, null);
			bool flag = num2 > 0f && MathUtils.Instance.IsNearlyEqual((double)num2, (double)num, null);
			bool isNewFish = Math.Floor((double)num5) > Math.Floor((double)curFishNum);
			this.PlayFillFishAnim(isNewFish, isZeroEnergy, flag);
			for (int i = 0; i < SpecialEnergyBarJingRan.MAX_FISH_NUM; i++)
			{
				SpecialEnergyBarJingRan.EFishState fishState = SpecialEnergyBarJingRan.EFishState.Empty;
				if (MathUtils.Instance.IsNearlyEqual((double)num2, 0.0, null))
				{
					fishState = SpecialEnergyBarJingRan.EFishState.Empty;
				}
				else if (MathUtils.Instance.IsNearlyEqual((double)num, (double)((float)(i * 2 + 1) * num3), null))
				{
					fishState = SpecialEnergyBarJingRan.EFishState.Half;
				}
				else if (num >= (float)((i + 1) * 2) * num3)
				{
					fishState = SpecialEnergyBarJingRan.EFishState.Full;
				}
				this.SetFishState(i, fishState);
			}
			this.UpdateTargetRot(num5, curFishNum);
			SpecialEnergyBarJingRanSlot barItemA = this.BarItemA;
			if (barItemA != null)
			{
				barItemA.SetKeyEnable(flag);
			}
			SpecialEnergyBarJingRanSlot barItemB = this.BarItemB;
			if (barItemB != null)
			{
				barItemB.SetKeyEnable(flag);
			}
			this.RefreshFireState(false);
		}

		// Token: 0x0603D157 RID: 250199 RVA: 0x00EB2B80 File Offset: 0x00EB0D80
		private void RefreshFireState(bool isStart = false)
		{
			bool isLightState = this.IsLightState;
			if (isLightState == this.IsFireState && !isStart)
			{
				return;
			}
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(isLightState);
			}
			UUIItem item2 = base.GetItem(20);
			if (item2 != null)
			{
				item2.SetUIActive(isLightState);
			}
			this.IsFireState = isLightState;
		}

		// Token: 0x0603D158 RID: 250200 RVA: 0x00EB2BD0 File Offset: 0x00EB0DD0
		private void PlayFillFishAnim(bool isNewFish, bool isZeroEnergy, bool isFullEnergy)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(8);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(this.CurState == SpecialEnergyBarJingRan.EState.Yin && isNewFish);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(9);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(this.CurState == SpecialEnergyBarJingRan.EState.Yin && !isZeroEnergy && isFullEnergy);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(15);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetUIActive(this.CurState == SpecialEnergyBarJingRan.EState.Yang && isNewFish);
			}
			UUINiagara uiNiagara4 = base.GetUiNiagara(14);
			if (uiNiagara4 == null)
			{
				return;
			}
			uiNiagara4.SetUIActive(this.CurState == SpecialEnergyBarJingRan.EState.Yang && !isZeroEnergy && isFullEnergy);
		}

		// Token: 0x0603D159 RID: 250201 RVA: 0x00EB2C60 File Offset: 0x00EB0E60
		private void UpdateTargetRot(float newFishNum, float oldFishNum)
		{
			if (newFishNum > oldFishNum)
			{
				this.RemainingRotDegree += (float)((Math.Floor((double)newFishNum) - Math.Floor((double)oldFishNum)) * 360.0 / (double)SpecialEnergyBarJingRan.MAX_FISH_NUM);
				return;
			}
			if (MathUtils.Instance.IsNearlyEqual((double)newFishNum, 0.0, null))
			{
				this.RemainingRotDegree = 0f;
				this.TmpRotation.Yaw = 0f;
				base.GetItem(10).SetUIRelativeRotation(this.TmpRotation);
			}
		}

		// Token: 0x0603D15A RID: 250202 RVA: 0x00EB2CEE File Offset: 0x00EB0EEE
		private void SetFishState(int fishIndex, SpecialEnergyBarJingRan.EFishState fishState)
		{
			if (fishIndex < 0 || fishIndex >= SpecialEnergyBarJingRan.MAX_FISH_NUM)
			{
				return;
			}
			this.FishPanelList[fishIndex].SetFishState(this.CurState, fishState);
		}

		// Token: 0x0603D15B RID: 250203 RVA: 0x00EB2D18 File Offset: 0x00EB0F18
		private void TryRotFishPanel(float delta)
		{
			if (this.RemainingRotDegree <= 0f)
			{
				return;
			}
			float num = delta / (float)TimeUtil.Instance.InverseMillisecond * (float)SpecialEnergyBarJingRan.FISH_ROT_SPEED;
			if (num > this.RemainingRotDegree)
			{
				num = this.RemainingRotDegree;
			}
			this.TmpRotation.Yaw = (this.TmpRotation.Yaw - num) % 360f;
			this.RemainingRotDegree -= num;
			base.GetItem(10).SetUIRelativeRotation(this.TmpRotation);
		}

		// Token: 0x0603D15C RID: 250204 RVA: 0x00EB2D98 File Offset: 0x00EB0F98
		private void RefreshBuff()
		{
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					return;
				}
			}
			SpecialEnergyBarInfo config = this.Config;
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				long buffId = config.BuffId;
				flag = true;
			}
			if (flag && this.Config.BuffId != 0L)
			{
				CharacterBuffComponent buffComponent2 = this.BuffComponent;
				this.Buff = ((buffComponent2 != null) ? buffComponent2.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0603D15D RID: 250205 RVA: 0x00EB2E38 File Offset: 0x00EB1038
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(22);
				return;
			}
			base.StopTweenAnim(22);
			base.GetItem(0).SetAlpha(1f);
			base.GetItem(2).SetAlpha(1f);
			base.GetItem(1).SetAlpha(1f);
			base.GetItem(3).SetAlpha(1f);
		}

		// Token: 0x0603D15E RID: 250206 RVA: 0x00EB2EAE File Offset: 0x00EB10AE
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(22);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0401FD35 RID: 130357
		[StaticVariableRuleIgnore]
		private static readonly int YANG_CONFIG_ID = 121201;

		// Token: 0x0401FD36 RID: 130358
		private static readonly int YIN_CONFIG_ID = 121202;

		// Token: 0x0401FD37 RID: 130359
		private static readonly int StateYinTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1JingranMd1001.形态标识.阴"];

		// Token: 0x0401FD38 RID: 130360
		private static readonly int StateYangTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1JingranMd1001.形态标识.阳"];

		// Token: 0x0401FD39 RID: 130361
		private static readonly int StateStrengthTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1JingranMd10011.标识.大招状态"];

		// Token: 0x0401FD3A RID: 130362
		private static readonly EAttributeType FishEnergyAttrId = EAttributeType.SpecialEnergy1;

		// Token: 0x0401FD3B RID: 130363
		private static readonly EAttributeType FishEnergyMaxAttrId = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401FD3C RID: 130364
		private static readonly int MAX_FISH_NUM = 3;

		// Token: 0x0401FD3D RID: 130365
		private static readonly int FISH_ROT_SPEED = 360;

		// Token: 0x0401FD3E RID: 130366
		[Nullable(2)]
		private SpecialEnergyBarInfo YangConfig;

		// Token: 0x0401FD3F RID: 130367
		[Nullable(2)]
		private SpecialEnergyBarInfo YinConfig;

		// Token: 0x0401FD40 RID: 130368
		private SpecialEnergyBarJingRan.EState CurState = SpecialEnergyBarJingRan.EState.Max;

		// Token: 0x0401FD41 RID: 130369
		[Nullable(2)]
		private SpecialEnergyBarJingRanSlot BarItemA;

		// Token: 0x0401FD42 RID: 130370
		[Nullable(2)]
		private SpecialEnergyBarJingRanSlot BarItemB;

		// Token: 0x0401FD43 RID: 130371
		[Nullable(1)]
		private List<SpecialEnergyBarJingRan.SpecialEnergyBarJingRanFishPanel> FishPanelList = new List<SpecialEnergyBarJingRan.SpecialEnergyBarJingRanFishPanel>(SpecialEnergyBarJingRan.MAX_FISH_NUM);

		// Token: 0x0401FD44 RID: 130372
		private FRotator TmpRotation;

		// Token: 0x0401FD45 RID: 130373
		private float CurFishNum;

		// Token: 0x0401FD46 RID: 130374
		private float RemainingRotDegree;

		// Token: 0x0401FD47 RID: 130375
		private bool IsLightState;

		// Token: 0x0401FD48 RID: 130376
		private bool IsFireState;

		// Token: 0x0401FD49 RID: 130377
		private bool IsWaitingSlotAnim;

		// Token: 0x0401FD4A RID: 130378
		private bool IsStateDirty;

		// Token: 0x0401FD4B RID: 130379
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401FD4C RID: 130380
		private int BuffHandle;

		// Token: 0x0401FD4D RID: 130381
		private bool IsPlayWarnAnim;

		// Token: 0x0401FD4E RID: 130382
		private bool IsInStrengthState;

		// Token: 0x0200C0FE RID: 49406
		private enum EChildType
		{
			// Token: 0x0403A414 RID: 238612
			PnlStateA,
			// Token: 0x0403A415 RID: 238613
			BarSlotA,
			// Token: 0x0403A416 RID: 238614
			PnlStateB,
			// Token: 0x0403A417 RID: 238615
			BarSlotB,
			// Token: 0x0403A418 RID: 238616
			PnlFish1,
			// Token: 0x0403A419 RID: 238617
			PnlFish2,
			// Token: 0x0403A41A RID: 238618
			PnlFish3,
			// Token: 0x0403A41B RID: 238619
			AniNsLoop,
			// Token: 0x0403A41C RID: 238620
			AniNsSingle,
			// Token: 0x0403A41D RID: 238621
			AniNsFull,
			// Token: 0x0403A41E RID: 238622
			PnlRot,
			// Token: 0x0403A41F RID: 238623
			FishBgYin,
			// Token: 0x0403A420 RID: 238624
			FishBgYang,
			// Token: 0x0403A421 RID: 238625
			AniNsLoopYang,
			// Token: 0x0403A422 RID: 238626
			AniNsFullYang,
			// Token: 0x0403A423 RID: 238627
			AniNsSingleYang,
			// Token: 0x0403A424 RID: 238628
			PnlDarkYang,
			// Token: 0x0403A425 RID: 238629
			PnlLightYang,
			// Token: 0x0403A426 RID: 238630
			PnlDarkYin,
			// Token: 0x0403A427 RID: 238631
			PnlLightYin,
			// Token: 0x0403A428 RID: 238632
			AniNsFireYang,
			// Token: 0x0403A429 RID: 238633
			AniNsFireYin,
			// Token: 0x0403A42A RID: 238634
			AnimWarning
		}

		// Token: 0x0200C0FF RID: 49407
		public enum EState
		{
			// Token: 0x0403A42C RID: 238636
			Yin,
			// Token: 0x0403A42D RID: 238637
			Yang,
			// Token: 0x0403A42E RID: 238638
			Max
		}

		// Token: 0x0200C100 RID: 49408
		public enum EFishState
		{
			// Token: 0x0403A430 RID: 238640
			Empty,
			// Token: 0x0403A431 RID: 238641
			Half,
			// Token: 0x0403A432 RID: 238642
			Full
		}

		// Token: 0x0200C101 RID: 49409
		private class SpecialEnergyBarJingRanFishPanel : UiPanelBase
		{
			// Token: 0x060503E6 RID: 328678 RVA: 0x0158F548 File Offset: 0x0158D748
			protected unsafe override void OnRegisterComponent()
			{
				int num = 6;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x060503E7 RID: 328679 RVA: 0x0158F638 File Offset: 0x0158D838
			public void SetFishState(SpecialEnergyBarJingRan.EState roleState, SpecialEnergyBarJingRan.EFishState fishState)
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(roleState == SpecialEnergyBarJingRan.EState.Yang);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(roleState == SpecialEnergyBarJingRan.EState.Yin);
				}
				UUIItem item3 = base.GetItem(2);
				if (item3 != null)
				{
					item3.SetUIActive(fishState != SpecialEnergyBarJingRan.EFishState.Empty && roleState == SpecialEnergyBarJingRan.EState.Yin);
				}
				UUIItem item4 = base.GetItem(5);
				if (item4 != null)
				{
					item4.SetUIActive(fishState != SpecialEnergyBarJingRan.EFishState.Empty && roleState == SpecialEnergyBarJingRan.EState.Yang);
				}
				UUIItem item5 = base.GetItem(3);
				if (item5 != null)
				{
					item5.SetUIActive(fishState == SpecialEnergyBarJingRan.EFishState.Full && roleState == SpecialEnergyBarJingRan.EState.Yin);
				}
				UUIItem item6 = base.GetItem(4);
				if (item6 == null)
				{
					return;
				}
				item6.SetUIActive(fishState == SpecialEnergyBarJingRan.EFishState.Full && roleState == SpecialEnergyBarJingRan.EState.Yang);
			}

			// Token: 0x0200D190 RID: 53648
			private enum EFishChildType
			{
				// Token: 0x0403EE29 RID: 257577
				EmptyYellow,
				// Token: 0x0403EE2A RID: 257578
				EmptyBlue,
				// Token: 0x0403EE2B RID: 257579
				FishHalfYin,
				// Token: 0x0403EE2C RID: 257580
				FishFullYin,
				// Token: 0x0403EE2D RID: 257581
				FishFullYang,
				// Token: 0x0403EE2E RID: 257582
				FishHalfYang
			}
		}
	}
}
