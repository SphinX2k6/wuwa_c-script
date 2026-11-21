using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA6 RID: 11686
	public class IMusicBattleBtnEffect : ISkillBtnEffectBase
	{
		// Token: 0x0600FEA4 RID: 65188 RVA: 0x0024B988 File Offset: 0x00249B88
		public static IMusicBattleBtnEffect Create(IMusicBattleBtnEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMusicBattleBtnEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x0600FEA5 RID: 65189 RVA: 0x0024B9A7 File Offset: 0x00249BA7
		public override ESkillBtnEffectType Type
		{
			get
			{
				return (ESkillBtnEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04008B02 RID: 35586
		private IMusicBattleBtnEffect Instance;
	}
}
