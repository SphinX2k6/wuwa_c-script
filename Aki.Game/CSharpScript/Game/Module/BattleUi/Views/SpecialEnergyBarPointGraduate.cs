using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E0A RID: 19978
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarPointGraduate : SpecialEnergyBarBase
	{
		// Token: 0x0603243B RID: 205883 RVA: 0x00E16B9A File Offset: 0x00E14D9A
		protected override void OnInitData()
		{
			this.LastPercent = this.PercentMachine.GetCurPercent();
		}

		// Token: 0x0603243C RID: 205884 RVA: 0x00E16BB0 File Offset: 0x00E14DB0
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

		// Token: 0x0603243D RID: 205885 RVA: 0x00E16C7C File Offset: 0x00E14E7C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarPointGraduate.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarPointGraduate.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603243E RID: 205886 RVA: 0x00E16CC0 File Offset: 0x00E14EC0
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

		// Token: 0x0603243F RID: 205887 RVA: 0x00E16D0C File Offset: 0x00E14F0C
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

		// Token: 0x06032440 RID: 205888 RVA: 0x00E16D58 File Offset: 0x00E14F58
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

		// Token: 0x06032441 RID: 205889 RVA: 0x00E16ED0 File Offset: 0x00E150D0
		public void SetGraduateItemOffset(int index, float percent)
		{
			UUIItem valueOrDefault = this.GraduateItemList.GetValueOrDefault(index);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.SetAnchorOffsetX(369f * (percent - 0.5f));
		}

		// Token: 0x06032442 RID: 205890 RVA: 0x00E16EF8 File Offset: 0x00E150F8
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

		// Token: 0x06032443 RID: 205891 RVA: 0x00E16F79 File Offset: 0x00E15179
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032444 RID: 205892 RVA: 0x00E16F82 File Offset: 0x00E15182
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032445 RID: 205893 RVA: 0x00E16F8B File Offset: 0x00E1518B
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

		// Token: 0x06032446 RID: 205894 RVA: 0x00E16FB7 File Offset: 0x00E151B7
		public override void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			this.PointItem.ReplaceFullEffect(niagara);
			this.SlotItem.ReplaceFullEffect(niagara);
		}

		// Token: 0x0401AA2C RID: 109100
		private const int POINT_NUM = 41;

		// Token: 0x0401AA2D RID: 109101
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401AA2E RID: 109102
		private const float TOTAL_WIDTH = 369f;

		// Token: 0x0401AA2F RID: 109103
		[Nullable(2)]
		protected SpecialEnergyBarSlotItem SlotItem;

		// Token: 0x0401AA30 RID: 109104
		[Nullable(2)]
		protected SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401AA31 RID: 109105
		protected List<UUIItem> GraduateItemList = new List<UUIItem>();

		// Token: 0x0401AA32 RID: 109106
		protected bool IsKeyEnable;

		// Token: 0x0401AA33 RID: 109107
		protected float LastPercent;

		// Token: 0x0401AA34 RID: 109108
		protected bool NeedInitSlot = true;

		// Token: 0x0401AA35 RID: 109109
		protected bool NeedInitPoint = true;

		// Token: 0x0401AA36 RID: 109110
		public bool IsMorph;

		// Token: 0x0200ABB2 RID: 43954
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035225 RID: 217637
			SlotItem,
			// Token: 0x04035226 RID: 217638
			PointItem,
			// Token: 0x04035227 RID: 217639
			GraduateItem,
			// Token: 0x04035228 RID: 217640
			KeyContainerItem,
			// Token: 0x04035229 RID: 217641
			BottomDescItem
		}
	}
}
