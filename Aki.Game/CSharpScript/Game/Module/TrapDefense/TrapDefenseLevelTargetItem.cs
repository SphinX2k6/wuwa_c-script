using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB4 RID: 19124
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseLevelTargetItem : GridProxyAbstract<ITrapDefenseLevelTargetItemData>
	{
		// Token: 0x060318D3 RID: 202963 RVA: 0x00B7D8D8 File Offset: 0x00B7BAD8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060318D4 RID: 202964 RVA: 0x00B7D984 File Offset: 0x00B7BB84
		public override void Refresh(ITrapDefenseLevelTargetItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(data.TargetStar.ToString(), true);
			}
			UUITexture texture = base.GetTexture(1);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(data.Info.IconKey.ToString());
			base.SetTextureByPath(resourcePath, texture, null, null);
			UUIText text2 = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text2, data.Info.NameKey.ToString(), new <>z__ReadOnlySingleElementList<object>(data.TargetValue));
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data.IsFinish);
		}

		// Token: 0x0401A7AB RID: 108459
		public ITrapDefenseLevelTargetItemData ItemData;

		// Token: 0x0401A7AC RID: 108460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<ITrapDefenseLevelTargetItemData> ClickCallBack;

		// Token: 0x0200AC18 RID: 44056
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344AF RID: 214191
			public const int TextStarNum = 0;

			// Token: 0x040344B0 RID: 214192
			public const int TextureIcon = 1;

			// Token: 0x040344B1 RID: 214193
			public const int TextTargetDesc = 2;

			// Token: 0x040344B2 RID: 214194
			public const int ItemFinish = 3;
		}
	}
}
