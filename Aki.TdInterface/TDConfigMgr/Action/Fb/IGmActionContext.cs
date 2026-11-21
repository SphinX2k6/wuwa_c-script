using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276F RID: 10095
	public class IGmActionContext : IActionContextType
	{
		// Token: 0x0600DFBE RID: 57278 RVA: 0x0020F16A File Offset: 0x0020D36A
		public static IGmActionContext Create(IGmActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGmActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600DFBF RID: 57279 RVA: 0x0020F189 File Offset: 0x0020D389
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x040079BF RID: 31167
		private IGmActionContext Instance;
	}
}
