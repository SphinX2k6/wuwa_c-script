using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A56 RID: 2646
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowComponent : IComponentBase
	{
		// Token: 0x06003CEF RID: 15599 RVA: 0x0009CBAF File Offset: 0x0009ADAF
		public static FlowComponent Create(IFlowComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FlowComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x0009CBD0 File Offset: 0x0009ADD0
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

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x0009CC08 File Offset: 0x0009AE08
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x0009CC1E File Offset: 0x0009AE1E
		public virtual PlayFlow InitState
		{
			get
			{
				if (this._InitStateInited)
				{
					return this._InitStateCache;
				}
				this._InitStateInited = true;
				this._InitStateCache = PlayFlow.Create(this.Instance.InitState);
				return this._InitStateCache;
			}
		}

		// Token: 0x040021F5 RID: 8693
		private IFlowComponent Instance;

		// Token: 0x040021F6 RID: 8694
		[Nullable(2)]
		private PlayFlow _InitStateCache;

		// Token: 0x040021F7 RID: 8695
		private bool _InitStateInited;
	}
}
