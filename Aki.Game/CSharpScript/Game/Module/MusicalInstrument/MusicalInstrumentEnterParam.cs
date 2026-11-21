using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004355 RID: 17237
	public class MusicalInstrumentEnterParam
	{
		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x0602B88B RID: 178315 RVA: 0x00C3BAA5 File Offset: 0x00C39CA5
		// (set) Token: 0x0602B88C RID: 178316 RVA: 0x00C3BAAD File Offset: 0x00C39CAD
		public EInstrumentType Type { get; set; }

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x0602B88D RID: 178317 RVA: 0x00C3BAB6 File Offset: 0x00C39CB6
		// (set) Token: 0x0602B88E RID: 178318 RVA: 0x00C3BABE File Offset: 0x00C39CBE
		public int? QteId { get; set; }
	}
}
