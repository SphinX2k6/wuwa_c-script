using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D92 RID: 3474
	public class IExploreSkillPullStatue : IExploreSkillInteractType
	{
		// Token: 0x06004F06 RID: 20230 RVA: 0x000C4C28 File Offset: 0x000C2E28
		public static IExploreSkillPullStatue Create(IExploreSkillPullStatue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillPullStatue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x000C4C47 File Offset: 0x000C2E47
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x000C4C54 File Offset: 0x000C2E54
		public virtual ICategoryMatchingCondition Condition
		{
			get
			{
				if (this._ConditionInited)
				{
					return this._ConditionCache;
				}
				this._ConditionInited = true;
				this._ConditionCache = ICategoryMatchingCondition.Create(this.Instance.Condition);
				return this._ConditionCache;
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x000C4C88 File Offset: 0x000C2E88
		public virtual int StatueInteractPointId
		{
			get
			{
				return this.Instance.StatueInteractPointId;
			}
		}

		// Token: 0x04002CE7 RID: 11495
		private IExploreSkillPullStatue Instance;

		// Token: 0x04002CE8 RID: 11496
		[Nullable(2)]
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04002CE9 RID: 11497
		private bool _ConditionInited;
	}
}
