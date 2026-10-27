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
	// Token: 0x02005E11 RID: 24081
	public class SpecialEnergyBarXuanling : SpecialEnergyBarBase
	{
		// Token: 0x0603D3CA RID: 250826 RVA: 0x00EC16E8 File Offset: 0x00EBF8E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
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
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D3CB RID: 250827 RVA: 0x00EC18A0 File Offset: 0x00EBFAA0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXuanling.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXuanling.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D3CC RID: 250828 RVA: 0x00EC18E4 File Offset: 0x00EBFAE4
		private UniTask InitBarItem()
		{
			SpecialEnergyBarXuanling.<InitBarItem>d__13 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarXuanling.<InitBarItem>d__13>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D3CD RID: 250829 RVA: 0x00EC1928 File Offset: 0x00EBFB28
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXuanling.SoftSwordTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSoftSwordTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXuanling.EnergyEmptyTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyEmptyTagChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnSpEnergyChanged));
		}

		// Token: 0x0603D3CE RID: 250830 RVA: 0x00EC197D File Offset: 0x00EBFB7D
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnSpEnergyChanged));
		}

		// Token: 0x0603D3CF RID: 250831 RVA: 0x00EC199C File Offset: 0x00EBFB9C
		protected override void OnStart()
		{
			base.InitTweenAnim(2);
			base.InitTweenAnim(3);
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			this.RefreshState(true);
			this.RefreshEmptyState(true);
			this.RefreshSpEnergyState(true);
		}

		// Token: 0x0603D3D0 RID: 250832 RVA: 0x00EC1A07 File Offset: 0x00EBFC07
		private void OnSoftSwordTagChanged(int tagId, bool tagExist)
		{
			this.SetSwordState(tagExist ? SpecialEnergyBarXuanling.ESwordState.SoftSword : SpecialEnergyBarXuanling.ESwordState.HardSword, false);
		}

		// Token: 0x0603D3D1 RID: 250833 RVA: 0x00EC1A17 File Offset: 0x00EBFC17
		private void OnEnergyEmptyTagChanged(int tagId, bool tagExist)
		{
			this.SetEmptyState(tagExist, false);
		}

		// Token: 0x0603D3D2 RID: 250834 RVA: 0x00EC1A21 File Offset: 0x00EBFC21
		private void OnSpEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SetSpEnergyState(this.CalcSpEnergyState(newValue), false);
		}

		// Token: 0x0603D3D3 RID: 250835 RVA: 0x00EC1A34 File Offset: 0x00EBFC34
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetSwordState((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarXuanling.SoftSwordTagId)) ? SpecialEnergyBarXuanling.ESwordState.SoftSword : SpecialEnergyBarXuanling.ESwordState.HardSword, isStart);
		}

		// Token: 0x0603D3D4 RID: 250836 RVA: 0x00EC1A68 File Offset: 0x00EBFC68
		private void RefreshEmptyState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			bool isEmpty = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarXuanling.EnergyEmptyTagId);
			this.SetEmptyState(isEmpty, isStart);
		}

		// Token: 0x0603D3D5 RID: 250837 RVA: 0x00EC1A98 File Offset: 0x00EBFC98
		private void RefreshSpEnergyState(bool isStart = false)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float spEnergy = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2) : 0f;
			this.SetSpEnergyState(this.CalcSpEnergyState(spEnergy), isStart);
		}

		// Token: 0x0603D3D6 RID: 250838 RVA: 0x00EC1ACC File Offset: 0x00EBFCCC
		private SpecialEnergyBarXuanling.ESpEnergyState CalcSpEnergyState(float spEnergy)
		{
			if (spEnergy <= 0f)
			{
				return SpecialEnergyBarXuanling.ESpEnergyState.Zero;
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max) : 0f;
			if (num > 0f && spEnergy >= num)
			{
				return SpecialEnergyBarXuanling.ESpEnergyState.Full;
			}
			return SpecialEnergyBarXuanling.ESpEnergyState.Half;
		}

		// Token: 0x0603D3D7 RID: 250839 RVA: 0x00EC1B0C File Offset: 0x00EBFD0C
		private void SetSwordState(SpecialEnergyBarXuanling.ESwordState state, bool isStart = false)
		{
			if (this.CurSwordState == state && !isStart)
			{
				return;
			}
			this.CurSwordState = state;
			if (state == SpecialEnergyBarXuanling.ESwordState.SoftSword)
			{
				base.StopTweenAnim(8);
				base.PlayTweenAnim(4);
			}
			else
			{
				base.StopTweenAnim(4);
				base.PlayTweenAnim(8);
			}
			this.SetSpEnergyState(this.CurSpEnergyState, true);
		}

		// Token: 0x0603D3D8 RID: 250840 RVA: 0x00EC1B5C File Offset: 0x00EBFD5C
		private void SetEmptyState(bool isEmpty, bool isStart = false)
		{
			if (this.IsEmpty == isEmpty && !isStart)
			{
				return;
			}
			this.IsEmpty = isEmpty;
			if (isEmpty)
			{
				base.StopTweenAnim(3);
				base.PlayTweenAnim(2);
				return;
			}
			base.StopTweenAnim(2);
			base.PlayTweenAnim(3);
		}

		// Token: 0x0603D3D9 RID: 250841 RVA: 0x00EC1B94 File Offset: 0x00EBFD94
		private void SetSpEnergyState(SpecialEnergyBarXuanling.ESpEnergyState state, bool isStart = false)
		{
			if (this.CurSpEnergyState == state && !isStart)
			{
				return;
			}
			this.CurSpEnergyState = state;
			SpecialEnergyBarXuanlingSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.SetKeyActionBySpEnergy(state == SpecialEnergyBarXuanling.ESpEnergyState.Full, isStart);
			}
			if (this.CurSwordState == SpecialEnergyBarXuanling.ESwordState.SoftSword)
			{
				switch (state)
				{
				case SpecialEnergyBarXuanling.ESpEnergyState.Zero:
					base.StopTweenAnim(6);
					base.StopTweenAnim(7);
					base.PlayTweenAnim(5);
					return;
				case SpecialEnergyBarXuanling.ESpEnergyState.Half:
					base.StopTweenAnim(5);
					base.StopTweenAnim(7);
					base.PlayTweenAnim(6);
					return;
				case SpecialEnergyBarXuanling.ESpEnergyState.Full:
					base.StopTweenAnim(5);
					base.StopTweenAnim(6);
					base.PlayTweenAnim(7);
					return;
				default:
					return;
				}
			}
			else
			{
				switch (state)
				{
				case SpecialEnergyBarXuanling.ESpEnergyState.Zero:
					base.StopTweenAnim(10);
					base.StopTweenAnim(11);
					base.PlayTweenAnim(9);
					return;
				case SpecialEnergyBarXuanling.ESpEnergyState.Half:
					base.StopTweenAnim(9);
					base.StopTweenAnim(11);
					base.PlayTweenAnim(10);
					return;
				case SpecialEnergyBarXuanling.ESpEnergyState.Full:
					base.StopTweenAnim(9);
					base.StopTweenAnim(10);
					base.PlayTweenAnim(11);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0603D3DA RID: 250842 RVA: 0x00EC1C86 File Offset: 0x00EBFE86
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarXuanlingSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x0401FEEF RID: 130799
		[StaticVariableRuleIgnore]
		private static readonly int SoftSwordTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XuanlingMd10011.逻辑.副武器"];

		// Token: 0x0401FEF0 RID: 130800
		[StaticVariableRuleIgnore]
		private static readonly int EnergyEmptyTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XuanlingMd10011.状态.满特殊能量1"];

		// Token: 0x0401FEF1 RID: 130801
		private const EAttributeType SpEnergyAttrId = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FEF2 RID: 130802
		private const EAttributeType SpEnergyMaxAttrId = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FEF3 RID: 130803
		[Nullable(2)]
		private SpecialEnergyBarXuanlingSlot BarItem;

		// Token: 0x0401FEF4 RID: 130804
		private bool IsEmpty;

		// Token: 0x0401FEF5 RID: 130805
		private SpecialEnergyBarXuanling.ESwordState CurSwordState;

		// Token: 0x0401FEF6 RID: 130806
		private SpecialEnergyBarXuanling.ESpEnergyState CurSpEnergyState;

		// Token: 0x0200C17B RID: 49531
		private enum EChildType
		{
			// Token: 0x0403A762 RID: 239458
			SlotBarItem,
			// Token: 0x0403A763 RID: 239459
			PnlWing,
			// Token: 0x0403A764 RID: 239460
			EmptyStart,
			// Token: 0x0403A765 RID: 239461
			EmptyClose,
			// Token: 0x0403A766 RID: 239462
			LogicAnimSoft,
			// Token: 0x0403A767 RID: 239463
			LogicAnimSoftSPZero,
			// Token: 0x0403A768 RID: 239464
			LogicAnimSoftSPHalf,
			// Token: 0x0403A769 RID: 239465
			LogicAnimSoftSPFull,
			// Token: 0x0403A76A RID: 239466
			LogicAnimHard,
			// Token: 0x0403A76B RID: 239467
			LogicAnimHardZero,
			// Token: 0x0403A76C RID: 239468
			LogicAnimHardHalf,
			// Token: 0x0403A76D RID: 239469
			LogicAnimHardFull
		}

		// Token: 0x0200C17C RID: 49532
		private enum ESwordState
		{
			// Token: 0x0403A76F RID: 239471
			HardSword,
			// Token: 0x0403A770 RID: 239472
			SoftSword
		}

		// Token: 0x0200C17D RID: 49533
		private enum ESpEnergyState
		{
			// Token: 0x0403A772 RID: 239474
			Zero,
			// Token: 0x0403A773 RID: 239475
			Half,
			// Token: 0x0403A774 RID: 239476
			Full
		}
	}
}
