using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002751 RID: 10065
	[NullableContext(1)]
	[Nullable(0)]
	public class IWhiteCatWarning : ICommonTipType
	{
		// Token: 0x0600E03D RID: 57405 RVA: 0x00212D74 File Offset: 0x00210F74
		public static IWhiteCatWarning Create(IWhiteCatWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWhiteCatWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x0600E03E RID: 57406 RVA: 0x00212D93 File Offset: 0x00210F93
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x0600E03F RID: 57407 RVA: 0x00212DA0 File Offset: 0x00210FA0
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x04007C4F RID: 31823
		private IWhiteCatWarning Instance;
	}
}
