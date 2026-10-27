using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200659E RID: 26014
	public class IDestroySelfT
	{
		// Token: 0x1700C132 RID: 49458
		// (get) Token: 0x0602D20D RID: 184845 RVA: 0x00630844 File Offset: 0x0062EA44
		// (set) Token: 0x0602D20E RID: 184846 RVA: 0x0063084C File Offset: 0x0062EA4C
		public bool DelayDestroy { get; set; }

		// Token: 0x1700C133 RID: 49459
		// (get) Token: 0x0602D20F RID: 184847 RVA: 0x00630855 File Offset: 0x0062EA55
		// (set) Token: 0x0602D210 RID: 184848 RVA: 0x0063085D File Offset: 0x0062EA5D
		public byte NullMask { get; set; }

		// Token: 0x0602D211 RID: 184849 RVA: 0x00630866 File Offset: 0x0062EA66
		public IDestroySelfT()
		{
			this.DelayDestroy = false;
			this.NullMask = 0;
		}
	}
}
