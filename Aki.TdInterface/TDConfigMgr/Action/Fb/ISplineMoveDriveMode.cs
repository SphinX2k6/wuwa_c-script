using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E3 RID: 10723
	public class ISplineMoveDriveMode
	{
		// Token: 0x0600ED3E RID: 60734 RVA: 0x0022E299 File Offset: 0x0022C499
		public static ISplineMoveDriveMode Create(ISplineMoveDriveMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveDriveMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x0600ED3F RID: 60735 RVA: 0x0022E2B8 File Offset: 0x0022C4B8
		public virtual ESplineMoveDriveMode Type
		{
			get
			{
				return (ESplineMoveDriveMode)this.Instance.Type;
			}
		}

		// Token: 0x04008295 RID: 33429
		private ISplineMoveDriveMode Instance;
	}
}
