using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B4 RID: 1972
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeParameterBuilder : ParameterBuilder
	{
		// Token: 0x06007E40 RID: 32320 RVA: 0x0012A860 File Offset: 0x00128A60
		[DynamicDependency("def_value")]
		internal RuntimeParameterBuilder(MethodBase mb, int pos, ParameterAttributes attributes, string strParamName)
		{
			this.name = strParamName;
			this.position = pos;
			this.attrs = attributes;
			this.methodb = mb;
			if (mb is DynamicMethod)
			{
				this.table_idx = 0;
				return;
			}
			this.table_idx = mb.get_next_table_index(8, 1);
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06007E41 RID: 32321 RVA: 0x0012A8AE File Offset: 0x00128AAE
		public override int Attributes
		{
			get
			{
				return (int)this.attrs;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06007E42 RID: 32322 RVA: 0x0012A8B6 File Offset: 0x00128AB6
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x0012A8BE File Offset: 0x00128ABE
		public override int Position
		{
			get
			{
				return this.position;
			}
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x0012A8C6 File Offset: 0x00128AC6
		public override void SetConstant(object defaultValue)
		{
			if (this.position > 0)
			{
				RuntimeTypeBuilder.SetConstantValue(this.methodb.GetParameterType(this.position - 1), defaultValue, ref defaultValue);
			}
			this.def_value = defaultValue;
			this.attrs |= ParameterAttributes.HasDefault;
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x0012A908 File Offset: 0x00128B08
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			CustomAttributeBuilder customAttributeBuilder = new CustomAttributeBuilder(con, binaryAttribute);
			string fullName = con.ReflectedType.FullName;
			if (fullName == "System.Runtime.InteropServices.InAttribute")
			{
				this.attrs |= ParameterAttributes.In;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.OutAttribute")
			{
				this.attrs |= ParameterAttributes.Out;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.OptionalAttribute")
			{
				this.attrs |= ParameterAttributes.Optional;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.MarshalAsAttribute")
			{
				this.attrs |= ParameterAttributes.HasFieldMarshal;
				this.marshal_info = CustomAttributeBuilder.get_umarshal(customAttributeBuilder, false);
				return;
			}
			if (fullName == "System.Runtime.InteropServices.DefaultParameterValueAttribute")
			{
				CustomAttributeBuilder.CustomAttributeInfo customAttributeInfo = CustomAttributeBuilder.decode_cattr(customAttributeBuilder);
				this.SetConstant(customAttributeInfo.ctorArgs[0]);
				return;
			}
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

		// Token: 0x0400184F RID: 6223
		private MethodBase methodb;

		// Token: 0x04001850 RID: 6224
		private string name;

		// Token: 0x04001851 RID: 6225
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001852 RID: 6226
		private UnmanagedMarshal marshal_info;

		// Token: 0x04001853 RID: 6227
		private ParameterAttributes attrs;

		// Token: 0x04001854 RID: 6228
		private int position;

		// Token: 0x04001855 RID: 6229
		private int table_idx;

		// Token: 0x04001856 RID: 6230
		private object def_value;
	}
}
