using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB2 RID: 3250
	public class IExploreSkillRagDollDestroySolidRock : IExploreSkillInteractType
	{
		// Token: 0x06004A60 RID: 19040 RVA: 0x000BA2C1 File Offset: 0x000B84C1
		[NullableContext(1)]
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

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x000BA2E0 File Offset: 0x000B84E0
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002A71 RID: 10865
		private IExploreSkillRagDollDestroySolidRock Instance;
	}
}
