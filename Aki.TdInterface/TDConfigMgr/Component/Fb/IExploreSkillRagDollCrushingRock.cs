using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D93 RID: 3475
	public class IExploreSkillRagDollCrushingRock : IExploreSkillInteractType
	{
		// Token: 0x06004F0B RID: 20235 RVA: 0x000C4C9D File Offset: 0x000C2E9D
		public static IExploreSkillRagDollCrushingRock Create(IExploreSkillRagDollCrushingRock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillRagDollCrushingRock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x000C4CBC File Offset: 0x000C2EBC
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002CEA RID: 11498
		private IExploreSkillRagDollCrushingRock Instance;
	}
}
