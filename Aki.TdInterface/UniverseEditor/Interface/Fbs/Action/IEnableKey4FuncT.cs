using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200666D RID: 26221
	public class IEnableKey4FuncT
	{
		// Token: 0x1700C2CA RID: 49866
		// (get) Token: 0x0602D8D9 RID: 186585 RVA: 0x0063CA14 File Offset: 0x0063AC14
		// (set) Token: 0x0602D8DA RID: 186586 RVA: 0x0063CA1C File Offset: 0x0063AC1C
		public bool IsEnable { get; set; }

		// Token: 0x1700C2CB RID: 49867
		// (get) Token: 0x0602D8DB RID: 186587 RVA: 0x0063CA25 File Offset: 0x0063AC25
		// (set) Token: 0x0602D8DC RID: 186588 RVA: 0x0063CA2D File Offset: 0x0063AC2D
		public EEnableKey4FuncKey FuncKey { get; set; }

		// Token: 0x0602D8DD RID: 186589 RVA: 0x0063CA36 File Offset: 0x0063AC36
		public IEnableKey4FuncT()
		{
			this.IsEnable = false;
			this.FuncKey = EEnableKey4FuncKey.TimeScaled;
		}
	}
}
