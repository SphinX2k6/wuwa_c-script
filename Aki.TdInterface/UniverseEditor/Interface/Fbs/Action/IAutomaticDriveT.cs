using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682A RID: 26666
	public class IAutomaticDriveT
	{
		// Token: 0x1700C40B RID: 50187
		// (get) Token: 0x0602D913 RID: 186643 RVA: 0x0063C502 File Offset: 0x0063A702
		// (set) Token: 0x0602D914 RID: 186644 RVA: 0x0063C50A File Offset: 0x0063A70A
		public float StandbyTime { get; set; }

		// Token: 0x0602D915 RID: 186645 RVA: 0x0063C513 File Offset: 0x0063A713
		public IAutomaticDriveT()
		{
			this.StandbyTime = 0f;
		}
	}
}
