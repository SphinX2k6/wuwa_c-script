using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B64 RID: 11108
	public class SwitchSubLevels : ActionParams
	{
		// Token: 0x0600F425 RID: 62501 RVA: 0x00239BEF File Offset: 0x00237DEF
		public static SwitchSubLevels Create(ISwitchSubLevels? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitchSubLevels
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x0600F426 RID: 62502 RVA: 0x00239C0E File Offset: 0x00237E0E
		public virtual ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x040085E0 RID: 34272
		private ISwitchSubLevels Instance;
	}
}
