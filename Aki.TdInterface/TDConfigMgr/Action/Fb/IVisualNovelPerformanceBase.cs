using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281C RID: 10268
	public class IVisualNovelPerformanceBase
	{
		// Token: 0x0600E48F RID: 58511 RVA: 0x0021C93B File Offset: 0x0021AB3B
		public static IVisualNovelPerformanceBase Create(IVisualNovelPerformanceBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x0600E490 RID: 58512 RVA: 0x0021C95A File Offset: 0x0021AB5A
		public virtual EVisualNovelPerformanceType Type
		{
			get
			{
				return (EVisualNovelPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x0600E491 RID: 58513 RVA: 0x0021C968 File Offset: 0x0021AB68
		public virtual float? StartTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StartTime);
			}
		}

		// Token: 0x04007D72 RID: 32114
		private IVisualNovelPerformanceBase Instance;
	}
}
