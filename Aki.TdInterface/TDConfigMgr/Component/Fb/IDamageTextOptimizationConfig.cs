using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA4 RID: 3492
	public class IDamageTextOptimizationConfig : IPerformanceOptimization
	{
		// Token: 0x06004F5D RID: 20317 RVA: 0x000C4A21 File Offset: 0x000C2C21
		[NullableContext(1)]
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

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06004F5E RID: 20318 RVA: 0x000C4A40 File Offset: 0x000C2C40
		public override EPerformanceOptimizationType Type
		{
			get
			{
				return (EPerformanceOptimizationType)this.Instance.Type;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x000C4A50 File Offset: 0x000C2C50
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

		// Token: 0x04002D8B RID: 11659
		private IDamageTextOptimizationConfig Instance;
	}
}
