using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FCD RID: 24525
	public class IStateRotationConfigT
	{
		// Token: 0x1700B5A4 RID: 46500
		// (get) Token: 0x06029479 RID: 169081 RVA: 0x005A26AA File Offset: 0x005A08AA
		// (set) Token: 0x0602947A RID: 169082 RVA: 0x005A26B2 File Offset: 0x005A08B2
		public string State { get; set; }

		// Token: 0x1700B5A5 RID: 46501
		// (get) Token: 0x0602947B RID: 169083 RVA: 0x005A26BB File Offset: 0x005A08BB
		// (set) Token: 0x0602947C RID: 169084 RVA: 0x005A26C3 File Offset: 0x005A08C3
		public bool IsLoop { get; set; }

		// Token: 0x1700B5A6 RID: 46502
		// (get) Token: 0x0602947D RID: 169085 RVA: 0x005A26CC File Offset: 0x005A08CC
		// (set) Token: 0x0602947E RID: 169086 RVA: 0x005A26D4 File Offset: 0x005A08D4
		public IStartRotationConfigT StartRotationConfig { get; set; }

		// Token: 0x1700B5A7 RID: 46503
		// (get) Token: 0x0602947F RID: 169087 RVA: 0x005A26DD File Offset: 0x005A08DD
		// (set) Token: 0x06029480 RID: 169088 RVA: 0x005A26E5 File Offset: 0x005A08E5
		public string RotatePoint { get; set; }

		// Token: 0x1700B5A8 RID: 46504
		// (get) Token: 0x06029481 RID: 169089 RVA: 0x005A26EE File Offset: 0x005A08EE
		// (set) Token: 0x06029482 RID: 169090 RVA: 0x005A26F6 File Offset: 0x005A08F6
		public List<IRotationConfigT> RotationConfig { get; set; }

		// Token: 0x1700B5A9 RID: 46505
		// (get) Token: 0x06029483 RID: 169091 RVA: 0x005A26FF File Offset: 0x005A08FF
		// (set) Token: 0x06029484 RID: 169092 RVA: 0x005A2707 File Offset: 0x005A0907
		public List<IKeyRotatorConfigT> KeyRotatorConfig { get; set; }

		// Token: 0x1700B5AA RID: 46506
		// (get) Token: 0x06029485 RID: 169093 RVA: 0x005A2710 File Offset: 0x005A0910
		// (set) Token: 0x06029486 RID: 169094 RVA: 0x005A2718 File Offset: 0x005A0918
		public List<IAxisAngleMethodConfigT> AxisAngleMethodConfig { get; set; }

		// Token: 0x1700B5AB RID: 46507
		// (get) Token: 0x06029487 RID: 169095 RVA: 0x005A2721 File Offset: 0x005A0921
		// (set) Token: 0x06029488 RID: 169096 RVA: 0x005A2729 File Offset: 0x005A0929
		public bool KeepLastRotation { get; set; }

		// Token: 0x1700B5AC RID: 46508
		// (get) Token: 0x06029489 RID: 169097 RVA: 0x005A2732 File Offset: 0x005A0932
		// (set) Token: 0x0602948A RID: 169098 RVA: 0x005A273A File Offset: 0x005A093A
		public byte NullMask { get; set; }

		// Token: 0x0602948B RID: 169099 RVA: 0x005A2744 File Offset: 0x005A0944
		public IStateRotationConfigT()
		{
			this.State = null;
			this.IsLoop = false;
			this.StartRotationConfig = null;
			this.RotatePoint = null;
			this.RotationConfig = null;
			this.KeyRotatorConfig = null;
			this.AxisAngleMethodConfig = null;
			this.KeepLastRotation = false;
			this.NullMask = 0;
		}
	}
}
