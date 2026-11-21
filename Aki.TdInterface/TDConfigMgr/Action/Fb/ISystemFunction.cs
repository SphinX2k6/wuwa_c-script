using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D38 RID: 11576
	public class ISystemFunction
	{
		// Token: 0x0600FCE8 RID: 64744 RVA: 0x00248CC8 File Offset: 0x00246EC8
		public static ISystemFunction Create(ISystemFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x0600FCE9 RID: 64745 RVA: 0x00248CE7 File Offset: 0x00246EE7
		public virtual ESystemFunction Type
		{
			get
			{
				return (ESystemFunction)this.Instance.Type;
			}
		}

		// Token: 0x04008A18 RID: 35352
		private ISystemFunction Instance;
	}
}
