using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CAD RID: 3245
	public class IExploreSkillInteractType
	{
		// Token: 0x06004A4B RID: 19019 RVA: 0x000BA093 File Offset: 0x000B8293
		[NullableContext(1)]
		public static IExploreSkillInteractType Create(IExploreSkillInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x000BA0B2 File Offset: 0x000B82B2
		public virtual EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002A66 RID: 10854
		private IExploreSkillInteractType Instance;
	}
}
