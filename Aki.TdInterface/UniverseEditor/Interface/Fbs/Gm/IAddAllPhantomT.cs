using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A99 RID: 19097
	public class IAddAllPhantomT
	{
		// Token: 0x170085C7 RID: 34247
		// (get) Token: 0x0601CB46 RID: 117574 RVA: 0x0040C14E File Offset: 0x0040A34E
		// (set) Token: 0x0601CB47 RID: 117575 RVA: 0x0040C156 File Offset: 0x0040A356
		public EGmCommand Type { get; set; }

		// Token: 0x0601CB48 RID: 117576 RVA: 0x0040C15F File Offset: 0x0040A35F
		public IAddAllPhantomT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
