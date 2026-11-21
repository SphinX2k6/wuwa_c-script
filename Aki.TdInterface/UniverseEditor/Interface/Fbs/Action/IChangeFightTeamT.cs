using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696B RID: 26987
	public class IChangeFightTeamT
	{
		// Token: 0x1700C6A7 RID: 50855
		// (get) Token: 0x0602E44A RID: 189514 RVA: 0x00651578 File Offset: 0x0064F778
		// (set) Token: 0x0602E44B RID: 189515 RVA: 0x00651580 File Offset: 0x0064F780
		public int TeamIndex { get; set; }

		// Token: 0x1700C6A8 RID: 50856
		// (get) Token: 0x0602E44C RID: 189516 RVA: 0x00651589 File Offset: 0x0064F789
		// (set) Token: 0x0602E44D RID: 189517 RVA: 0x00651591 File Offset: 0x0064F791
		public byte NullMask { get; set; }

		// Token: 0x0602E44E RID: 189518 RVA: 0x0065159A File Offset: 0x0064F79A
		public IChangeFightTeamT()
		{
			this.TeamIndex = 0;
			this.NullMask = 0;
		}
	}
}
