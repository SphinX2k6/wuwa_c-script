using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005026 RID: 20518
	public class ICheckSystemFunctionT
	{
		// Token: 0x170092D3 RID: 37587
		// (get) Token: 0x060200A5 RID: 131237 RVA: 0x00471E5A File Offset: 0x0047005A
		// (set) Token: 0x060200A6 RID: 131238 RVA: 0x00471E62 File Offset: 0x00470062
		public ECondition Type { get; set; }

		// Token: 0x170092D4 RID: 37588
		// (get) Token: 0x060200A7 RID: 131239 RVA: 0x00471E6B File Offset: 0x0047006B
		// (set) Token: 0x060200A8 RID: 131240 RVA: 0x00471E73 File Offset: 0x00470073
		public int SystemId { get; set; }

		// Token: 0x170092D5 RID: 37589
		// (get) Token: 0x060200A9 RID: 131241 RVA: 0x00471E7C File Offset: 0x0047007C
		// (set) Token: 0x060200AA RID: 131242 RVA: 0x00471E84 File Offset: 0x00470084
		public ECompare Compare { get; set; }

		// Token: 0x060200AB RID: 131243 RVA: 0x00471E8D File Offset: 0x0047008D
		public ICheckSystemFunctionT()
		{
			this.Type = ECondition.CompareVar;
			this.SystemId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
