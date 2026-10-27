using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB1 RID: 3249
	public class IExploreSkillRagDollCrushingRock : IExploreSkillInteractType
	{
		// Token: 0x06004A5D RID: 19037 RVA: 0x000BA28D File Offset: 0x000B848D
		[NullableContext(1)]
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

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06004A5E RID: 19038 RVA: 0x000BA2AC File Offset: 0x000B84AC
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002A70 RID: 10864
		private IExploreSkillRagDollCrushingRock Instance;
	}
}
