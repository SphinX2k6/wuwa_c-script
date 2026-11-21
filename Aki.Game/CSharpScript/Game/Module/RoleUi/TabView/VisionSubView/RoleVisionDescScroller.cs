using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003CA0 RID: 15520
	[NullableContext(1)]
	[Nullable(0)]
	internal class RoleVisionDescScroller : UiPanelBase
	{
		// Token: 0x06027BD9 RID: 162777 RVA: 0x00B21568 File Offset: 0x00B1F768
		public RoleVisionDescScroller(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06027BDA RID: 162778 RVA: 0x00B2157D File Offset: 0x00B1F77D
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06027BDB RID: 162779 RVA: 0x00B215B6 File Offset: 0x00B1F7B6
		protected override void OnStart()
		{
			this.Scroller = new GenericScrollView<RoleVisionFetterDescScrollerItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<RoleVisionFetterDescScrollerItem>(this.InitFettersItem), null);
		}

		// Token: 0x06027BDC RID: 162780 RVA: 0x00B215D8 File Offset: 0x00B1F7D8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<RoleVisionFetterDescScrollerItem> InitFettersItem([Nullable(2)] object data, UUIItem item, int index)
		{
			RoleVisionFetterDescScrollerItem roleVisionFetterDescScrollerItem = new RoleVisionFetterDescScrollerItem(item);
			roleVisionFetterDescScrollerItem.Update((PhantomFetter)data);
			return new LayoutItem<RoleVisionFetterDescScrollerItem>
			{
				Key = index,
				Value = roleVisionFetterDescScrollerItem
			};
		}

		// Token: 0x06027BDD RID: 162781 RVA: 0x00B21610 File Offset: 0x00B1F810
		public void Update(IReadOnlyList<PhantomFetter> data)
		{
			this.Scroller.RefreshByData<PhantomFetter>(new List<PhantomFetter>(data), null);
		}

		// Token: 0x06027BDE RID: 162782 RVA: 0x00B21637 File Offset: 0x00B1F837
		protected override void OnBeforeDestroy()
		{
			this.Scroller.ClearChildren();
		}

		// Token: 0x04015A87 RID: 88711
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<RoleVisionFetterDescScrollerItem> Scroller;
	}
}
