using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007A7 RID: 1959
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeFieldBuilder : FieldBuilder
	{
		// Token: 0x06007D17 RID: 32023 RVA: 0x0012713C File Offset: 0x0012533C
		[DynamicDependency("modOpt")]
		internal RuntimeFieldBuilder(RuntimeTypeBuilder tb, string fieldName, Type type, FieldAttributes attributes, Type[] modReq, Type[] modOpt)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			this.attrs = (attributes & ~(FieldAttributes.RTSpecialName | FieldAttributes.HasFieldMarshal | FieldAttributes.HasDefault | FieldAttributes.HasFieldRVA));
			this.name = fieldName;
			this.type = type;
			this.modReq = modReq;
			this.modOpt = modOpt;
			this.offset = -1;
			this.typeb = tb;
			((RuntimeModuleBuilder)tb.Module).RegisterToken(this, this.MetadataToken);
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06007D18 RID: 32024 RVA: 0x001271AB File Offset: 0x001253AB
		public override FieldAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06007D19 RID: 32025 RVA: 0x001271B3 File Offset: 0x001253B3
		public override Type DeclaringType
		{
			get
			{
				if (this.typeb.is_hidden_global_type)
				{
					return null;
				}
				return this.typeb;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06007D1A RID: 32026 RVA: 0x001271CA File Offset: 0x001253CA
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				throw RuntimeFieldBuilder.CreateNotSupportedException();
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06007D1B RID: 32027 RVA: 0x001271D1 File Offset: 0x001253D1
		public override Type FieldType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06007D1C RID: 32028 RVA: 0x001271D9 File Offset: 0x001253D9
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06007D1D RID: 32029 RVA: 0x001271E1 File Offset: 0x001253E1
		public override Type ReflectedType
		{
			get
			{
				return this.typeb;
			}
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x001271E9 File Offset: 0x001253E9
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.typeb.is_created)
			{
				return CustomAttribute.GetCustomAttributes(this, inherit);
			}
			throw RuntimeFieldBuilder.CreateNotSupportedException();
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x00127205 File Offset: 0x00125405
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.typeb.is_created)
			{
				return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
			}
			throw RuntimeFieldBuilder.CreateNotSupportedException();
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06007D20 RID: 32032 RVA: 0x00127222 File Offset: 0x00125422
		public override int MetadataToken
		{
			get
			{
				return ((RuntimeModuleBuilder)this.typeb.Module).GetToken(this);
			}
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x001271CA File Offset: 0x001253CA
		public override object GetValue(object obj)
		{
			throw RuntimeFieldBuilder.CreateNotSupportedException();
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x001271CA File Offset: 0x001253CA
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw RuntimeFieldBuilder.CreateNotSupportedException();
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x00007B65 File Offset: 0x00005D65
		internal override int GetFieldOffset()
		{
			return 0;
		}

		// Token: 0x06007D24 RID: 32036 RVA: 0x0012723A File Offset: 0x0012543A
		internal void SetRVAData(byte[] data)
		{
			this.attrs |= FieldAttributes.HasFieldRVA;
			this.rva_data = (byte[])data.Clone();
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x0012725F File Offset: 0x0012545F
		internal static PackingSize RVADataPackingSize(int size)
		{
			if (size % 8 == 0)
			{
				return PackingSize.Size8;
			}
			if (size % 4 == 0)
			{
				return PackingSize.Size4;
			}
			if (size % 2 == 0)
			{
				return PackingSize.Size2;
			}
			return PackingSize.Size1;
		}

		// Token: 0x06007D26 RID: 32038 RVA: 0x00127277 File Offset: 0x00125477
		protected override void SetConstantCore(object defaultValue)
		{
			this.RejectIfCreated();
			this.def_value = defaultValue;
		}

		// Token: 0x06007D27 RID: 32039 RVA: 0x00127288 File Offset: 0x00125488
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			this.RejectIfCreated();
			CustomAttributeBuilder customAttributeBuilder = new CustomAttributeBuilder(con, binaryAttribute);
			string fullName = con.ReflectedType.FullName;
			if (fullName == "System.Runtime.InteropServices.FieldOffsetAttribute")
			{
				this.offset = BinaryPrimitives.ReadInt32LittleEndian(binaryAttribute.Slice(2));
				return;
			}
			if (fullName == "System.NonSerializedAttribute")
			{
				this.attrs |= FieldAttributes.NotSerialized;
				return;
			}
			if (fullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= FieldAttributes.SpecialName;
				return;
			}
			if (fullName == "System.Runtime.InteropServices.MarshalAsAttribute")
			{
				this.attrs |= FieldAttributes.HasFieldMarshal;
				this.marshal_info = CustomAttributeBuilder.get_umarshal(customAttributeBuilder, true);
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

		// Token: 0x06007D28 RID: 32040 RVA: 0x0012738A File Offset: 0x0012558A
		protected override void SetOffsetCore(int iOffset)
		{
			this.RejectIfCreated();
			if (iOffset < 0)
			{
				throw new ArgumentException(SR.Argument_NegativeFieldOffsetNotPermitted);
			}
			this.offset = iOffset;
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x001271CA File Offset: 0x001253CA
		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw RuntimeFieldBuilder.CreateNotSupportedException();
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x00126C2D File Offset: 0x00124E2D
		private static NotSupportedException CreateNotSupportedException()
		{
			return new NotSupportedException(SR.NotSupported_DynamicModule);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x001273A8 File Offset: 0x001255A8
		private void RejectIfCreated()
		{
			if (this.typeb.is_created)
			{
				throw new InvalidOperationException(SR.InvalidOperation_TypeHasBeenCreated);
			}
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x001273C4 File Offset: 0x001255C4
		internal void ResolveUserTypes()
		{
			this.type = RuntimeTypeBuilder.ResolveUserType(this.type);
			RuntimeTypeBuilder.ResolveUserTypes(this.modReq);
			RuntimeTypeBuilder.ResolveUserTypes(this.modOpt);
			if (this.marshal_info != null)
			{
				this.marshal_info.marshaltyperef = RuntimeTypeBuilder.ResolveUserType(this.marshal_info.marshaltyperef);
			}
		}

		// Token: 0x06007D2D RID: 32045 RVA: 0x0012741C File Offset: 0x0012561C
		internal FieldInfo RuntimeResolve()
		{
			RuntimeTypeHandle declaringType = new RuntimeTypeHandle(this.typeb.CreateType() as RuntimeType);
			return FieldInfo.GetFieldFromHandle(this.handle, declaringType);
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06007D2E RID: 32046 RVA: 0x0012744C File Offset: 0x0012564C
		public override Module Module
		{
			get
			{
				return base.Module;
			}
		}

		// Token: 0x040017DA RID: 6106
		private FieldAttributes attrs;

		// Token: 0x040017DB RID: 6107
		private Type type;

		// Token: 0x040017DC RID: 6108
		private string name;

		// Token: 0x040017DD RID: 6109
		private object def_value;

		// Token: 0x040017DE RID: 6110
		private int offset;

		// Token: 0x040017DF RID: 6111
		internal RuntimeTypeBuilder typeb;

		// Token: 0x040017E0 RID: 6112
		private byte[] rva_data;

		// Token: 0x040017E1 RID: 6113
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040017E2 RID: 6114
		private UnmanagedMarshal marshal_info;

		// Token: 0x040017E3 RID: 6115
		private RuntimeFieldHandle handle;

		// Token: 0x040017E4 RID: 6116
		private Type[] modReq;

		// Token: 0x040017E5 RID: 6117
		private Type[] modOpt;
	}
}
