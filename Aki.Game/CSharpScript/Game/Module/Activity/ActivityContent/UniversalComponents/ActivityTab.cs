using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F64 RID: 20324
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityTab : IActivityTab
	{
		// Token: 0x170063AC RID: 25516
		// (get) Token: 0x0603303E RID: 208958 RVA: 0x00E4C7F0 File Offset: 0x00E4A9F0
		// (set) Token: 0x0603303F RID: 208959 RVA: 0x00E4C7F8 File Offset: 0x00E4A9F8
		public IActivityRewardDataPage TabData { get; set; }

		// Token: 0x170063AD RID: 25517
		// (get) Token: 0x06033040 RID: 208960 RVA: 0x00E4C801 File Offset: 0x00E4AA01
		// (set) Token: 0x06033041 RID: 208961 RVA: 0x00E4C809 File Offset: 0x00E4AA09
		public Action<int> TabFunction { get; set; }

		// Token: 0x170063AE RID: 25518
		// (get) Token: 0x06033042 RID: 208962 RVA: 0x00E4C812 File Offset: 0x00E4AA12
		// (set) Token: 0x06033043 RID: 208963 RVA: 0x00E4C81A File Offset: 0x00E4AA1A
		public Func<bool, int, bool> TabCanExecuteFunction { get; set; }
	}
}
