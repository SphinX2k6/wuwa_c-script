using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024C8 RID: 9416
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtActionContext : IActionContextType
	{
		// Token: 0x0600D262 RID: 53858 RVA: 0x001F386E File Offset: 0x001F1A6E
		public static ICommonBtActionContext Create(ICommonBtActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600D263 RID: 53859 RVA: 0x001F388D File Offset: 0x001F1A8D
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x04007370 RID: 29552
		private ICommonBtActionContext Instance;
	}
}
