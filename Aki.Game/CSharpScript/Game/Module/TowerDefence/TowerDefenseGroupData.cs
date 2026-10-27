using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B4F RID: 19279
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseGroupData
	{
		// Token: 0x0401A9F4 RID: 109044
		public int GroupId;

		// Token: 0x0401A9F5 RID: 109045
		public List<int> SubStageIds = new List<int>();

		// Token: 0x0401A9F6 RID: 109046
		public Action<int> OnClickSubLevel = delegate(int _)
		{
		};

		// Token: 0x0401A9F7 RID: 109047
		public Func<int, bool> IsSelectedGetter = (int _) => false;
	}
}
