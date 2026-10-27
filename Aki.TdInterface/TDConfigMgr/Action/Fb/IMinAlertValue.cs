using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F5 RID: 10741
	public class IMinAlertValue : ISetAlertValueType
	{
		// Token: 0x0600ED1E RID: 60702 RVA: 0x0022977E File Offset: 0x0022797E
		[NullableContext(1)]
		public static IMinAlertValue Create(IMinAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMinAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x0600ED1F RID: 60703 RVA: 0x0022979D File Offset: 0x0022799D
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x0400828F RID: 33423
		private IMinAlertValue Instance;
	}
}
