using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024CA RID: 9418
	[NullableContext(1)]
	[Nullable(0)]
	public class IGmActionContext : IActionContextType
	{
		// Token: 0x0600D269 RID: 53865 RVA: 0x001F390E File Offset: 0x001F1B0E
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

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x0600D26A RID: 53866 RVA: 0x001F392D File Offset: 0x001F1B2D
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x04007372 RID: 29554
		private IGmActionContext Instance;
	}
}
