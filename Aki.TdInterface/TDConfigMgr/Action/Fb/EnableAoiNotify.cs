using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C09 RID: 11273
	public class EnableAoiNotify : ActionParams
	{
		// Token: 0x0600F83A RID: 63546 RVA: 0x002418DB File Offset: 0x0023FADB
		public static EnableAoiNotify Create(IEnableAoiNotify? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableAoiNotify
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x0600F83B RID: 63547 RVA: 0x002418FA File Offset: 0x0023FAFA
		public virtual EAoiNotifyState State
		{
			get
			{
				return (EAoiNotifyState)this.Instance.State;
			}
		}

		// Token: 0x040087D5 RID: 34773
		private IEnableAoiNotify Instance;
	}
}
