using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC8 RID: 28104
	public class IFaceExpressionConfigT
	{
		// Token: 0x1700CE00 RID: 52736
		// (get) Token: 0x06030819 RID: 198681 RVA: 0x006966BE File Offset: 0x006948BE
		// (set) Token: 0x0603081A RID: 198682 RVA: 0x006966C6 File Offset: 0x006948C6
		public EFaceExpressionConfigType Type { get; set; }

		// Token: 0x0603081B RID: 198683 RVA: 0x006966CF File Offset: 0x006948CF
		public IFaceExpressionConfigT()
		{
			this.Type = EFaceExpressionConfigType.Morph;
		}
	}
}
