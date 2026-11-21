using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C85 RID: 11397
	public class ExecResurrection : ActionParams
	{
		// Token: 0x0600FA45 RID: 64069 RVA: 0x00244F4C File Offset: 0x0024314C
		public static ExecResurrection Create(IExecResurrection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecResurrection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x0600FA46 RID: 64070 RVA: 0x00244F6B File Offset: 0x0024316B
		public virtual int ReviveId
		{
			get
			{
				return this.Instance.ReviveId;
			}
		}

		// Token: 0x040088B9 RID: 35001
		private IExecResurrection Instance;
	}
}
