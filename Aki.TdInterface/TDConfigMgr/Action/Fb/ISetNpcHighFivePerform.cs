using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5E RID: 10846
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetNpcHighFivePerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600EE90 RID: 61072 RVA: 0x0022B7BB File Offset: 0x002299BB
		public static ISetNpcHighFivePerform Create(ISetNpcHighFivePerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHighFivePerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B96 RID: 19350
		// (get) Token: 0x0600EE91 RID: 61073 RVA: 0x0022B7DA File Offset: 0x002299DA
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x0600EE92 RID: 61074 RVA: 0x0022B7E7 File Offset: 0x002299E7
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

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x0022B81B File Offset: 0x00229A1B
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x0600EE94 RID: 61076 RVA: 0x0022B828 File Offset: 0x00229A28
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				return (ENpcGroupPerformNpcType)this.Instance.NpcType;
			}
		}

		// Token: 0x0400833E RID: 33598
		private ISetNpcHighFivePerform Instance;

		// Token: 0x0400833F RID: 33599
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008340 RID: 33600
		private bool _InitiatorInited;
	}
}
