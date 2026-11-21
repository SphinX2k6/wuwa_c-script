using System;

namespace System.Diagnostics.Contracts
{
	// Token: 0x0200089B RID: 2203
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class ContractVerificationAttribute : Attribute
	{
		// Token: 0x060089AB RID: 35243 RVA: 0x0014E4BE File Offset: 0x0014C6BE
		public ContractVerificationAttribute(bool value)
		{
			this._value = value;
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x0014E4CD File Offset: 0x0014C6CD
		public bool Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x04001E58 RID: 7768
		private readonly bool _value;
	}
}
