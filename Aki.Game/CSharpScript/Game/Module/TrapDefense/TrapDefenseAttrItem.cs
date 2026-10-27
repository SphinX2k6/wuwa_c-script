using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ABD RID: 19133
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseAttrItem : GridProxyAbstract<ITrapDefenseAttrItemData>
	{
		// Token: 0x0603191E RID: 203038 RVA: 0x00B7E8BC File Offset: 0x00B7CABC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603191F RID: 203039 RVA: 0x00B7E948 File Offset: 0x00B7CB48
		public override void Refresh(ITrapDefenseAttrItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUITexture texture = base.GetTexture(0);
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			text.ShowTextNew(data.NameKey);
			text2.SetUIActive(!string.IsNullOrEmpty(data.Value));
			texture.SetUIActive(!string.IsNullOrEmpty(data.IconPath));
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				base.SetTextureByPath(data.IconPath, texture, null, null);
			}
			if (!string.IsNullOrEmpty(data.Value))
			{
				text2.SetText(data.Value, true);
			}
		}

		// Token: 0x0401A7C4 RID: 108484
		public ITrapDefenseAttrItemData ItemData;

		// Token: 0x0401A7C5 RID: 108485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseAttrItemData> ClickCallBack;

		// Token: 0x0200AC22 RID: 44066
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344E6 RID: 214246
			public const int TextureIcon = 0;

			// Token: 0x040344E7 RID: 214247
			public const int TextName = 1;

			// Token: 0x040344E8 RID: 214248
			public const int TextValue = 2;
		}
	}
}
