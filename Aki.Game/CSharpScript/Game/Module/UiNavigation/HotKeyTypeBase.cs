using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003967 RID: 14695
	public abstract class HotKeyTypeBase : UiPanelBase
	{
		// Token: 0x06025D88 RID: 155016 RVA: 0x00AA17B2 File Offset: 0x00A9F9B2
		public void SetIsMultiKeyItem(bool isMultiKeyItem)
		{
			this.IsMultiKeyItem = isMultiKeyItem;
		}

		// Token: 0x06025D89 RID: 155017 RVA: 0x00AA17BB File Offset: 0x00A9F9BB
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06025D8A RID: 155018 RVA: 0x00AA17C3 File Offset: 0x00A9F9C3
		protected virtual void OnClear()
		{
		}

		// Token: 0x06025D8B RID: 155019
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public abstract List<HotKeyComponent> GetHotKeyComponents();

		// Token: 0x06025D8C RID: 155020
		public abstract void KeyItemNotifySetActive(bool value);

		// Token: 0x04014D4E RID: 85326
		protected bool IsMultiKeyItem;
	}
}
