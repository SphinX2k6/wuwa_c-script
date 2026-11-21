using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x02004893 RID: 18579
	public class InstanceDetectionDynamicData
	{
		// Token: 0x04018D37 RID: 101687
		public bool IsSelect;

		// Token: 0x04018D38 RID: 101688
		public bool IsOnlyOneGrid;

		// Token: 0x04018D39 RID: 101689
		public bool IsShow = true;

		// Token: 0x04018D3A RID: 101690
		public int InstanceSeriesTitle;

		// Token: 0x04018D3B RID: 101691
		public int InstanceGirdId;

		// Token: 0x04018D3C RID: 101692
		public EInstanceDetectionExtraType ExtraType;

		// Token: 0x04018D3D RID: 101693
		[Nullable(1)]
		public string ExtraText = string.Empty;
	}
}
