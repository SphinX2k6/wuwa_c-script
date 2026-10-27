using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200130F RID: 4879
	public class ITrackRuleTypeBase
	{
		// Token: 0x06007010 RID: 28688 RVA: 0x0010ED8C File Offset: 0x0010CF8C
		[NullableContext(1)]
		public static ITrackRuleTypeBase Create(ITrackRuleTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackRuleTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x0010EDAB File Offset: 0x0010CFAB
		public virtual ETrackRuleType Type
		{
			get
			{
				return (ETrackRuleType)this.Instance.Type;
			}
		}

		// Token: 0x040040A5 RID: 16549
		private ITrackRuleTypeBase Instance;
	}
}
