using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA5 RID: 11685
	public class ISkillBtnEffectBase
	{
		// Token: 0x0600FEA1 RID: 65185 RVA: 0x0024B954 File Offset: 0x00249B54
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

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x0600FEA2 RID: 65186 RVA: 0x0024B973 File Offset: 0x00249B73
		public virtual ESkillBtnEffectType Type
		{
			get
			{
				return (ESkillBtnEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04008B01 RID: 35585
		private ISkillBtnEffectBase Instance;
	}
}
