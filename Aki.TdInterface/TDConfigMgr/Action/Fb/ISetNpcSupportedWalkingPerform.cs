using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A61 RID: 10849
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcSupportedWalkingPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600EEA4 RID: 61092 RVA: 0x0022B986 File Offset: 0x00229B86
		public static ISetNpcSupportedWalkingPerform Create(ISetNpcSupportedWalkingPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcSupportedWalkingPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x0600EEA5 RID: 61093 RVA: 0x0022B9A5 File Offset: 0x00229BA5
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x0600EEA6 RID: 61094 RVA: 0x0022B9B2 File Offset: 0x00229BB2
		public virtual IPlayerInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = IPlayerInitiator.Create(this.Instance.Initiator);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x0600EEA7 RID: 61095 RVA: 0x0022B9E6 File Offset: 0x00229BE6
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x04008347 RID: 33607
		private ISetNpcSupportedWalkingPerform Instance;

		// Token: 0x04008348 RID: 33608
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008349 RID: 33609
		private bool _InitiatorInited;
	}
}
