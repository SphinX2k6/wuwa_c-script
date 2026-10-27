using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AEB RID: 19179
	public class ICheckPlayerGenderT
	{
		// Token: 0x17008B13 RID: 35603
		// (get) Token: 0x0601E238 RID: 123448 RVA: 0x0043A344 File Offset: 0x00438544
		// (set) Token: 0x0601E239 RID: 123449 RVA: 0x0043A34C File Offset: 0x0043854C
		public ECondition Type { get; set; }

		// Token: 0x17008B14 RID: 35604
		// (get) Token: 0x0601E23A RID: 123450 RVA: 0x0043A355 File Offset: 0x00438555
		// (set) Token: 0x0601E23B RID: 123451 RVA: 0x0043A35D File Offset: 0x0043855D
		public EGender Gender { get; set; }

		// Token: 0x0601E23C RID: 123452 RVA: 0x0043A366 File Offset: 0x00438566
		public ICheckPlayerGenderT()
		{
			this.Type = ECondition.CompareVar;
			this.Gender = EGender.M;
		}
	}
}
