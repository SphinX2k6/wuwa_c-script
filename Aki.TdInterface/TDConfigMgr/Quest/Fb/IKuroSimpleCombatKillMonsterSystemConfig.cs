using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F1 RID: 4849
	public class IKuroSimpleCombatKillMonsterSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006EAB RID: 28331 RVA: 0x0010B565 File Offset: 0x00109765
		[NullableContext(1)]
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

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06006EAC RID: 28332 RVA: 0x0010B584 File Offset: 0x00109784
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x04003F6F RID: 16239
		private IKuroSimpleCombatKillMonsterSystemConfig Instance;
	}
}
