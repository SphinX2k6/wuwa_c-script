using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024CC RID: 9420
	[NullableContext(1)]
	[Nullable(0)]
	public class ICsvActionContext : IActionContextType
	{
		// Token: 0x0600D26F RID: 53871 RVA: 0x001F3976 File Offset: 0x001F1B76
		public static ICsvActionContext Create(ICsvActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICsvActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0600D270 RID: 53872 RVA: 0x001F3995 File Offset: 0x001F1B95
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x04007374 RID: 29556
		private ICsvActionContext Instance;
	}
}
