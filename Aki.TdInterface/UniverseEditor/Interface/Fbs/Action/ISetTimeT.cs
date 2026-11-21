using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200785E RID: 30814
	public class ISetTimeT
	{
		// Token: 0x1700E207 RID: 57863
		// (get) Token: 0x06036322 RID: 221986 RVA: 0x00742983 File Offset: 0x00740B83
		// (set) Token: 0x06036323 RID: 221987 RVA: 0x0074298B File Offset: 0x00740B8B
		public EChangeTimerType Type { get; set; }

		// Token: 0x1700E208 RID: 57864
		// (get) Token: 0x06036324 RID: 221988 RVA: 0x00742994 File Offset: 0x00740B94
		// (set) Token: 0x06036325 RID: 221989 RVA: 0x0074299C File Offset: 0x00740B9C
		public int Time { get; set; }

		// Token: 0x1700E209 RID: 57865
		// (get) Token: 0x06036326 RID: 221990 RVA: 0x007429A5 File Offset: 0x00740BA5
		// (set) Token: 0x06036327 RID: 221991 RVA: 0x007429AD File Offset: 0x00740BAD
		public TVarRefUnion VarForTime { get; set; }

		// Token: 0x1700E20A RID: 57866
		// (get) Token: 0x06036328 RID: 221992 RVA: 0x007429B6 File Offset: 0x00740BB6
		// (set) Token: 0x06036329 RID: 221993 RVA: 0x007429BE File Offset: 0x00740BBE
		public byte NullMask { get; set; }

		// Token: 0x0603632A RID: 221994 RVA: 0x007429C7 File Offset: 0x00740BC7
		public ISetTimeT()
		{
			this.Type = EChangeTimerType.Add;
			this.Time = 0;
			this.VarForTime = null;
			this.NullMask = 0;
		}
	}
}
