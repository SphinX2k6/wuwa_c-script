using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005872 RID: 22642
	public class InstanceDungeonEntranceTowerDefenceItem : UiPanelBase
	{
		// Token: 0x06039983 RID: 235907 RVA: 0x00DAF1AC File Offset: 0x00DAD3AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039984 RID: 235908 RVA: 0x00DAF29C File Offset: 0x00DAD49C
		protected override void OnStart()
		{
			this.PhantomScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.SetButtonUiActive(1, false);
			if (this.ItemDataHandle != null)
			{
				this.RefreshItem(this.ItemDataHandle.Data);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "TowerDefence_Vison", Array.Empty<object>());
		}

		// Token: 0x06039985 RID: 235909 RVA: 0x00DAF320 File Offset: 0x00DAD520
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreatePropItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06039986 RID: 235910 RVA: 0x00DAF327 File Offset: 0x00DAD527
		[NullableContext(1)]
		public void RefreshItem(List<TItem> data)
		{
			if (base.InAsyncLoading())
			{
				this.ItemDataHandle = new InstanceDungeonEntranceTowerDefenceItemData
				{
					Data = data
				};
				return;
			}
			this.PhantomScroll.RefreshByData(data, delegate
			{
				foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.PhantomScroll.GetScrollItemList())
				{
					commonItemSmallItemGrid.SetQuality(null);
					commonItemSmallItemGrid.SetAllowClickBack(false);
				}
			}, false);
		}

		// Token: 0x0401E1C5 RID: 123333
		[Nullable(2)]
		private InstanceDungeonEntranceTowerDefenceItemData ItemDataHandle;

		// Token: 0x0401E1C6 RID: 123334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> PhantomScroll;

		// Token: 0x0200BAB7 RID: 47799
		private enum EComponent
		{
			// Token: 0x040386CB RID: 231115
			PhantomScroll,
			// Token: 0x040386CC RID: 231116
			HelpButton,
			// Token: 0x040386CD RID: 231117
			TitleText,
			// Token: 0x040386CE RID: 231118
			SubTitleItem,
			// Token: 0x040386CF RID: 231119
			SubTitleNumText,
			// Token: 0x040386D0 RID: 231120
			UpItem
		}
	}
}
