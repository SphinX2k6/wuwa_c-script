using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A74 RID: 10868
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAtConfig
	{
		// Token: 0x0600EEF2 RID: 61170 RVA: 0x0022C1DE File Offset: 0x0022A3DE
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

		// Token: 0x17004BCC RID: 19404
		// (get) Token: 0x0600EEF3 RID: 61171 RVA: 0x0022C1FD File Offset: 0x0022A3FD
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

		// Token: 0x17004BCD RID: 19405
		// (get) Token: 0x0600EEF4 RID: 61172 RVA: 0x0022C231 File Offset: 0x0022A431
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

		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x0600EEF5 RID: 61173 RVA: 0x0022C260 File Offset: 0x0022A460
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

		// Token: 0x04008370 RID: 33648
		private ICheckFlowLookAtConfig Instance;

		// Token: 0x04008371 RID: 33649
		[Nullable(2)]
		private PlayFlow _FlowCache;

		// Token: 0x04008372 RID: 33650
		private bool _FlowInited;

		// Token: 0x04008373 RID: 33651
		private ICheckFlowLookAtTarget _TargetCache;

		// Token: 0x04008374 RID: 33652
		private bool _TargetInited;

		// Token: 0x04008375 RID: 33653
		[Nullable(2)]
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x04008376 RID: 33654
		private bool _EntityLookAtPerformInited;
	}
}
