using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002877 RID: 10359
	public class IPlotFilmModeConfig
	{
		// Token: 0x0600E6E8 RID: 59112 RVA: 0x00222A3A File Offset: 0x00220C3A
		public static IPlotFilmModeConfig Create(IPlotFilmModeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlotFilmModeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x0600E6E9 RID: 59113 RVA: 0x00222A5C File Offset: 0x00220C5C
		public virtual bool? IsAdaptFilmAspectRatio
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAdaptFilmAspectRatio);
			}
		}

		// Token: 0x04007F27 RID: 32551
		private IPlotFilmModeConfig Instance;
	}
}
