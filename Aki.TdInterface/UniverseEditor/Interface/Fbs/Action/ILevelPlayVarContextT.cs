using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EE RID: 27118
	public class ILevelPlayVarContextT
	{
		// Token: 0x1700C931 RID: 51505
		// (get) Token: 0x0602F71D RID: 194333 RVA: 0x006764D8 File Offset: 0x006746D8
		// (set) Token: 0x0602F71E RID: 194334 RVA: 0x006764E0 File Offset: 0x006746E0
		public EVarContext Type { get; set; }

		// Token: 0x1700C932 RID: 51506
		// (get) Token: 0x0602F71F RID: 194335 RVA: 0x006764E9 File Offset: 0x006746E9
		// (set) Token: 0x0602F720 RID: 194336 RVA: 0x006764F1 File Offset: 0x006746F1
		public int Id { get; set; }

		// Token: 0x0602F721 RID: 194337 RVA: 0x006764FA File Offset: 0x006746FA
		public ILevelPlayVarContextT()
		{
			this.Type = EVarContext.None;
			this.Id = 0;
		}
	}
}
