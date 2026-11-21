using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772D RID: 30509
	public class ISendBattleStateTypeT
	{
		// Token: 0x1700DFB4 RID: 57268
		// (get) Token: 0x06035887 RID: 219271 RVA: 0x0072D0CA File Offset: 0x0072B2CA
		// (set) Token: 0x06035888 RID: 219272 RVA: 0x0072D0D2 File Offset: 0x0072B2D2
		public ESetBattleStateType Type { get; set; }

		// Token: 0x06035889 RID: 219273 RVA: 0x0072D0DB File Offset: 0x0072B2DB
		public ISendBattleStateTypeT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
		}
	}
}
