using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046BF RID: 18111
	public class KurotatoRoleSkillInfo : IKurotatoRoleSkillInfo
	{
		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x0602D870 RID: 186480 RVA: 0x00CBE9DA File Offset: 0x00CBCBDA
		// (set) Token: 0x0602D871 RID: 186481 RVA: 0x00CBE9E2 File Offset: 0x00CBCBE2
		public int AttrId { get; set; }

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x0602D872 RID: 186482 RVA: 0x00CBE9EB File Offset: 0x00CBCBEB
		// (set) Token: 0x0602D873 RID: 186483 RVA: 0x00CBE9F3 File Offset: 0x00CBCBF3
		public int Value { get; set; }

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x0602D874 RID: 186484 RVA: 0x00CBE9FC File Offset: 0x00CBCBFC
		// (set) Token: 0x0602D875 RID: 186485 RVA: 0x00CBEA04 File Offset: 0x00CBCC04
		public bool IsRecommend { get; set; }

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x0602D876 RID: 186486 RVA: 0x00CBEA0D File Offset: 0x00CBCC0D
		// (set) Token: 0x0602D877 RID: 186487 RVA: 0x00CBEA15 File Offset: 0x00CBCC15
		public bool? IsAddition { get; set; }

		// Token: 0x17005B8D RID: 23437
		// (get) Token: 0x0602D878 RID: 186488 RVA: 0x00CBEA1E File Offset: 0x00CBCC1E
		// (set) Token: 0x0602D879 RID: 186489 RVA: 0x00CBEA26 File Offset: 0x00CBCC26
		public int? BaseValue { get; set; }

		// Token: 0x17005B8E RID: 23438
		// (get) Token: 0x0602D87A RID: 186490 RVA: 0x00CBEA2F File Offset: 0x00CBCC2F
		// (set) Token: 0x0602D87B RID: 186491 RVA: 0x00CBEA37 File Offset: 0x00CBCC37
		public bool? IsLocked { get; set; }

		// Token: 0x17005B8F RID: 23439
		// (get) Token: 0x0602D87C RID: 186492 RVA: 0x00CBEA40 File Offset: 0x00CBCC40
		// (set) Token: 0x0602D87D RID: 186493 RVA: 0x00CBEA48 File Offset: 0x00CBCC48
		public int? LockedValue { get; set; }
	}
}
