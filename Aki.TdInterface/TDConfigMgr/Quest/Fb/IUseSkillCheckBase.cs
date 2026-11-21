using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014B3 RID: 5299
	public class IUseSkillCheckBase
	{
		// Token: 0x06007838 RID: 30776 RVA: 0x00120076 File Offset: 0x0011E276
		public static IUseSkillCheckBase Create(IUseSkillCheckBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x00120095 File Offset: 0x0011E295
		public virtual EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x0400451F RID: 17695
		private IUseSkillCheckBase Instance;
	}
}
