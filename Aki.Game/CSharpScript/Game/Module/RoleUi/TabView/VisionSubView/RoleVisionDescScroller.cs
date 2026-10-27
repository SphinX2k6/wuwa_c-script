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
	// Token: 0x02004CEE RID: 19694
	[NullableContext(1)]
	[Nullable(0)]
	internal class RoleVisionDescScroller : UiPanelBase
	{
		// Token: 0x06032DFE RID: 208382 RVA: 0x00BDBC60 File Offset: 0x00BD9E60
		public RoleVisionDescScroller(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06032DFF RID: 208383 RVA: 0x00BDBC75 File Offset: 0x00BD9E75
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06032E00 RID: 208384 RVA: 0x00BDBCAE File Offset: 0x00BD9EAE
		protected override void OnStart()
		{
			this.Scroller = new GenericScrollView<RoleVisionFetterDescScrollerItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<RoleVisionFetterDescScrollerItem>(this.InitFettersItem), null);
		}

		// Token: 0x06032E01 RID: 208385 RVA: 0x00BDBCD0 File Offset: 0x00BD9ED0
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

		// Token: 0x06032E02 RID: 208386 RVA: 0x00BDBD08 File Offset: 0x00BD9F08
		public void Update(IReadOnlyList<PhantomFetter> data)
		{
			this.Scroller.RefreshByData<PhantomFetter>(new List<PhantomFetter>(data), null);
		}

		// Token: 0x06032E03 RID: 208387 RVA: 0x00BDBD2F File Offset: 0x00BD9F2F
		protected override void OnBeforeDestroy()
		{
			this.Scroller.ClearChildren();
		}

		// Token: 0x0401B102 RID: 110850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<RoleVisionFetterDescScrollerItem> Scroller;
	}
}
