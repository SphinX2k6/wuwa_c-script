using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C56 RID: 19542
	public class IRunningResetReviveInfoT
	{
		// Token: 0x17008AA3 RID: 35491
		// (get) Token: 0x0601DFAF RID: 122799 RVA: 0x00434144 File Offset: 0x00432344
		// (set) Token: 0x0601DFB0 RID: 122800 RVA: 0x0043414C File Offset: 0x0043234C
		public List<IInstEntityDataT> ResetDatas { get; set; }

		// Token: 0x17008AA4 RID: 35492
		// (get) Token: 0x0601DFB1 RID: 122801 RVA: 0x00434155 File Offset: 0x00432355
		// (set) Token: 0x0601DFB2 RID: 122802 RVA: 0x0043415D File Offset: 0x0043235D
		public List<IInstEntityDataT> ReviveDatas { get; set; }

		// Token: 0x17008AA5 RID: 35493
		// (get) Token: 0x0601DFB3 RID: 122803 RVA: 0x00434166 File Offset: 0x00432366
		// (set) Token: 0x0601DFB4 RID: 122804 RVA: 0x0043416E File Offset: 0x0043236E
		public byte NullMask { get; set; }

		// Token: 0x0601DFB5 RID: 122805 RVA: 0x00434177 File Offset: 0x00432377
		public IRunningResetReviveInfoT()
		{
			this.ResetDatas = null;
			this.ReviveDatas = null;
			this.NullMask = 0;
		}
	}
}
