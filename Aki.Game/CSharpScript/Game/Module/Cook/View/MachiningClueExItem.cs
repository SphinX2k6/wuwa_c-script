using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AF3 RID: 19187
	[NullableContext(1)]
	[Nullable(0)]
	public class MachiningClueExItem : UiPanelBase
	{
		// Token: 0x0602FFD6 RID: 196566 RVA: 0x00D6306C File Offset: 0x00D6126C
		public MachiningClueExItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602FFD7 RID: 196567 RVA: 0x00D63084 File Offset: 0x00D61284
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

		// Token: 0x0602FFD8 RID: 196568 RVA: 0x00D63110 File Offset: 0x00D61310
		public void Update(bool isUnlock, string contentText)
		{
			base.GetSprite(0).SetUIActive(isUnlock);
			base.GetText(2).SetUIActive(isUnlock);
			base.GetText(1).SetUIActive(!isUnlock);
			if (isUnlock)
			{
				base.GetText(2).SetText(contentText, true);
				return;
			}
			base.GetText(1).SetText(contentText, true);
		}
	}
}
