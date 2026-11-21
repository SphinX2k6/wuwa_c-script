using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BC RID: 29628
	public class IOverrideAiBehaviorTreeT
	{
		// Token: 0x1700D9AA RID: 55722
		// (get) Token: 0x06033D36 RID: 212278 RVA: 0x006FD974 File Offset: 0x006FBB74
		// (set) Token: 0x06033D37 RID: 212279 RVA: 0x006FD97C File Offset: 0x006FBB7C
		public string Key { get; set; }

		// Token: 0x1700D9AB RID: 55723
		// (get) Token: 0x06033D38 RID: 212280 RVA: 0x006FD985 File Offset: 0x006FBB85
		// (set) Token: 0x06033D39 RID: 212281 RVA: 0x006FD98D File Offset: 0x006FBB8D
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D9AC RID: 55724
		// (get) Token: 0x06033D3A RID: 212282 RVA: 0x006FD996 File Offset: 0x006FBB96
		// (set) Token: 0x06033D3B RID: 212283 RVA: 0x006FD99E File Offset: 0x006FBB9E
		public int BehaviorTree { get; set; }

		// Token: 0x1700D9AD RID: 55725
		// (get) Token: 0x06033D3C RID: 212284 RVA: 0x006FD9A7 File Offset: 0x006FBBA7
		// (set) Token: 0x06033D3D RID: 212285 RVA: 0x006FD9AF File Offset: 0x006FBBAF
		public ICommonBtOverrideT CommonBtOverride { get; set; }

		// Token: 0x1700D9AE RID: 55726
		// (get) Token: 0x06033D3E RID: 212286 RVA: 0x006FD9B8 File Offset: 0x006FBBB8
		// (set) Token: 0x06033D3F RID: 212287 RVA: 0x006FD9C0 File Offset: 0x006FBBC0
		public IConditionGroupT RemoveCondition { get; set; }

		// Token: 0x06033D40 RID: 212288 RVA: 0x006FD9C9 File Offset: 0x006FBBC9
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
