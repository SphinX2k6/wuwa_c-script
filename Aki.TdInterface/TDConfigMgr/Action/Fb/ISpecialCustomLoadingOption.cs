using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002958 RID: 10584
	public class ISpecialCustomLoadingOption
	{
		// Token: 0x0600EAF4 RID: 60148 RVA: 0x0022A438 File Offset: 0x00228638
		public static ISpecialCustomLoadingOption Create(ISpecialCustomLoadingOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialCustomLoadingOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044F2 RID: 17650
		// (get) Token: 0x0600EAF5 RID: 60149 RVA: 0x0022A457 File Offset: 0x00228657
		public virtual ESpecialCustomLoadingType Type
		{
			get
			{
				return (ESpecialCustomLoadingType)this.Instance.Type;
			}
		}

		// Token: 0x0400816C RID: 33132
		private ISpecialCustomLoadingOption Instance;
	}
}
