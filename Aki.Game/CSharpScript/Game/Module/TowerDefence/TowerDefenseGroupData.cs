using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AF7 RID: 15095
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseGroupData
	{
		// Token: 0x04015346 RID: 86854
		public int GroupId;

		// Token: 0x04015347 RID: 86855
		public List<int> SubStageIds = new List<int>();

		// Token: 0x04015348 RID: 86856
		public Action<int> OnClickSubLevel = delegate(int _)
		{
		};

		// Token: 0x04015349 RID: 86857
		public Func<int, bool> IsSelectedGetter = (int _) => false;
	}
}
