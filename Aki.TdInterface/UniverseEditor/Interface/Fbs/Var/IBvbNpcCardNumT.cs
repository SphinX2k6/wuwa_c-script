using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A6A RID: 14954
	public class IBvbNpcCardNumT
	{
		// Token: 0x1700667D RID: 26237
		// (get) Token: 0x0601445F RID: 83039 RVA: 0x002F60DE File Offset: 0x002F42DE
		// (set) Token: 0x06014460 RID: 83040 RVA: 0x002F60E6 File Offset: 0x002F42E6
		public ESystemVarName Type { get; set; }

		// Token: 0x06014461 RID: 83041 RVA: 0x002F60EF File Offset: 0x002F42EF
		public IBvbNpcCardNumT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
