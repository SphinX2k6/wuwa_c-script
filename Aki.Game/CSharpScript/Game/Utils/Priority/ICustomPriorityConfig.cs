using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02003486 RID: 13446
	public interface ICustomPriorityConfig<T> where T : struct, Enum
	{
		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x060224AD RID: 140461
		// (set) Token: 0x060224AE RID: 140462
		bool Enable { get; set; }

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x060224AF RID: 140463
		// (set) Token: 0x060224B0 RID: 140464
		T? Enum { get; set; }

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x060224B1 RID: 140465
		// (set) Token: 0x060224B2 RID: 140466
		int? Priority { get; set; }

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x060224B3 RID: 140467
		// (set) Token: 0x060224B4 RID: 140468
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

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x060224B5 RID: 140469
		// (set) Token: 0x060224B6 RID: 140470
		bool? EnterReentrant { get; set; }

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x060224B7 RID: 140471
		// (set) Token: 0x060224B8 RID: 140472
		bool? ForceEnterCallback { get; set; }

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x060224B9 RID: 140473
		// (set) Token: 0x060224BA RID: 140474
		bool? CheckEnterValid { get; set; }

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x060224BB RID: 140475
		// (set) Token: 0x060224BC RID: 140476
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

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x060224BD RID: 140477
		// (set) Token: 0x060224BE RID: 140478
		bool? ForceExitCallback { get; set; }

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x060224BF RID: 140479
		// (set) Token: 0x060224C0 RID: 140480
		bool? CheckExitValid { get; set; }
	}
}
