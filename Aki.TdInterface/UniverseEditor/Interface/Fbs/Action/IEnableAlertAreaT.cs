using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB4 RID: 27828
	public class IEnableAlertAreaT
	{
		// Token: 0x1700CC22 RID: 52258
		// (get) Token: 0x0602FF64 RID: 196452 RVA: 0x006873F3 File Offset: 0x006855F3
		// (set) Token: 0x0602FF65 RID: 196453 RVA: 0x006873FB File Offset: 0x006855FB
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700CC23 RID: 52259
		// (get) Token: 0x0602FF66 RID: 196454 RVA: 0x00687404 File Offset: 0x00685604
		// (set) Token: 0x0602FF67 RID: 196455 RVA: 0x0068740C File Offset: 0x0068560C
		public int AreaId { get; set; }

		// Token: 0x1700CC24 RID: 52260
		// (get) Token: 0x0602FF68 RID: 196456 RVA: 0x00687415 File Offset: 0x00685615
		// (set) Token: 0x0602FF69 RID: 196457 RVA: 0x0068741D File Offset: 0x0068561D
		public bool IsEnable { get; set; }

		// Token: 0x1700CC25 RID: 52261
		// (get) Token: 0x0602FF6A RID: 196458 RVA: 0x00687426 File Offset: 0x00685626
		// (set) Token: 0x0602FF6B RID: 196459 RVA: 0x0068742E File Offset: 0x0068562E
		public TDisableAlertConditionUnion AutoDisableCondition { get; set; }

		// Token: 0x0602FF6C RID: 196460 RVA: 0x00687437 File Offset: 0x00685637
		public IEnableAlertAreaT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.IsEnable = false;
			this.AutoDisableCondition = null;
		}
	}
}
