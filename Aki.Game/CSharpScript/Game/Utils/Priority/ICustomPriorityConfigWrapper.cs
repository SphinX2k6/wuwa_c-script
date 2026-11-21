using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02003488 RID: 13448
	[NullableContext(1)]
	internal interface ICustomPriorityConfigWrapper<[Nullable(0)] T> where T : struct, Enum
	{
		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x060224D6 RID: 140502
		// (set) Token: 0x060224D7 RID: 140503
		bool Enable { get; set; }

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x060224D8 RID: 140504
		// (set) Token: 0x060224D9 RID: 140505
		[Nullable(0)]
		T Enum { [NullableContext(0)] get; [NullableContext(0)] set; }

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x060224DA RID: 140506
		// (set) Token: 0x060224DB RID: 140507
		int Priority { get; set; }

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x060224DC RID: 140508
		// (set) Token: 0x060224DD RID: 140509
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

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x060224DE RID: 140510
		// (set) Token: 0x060224DF RID: 140511
		bool? EnterReentrant { get; set; }

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x060224E0 RID: 140512
		// (set) Token: 0x060224E1 RID: 140513
		bool? ForceEnterCallback { get; set; }

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x060224E2 RID: 140514
		// (set) Token: 0x060224E3 RID: 140515
		bool? CheckEnterValid { get; set; }

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x060224E4 RID: 140516
		// (set) Token: 0x060224E5 RID: 140517
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

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x060224E6 RID: 140518
		// (set) Token: 0x060224E7 RID: 140519
		bool? ForceExitCallback { get; set; }

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x060224E8 RID: 140520
		// (set) Token: 0x060224E9 RID: 140521
		bool? CheckExitValid { get; set; }

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x060224EA RID: 140522
		// (set) Token: 0x060224EB RID: 140523
		Func<bool, bool, string, bool> EnterWrapper { get; set; }

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x060224EC RID: 140524
		// (set) Token: 0x060224ED RID: 140525
		Func<bool, string, bool> ExitWrapper { get; set; }
	}
}
