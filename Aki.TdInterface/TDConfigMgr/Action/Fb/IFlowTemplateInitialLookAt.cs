using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A59 RID: 10841
	public class IFlowTemplateInitialLookAt
	{
		// Token: 0x0600EF65 RID: 61285 RVA: 0x00231681 File Offset: 0x0022F881
		public static IFlowTemplateInitialLookAt Create(IFlowTemplateInitialLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x0600EF66 RID: 61286 RVA: 0x002316A0 File Offset: 0x0022F8A0
		public virtual int ActorIndex
		{
			get
			{
				return this.Instance.ActorIndex;
			}
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x0600EF67 RID: 61287 RVA: 0x002316AD File Offset: 0x0022F8AD
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadIFlowTemplateInitialLookAt_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008387 RID: 33671
		private IFlowTemplateInitialLookAt Instance;

		// Token: 0x04008388 RID: 33672
		private IActorLookAtData _TargetCache;

		// Token: 0x04008389 RID: 33673
		private bool _TargetInited;
	}
}
