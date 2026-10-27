using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C46 RID: 27718
	public class IOpenTraceSplineT
	{
		// Token: 0x1700CE6C RID: 52844
		// (get) Token: 0x06030D3A RID: 199994 RVA: 0x006A1F22 File Offset: 0x006A0122
		// (set) Token: 0x06030D3B RID: 199995 RVA: 0x006A1F2A File Offset: 0x006A012A
		public ETraceSplineOptionType Type { get; set; }

		// Token: 0x1700CE6D RID: 52845
		// (get) Token: 0x06030D3C RID: 199996 RVA: 0x006A1F33 File Offset: 0x006A0133
		// (set) Token: 0x06030D3D RID: 199997 RVA: 0x006A1F3B File Offset: 0x006A013B
		public int SplineEntityId { get; set; }

		// Token: 0x1700CE6E RID: 52846
		// (get) Token: 0x06030D3E RID: 199998 RVA: 0x006A1F44 File Offset: 0x006A0144
		// (set) Token: 0x06030D3F RID: 199999 RVA: 0x006A1F4C File Offset: 0x006A014C
		public float Duration { get; set; }

		// Token: 0x06030D40 RID: 200000 RVA: 0x006A1F55 File Offset: 0x006A0155
		public IOpenTraceSplineT()
		{
			this.Type = ETraceSplineOptionType.Open;
			this.SplineEntityId = 0;
			this.Duration = 0f;
		}
	}
}
