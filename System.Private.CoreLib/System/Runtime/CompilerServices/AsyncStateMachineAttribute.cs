using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000666 RID: 1638
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public sealed class AsyncStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x06007334 RID: 29492 RVA: 0x001126ED File Offset: 0x001108ED
		[NullableContext(1)]
		public AsyncStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
