using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049EB RID: 18923
	public abstract class HotKeyItem : UiPanelBase
	{
		// Token: 0x06031246 RID: 201286
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public abstract List<HotKeyComponent> GetHotKeyComponentArray();

		// Token: 0x06031247 RID: 201287 RVA: 0x00B65A03 File Offset: 0x00B63C03
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06031248 RID: 201288 RVA: 0x00B65A0B File Offset: 0x00B63C0B
		protected virtual void OnClear()
		{
		}
	}
}
