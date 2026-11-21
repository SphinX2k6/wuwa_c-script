using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB5 RID: 2997
	public class IEntityGroupFailureCondition
	{
		// Token: 0x06004486 RID: 17542 RVA: 0x000ADA6E File Offset: 0x000ABC6E
		public static IEntityGroupFailureCondition Create(IEntityGroupFailureCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x000ADA8D File Offset: 0x000ABC8D
		public virtual EEntityGroupFailureCondition Type
		{
			get
			{
				return (EEntityGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x040025F4 RID: 9716
		private IEntityGroupFailureCondition Instance;
	}
}
