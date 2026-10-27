using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x0200575D RID: 22365
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoLevelTargetItem : GridProxyAbstract<KurotatoLevelTargetItemData>
	{
		// Token: 0x06038D48 RID: 232776 RVA: 0x00D801A8 File Offset: 0x00D7E3A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D49 RID: 232777 RVA: 0x00D80234 File Offset: 0x00D7E434
		[NullableContext(1)]
		public override void Refresh(KurotatoLevelTargetItemData data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, data.Text, Array.Empty<object>());
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool isFinish = data.IsFinish;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(isFinish, fcolor);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!data.IsEndless && data.IsFinish);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!data.IsEndless && !data.IsFinish);
		}

		// Token: 0x0200B959 RID: 47449
		private enum EComponent
		{
			// Token: 0x040380CF RID: 229583
			TextDesc,
			// Token: 0x040380D0 RID: 229584
			ItemFinishIcon,
			// Token: 0x040380D1 RID: 229585
			ItemUnFinishIcon
		}
	}
}
