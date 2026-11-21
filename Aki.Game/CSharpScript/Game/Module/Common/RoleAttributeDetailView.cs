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
	// Token: 0x02004B26 RID: 19238
	public class RoleAttributeDetailView : UiViewBase
	{
		// Token: 0x060301F5 RID: 197109 RVA: 0x00D6BDE2 File Offset: 0x00D69FE2
		[NullableContext(1)]
		public RoleAttributeDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060301F6 RID: 197110 RVA: 0x00D6BDEC File Offset: 0x00D69FEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x060301F7 RID: 197111 RVA: 0x00D6BE48 File Offset: 0x00D6A048
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

		// Token: 0x060301F8 RID: 197112 RVA: 0x00D6BEDF File Offset: 0x00D6A0DF
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem.Destroy(null);
			if (this.AttrScrollList != null)
			{
				this.AttrScrollList.ClearChildren();
				this.AttrScrollList = null;
			}
		}

		// Token: 0x060301F9 RID: 197113 RVA: 0x00D6BF08 File Offset: 0x00D6A108
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

		// Token: 0x060301FA RID: 197114 RVA: 0x00D6BF49 File Offset: 0x00D6A149
		private void OnBackButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04019811 RID: 104465
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04019812 RID: 104466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<RoleAttrListScrollItem> AttrScrollList;

		// Token: 0x0200A77E RID: 42878
		private class EAttributeView
		{
			// Token: 0x04033C32 RID: 212018
			public const int ItemCaption = 0;

			// Token: 0x04033C33 RID: 212019
			public const int AttributeContent = 1;

			// Token: 0x04033C34 RID: 212020
			public const int ItemAttribute = 2;
		}
	}
}
