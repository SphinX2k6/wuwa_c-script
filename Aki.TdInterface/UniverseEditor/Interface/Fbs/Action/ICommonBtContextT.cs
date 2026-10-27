using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006463 RID: 25699
	public class ICommonBtContextT
	{
		// Token: 0x1700BF40 RID: 48960
		// (get) Token: 0x0602C794 RID: 182164 RVA: 0x00619510 File Offset: 0x00617710
		// (set) Token: 0x0602C795 RID: 182165 RVA: 0x00619518 File Offset: 0x00617718
		public EVarContext Type { get; set; }

		// Token: 0x1700BF41 RID: 48961
		// (get) Token: 0x0602C796 RID: 182166 RVA: 0x00619521 File Offset: 0x00617721
		// (set) Token: 0x0602C797 RID: 182167 RVA: 0x00619529 File Offset: 0x00617729
		public int Id { get; set; }

		// Token: 0x0602C798 RID: 182168 RVA: 0x00619532 File Offset: 0x00617732
		public ICommonBtContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
