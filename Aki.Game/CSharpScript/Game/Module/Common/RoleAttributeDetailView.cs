using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B45 RID: 23365
	public class RoleAttributeDetailView : UiViewBase
	{
		// Token: 0x0603B283 RID: 242307 RVA: 0x00E1B142 File Offset: 0x00E19342
		[NullableContext(1)]
		public RoleAttributeDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B284 RID: 242308 RVA: 0x00E1B14C File Offset: 0x00E1934C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603B285 RID: 242309 RVA: 0x00E1B1A8 File Offset: 0x00E193A8
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnBackButtonClick));
			this.CaptionItem.SetTitleLocalText("PrefabTextItem_1302715335_Text");
			List<AttrListScrollData> data = this.OpenParam as List<AttrListScrollData>;
			this.AttrScrollList = new GenericScrollView<RoleAttrListScrollItem>(base.GetScrollViewWithScrollbar(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<RoleAttrListScrollItem>(this.InitAttrItem), null);
			this.AttrScrollList.RefreshByData<AttrListScrollData>(data, null);
			EventSystem.Instance.Emit<bool>(EEventName.AttributeComponentEvent, true);
		}

		// Token: 0x0603B286 RID: 242310 RVA: 0x00E1B23F File Offset: 0x00E1943F
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem.Destroy(null);
			if (this.AttrScrollList != null)
			{
				this.AttrScrollList.ClearChildren();
				this.AttrScrollList = null;
			}
		}

		// Token: 0x0603B287 RID: 242311 RVA: 0x00E1B268 File Offset: 0x00E19468
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<RoleAttrListScrollItem> InitAttrItem(object data, UUIItem item, int index)
		{
			AttrListScrollData attrListScrollData = (AttrListScrollData)data;
			RoleAttrListScrollItem roleAttrListScrollItem = new RoleAttrListScrollItem(item, attrListScrollData.AttributeType);
			roleAttrListScrollItem.ShowTemp(attrListScrollData, index);
			return new LayoutItem<RoleAttrListScrollItem>
			{
				Key = index,
				Value = roleAttrListScrollItem
			};
		}

		// Token: 0x0603B288 RID: 242312 RVA: 0x00E1B2A9 File Offset: 0x00E194A9
		private void OnBackButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401ED55 RID: 126293
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401ED56 RID: 126294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<RoleAttrListScrollItem> AttrScrollList;

		// Token: 0x0200BD75 RID: 48501
		private class EAttributeView
		{
			// Token: 0x04039266 RID: 234086
			public const int ItemCaption = 0;

			// Token: 0x04039267 RID: 234087
			public const int AttributeContent = 1;

			// Token: 0x04039268 RID: 234088
			public const int ItemAttribute = 2;
		}
	}
}
