using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB2 RID: 10930
	public class IMusicBattleBtnEffect : ISkillBtnEffectBase
	{
		// Token: 0x0600EFEE RID: 61422 RVA: 0x0022DC7C File Offset: 0x0022BE7C
		[NullableContext(1)]
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

		// Token: 0x17004C4C RID: 19532
		// (get) Token: 0x0600EFEF RID: 61423 RVA: 0x0022DC9B File Offset: 0x0022BE9B
		public override ESkillBtnEffectType Type
		{
			get
			{
				return (ESkillBtnEffectType)this.Instance.Type;
			}
		}

		// Token: 0x040083FE RID: 33790
		private IMusicBattleBtnEffect Instance;
	}
}
