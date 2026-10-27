using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200649F RID: 25759
	public class ICommonTipIdT
	{
		// Token: 0x1700BFB0 RID: 49072
		// (get) Token: 0x0602CA56 RID: 182870 RVA: 0x0062121C File Offset: 0x0061F41C
		// (set) Token: 0x0602CA57 RID: 182871 RVA: 0x00621224 File Offset: 0x0061F424
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFB1 RID: 49073
		// (get) Token: 0x0602CA58 RID: 182872 RVA: 0x0062122D File Offset: 0x0061F42D
		// (set) Token: 0x0602CA59 RID: 182873 RVA: 0x00621235 File Offset: 0x0061F435
		public int Id { get; set; }

		// Token: 0x0602CA5A RID: 182874 RVA: 0x0062123E File Offset: 0x0061F43E
		public ICommonTipIdT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.Id = 0;
		}
	}
}
