using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200536E RID: 21358
	public class ZitherKeyGroupView : UiPanelBase
	{
		// Token: 0x06036923 RID: 223523 RVA: 0x00CEC4F8 File Offset: 0x00CEA6F8
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

		// Token: 0x06036924 RID: 223524 RVA: 0x00CEC564 File Offset: 0x00CEA764
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

		// Token: 0x0401CD89 RID: 118153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MusicalInstrumentKeyItem> KeyItems;

		// Token: 0x0401CD8A RID: 118154
		private bool IsInteractive = true;

		// Token: 0x0200B5E9 RID: 46569
		private enum EZitherKeyGroupViewComponent
		{
			// Token: 0x040371A9 RID: 225705
			NoteLayout,
			// Token: 0x040371AA RID: 225706
			DisableMask
		}
	}
}
