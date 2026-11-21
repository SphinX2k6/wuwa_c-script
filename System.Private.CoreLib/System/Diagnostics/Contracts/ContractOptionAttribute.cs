using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x0200089F RID: 2207
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractOptionAttribute : Attribute
	{
		// Token: 0x060089B1 RID: 35249 RVA: 0x0014E4EC File Offset: 0x0014C6EC
		public ContractOptionAttribute(string category, string setting, bool enabled)
		{
			this._category = category;
			this._setting = setting;
			this._enabled = enabled;
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x0014E509 File Offset: 0x0014C709
		public ContractOptionAttribute(string category, string setting, string value)
		{
			this._category = category;
			this._setting = setting;
			this._value = value;
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060089B3 RID: 35251 RVA: 0x0014E526 File Offset: 0x0014C726
		public string Category
		{
			get
			{
				return this._category;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x0014E52E File Offset: 0x0014C72E
		public string Setting
		{
			get
			{
				return this._setting;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060089B5 RID: 35253 RVA: 0x0014E536 File Offset: 0x0014C736
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060089B6 RID: 35254 RVA: 0x0014E53E File Offset: 0x0014C73E
		[Nullable(2)]
		public string Value
		{
			[NullableContext(2)]
			get
			{
				return this._value;
			}
		}

		// Token: 0x04001E5A RID: 7770
		private readonly string _category;

		// Token: 0x04001E5B RID: 7771
		private readonly string _setting;

		// Token: 0x04001E5C RID: 7772
		private readonly bool _enabled;

		// Token: 0x04001E5D RID: 7773
		private readonly string _value;
	}
}
