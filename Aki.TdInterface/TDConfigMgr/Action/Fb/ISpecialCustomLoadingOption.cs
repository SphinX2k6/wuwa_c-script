using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002695 RID: 9877
	public class ISpecialCustomLoadingOption
	{
		// Token: 0x0600DD1D RID: 56605 RVA: 0x0020DC98 File Offset: 0x0020BE98
		[NullableContext(1)]
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

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x0600DD1E RID: 56606 RVA: 0x0020DCB7 File Offset: 0x0020BEB7
		public virtual ESpecialCustomLoadingType Type
		{
			get
			{
				return (ESpecialCustomLoadingType)this.Instance.Type;
			}
		}

		// Token: 0x04007ACF RID: 31439
		private ISpecialCustomLoadingOption Instance;
	}
}
