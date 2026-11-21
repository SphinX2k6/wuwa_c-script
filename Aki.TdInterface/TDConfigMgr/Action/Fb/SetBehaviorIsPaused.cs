using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002869 RID: 10345
	public class SetBehaviorIsPaused : ActionParams
	{
		// Token: 0x0600E6BD RID: 59069 RVA: 0x002226AA File Offset: 0x002208AA
		public static SetBehaviorIsPaused Create(ISetBehaviorIsPaused? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetBehaviorIsPaused
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x002226C9 File Offset: 0x002208C9
		public virtual bool IsPaused
		{
			get
			{
				return this.Instance.IsPaused;
			}
		}

		// Token: 0x04007F15 RID: 32533
		private ISetBehaviorIsPaused Instance;
	}
}
