using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F4F RID: 3919
	public class ICircuitConnectLayoutBase
	{
		// Token: 0x060057EA RID: 22506 RVA: 0x000D71C9 File Offset: 0x000D53C9
		public static ICircuitConnectLayoutBase Create(ICircuitConnectLayoutBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectLayoutBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x060057EB RID: 22507 RVA: 0x000D71E8 File Offset: 0x000D53E8
		public virtual ECircuitConnectElementType Type
		{
			get
			{
				return (ECircuitConnectElementType)this.Instance.Type;
			}
		}

		// Token: 0x0400327A RID: 12922
		private ICircuitConnectLayoutBase Instance;
	}
}
