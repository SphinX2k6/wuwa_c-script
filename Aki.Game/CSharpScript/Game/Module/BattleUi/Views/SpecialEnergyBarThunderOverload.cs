using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E06 RID: 24070
	public class SpecialEnergyBarThunderOverload : SpecialEnergyBarMorphCountDown
	{
		// Token: 0x0603D347 RID: 250695 RVA: 0x00EBE7D0 File Offset: 0x00EBC9D0
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D348 RID: 250696 RVA: 0x00EBE8C0 File Offset: 0x00EBCAC0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarThunderOverload.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarThunderOverload.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D349 RID: 250697 RVA: 0x00EBE903 File Offset: 0x00EBCB03
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshKeyEnable(true);
		}

		// Token: 0x0603D34A RID: 250698 RVA: 0x00EBE912 File Offset: 0x00EBCB12
		protected override ValueTuple<float, float> GetEffectBasePercents(float effectBasePercent)
		{
			return new ValueTuple<float, float>(1f, effectBasePercent);
		}

		// Token: 0x0603D34B RID: 250699 RVA: 0x00EBE91F File Offset: 0x00EBCB1F
		protected override ValueTuple<int, int> GetEffectPointNums(int pointNum)
		{
			return new ValueTuple<int, int>(17, 17);
		}

		// Token: 0x0603D34C RID: 250700 RVA: 0x00EBE92A File Offset: 0x00EBCB2A
		protected override int GetUseEffectPointOffsetNum(int pointNum)
		{
			return Math.Max(0, pointNum - 17);
		}

		// Token: 0x0603D34D RID: 250701 RVA: 0x00EBE936 File Offset: 0x00EBCB36
		protected override void OnBarPercentChanged()
		{
			base.OnBarPercentChanged();
			this.RefreshKeyEnable(false);
		}

		// Token: 0x0603D34E RID: 250702 RVA: 0x00EBE945 File Offset: 0x00EBCB45
		protected override void OnKeyEnableChanged()
		{
			this.RefreshKeyEnable(false);
		}

		// Token: 0x0603D34F RID: 250703 RVA: 0x00EBE94E File Offset: 0x00EBCB4E
		private void RefreshKeyEnable(bool isStart = false)
		{
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x0401FE9C RID: 130716
		private const int FULL_EFFECT_POINT_NUM = 17;

		// Token: 0x0200C167 RID: 49511
		private enum EChildType
		{
			// Token: 0x0403A6D3 RID: 239315
			PointLeftItem,
			// Token: 0x0403A6D4 RID: 239316
			PointRightItem,
			// Token: 0x0403A6D5 RID: 239317
			IconTexture,
			// Token: 0x0403A6D6 RID: 239318
			StartEffect,
			// Token: 0x0403A6D7 RID: 239319
			AnimItem,
			// Token: 0x0403A6D8 RID: 239320
			KeyContainerItem
		}
	}
}
