using System;

namespace System.Security
{
	// Token: 0x02000264 RID: 612
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SecurityRulesAttribute : Attribute
	{
		// Token: 0x06002DDA RID: 11738 RVA: 0x00093DC5 File Offset: 0x00091FC5
		public SecurityRulesAttribute(SecurityRuleSet ruleSet)
		{
			this.RuleSet = ruleSet;
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x00093DD4 File Offset: 0x00091FD4
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x00093DDC File Offset: 0x00091FDC
		public bool SkipVerificationInFullTrust { get; set; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x00093DE5 File Offset: 0x00091FE5
		public SecurityRuleSet RuleSet { get; }
	}
}
