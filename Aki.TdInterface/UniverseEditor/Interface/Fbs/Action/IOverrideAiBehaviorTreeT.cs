using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C55 RID: 27733
	public class IOverrideAiBehaviorTreeT
	{
		// Token: 0x1700CE8F RID: 52879
		// (get) Token: 0x06030DDB RID: 200155 RVA: 0x006A3474 File Offset: 0x006A1674
		// (set) Token: 0x06030DDC RID: 200156 RVA: 0x006A347C File Offset: 0x006A167C
		public string Key { get; set; }

		// Token: 0x1700CE90 RID: 52880
		// (get) Token: 0x06030DDD RID: 200157 RVA: 0x006A3485 File Offset: 0x006A1685
		// (set) Token: 0x06030DDE RID: 200158 RVA: 0x006A348D File Offset: 0x006A168D
		public List<int> EntityIds { get; set; }

		// Token: 0x1700CE91 RID: 52881
		// (get) Token: 0x06030DDF RID: 200159 RVA: 0x006A3496 File Offset: 0x006A1696
		// (set) Token: 0x06030DE0 RID: 200160 RVA: 0x006A349E File Offset: 0x006A169E
		public int BehaviorTree { get; set; }

		// Token: 0x1700CE92 RID: 52882
		// (get) Token: 0x06030DE1 RID: 200161 RVA: 0x006A34A7 File Offset: 0x006A16A7
		// (set) Token: 0x06030DE2 RID: 200162 RVA: 0x006A34AF File Offset: 0x006A16AF
		public ICommonBtOverrideT CommonBtOverride { get; set; }

		// Token: 0x1700CE93 RID: 52883
		// (get) Token: 0x06030DE3 RID: 200163 RVA: 0x006A34B8 File Offset: 0x006A16B8
		// (set) Token: 0x06030DE4 RID: 200164 RVA: 0x006A34C0 File Offset: 0x006A16C0
		public IConditionGroupT RemoveCondition { get; set; }

		// Token: 0x06030DE5 RID: 200165 RVA: 0x006A34C9 File Offset: 0x006A16C9
		public IOverrideAiBehaviorTreeT()
		{
			this.Key = null;
			this.EntityIds = null;
			this.BehaviorTree = 0;
			this.CommonBtOverride = null;
			this.RemoveCondition = null;
		}
	}
}
