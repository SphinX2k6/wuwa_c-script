using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005906 RID: 22790
	public class ISettingSpringDirT
	{
		// Token: 0x1700AAD3 RID: 43731
		// (get) Token: 0x0602683E RID: 157758 RVA: 0x0054E721 File Offset: 0x0054C921
		// (set) Token: 0x0602683F RID: 157759 RVA: 0x0054E729 File Offset: 0x0054C929
		public bool IsSettingDir { get; set; }

		// Token: 0x1700AAD4 RID: 43732
		// (get) Token: 0x06026840 RID: 157760 RVA: 0x0054E732 File Offset: 0x0054C932
		// (set) Token: 0x06026841 RID: 157761 RVA: 0x0054E73A File Offset: 0x0054C93A
		public bool IsRotator { get; set; }

		// Token: 0x1700AAD5 RID: 43733
		// (get) Token: 0x06026842 RID: 157762 RVA: 0x0054E743 File Offset: 0x0054C943
		// (set) Token: 0x06026843 RID: 157763 RVA: 0x0054E74B File Offset: 0x0054C94B
		public IVectorInfoT SpringDir { get; set; }

		// Token: 0x06026844 RID: 157764 RVA: 0x0054E754 File Offset: 0x0054C954
		public ISettingSpringDirT()
		{
			this.IsSettingDir = false;
			this.IsRotator = false;
			this.SpringDir = null;
		}
	}
}
