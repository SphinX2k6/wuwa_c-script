using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x0200455E RID: 17758
	public interface ICustomPriorityConfig<T> where T : struct, Enum
	{
		// Token: 0x17007559 RID: 30041
		// (get) Token: 0x0602DDCB RID: 187851
		// (set) Token: 0x0602DDCC RID: 187852
		bool Enable { get; set; }

		// Token: 0x1700755A RID: 30042
		// (get) Token: 0x0602DDCD RID: 187853
		// (set) Token: 0x0602DDCE RID: 187854
		T? Enum { get; set; }

		// Token: 0x1700755B RID: 30043
		// (get) Token: 0x0602DDCF RID: 187855
		// (set) Token: 0x0602DDD0 RID: 187856
		int? Priority { get; set; }

		// Token: 0x1700755C RID: 30044
		// (get) Token: 0x0602DDD1 RID: 187857
		// (set) Token: 0x0602DDD2 RID: 187858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Func<ICustomPriorityCallbackParam, bool> EnterCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700755D RID: 30045
		// (get) Token: 0x0602DDD3 RID: 187859
		// (set) Token: 0x0602DDD4 RID: 187860
		bool? EnterReentrant { get; set; }

		// Token: 0x1700755E RID: 30046
		// (get) Token: 0x0602DDD5 RID: 187861
		// (set) Token: 0x0602DDD6 RID: 187862
		bool? ForceEnterCallback { get; set; }

		// Token: 0x1700755F RID: 30047
		// (get) Token: 0x0602DDD7 RID: 187863
		// (set) Token: 0x0602DDD8 RID: 187864
		bool? CheckEnterValid { get; set; }

		// Token: 0x17007560 RID: 30048
		// (get) Token: 0x0602DDD9 RID: 187865
		// (set) Token: 0x0602DDDA RID: 187866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Func<ICustomPriorityCallbackParam, bool> ExitCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007561 RID: 30049
		// (get) Token: 0x0602DDDB RID: 187867
		// (set) Token: 0x0602DDDC RID: 187868
		bool? ForceExitCallback { get; set; }

		// Token: 0x17007562 RID: 30050
		// (get) Token: 0x0602DDDD RID: 187869
		// (set) Token: 0x0602DDDE RID: 187870
		bool? CheckExitValid { get; set; }
	}
}
