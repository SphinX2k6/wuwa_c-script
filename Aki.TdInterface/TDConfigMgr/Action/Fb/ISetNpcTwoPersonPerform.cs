using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A60 RID: 10848
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcTwoPersonPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600EE9C RID: 61084 RVA: 0x0022B8BF File Offset: 0x00229ABF
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

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x0600EE9D RID: 61085 RVA: 0x0022B8DE File Offset: 0x00229ADE
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x0600EE9E RID: 61086 RVA: 0x0022B8EB File Offset: 0x00229AEB
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

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x0600EE9F RID: 61087 RVA: 0x0022B91F File Offset: 0x00229B1F
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x0600EEA0 RID: 61088 RVA: 0x0022B92C File Offset: 0x00229B2C
		public virtual string GroupPerformMark
		{
			get
			{
				return this.Instance.GroupPerformMark;
			}
		}

		// Token: 0x17004BA2 RID: 19362
		// (get) Token: 0x0600EEA1 RID: 61089 RVA: 0x0022B939 File Offset: 0x00229B39
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				return (ENpcGroupPerformNpcType)this.Instance.NpcType;
			}
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x0600EEA2 RID: 61090 RVA: 0x0022B948 File Offset: 0x00229B48
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

		// Token: 0x04008344 RID: 33604
		private ISetNpcTwoPersonPerform Instance;

		// Token: 0x04008345 RID: 33605
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008346 RID: 33606
		private bool _InitiatorInited;
	}
}
