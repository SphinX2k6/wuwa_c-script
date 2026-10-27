using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C48 RID: 3144
	public class IPatrolCycleLooply : ICycleModeType
	{
		// Token: 0x060047FE RID: 18430 RVA: 0x000B51C3 File Offset: 0x000B33C3
		[NullableContext(1)]
		public static IPatrolCycleLooply Create(IPatrolCycleLooply? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleLooply
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x000B51E2 File Offset: 0x000B33E2
		public override EPatrolCycleMode Type
		{
			get
			{
				return (EPatrolCycleMode)this.Instance.Type;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06004800 RID: 18432 RVA: 0x000B51EF File Offset: 0x000B33EF
		public virtual bool IsCircle
		{
			get
			{
				return this.Instance.IsCircle;
			}
		}

		// Token: 0x040028FB RID: 10491
		private IPatrolCycleLooply Instance;
	}
}
