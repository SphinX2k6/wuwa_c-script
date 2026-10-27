using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A49 RID: 10825
	[NullableContext(1)]
	[Nullable(0)]
	public class SendClientEvent : ActionParams
	{
		// Token: 0x0600EE48 RID: 61000 RVA: 0x0022B270 File Offset: 0x00229470
		public static SendClientEvent Create(ISendClientEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendClientEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B78 RID: 19320
		// (get) Token: 0x0600EE49 RID: 61001 RVA: 0x0022B28F File Offset: 0x0022948F
		public virtual string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x0600EE4A RID: 61002 RVA: 0x0022B29C File Offset: 0x0022949C
		public virtual IClientEventTarget Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadSendClientEvent_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x04008321 RID: 33569
		private ISendClientEvent Instance;

		// Token: 0x04008322 RID: 33570
		private IClientEventTarget _TargetCache;

		// Token: 0x04008323 RID: 33571
		private bool _TargetInited;
	}
}
