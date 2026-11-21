using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001437 RID: 5175
	public class IKuroSimpleCombatKillMonsterSystemConfig : IEnableSystemConfig
	{
		// Token: 0x0600752B RID: 29995 RVA: 0x00119865 File Offset: 0x00117A65
		public static IKuroSimpleCombatKillMonsterSystemConfig Create(IKuroSimpleCombatKillMonsterSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKuroSimpleCombatKillMonsterSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x0600752C RID: 29996 RVA: 0x00119884 File Offset: 0x00117A84
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x040042DD RID: 17117
		private IKuroSimpleCombatKillMonsterSystemConfig Instance;
	}
}
