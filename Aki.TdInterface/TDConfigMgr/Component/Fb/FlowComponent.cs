using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1F RID: 2847
	public class FlowComponent : IComponentBase
	{
		// Token: 0x0600410F RID: 16655 RVA: 0x000A6027 File Offset: 0x000A4227
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x000A6048 File Offset: 0x000A4248
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

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x000A6080 File Offset: 0x000A4280
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x000A6096 File Offset: 0x000A4296
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

		// Token: 0x0400240C RID: 9228
		private IFlowComponent Instance;

		// Token: 0x0400240D RID: 9229
		[Nullable(2)]
		private PlayFlow _InitStateCache;

		// Token: 0x0400240E RID: 9230
		private bool _InitStateInited;
	}
}
