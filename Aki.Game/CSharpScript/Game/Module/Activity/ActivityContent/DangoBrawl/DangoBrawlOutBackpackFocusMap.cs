using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005778 RID: 22392
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackFocusMap
	{
		// Token: 0x060373FE RID: 226302 RVA: 0x00F6CFDC File Offset: 0x00F6B1DC
		public void Bind(DangoBrawlOutBackpackItemBase item)
		{
			UUIItem rootItem = item.GetRootItem();
			if (rootItem != null)
			{
				this.Map[rootItem] = item;
			}
		}

		// Token: 0x060373FF RID: 226303 RVA: 0x00F6D000 File Offset: 0x00F6B200
		public void Clear()
		{
			this.Map.Clear();
		}

		// Token: 0x06037400 RID: 226304 RVA: 0x00F6D010 File Offset: 0x00F6B210
		[NullableContext(2)]
		public DangoBrawlOutBackpackItemBase TryFindFocusItem()
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			UUIItem uuiitem = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.RootUIComp.Get() : null;
			if (uuiitem == null)
			{
				return null;
			}
			DangoBrawlOutBackpackItemBase result;
			if (!this.Map.TryGetValue(uuiitem, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0401D303 RID: 119555
		private readonly Dictionary<UUIItem, DangoBrawlOutBackpackItemBase> Map = new Dictionary<UUIItem, DangoBrawlOutBackpackItemBase>();
	}
}
