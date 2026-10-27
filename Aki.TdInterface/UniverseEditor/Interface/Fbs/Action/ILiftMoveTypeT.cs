using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A00 RID: 27136
	public class ILiftMoveTypeT
	{
		// Token: 0x1700C959 RID: 51545
		// (get) Token: 0x0602F7C5 RID: 194501 RVA: 0x00677896 File Offset: 0x00675A96
		// (set) Token: 0x0602F7C6 RID: 194502 RVA: 0x0067789E File Offset: 0x00675A9E
		public ELiftMoveType Type { get; set; }

		// Token: 0x0602F7C7 RID: 194503 RVA: 0x006778A7 File Offset: 0x00675AA7
		public ILiftMoveTypeT()
		{
			this.Type = ELiftMoveType.Default;
		}
	}
}
