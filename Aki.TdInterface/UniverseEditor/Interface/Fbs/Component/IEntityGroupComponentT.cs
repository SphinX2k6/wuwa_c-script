using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200517B RID: 20859
	public class IEntityGroupComponentT
	{
		// Token: 0x17009866 RID: 39014
		// (get) Token: 0x06021B9F RID: 138143 RVA: 0x004AE323 File Offset: 0x004AC523
		// (set) Token: 0x06021BA0 RID: 138144 RVA: 0x004AE32B File Offset: 0x004AC52B
		public bool Disabled { get; set; }

		// Token: 0x17009867 RID: 39015
		// (get) Token: 0x06021BA1 RID: 138145 RVA: 0x004AE334 File Offset: 0x004AC534
		// (set) Token: 0x06021BA2 RID: 138146 RVA: 0x004AE33C File Offset: 0x004AC53C
		public List<int> EntityIds { get; set; }

		// Token: 0x17009868 RID: 39016
		// (get) Token: 0x06021BA3 RID: 138147 RVA: 0x004AE345 File Offset: 0x004AC545
		// (set) Token: 0x06021BA4 RID: 138148 RVA: 0x004AE34D File Offset: 0x004AC54D
		public List<IEntityStateTriggerT> StateTriggers { get; set; }

		// Token: 0x17009869 RID: 39017
		// (get) Token: 0x06021BA5 RID: 138149 RVA: 0x004AE356 File Offset: 0x004AC556
		// (set) Token: 0x06021BA6 RID: 138150 RVA: 0x004AE35E File Offset: 0x004AC55E
		public IFinishStateTriggerT FinishState { get; set; }

		// Token: 0x1700986A RID: 39018
		// (get) Token: 0x06021BA7 RID: 138151 RVA: 0x004AE367 File Offset: 0x004AC567
		// (set) Token: 0x06021BA8 RID: 138152 RVA: 0x004AE36F File Offset: 0x004AC56F
		public IFailureStateTriggerT FailureState { get; set; }

		// Token: 0x1700986B RID: 39019
		// (get) Token: 0x06021BA9 RID: 138153 RVA: 0x004AE378 File Offset: 0x004AC578
		// (set) Token: 0x06021BAA RID: 138154 RVA: 0x004AE380 File Offset: 0x004AC580
		public byte NullMask { get; set; }

		// Token: 0x06021BAB RID: 138155 RVA: 0x004AE389 File Offset: 0x004AC589
		public IEntityGroupComponentT()
		{
			this.Disabled = false;
			this.EntityIds = null;
			this.StateTriggers = null;
			this.FinishState = null;
			this.FailureState = null;
			this.NullMask = 0;
		}
	}
}
