using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005281 RID: 21121
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballAttributeItem : GridProxyAbstract<IPinballAttributeItemData>
	{
		// Token: 0x06034939 RID: 215353 RVA: 0x00EB54C0 File Offset: 0x00EB36C0
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

		// Token: 0x0603493A RID: 215354 RVA: 0x00EB556C File Offset: 0x00EB376C
		[NullableContext(1)]
		public override void Refresh(IPinballAttributeItemData data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.AttributeConfig.Icon, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.AttributeConfig.Name, Array.Empty<object>());
			string formatAttributeValueString = PinballModel.Instance.GetFormatAttributeValueString(data.AttributeConfig, (float)data.AttributeValue);
			base.GetText(1).SetText(formatAttributeValueString, true);
			base.GetSprite(3).SetUIActive(data.IsBgShow);
		}

		// Token: 0x0200AEE1 RID: 44769
		private enum EComponent
		{
			// Token: 0x04036080 RID: 221312
			AttributeNameText,
			// Token: 0x04036081 RID: 221313
			AttributeValueText,
			// Token: 0x04036082 RID: 221314
			IconTexture,
			// Token: 0x04036083 RID: 221315
			BgSprite
		}
	}
}
