using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B50 RID: 19280
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSubLevelData
	{
		// Token: 0x0401A9F8 RID: 109048
		public int StageId;

		// Token: 0x0401A9F9 RID: 109049
		public Action<int> OnClickCb = delegate(int _)
		{
		};

		// Token: 0x0401A9FA RID: 109050
		public Func<int, bool> IsSelectedGetter = (int _) => false;
	}
}
