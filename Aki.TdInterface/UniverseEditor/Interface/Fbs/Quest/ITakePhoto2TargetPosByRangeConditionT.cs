using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F9 RID: 17913
	public class ITakePhoto2TargetPosByRangeConditionT
	{
		// Token: 0x17007D53 RID: 32083
		// (get) Token: 0x0601A2FC RID: 107260 RVA: 0x003BAD09 File Offset: 0x003B8F09
		// (set) Token: 0x0601A2FD RID: 107261 RVA: 0x003BAD11 File Offset: 0x003B8F11
		public TRangeUnion Range { get; set; }

		// Token: 0x0601A2FE RID: 107262 RVA: 0x003BAD1A File Offset: 0x003B8F1A
		public ITakePhoto2TargetPosByRangeConditionT()
		{
			this.Range = null;
		}
	}
}
