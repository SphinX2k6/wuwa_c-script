using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DE RID: 23006
	public class IStreamingSourceTriggerPointComponentT
	{
		// Token: 0x1700ACD8 RID: 44248
		// (get) Token: 0x0602707E RID: 159870 RVA: 0x0055EDD3 File Offset: 0x0055CFD3
		// (set) Token: 0x0602707F RID: 159871 RVA: 0x0055EDDB File Offset: 0x0055CFDB
		public bool Disabled { get; set; }

		// Token: 0x1700ACD9 RID: 44249
		// (get) Token: 0x06027080 RID: 159872 RVA: 0x0055EDE4 File Offset: 0x0055CFE4
		// (set) Token: 0x06027081 RID: 159873 RVA: 0x0055EDEC File Offset: 0x0055CFEC
		public int Radius { get; set; }

		// Token: 0x1700ACDA RID: 44250
		// (get) Token: 0x06027082 RID: 159874 RVA: 0x0055EDF5 File Offset: 0x0055CFF5
		// (set) Token: 0x06027083 RID: 159875 RVA: 0x0055EDFD File Offset: 0x0055CFFD
		public TStreamingSourceConfigUnion StreamingSource { get; set; }

		// Token: 0x1700ACDB RID: 44251
		// (get) Token: 0x06027084 RID: 159876 RVA: 0x0055EE06 File Offset: 0x0055D006
		// (set) Token: 0x06027085 RID: 159877 RVA: 0x0055EE0E File Offset: 0x0055D00E
		public byte NullMask { get; set; }

		// Token: 0x06027086 RID: 159878 RVA: 0x0055EE17 File Offset: 0x0055D017
		public IStreamingSourceTriggerPointComponentT()
		{
			this.Disabled = false;
			this.Radius = 0;
			this.StreamingSource = null;
			this.NullMask = 0;
		}
	}
}
