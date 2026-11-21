using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029AC RID: 10668
	public class ISendBattleEventsForMonsterSummonConfig
	{
		// Token: 0x0600EC56 RID: 60502 RVA: 0x0022C9E5 File Offset: 0x0022ABE5
		public static ISendBattleEventsForMonsterSummonConfig Create(ISendBattleEventsForMonsterSummonConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleEventsForMonsterSummonConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x0600EC57 RID: 60503 RVA: 0x0022CA04 File Offset: 0x0022AC04
		public virtual int TagConfigId
		{
			get
			{
				return this.Instance.TagConfigId;
			}
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x0600EC58 RID: 60504 RVA: 0x0022CA14 File Offset: 0x0022AC14
		public virtual int? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DelayTime);
			}
		}

		// Token: 0x0400821E RID: 33310
		private ISendBattleEventsForMonsterSummonConfig Instance;
	}
}
