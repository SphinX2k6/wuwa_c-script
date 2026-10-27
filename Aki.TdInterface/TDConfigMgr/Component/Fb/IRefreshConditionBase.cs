using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AA9 RID: 2729
	public class IRefreshConditionBase
	{
		// Token: 0x06003EF8 RID: 16120 RVA: 0x000A120E File Offset: 0x0009F40E
		[NullableContext(1)]
		public static IRefreshConditionBase Create(IRefreshConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x000A122D File Offset: 0x0009F42D
		public virtual ERewardDropType Type
		{
			get
			{
				return (ERewardDropType)this.Instance.Type;
			}
		}

		// Token: 0x040022FA RID: 8954
		private IRefreshConditionBase Instance;
	}
}
