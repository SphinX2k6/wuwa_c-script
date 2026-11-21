using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E54 RID: 24148
	public class IRenderQuantumFollowShooterT
	{
		// Token: 0x1700B213 RID: 45587
		// (get) Token: 0x060285E4 RID: 165348 RVA: 0x005852B4 File Offset: 0x005834B4
		// (set) Token: 0x060285E5 RID: 165349 RVA: 0x005852BC File Offset: 0x005834BC
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700B214 RID: 45588
		// (get) Token: 0x060285E6 RID: 165350 RVA: 0x005852C5 File Offset: 0x005834C5
		// (set) Token: 0x060285E7 RID: 165351 RVA: 0x005852CD File Offset: 0x005834CD
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700B215 RID: 45589
		// (get) Token: 0x060285E8 RID: 165352 RVA: 0x005852D6 File Offset: 0x005834D6
		// (set) Token: 0x060285E9 RID: 165353 RVA: 0x005852DE File Offset: 0x005834DE
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700B216 RID: 45590
		// (get) Token: 0x060285EA RID: 165354 RVA: 0x005852E7 File Offset: 0x005834E7
		// (set) Token: 0x060285EB RID: 165355 RVA: 0x005852EF File Offset: 0x005834EF
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700B217 RID: 45591
		// (get) Token: 0x060285EC RID: 165356 RVA: 0x005852F8 File Offset: 0x005834F8
		// (set) Token: 0x060285ED RID: 165357 RVA: 0x00585300 File Offset: 0x00583500
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060285EE RID: 165358 RVA: 0x00585309 File Offset: 0x00583509
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
