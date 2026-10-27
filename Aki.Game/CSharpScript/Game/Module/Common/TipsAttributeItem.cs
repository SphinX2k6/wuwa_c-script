using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B46 RID: 23366
	public class TipsAttributeItem : UiPanelBase
	{
		// Token: 0x0603B289 RID: 242313 RVA: 0x00E1B2B2 File Offset: 0x00E194B2
		[NullableContext(1)]
		public TipsAttributeItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B28A RID: 242314 RVA: 0x00E1B2C7 File Offset: 0x00E194C7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603B28B RID: 242315 RVA: 0x00E1B300 File Offset: 0x00E19500
		[NullableContext(1)]
		public void UpdateItem(CommonComponentDefine.TipsAttributeData data)
		{
			string propertyIndexName = PropertyIndexConfig.Instance.GetPropertyIndexName(data.Id);
			base.GetText(0).ShowTextNew(propertyIndexName);
			base.GetText(1).SetText(AttributeModel.Instance.GetFormatAttributeValueString(data.Id, data.Value, data.IsRatio), true);
		}

		// Token: 0x0200BD76 RID: 48502
		private enum ETipsAttributeItemDefine
		{
			// Token: 0x0403926A RID: 234090
			AttributeName,
			// Token: 0x0403926B RID: 234091
			AttributeValue
		}
	}
}
