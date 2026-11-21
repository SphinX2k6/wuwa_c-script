using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B7C RID: 11132
	public class ICameraLockTargetBase
	{
		// Token: 0x0600F4A1 RID: 62625 RVA: 0x0023AB44 File Offset: 0x00238D44
		public static ICameraLockTargetBase Create(ICameraLockTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x0023AB63 File Offset: 0x00238D63
		public virtual ECameraLockTargetType Type
		{
			get
			{
				return (ECameraLockTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008626 RID: 34342
		private ICameraLockTargetBase Instance;
	}
}
