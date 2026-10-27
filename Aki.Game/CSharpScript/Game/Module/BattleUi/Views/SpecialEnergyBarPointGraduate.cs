using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E25 RID: 24101
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarPointGraduate : SpecialEnergyBarBase
	{
		// Token: 0x0603D4AC RID: 251052 RVA: 0x00EC563A File Offset: 0x00EC383A
		protected override void OnInitData()
		{
			this.LastPercent = this.PercentMachine.GetCurPercent();
		}

		// Token: 0x0603D4AD RID: 251053 RVA: 0x00EC5650 File Offset: 0x00EC3850
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D4AE RID: 251054 RVA: 0x00EC571C File Offset: 0x00EC391C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarPointGraduate.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarPointGraduate.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4AF RID: 251055 RVA: 0x00EC5760 File Offset: 0x00EC3960
		protected UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarPointGraduate.<InitSlotItem>d__15 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarPointGraduate.<InitSlotItem>d__15>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4B0 RID: 251056 RVA: 0x00EC57AC File Offset: 0x00EC39AC
		protected UniTask InitPointItem(UUIItem pointItem)
		{
			SpecialEnergyBarPointGraduate.<InitPointItem>d__16 <InitPointItem>d__;
			<InitPointItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointItem>d__.<>4__this = this;
			<InitPointItem>d__.pointItem = pointItem;
			<InitPointItem>d__.<>1__state = -1;
			<InitPointItem>d__.<>t__builder.Start<SpecialEnergyBarPointGraduate.<InitPointItem>d__16>(ref <InitPointItem>d__);
			return <InitPointItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4B1 RID: 251057 RVA: 0x00EC57F8 File Offset: 0x00EC39F8
		protected override void OnStart()
		{
			if (this.Config == null)
			{
				return;
			}
			if (this.Config.EffectColor != null)
			{
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				FColor fcolor2 = fcolor;
				if (this.Config.PointColor != null)
				{
					fcolor2 = FColor.FromHex(this.Config.PointColor);
				}
				SpecialEnergyBarPointItem pointItem = this.PointItem;
				if (pointItem != null)
				{
					pointItem.SetFullEffectColor(flinearColor, false);
				}
				SpecialEnergyBarSlotItem slotItem = this.SlotItem;
				if (slotItem != null)
				{
					slotItem.SetBarColor(fcolor);
				}
				SpecialEnergyBarSlotItem slotItem2 = this.SlotItem;
				if (slotItem2 != null)
				{
					slotItem2.SetPointColor(fcolor2);
				}
				SpecialEnergyBarSlotItem slotItem3 = this.SlotItem;
				if (slotItem3 != null)
				{
					slotItem3.SetFullEffectColor(flinearColor, false);
				}
			}
			UUIItem item = base.GetItem(2);
			this.GraduateItemList.Add(item);
			int num = this.Config.SlotNum - 1;
			if (num > 1)
			{
				AActor owner = item.GetOwner();
				UUIItem parentAsUIItem = item.GetParentAsUIItem();
				for (int i = 1; i < num; i++)
				{
					AActor aactor = LguiUtil.Instance.DuplicateActor(owner, parentAsUIItem);
					this.GraduateItemList.Add(aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
				}
			}
			else
			{
				item.SetUIActive(num > 0);
			}
			for (int j = 0; j < num; j++)
			{
				this.SetGraduateItemOffset(j, this.Config.ExtraFloatParams[j]);
			}
			base.GetItem(4).SetUIActive(!this.IsMorph);
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603D4B2 RID: 251058 RVA: 0x00EC5970 File Offset: 0x00EC3B70
		public void SetGraduateItemOffset(int index, float percent)
		{
			UUIItem valueOrDefault = this.GraduateItemList.GetValueOrDefault(index);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.SetAnchorOffsetX(369f * (percent - 0.5f));
		}

		// Token: 0x0603D4B3 RID: 251059 RVA: 0x00EC5998 File Offset: 0x00EC3B98
		protected virtual void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			bool changeVisible = false;
			if (this.IsKeyEnable != keyEnable)
			{
				this.IsKeyEnable = keyEnable;
				changeVisible = true;
			}
			SpecialEnergyBarSlotItem slotItem = this.SlotItem;
			if (slotItem != null)
			{
				slotItem.UpdatePercentWithVisible(curPercent, !keyEnable, changeVisible, isStart, this.LastPercent);
			}
			SpecialEnergyBarPointItem pointItem = this.PointItem;
			if (pointItem != null)
			{
				pointItem.UpdatePercentWithVisible(curPercent, keyEnable, changeVisible, isStart);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(keyEnable, isStart);
			}
			this.LastPercent = curPercent;
		}

		// Token: 0x0603D4B4 RID: 251060 RVA: 0x00EC5A19 File Offset: 0x00EC3C19
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D4B5 RID: 251061 RVA: 0x00EC5A22 File Offset: 0x00EC3C22
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D4B6 RID: 251062 RVA: 0x00EC5A2B File Offset: 0x00EC3C2B
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarPointItem pointItem = this.PointItem;
			if (pointItem != null)
			{
				pointItem.Tick(delta);
			}
			SpecialEnergyBarSlotItem slotItem = this.SlotItem;
			if (slotItem == null)
			{
				return;
			}
			slotItem.Tick(delta);
		}

		// Token: 0x0603D4B7 RID: 251063 RVA: 0x00EC5A57 File Offset: 0x00EC3C57
		public override void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			this.PointItem.ReplaceFullEffect(niagara);
			this.SlotItem.ReplaceFullEffect(niagara);
		}

		// Token: 0x0401FF65 RID: 130917
		private const int POINT_NUM = 41;

		// Token: 0x0401FF66 RID: 130918
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401FF67 RID: 130919
		private const float TOTAL_WIDTH = 369f;

		// Token: 0x0401FF68 RID: 130920
		[Nullable(2)]
		protected SpecialEnergyBarSlotItem SlotItem;

		// Token: 0x0401FF69 RID: 130921
		[Nullable(2)]
		protected SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401FF6A RID: 130922
		protected List<UUIItem> GraduateItemList = new List<UUIItem>();

		// Token: 0x0401FF6B RID: 130923
		protected bool IsKeyEnable;

		// Token: 0x0401FF6C RID: 130924
		protected float LastPercent;

		// Token: 0x0401FF6D RID: 130925
		protected bool NeedInitSlot = true;

		// Token: 0x0401FF6E RID: 130926
		protected bool NeedInitPoint = true;

		// Token: 0x0401FF6F RID: 130927
		public bool IsMorph;

		// Token: 0x0200C1A3 RID: 49571
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A833 RID: 239667
			SlotItem,
			// Token: 0x0403A834 RID: 239668
			PointItem,
			// Token: 0x0403A835 RID: 239669
			GraduateItem,
			// Token: 0x0403A836 RID: 239670
			KeyContainerItem,
			// Token: 0x0403A837 RID: 239671
			BottomDescItem
		}
	}
}
