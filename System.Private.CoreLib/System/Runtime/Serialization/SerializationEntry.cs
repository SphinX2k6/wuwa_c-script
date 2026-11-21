using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x02000528 RID: 1320
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct SerializationEntry
	{
		// Token: 0x060048D8 RID: 18648 RVA: 0x000F1DCC File Offset: 0x000EFFCC
		internal SerializationEntry(string entryName, object entryValue, Type entryType)
		{
			this._name = entryName;
			this._value = entryValue;
			this._type = entryType;
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x000F1DE3 File Offset: 0x000EFFE3
		[Nullable(2)]
		public object Value
		{
			[NullableContext(2)]
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x000F1DEB File Offset: 0x000EFFEB
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x000F1DF3 File Offset: 0x000EFFF3
		public Type ObjectType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04001169 RID: 4457
		private readonly string _name;

		// Token: 0x0400116A RID: 4458
		private readonly object _value;

		// Token: 0x0400116B RID: 4459
		private readonly Type _type;
	}
}
