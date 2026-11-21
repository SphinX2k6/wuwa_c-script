using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E09 RID: 19977
	public class SpecialEnergyBarPoint : SpecialEnergyBarBase
	{
		// Token: 0x06032432 RID: 205874 RVA: 0x00E169A0 File Offset: 0x00E14BA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032433 RID: 205875 RVA: 0x00E16A2C File Offset: 0x00E14C2C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarPoint.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarPoint.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032434 RID: 205876 RVA: 0x00E16A70 File Offset: 0x00E14C70
		[NullableContext(1)]
		protected UniTask InitPointItem(UUIItem pointItem)
		{
			SpecialEnergyBarPoint.<InitPointItem>d__7 <InitPointItem>d__;
			<InitPointItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointItem>d__.<>4__this = this;
			<InitPointItem>d__.pointItem = pointItem;
			<InitPointItem>d__.<>1__state = -1;
			<InitPointItem>d__.<>t__builder.Start<SpecialEnergyBarPoint.<InitPointItem>d__7>(ref <InitPointItem>d__);
			return <InitPointItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032435 RID: 205877 RVA: 0x00E16ABC File Offset: 0x00E14CBC
		protected override void OnStart()
		{
			if (this.Config == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.Config.EffectColor))
			{
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				this.PointItem.SetFullEffectColor(flinearColor, false);
			}
			base.GetItem(2).SetUIActive(!this.IsMorph);
			this.RefreshBarPercent(true);
		}

		// Token: 0x06032436 RID: 205878 RVA: 0x00E16B28 File Offset: 0x00E14D28
		protected void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.PointItem.UpdatePercent(curPercent, true, 0);
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x06032437 RID: 205879 RVA: 0x00E16B66 File Offset: 0x00E14D66
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032438 RID: 205880 RVA: 0x00E16B6F File Offset: 0x00E14D6F
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032439 RID: 205881 RVA: 0x00E16B78 File Offset: 0x00E14D78
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarPointItem pointItem = this.PointItem;
			if (pointItem == null)
			{
				return;
			}
			pointItem.Tick(delta);
		}

		// Token: 0x0401AA28 RID: 109096
		private const int POINT_NUM = 41;

		// Token: 0x0401AA29 RID: 109097
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401AA2A RID: 109098
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401AA2B RID: 109099
		public bool IsMorph;

		// Token: 0x0200ABAF RID: 43951
		private enum EChildType
		{
			// Token: 0x04035218 RID: 217624
			PointItem,
			// Token: 0x04035219 RID: 217625
			KeyContainerItem,
			// Token: 0x0403521A RID: 217626
			BottomDescItem
		}
	}
}
