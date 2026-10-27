using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006303 RID: 25347
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballAttributeItem : GridProxyAbstract<IPinballAttributeItemData>
	{
		// Token: 0x0603FC78 RID: 261240 RVA: 0x00F6E564 File Offset: 0x00F6C764
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FC79 RID: 261241 RVA: 0x00F6E610 File Offset: 0x00F6C810
		[NullableContext(1)]
		public override void Refresh(IPinballAttributeItemData data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.AttributeConfig.Icon, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.AttributeConfig.Name, Array.Empty<object>());
			string formatAttributeValueString = PinballModel.Instance.GetFormatAttributeValueString(data.AttributeConfig, (float)data.AttributeValue);
			base.GetText(1).SetText(formatAttributeValueString, true);
			base.GetSprite(3).SetUIActive(data.IsBgShow);
		}

		// Token: 0x0200C4FA RID: 50426
		private enum EComponent
		{
			// Token: 0x0403B71E RID: 243486
			AttributeNameText,
			// Token: 0x0403B71F RID: 243487
			AttributeValueText,
			// Token: 0x0403B720 RID: 243488
			IconTexture,
			// Token: 0x0403B721 RID: 243489
			BgSprite
		}
	}
}
