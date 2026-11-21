using System;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006953 RID: 26963
	public class IChangeEntityCampT
	{
		// Token: 0x1700C677 RID: 50807
		// (get) Token: 0x0602E380 RID: 189312 RVA: 0x00650124 File Offset: 0x0064E324
		// (set) Token: 0x0602E381 RID: 189313 RVA: 0x0065012C File Offset: 0x0064E32C
		public int TargetEntity { get; set; }

		// Token: 0x1700C678 RID: 50808
		// (get) Token: 0x0602E382 RID: 189314 RVA: 0x00650135 File Offset: 0x0064E335
		// (set) Token: 0x0602E383 RID: 189315 RVA: 0x0065013D File Offset: 0x0064E33D
		public ECamp Camp { get; set; }

		// Token: 0x0602E384 RID: 189316 RVA: 0x00650146 File Offset: 0x0064E346
		public IChangeEntityCampT()
		{
			this.TargetEntity = 0;
			this.Camp = ECamp.Player;
		}
	}
}
