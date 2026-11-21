using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAA RID: 3498
	public class IEnterScreenWeight : IExploreSkillSearchTargetCfg
	{
		// Token: 0x06004F7C RID: 20348 RVA: 0x000C5C85 File Offset: 0x000C3E85
		public static IEnterScreenWeight Create(IEnterScreenWeight? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterScreenWeight
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x000C5CA4 File Offset: 0x000C3EA4
		public override EExploreSkillSearchTargetCfg Type
		{
			get
			{
				return (EExploreSkillSearchTargetCfg)this.Instance.Type;
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x000C5CB1 File Offset: 0x000C3EB1
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x04002D43 RID: 11587
		private IEnterScreenWeight Instance;
	}
}
