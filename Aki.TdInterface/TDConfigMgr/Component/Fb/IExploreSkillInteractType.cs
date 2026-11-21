using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D8F RID: 3471
	public class IExploreSkillInteractType
	{
		// Token: 0x06004EF9 RID: 20217 RVA: 0x000C4AA3 File Offset: 0x000C2CA3
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

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x000C4AC2 File Offset: 0x000C2CC2
		public virtual EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002CE0 RID: 11488
		private IExploreSkillInteractType Instance;
	}
}
