using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004839 RID: 18489
	public class ICommitLogT
	{
		// Token: 0x170084AD RID: 33965
		// (get) Token: 0x0601C951 RID: 117073 RVA: 0x0040A7AE File Offset: 0x004089AE
		// (set) Token: 0x0601C952 RID: 117074 RVA: 0x0040A7B6 File Offset: 0x004089B6
		public string Date { get; set; }

		// Token: 0x170084AE RID: 33966
		// (get) Token: 0x0601C953 RID: 117075 RVA: 0x0040A7BF File Offset: 0x004089BF
		// (set) Token: 0x0601C954 RID: 117076 RVA: 0x0040A7C7 File Offset: 0x004089C7
		public string Log { get; set; }

		// Token: 0x0601C955 RID: 117077 RVA: 0x0040A7D0 File Offset: 0x004089D0
		public ICommitLogT()
		{
			this.Date = null;
			this.Log = null;
		}
	}
}
