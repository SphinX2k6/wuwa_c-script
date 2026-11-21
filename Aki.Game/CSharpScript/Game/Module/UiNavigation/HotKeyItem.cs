using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003965 RID: 14693
	public abstract class HotKeyItem : UiPanelBase
	{
		// Token: 0x06025D7C RID: 155004
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public abstract List<HotKeyComponent> GetHotKeyComponentArray();

		// Token: 0x06025D7D RID: 155005 RVA: 0x00AA0953 File Offset: 0x00A9EB53
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06025D7E RID: 155006 RVA: 0x00AA095B File Offset: 0x00A9EB5B
		protected virtual void OnClear()
		{
		}
	}
}
