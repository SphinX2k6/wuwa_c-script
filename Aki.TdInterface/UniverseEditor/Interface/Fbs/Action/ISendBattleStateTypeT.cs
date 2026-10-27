using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6A RID: 28522
	public class ISendBattleStateTypeT
	{
		// Token: 0x1700D3E8 RID: 54248
		// (get) Token: 0x06032649 RID: 206409 RVA: 0x006CD88A File Offset: 0x006CBA8A
		// (set) Token: 0x0603264A RID: 206410 RVA: 0x006CD892 File Offset: 0x006CBA92
		public ESetBattleStateType Type { get; set; }

		// Token: 0x0603264B RID: 206411 RVA: 0x006CD89B File Offset: 0x006CBA9B
		public ISendBattleStateTypeT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
		}
	}
}
