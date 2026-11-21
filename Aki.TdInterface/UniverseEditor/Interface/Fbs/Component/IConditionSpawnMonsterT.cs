using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555A RID: 21850
	public class IConditionSpawnMonsterT
	{
		// Token: 0x17009C3B RID: 39995
		// (get) Token: 0x06022AE3 RID: 142051 RVA: 0x004C6F37 File Offset: 0x004C5137
		// (set) Token: 0x06022AE4 RID: 142052 RVA: 0x004C6F3F File Offset: 0x004C513F
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009C3C RID: 39996
		// (get) Token: 0x06022AE5 RID: 142053 RVA: 0x004C6F48 File Offset: 0x004C5148
		// (set) Token: 0x06022AE6 RID: 142054 RVA: 0x004C6F50 File Offset: 0x004C5150
		public IConditionGroupT EndCondition { get; set; }

		// Token: 0x17009C3D RID: 39997
		// (get) Token: 0x06022AE7 RID: 142055 RVA: 0x004C6F59 File Offset: 0x004C5159
		// (set) Token: 0x06022AE8 RID: 142056 RVA: 0x004C6F61 File Offset: 0x004C5161
		public bool Loop { get; set; }

		// Token: 0x17009C3E RID: 39998
		// (get) Token: 0x06022AE9 RID: 142057 RVA: 0x004C6F6A File Offset: 0x004C516A
		// (set) Token: 0x06022AEA RID: 142058 RVA: 0x004C6F72 File Offset: 0x004C5172
		public List<IDynamicSpawnMonsterConfigT> BatchConfigs { get; set; }

		// Token: 0x17009C3F RID: 39999
		// (get) Token: 0x06022AEB RID: 142059 RVA: 0x004C6F7B File Offset: 0x004C517B
		// (set) Token: 0x06022AEC RID: 142060 RVA: 0x004C6F83 File Offset: 0x004C5183
		public byte NullMask { get; set; }

		// Token: 0x06022AED RID: 142061 RVA: 0x004C6F8C File Offset: 0x004C518C
		public IConditionSpawnMonsterT()
		{
			this.Condition = null;
			this.EndCondition = null;
			this.Loop = false;
			this.BatchConfigs = null;
			this.NullMask = 0;
		}
	}
}
