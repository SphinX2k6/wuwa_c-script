using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02003487 RID: 13447
	public class CustomPriorityConfig<T> : ICustomPriorityConfig<T> where T : struct, Enum
	{
		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x060224C1 RID: 140481 RVA: 0x009B7911 File Offset: 0x009B5B11
		// (set) Token: 0x060224C2 RID: 140482 RVA: 0x009B7919 File Offset: 0x009B5B19
		public bool Enable { get; set; }

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x060224C3 RID: 140483 RVA: 0x009B7922 File Offset: 0x009B5B22
		// (set) Token: 0x060224C4 RID: 140484 RVA: 0x009B792A File Offset: 0x009B5B2A
		public T? Enum { get; set; }

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x060224C5 RID: 140485 RVA: 0x009B7933 File Offset: 0x009B5B33
		// (set) Token: 0x060224C6 RID: 140486 RVA: 0x009B793B File Offset: 0x009B5B3B
		public int? Priority { get; set; }

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x060224C7 RID: 140487 RVA: 0x009B7944 File Offset: 0x009B5B44
		// (set) Token: 0x060224C8 RID: 140488 RVA: 0x009B794C File Offset: 0x009B5B4C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomPriorityCallbackParam, bool> EnterCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x060224C9 RID: 140489 RVA: 0x009B7955 File Offset: 0x009B5B55
		// (set) Token: 0x060224CA RID: 140490 RVA: 0x009B795D File Offset: 0x009B5B5D
		public bool? EnterReentrant { get; set; }

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x060224CB RID: 140491 RVA: 0x009B7966 File Offset: 0x009B5B66
		// (set) Token: 0x060224CC RID: 140492 RVA: 0x009B796E File Offset: 0x009B5B6E
		public bool? ForceEnterCallback { get; set; }

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x060224CD RID: 140493 RVA: 0x009B7977 File Offset: 0x009B5B77
		// (set) Token: 0x060224CE RID: 140494 RVA: 0x009B797F File Offset: 0x009B5B7F
		public bool? CheckEnterValid { get; set; }

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x060224CF RID: 140495 RVA: 0x009B7988 File Offset: 0x009B5B88
		// (set) Token: 0x060224D0 RID: 140496 RVA: 0x009B7990 File Offset: 0x009B5B90
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomPriorityCallbackParam, bool> ExitCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x060224D1 RID: 140497 RVA: 0x009B7999 File Offset: 0x009B5B99
		// (set) Token: 0x060224D2 RID: 140498 RVA: 0x009B79A1 File Offset: 0x009B5BA1
		public bool? ForceExitCallback { get; set; }

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x060224D3 RID: 140499 RVA: 0x009B79AA File Offset: 0x009B5BAA
		// (set) Token: 0x060224D4 RID: 140500 RVA: 0x009B79B2 File Offset: 0x009B5BB2
		public bool? CheckExitValid { get; set; }
	}
}
