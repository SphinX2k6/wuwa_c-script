using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004874 RID: 18548
	public class InstanceDungeonLockItem : UiPanelBase
	{
		// Token: 0x0602EAA6 RID: 191142 RVA: 0x00D06C64 File Offset: 0x00D04E64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602EAA7 RID: 191143 RVA: 0x00D06CAC File Offset: 0x00D04EAC
		[NullableContext(1)]
		public void RefreshItem(TableTextArgNew args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), args.TextKey, args.Params);
		}

		// Token: 0x0602EAA8 RID: 191144 RVA: 0x00D06CCB File Offset: 0x00D04ECB
		[NullableContext(1)]
		public void SetLockText(string lockText)
		{
			base.GetText(0).SetText(lockText, true);
		}

		// Token: 0x0200A51F RID: 42271
		private enum EChildType
		{
			// Token: 0x04033208 RID: 209416
			TextLock
		}
	}
}
