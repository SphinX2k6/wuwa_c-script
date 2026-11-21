using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D7A RID: 11642
	public class FlowDefineNpcGroupPerform : ActionParams
	{
		// Token: 0x0600FDF5 RID: 65013 RVA: 0x0024A752 File Offset: 0x00248952
		public static FlowDefineNpcGroupPerform Create(IFlowDefineNpcGroupPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FlowDefineNpcGroupPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x0600FDF6 RID: 65014 RVA: 0x0024A771 File Offset: 0x00248971
		public virtual IFlowDefineNpcGroupPerformType PerformType
		{
			get
			{
				if (this._PerformTypeInited)
				{
					return this._PerformTypeCache;
				}
				this._PerformTypeInited = true;
				this._PerformTypeCache = ActionReadHelper.ReadFlowDefineNpcGroupPerform_PerformType(this.Instance);
				return this._PerformTypeCache;
			}
		}

		// Token: 0x04008AA6 RID: 35494
		private IFlowDefineNpcGroupPerform Instance;

		// Token: 0x04008AA7 RID: 35495
		private IFlowDefineNpcGroupPerformType _PerformTypeCache;

		// Token: 0x04008AA8 RID: 35496
		private bool _PerformTypeInited;
	}
}
