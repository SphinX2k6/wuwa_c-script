using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EA5 RID: 24229
	public class IScaleUpSpiritPerformConfigT
	{
		// Token: 0x1700B2EF RID: 45807
		// (get) Token: 0x0602893A RID: 166202 RVA: 0x0058C174 File Offset: 0x0058A374
		// (set) Token: 0x0602893B RID: 166203 RVA: 0x0058C17C File Offset: 0x0058A37C
		public bool IsInitHide { get; set; }

		// Token: 0x1700B2F0 RID: 45808
		// (get) Token: 0x0602893C RID: 166204 RVA: 0x0058C185 File Offset: 0x0058A385
		// (set) Token: 0x0602893D RID: 166205 RVA: 0x0058C18D File Offset: 0x0058A38D
		public string AppearEffectDa { get; set; }

		// Token: 0x1700B2F1 RID: 45809
		// (get) Token: 0x0602893E RID: 166206 RVA: 0x0058C196 File Offset: 0x0058A396
		// (set) Token: 0x0602893F RID: 166207 RVA: 0x0058C19E File Offset: 0x0058A39E
		public string ScaleUpEffectDa { get; set; }

		// Token: 0x1700B2F2 RID: 45810
		// (get) Token: 0x06028940 RID: 166208 RVA: 0x0058C1A7 File Offset: 0x0058A3A7
		// (set) Token: 0x06028941 RID: 166209 RVA: 0x0058C1AF File Offset: 0x0058A3AF
		public int ScaleUpPerformTag { get; set; }

		// Token: 0x1700B2F3 RID: 45811
		// (get) Token: 0x06028942 RID: 166210 RVA: 0x0058C1B8 File Offset: 0x0058A3B8
		// (set) Token: 0x06028943 RID: 166211 RVA: 0x0058C1C0 File Offset: 0x0058A3C0
		public byte NullMask { get; set; }

		// Token: 0x06028944 RID: 166212 RVA: 0x0058C1C9 File Offset: 0x0058A3C9
		public IScaleUpSpiritPerformConfigT()
		{
			this.IsInitHide = false;
			this.AppearEffectDa = null;
			this.ScaleUpEffectDa = null;
			this.ScaleUpPerformTag = 0;
			this.NullMask = 0;
		}
	}
}
