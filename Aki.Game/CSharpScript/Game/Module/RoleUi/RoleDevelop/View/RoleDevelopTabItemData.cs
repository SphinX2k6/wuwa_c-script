using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D56 RID: 19798
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RoleDevelopTabItemData : MultiTemplateGridDataBase<RoleDevelopTabItemCellData, RoleDevelopTabItem>
	{
		// Token: 0x0603328E RID: 209550 RVA: 0x00BEEF5E File Offset: 0x00BED15E
		public RoleDevelopTabItemData(RoleDevelopTabItemCellData data, Action<int, UUIExtendToggle> toggleFunc, Func<int, bool> canToggleChange)
		{
			base.Data = data;
			this.ToggleFunc = toggleFunc;
			this.CanToggleChange = canToggleChange;
		}

		// Token: 0x0603328F RID: 209551 RVA: 0x00BEEF7B File Offset: 0x00BED17B
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x06033290 RID: 209552 RVA: 0x00BEEF7E File Offset: 0x00BED17E
		public override RoleDevelopTabItem CreateProxy()
		{
			RoleDevelopTabItem roleDevelopTabItem = new RoleDevelopTabItem();
			roleDevelopTabItem.BindOnToggleFunc(this.ToggleFunc);
			roleDevelopTabItem.BindCanToggleExecuteChange(this.CanToggleChange);
			return roleDevelopTabItem;
		}

		// Token: 0x0401B2FE RID: 111358
		private Action<int, UUIExtendToggle> ToggleFunc;

		// Token: 0x0401B2FF RID: 111359
		private Func<int, bool> CanToggleChange;
	}
}
