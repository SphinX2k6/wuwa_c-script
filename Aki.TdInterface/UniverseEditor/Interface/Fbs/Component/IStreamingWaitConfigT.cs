using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E1 RID: 23009
	public class IStreamingWaitConfigT
	{
		// Token: 0x1700ACDF RID: 44255
		// (get) Token: 0x06027098 RID: 159896 RVA: 0x0055F06C File Offset: 0x0055D26C
		// (set) Token: 0x06027099 RID: 159897 RVA: 0x0055F074 File Offset: 0x0055D274
		public float MinWaitStreamDuration { get; set; }

		// Token: 0x1700ACE0 RID: 44256
		// (get) Token: 0x0602709A RID: 159898 RVA: 0x0055F07D File Offset: 0x0055D27D
		// (set) Token: 0x0602709B RID: 159899 RVA: 0x0055F085 File Offset: 0x0055D285
		public float MaxWaitStreamDuration { get; set; }

		// Token: 0x0602709C RID: 159900 RVA: 0x0055F08E File Offset: 0x0055D28E
		public IStreamingWaitConfigT()
		{
			this.MinWaitStreamDuration = 0f;
			this.MaxWaitStreamDuration = 0f;
		}
	}
}
