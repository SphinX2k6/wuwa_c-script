using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E8 RID: 9960
	public class ISendBattleEventsForMonsterSummonConfig
	{
		// Token: 0x0600DE7A RID: 56954 RVA: 0x002101A5 File Offset: 0x0020E3A5
		[NullableContext(1)]
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

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0600DE7B RID: 56955 RVA: 0x002101C4 File Offset: 0x0020E3C4
		public virtual int TagConfigId
		{
			get
			{
				return this.Instance.TagConfigId;
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x002101D4 File Offset: 0x0020E3D4
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

		// Token: 0x04007B7E RID: 31614
		private ISendBattleEventsForMonsterSummonConfig Instance;
	}
}
