using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC5 RID: 3269
	[NullableContext(1)]
	[Nullable(0)]
	public class IAngleWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06004ABD RID: 19133 RVA: 0x000BAFAD File Offset: 0x000B91AD
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

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x000BAFCC File Offset: 0x000B91CC
		public override EExploreSkillSearchTargetCfg Type
		{
			get
			{
				return (EExploreSkillSearchTargetCfg)this.Instance.Type;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x000BAFDC File Offset: 0x000B91DC
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

		// Token: 0x04002ABA RID: 10938
		private IAngleWeight Instance;

		// Token: 0x04002ABB RID: 10939
		private List<IEntityAngleWeight> _AngleWeightCache;

		// Token: 0x04002ABC RID: 10940
		private bool _AngleWeightInited;
	}
}
