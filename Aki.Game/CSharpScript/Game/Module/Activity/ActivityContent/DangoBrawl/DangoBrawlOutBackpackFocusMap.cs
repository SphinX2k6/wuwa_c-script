using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006828 RID: 26664
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackFocusMap
	{
		// Token: 0x060428AA RID: 272554 RVA: 0x0102BAA0 File Offset: 0x01029CA0
		public void Bind(DangoBrawlOutBackpackItemBase item)
		{
			UUIItem rootItem = item.GetRootItem();
			if (rootItem != null)
			{
				this.Map[rootItem] = item;
			}
		}

		// Token: 0x060428AB RID: 272555 RVA: 0x0102BAC4 File Offset: 0x01029CC4
		public void Clear()
		{
			this.Map.Clear();
		}

		// Token: 0x060428AC RID: 272556 RVA: 0x0102BAD4 File Offset: 0x01029CD4
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

		// Token: 0x04022AA6 RID: 141990
		private readonly Dictionary<UUIItem, DangoBrawlOutBackpackItemBase> Map = new Dictionary<UUIItem, DangoBrawlOutBackpackItemBase>();
	}
}
