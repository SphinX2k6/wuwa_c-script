using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CEA RID: 11498
	public class ExecAlertSystemAction : ActionParams
	{
		// Token: 0x0600FBD6 RID: 64470 RVA: 0x0024735B File Offset: 0x0024555B
		public static ExecAlertSystemAction Create(IExecAlertSystemAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecAlertSystemAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EB0 RID: 20144
		// (get) Token: 0x0600FBD7 RID: 64471 RVA: 0x0024737A File Offset: 0x0024557A
		public virtual IAlertSystemOption Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ActionReadHelper.ReadExecAlertSystemAction_Option(this.Instance);
				return this._OptionCache;
			}
		}

		// Token: 0x0400898C RID: 35212
		private IExecAlertSystemAction Instance;

		// Token: 0x0400898D RID: 35213
		private IAlertSystemOption _OptionCache;

		// Token: 0x0400898E RID: 35214
		private bool _OptionInited;
	}
}
