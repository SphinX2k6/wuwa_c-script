using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002797 RID: 10135
	public class Log : ActionParams
	{
		// Token: 0x0600E08E RID: 57486 RVA: 0x00210C91 File Offset: 0x0020EE91
		public static Log Create(ILog? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Log
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x0600E08F RID: 57487 RVA: 0x00210CB0 File Offset: 0x0020EEB0
		public virtual string Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x0600E090 RID: 57488 RVA: 0x00210CBD File Offset: 0x0020EEBD
		public virtual string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x04007A21 RID: 31265
		private ILog Instance;
	}
}
