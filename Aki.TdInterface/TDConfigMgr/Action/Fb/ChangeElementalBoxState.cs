using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E02 RID: 11778
	public class ChangeElementalBoxState : ActionParams
	{
		// Token: 0x06010005 RID: 65541 RVA: 0x0024DB43 File Offset: 0x0024BD43
		public static ChangeElementalBoxState Create(IChangeElementalBoxState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeElementalBoxState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x06010006 RID: 65542 RVA: 0x0024DB62 File Offset: 0x0024BD62
		public virtual IChangeElementalBoxStateTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadChangeElementalBoxState_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x170050B0 RID: 20656
		// (get) Token: 0x06010007 RID: 65543 RVA: 0x0024DB91 File Offset: 0x0024BD91
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04008BB8 RID: 35768
		private IChangeElementalBoxState Instance;

		// Token: 0x04008BB9 RID: 35769
		private IChangeElementalBoxStateTarget _TargetCache;

		// Token: 0x04008BBA RID: 35770
		private bool _TargetInited;
	}
}
