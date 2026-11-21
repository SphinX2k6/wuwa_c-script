using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AF RID: 10159
	public class ITalkOptionPreConditionBase
	{
		// Token: 0x0600E0E5 RID: 57573 RVA: 0x002113C2 File Offset: 0x0020F5C2
		public static ITalkOptionPreConditionBase Create(ITalkOptionPreConditionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPreConditionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x0600E0E6 RID: 57574 RVA: 0x002113E1 File Offset: 0x0020F5E1
		public virtual ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x04007A47 RID: 31303
		private ITalkOptionPreConditionBase Instance;
	}
}
