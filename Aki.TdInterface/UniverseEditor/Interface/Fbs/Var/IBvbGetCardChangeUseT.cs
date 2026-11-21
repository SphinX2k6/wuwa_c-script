using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E36 RID: 15926
	public class IBvbGetCardChangeUseT
	{
		// Token: 0x17006B99 RID: 27545
		// (get) Token: 0x06015709 RID: 87817 RVA: 0x003184F3 File Offset: 0x003166F3
		// (set) Token: 0x0601570A RID: 87818 RVA: 0x003184FB File Offset: 0x003166FB
		public ESystemVarName Type { get; set; }

		// Token: 0x17006B9A RID: 27546
		// (get) Token: 0x0601570B RID: 87819 RVA: 0x00318504 File Offset: 0x00316704
		// (set) Token: 0x0601570C RID: 87820 RVA: 0x0031850C File Offset: 0x0031670C
		public TVarRefUnion Card { get; set; }

		// Token: 0x0601570D RID: 87821 RVA: 0x00318515 File Offset: 0x00316715
		public IBvbGetCardChangeUseT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Card = null;
		}
	}
}
