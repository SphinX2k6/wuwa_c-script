using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D4C RID: 11596
	public class ISetNpcHuggingBearPerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600FD2E RID: 64814 RVA: 0x002491F1 File Offset: 0x002473F1
		public static ISetNpcHuggingBearPerform Create(ISetNpcHuggingBearPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcHuggingBearPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x0600FD2F RID: 64815 RVA: 0x00249210 File Offset: 0x00247410
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x0600FD30 RID: 64816 RVA: 0x0024921D File Offset: 0x0024741D
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

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x0600FD31 RID: 64817 RVA: 0x00249251 File Offset: 0x00247451
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x0600FD32 RID: 64818 RVA: 0x0024925E File Offset: 0x0024745E
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				return (ENpcGroupPerformNpcType)this.Instance.NpcType;
			}
		}

		// Token: 0x04008A34 RID: 35380
		private ISetNpcHuggingBearPerform Instance;

		// Token: 0x04008A35 RID: 35381
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008A36 RID: 35382
		private bool _InitiatorInited;
	}
}
