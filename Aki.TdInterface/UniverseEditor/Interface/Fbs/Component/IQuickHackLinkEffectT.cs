using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD4 RID: 24020
	public class IQuickHackLinkEffectT
	{
		// Token: 0x1700B0F2 RID: 45298
		// (get) Token: 0x060280E8 RID: 164072 RVA: 0x0057A615 File Offset: 0x00578815
		// (set) Token: 0x060280E9 RID: 164073 RVA: 0x0057A61D File Offset: 0x0057881D
		public string RequiredState { get; set; }

		// Token: 0x1700B0F3 RID: 45299
		// (get) Token: 0x060280EA RID: 164074 RVA: 0x0057A626 File Offset: 0x00578826
		// (set) Token: 0x060280EB RID: 164075 RVA: 0x0057A62E File Offset: 0x0057882E
		public string EffectPath { get; set; }

		// Token: 0x1700B0F4 RID: 45300
		// (get) Token: 0x060280EC RID: 164076 RVA: 0x0057A637 File Offset: 0x00578837
		// (set) Token: 0x060280ED RID: 164077 RVA: 0x0057A63F File Offset: 0x0057883F
		public IVectorInfoT StartPoint { get; set; }

		// Token: 0x1700B0F5 RID: 45301
		// (get) Token: 0x060280EE RID: 164078 RVA: 0x0057A648 File Offset: 0x00578848
		// (set) Token: 0x060280EF RID: 164079 RVA: 0x0057A650 File Offset: 0x00578850
		public IVectorInfoT EndPoint { get; set; }

		// Token: 0x060280F0 RID: 164080 RVA: 0x0057A659 File Offset: 0x00578859
		public IQuickHackLinkEffectT()
		{
			this.RequiredState = null;
			this.EffectPath = null;
			this.StartPoint = null;
			this.EndPoint = null;
		}
	}
}
