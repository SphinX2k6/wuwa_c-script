using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007B5 RID: 1973
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimePropertyBuilder : PropertyBuilder
	{
		// Token: 0x06007E46 RID: 32326 RVA: 0x0012AA1C File Offset: 0x00128C1C
		internal RuntimePropertyBuilder(RuntimeTypeBuilder tb, string name, PropertyAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.name = name;
			this.attrs = attributes;
			this.callingConvention = callingConvention;
			this.type = (returnType ?? typeof(void));
			this.returnModReq = returnModReq;
			this.returnModOpt = returnModOpt;
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			if (parameterTypes != null)
			{
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, this.parameters.Length);
			}
			this.typeb = tb;
			this.table_idx = tb.get_next_table_index(23, 1);
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x0012AAB9 File Offset: 0x00128CB9
		public override PropertyAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06007E48 RID: 32328 RVA: 0x0012AAC1 File Offset: 0x00128CC1
		public override bool CanRead
		{
			get
			{
				return this.get_method != null;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x0012AACF File Offset: 0x00128CCF
		public override bool CanWrite
		{
			get
			{
				return this.set_method != null;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06007E4A RID: 32330 RVA: 0x0012AADD File Offset: 0x00128CDD
		public override Type DeclaringType
		{
			get
			{
				return this.typeb;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x0012AAE5 File Offset: 0x00128CE5
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06007E4C RID: 32332 RVA: 0x0012AAED File Offset: 0x00128CED
		public override Type PropertyType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06007E4D RID: 32333 RVA: 0x0012AADD File Offset: 0x00128CDD
		public override Type ReflectedType
		{
			get
			{
				return this.typeb;
			}
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x0012AAF5 File Offset: 0x00128CF5
		protected override void AddOtherMethodCore(MethodBuilder mdBuilder)
		{
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.typeb.check_not_created();
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0001A4BA File Offset: 0x000186BA
		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			return null;
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x0012AB14 File Offset: 0x00128D14
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return this.get_method;
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override ParameterInfo[] GetIndexParameters()
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x0012AB1C File Offset: 0x00128D1C
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return this.set_method;
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override object GetValue(object obj, object[] index)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x0012AB24 File Offset: 0x00128D24
		protected override void SetConstantCore(object defaultValue)
		{
			this.typeb.check_not_created();
			this.def_value = defaultValue;
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x0012AB38 File Offset: 0x00128D38
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			this.typeb.check_not_created();
			if (con.ReflectedType.FullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= PropertyAttributes.SpecialName;
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

		// Token: 0x06007E5A RID: 32346 RVA: 0x0012ABCF File Offset: 0x00128DCF
		protected override void SetGetMethodCore(MethodBuilder mdBuilder)
		{
			this.typeb.check_not_created();
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.get_method = mdBuilder;
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x0012ABEE File Offset: 0x00128DEE
		protected override void SetSetMethodCore(MethodBuilder mdBuilder)
		{
			ArgumentNullException.ThrowIfNull(mdBuilder, "mdBuilder");
			this.set_method = mdBuilder;
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override void SetValue(object obj, object value, object[] index)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x0012AB0D File Offset: 0x00128D0D
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			throw RuntimePropertyBuilder.not_supported();
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x0012744C File Offset: 0x0012564C
		public override Module Module
		{
			get
			{
				return base.Module;
			}
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x00126C2D File Offset: 0x00124E2D
		private static NotSupportedException not_supported()
		{
			return new NotSupportedException(SR.NotSupported_DynamicModule);
		}

		// Token: 0x04001857 RID: 6231
		private PropertyAttributes attrs;

		// Token: 0x04001858 RID: 6232
		private string name;

		// Token: 0x04001859 RID: 6233
		private Type type;

		// Token: 0x0400185A RID: 6234
		private Type[] parameters;

		// Token: 0x0400185B RID: 6235
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x0400185C RID: 6236
		private object def_value;

		// Token: 0x0400185D RID: 6237
		private MethodBuilder set_method;

		// Token: 0x0400185E RID: 6238
		private MethodBuilder get_method;

		// Token: 0x0400185F RID: 6239
		private int table_idx;

		// Token: 0x04001860 RID: 6240
		internal RuntimeTypeBuilder typeb;

		// Token: 0x04001861 RID: 6241
		private Type[] returnModReq;

		// Token: 0x04001862 RID: 6242
		private Type[] returnModOpt;

		// Token: 0x04001863 RID: 6243
		private Type[][] paramModReq;

		// Token: 0x04001864 RID: 6244
		private Type[][] paramModOpt;

		// Token: 0x04001865 RID: 6245
		private CallingConventions callingConvention;
	}
}
