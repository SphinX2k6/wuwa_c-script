using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E54 RID: 15956
	public class IBvbNpcScoreT
	{
		// Token: 0x17006BBC RID: 27580
		// (get) Token: 0x060157D5 RID: 88021 RVA: 0x00319A22 File Offset: 0x00317C22
		// (set) Token: 0x060157D6 RID: 88022 RVA: 0x00319A2A File Offset: 0x00317C2A
		public ESystemVarName Type { get; set; }

		// Token: 0x060157D7 RID: 88023 RVA: 0x00319A33 File Offset: 0x00317C33
		public IBvbNpcScoreT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
