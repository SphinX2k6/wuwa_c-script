using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D09 RID: 11529
	public class ISlopeSlidePerformStart : IStartSlidePerformType
	{
		// Token: 0x0600FC39 RID: 64569 RVA: 0x00247B45 File Offset: 0x00245D45
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

		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x0600FC3A RID: 64570 RVA: 0x00247B64 File Offset: 0x00245D64
		public override ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x0600FC3B RID: 64571 RVA: 0x00247B71 File Offset: 0x00245D71
		public virtual string SlopeSlidePerformDaPath
		{
			get
			{
				return this.Instance.SlopeSlidePerformDaPath;
			}
		}

		// Token: 0x040089BD RID: 35261
		private ISlopeSlidePerformStart Instance;
	}
}
