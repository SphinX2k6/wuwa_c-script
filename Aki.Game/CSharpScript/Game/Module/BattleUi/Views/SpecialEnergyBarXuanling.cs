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
	// Token: 0x02004DF6 RID: 19958
	public class SpecialEnergyBarXuanling : SpecialEnergyBarBase
	{
		// Token: 0x06032359 RID: 205657 RVA: 0x00E12C48 File Offset: 0x00E10E48
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

		// Token: 0x0603235A RID: 205658 RVA: 0x00E12E00 File Offset: 0x00E11000
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXuanling.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXuanling.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603235B RID: 205659 RVA: 0x00E12E44 File Offset: 0x00E11044
		private UniTask InitBarItem()
		{
			SpecialEnergyBarXuanling.<InitBarItem>d__13 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarXuanling.<InitBarItem>d__13>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603235C RID: 205660 RVA: 0x00E12E88 File Offset: 0x00E11088
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXuanling.SoftSwordTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnSoftSwordTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarXuanling.EnergyEmptyTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyEmptyTagChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnSpEnergyChanged));
		}

		// Token: 0x0603235D RID: 205661 RVA: 0x00E12EDD File Offset: 0x00E110DD
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnSpEnergyChanged));
		}

		// Token: 0x0603235E RID: 205662 RVA: 0x00E12EFC File Offset: 0x00E110FC
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

		// Token: 0x0603235F RID: 205663 RVA: 0x00E12F67 File Offset: 0x00E11167
		private void OnSoftSwordTagChanged(int tagId, bool tagExist)
		{
			this.SetSwordState(tagExist ? SpecialEnergyBarXuanling.ESwordState.SoftSword : SpecialEnergyBarXuanling.ESwordState.HardSword, false);
		}

		// Token: 0x06032360 RID: 205664 RVA: 0x00E12F77 File Offset: 0x00E11177
		private void OnEnergyEmptyTagChanged(int tagId, bool tagExist)
		{
			this.SetEmptyState(tagExist, false);
		}

		// Token: 0x06032361 RID: 205665 RVA: 0x00E12F81 File Offset: 0x00E11181
		private void OnSpEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SetSpEnergyState(this.CalcSpEnergyState(newValue), false);
		}

		// Token: 0x06032362 RID: 205666 RVA: 0x00E12F94 File Offset: 0x00E11194
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetSwordState((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarXuanling.SoftSwordTagId)) ? SpecialEnergyBarXuanling.ESwordState.SoftSword : SpecialEnergyBarXuanling.ESwordState.HardSword, isStart);
		}

		// Token: 0x06032363 RID: 205667 RVA: 0x00E12FC8 File Offset: 0x00E111C8
		private void RefreshEmptyState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			bool isEmpty = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarXuanling.EnergyEmptyTagId);
			this.SetEmptyState(isEmpty, isStart);
		}

		// Token: 0x06032364 RID: 205668 RVA: 0x00E12FF8 File Offset: 0x00E111F8
		private void RefreshSpEnergyState(bool isStart = false)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float spEnergy = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2) : 0f;
			this.SetSpEnergyState(this.CalcSpEnergyState(spEnergy), isStart);
		}

		// Token: 0x06032365 RID: 205669 RVA: 0x00E1302C File Offset: 0x00E1122C
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

		// Token: 0x06032366 RID: 205670 RVA: 0x00E1306C File Offset: 0x00E1126C
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

		// Token: 0x06032367 RID: 205671 RVA: 0x00E130BC File Offset: 0x00E112BC
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

		// Token: 0x06032368 RID: 205672 RVA: 0x00E130F4 File Offset: 0x00E112F4
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

		// Token: 0x06032369 RID: 205673 RVA: 0x00E131E6 File Offset: 0x00E113E6
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

		// Token: 0x0401A9B6 RID: 108982
		[StaticVariableRuleIgnore]
		private static readonly int SoftSwordTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XuanlingMd10011.逻辑.副武器"];

		// Token: 0x0401A9B7 RID: 108983
		[StaticVariableRuleIgnore]
		private static readonly int EnergyEmptyTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1XuanlingMd10011.状态.满特殊能量1"];

		// Token: 0x0401A9B8 RID: 108984
		private const EAttributeType SpEnergyAttrId = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A9B9 RID: 108985
		private const EAttributeType SpEnergyMaxAttrId = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A9BA RID: 108986
		[Nullable(2)]
		private SpecialEnergyBarXuanlingSlot BarItem;

		// Token: 0x0401A9BB RID: 108987
		private bool IsEmpty;

		// Token: 0x0401A9BC RID: 108988
		private SpecialEnergyBarXuanling.ESwordState CurSwordState;

		// Token: 0x0401A9BD RID: 108989
		private SpecialEnergyBarXuanling.ESpEnergyState CurSpEnergyState;

		// Token: 0x0200AB8A RID: 43914
		private enum EChildType
		{
			// Token: 0x04035154 RID: 217428
			SlotBarItem,
			// Token: 0x04035155 RID: 217429
			PnlWing,
			// Token: 0x04035156 RID: 217430
			EmptyStart,
			// Token: 0x04035157 RID: 217431
			EmptyClose,
			// Token: 0x04035158 RID: 217432
			LogicAnimSoft,
			// Token: 0x04035159 RID: 217433
			LogicAnimSoftSPZero,
			// Token: 0x0403515A RID: 217434
			LogicAnimSoftSPHalf,
			// Token: 0x0403515B RID: 217435
			LogicAnimSoftSPFull,
			// Token: 0x0403515C RID: 217436
			LogicAnimHard,
			// Token: 0x0403515D RID: 217437
			LogicAnimHardZero,
			// Token: 0x0403515E RID: 217438
			LogicAnimHardHalf,
			// Token: 0x0403515F RID: 217439
			LogicAnimHardFull
		}

		// Token: 0x0200AB8B RID: 43915
		private enum ESwordState
		{
			// Token: 0x04035161 RID: 217441
			HardSword,
			// Token: 0x04035162 RID: 217442
			SoftSword
		}

		// Token: 0x0200AB8C RID: 43916
		private enum ESpEnergyState
		{
			// Token: 0x04035164 RID: 217444
			Zero,
			// Token: 0x04035165 RID: 217445
			Half,
			// Token: 0x04035166 RID: 217446
			Full
		}
	}
}
