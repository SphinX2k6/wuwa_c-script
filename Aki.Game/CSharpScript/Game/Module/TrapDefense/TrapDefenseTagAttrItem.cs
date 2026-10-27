using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ABE RID: 19134
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseTagAttrItem : GridProxyAbstract<ITrapDefenseAttrItemData>
	{
		// Token: 0x06031921 RID: 203041 RVA: 0x00B7E9F0 File Offset: 0x00B7CBF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031922 RID: 203042 RVA: 0x00B7EA7C File Offset: 0x00B7CC7C
		public override void Refresh(ITrapDefenseAttrItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUISprite sprite = base.GetSprite(0);
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			text.ShowTextNew(data.NameKey);
			text2.SetUIActive(!string.IsNullOrEmpty(data.Value));
			sprite.SetUIActive(!string.IsNullOrEmpty(data.IconPath));
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				this.SetSpriteByPath(data.IconPath, sprite, false, null, null);
			}
			if (!string.IsNullOrEmpty(data.Value))
			{
				text2.ShowTextNew(data.Value);
			}
		}

		// Token: 0x0401A7C6 RID: 108486
		public ITrapDefenseAttrItemData ItemData;

		// Token: 0x0401A7C7 RID: 108487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseAttrItemData> ClickCallBack;

		// Token: 0x0200AC23 RID: 44067
		[NullableContext(0)]
		private class ETagType
		{
			// Token: 0x040344E9 RID: 214249
			public const int SpriteIcon = 0;

			// Token: 0x040344EA RID: 214250
			public const int TextName = 1;

			// Token: 0x040344EB RID: 214251
			public const int TextValue = 2;
		}
	}
}
