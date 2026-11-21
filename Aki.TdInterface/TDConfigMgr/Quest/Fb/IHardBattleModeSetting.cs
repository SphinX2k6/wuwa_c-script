using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015AA RID: 5546
	public class IHardBattleModeSetting
	{
		// Token: 0x06007D10 RID: 32016 RVA: 0x00129446 File Offset: 0x00127646
		public static IHardBattleModeSetting Create(IHardBattleModeSetting? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHardBattleModeSetting
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x06007D11 RID: 32017 RVA: 0x00129468 File Offset: 0x00127668
		public virtual bool? CanOpenHardBattleMode
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanOpenHardBattleMode);
			}
		}

		// Token: 0x04004844 RID: 18500
		private IHardBattleModeSetting Instance;
	}
}
