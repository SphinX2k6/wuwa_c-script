using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A1C RID: 10780
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlopeSlidePerformStart : IStartSlidePerformType
	{
		// Token: 0x0600EDA2 RID: 60834 RVA: 0x0022A1C1 File Offset: 0x002283C1
		public static ISlopeSlidePerformStart Create(ISlopeSlidePerformStart? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlopeSlidePerformStart
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x0600EDA3 RID: 60835 RVA: 0x0022A1E0 File Offset: 0x002283E0
		public override ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x0600EDA4 RID: 60836 RVA: 0x0022A1ED File Offset: 0x002283ED
		public virtual string SlopeSlidePerformDaPath
		{
			get
			{
				return this.Instance.SlopeSlidePerformDaPath;
			}
		}

		// Token: 0x040082CC RID: 33484
		private ISlopeSlidePerformStart Instance;
	}
}
