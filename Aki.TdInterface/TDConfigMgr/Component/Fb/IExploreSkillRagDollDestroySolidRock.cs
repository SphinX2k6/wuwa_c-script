using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D94 RID: 3476
	public class IExploreSkillRagDollDestroySolidRock : IExploreSkillInteractType
	{
		// Token: 0x06004F0E RID: 20238 RVA: 0x000C4CD1 File Offset: 0x000C2ED1
		public static IExploreSkillRagDollDestroySolidRock Create(IExploreSkillRagDollDestroySolidRock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillRagDollDestroySolidRock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x000C4CF0 File Offset: 0x000C2EF0
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002CEB RID: 11499
		private IExploreSkillRagDollDestroySolidRock Instance;
	}
}
