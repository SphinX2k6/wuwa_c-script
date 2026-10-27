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
	// Token: 0x0200598C RID: 22924
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantQuestGuideItem : UiPanelBase, IGridProxy<IGiantQuestGuideData>
	{
		// Token: 0x17008B6F RID: 35695
		// (get) Token: 0x0603A2B3 RID: 238259 RVA: 0x00DD395A File Offset: 0x00DD1B5A
		// (set) Token: 0x0603A2B4 RID: 238260 RVA: 0x00DD3962 File Offset: 0x00DD1B62
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

		// Token: 0x17008B70 RID: 35696
		// (get) Token: 0x0603A2B5 RID: 238261 RVA: 0x00DD396B File Offset: 0x00DD1B6B
		// (set) Token: 0x0603A2B6 RID: 238262 RVA: 0x00DD3973 File Offset: 0x00DD1B73
		public int GridIndex { get; set; }

		// Token: 0x17008B71 RID: 35697
		// (get) Token: 0x0603A2B7 RID: 238263 RVA: 0x00DD397C File Offset: 0x00DD1B7C
		// (set) Token: 0x0603A2B8 RID: 238264 RVA: 0x00DD3984 File Offset: 0x00DD1B84
		public int DisplayIndex { get; set; }

		// Token: 0x0603A2B9 RID: 238265 RVA: 0x00DD3990 File Offset: 0x00DD1B90
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

		// Token: 0x0603A2BA RID: 238266 RVA: 0x00DD3AFC File Offset: 0x00DD1CFC
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

		// Token: 0x0603A2BB RID: 238267 RVA: 0x00DD3BC4 File Offset: 0x00DD1DC4
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

		// Token: 0x0603A2BC RID: 238268 RVA: 0x00DD3C44 File Offset: 0x00DD1E44
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

		// Token: 0x0603A2BD RID: 238269 RVA: 0x00DD3CC8 File Offset: 0x00DD1EC8
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

		// Token: 0x0603A2BE RID: 238270 RVA: 0x00DD3D99 File Offset: 0x00DD1F99
		public void Clear()
		{
		}

		// Token: 0x0603A2BF RID: 238271 RVA: 0x00DD3D9B File Offset: 0x00DD1F9B
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnHover.Remove(new Action(this.OnPointEnter));
		}

		// Token: 0x0603A2C0 RID: 238272 RVA: 0x00DD3DBF File Offset: 0x00DD1FBF
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603A2C1 RID: 238273 RVA: 0x00DD3DC1 File Offset: 0x00DD1FC1
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603A2C2 RID: 238274 RVA: 0x00DD3DC3 File Offset: 0x00DD1FC3
		public object GetKey(IGiantQuestGuideData data, int gridIndex)
		{
			return data.AccessId;
		}

		// Token: 0x0603A2C3 RID: 238275 RVA: 0x00DD3DD0 File Offset: 0x00DD1FD0
		private void OnPointEnter()
		{
			Action<int> onHoverCallBack = this.OnHoverCallBack;
			if (onHoverCallBack == null)
			{
				return;
			}
			onHoverCallBack(this.GridIndex);
		}

		// Token: 0x0603A2C4 RID: 238276 RVA: 0x00DD3DE8 File Offset: 0x00DD1FE8
		private void OnClickGoto()
		{
			if (this.CurrentData != null)
			{
				this.CurrentData.OnGoto(this.CurrentData);
			}
		}

		// Token: 0x0401E596 RID: 124310
		[Nullable(2)]
		private IGiantQuestGuideData CurrentData;

		// Token: 0x0401E597 RID: 124311
		[Nullable(2)]
		public Action<int> OnHoverCallBack;

		// Token: 0x0401E598 RID: 124312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> IconLayout;
	}
}
