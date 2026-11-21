using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AF8 RID: 15096
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseSubLevelData
	{
		// Token: 0x0401534A RID: 86858
		public int StageId;

		// Token: 0x0401534B RID: 86859
		public Action<int> OnClickCb = delegate(int _)
		{
		};

		// Token: 0x0401534C RID: 86860
		public Func<int, bool> IsSelectedGetter = (int _) => false;
	}
}
