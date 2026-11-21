using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005928 RID: 22824
	public class SolarSchoolPrizeDrawTipCostItem : UiPanelBase
	{
		// Token: 0x060383EB RID: 230379 RVA: 0x00FBA364 File Offset: 0x00FB8564
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnTipCostClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060383EC RID: 230380 RVA: 0x00FBA46D File Offset: 0x00FB866D
		protected override void OnStart()
		{
			this.Refresh();
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x060383ED RID: 230381 RVA: 0x00FBA4AD File Offset: 0x00FB86AD
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x060383EE RID: 230382 RVA: 0x00FBA4E8 File Offset: 0x00FB86E8
		public void Refresh()
		{
			SolarSchoolPrizeDrawingCenter instance = SolarSchoolPrizeDrawingCenter.Instance;
			SolarSchoolCostCurrency costA = instance.GetCostA();
			bool flag = instance.GetCurrencyCount(costA) <= 0;
			SolarSchoolCostCurrency currency = flag ? instance.GetCostB() : costA;
			string path = flag ? UiResourceConfig.Instance.GetResourcePath("T_IconSolarSchoolZS00Coin") : instance.GetCurrencyIcon(currency);
			base.SetTextureByPath(path, base.GetTexture(3), null, null);
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText(instance.GetCurrencyCount(currency).ToString(), true);
		}

		// Token: 0x060383EF RID: 230383 RVA: 0x00FBA572 File Offset: 0x00FB8772
		private void OnItemChanged(int itemId)
		{
			if (this.MatchesCurrency(ESolarSchoolCostSource.Item, itemId))
			{
				this.Refresh();
			}
		}

		// Token: 0x060383F0 RID: 230384 RVA: 0x00FBA584 File Offset: 0x00FB8784
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (this.MatchesCurrency(ESolarSchoolCostSource.Attr, (int)attr))
			{
				this.Refresh();
			}
		}

		// Token: 0x060383F1 RID: 230385 RVA: 0x00FBA598 File Offset: 0x00FB8798
		private bool MatchesCurrency(ESolarSchoolCostSource source, int id)
		{
			SolarSchoolPrizeDrawingCenter instance = SolarSchoolPrizeDrawingCenter.Instance;
			SolarSchoolCostCurrency costA = instance.GetCostA();
			SolarSchoolCostCurrency costB = instance.GetCostB();
			return (costA.Source == source && costA.Id == id) || (costB.Source == source && costB.Id == id);
		}

		// Token: 0x060383F2 RID: 230386 RVA: 0x00FBA5DF File Offset: 0x00FB87DF
		private void OnBtnTipCostClick()
		{
		}

		// Token: 0x0200B4E6 RID: 46310
		private class EComponents
		{
			// Token: 0x04037EEC RID: 229100
			public const int BtnTipCost = 0;

			// Token: 0x04037EED RID: 229101
			public const int TexIcon = 1;

			// Token: 0x04037EEE RID: 229102
			public const int TxtValue = 2;

			// Token: 0x04037EEF RID: 229103
			public const int TexCoinIcon = 3;

			// Token: 0x04037EF0 RID: 229104
			public const int TxtNum = 4;
		}
	}
}
