using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D41 RID: 11585
	public class ReignsAddBuff : ActionParams
	{
		// Token: 0x0600FD07 RID: 64775 RVA: 0x00248EF7 File Offset: 0x002470F7
		public static ReignsAddBuff Create(IReignsAddBuff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsAddBuff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x0600FD08 RID: 64776 RVA: 0x00248F16 File Offset: 0x00247116
		public virtual int BuffId
		{
			get
			{
				return this.Instance.BuffId;
			}
		}

		// Token: 0x04008A23 RID: 35363
		private IReignsAddBuff Instance;
	}
}
