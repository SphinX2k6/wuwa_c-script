using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x02005301 RID: 21249
	public class NewbieMainTabItemData
	{
		// Token: 0x0401BF5B RID: 114523
		[Nullable(1)]
		public NewbieMainTabData TabData;

		// Token: 0x0401BF5C RID: 114524
		public NewbieMainActTab TabConfig;

		// Token: 0x0401BF5D RID: 114525
		public NewbieMainActTask? ProgressingTask;

		// Token: 0x0401BF5E RID: 114526
		public int ProgressingQuestId;

		// Token: 0x0401BF5F RID: 114527
		public ENewbieMainTabState State;

		// Token: 0x0401BF60 RID: 114528
		public bool IsNew;
	}
}
