using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x0200546E RID: 21614
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DropDownLogicBase
	{
		// Token: 0x060372B7 RID: 225975
		public abstract IReadOnlyList<object> GetDropDownDataList();

		// Token: 0x060372B8 RID: 225976
		public abstract TableTextArgNew GetDataTextId(object data, MenuData menuData);

		// Token: 0x060372B9 RID: 225977
		public abstract void TriggerSelectChange(object data, MenuData menuData);

		// Token: 0x060372BA RID: 225978
		public abstract int GetDefaultIndex(MenuData menuData);

		// Token: 0x060372BB RID: 225979 RVA: 0x00D15A66 File Offset: 0x00D13C66
		public virtual bool CanSelectChange(int curIndex, int newIndex, MenuData menuData)
		{
			return curIndex != newIndex;
		}
	}
}
