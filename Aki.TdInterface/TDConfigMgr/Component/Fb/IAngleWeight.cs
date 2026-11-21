using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA9 RID: 3497
	public class IAngleWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06004F78 RID: 20344 RVA: 0x000C5BE5 File Offset: 0x000C3DE5
		public static IAngleWeight Create(IAngleWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAngleWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x000C5C04 File Offset: 0x000C3E04
		public override EExploreSkillSearchTargetCfg Type
		{
			get
			{
				return (EExploreSkillSearchTargetCfg)this.Instance.Type;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x000C5C14 File Offset: 0x000C3E14
		public virtual List<IEntityAngleWeight> AngleWeight
		{
			get
			{
				if (this._AngleWeightInited)
				{
					return this._AngleWeightCache;
				}
				this._AngleWeightInited = true;
				int angleWeightLength = this.Instance.AngleWeightLength;
				this._AngleWeightCache = new List<IEntityAngleWeight>(angleWeightLength);
				for (int i = 0; i < angleWeightLength; i++)
				{
					this._AngleWeightCache.Add(IEntityAngleWeight.Create(this.Instance.AngleWeight(i)));
				}
				return this._AngleWeightCache;
			}
		}

		// Token: 0x04002D40 RID: 11584
		private IAngleWeight Instance;

		// Token: 0x04002D41 RID: 11585
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x04002D42 RID: 11586
		private bool _AngleWeightInited;
	}
}
