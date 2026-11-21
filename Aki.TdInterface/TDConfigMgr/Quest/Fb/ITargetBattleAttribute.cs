using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014E0 RID: 5344
	public class ITargetBattleAttribute
	{
		// Token: 0x0600792B RID: 31019 RVA: 0x00121C0E File Offset: 0x0011FE0E
		public static ITargetBattleAttribute Create(ITargetBattleAttribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetBattleAttribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x00121C2D File Offset: 0x0011FE2D
		public virtual ETargetBattleAttribute Type
		{
			get
			{
				return (ETargetBattleAttribute)this.Instance.Type;
			}
		}

		// Token: 0x040045AE RID: 17838
		private ITargetBattleAttribute Instance;
	}
}
