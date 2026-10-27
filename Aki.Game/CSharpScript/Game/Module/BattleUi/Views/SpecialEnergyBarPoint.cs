using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E24 RID: 24100
	public class SpecialEnergyBarPoint : SpecialEnergyBarBase
	{
		// Token: 0x0603D4A3 RID: 251043 RVA: 0x00EC5440 File Offset: 0x00EC3640
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

		// Token: 0x0603D4A4 RID: 251044 RVA: 0x00EC54CC File Offset: 0x00EC36CC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarPoint.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarPoint.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4A5 RID: 251045 RVA: 0x00EC5510 File Offset: 0x00EC3710
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

		// Token: 0x0603D4A6 RID: 251046 RVA: 0x00EC555C File Offset: 0x00EC375C
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

		// Token: 0x0603D4A7 RID: 251047 RVA: 0x00EC55C8 File Offset: 0x00EC37C8
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

		// Token: 0x0603D4A8 RID: 251048 RVA: 0x00EC5606 File Offset: 0x00EC3806
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D4A9 RID: 251049 RVA: 0x00EC560F File Offset: 0x00EC380F
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D4AA RID: 251050 RVA: 0x00EC5618 File Offset: 0x00EC3818
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

		// Token: 0x0401FF61 RID: 130913
		private const int POINT_NUM = 41;

		// Token: 0x0401FF62 RID: 130914
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401FF63 RID: 130915
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401FF64 RID: 130916
		public bool IsMorph;

		// Token: 0x0200C1A0 RID: 49568
		private enum EChildType
		{
			// Token: 0x0403A826 RID: 239654
			PointItem,
			// Token: 0x0403A827 RID: 239655
			KeyContainerItem,
			// Token: 0x0403A828 RID: 239656
			BottomDescItem
		}
	}
}
