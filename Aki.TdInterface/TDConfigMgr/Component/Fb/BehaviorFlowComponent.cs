using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A55 RID: 2645
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorFlowComponent : IComponentBase
	{
		// Token: 0x06003CE8 RID: 15592 RVA: 0x0009CAC0 File Offset: 0x0009ACC0
		public static BehaviorFlowComponent Create(IBehaviorFlowComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BehaviorFlowComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x0009CAE0 File Offset: 0x0009ACE0
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x0009CB18 File Offset: 0x0009AD18
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x0009CB30 File Offset: 0x0009AD30
		public virtual bool? _Folded
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance._Folded);
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x0009CB66 File Offset: 0x0009AD66
		public virtual int InitStateId
		{
			get
			{
				return this.Instance.InitStateId;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x0009CB73 File Offset: 0x0009AD73
		public virtual IFlowInfo FlowInfo
		{
			get
			{
				if (this._FlowInfoInited)
				{
					return this._FlowInfoCache;
				}
				this._FlowInfoInited = true;
				this._FlowInfoCache = IFlowInfo.Create(this.Instance.FlowInfo);
				return this._FlowInfoCache;
			}
		}

		// Token: 0x040021F2 RID: 8690
		private IBehaviorFlowComponent Instance;

		// Token: 0x040021F3 RID: 8691
		[Nullable(2)]
		private IFlowInfo _FlowInfoCache;

		// Token: 0x040021F4 RID: 8692
		private bool _FlowInfoInited;
	}
}
