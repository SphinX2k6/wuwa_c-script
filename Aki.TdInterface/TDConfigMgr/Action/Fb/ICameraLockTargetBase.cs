using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A7 RID: 10407
	public class ICameraLockTargetBase
	{
		// Token: 0x0600E672 RID: 58994 RVA: 0x0021DBC4 File Offset: 0x0021BDC4
		[NullableContext(1)]
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

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x0600E673 RID: 58995 RVA: 0x0021DBE3 File Offset: 0x0021BDE3
		public virtual ECameraLockTargetType Type
		{
			get
			{
				return (ECameraLockTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04007F67 RID: 32615
		private ICameraLockTargetBase Instance;
	}
}
