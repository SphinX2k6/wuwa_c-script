using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D17 RID: 11543
	public class IBvbUseFieldCardSkill : IBvbPlayerOperationType
	{
		// Token: 0x0600FC74 RID: 64628 RVA: 0x00248361 File Offset: 0x00246561
		public static IBvbUseFieldCardSkill Create(IBvbUseFieldCardSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbUseFieldCardSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x0600FC75 RID: 64629 RVA: 0x00248380 File Offset: 0x00246580
		public override EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040089DF RID: 35295
		private IBvbUseFieldCardSkill Instance;
	}
}
