using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002750 RID: 10064
	[NullableContext(1)]
	[Nullable(0)]
	public class IBlackCatWarning : ICommonTipType
	{
		// Token: 0x0600E039 RID: 57401 RVA: 0x00212D33 File Offset: 0x00210F33
		public static IBlackCatWarning Create(IBlackCatWarning? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlackCatWarning
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0600E03A RID: 57402 RVA: 0x00212D52 File Offset: 0x00210F52
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0600E03B RID: 57403 RVA: 0x00212D5F File Offset: 0x00210F5F
		public virtual string WarningText
		{
			get
			{
				return this.Instance.WarningText;
			}
		}

		// Token: 0x04007C4E RID: 31822
		private IBlackCatWarning Instance;
	}
}
