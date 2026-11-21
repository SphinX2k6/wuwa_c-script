using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004407 RID: 17415
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuDetailPopData
	{
		// Token: 0x04017B3D RID: 97085
		public string Title = "";

		// Token: 0x04017B3E RID: 97086
		public string Description = "";

		// Token: 0x04017B3F RID: 97087
		public bool IsMulti;

		// Token: 0x04017B40 RID: 97088
		public List<MenuDetailPopItemData> ItemList = new List<MenuDetailPopItemData>();
	}
}
