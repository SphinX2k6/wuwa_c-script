using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF8 RID: 24056
	public class SpecialEnergyBarQianXiao : SpecialEnergyBarBase
	{
		// Token: 0x0603D268 RID: 250472 RVA: 0x00EB9B6C File Offset: 0x00EB7D6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 25;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
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
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D269 RID: 250473 RVA: 0x00EB9EE0 File Offset: 0x00EB80E0
		protected override void OnInitData()
		{
			this.AttributeId = EAttributeType.SpecialEnergy2;
			this.MaxAttributeId = EAttributeType.SpecialEnergy2Max;
			SpecialEnergyBarInfo config = this.Config;
			float? num = (config != null) ? config.ExtraFloatParams.GetValueOrNull(0) : null;
			if (num != null)
			{
				this.WarningAnimPercent = num.Value;
			}
		}

		// Token: 0x0603D26A RID: 250474 RVA: 0x00EB9F34 File Offset: 0x00EB8134
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQianXiao.StayInAirTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStayInAirTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQianXiao.SpecialTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQianXiao.SpecialEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialEnableTagChange));
		}

		// Token: 0x0603D26B RID: 250475 RVA: 0x00EB9F8C File Offset: 0x00EB818C
		private void OnStayInAirTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarQianXiao.EState.StayInAir : SpecialEnergyBarQianXiao.EState.Normal, false);
		}

		// Token: 0x0603D26C RID: 250476 RVA: 0x00EB9F9C File Offset: 0x00EB819C
		private void OnSpecialTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarQianXiao.EState.Special : SpecialEnergyBarQianXiao.EState.Normal, false);
		}

		// Token: 0x0603D26D RID: 250477 RVA: 0x00EB9FAC File Offset: 0x00EB81AC
		private void OnSpecialEnableTagChange(int tagId, bool tagExist)
		{
			this.SetSpecialStateEnable(tagExist);
		}

		// Token: 0x0603D26E RID: 250478 RVA: 0x00EB9FB8 File Offset: 0x00EB81B8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarQianXiao.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarQianXiao.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D26F RID: 250479 RVA: 0x00EB9FFC File Offset: 0x00EB81FC
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarQianXiao.<InitBarItem>d__19 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarQianXiao.<InitBarItem>d__19>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D270 RID: 250480 RVA: 0x00EBA040 File Offset: 0x00EB8240
		protected override void OnStart()
		{
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			base.InitTweenAnim(17);
			base.InitTweenAnim(18);
			base.InitTweenAnim(19);
			base.InitTweenAnim(20);
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshState(true);
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D271 RID: 250481 RVA: 0x00EBA0AE File Offset: 0x00EB82AE
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(19);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D272 RID: 250482 RVA: 0x00EBA0C0 File Offset: 0x00EB82C0
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			switch (this.CurState)
			{
			case SpecialEnergyBarQianXiao.EState.Normal:
			{
				UUITexture texture = base.GetTexture(4);
				if (texture == null)
				{
					return;
				}
				texture.SetFillAmount(curPercent);
				return;
			}
			case SpecialEnergyBarQianXiao.EState.StayInAir:
			{
				UUITexture texture2 = base.GetTexture(6);
				if (texture2 != null)
				{
					texture2.SetFillAmount(curPercent);
				}
				UUITexture texture3 = base.GetTexture(23);
				if (texture3 != null)
				{
					texture3.SetFillAmount(curPercent);
				}
				UUITexture texture4 = base.GetTexture(24);
				if (texture4 == null)
				{
					return;
				}
				texture4.SetFillAmount(curPercent);
				return;
			}
			case SpecialEnergyBarQianXiao.EState.Special:
			{
				UUITexture texture5 = base.GetTexture(8);
				if (texture5 != null)
				{
					texture5.SetFillAmount(curPercent);
				}
				UUITexture texture6 = base.GetTexture(9);
				if (texture6 == null)
				{
					return;
				}
				texture6.SetFillAmount(curPercent);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603D273 RID: 250483 RVA: 0x00EBA167 File Offset: 0x00EB8367
		protected override void OnBeforeHide()
		{
			SpecialEnergyBarQianXiaoSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.StopCoolDownState();
		}

		// Token: 0x0603D274 RID: 250484 RVA: 0x00EBA17C File Offset: 0x00EB837C
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarQianXiao.SpecialTagId))
			{
				this.SetState(SpecialEnergyBarQianXiao.EState.Special, isStart);
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarQianXiao.StayInAirTagId))
				{
					this.SetState(SpecialEnergyBarQianXiao.EState.StayInAir, isStart);
				}
				else
				{
					this.SetState(SpecialEnergyBarQianXiao.EState.Normal, isStart);
				}
			}
			if (isStart)
			{
				BaseTagComponent tagComponent3 = this.TagComponent;
				if (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarQianXiao.SpecialEnableTagId))
				{
					this.SetSpecialStateEnable(true);
				}
			}
		}

		// Token: 0x0603D275 RID: 250485 RVA: 0x00EBA1FC File Offset: 0x00EB83FC
		private void SetState(SpecialEnergyBarQianXiao.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			int curState = (int)this.CurState;
			this.CurState = state;
			if (curState == 2 && state != SpecialEnergyBarQianXiao.EState.Special)
			{
				base.StopTweenAnim(20);
				base.PlayTweenAnim(18);
				SpecialEnergyBarQianXiaoSlot barItem = this.BarItem;
				if (barItem != null)
				{
					barItem.SetState(SpecialEnergyBarQianXiaoSlot.ESlotState.CoolDown);
				}
				this.SetSpecialStateEnable(false);
			}
			switch (this.CurState)
			{
			case SpecialEnergyBarQianXiao.EState.Normal:
			{
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(7);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				base.PlayTweenAnim(16);
				break;
			}
			case SpecialEnergyBarQianXiao.EState.StayInAir:
			{
				UUIItem item4 = base.GetItem(3);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
				UUIItem item5 = base.GetItem(5);
				if (item5 != null)
				{
					item5.SetUIActive(true);
				}
				UUIItem item6 = base.GetItem(7);
				if (item6 != null)
				{
					item6.SetUIActive(false);
				}
				base.PlayTweenAnim(15);
				break;
			}
			case SpecialEnergyBarQianXiao.EState.Special:
			{
				UUIItem item7 = base.GetItem(3);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
				UUIItem item8 = base.GetItem(5);
				if (item8 != null)
				{
					item8.SetUIActive(false);
				}
				UUIItem item9 = base.GetItem(7);
				if (item9 != null)
				{
					item9.SetUIActive(true);
				}
				base.PlayTweenAnim(17);
				base.PlayTweenAnim(20);
				SpecialEnergyBarQianXiaoSlot barItem2 = this.BarItem;
				if (barItem2 != null)
				{
					barItem2.SetState(SpecialEnergyBarQianXiaoSlot.ESlotState.Special);
				}
				break;
			}
			}
			this.OnBarPercentChanged();
		}

		// Token: 0x0603D276 RID: 250486 RVA: 0x00EBA35C File Offset: 0x00EB855C
		private void SetSpecialStateEnable(bool enable)
		{
			if (this.IsSpecialStateEnable == enable)
			{
				return;
			}
			if (enable)
			{
				SpecialEnergyBarQianXiaoSlot barItem = this.BarItem;
				if (barItem == null || !barItem.IsInSlotState(SpecialEnergyBarQianXiaoSlot.ESlotState.CoolDown))
				{
					this.IsSpecialStateEnable = true;
					SpecialEnergyBarQianXiaoSlot barItem2 = this.BarItem;
					if (barItem2 != null)
					{
						barItem2.SetFullEffectEnable(true);
					}
					base.PlayTweenAnim(13);
					return;
				}
			}
			if (!enable && this.CurState != SpecialEnergyBarQianXiao.EState.Special)
			{
				this.IsSpecialStateEnable = false;
				SpecialEnergyBarQianXiaoSlot barItem3 = this.BarItem;
				if (barItem3 != null)
				{
					barItem3.SetFullEffectEnable(false);
				}
				base.PlayTweenAnim(14);
			}
		}

		// Token: 0x0603D277 RID: 250487 RVA: 0x00EBA3E0 File Offset: 0x00EB85E0
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarQianXiaoSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			if (this.CurState == SpecialEnergyBarQianXiao.EState.StayInAir && this.PercentMachine.GetCurPercent() < this.WarningAnimPercent)
			{
				this.PlayWarnAnim(true);
				return;
			}
			this.PlayWarnAnim(false);
		}

		// Token: 0x0603D278 RID: 250488 RVA: 0x00EBA434 File Offset: 0x00EB8634
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(19);
				return;
			}
			base.StopTweenAnim(19);
			UUITexture texture = base.GetTexture(6);
			if (texture != null)
			{
				texture.SetColor(this.BarDefaultColor);
			}
			UUITexture texture2 = base.GetTexture(24);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetAlpha(1f);
		}

		// Token: 0x0603D279 RID: 250489 RVA: 0x00EBA498 File Offset: 0x00EB8698
		private UniTask<bool> LoadCurve([Nullable(1)] string path)
		{
			SpecialEnergyBarQianXiao.<LoadCurve>d__29 <LoadCurve>d__;
			<LoadCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadCurve>d__.<>4__this = this;
			<LoadCurve>d__.path = path;
			<LoadCurve>d__.<>1__state = -1;
			<LoadCurve>d__.<>t__builder.Start<SpecialEnergyBarQianXiao.<LoadCurve>d__29>(ref <LoadCurve>d__);
			return <LoadCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0401FE0C RID: 130572
		[StaticVariableRuleIgnore]
		private static readonly int StayInAirTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QianxiaMd10011.状态标识.特殊闪避可用"];

		// Token: 0x0401FE0D RID: 130573
		[StaticVariableRuleIgnore]
		private static readonly int SpecialTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QianxiaMd10011.状态标识.电锯状态"];

		// Token: 0x0401FE0E RID: 130574
		[StaticVariableRuleIgnore]
		private static readonly int SpecialEnableTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QianxiaMd10011.状态标识.剪刀E可用"];

		// Token: 0x0401FE0F RID: 130575
		[Nullable(1)]
		private const string CURVE_PATH = "/Game/Aki/UI/UIResources/UiFight/Curve/EnergyBar/Qianxiao/GearRollbackCurve.GearRollbackCurve";

		// Token: 0x0401FE10 RID: 130576
		private readonly FColor BarDefaultColor = new FColor(byte.MaxValue, 133, 246, byte.MaxValue);

		// Token: 0x0401FE11 RID: 130577
		[Nullable(2)]
		private SpecialEnergyBarQianXiaoSlot BarItem;

		// Token: 0x0401FE12 RID: 130578
		private SpecialEnergyBarQianXiao.EState CurState;

		// Token: 0x0401FE13 RID: 130579
		private bool IsSpecialStateEnable;

		// Token: 0x0401FE14 RID: 130580
		private bool IsPlayWarnAnim;

		// Token: 0x0401FE15 RID: 130581
		private float WarningAnimPercent = 0.5f;

		// Token: 0x0200C13A RID: 49466
		private enum EState
		{
			// Token: 0x0403A5BA RID: 239034
			Normal,
			// Token: 0x0403A5BB RID: 239035
			StayInAir,
			// Token: 0x0403A5BC RID: 239036
			Special
		}

		// Token: 0x0200C13B RID: 49467
		private enum EChildType
		{
			// Token: 0x0403A5BE RID: 239038
			EnergyBar,
			// Token: 0x0403A5BF RID: 239039
			SlotBarItem,
			// Token: 0x0403A5C0 RID: 239040
			SlotBarPoint,
			// Token: 0x0403A5C1 RID: 239041
			BarItemNormal,
			// Token: 0x0403A5C2 RID: 239042
			BarTextureNormal,
			// Token: 0x0403A5C3 RID: 239043
			BarItemAir,
			// Token: 0x0403A5C4 RID: 239044
			BarTextureAir,
			// Token: 0x0403A5C5 RID: 239045
			BarItemSpecial,
			// Token: 0x0403A5C6 RID: 239046
			BarTextureSpecialLeft,
			// Token: 0x0403A5C7 RID: 239047
			BarTextureSpecialRight,
			// Token: 0x0403A5C8 RID: 239048
			GearActiveTexture,
			// Token: 0x0403A5C9 RID: 239049
			GearItem,
			// Token: 0x0403A5CA RID: 239050
			BarPointItem,
			// Token: 0x0403A5CB RID: 239051
			AniGearActive,
			// Token: 0x0403A5CC RID: 239052
			AniGear,
			// Token: 0x0403A5CD RID: 239053
			AniAirState,
			// Token: 0x0403A5CE RID: 239054
			AniNormalState,
			// Token: 0x0403A5CF RID: 239055
			AniSpecialState,
			// Token: 0x0403A5D0 RID: 239056
			AniRestore,
			// Token: 0x0403A5D1 RID: 239057
			AniWarning,
			// Token: 0x0403A5D2 RID: 239058
			AniStart,
			// Token: 0x0403A5D3 RID: 239059
			GlowItem,
			// Token: 0x0403A5D4 RID: 239060
			GlowSlider,
			// Token: 0x0403A5D5 RID: 239061
			GlowBarTexture,
			// Token: 0x0403A5D6 RID: 239062
			GlowBar2Texture
		}
	}
}
