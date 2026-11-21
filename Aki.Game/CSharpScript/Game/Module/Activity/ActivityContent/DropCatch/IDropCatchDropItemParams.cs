using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055F3 RID: 22003
	public class IDropCatchDropItemParams
	{
		// Token: 0x0401CC2D RID: 117805
		public int InstanceId;

		// Token: 0x0401CC2E RID: 117806
		public int ItemId;

		// Token: 0x0401CC2F RID: 117807
		public double PosX;

		// Token: 0x0401CC30 RID: 117808
		public double PosY;

		// Token: 0x0401CC31 RID: 117809
		[Nullable(1)]
		public IGameplayLogicContext Context;
	}
}
