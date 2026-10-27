using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200139F RID: 5023
	public class IRoleSkinTrialActivities : IShowUi
	{
		// Token: 0x060072CE RID: 29390 RVA: 0x00113D05 File Offset: 0x00111F05
		[NullableContext(1)]
		public static IRoleSkinTrialActivities Create(IRoleSkinTrialActivities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleSkinTrialActivities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x060072CF RID: 29391 RVA: 0x00113D24 File Offset: 0x00111F24
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x0400425D RID: 16989
		private IRoleSkinTrialActivities Instance;
	}
}
