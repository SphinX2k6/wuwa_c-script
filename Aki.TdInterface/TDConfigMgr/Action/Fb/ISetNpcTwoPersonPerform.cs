using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D4D RID: 11597
	public class ISetNpcTwoPersonPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600FD34 RID: 64820 RVA: 0x00249273 File Offset: 0x00247473
		public static ISetNpcTwoPersonPerform Create(ISetNpcTwoPersonPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcTwoPersonPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x0600FD35 RID: 64821 RVA: 0x00249292 File Offset: 0x00247492
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x0600FD36 RID: 64822 RVA: 0x0024929F File Offset: 0x0024749F
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

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x0600FD37 RID: 64823 RVA: 0x002492D3 File Offset: 0x002474D3
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x0600FD38 RID: 64824 RVA: 0x002492E0 File Offset: 0x002474E0
		public virtual string GroupPerformMark
		{
			get
			{
				return this.Instance.GroupPerformMark;
			}
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x0600FD39 RID: 64825 RVA: 0x002492ED File Offset: 0x002474ED
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				return (ENpcGroupPerformNpcType)this.Instance.NpcType;
			}
		}

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x0600FD3A RID: 64826 RVA: 0x002492FC File Offset: 0x002474FC
		public virtual EWaitInteractNpcMontageWaitType? WaitInteractNpcType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EWaitInteractNpcMontageWaitType?((EWaitInteractNpcMontageWaitType)this.Instance.WaitInteractNpcType);
			}
		}

		// Token: 0x04008A37 RID: 35383
		private ISetNpcTwoPersonPerform Instance;

		// Token: 0x04008A38 RID: 35384
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008A39 RID: 35385
		private bool _InitiatorInited;
	}
}
