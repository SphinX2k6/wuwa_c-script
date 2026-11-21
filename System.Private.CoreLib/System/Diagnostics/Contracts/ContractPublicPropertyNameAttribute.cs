using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x0200089C RID: 2204
	[NullableContext(1)]
	[Nullable(0)]
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class ContractPublicPropertyNameAttribute : Attribute
	{
		// Token: 0x060089AD RID: 35245 RVA: 0x0014E4D5 File Offset: 0x0014C6D5
		public ContractPublicPropertyNameAttribute(string name)
		{
			this._publicName = name;
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x0014E4E4 File Offset: 0x0014C6E4
		public string Name
		{
			get
			{
				return this._publicName;
			}
		}

		// Token: 0x04001E59 RID: 7769
		private readonly string _publicName;
	}
}
