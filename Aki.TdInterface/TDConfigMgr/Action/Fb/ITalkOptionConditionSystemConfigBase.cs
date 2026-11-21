using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B3 RID: 10163
	public class ITalkOptionConditionSystemConfigBase
	{
		// Token: 0x0600E0F3 RID: 57587 RVA: 0x0021152C File Offset: 0x0020F72C
		public static ITalkOptionConditionSystemConfigBase Create(ITalkOptionConditionSystemConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionConditionSystemConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600E0F4 RID: 57588 RVA: 0x0021154B File Offset: 0x0020F74B
		public virtual ETalkOptionConditionSystem Type
		{
			get
			{
				return (ETalkOptionConditionSystem)this.Instance.Type;
			}
		}

		// Token: 0x04007A4F RID: 31311
		private ITalkOptionConditionSystemConfigBase Instance;
	}
}
