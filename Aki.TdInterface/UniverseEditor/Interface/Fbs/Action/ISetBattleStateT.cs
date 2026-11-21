using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007781 RID: 30593
	public class ISetBattleStateT
	{
		// Token: 0x1700E030 RID: 57392
		// (get) Token: 0x06035B30 RID: 219952 RVA: 0x007321E1 File Offset: 0x007303E1
		// (set) Token: 0x06035B31 RID: 219953 RVA: 0x007321E9 File Offset: 0x007303E9
		public TStateOptionUnion StateOption { get; set; }

		// Token: 0x06035B32 RID: 219954 RVA: 0x007321F2 File Offset: 0x007303F2
		public ISetBattleStateT()
		{
			this.StateOption = null;
		}
	}
}
