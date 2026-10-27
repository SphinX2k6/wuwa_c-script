using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679F RID: 26527
	public class IFindSunSpiritT
	{
		// Token: 0x1700C4EE RID: 50414
		// (get) Token: 0x0602E2A8 RID: 189096 RVA: 0x0064E4AB File Offset: 0x0064C6AB
		// (set) Token: 0x0602E2A9 RID: 189097 RVA: 0x0064E4B3 File Offset: 0x0064C6B3
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C4EF RID: 50415
		// (get) Token: 0x0602E2AA RID: 189098 RVA: 0x0064E4BC File Offset: 0x0064C6BC
		// (set) Token: 0x0602E2AB RID: 189099 RVA: 0x0064E4C4 File Offset: 0x0064C6C4
		public int Id { get; set; }

		// Token: 0x1700C4F0 RID: 50416
		// (get) Token: 0x0602E2AC RID: 189100 RVA: 0x0064E4CD File Offset: 0x0064C6CD
		// (set) Token: 0x0602E2AD RID: 189101 RVA: 0x0064E4D5 File Offset: 0x0064C6D5
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700C4F1 RID: 50417
		// (get) Token: 0x0602E2AE RID: 189102 RVA: 0x0064E4DE File Offset: 0x0064C6DE
		// (set) Token: 0x0602E2AF RID: 189103 RVA: 0x0064E4E6 File Offset: 0x0064C6E6
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700C4F2 RID: 50418
		// (get) Token: 0x0602E2B0 RID: 189104 RVA: 0x0064E4EF File Offset: 0x0064C6EF
		// (set) Token: 0x0602E2B1 RID: 189105 RVA: 0x0064E4F7 File Offset: 0x0064C6F7
		public List<int> SunSpiritEntityIds { get; set; }

		// Token: 0x1700C4F3 RID: 50419
		// (get) Token: 0x0602E2B2 RID: 189106 RVA: 0x0064E500 File Offset: 0x0064C700
		// (set) Token: 0x0602E2B3 RID: 189107 RVA: 0x0064E508 File Offset: 0x0064C708
		public List<int> TargetLocationIds { get; set; }

		// Token: 0x1700C4F4 RID: 50420
		// (get) Token: 0x0602E2B4 RID: 189108 RVA: 0x0064E511 File Offset: 0x0064C711
		// (set) Token: 0x0602E2B5 RID: 189109 RVA: 0x0064E519 File Offset: 0x0064C719
		public ISunSpiritDifficultyReductionT DifficultyReductionConfig { get; set; }

		// Token: 0x0602E2B6 RID: 189110 RVA: 0x0064E522 File Offset: 0x0064C722
		public IFindSunSpiritT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
			this.Pos = null;
			this.Direction = null;
			this.SunSpiritEntityIds = null;
			this.TargetLocationIds = null;
			this.DifficultyReductionConfig = null;
		}
	}
}
