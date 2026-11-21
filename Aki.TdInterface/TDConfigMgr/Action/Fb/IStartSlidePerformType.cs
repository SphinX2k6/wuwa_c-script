using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D08 RID: 11528
	public class IStartSlidePerformType
	{
		// Token: 0x0600FC36 RID: 64566 RVA: 0x00247B11 File Offset: 0x00245D11
		public static IStartSlidePerformType Create(IStartSlidePerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStartSlidePerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x0600FC37 RID: 64567 RVA: 0x00247B30 File Offset: 0x00245D30
		public virtual ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x040089BC RID: 35260
		private IStartSlidePerformType Instance;
	}
}
