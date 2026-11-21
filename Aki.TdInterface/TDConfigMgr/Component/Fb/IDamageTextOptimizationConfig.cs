using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EA0 RID: 3744
	public class IDamageTextOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x06005482 RID: 21634 RVA: 0x000D0271 File Offset: 0x000CE471
		public static IDamageTextOptimizationConfig Create(IDamageTextOptimizationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDamageTextOptimizationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06005483 RID: 21635 RVA: 0x000D0290 File Offset: 0x000CE490
		public override EPerformanceOptimizationType Type
		{
			get
			{
				return (EPerformanceOptimizationType)this.Instance.Type;
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x000D02A0 File Offset: 0x000CE4A0
		public virtual bool? UseRange
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseRange);
			}
		}

		// Token: 0x04003051 RID: 12369
		private IDamageTextOptimizationConfig Instance;
	}
}
