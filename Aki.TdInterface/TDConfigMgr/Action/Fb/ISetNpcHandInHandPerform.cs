using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5B RID: 10843
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcHandInHandPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600EE85 RID: 61061 RVA: 0x0022B6DE File Offset: 0x002298DE
		public static ISetNpcHandInHandPerform Create(ISetNpcHandInHandPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHandInHandPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B91 RID: 19345
		// (get) Token: 0x0600EE86 RID: 61062 RVA: 0x0022B6FD File Offset: 0x002298FD
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004B92 RID: 19346
		// (get) Token: 0x0600EE87 RID: 61063 RVA: 0x0022B70A File Offset: 0x0022990A
		public virtual IHandInHandInitiator Initiator
		{
			get
			{
				if (this._InitiatorInited)
				{
					return this._InitiatorCache;
				}
				this._InitiatorInited = true;
				this._InitiatorCache = IHandInHandInitiator.Create(this.Instance.Initiator);
				return this._InitiatorCache;
			}
		}

		// Token: 0x17004B93 RID: 19347
		// (get) Token: 0x0600EE88 RID: 61064 RVA: 0x0022B73E File Offset: 0x0022993E
		public virtual int Follower
		{
			get
			{
				return this.Instance.Follower;
			}
		}

		// Token: 0x04008339 RID: 33593
		private ISetNpcHandInHandPerform Instance;

		// Token: 0x0400833A RID: 33594
		[Nullable(2)]
		private IHandInHandInitiator _InitiatorCache;

		// Token: 0x0400833B RID: 33595
		private bool _InitiatorInited;
	}
}
