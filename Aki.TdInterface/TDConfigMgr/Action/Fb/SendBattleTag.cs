using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C71 RID: 11377
	public class SendBattleTag : ActionParams
	{
		// Token: 0x0600F9FE RID: 63998 RVA: 0x0024497C File Offset: 0x00242B7C
		public static SendBattleTag Create(ISendBattleTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendBattleTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x0600F9FF RID: 63999 RVA: 0x0024499B File Offset: 0x00242B9B
		public virtual int TagConfigId
		{
			get
			{
				return this.Instance.TagConfigId;
			}
		}

		// Token: 0x04008899 RID: 34969
		private ISendBattleTag Instance;
	}
}
