using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A66 RID: 14950
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseTagAttrItem : GridProxyAbstract<ITrapDefenseAttrItemData>
	{
		// Token: 0x060266B1 RID: 157361 RVA: 0x00AC29A4 File Offset: 0x00AC0BA4
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

		// Token: 0x060266B2 RID: 157362 RVA: 0x00AC2A30 File Offset: 0x00AC0C30
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

		// Token: 0x04015118 RID: 86296
		public ITrapDefenseAttrItemData ItemData;

		// Token: 0x04015119 RID: 86297
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseAttrItemData> ClickCallBack;

		// Token: 0x02009643 RID: 38467
		[NullableContext(0)]
		private class ETagType
		{
			// Token: 0x0402EE9A RID: 192154
			public const int SpriteIcon = 0;

			// Token: 0x0402EE9B RID: 192155
			public const int TextName = 1;

			// Token: 0x0402EE9C RID: 192156
			public const int TextValue = 2;
		}
	}
}
