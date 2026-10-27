using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005ADE RID: 23262
	[NullableContext(1)]
	[Nullable(0)]
	internal class RoleInfoPanel : UiPanelBase
	{
		// Token: 0x0603AE8D RID: 241293 RVA: 0x00E0BB6C File Offset: 0x00E09D6C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603AE8E RID: 241294 RVA: 0x00E0BBC6 File Offset: 0x00E09DC6
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<AttributeItem, AttributeItemData>(base.GetMultiTemplateLayout(1), new Func<AttributeItem>(this.CreateAttributeItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603AE8F RID: 241295 RVA: 0x00E0BBF9 File Offset: 0x00E09DF9
		private AttributeItem CreateAttributeItem()
		{
			return new AttributeItem();
		}

		// Token: 0x0603AE90 RID: 241296 RVA: 0x00E0BC00 File Offset: 0x00E09E00
		public void Refresh(AbyssDangoRoleData data)
		{
			string name = data.GetName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
			this.RefreshAttribute(data);
		}

		// Token: 0x0603AE91 RID: 241297 RVA: 0x00E0BC34 File Offset: 0x00E09E34
		private void RefreshAttribute(AbyssDangoRoleData data)
		{
			AttributeItemData attributeItemData = new AttributeItemData();
			attributeItemData.DangoRoleData = data;
			GenericLayout<AttributeItem, AttributeItemData> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.RefreshByData(new <>z__ReadOnlySingleElementList<AttributeItemData>(attributeItemData), null, false);
		}

		// Token: 0x0401EBEF RID: 125935
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AttributeItem, AttributeItemData> Layout;

		// Token: 0x0200BD3A RID: 48442
		[NullableContext(0)]
		internal enum ERoleInfoComponent
		{
			// Token: 0x04039122 RID: 233762
			NameText,
			// Token: 0x04039123 RID: 233763
			AttributeTagLayout,
			// Token: 0x04039124 RID: 233764
			AttributeItem
		}
	}
}
