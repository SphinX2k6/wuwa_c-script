using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D4B RID: 11595
	public class ISetNpcHighFivePerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600FD28 RID: 64808 RVA: 0x0024916F File Offset: 0x0024736F
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

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x0600FD29 RID: 64809 RVA: 0x0024918E File Offset: 0x0024738E
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x0600FD2A RID: 64810 RVA: 0x0024919B File Offset: 0x0024739B
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

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x0600FD2B RID: 64811 RVA: 0x002491CF File Offset: 0x002473CF
		public virtual int Target
		{
			get
			{
				return this.Instance.Target;
			}
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x0600FD2C RID: 64812 RVA: 0x002491DC File Offset: 0x002473DC
		public virtual ENpcGroupPerformNpcType NpcType
		{
			get
			{
				return (ENpcGroupPerformNpcType)this.Instance.NpcType;
			}
		}

		// Token: 0x04008A31 RID: 35377
		private ISetNpcHighFivePerform Instance;

		// Token: 0x04008A32 RID: 35378
		[Nullable(2)]
		private IPlayerInitiator _InitiatorCache;

		// Token: 0x04008A33 RID: 35379
		private bool _InitiatorInited;
	}
}
