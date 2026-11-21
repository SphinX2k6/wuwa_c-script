using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004863 RID: 18531
	public class IMatchPhantomRoleT
	{
		// Token: 0x1700810B RID: 33035
		// (get) Token: 0x0601B655 RID: 112213 RVA: 0x003E1088 File Offset: 0x003DF288
		// (set) Token: 0x0601B656 RID: 112214 RVA: 0x003E1090 File Offset: 0x003DF290
		public EMatchRoleType Type { get; set; }

		// Token: 0x1700810C RID: 33036
		// (get) Token: 0x0601B657 RID: 112215 RVA: 0x003E1099 File Offset: 0x003DF299
		// (set) Token: 0x0601B658 RID: 112216 RVA: 0x003E10A1 File Offset: 0x003DF2A1
		public int Id { get; set; }

		// Token: 0x1700810D RID: 33037
		// (get) Token: 0x0601B659 RID: 112217 RVA: 0x003E10AA File Offset: 0x003DF2AA
		// (set) Token: 0x0601B65A RID: 112218 RVA: 0x003E10B2 File Offset: 0x003DF2B2
		public ECompare Compare { get; set; }

		// Token: 0x1700810E RID: 33038
		// (get) Token: 0x0601B65B RID: 112219 RVA: 0x003E10BB File Offset: 0x003DF2BB
		// (set) Token: 0x0601B65C RID: 112220 RVA: 0x003E10C3 File Offset: 0x003DF2C3
		public byte NullMask { get; set; }

		// Token: 0x0601B65D RID: 112221 RVA: 0x003E10CC File Offset: 0x003DF2CC
		public IMatchPhantomRoleT()
		{
			this.Type = EMatchRoleType.Player;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.NullMask = 0;
		}
	}
}
