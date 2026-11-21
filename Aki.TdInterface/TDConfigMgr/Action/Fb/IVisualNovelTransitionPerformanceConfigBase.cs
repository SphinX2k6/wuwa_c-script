using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002836 RID: 10294
	public class IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600E51D RID: 58653 RVA: 0x0021D9B2 File Offset: 0x0021BBB2
		public static IVisualNovelTransitionPerformanceConfigBase Create(IVisualNovelTransitionPerformanceConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x0600E51E RID: 58654 RVA: 0x0021D9D1 File Offset: 0x0021BBD1
		public virtual EVisualNovelSubType Type
		{
			get
			{
				return (EVisualNovelSubType)this.Instance.Type;
			}
		}

		// Token: 0x04007DB6 RID: 32182
		private IVisualNovelTransitionPerformanceConfigBase Instance;
	}
}
