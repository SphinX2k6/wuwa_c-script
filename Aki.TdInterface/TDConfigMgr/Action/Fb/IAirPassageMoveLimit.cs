using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BB2 RID: 11186
	public class IAirPassageMoveLimit
	{
		// Token: 0x0600F68C RID: 63116 RVA: 0x0023EA05 File Offset: 0x0023CC05
		public static IAirPassageMoveLimit Create(IAirPassageMoveLimit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirPassageMoveLimit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x0600F68D RID: 63117 RVA: 0x0023EA24 File Offset: 0x0023CC24
		public virtual float DirectionAngleLimit
		{
			get
			{
				return this.Instance.DirectionAngleLimit;
			}
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x0600F68E RID: 63118 RVA: 0x0023EA31 File Offset: 0x0023CC31
		public virtual float EdgeLimitCurveFactor
		{
			get
			{
				return this.Instance.EdgeLimitCurveFactor;
			}
		}

		// Token: 0x0400871C RID: 34588
		private IAirPassageMoveLimit Instance;
	}
}
