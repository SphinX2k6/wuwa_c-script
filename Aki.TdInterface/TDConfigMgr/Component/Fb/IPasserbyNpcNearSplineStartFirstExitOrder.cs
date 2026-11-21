using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC8 RID: 3528
	public class IPasserbyNpcNearSplineStartFirstExitOrder : IPasserbyNpcExitOrderBase
	{
		// Token: 0x06005015 RID: 20501 RVA: 0x000C6F66 File Offset: 0x000C5166
		public static IPasserbyNpcNearSplineStartFirstExitOrder Create(IPasserbyNpcNearSplineStartFirstExitOrder? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcNearSplineStartFirstExitOrder
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x000C6F85 File Offset: 0x000C5185
		public override EPasserbyNpcExitOrderType Type
		{
			get
			{
				return (EPasserbyNpcExitOrderType)this.Instance.Type;
			}
		}

		// Token: 0x04002D9F RID: 11679
		private IPasserbyNpcNearSplineStartFirstExitOrder Instance;
	}
}
