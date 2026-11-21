using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x02000896 RID: 2198
	[NullableContext(1)]
	[Nullable(0)]
	[Conditional("CONTRACTS_FULL")]
	[Conditional("DEBUG")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class ContractClassAttribute : Attribute
	{
		// Token: 0x060089A4 RID: 35236 RVA: 0x0014E490 File Offset: 0x0014C690
		public ContractClassAttribute(Type typeContainingContracts)
		{
			this._typeWithContracts = typeContainingContracts;
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060089A5 RID: 35237 RVA: 0x0014E49F File Offset: 0x0014C69F
		public Type TypeContainingContracts
		{
			get
			{
				return this._typeWithContracts;
			}
		}

		// Token: 0x04001E56 RID: 7766
		private readonly Type _typeWithContracts;
	}
}
