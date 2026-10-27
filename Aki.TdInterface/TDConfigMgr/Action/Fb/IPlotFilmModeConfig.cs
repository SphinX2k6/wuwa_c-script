using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C8 RID: 9672
	public class IPlotFilmModeConfig
	{
		// Token: 0x0600D96E RID: 55662 RVA: 0x00206D66 File Offset: 0x00204F66
		[NullableContext(1)]
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

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x0600D96F RID: 55663 RVA: 0x00206D88 File Offset: 0x00204F88
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

		// Token: 0x040078C0 RID: 30912
		private IPlotFilmModeConfig Instance;
	}
}
