using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280D RID: 10253
	public class AvgShakeUi : ActionParams
	{
		// Token: 0x0600E453 RID: 58451 RVA: 0x0021C413 File Offset: 0x0021A613
		public static AvgShakeUi Create(IAvgShakeUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AvgShakeUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x0600E454 RID: 58452 RVA: 0x0021C432 File Offset: 0x0021A632
		public virtual EAvgShakeUiIntensity Intensity
		{
			get
			{
				return (EAvgShakeUiIntensity)this.Instance.Intensity;
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x0600E455 RID: 58453 RVA: 0x0021C43F File Offset: 0x0021A63F
		public virtual int RepeatCount
		{
			get
			{
				return this.Instance.RepeatCount;
			}
		}

		// Token: 0x04007D63 RID: 32099
		private IAvgShakeUi Instance;
	}
}
