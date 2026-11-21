using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007A6 RID: 1958
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeEventBuilder : EventBuilder
	{
		// Token: 0x06007D0F RID: 32015 RVA: 0x00126F93 File Offset: 0x00125193
		[DynamicDependency("table_idx")]
		internal RuntimeEventBuilder(RuntimeTypeBuilder tb, string eventName, EventAttributes eventAttrs, Type eventType)
		{
			this.name = eventName;
			this.attrs = eventAttrs;
			this.type = eventType;
			this.typeb = tb;
			this.table_idx = this.get_next_table_index(20, 1);
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x00126FC7 File Offset: 0x001251C7
		internal int get_next_table_index(int table, int count)
		{
			return this.typeb.get_next_table_index(table, count);
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x00126FD8 File Offset: 0x001251D8
		protected override void AddOtherMethodCore(MethodBuilder mdBuilder)
		{
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.RejectIfCreated();
			if (this.other_methods != null)
			{
				MethodBuilder[] array = new MethodBuilder[this.other_methods.Length + 1];
				this.other_methods.CopyTo(array, 0);
				this.other_methods = array;
			}
			else
			{
				this.other_methods = new MethodBuilder[1];
			}
			this.other_methods[this.other_methods.Length - 1] = mdBuilder;
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x00127042 File Offset: 0x00125242
		protected override void SetAddOnMethodCore(MethodBuilder mdBuilder)
		{
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.RejectIfCreated();
			this.add_method = mdBuilder;
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x0012705C File Offset: 0x0012525C
		protected override void SetRaiseMethodCore(MethodBuilder mdBuilder)
		{
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.RejectIfCreated();
			this.raise_method = mdBuilder;
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x00127076 File Offset: 0x00125276
		protected override void SetRemoveOnMethodCore(MethodBuilder mdBuilder)
		{
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.RejectIfCreated();
			this.remove_method = mdBuilder;
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x00127090 File Offset: 0x00125290
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			this.RejectIfCreated();
			if (con.ReflectedType.FullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= EventAttributes.SpecialName;
				return;
			}
			CustomAttributeBuilder customAttributeBuilder = new CustomAttributeBuilder(con, binaryAttribute);
			if (this.cattrs != null)
			{
				CustomAttributeBuilder[] array = new CustomAttributeBuilder[this.cattrs.Length + 1];
				this.cattrs.CopyTo(array, 0);
				array[this.cattrs.Length] = customAttributeBuilder;
				this.cattrs = array;
				return;
			}
			this.cattrs = new CustomAttributeBuilder[1];
			this.cattrs[0] = customAttributeBuilder;
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x00127122 File Offset: 0x00125322
		private void RejectIfCreated()
		{
			if (this.typeb.is_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_MethodBaked);
			}
		}

		// Token: 0x040017D0 RID: 6096
		internal string name;

		// Token: 0x040017D1 RID: 6097
		private Type type;

		// Token: 0x040017D2 RID: 6098
		private RuntimeTypeBuilder typeb;

		// Token: 0x040017D3 RID: 6099
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040017D4 RID: 6100
		internal MethodBuilder add_method;

		// Token: 0x040017D5 RID: 6101
		internal MethodBuilder remove_method;

		// Token: 0x040017D6 RID: 6102
		internal MethodBuilder raise_method;

		// Token: 0x040017D7 RID: 6103
		internal MethodBuilder[] other_methods;

		// Token: 0x040017D8 RID: 6104
		internal EventAttributes attrs;

		// Token: 0x040017D9 RID: 6105
		private int table_idx;
	}
}
