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
	// Token: 0x02004DDD RID: 19933
	public class SpecialEnergyBarQianXiao : SpecialEnergyBarBase
	{
		// Token: 0x060321F7 RID: 205303 RVA: 0x00E0B0B8 File Offset: 0x00E092B8
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

		// Token: 0x060321F8 RID: 205304 RVA: 0x00E0B42C File Offset: 0x00E0962C
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

		// Token: 0x060321F9 RID: 205305 RVA: 0x00E0B480 File Offset: 0x00E09680
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQianXiao.StayInAirTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStayInAirTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQianXiao.SpecialTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQianXiao.SpecialEnableTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSpecialEnableTagChange));
		}

		// Token: 0x060321FA RID: 205306 RVA: 0x00E0B4D8 File Offset: 0x00E096D8
		private void OnStayInAirTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarQianXiao.EState.StayInAir : SpecialEnergyBarQianXiao.EState.Normal, false);
		}

		// Token: 0x060321FB RID: 205307 RVA: 0x00E0B4E8 File Offset: 0x00E096E8
		private void OnSpecialTagChange(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarQianXiao.EState.Special : SpecialEnergyBarQianXiao.EState.Normal, false);
		}

		// Token: 0x060321FC RID: 205308 RVA: 0x00E0B4F8 File Offset: 0x00E096F8
		private void OnSpecialEnableTagChange(int tagId, bool tagExist)
		{
			this.SetSpecialStateEnable(tagExist);
		}

		// Token: 0x060321FD RID: 205309 RVA: 0x00E0B504 File Offset: 0x00E09704
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarQianXiao.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarQianXiao.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060321FE RID: 205310 RVA: 0x00E0B548 File Offset: 0x00E09748
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarQianXiao.<InitBarItem>d__19 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarQianXiao.<InitBarItem>d__19>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060321FF RID: 205311 RVA: 0x00E0B58C File Offset: 0x00E0978C
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

		// Token: 0x06032200 RID: 205312 RVA: 0x00E0B5FA File Offset: 0x00E097FA
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(19);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06032201 RID: 205313 RVA: 0x00E0B60C File Offset: 0x00E0980C
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

		// Token: 0x06032202 RID: 205314 RVA: 0x00E0B6B3 File Offset: 0x00E098B3
		protected override void OnBeforeHide()
		{
			SpecialEnergyBarQianXiaoSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.StopCoolDownState();
		}

		// Token: 0x06032203 RID: 205315 RVA: 0x00E0B6C8 File Offset: 0x00E098C8
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

		// Token: 0x06032204 RID: 205316 RVA: 0x00E0B748 File Offset: 0x00E09948
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

		// Token: 0x06032205 RID: 205317 RVA: 0x00E0B8A8 File Offset: 0x00E09AA8
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

		// Token: 0x06032206 RID: 205318 RVA: 0x00E0B92C File Offset: 0x00E09B2C
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

		// Token: 0x06032207 RID: 205319 RVA: 0x00E0B980 File Offset: 0x00E09B80
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

		// Token: 0x06032208 RID: 205320 RVA: 0x00E0B9E4 File Offset: 0x00E09BE4
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

		// Token: 0x0401A8D3 RID: 108755
		[StaticVariableRuleIgnore]
		private static readonly int StayInAirTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QianxiaMd10011.状态标识.特殊闪避可用"];

		// Token: 0x0401A8D4 RID: 108756
		[StaticVariableRuleIgnore]
		private static readonly int SpecialTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QianxiaMd10011.状态标识.电锯状态"];

		// Token: 0x0401A8D5 RID: 108757
		[StaticVariableRuleIgnore]
		private static readonly int SpecialEnableTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1QianxiaMd10011.状态标识.剪刀E可用"];

		// Token: 0x0401A8D6 RID: 108758
		[Nullable(1)]
		private const string CURVE_PATH = "/Game/Aki/UI/UIResources/UiFight/Curve/EnergyBar/Qianxiao/GearRollbackCurve.GearRollbackCurve";

		// Token: 0x0401A8D7 RID: 108759
		private readonly FColor BarDefaultColor = new FColor(byte.MaxValue, 133, 246, byte.MaxValue);

		// Token: 0x0401A8D8 RID: 108760
		[Nullable(2)]
		private SpecialEnergyBarQianXiaoSlot BarItem;

		// Token: 0x0401A8D9 RID: 108761
		private SpecialEnergyBarQianXiao.EState CurState;

		// Token: 0x0401A8DA RID: 108762
		private bool IsSpecialStateEnable;

		// Token: 0x0401A8DB RID: 108763
		private bool IsPlayWarnAnim;

		// Token: 0x0401A8DC RID: 108764
		private float WarningAnimPercent = 0.5f;

		// Token: 0x0200AB49 RID: 43849
		private enum EState
		{
			// Token: 0x04034FAC RID: 217004
			Normal,
			// Token: 0x04034FAD RID: 217005
			StayInAir,
			// Token: 0x04034FAE RID: 217006
			Special
		}

		// Token: 0x0200AB4A RID: 43850
		private enum EChildType
		{
			// Token: 0x04034FB0 RID: 217008
			EnergyBar,
			// Token: 0x04034FB1 RID: 217009
			SlotBarItem,
			// Token: 0x04034FB2 RID: 217010
			SlotBarPoint,
			// Token: 0x04034FB3 RID: 217011
			BarItemNormal,
			// Token: 0x04034FB4 RID: 217012
			BarTextureNormal,
			// Token: 0x04034FB5 RID: 217013
			BarItemAir,
			// Token: 0x04034FB6 RID: 217014
			BarTextureAir,
			// Token: 0x04034FB7 RID: 217015
			BarItemSpecial,
			// Token: 0x04034FB8 RID: 217016
			BarTextureSpecialLeft,
			// Token: 0x04034FB9 RID: 217017
			BarTextureSpecialRight,
			// Token: 0x04034FBA RID: 217018
			GearActiveTexture,
			// Token: 0x04034FBB RID: 217019
			GearItem,
			// Token: 0x04034FBC RID: 217020
			BarPointItem,
			// Token: 0x04034FBD RID: 217021
			AniGearActive,
			// Token: 0x04034FBE RID: 217022
			AniGear,
			// Token: 0x04034FBF RID: 217023
			AniAirState,
			// Token: 0x04034FC0 RID: 217024
			AniNormalState,
			// Token: 0x04034FC1 RID: 217025
			AniSpecialState,
			// Token: 0x04034FC2 RID: 217026
			AniRestore,
			// Token: 0x04034FC3 RID: 217027
			AniWarning,
			// Token: 0x04034FC4 RID: 217028
			AniStart,
			// Token: 0x04034FC5 RID: 217029
			GlowItem,
			// Token: 0x04034FC6 RID: 217030
			GlowSlider,
			// Token: 0x04034FC7 RID: 217031
			GlowBarTexture,
			// Token: 0x04034FC8 RID: 217032
			GlowBar2Texture
		}
	}
}
