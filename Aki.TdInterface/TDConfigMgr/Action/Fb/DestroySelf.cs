using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002938 RID: 10552
	public class DestroySelf : ActionParams
	{
		// Token: 0x0600EA7F RID: 60031 RVA: 0x00229A1E File Offset: 0x00227C1E
		public static DestroySelf Create(IDestroySelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroySelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x0600EA80 RID: 60032 RVA: 0x00229A40 File Offset: 0x00227C40
		public virtual bool? DelayDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayDestroy);
			}
		}

		// Token: 0x04008140 RID: 33088
		private IDestroySelf Instance;
	}
}
