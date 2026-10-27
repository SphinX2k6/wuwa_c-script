using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C47 RID: 3143
	public class ICycleModeType
	{
		// Token: 0x060047FB RID: 18427 RVA: 0x000B518F File Offset: 0x000B338F
		[NullableContext(1)]
		public static ICycleModeType Create(ICycleModeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICycleModeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x000B51AE File Offset: 0x000B33AE
		public virtual EPatrolCycleMode Type
		{
			get
			{
				return (EPatrolCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x040028FA RID: 10490
		private ICycleModeType Instance;
	}
}
