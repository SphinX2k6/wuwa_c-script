using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761A RID: 30234
	public class IWriteLetterConfigT
	{
		// Token: 0x1700E59A RID: 58778
		// (get) Token: 0x06037120 RID: 225568 RVA: 0x007782DE File Offset: 0x007764DE
		// (set) Token: 0x06037121 RID: 225569 RVA: 0x007782E6 File Offset: 0x007764E6
		public int LetterId { get; set; }

		// Token: 0x06037122 RID: 225570 RVA: 0x007782EF File Offset: 0x007764EF
		public IWriteLetterConfigT()
		{
			this.LetterId = 0;
		}
	}
}
