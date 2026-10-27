using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584A RID: 22602
	public class IRenderQuantumFollowShooterT
	{
		// Token: 0x1700A8E8 RID: 43240
		// (get) Token: 0x0602609D RID: 155805 RVA: 0x0053EA50 File Offset: 0x0053CC50
		// (set) Token: 0x0602609E RID: 155806 RVA: 0x0053EA58 File Offset: 0x0053CC58
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700A8E9 RID: 43241
		// (get) Token: 0x0602609F RID: 155807 RVA: 0x0053EA61 File Offset: 0x0053CC61
		// (set) Token: 0x060260A0 RID: 155808 RVA: 0x0053EA69 File Offset: 0x0053CC69
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700A8EA RID: 43242
		// (get) Token: 0x060260A1 RID: 155809 RVA: 0x0053EA72 File Offset: 0x0053CC72
		// (set) Token: 0x060260A2 RID: 155810 RVA: 0x0053EA7A File Offset: 0x0053CC7A
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700A8EB RID: 43243
		// (get) Token: 0x060260A3 RID: 155811 RVA: 0x0053EA83 File Offset: 0x0053CC83
		// (set) Token: 0x060260A4 RID: 155812 RVA: 0x0053EA8B File Offset: 0x0053CC8B
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700A8EC RID: 43244
		// (get) Token: 0x060260A5 RID: 155813 RVA: 0x0053EA94 File Offset: 0x0053CC94
		// (set) Token: 0x060260A6 RID: 155814 RVA: 0x0053EA9C File Offset: 0x0053CC9C
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060260A7 RID: 155815 RVA: 0x0053EAA5 File Offset: 0x0053CCA5
		public IRenderQuantumFollowShooterT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.CenterTarget = null;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
