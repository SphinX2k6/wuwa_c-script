using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066A3 RID: 26275
	public class IDropCatchDropItemParams
	{
		// Token: 0x040223D4 RID: 140244
		public int InstanceId;

		// Token: 0x040223D5 RID: 140245
		public int ItemId;

		// Token: 0x040223D6 RID: 140246
		public double PosX;

		// Token: 0x040223D7 RID: 140247
		public double PosY;

		// Token: 0x040223D8 RID: 140248
		[Nullable(1)]
		public IGameplayLogicContext Context;
	}
}
