using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005424 RID: 21540
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuDetailPopData
	{
		// Token: 0x0401D0A4 RID: 118948
		public string Title = "";

		// Token: 0x0401D0A5 RID: 118949
		public string Description = "";

		// Token: 0x0401D0A6 RID: 118950
		public bool IsMulti;

		// Token: 0x0401D0A7 RID: 118951
		public List<MenuDetailPopItemData> ItemList = new List<MenuDetailPopItemData>();
	}
}
