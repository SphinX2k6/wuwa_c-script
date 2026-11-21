using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B27 RID: 19239
	public class TipsAttributeItem : UiPanelBase
	{
		// Token: 0x060301FB RID: 197115 RVA: 0x00D6BF52 File Offset: 0x00D6A152
		[NullableContext(1)]
		public TipsAttributeItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060301FC RID: 197116 RVA: 0x00D6BF67 File Offset: 0x00D6A167
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060301FD RID: 197117 RVA: 0x00D6BFA0 File Offset: 0x00D6A1A0
		[NullableContext(1)]
		public void UpdateItem(CommonComponentDefine.TipsAttributeData data)
		{
			string propertyIndexName = PropertyIndexConfig.Instance.GetPropertyIndexName(data.Id);
			base.GetText(0).ShowTextNew(propertyIndexName);
			base.GetText(1).SetText(AttributeModel.Instance.GetFormatAttributeValueString(data.Id, data.Value, data.IsRatio), true);
		}

		// Token: 0x0200A77F RID: 42879
		private enum ETipsAttributeItemDefine
		{
			// Token: 0x04033C36 RID: 212022
			AttributeName,
			// Token: 0x04033C37 RID: 212023
			AttributeValue
		}
	}
}
