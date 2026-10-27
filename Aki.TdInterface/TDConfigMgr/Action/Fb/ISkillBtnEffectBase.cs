using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB1 RID: 10929
	public class ISkillBtnEffectBase
	{
		// Token: 0x0600EFEB RID: 61419 RVA: 0x0022DC48 File Offset: 0x0022BE48
		[NullableContext(1)]
		public static ISkillBtnEffectBase Create(ISkillBtnEffectBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillBtnEffectBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C4B RID: 19531
		// (get) Token: 0x0600EFEC RID: 61420 RVA: 0x0022DC67 File Offset: 0x0022BE67
		public virtual ESkillBtnEffectType Type
		{
			get
			{
				return (ESkillBtnEffectType)this.Instance.Type;
			}
		}

		// Token: 0x040083FD RID: 33789
		private ISkillBtnEffectBase Instance;
	}
}
