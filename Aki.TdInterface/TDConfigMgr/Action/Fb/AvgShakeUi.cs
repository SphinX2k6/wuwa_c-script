using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002564 RID: 9572
	public class AvgShakeUi : ActionParams
	{
		// Token: 0x0600D6E9 RID: 55017 RVA: 0x00200817 File Offset: 0x001FEA17
		[NullableContext(1)]
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

		// Token: 0x17003DE3 RID: 15843
		// (get) Token: 0x0600D6EA RID: 55018 RVA: 0x00200836 File Offset: 0x001FEA36
		public virtual EAvgShakeUiIntensity Intensity
		{
			get
			{
				return (EAvgShakeUiIntensity)this.Instance.Intensity;
			}
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x0600D6EB RID: 55019 RVA: 0x00200843 File Offset: 0x001FEA43
		public virtual int RepeatCount
		{
			get
			{
				return this.Instance.RepeatCount;
			}
		}

		// Token: 0x04007706 RID: 30470
		private IAvgShakeUi Instance;
	}
}
