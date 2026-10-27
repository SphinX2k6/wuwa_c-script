using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A86 RID: 10886
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowDefineNpcGroupPerform : ActionParams
	{
		// Token: 0x0600EF3F RID: 61247 RVA: 0x0022CA46 File Offset: 0x0022AC46
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

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x0600EF40 RID: 61248 RVA: 0x0022CA65 File Offset: 0x0022AC65
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

		// Token: 0x040083A2 RID: 33698
		private IFlowDefineNpcGroupPerform Instance;

		// Token: 0x040083A3 RID: 33699
		private IFlowDefineNpcGroupPerformType _PerformTypeCache;

		// Token: 0x040083A4 RID: 33700
		private bool _PerformTypeInited;
	}
}
