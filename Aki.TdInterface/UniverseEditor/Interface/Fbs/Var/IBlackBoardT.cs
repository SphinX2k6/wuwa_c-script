using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DE5 RID: 15845
	public class IBlackBoardT
	{
		// Token: 0x17006B01 RID: 27393
		// (get) Token: 0x06015449 RID: 87113 RVA: 0x00313857 File Offset: 0x00311A57
		// (set) Token: 0x0601544A RID: 87114 RVA: 0x0031385F File Offset: 0x00311A5F
		public EBlackBoardType Type { get; set; }

		// Token: 0x17006B02 RID: 27394
		// (get) Token: 0x0601544B RID: 87115 RVA: 0x00313868 File Offset: 0x00311A68
		// (set) Token: 0x0601544C RID: 87116 RVA: 0x00313870 File Offset: 0x00311A70
		public string Key { get; set; }

		// Token: 0x0601544D RID: 87117 RVA: 0x00313879 File Offset: 0x00311A79
		public IBlackBoardT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
		}
	}
}
