using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002962 RID: 10594
	public class ICustomScreenLoadingCyberpunk : ICustomScreenLoadingTypeBase
	{
		// Token: 0x0600EB1C RID: 60188 RVA: 0x0022A7D0 File Offset: 0x002289D0
		public static ICustomScreenLoadingCyberpunk Create(ICustomScreenLoadingCyberpunk? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingCyberpunk
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004506 RID: 17670
		// (get) Token: 0x0600EB1D RID: 60189 RVA: 0x0022A7EF File Offset: 0x002289EF
		public override ECustomScreenLoading Type
		{
			get
			{
				return (ECustomScreenLoading)this.Instance.Type;
			}
		}

		// Token: 0x04008180 RID: 33152
		private ICustomScreenLoadingCyberpunk Instance;
	}
}
