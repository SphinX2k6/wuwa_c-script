using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A2 RID: 24738
	public class IActorFaceExpressionStopT
	{
		// Token: 0x1700B64D RID: 46669
		// (get) Token: 0x0602A3AC RID: 172972 RVA: 0x005D26BA File Offset: 0x005D08BA
		// (set) Token: 0x0602A3AD RID: 172973 RVA: 0x005D26C2 File Offset: 0x005D08C2
		public EActorFaceExpressionType Type { get; set; }

		// Token: 0x1700B64E RID: 46670
		// (get) Token: 0x0602A3AE RID: 172974 RVA: 0x005D26CB File Offset: 0x005D08CB
		// (set) Token: 0x0602A3AF RID: 172975 RVA: 0x005D26D3 File Offset: 0x005D08D3
		public float DelayTime { get; set; }

		// Token: 0x1700B64F RID: 46671
		// (get) Token: 0x0602A3B0 RID: 172976 RVA: 0x005D26DC File Offset: 0x005D08DC
		// (set) Token: 0x0602A3B1 RID: 172977 RVA: 0x005D26E4 File Offset: 0x005D08E4
		public byte NullMask { get; set; }

		// Token: 0x0602A3B2 RID: 172978 RVA: 0x005D26ED File Offset: 0x005D08ED
		public IActorFaceExpressionStopT()
		{
			this.Type = EActorFaceExpressionType.Play;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
