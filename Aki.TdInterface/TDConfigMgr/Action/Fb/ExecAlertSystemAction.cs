using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FD RID: 10749
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecAlertSystemAction : ActionParams
	{
		// Token: 0x0600ED3F RID: 60735 RVA: 0x002299D7 File Offset: 0x00227BD7
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

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x0600ED40 RID: 60736 RVA: 0x002299F6 File Offset: 0x00227BF6
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

		// Token: 0x0400829B RID: 33435
		private IExecAlertSystemAction Instance;

		// Token: 0x0400829C RID: 33436
		private IAlertSystemOption _OptionCache;

		// Token: 0x0400829D RID: 33437
		private bool _OptionInited;
	}
}
