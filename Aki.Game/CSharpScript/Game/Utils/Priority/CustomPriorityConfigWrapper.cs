using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02003489 RID: 13449
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	internal class CustomPriorityConfigWrapper<[Nullable(0)] T> : ICustomPriorityConfigWrapper<T> where T : struct, Enum
	{
		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x060224EE RID: 140526 RVA: 0x009B79C3 File Offset: 0x009B5BC3
		// (set) Token: 0x060224EF RID: 140527 RVA: 0x009B79CB File Offset: 0x009B5BCB
		public bool Enable { get; set; }

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x060224F0 RID: 140528 RVA: 0x009B79D4 File Offset: 0x009B5BD4
		// (set) Token: 0x060224F1 RID: 140529 RVA: 0x009B79DC File Offset: 0x009B5BDC
		[Nullable(0)]
		[RequiredMember]
		public T Enum { [NullableContext(0)] get; [NullableContext(0)] set; }

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x060224F2 RID: 140530 RVA: 0x009B79E5 File Offset: 0x009B5BE5
		// (set) Token: 0x060224F3 RID: 140531 RVA: 0x009B79ED File Offset: 0x009B5BED
		[RequiredMember]
		public int Priority { get; set; }

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x060224F4 RID: 140532 RVA: 0x009B79F6 File Offset: 0x009B5BF6
		// (set) Token: 0x060224F5 RID: 140533 RVA: 0x009B79FE File Offset: 0x009B5BFE
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

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x060224F6 RID: 140534 RVA: 0x009B7A07 File Offset: 0x009B5C07
		// (set) Token: 0x060224F7 RID: 140535 RVA: 0x009B7A0F File Offset: 0x009B5C0F
		public bool? EnterReentrant { get; set; }

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x060224F8 RID: 140536 RVA: 0x009B7A18 File Offset: 0x009B5C18
		// (set) Token: 0x060224F9 RID: 140537 RVA: 0x009B7A20 File Offset: 0x009B5C20
		public bool? ForceEnterCallback { get; set; }

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x060224FA RID: 140538 RVA: 0x009B7A29 File Offset: 0x009B5C29
		// (set) Token: 0x060224FB RID: 140539 RVA: 0x009B7A31 File Offset: 0x009B5C31
		public bool? CheckEnterValid { get; set; }

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x060224FC RID: 140540 RVA: 0x009B7A3A File Offset: 0x009B5C3A
		// (set) Token: 0x060224FD RID: 140541 RVA: 0x009B7A42 File Offset: 0x009B5C42
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

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x060224FE RID: 140542 RVA: 0x009B7A4B File Offset: 0x009B5C4B
		// (set) Token: 0x060224FF RID: 140543 RVA: 0x009B7A53 File Offset: 0x009B5C53
		public bool? ForceExitCallback { get; set; }

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x06022500 RID: 140544 RVA: 0x009B7A5C File Offset: 0x009B5C5C
		// (set) Token: 0x06022501 RID: 140545 RVA: 0x009B7A64 File Offset: 0x009B5C64
		public bool? CheckExitValid { get; set; }

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x06022502 RID: 140546 RVA: 0x009B7A6D File Offset: 0x009B5C6D
		// (set) Token: 0x06022503 RID: 140547 RVA: 0x009B7A75 File Offset: 0x009B5C75
		[RequiredMember]
		public Func<bool, bool, string, bool> EnterWrapper { get; set; }

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x06022504 RID: 140548 RVA: 0x009B7A7E File Offset: 0x009B5C7E
		// (set) Token: 0x06022505 RID: 140549 RVA: 0x009B7A86 File Offset: 0x009B5C86
		[RequiredMember]
		public Func<bool, string, bool> ExitWrapper { get; set; }

		// Token: 0x06022506 RID: 140550 RVA: 0x009B7A8F File Offset: 0x009B5C8F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CustomPriorityConfigWrapper()
		{
		}
	}
}
