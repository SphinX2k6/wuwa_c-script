using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578B RID: 22411
	public class IFailureConditionHitTargetEntityT
	{
		// Token: 0x1700A1FD RID: 41469
		// (get) Token: 0x0602426F RID: 148079 RVA: 0x004F880B File Offset: 0x004F6A0B
		// (set) Token: 0x06024270 RID: 148080 RVA: 0x004F8813 File Offset: 0x004F6A13
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x1700A1FE RID: 41470
		// (get) Token: 0x06024271 RID: 148081 RVA: 0x004F881C File Offset: 0x004F6A1C
		// (set) Token: 0x06024272 RID: 148082 RVA: 0x004F8824 File Offset: 0x004F6A24
		public List<int> EntityIds { get; set; }

		// Token: 0x06024273 RID: 148083 RVA: 0x004F882D File Offset: 0x004F6A2D
		public IFailureConditionHitTargetEntityT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
			this.EntityIds = null;
		}
	}
}
