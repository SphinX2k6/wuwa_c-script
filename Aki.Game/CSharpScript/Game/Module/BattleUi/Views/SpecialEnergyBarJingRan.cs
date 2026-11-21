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
	// Token: 0x02004DC2 RID: 19906
	public class SpecialEnergyBarJingRan : SpecialEnergyBarBase
	{
		// Token: 0x060320BC RID: 204988 RVA: 0x00E030A4 File Offset: 0x00E012A4
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

		// Token: 0x060320BD RID: 204989 RVA: 0x00E033D1 File Offset: 0x00E015D1
		protected override void OnInitData()
		{
			this.YangConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(SpecialEnergyBarJingRan.YANG_CONFIG_ID);
			this.YinConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(SpecialEnergyBarJingRan.YIN_CONFIG_ID);
		}

		// Token: 0x060320BE RID: 204990 RVA: 0x00E03408 File Offset: 0x00E01608
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJingRan.StateYinTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJingRan.StateYangTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForAttributeChanged(SpecialEnergyBarJingRan.FishEnergyAttrId, new Action<EAttributeType, float, float>(this.OnFishEnergyChanged));
			base.ListenForAttributeChanged(SpecialEnergyBarJingRan.FishEnergyMaxAttrId, new Action<EAttributeType, float, float>(this.OnFishEnergyChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarJingRan.StateStrengthTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStrengthTagChange));
		}

		// Token: 0x060320BF RID: 204991 RVA: 0x00E03490 File Offset: 0x00E01690
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarJingRan.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarJingRan.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060320C0 RID: 204992 RVA: 0x00E034D4 File Offset: 0x00E016D4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarJingRan.<InitBarItem>d__34 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarJingRan.<InitBarItem>d__34>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060320C1 RID: 204993 RVA: 0x00E03518 File Offset: 0x00E01718
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

		// Token: 0x060320C2 RID: 204994 RVA: 0x00E0356C File Offset: 0x00E0176C
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

		// Token: 0x060320C3 RID: 204995 RVA: 0x00E035E8 File Offset: 0x00E017E8
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

		// Token: 0x060320C4 RID: 204996 RVA: 0x00E03687 File Offset: 0x00E01887
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

		// Token: 0x060320C5 RID: 204997 RVA: 0x00E036B1 File Offset: 0x00E018B1
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

		// Token: 0x060320C6 RID: 204998 RVA: 0x00E036DD File Offset: 0x00E018DD
		private void OnFishEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateFishEnergy();
		}

		// Token: 0x060320C7 RID: 204999 RVA: 0x00E036E5 File Offset: 0x00E018E5
		protected override void OnAttributeChanged()
		{
			this.UpdateBarBgStyle();
		}

		// Token: 0x060320C8 RID: 205000 RVA: 0x00E036ED File Offset: 0x00E018ED
		protected override void OnMaxAttributeChanged()
		{
			this.UpdateBarBgStyle();
		}

		// Token: 0x060320C9 RID: 205001 RVA: 0x00E036F8 File Offset: 0x00E018F8
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

		// Token: 0x060320CA RID: 205002 RVA: 0x00E03760 File Offset: 0x00E01960
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

		// Token: 0x060320CB RID: 205003 RVA: 0x00E037A0 File Offset: 0x00E019A0
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

		// Token: 0x060320CC RID: 205004 RVA: 0x00E037F4 File Offset: 0x00E019F4
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

		// Token: 0x060320CD RID: 205005 RVA: 0x00E038A0 File Offset: 0x00E01AA0
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

		// Token: 0x060320CE RID: 205006 RVA: 0x00E03A74 File Offset: 0x00E01C74
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

		// Token: 0x060320CF RID: 205007 RVA: 0x00E03AC4 File Offset: 0x00E01CC4
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

		// Token: 0x060320D0 RID: 205008 RVA: 0x00E03B54 File Offset: 0x00E01D54
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

		// Token: 0x060320D1 RID: 205009 RVA: 0x00E03BE2 File Offset: 0x00E01DE2
		private void SetFishState(int fishIndex, SpecialEnergyBarJingRan.EFishState fishState)
		{
			if (fishIndex < 0 || fishIndex >= SpecialEnergyBarJingRan.MAX_FISH_NUM)
			{
				return;
			}
			this.FishPanelList[fishIndex].SetFishState(this.CurState, fishState);
		}

		// Token: 0x060320D2 RID: 205010 RVA: 0x00E03C0C File Offset: 0x00E01E0C
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

		// Token: 0x060320D3 RID: 205011 RVA: 0x00E03C8C File Offset: 0x00E01E8C
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

		// Token: 0x060320D4 RID: 205012 RVA: 0x00E03D2C File Offset: 0x00E01F2C
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

		// Token: 0x060320D5 RID: 205013 RVA: 0x00E03DA2 File Offset: 0x00E01FA2
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(22);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0401A7F2 RID: 108530
		[StaticVariableRuleIgnore]
		private static readonly int YANG_CONFIG_ID = 121201;

		// Token: 0x0401A7F3 RID: 108531
		private static readonly int YIN_CONFIG_ID = 121202;

		// Token: 0x0401A7F4 RID: 108532
		private static readonly int StateYinTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1JingranMd1001.形态标识.阴"];

		// Token: 0x0401A7F5 RID: 108533
		private static readonly int StateYangTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1JingranMd1001.形态标识.阳"];

		// Token: 0x0401A7F6 RID: 108534
		private static readonly int StateStrengthTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1JingranMd10011.标识.大招状态"];

		// Token: 0x0401A7F7 RID: 108535
		private static readonly EAttributeType FishEnergyAttrId = EAttributeType.SpecialEnergy1;

		// Token: 0x0401A7F8 RID: 108536
		private static readonly EAttributeType FishEnergyMaxAttrId = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401A7F9 RID: 108537
		private static readonly int MAX_FISH_NUM = 3;

		// Token: 0x0401A7FA RID: 108538
		private static readonly int FISH_ROT_SPEED = 360;

		// Token: 0x0401A7FB RID: 108539
		[Nullable(2)]
		private SpecialEnergyBarInfo YangConfig;

		// Token: 0x0401A7FC RID: 108540
		[Nullable(2)]
		private SpecialEnergyBarInfo YinConfig;

		// Token: 0x0401A7FD RID: 108541
		private SpecialEnergyBarJingRan.EState CurState = SpecialEnergyBarJingRan.EState.Max;

		// Token: 0x0401A7FE RID: 108542
		[Nullable(2)]
		private SpecialEnergyBarJingRanSlot BarItemA;

		// Token: 0x0401A7FF RID: 108543
		[Nullable(2)]
		private SpecialEnergyBarJingRanSlot BarItemB;

		// Token: 0x0401A800 RID: 108544
		[Nullable(1)]
		private List<SpecialEnergyBarJingRan.SpecialEnergyBarJingRanFishPanel> FishPanelList = new List<SpecialEnergyBarJingRan.SpecialEnergyBarJingRanFishPanel>(SpecialEnergyBarJingRan.MAX_FISH_NUM);

		// Token: 0x0401A801 RID: 108545
		private FRotator TmpRotation;

		// Token: 0x0401A802 RID: 108546
		private float CurFishNum;

		// Token: 0x0401A803 RID: 108547
		private float RemainingRotDegree;

		// Token: 0x0401A804 RID: 108548
		private bool IsLightState;

		// Token: 0x0401A805 RID: 108549
		private bool IsFireState;

		// Token: 0x0401A806 RID: 108550
		private bool IsWaitingSlotAnim;

		// Token: 0x0401A807 RID: 108551
		private bool IsStateDirty;

		// Token: 0x0401A808 RID: 108552
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401A809 RID: 108553
		private int BuffHandle;

		// Token: 0x0401A80A RID: 108554
		private bool IsPlayWarnAnim;

		// Token: 0x0401A80B RID: 108555
		private bool IsInStrengthState;

		// Token: 0x0200AB07 RID: 43783
		private enum EChildType
		{
			// Token: 0x04034DE6 RID: 216550
			PnlStateA,
			// Token: 0x04034DE7 RID: 216551
			BarSlotA,
			// Token: 0x04034DE8 RID: 216552
			PnlStateB,
			// Token: 0x04034DE9 RID: 216553
			BarSlotB,
			// Token: 0x04034DEA RID: 216554
			PnlFish1,
			// Token: 0x04034DEB RID: 216555
			PnlFish2,
			// Token: 0x04034DEC RID: 216556
			PnlFish3,
			// Token: 0x04034DED RID: 216557
			AniNsLoop,
			// Token: 0x04034DEE RID: 216558
			AniNsSingle,
			// Token: 0x04034DEF RID: 216559
			AniNsFull,
			// Token: 0x04034DF0 RID: 216560
			PnlRot,
			// Token: 0x04034DF1 RID: 216561
			FishBgYin,
			// Token: 0x04034DF2 RID: 216562
			FishBgYang,
			// Token: 0x04034DF3 RID: 216563
			AniNsLoopYang,
			// Token: 0x04034DF4 RID: 216564
			AniNsFullYang,
			// Token: 0x04034DF5 RID: 216565
			AniNsSingleYang,
			// Token: 0x04034DF6 RID: 216566
			PnlDarkYang,
			// Token: 0x04034DF7 RID: 216567
			PnlLightYang,
			// Token: 0x04034DF8 RID: 216568
			PnlDarkYin,
			// Token: 0x04034DF9 RID: 216569
			PnlLightYin,
			// Token: 0x04034DFA RID: 216570
			AniNsFireYang,
			// Token: 0x04034DFB RID: 216571
			AniNsFireYin,
			// Token: 0x04034DFC RID: 216572
			AnimWarning
		}

		// Token: 0x0200AB08 RID: 43784
		public enum EState
		{
			// Token: 0x04034DFE RID: 216574
			Yin,
			// Token: 0x04034DFF RID: 216575
			Yang,
			// Token: 0x04034E00 RID: 216576
			Max
		}

		// Token: 0x0200AB09 RID: 43785
		public enum EFishState
		{
			// Token: 0x04034E02 RID: 216578
			Empty,
			// Token: 0x04034E03 RID: 216579
			Half,
			// Token: 0x04034E04 RID: 216580
			Full
		}

		// Token: 0x0200AB0A RID: 43786
		private class SpecialEnergyBarJingRanFishPanel : UiPanelBase
		{
			// Token: 0x0604692D RID: 289069 RVA: 0x01548B5C File Offset: 0x01546D5C
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

			// Token: 0x0604692E RID: 289070 RVA: 0x01548C4C File Offset: 0x01546E4C
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

			// Token: 0x0200BD6E RID: 48494
			private enum EFishChildType
			{
				// Token: 0x0403A271 RID: 238193
				EmptyYellow,
				// Token: 0x0403A272 RID: 238194
				EmptyBlue,
				// Token: 0x0403A273 RID: 238195
				FishHalfYin,
				// Token: 0x0403A274 RID: 238196
				FishFullYin,
				// Token: 0x0403A275 RID: 238197
				FishFullYang,
				// Token: 0x0403A276 RID: 238198
				FishHalfYang
			}
		}
	}
}
