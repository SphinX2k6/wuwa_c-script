using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000662 RID: 1634
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public sealed class AsyncIteratorStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x06007327 RID: 29479 RVA: 0x001126ED File Offset: 0x001108ED
		[NullableContext(1)]
		public AsyncIteratorStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
