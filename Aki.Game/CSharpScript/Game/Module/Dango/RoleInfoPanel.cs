using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004ABF RID: 19135
	[NullableContext(1)]
	[Nullable(0)]
	internal class RoleInfoPanel : UiPanelBase
	{
		// Token: 0x0602FDFF RID: 196095 RVA: 0x00D5C854 File Offset: 0x00D5AA54
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602FE00 RID: 196096 RVA: 0x00D5C8AE File Offset: 0x00D5AAAE
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<AttributeItem, AttributeItemData>(base.GetMultiTemplateLayout(1), new Func<AttributeItem>(this.CreateAttributeItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0602FE01 RID: 196097 RVA: 0x00D5C8E1 File Offset: 0x00D5AAE1
		private AttributeItem CreateAttributeItem()
		{
			return new AttributeItem();
		}

		// Token: 0x0602FE02 RID: 196098 RVA: 0x00D5C8E8 File Offset: 0x00D5AAE8
		public void Refresh(AbyssDangoRoleData data)
		{
			string name = data.GetName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
			this.RefreshAttribute(data);
		}

		// Token: 0x0602FE03 RID: 196099 RVA: 0x00D5C91C File Offset: 0x00D5AB1C
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

		// Token: 0x040196AB RID: 104107
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<AttributeItem, AttributeItemData> Layout;

		// Token: 0x0200A742 RID: 42818
		[NullableContext(0)]
		internal enum ERoleInfoComponent
		{
			// Token: 0x04033AEC RID: 211692
			NameText,
			// Token: 0x04033AED RID: 211693
			AttributeTagLayout,
			// Token: 0x04033AEE RID: 211694
			AttributeItem
		}
	}
}
