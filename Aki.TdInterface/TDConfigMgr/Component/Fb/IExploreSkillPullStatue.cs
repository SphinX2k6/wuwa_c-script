using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB0 RID: 3248
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillPullStatue : IExploreSkillInteractType
	{
		// Token: 0x06004A58 RID: 19032 RVA: 0x000BA218 File Offset: 0x000B8418
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

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06004A59 RID: 19033 RVA: 0x000BA237 File Offset: 0x000B8437
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06004A5A RID: 19034 RVA: 0x000BA244 File Offset: 0x000B8444
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

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x000BA278 File Offset: 0x000B8478
		public virtual int StatueInteractPointId
		{
			get
			{
				return this.Instance.StatueInteractPointId;
			}
		}

		// Token: 0x04002A6D RID: 10861
		private IExploreSkillPullStatue Instance;

		// Token: 0x04002A6E RID: 10862
		[Nullable(2)]
		private ICategoryMatchingCondition _ConditionCache;

		// Token: 0x04002A6F RID: 10863
		private bool _ConditionInited;
	}
}
