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
	// Token: 0x02003D9E RID: 15774
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementPanel : UiPanelBase
	{
		// Token: 0x06028542 RID: 165186 RVA: 0x00B4BD68 File Offset: 0x00B49F68
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

		// Token: 0x06028543 RID: 165187 RVA: 0x00B4BEFC File Offset: 0x00B4A0FC
		protected override UniTask OnBeforeStartAsync()
		{
			ElementPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ElementPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028544 RID: 165188 RVA: 0x00B4BF40 File Offset: 0x00B4A140
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<ElementItem, ElementInfo>(base.GetHorizontalLayout(2), new Func<ElementItem>(this.CreateElementItem), null, false, true);
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x06028545 RID: 165189 RVA: 0x00B4BF8C File Offset: 0x00B4A18C
		private ElementItem CreateElementItem()
		{
			return new ElementItem();
		}

		// Token: 0x06028546 RID: 165190 RVA: 0x00B4BF94 File Offset: 0x00B4A194
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

		// Token: 0x06028547 RID: 165191 RVA: 0x00B4BFE8 File Offset: 0x00B4A1E8
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

		// Token: 0x06028548 RID: 165192 RVA: 0x00B4C039 File Offset: 0x00B4A239
		private void BtnMask()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		}

		// Token: 0x06028549 RID: 165193 RVA: 0x00B4C04C File Offset: 0x00B4A24C
		public void Refresh(List<ElementInfo> elementInfoList)
		{
			this.RefreshInternal(elementInfoList, false);
		}

		// Token: 0x0602854A RID: 165194 RVA: 0x00B4C058 File Offset: 0x00B4A258
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

		// Token: 0x0602854B RID: 165195 RVA: 0x00B4C104 File Offset: 0x00B4A304
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

		// Token: 0x04015EA7 RID: 89767
		private TipPanel TipPanel;

		// Token: 0x04015EA8 RID: 89768
		private GenericLayout<ElementItem, ElementInfo> ElementLayout;

		// Token: 0x02009983 RID: 39299
		[NullableContext(0)]
		private class EElementPanelCom
		{
			// Token: 0x0402FDE0 RID: 196064
			public const int TipToggle = 0;

			// Token: 0x0402FDE1 RID: 196065
			public const int TotalNumText = 1;

			// Token: 0x0402FDE2 RID: 196066
			public const int ElementsLayout = 2;

			// Token: 0x0402FDE3 RID: 196067
			public const int ElementItem = 3;

			// Token: 0x0402FDE4 RID: 196068
			public const int TipItem = 4;

			// Token: 0x0402FDE5 RID: 196069
			public const int AreaToggle = 5;

			// Token: 0x0402FDE6 RID: 196070
			public const int BtnMask = 6;
		}
	}
}
