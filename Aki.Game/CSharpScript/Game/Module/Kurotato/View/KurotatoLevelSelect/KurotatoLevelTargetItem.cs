using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect
{
	// Token: 0x02004734 RID: 18228
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoLevelTargetItem : GridProxyAbstract<KurotatoLevelTargetItemData>
	{
		// Token: 0x0602DC58 RID: 187480 RVA: 0x00CCEC50 File Offset: 0x00CCCE50
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

		// Token: 0x0602DC59 RID: 187481 RVA: 0x00CCECDC File Offset: 0x00CCCEDC
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

		// Token: 0x0200A375 RID: 41845
		private enum EComponent
		{
			// Token: 0x04032AD1 RID: 207569
			TextDesc,
			// Token: 0x04032AD2 RID: 207570
			ItemFinishIcon,
			// Token: 0x04032AD3 RID: 207571
			ItemUnFinishIcon
		}
	}
}
