using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002773 RID: 10099
	public class ISetBehaviorPaused
	{
		// Token: 0x0600DFCB RID: 57291 RVA: 0x0020F26E File Offset: 0x0020D46E
		public static ISetBehaviorPaused Create(ISetBehaviorPaused? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBehaviorPaused
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600DFCC RID: 57292 RVA: 0x0020F28D File Offset: 0x0020D48D
		public virtual bool IsPaused
		{
			get
			{
				return this.Instance.IsPaused;
			}
		}

		// Token: 0x040079C5 RID: 31173
		private ISetBehaviorPaused Instance;
	}
}
