using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049ED RID: 18925
	public abstract class HotKeyTypeBase : UiPanelBase
	{
		// Token: 0x06031252 RID: 201298 RVA: 0x00B667F9 File Offset: 0x00B649F9
		public void SetIsMultiKeyItem(bool isMultiKeyItem)
		{
			this.IsMultiKeyItem = isMultiKeyItem;
		}

		// Token: 0x06031253 RID: 201299 RVA: 0x00B66802 File Offset: 0x00B64A02
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06031254 RID: 201300 RVA: 0x00B6680A File Offset: 0x00B64A0A
		protected virtual void OnClear()
		{
		}

		// Token: 0x06031255 RID: 201301
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public abstract List<HotKeyComponent> GetHotKeyComponents();

		// Token: 0x06031256 RID: 201302
		public abstract void KeyItemNotifySetActive(bool value);

		// Token: 0x0401A4DC RID: 107740
		protected bool IsMultiKeyItem;
	}
}
