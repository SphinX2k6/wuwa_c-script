using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE5 RID: 3045
	public class ILifeStageConfig
	{
		// Token: 0x060045F0 RID: 17904 RVA: 0x000B0CFF File Offset: 0x000AEEFF
		[NullableContext(1)]
		public static ILifeStageConfig Create(ILifeStageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILifeStageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x000B0D20 File Offset: 0x000AEF20
		public virtual float? PerformDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.PerformDuration);
			}
		}

		// Token: 0x040027D0 RID: 10192
		private ILifeStageConfig Instance;
	}
}
