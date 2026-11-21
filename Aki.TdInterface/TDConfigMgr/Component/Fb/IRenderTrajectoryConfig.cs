using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C16 RID: 3094
	public class IRenderTrajectoryConfig
	{
		// Token: 0x060046E1 RID: 18145 RVA: 0x000B4191 File Offset: 0x000B2391
		public static IRenderTrajectoryConfig Create(IRenderTrajectoryConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderTrajectoryConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x000B41B0 File Offset: 0x000B23B0
		public virtual float Time
		{
			get
			{
				return this.Instance.Time;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x060046E3 RID: 18147 RVA: 0x000B41BD File Offset: 0x000B23BD
		public virtual string Effect
		{
			get
			{
				return this.Instance.Effect;
			}
		}

		// Token: 0x040027C1 RID: 10177
		private IRenderTrajectoryConfig Instance;
	}
}
