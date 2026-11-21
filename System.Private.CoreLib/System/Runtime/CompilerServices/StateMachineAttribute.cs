using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006CB RID: 1739
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public class StateMachineAttribute : Attribute
	{
		// Token: 0x06007488 RID: 29832 RVA: 0x00115999 File Offset: 0x00113B99
		public StateMachineAttribute(Type stateMachineType)
		{
			this.StateMachineType = stateMachineType;
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06007489 RID: 29833 RVA: 0x001159A8 File Offset: 0x00113BA8
		public Type StateMachineType { get; }
	}
}
