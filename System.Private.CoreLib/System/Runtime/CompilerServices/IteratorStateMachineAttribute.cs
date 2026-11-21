using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006AE RID: 1710
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public sealed class IteratorStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x06007434 RID: 29748 RVA: 0x001126ED File Offset: 0x001108ED
		[NullableContext(1)]
		public IteratorStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
