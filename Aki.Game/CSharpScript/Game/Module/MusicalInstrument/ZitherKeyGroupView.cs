using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004351 RID: 17233
	public class ZitherKeyGroupView : UiPanelBase
	{
		// Token: 0x0602B869 RID: 178281 RVA: 0x00C3B384 File Offset: 0x00C39584
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602B86A RID: 178282 RVA: 0x00C3B3F0 File Offset: 0x00C395F0
		public void Refresh(bool isInteractive)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!isInteractive);
			}
			if (isInteractive != this.IsInteractive)
			{
				base.GetRootItem().PlayUIItemAlphaTween(this.IsInteractive ? 1f : 0.5f, isInteractive ? 1f : 0.5f, 0.2f);
				foreach (MusicalInstrumentKeyItem musicalInstrumentKeyItem in this.KeyItems)
				{
					((GuqinKeyItem)musicalInstrumentKeyItem).SetInteractive(isInteractive);
				}
				this.IsInteractive = isInteractive;
			}
		}

		// Token: 0x0401781F RID: 96287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MusicalInstrumentKeyItem> KeyItems;

		// Token: 0x04017820 RID: 96288
		private bool IsInteractive = true;

		// Token: 0x0200A020 RID: 40992
		private enum EZitherKeyGroupViewComponent
		{
			// Token: 0x04031BFC RID: 203772
			NoteLayout,
			// Token: 0x04031BFD RID: 203773
			DisableMask
		}
	}
}
