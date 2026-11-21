using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x02000897 RID: 2199
	[NullableContext(1)]
	[Nullable(0)]
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class ContractClassForAttribute : Attribute
	{
		// Token: 0x060089A6 RID: 35238 RVA: 0x0014E4A7 File Offset: 0x0014C6A7
		public ContractClassForAttribute(Type typeContractsAreFor)
		{
			this._typeIAmAContractFor = typeContractsAreFor;
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060089A7 RID: 35239 RVA: 0x0014E4B6 File Offset: 0x0014C6B6
		public Type TypeContractsAreFor
		{
			get
			{
				return this._typeIAmAContractFor;
			}
		}

		// Token: 0x04001E57 RID: 7767
		private readonly Type _typeIAmAContractFor;
	}
}
