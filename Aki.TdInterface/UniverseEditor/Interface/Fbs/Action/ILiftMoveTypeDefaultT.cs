using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A09 RID: 27145
	public class ILiftMoveTypeDefaultT
	{
		// Token: 0x1700C966 RID: 51558
		// (get) Token: 0x0602F805 RID: 194565 RVA: 0x00677E4E File Offset: 0x0067604E
		// (set) Token: 0x0602F806 RID: 194566 RVA: 0x00677E56 File Offset: 0x00676056
		public ELiftMoveType Type { get; set; }

		// Token: 0x0602F807 RID: 194567 RVA: 0x00677E5F File Offset: 0x0067605F
		public ILiftMoveTypeDefaultT()
		{
			this.Type = ELiftMoveType.Default;
		}
	}
}
