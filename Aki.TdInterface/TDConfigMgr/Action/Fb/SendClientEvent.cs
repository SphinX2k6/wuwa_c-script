using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D36 RID: 11574
	public class SendClientEvent : ActionParams
	{
		// Token: 0x0600FCE0 RID: 64736 RVA: 0x00248C24 File Offset: 0x00246E24
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

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x0600FCE1 RID: 64737 RVA: 0x00248C43 File Offset: 0x00246E43
		public virtual string EventName
		{
			get
			{
				return this.Instance.EventName;
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x0600FCE2 RID: 64738 RVA: 0x00248C50 File Offset: 0x00246E50
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

		// Token: 0x04008A14 RID: 35348
		private ISendClientEvent Instance;

		// Token: 0x04008A15 RID: 35349
		private IClientEventTarget _TargetCache;

		// Token: 0x04008A16 RID: 35350
		private bool _TargetInited;
	}
}
