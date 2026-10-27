using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC4 RID: 3268
	public class IExploreSkillSearchTargetCfg
	{
		// Token: 0x06004ABA RID: 19130 RVA: 0x000BAF79 File Offset: 0x000B9179
		[NullableContext(1)]
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

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x000BAF98 File Offset: 0x000B9198
		public virtual EExploreSkillSearchTargetCfg Type
		{
			get
			{
				return (EExploreSkillSearchTargetCfg)this.Instance.Type;
			}
		}

		// Token: 0x04002AB9 RID: 10937
		private IExploreSkillSearchTargetCfg Instance;
	}
}
