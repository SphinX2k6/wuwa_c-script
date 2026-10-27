using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD3 RID: 19155
	public class ICheckOnlinePlayerT
	{
		// Token: 0x17008AE2 RID: 35554
		// (get) Token: 0x0601E158 RID: 123224 RVA: 0x004386BB File Offset: 0x004368BB
		// (set) Token: 0x0601E159 RID: 123225 RVA: 0x004386C3 File Offset: 0x004368C3
		public ECheckEntity Type { get; set; }

		// Token: 0x17008AE3 RID: 35555
		// (get) Token: 0x0601E15A RID: 123226 RVA: 0x004386CC File Offset: 0x004368CC
		// (set) Token: 0x0601E15B RID: 123227 RVA: 0x004386D4 File Offset: 0x004368D4
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601E15C RID: 123228 RVA: 0x004386DD File Offset: 0x004368DD
		public ICheckOnlinePlayerT()
		{
			this.Type = ECheckEntity.OnlinePlayer;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
