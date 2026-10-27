using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025BD RID: 9661
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeOtherState : ActionParams
	{
		// Token: 0x0600D94C RID: 55628 RVA: 0x00206ACC File Offset: 0x00204CCC
		public static ChangeOtherState Create(IChangeOtherState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeOtherState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x0600D94D RID: 55629 RVA: 0x00206AEB File Offset: 0x00204CEB
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x0600D94E RID: 55630 RVA: 0x00206AF8 File Offset: 0x00204CF8
		public virtual PlayFlow State
		{
			get
			{
				if (this._StateInited)
				{
					return this._StateCache;
				}
				this._StateInited = true;
				this._StateCache = PlayFlow.Create(this.Instance.State);
				return this._StateCache;
			}
		}

		// Token: 0x040078B3 RID: 30899
		private IChangeOtherState Instance;

		// Token: 0x040078B4 RID: 30900
		[Nullable(2)]
		private PlayFlow _StateCache;

		// Token: 0x040078B5 RID: 30901
		private bool _StateInited;
	}
}
