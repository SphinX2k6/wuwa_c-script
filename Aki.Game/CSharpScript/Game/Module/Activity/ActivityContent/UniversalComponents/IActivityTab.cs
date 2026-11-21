using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F63 RID: 20323
	[NullableContext(1)]
	public interface IActivityTab
	{
		// Token: 0x170063A9 RID: 25513
		// (get) Token: 0x06033038 RID: 208952
		// (set) Token: 0x06033039 RID: 208953
		IActivityRewardDataPage TabData { get; set; }

		// Token: 0x170063AA RID: 25514
		// (get) Token: 0x0603303A RID: 208954
		// (set) Token: 0x0603303B RID: 208955
		Action<int> TabFunction { get; set; }

		// Token: 0x170063AB RID: 25515
		// (get) Token: 0x0603303C RID: 208956
		// (set) Token: 0x0603303D RID: 208957
		Func<bool, int, bool> TabCanExecuteFunction { get; set; }
	}
}
