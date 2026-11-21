using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B2 RID: 10162
	public class ITalkOptionFirstSelect : ITalkOptionPreConditionBase
	{
		// Token: 0x0600E0F0 RID: 57584 RVA: 0x002114F8 File Offset: 0x0020F6F8
		public static ITalkOptionFirstSelect Create(ITalkOptionFirstSelect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionFirstSelect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x00211517 File Offset: 0x0020F717
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x04007A4E RID: 31310
		private ITalkOptionFirstSelect Instance;
	}
}
