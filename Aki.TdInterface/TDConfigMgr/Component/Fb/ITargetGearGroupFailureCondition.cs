using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6F RID: 3183
	public class ITargetGearGroupFailureCondition
	{
		// Token: 0x060048B7 RID: 18615 RVA: 0x000B7C15 File Offset: 0x000B5E15
		public static ITargetGearGroupFailureCondition Create(ITargetGearGroupFailureCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupFailureCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x000B7C34 File Offset: 0x000B5E34
		public virtual ETargetGearGroupFailureCondition Type
		{
			get
			{
				return (ETargetGearGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x040028E2 RID: 10466
		private ITargetGearGroupFailureCondition Instance;
	}
}
