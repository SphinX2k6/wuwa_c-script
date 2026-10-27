using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200139E RID: 5022
	public class IRoleTrialActivities : IShowUi
	{
		// Token: 0x060072CB RID: 29387 RVA: 0x00113CD1 File Offset: 0x00111ED1
		[NullableContext(1)]
		public static IRoleTrialActivities Create(IRoleTrialActivities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTrialActivities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x060072CC RID: 29388 RVA: 0x00113CF0 File Offset: 0x00111EF0
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x0400425C RID: 16988
		private IRoleTrialActivities Instance;
	}
}
