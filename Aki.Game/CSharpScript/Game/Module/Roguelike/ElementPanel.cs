using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD5 RID: 19925
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementPanel : UiPanelBase
	{
		// Token: 0x060336D5 RID: 210645 RVA: 0x00C02810 File Offset: 0x00C00A10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.AreaToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.TipToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.BtnMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060336D6 RID: 210646 RVA: 0x00C029A4 File Offset: 0x00C00BA4
		protected override UniTask OnBeforeStartAsync()
		{
			ElementPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ElementPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060336D7 RID: 210647 RVA: 0x00C029E8 File Offset: 0x00C00BE8
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<ElementItem, ElementInfo>(base.GetHorizontalLayout(2), new Func<ElementItem>(this.CreateElementItem), null, false, true);
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x060336D8 RID: 210648 RVA: 0x00C02A34 File Offset: 0x00C00C34
		private ElementItem CreateElementItem()
		{
			return new ElementItem();
		}

		// Token: 0x060336D9 RID: 210649 RVA: 0x00C02A3C File Offset: 0x00C00C3C
		private void AreaToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_UnChecked)
			{
				if (state == EToggleState.ETT_Checked)
				{
					base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
					base.GetItem(4).SetUIActive(true);
					return;
				}
			}
			else
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				base.GetItem(4).SetUIActive(false);
			}
		}

		// Token: 0x060336DA RID: 210650 RVA: 0x00C02A90 File Offset: 0x00C00C90
		private void TipToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_UnChecked)
			{
				if (state == EToggleState.ETT_Checked)
				{
					base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_Checked, false, false, false);
					base.GetItem(4).SetUIActive(true);
					return;
				}
			}
			else
			{
				base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				base.GetItem(4).SetUIActive(false);
			}
		}

		// Token: 0x060336DB RID: 210651 RVA: 0x00C02AE1 File Offset: 0x00C00CE1
		private void BtnMask()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x060336DC RID: 210652 RVA: 0x00C02AF4 File Offset: 0x00C00CF4
		public void Refresh(List<ElementInfo> elementInfoList)
		{
			this.RefreshInternal(elementInfoList, false);
		}

		// Token: 0x060336DD RID: 210653 RVA: 0x00C02B00 File Offset: 0x00C00D00
		[NullableContext(2)]
		public void Refresh(RogueGainEntry rogueGainEntry = null)
		{
			List<ElementInfo> list = new List<ElementInfo>();
			Dictionary<EElementType, ElementInfo> item = RoguelikeModel.Instance.GetSortElementInfoArrayMap((rogueGainEntry != null) ? rogueGainEntry.ElementDict : null).Item2;
			foreach (int num in RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.ElementList())
			{
				ElementInfo item2;
				if (!item.TryGetValue((EElementType)num, out item2))
				{
					item2 = new ElementInfo(num, 0, null);
				}
				list.Add(item2);
			}
			bool isPreview = rogueGainEntry != null && rogueGainEntry.ElementDict.Count > 0;
			this.RefreshInternal(list, isPreview);
		}

		// Token: 0x060336DE RID: 210654 RVA: 0x00C02BAC File Offset: 0x00C00DAC
		private void RefreshInternal(List<ElementInfo> elementInfoArray, bool isPreview)
		{
			this.ElementLayout.RefreshByData(elementInfoArray, null, false);
			int num = 0;
			foreach (ElementInfo elementInfo in elementInfoArray)
			{
				if (elementInfo.ElementId != 7)
				{
					num += elementInfo.Count;
				}
			}
			if (!isPreview)
			{
				base.GetText(1).SetText(num.ToString(), true);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RoguelikeView_17_Text", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
			}
			this.TipPanel.UpdateNum(num);
		}

		// Token: 0x0401B4D4 RID: 111828
		private TipPanel TipPanel;

		// Token: 0x0401B4D5 RID: 111829
		private GenericLayout<ElementItem, ElementInfo> ElementLayout;

		// Token: 0x0200AF4E RID: 44878
		[NullableContext(0)]
		private class EElementPanelCom
		{
			// Token: 0x040353AB RID: 218027
			public const int TipToggle = 0;

			// Token: 0x040353AC RID: 218028
			public const int TotalNumText = 1;

			// Token: 0x040353AD RID: 218029
			public const int ElementsLayout = 2;

			// Token: 0x040353AE RID: 218030
			public const int ElementItem = 3;

			// Token: 0x040353AF RID: 218031
			public const int TipItem = 4;

			// Token: 0x040353B0 RID: 218032
			public const int AreaToggle = 5;

			// Token: 0x040353B1 RID: 218033
			public const int BtnMask = 6;
		}
	}
}
