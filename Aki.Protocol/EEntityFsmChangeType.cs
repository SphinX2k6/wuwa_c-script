using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001624 RID: 5668
	public enum EEntityFsmChangeType
	{
		// Token: 0x0400C15F RID: 49503
		[OriginalName("Enter")]
		Enter,
		// Token: 0x0400C160 RID: 49504
		[OriginalName("Exit")]
		Exit,
		// Token: 0x0400C161 RID: 49505
		[OriginalName("BindStart")]
		BindStart = 3,
		// Token: 0x0400C162 RID: 49506
		[OriginalName("BindEnd")]
		BindEnd,
		// Token: 0x0400C163 RID: 49507
		[OriginalName("Task")]
		Task
	}
}
