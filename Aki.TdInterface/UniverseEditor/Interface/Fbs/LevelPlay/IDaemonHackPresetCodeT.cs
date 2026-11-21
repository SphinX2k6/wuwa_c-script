using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048BE RID: 18622
	public class IDaemonHackPresetCodeT
	{
		// Token: 0x1700818F RID: 33167
		// (get) Token: 0x0601B885 RID: 112773 RVA: 0x003E4E87 File Offset: 0x003E3087
		// (set) Token: 0x0601B886 RID: 112774 RVA: 0x003E4E8F File Offset: 0x003E308F
		public string Code { get; set; }

		// Token: 0x17008190 RID: 33168
		// (get) Token: 0x0601B887 RID: 112775 RVA: 0x003E4E98 File Offset: 0x003E3098
		// (set) Token: 0x0601B888 RID: 112776 RVA: 0x003E4EA0 File Offset: 0x003E30A0
		public bool IsCorrect { get; set; }

		// Token: 0x17008191 RID: 33169
		// (get) Token: 0x0601B889 RID: 112777 RVA: 0x003E4EA9 File Offset: 0x003E30A9
		// (set) Token: 0x0601B88A RID: 112778 RVA: 0x003E4EB1 File Offset: 0x003E30B1
		public int Order { get; set; }

		// Token: 0x17008192 RID: 33170
		// (get) Token: 0x0601B88B RID: 112779 RVA: 0x003E4EBA File Offset: 0x003E30BA
		// (set) Token: 0x0601B88C RID: 112780 RVA: 0x003E4EC2 File Offset: 0x003E30C2
		public byte NullMask { get; set; }

		// Token: 0x0601B88D RID: 112781 RVA: 0x003E4ECB File Offset: 0x003E30CB
		public IDaemonHackPresetCodeT()
		{
			this.Code = null;
			this.IsCorrect = false;
			this.Order = 0;
			this.NullMask = 0;
		}
	}
}
