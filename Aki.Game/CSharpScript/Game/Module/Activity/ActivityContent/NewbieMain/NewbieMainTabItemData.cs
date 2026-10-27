using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02006383 RID: 25475
	public class NewbieMainTabItemData
	{
		// Token: 0x0402162C RID: 136748
		[Nullable(1)]
		public NewbieMainTabData TabData;

		// Token: 0x0402162D RID: 136749
		public NewbieMainActTab TabConfig;

		// Token: 0x0402162E RID: 136750
		public NewbieMainActTask? ProgressingTask;

		// Token: 0x0402162F RID: 136751
		public int ProgressingQuestId;

		// Token: 0x04021630 RID: 136752
		public ENewbieMainTabState State;

		// Token: 0x04021631 RID: 136753
		public bool IsNew;
	}
}
