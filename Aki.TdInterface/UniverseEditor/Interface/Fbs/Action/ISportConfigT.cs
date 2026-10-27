using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200719D RID: 29085
	public class ISportConfigT
	{
		// Token: 0x1700D803 RID: 55299
		// (get) Token: 0x0603391A RID: 211226 RVA: 0x006F1F32 File Offset: 0x006F0132
		// (set) Token: 0x0603391B RID: 211227 RVA: 0x006F1F3A File Offset: 0x006F013A
		public ESportStateType Type { get; set; }

		// Token: 0x0603391C RID: 211228 RVA: 0x006F1F43 File Offset: 0x006F0143
		public ISportConfigT()
		{
			this.Type = ESportStateType.Slide;
		}
	}
}
