using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BC5 RID: 11205
	public class ISportConfig
	{
		// Token: 0x0600F703 RID: 63235 RVA: 0x0023F94D File Offset: 0x0023DB4D
		public static ISportConfig Create(ISportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x0600F704 RID: 63236 RVA: 0x0023F96C File Offset: 0x0023DB6C
		public virtual ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x04008743 RID: 34627
		private ISportConfig Instance;
	}
}
