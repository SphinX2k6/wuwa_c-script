using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007244 RID: 29252
	public class IMotorBounceT
	{
		// Token: 0x1700D651 RID: 54865
		// (get) Token: 0x06032EFE RID: 208638 RVA: 0x006E068F File Offset: 0x006DE88F
		// (set) Token: 0x06032EFF RID: 208639 RVA: 0x006E0697 File Offset: 0x006DE897
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D652 RID: 54866
		// (get) Token: 0x06032F00 RID: 208640 RVA: 0x006E06A0 File Offset: 0x006DE8A0
		// (set) Token: 0x06032F01 RID: 208641 RVA: 0x006E06A8 File Offset: 0x006DE8A8
		public int Height { get; set; }

		// Token: 0x1700D653 RID: 54867
		// (get) Token: 0x06032F02 RID: 208642 RVA: 0x006E06B1 File Offset: 0x006DE8B1
		// (set) Token: 0x06032F03 RID: 208643 RVA: 0x006E06B9 File Offset: 0x006DE8B9
		public float Time { get; set; }

		// Token: 0x1700D654 RID: 54868
		// (get) Token: 0x06032F04 RID: 208644 RVA: 0x006E06C2 File Offset: 0x006DE8C2
		// (set) Token: 0x06032F05 RID: 208645 RVA: 0x006E06CA File Offset: 0x006DE8CA
		public string MotionCurve { get; set; }

		// Token: 0x1700D655 RID: 54869
		// (get) Token: 0x06032F06 RID: 208646 RVA: 0x006E06D3 File Offset: 0x006DE8D3
		// (set) Token: 0x06032F07 RID: 208647 RVA: 0x006E06DB File Offset: 0x006DE8DB
		public EMotorBounceSkillType SkillType { get; set; }

		// Token: 0x1700D656 RID: 54870
		// (get) Token: 0x06032F08 RID: 208648 RVA: 0x006E06E4 File Offset: 0x006DE8E4
		// (set) Token: 0x06032F09 RID: 208649 RVA: 0x006E06EC File Offset: 0x006DE8EC
		public byte NullMask { get; set; }

		// Token: 0x06032F0A RID: 208650 RVA: 0x006E06F5 File Offset: 0x006DE8F5
		public IMotorBounceT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Height = 0;
			this.Time = 0f;
			this.MotionCurve = null;
			this.SkillType = EMotorBounceSkillType.None;
			this.NullMask = 0;
		}
	}
}
