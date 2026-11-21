using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA3 RID: 10915
	public class ILimitPlayerBlockAll : ILimitPlayerOption
	{
		// Token: 0x0600F0B7 RID: 61623 RVA: 0x002341FA File Offset: 0x002323FA
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

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x0600F0B8 RID: 61624 RVA: 0x00234219 File Offset: 0x00232419
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008459 RID: 33881
		private ILimitPlayerBlockAll Instance;
	}
}
