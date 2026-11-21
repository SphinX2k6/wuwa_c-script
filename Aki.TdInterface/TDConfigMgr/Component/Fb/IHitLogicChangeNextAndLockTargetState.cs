using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C56 RID: 3158
	public class IHitLogicChangeNextAndLockTargetState : IHitLogicType
	{
		// Token: 0x0600483F RID: 18495 RVA: 0x000B6CA6 File Offset: 0x000B4EA6
		public static IHitLogicChangeNextAndLockTargetState Create(IHitLogicChangeNextAndLockTargetState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHitLogicChangeNextAndLockTargetState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x000B6CC5 File Offset: 0x000B4EC5
		public override EHitLogicType Type
		{
			get
			{
				return (EHitLogicType)this.Instance.Type;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x000B6CD2 File Offset: 0x000B4ED2
		public virtual string TargetState
		{
			get
			{
				return this.Instance.TargetState;
			}
		}

		// Token: 0x0400288F RID: 10383
		private IHitLogicChangeNextAndLockTargetState Instance;
	}
}
