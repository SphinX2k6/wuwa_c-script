using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058BB RID: 22715
	public class InstanceDetectionDynamicData
	{
		// Token: 0x0401E29A RID: 123546
		public bool IsSelect;

		// Token: 0x0401E29B RID: 123547
		public bool IsOnlyOneGrid;

		// Token: 0x0401E29C RID: 123548
		public bool IsShow = true;

		// Token: 0x0401E29D RID: 123549
		public int InstanceSeriesTitle;

		// Token: 0x0401E29E RID: 123550
		public int InstanceGirdId;

		// Token: 0x0401E29F RID: 123551
		public EInstanceDetectionExtraType ExtraType;

		// Token: 0x0401E2A0 RID: 123552
		[Nullable(1)]
		public string ExtraText = string.Empty;
	}
}
