using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D1F RID: 15647
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class RoleDevelopTabItemData : MultiTemplateGridDataBase<RoleDevelopTabItemCellData, RoleDevelopTabItem>
	{
		// Token: 0x060280F8 RID: 164088 RVA: 0x00B38092 File Offset: 0x00B36292
		public RoleDevelopTabItemData(RoleDevelopTabItemCellData data, Action<int, UUIExtendToggle> toggleFunc, Func<int, bool> canToggleChange)
		{
			base.Data = data;
			this.ToggleFunc = toggleFunc;
			this.CanToggleChange = canToggleChange;
		}

		// Token: 0x060280F9 RID: 164089 RVA: 0x00B380AF File Offset: 0x00B362AF
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060280FA RID: 164090 RVA: 0x00B380B2 File Offset: 0x00B362B2
		public override RoleDevelopTabItem CreateProxy()
		{
			RoleDevelopTabItem roleDevelopTabItem = new RoleDevelopTabItem();
			roleDevelopTabItem.BindOnToggleFunc(this.ToggleFunc);
			roleDevelopTabItem.BindCanToggleExecuteChange(this.CanToggleChange);
			return roleDevelopTabItem;
		}

		// Token: 0x04015CCF RID: 89295
		private Action<int, UUIExtendToggle> ToggleFunc;

		// Token: 0x04015CD0 RID: 89296
		private Func<int, bool> CanToggleChange;
	}
}
