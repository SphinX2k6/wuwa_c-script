using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E00 RID: 15872
	public class IBvbAdjustPosPreferenceT
	{
		// Token: 0x17006B38 RID: 27448
		// (get) Token: 0x0601553B RID: 87355 RVA: 0x0031506E File Offset: 0x0031326E
		// (set) Token: 0x0601553C RID: 87356 RVA: 0x00315076 File Offset: 0x00313276
		public ESystemVarName Type { get; set; }

		// Token: 0x0601553D RID: 87357 RVA: 0x0031507F File Offset: 0x0031327F
		public IBvbAdjustPosPreferenceT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
