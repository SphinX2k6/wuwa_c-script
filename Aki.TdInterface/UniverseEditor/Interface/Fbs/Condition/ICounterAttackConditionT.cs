using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF3 RID: 19443
	public class ICounterAttackConditionT
	{
		// Token: 0x17008D3B RID: 36155
		// (get) Token: 0x0601EC87 RID: 126087 RVA: 0x0044FF7F File Offset: 0x0044E17F
		// (set) Token: 0x0601EC88 RID: 126088 RVA: 0x0044FF87 File Offset: 0x0044E187
		public EBattleConditionType Type { get; set; }

		// Token: 0x17008D3C RID: 36156
		// (get) Token: 0x0601EC89 RID: 126089 RVA: 0x0044FF90 File Offset: 0x0044E190
		// (set) Token: 0x0601EC8A RID: 126090 RVA: 0x0044FF98 File Offset: 0x0044E198
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601EC8B RID: 126091 RVA: 0x0044FFA1 File Offset: 0x0044E1A1
		public ICounterAttackConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
