using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F4 RID: 26356
	public class IEntityVarContextT
	{
		// Token: 0x1700C3E1 RID: 50145
		// (get) Token: 0x0602DD62 RID: 187746 RVA: 0x00644A84 File Offset: 0x00642C84
		// (set) Token: 0x0602DD63 RID: 187747 RVA: 0x00644A8C File Offset: 0x00642C8C
		public EVarContext Type { get; set; }

		// Token: 0x1700C3E2 RID: 50146
		// (get) Token: 0x0602DD64 RID: 187748 RVA: 0x00644A95 File Offset: 0x00642C95
		// (set) Token: 0x0602DD65 RID: 187749 RVA: 0x00644A9D File Offset: 0x00642C9D
		public int Id { get; set; }

		// Token: 0x1700C3E3 RID: 50147
		// (get) Token: 0x0602DD66 RID: 187750 RVA: 0x00644AA6 File Offset: 0x00642CA6
		// (set) Token: 0x0602DD67 RID: 187751 RVA: 0x00644AAE File Offset: 0x00642CAE
		public EEntityVarMatchType MatchType { get; set; }

		// Token: 0x1700C3E4 RID: 50148
		// (get) Token: 0x0602DD68 RID: 187752 RVA: 0x00644AB7 File Offset: 0x00642CB7
		// (set) Token: 0x0602DD69 RID: 187753 RVA: 0x00644ABF File Offset: 0x00642CBF
		public byte NullMask { get; set; }

		// Token: 0x0602DD6A RID: 187754 RVA: 0x00644AC8 File Offset: 0x00642CC8
		public IEntityVarContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
			this.MatchType = EEntityVarMatchType.EntityId;
			this.NullMask = 0;
		}
	}
}
