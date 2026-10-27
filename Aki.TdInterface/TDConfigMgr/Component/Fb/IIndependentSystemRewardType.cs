using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB1 RID: 2737
	public class IIndependentSystemRewardType
	{
		// Token: 0x06003F1D RID: 16157 RVA: 0x000A16EE File Offset: 0x0009F8EE
		[NullableContext(1)]
		public static IIndependentSystemRewardType Create(IIndependentSystemRewardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IIndependentSystemRewardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003F1E RID: 16158 RVA: 0x000A170D File Offset: 0x0009F90D
		public virtual EIndependentSystemRewardType Type
		{
			get
			{
				return (EIndependentSystemRewardType)this.Instance.Type;
			}
		}

		// Token: 0x04002310 RID: 8976
		private IIndependentSystemRewardType Instance;
	}
}
