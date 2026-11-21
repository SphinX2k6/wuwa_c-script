using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.DropDownLogic
{
	// Token: 0x02004451 RID: 17489
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DropDownLogicBase
	{
		// Token: 0x0602C200 RID: 180736
		public abstract IReadOnlyList<object> GetDropDownDataList();

		// Token: 0x0602C201 RID: 180737
		public abstract TableTextArgNew GetDataTextId(object data, MenuData menuData);

		// Token: 0x0602C202 RID: 180738
		public abstract void TriggerSelectChange(object data, MenuData menuData);

		// Token: 0x0602C203 RID: 180739
		public abstract int GetDefaultIndex(MenuData menuData);

		// Token: 0x0602C204 RID: 180740 RVA: 0x00C64E7E File Offset: 0x00C6307E
		public virtual bool CanSelectChange(int curIndex, int newIndex, MenuData menuData)
		{
			return curIndex != newIndex;
		}
	}
}
