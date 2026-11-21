using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F7C RID: 20348
	[NullableContext(1)]
	[Nullable(0)]
	public static class TotalTopUpDefine
	{
		// Token: 0x060330C5 RID: 209093 RVA: 0x00E4E835 File Offset: 0x00E4CA35
		private static bool CheckIsOrnament(int id, ItemConfig itemConfig)
		{
			return itemConfig != null && itemConfig.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Ornament;
		}

		// Token: 0x060330C6 RID: 209094 RVA: 0x00E4E84C File Offset: 0x00E4CA4C
		private static void ShowOrnamentPreview(int id, ItemConfig itemConfig)
		{
			RoleController.Instance.OpenOrnamentPreviewView(id, null);
		}

		// Token: 0x0401B185 RID: 110981
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
