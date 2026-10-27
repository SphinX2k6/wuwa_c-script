using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CB3 RID: 3251
	public class IExploreSkillLonelyDollPollutant : IExploreSkillInteractType
	{
		// Token: 0x06004A63 RID: 19043 RVA: 0x000BA2F5 File Offset: 0x000B84F5
		[NullableContext(1)]
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

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x000BA314 File Offset: 0x000B8514
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002A72 RID: 10866
		private IExploreSkillLonelyDollPollutant Instance;
	}
}
