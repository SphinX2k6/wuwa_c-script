using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024C6 RID: 9414
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowActionContext : IActionContextType
	{
		// Token: 0x0600D25B RID: 53851 RVA: 0x001F37CF File Offset: 0x001F19CF
		public static IFlowActionContext Create(IFlowActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x0600D25C RID: 53852 RVA: 0x001F37EE File Offset: 0x001F19EE
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x0400736E RID: 29550
		private IFlowActionContext Instance;
	}
}
