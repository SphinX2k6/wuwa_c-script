using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D0 RID: 10192
	public class ILimitPlayerBlockAll : ILimitPlayerOption
	{
		// Token: 0x0600E295 RID: 58005 RVA: 0x00217426 File Offset: 0x00215626
		[NullableContext(1)]
		public static ILimitPlayerBlockAll Create(ILimitPlayerBlockAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerBlockAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x0600E296 RID: 58006 RVA: 0x00217445 File Offset: 0x00215645
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04007DA2 RID: 32162
		private ILimitPlayerBlockAll Instance;
	}
}
