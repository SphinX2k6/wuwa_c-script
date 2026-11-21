using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02004965 RID: 18789
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantQuestGuideItem : UiPanelBase, IGridProxy<IGiantQuestGuideData>
	{
		// Token: 0x17005F3C RID: 24380
		// (get) Token: 0x0602F1D9 RID: 192985 RVA: 0x00D22DEA File Offset: 0x00D20FEA
		// (set) Token: 0x0602F1DA RID: 192986 RVA: 0x00D22DF2 File Offset: 0x00D20FF2
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<IGiantQuestGuideData>, IGiantQuestGuideData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17005F3D RID: 24381
		// (get) Token: 0x0602F1DB RID: 192987 RVA: 0x00D22DFB File Offset: 0x00D20FFB
		// (set) Token: 0x0602F1DC RID: 192988 RVA: 0x00D22E03 File Offset: 0x00D21003
		public int GridIndex { get; set; }

		// Token: 0x17005F3E RID: 24382
		// (get) Token: 0x0602F1DD RID: 192989 RVA: 0x00D22E0C File Offset: 0x00D2100C
		// (set) Token: 0x0602F1DE RID: 192990 RVA: 0x00D22E14 File Offset: 0x00D21014
		public int DisplayIndex { get; set; }

		// Token: 0x0602F1DF RID: 192991 RVA: 0x00D22E20 File Offset: 0x00D21020
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickGoto));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602F1E0 RID: 192992 RVA: 0x00D22F8C File Offset: 0x00D2118C
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(() => false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 != null)
			{
				extendToggle2.OnHover.Add(new Action(this.OnPointEnter));
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
			object obj;
			if (scrollViewWithScrollbar == null)
			{
				obj = null;
			}
			else
			{
				AUIBaseActor content = scrollViewWithScrollbar.GetContent();
				obj = ((content != null) ? content.GetComponentByClass(UUILayoutBase.StaticClass()) : null);
			}
			UUILayoutBase uuilayoutBase = obj as UUILayoutBase;
			if (uuilayoutBase != null)
			{
				this.IconLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(uuilayoutBase, () => new CommonItemSmallItemGrid(), null, false, true);
			}
		}

		// Token: 0x0602F1E1 RID: 192993 RVA: 0x00D23054 File Offset: 0x00D21254
		public void Refresh(IGiantQuestGuideData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(data.DescText, true);
			}
			bool flag = data.State == EGiantQuestGuideState.Done;
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
			if (scrollViewWithScrollbar != null)
			{
				UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(!flag);
				}
			}
			this.RefreshIcons(flag ? new List<IGiantQuestGuideItemInfo>() : data.Items);
			this.RefreshState(data);
		}

		// Token: 0x0602F1E2 RID: 192994 RVA: 0x00D230D4 File Offset: 0x00D212D4
		private void RefreshIcons(List<IGiantQuestGuideItemInfo> items)
		{
			if (this.IconLayout == null)
			{
				return;
			}
			List<TItem> list = new List<TItem>();
			foreach (IGiantQuestGuideItemInfo giantQuestGuideItemInfo in items)
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(giantQuestGuideItemInfo.ItemId, 0), giantQuestGuideItemInfo.Count));
			}
			this.IconLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0602F1E3 RID: 192995 RVA: 0x00D23158 File Offset: 0x00D21358
		private void RefreshState(IGiantQuestGuideData data)
		{
			bool flag = data.State == EGiantQuestGuideState.Locked;
			bool flag2 = data.State == EGiantQuestGuideState.Done;
			bool flag3 = data.State == EGiantQuestGuideState.CanGoto;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(flag);
			}
			if (flag)
			{
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.SetText(data.LockedText, true);
				}
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag3 && data.HasSkip);
				}
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(flag2 ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(data.HasNew);
		}

		// Token: 0x0602F1E4 RID: 192996 RVA: 0x00D23229 File Offset: 0x00D21429
		public void Clear()
		{
		}

		// Token: 0x0602F1E5 RID: 192997 RVA: 0x00D2322B File Offset: 0x00D2142B
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnHover.Remove(new Action(this.OnPointEnter));
		}

		// Token: 0x0602F1E6 RID: 192998 RVA: 0x00D2324F File Offset: 0x00D2144F
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602F1E7 RID: 192999 RVA: 0x00D23251 File Offset: 0x00D21451
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602F1E8 RID: 193000 RVA: 0x00D23253 File Offset: 0x00D21453
		public object GetKey(IGiantQuestGuideData data, int gridIndex)
		{
			return data.AccessId;
		}

		// Token: 0x0602F1E9 RID: 193001 RVA: 0x00D23260 File Offset: 0x00D21460
		private void OnPointEnter()
		{
			Action<int> onHoverCallBack = this.OnHoverCallBack;
			if (onHoverCallBack == null)
			{
				return;
			}
			onHoverCallBack(this.GridIndex);
		}

		// Token: 0x0602F1EA RID: 193002 RVA: 0x00D23278 File Offset: 0x00D21478
		private void OnClickGoto()
		{
			if (this.CurrentData != null)
			{
				this.CurrentData.OnGoto(this.CurrentData);
			}
		}

		// Token: 0x04019034 RID: 102452
		[Nullable(2)]
		private IGiantQuestGuideData CurrentData;

		// Token: 0x04019035 RID: 102453
		[Nullable(2)]
		public Action<int> OnHoverCallBack;

		// Token: 0x04019036 RID: 102454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> IconLayout;
	}
}
