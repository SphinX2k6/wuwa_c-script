using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E5 RID: 10725
	public class IPositionDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600ED44 RID: 60740 RVA: 0x0022E301 File Offset: 0x0022C501
		public static IPositionDrivenMoveDriveMode Create(IPositionDrivenMoveDriveMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPositionDrivenMoveDriveMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x0600ED45 RID: 60741 RVA: 0x0022E320 File Offset: 0x0022C520
		public override ESplineMoveDriveMode Type
		{
			get
			{
				return (ESplineMoveDriveMode)this.Instance.Type;
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x0600ED46 RID: 60742 RVA: 0x0022E330 File Offset: 0x0022C530
		public virtual bool? IsFixedPitch
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFixedPitch);
			}
		}

		// Token: 0x04008297 RID: 33431
		private IPositionDrivenMoveDriveMode Instance;
	}
}
