using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA6 RID: 27558
	public class IDarkTideSetMapMarkStateT
	{
		// Token: 0x1700CA30 RID: 51760
		// (get) Token: 0x0602F6DB RID: 194267 RVA: 0x00678524 File Offset: 0x00676724
		// (set) Token: 0x0602F6DC RID: 194268 RVA: 0x0067852C File Offset: 0x0067672C
		public int MapMarkId { get; set; }

		// Token: 0x1700CA31 RID: 51761
		// (get) Token: 0x0602F6DD RID: 194269 RVA: 0x00678535 File Offset: 0x00676735
		// (set) Token: 0x0602F6DE RID: 194270 RVA: 0x0067853D File Offset: 0x0067673D
		public EDarkTideMapMarkStateType StateType { get; set; }

		// Token: 0x0602F6DF RID: 194271 RVA: 0x00678546 File Offset: 0x00676746
		public IDarkTideSetMapMarkStateT()
		{
			this.MapMarkId = 0;
			this.StateType = EDarkTideMapMarkStateType.Hide;
		}
	}
}
