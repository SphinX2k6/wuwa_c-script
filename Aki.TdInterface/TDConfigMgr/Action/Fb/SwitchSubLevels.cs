using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288F RID: 10383
	public class SwitchSubLevels : ActionParams
	{
		// Token: 0x0600E5F6 RID: 58870 RVA: 0x0021CC6F File Offset: 0x0021AE6F
		[NullableContext(1)]
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

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x0600E5F7 RID: 58871 RVA: 0x0021CC8E File Offset: 0x0021AE8E
		public virtual ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x04007F21 RID: 32545
		private ISwitchSubLevels Instance;
	}
}
