using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D95 RID: 3477
	public class IExploreSkillLonelyDollPollutant : IExploreSkillInteractType
	{
		// Token: 0x06004F11 RID: 20241 RVA: 0x000C4D05 File Offset: 0x000C2F05
		public static IExploreSkillLonelyDollPollutant Create(IExploreSkillLonelyDollPollutant? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillLonelyDollPollutant
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06004F12 RID: 20242 RVA: 0x000C4D24 File Offset: 0x000C2F24
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002CEC RID: 11500
		private IExploreSkillLonelyDollPollutant Instance;
	}
}
