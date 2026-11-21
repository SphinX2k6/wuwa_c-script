using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB7 RID: 2999
	public class IEntityGroupFailureArbitraryState : IEntityGroupFailureCondition
	{
		// Token: 0x0600448D RID: 17549 RVA: 0x000ADB52 File Offset: 0x000ABD52
		public static IEntityGroupFailureArbitraryState Create(IEntityGroupFailureArbitraryState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureArbitraryState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x000ADB71 File Offset: 0x000ABD71
		public override EEntityGroupFailureCondition Type
		{
			get
			{
				return (EEntityGroupFailureCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x000ADB7E File Offset: 0x000ABD7E
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x040025F8 RID: 9720
		private IEntityGroupFailureArbitraryState Instance;
	}
}
