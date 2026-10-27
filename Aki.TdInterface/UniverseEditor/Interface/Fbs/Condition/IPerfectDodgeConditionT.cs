using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C6E RID: 19566
	public class IPerfectDodgeConditionT
	{
		// Token: 0x17008E1E RID: 36382
		// (get) Token: 0x0601F06F RID: 127087 RVA: 0x004567D3 File Offset: 0x004549D3
		// (set) Token: 0x0601F070 RID: 127088 RVA: 0x004567DB File Offset: 0x004549DB
		public EBattleConditionType Type { get; set; }

		// Token: 0x17008E1F RID: 36383
		// (get) Token: 0x0601F071 RID: 127089 RVA: 0x004567E4 File Offset: 0x004549E4
		// (set) Token: 0x0601F072 RID: 127090 RVA: 0x004567EC File Offset: 0x004549EC
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601F073 RID: 127091 RVA: 0x004567F5 File Offset: 0x004549F5
		public IPerfectDodgeConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
