using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02005F7C RID: 24444
	[NullableContext(1)]
	public interface IActivityTab
	{
		// Token: 0x17008FD7 RID: 36823
		// (get) Token: 0x0603E09E RID: 254110
		// (set) Token: 0x0603E09F RID: 254111
		IActivityRewardDataPage TabData { get; set; }

		// Token: 0x17008FD8 RID: 36824
		// (get) Token: 0x0603E0A0 RID: 254112
		// (set) Token: 0x0603E0A1 RID: 254113
		Action<int> TabFunction { get; set; }

		// Token: 0x17008FD9 RID: 36825
		// (get) Token: 0x0603E0A2 RID: 254114
		// (set) Token: 0x0603E0A3 RID: 254115
		Func<bool, int, bool> TabCanExecuteFunction { get; set; }
	}
}
