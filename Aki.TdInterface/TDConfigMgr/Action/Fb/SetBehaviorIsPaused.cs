using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025BA RID: 9658
	public class SetBehaviorIsPaused : ActionParams
	{
		// Token: 0x0600D943 RID: 55619 RVA: 0x002069D6 File Offset: 0x00204BD6
		[NullableContext(1)]
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

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0600D944 RID: 55620 RVA: 0x002069F5 File Offset: 0x00204BF5
		public virtual bool IsPaused
		{
			get
			{
				return this.Instance.IsPaused;
			}
		}

		// Token: 0x040078AE RID: 30894
		private ISetBehaviorIsPaused Instance;
	}
}
