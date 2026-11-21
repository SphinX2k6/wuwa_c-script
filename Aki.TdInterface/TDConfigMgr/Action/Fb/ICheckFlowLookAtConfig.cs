using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D68 RID: 11624
	public class ICheckFlowLookAtConfig
	{
		// Token: 0x0600FDA8 RID: 64936 RVA: 0x00249EEA File Offset: 0x002480EA
		public static ICheckFlowLookAtConfig Create(ICheckFlowLookAtConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x0600FDA9 RID: 64937 RVA: 0x00249F09 File Offset: 0x00248109
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				this._FlowCache = PlayFlow.Create(this.Instance.Flow);
				return this._FlowCache;
			}
		}

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x0600FDAA RID: 64938 RVA: 0x00249F3D File Offset: 0x0024813D
		public virtual ICheckFlowLookAtTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadICheckFlowLookAtConfig_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x0600FDAB RID: 64939 RVA: 0x00249F6C File Offset: 0x0024816C
		[Nullable(2)]
		public virtual IEntityLookAtPerform EntityLookAtPerform
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityLookAtPerformInited)
				{
					return this._EntityLookAtPerformCache;
				}
				this._EntityLookAtPerformInited = true;
				this._EntityLookAtPerformCache = IEntityLookAtPerform.Create(this.Instance.EntityLookAtPerform);
				return this._EntityLookAtPerformCache;
			}
		}

		// Token: 0x04008A74 RID: 35444
		private ICheckFlowLookAtConfig Instance;

		// Token: 0x04008A75 RID: 35445
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008A76 RID: 35446
		private bool _FlowInited;

		// Token: 0x04008A77 RID: 35447
		private ICheckFlowLookAtTarget _TargetCache;

		// Token: 0x04008A78 RID: 35448
		private bool _TargetInited;

		// Token: 0x04008A79 RID: 35449
		[Nullable(2)]
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x04008A7A RID: 35450
		private bool _EntityLookAtPerformInited;
	}
}
