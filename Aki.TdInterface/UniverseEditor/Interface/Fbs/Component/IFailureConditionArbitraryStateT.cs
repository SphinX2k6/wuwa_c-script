using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005220 RID: 21024
	public class IFailureConditionArbitraryStateT
	{
		// Token: 0x170099FC RID: 39420
		// (get) Token: 0x060222BB RID: 139963 RVA: 0x004BDA1B File Offset: 0x004BBC1B
		// (set) Token: 0x060222BC RID: 139964 RVA: 0x004BDA23 File Offset: 0x004BBC23
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x170099FD RID: 39421
		// (get) Token: 0x060222BD RID: 139965 RVA: 0x004BDA2C File Offset: 0x004BBC2C
		// (set) Token: 0x060222BE RID: 139966 RVA: 0x004BDA34 File Offset: 0x004BBC34
		public string State { get; set; }

		// Token: 0x060222BF RID: 139967 RVA: 0x004BDA3D File Offset: 0x004BBC3D
		public IFailureConditionArbitraryStateT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
			this.State = null;
		}
	}
}
