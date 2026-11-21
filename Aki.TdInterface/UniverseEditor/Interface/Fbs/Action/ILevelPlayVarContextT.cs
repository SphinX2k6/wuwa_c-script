using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709E RID: 28830
	public class ILevelPlayVarContextT
	{
		// Token: 0x1700D331 RID: 54065
		// (get) Token: 0x060320DD RID: 205021 RVA: 0x006C6830 File Offset: 0x006C4A30
		// (set) Token: 0x060320DE RID: 205022 RVA: 0x006C6838 File Offset: 0x006C4A38
		public EVarContext Type { get; set; }

		// Token: 0x1700D332 RID: 54066
		// (get) Token: 0x060320DF RID: 205023 RVA: 0x006C6841 File Offset: 0x006C4A41
		// (set) Token: 0x060320E0 RID: 205024 RVA: 0x006C6849 File Offset: 0x006C4A49
		public int Id { get; set; }

		// Token: 0x060320E1 RID: 205025 RVA: 0x006C6852 File Offset: 0x006C4A52
		public ILevelPlayVarContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
