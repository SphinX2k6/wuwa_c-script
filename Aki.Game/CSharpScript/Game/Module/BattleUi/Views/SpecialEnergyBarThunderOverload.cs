using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DEB RID: 19947
	public class SpecialEnergyBarThunderOverload : SpecialEnergyBarMorphCountDown
	{
		// Token: 0x060322D6 RID: 205526 RVA: 0x00E0FD30 File Offset: 0x00E0DF30
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

		// Token: 0x060322D7 RID: 205527 RVA: 0x00E0FE20 File Offset: 0x00E0E020
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarThunderOverload.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarThunderOverload.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060322D8 RID: 205528 RVA: 0x00E0FE63 File Offset: 0x00E0E063
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshKeyEnable(true);
		}

		// Token: 0x060322D9 RID: 205529 RVA: 0x00E0FE72 File Offset: 0x00E0E072
		protected override ValueTuple<float, float> GetEffectBasePercents(float effectBasePercent)
		{
			return new ValueTuple<float, float>(1f, effectBasePercent);
		}

		// Token: 0x060322DA RID: 205530 RVA: 0x00E0FE7F File Offset: 0x00E0E07F
		protected override ValueTuple<int, int> GetEffectPointNums(int pointNum)
		{
			return new ValueTuple<int, int>(17, 17);
		}

		// Token: 0x060322DB RID: 205531 RVA: 0x00E0FE8A File Offset: 0x00E0E08A
		protected override int GetUseEffectPointOffsetNum(int pointNum)
		{
			return Math.Max(0, pointNum - 17);
		}

		// Token: 0x060322DC RID: 205532 RVA: 0x00E0FE96 File Offset: 0x00E0E096
		protected override void OnBarPercentChanged()
		{
			base.OnBarPercentChanged();
			this.RefreshKeyEnable(false);
		}

		// Token: 0x060322DD RID: 205533 RVA: 0x00E0FEA5 File Offset: 0x00E0E0A5
		protected override void OnKeyEnableChanged()
		{
			this.RefreshKeyEnable(false);
		}

		// Token: 0x060322DE RID: 205534 RVA: 0x00E0FEAE File Offset: 0x00E0E0AE
		private void RefreshKeyEnable(bool isStart = false)
		{
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x0401A963 RID: 108899
		private const int FULL_EFFECT_POINT_NUM = 17;

		// Token: 0x0200AB76 RID: 43894
		private enum EChildType
		{
			// Token: 0x040350C5 RID: 217285
			PointLeftItem,
			// Token: 0x040350C6 RID: 217286
			PointRightItem,
			// Token: 0x040350C7 RID: 217287
			IconTexture,
			// Token: 0x040350C8 RID: 217288
			StartEffect,
			// Token: 0x040350C9 RID: 217289
			AnimItem,
			// Token: 0x040350CA RID: 217290
			KeyContainerItem
		}
	}
}
