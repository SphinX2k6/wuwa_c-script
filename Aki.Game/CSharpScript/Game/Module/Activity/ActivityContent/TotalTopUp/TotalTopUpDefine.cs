using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F95 RID: 24469
	[NullableContext(1)]
	[Nullable(0)]
	public static class TotalTopUpDefine
	{
		// Token: 0x0603E12B RID: 254251 RVA: 0x00EFCB7D File Offset: 0x00EFAD7D
		private static bool CheckIsOrnament(int id, ItemConfig itemConfig)
		{
			return itemConfig != null && itemConfig.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Ornament;
		}

		// Token: 0x0603E12C RID: 254252 RVA: 0x00EFCB94 File Offset: 0x00EFAD94
		private static void ShowOrnamentPreview(int id, ItemConfig itemConfig)
		{
			RoleController.Instance.OpenOrnamentPreviewView(id, null);
		}

		// Token: 0x040206B3 RID: 132787
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			1,
			1
		})]
		[StaticVariableRuleIgnore]
		public static readonly List<ValueTuple<Func<int, ItemConfig, bool>, Action<int, ItemConfig>>> itemTipsFunctionList = new List<ValueTuple<Func<int, ItemConfig, bool>, Action<int, ItemConfig>>>
		{
			new ValueTuple<Func<int, ItemConfig, bool>, Action<int, ItemConfig>>(new Func<int, ItemConfig, bool>(TotalTopUpDefine.CheckIsOrnament), new Action<int, ItemConfig>(TotalTopUpDefine.ShowOrnamentPreview))
		};
	}
}
