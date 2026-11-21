using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF2 RID: 19186
	[NullableContext(1)]
	[Nullable(0)]
	public class MachiningClueItem : UiPanelBase
	{
		// Token: 0x0602FFD3 RID: 196563 RVA: 0x00D62F92 File Offset: 0x00D61192
		public MachiningClueItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602FFD4 RID: 196564 RVA: 0x00D62FA8 File Offset: 0x00D611A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FFD5 RID: 196565 RVA: 0x00D63014 File Offset: 0x00D61214
		public void Update(bool isUnlock, string contentText)
		{
			base.GetSprite(0).SetUIActive(isUnlock);
			base.GetText(1).SetText(contentText, true);
			if (isUnlock)
			{
				base.GetText(1).SetColor(FColor.FromHex("aa9b6a"));
				return;
			}
			base.GetText(1).SetColor(FColor.FromHex("ece5d8"));
		}
	}
}
