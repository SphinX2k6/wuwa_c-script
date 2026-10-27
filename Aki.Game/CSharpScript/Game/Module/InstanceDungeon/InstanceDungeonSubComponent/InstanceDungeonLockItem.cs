using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200589C RID: 22684
	public class InstanceDungeonLockItem : UiPanelBase
	{
		// Token: 0x06039B83 RID: 236419 RVA: 0x00DB7D4C File Offset: 0x00DB5F4C
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

		// Token: 0x06039B84 RID: 236420 RVA: 0x00DB7D94 File Offset: 0x00DB5F94
		[NullableContext(1)]
		public void RefreshItem(TableTextArgNew args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), args.TextKey, args.Params);
		}

		// Token: 0x06039B85 RID: 236421 RVA: 0x00DB7DB3 File Offset: 0x00DB5FB3
		[NullableContext(1)]
		public void SetLockText(string lockText)
		{
			base.GetText(0).SetText(lockText, true);
		}

		// Token: 0x0200BB06 RID: 47878
		private enum EChildType
		{
			// Token: 0x04038807 RID: 231431
			TextLock
		}
	}
}
