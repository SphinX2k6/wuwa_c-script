using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200518E RID: 20878
	public class IPreGenderCondtionT
	{
		// Token: 0x17009588 RID: 38280
		// (get) Token: 0x06020DB1 RID: 134577 RVA: 0x0048C104 File Offset: 0x0048A304
		// (set) Token: 0x06020DB2 RID: 134578 RVA: 0x0048C10C File Offset: 0x0048A30C
		public EAccessQuestCondition Type { get; set; }

		// Token: 0x17009589 RID: 38281
		// (get) Token: 0x06020DB3 RID: 134579 RVA: 0x0048C115 File Offset: 0x0048A315
		// (set) Token: 0x06020DB4 RID: 134580 RVA: 0x0048C11D File Offset: 0x0048A31D
		public EGender Gender { get; set; }

		// Token: 0x06020DB5 RID: 134581 RVA: 0x0048C126 File Offset: 0x0048A326
		public IPreGenderCondtionT()
		{
			this.Type = EAccessQuestCondition.ExploreLevel;
			this.Gender = EGender.M;
		}
	}
}
