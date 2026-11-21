using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E4 RID: 10724
	public class IInputDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600ED41 RID: 60737 RVA: 0x0022E2CD File Offset: 0x0022C4CD
		public static IInputDrivenMoveDriveMode Create(IInputDrivenMoveDriveMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInputDrivenMoveDriveMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x0600ED42 RID: 60738 RVA: 0x0022E2EC File Offset: 0x0022C4EC
		public override ESplineMoveDriveMode Type
		{
			get
			{
				return (ESplineMoveDriveMode)this.Instance.Type;
			}
		}

		// Token: 0x04008296 RID: 33430
		private IInputDrivenMoveDriveMode Instance;
	}
}
