using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD6 RID: 11478
	public class IDelayRemoveAfterSkillFinish : IDelayRemoveType
	{
		// Token: 0x0600FB86 RID: 64390 RVA: 0x00246D98 File Offset: 0x00244F98
		public static IDelayRemoveAfterSkillFinish Create(IDelayRemoveAfterSkillFinish? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDelayRemoveAfterSkillFinish
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x0600FB87 RID: 64391 RVA: 0x00246DB7 File Offset: 0x00244FB7
		public override EDelayRemoveType Type
		{
			get
			{
				return (EDelayRemoveType)this.Instance.Type;
			}
		}

		// Token: 0x0400896E RID: 35182
		private IDelayRemoveAfterSkillFinish Instance;
	}
}
