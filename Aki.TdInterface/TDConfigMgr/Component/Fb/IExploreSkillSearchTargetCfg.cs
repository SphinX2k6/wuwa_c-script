using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA8 RID: 3496
	public class IExploreSkillSearchTargetCfg
	{
		// Token: 0x06004F75 RID: 20341 RVA: 0x000C5BB1 File Offset: 0x000C3DB1
		public static IExploreSkillSearchTargetCfg Create(IExploreSkillSearchTargetCfg? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillSearchTargetCfg
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x000C5BD0 File Offset: 0x000C3DD0
		public virtual EExploreSkillSearchTargetCfg Type
		{
			get
			{
				return (EExploreSkillSearchTargetCfg)this.Instance.Type;
			}
		}

		// Token: 0x04002D3F RID: 11583
		private IExploreSkillSearchTargetCfg Instance;
	}
}
