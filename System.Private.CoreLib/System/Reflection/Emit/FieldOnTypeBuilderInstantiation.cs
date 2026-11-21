using System;
using System.Globalization;

namespace System.Reflection.Emit
{
	// Token: 0x0200079F RID: 1951
	internal sealed class FieldOnTypeBuilderInstantiation : FieldInfo
	{
		// Token: 0x06007C49 RID: 31817 RVA: 0x00125ED5 File Offset: 0x001240D5
		internal FieldInfo RuntimeResolve()
		{
			return this._type.RuntimeResolve().GetField(this._field);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x00125EF0 File Offset: 0x001240F0
		internal static FieldInfo GetField(FieldInfo Field, TypeBuilderInstantiation type)
		{
			FieldInfo fieldInfo;
			if (type._hashtable.Contains(Field))
			{
				fieldInfo = (type._hashtable[Field] as FieldInfo);
			}
			else
			{
				fieldInfo = new FieldOnTypeBuilderInstantiation(Field, type);
				type._hashtable[Field] = fieldInfo;
			}
			return fieldInfo;
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00125F35 File Offset: 0x00124135
		internal FieldOnTypeBuilderInstantiation(FieldInfo field, TypeBuilderInstantiation type)
		{
			this._field = field;
			this._type = type;
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x000211FB File Offset: 0x0001F3FB
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Field;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06007C4D RID: 31821 RVA: 0x00125F4B File Offset: 0x0012414B
		public override string Name
		{
			get
			{
				return this._field.Name;
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06007C4E RID: 31822 RVA: 0x00125F58 File Offset: 0x00124158
		public override Type DeclaringType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06007C4F RID: 31823 RVA: 0x00125F58 File Offset: 0x00124158
		public override Type ReflectedType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x00125F60 File Offset: 0x00124160
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._field.GetCustomAttributes(inherit);
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x00125F6E File Offset: 0x0012416E
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this._field.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x00125F7D File Offset: 0x0012417D
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._field.IsDefined(attributeType, inherit);
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06007C53 RID: 31827 RVA: 0x00125F8C File Offset: 0x0012418C
		public override int MetadataToken
		{
			get
			{
				return this._field.MetadataToken;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06007C54 RID: 31828 RVA: 0x00125F99 File Offset: 0x00124199
		public override Module Module
		{
			get
			{
				return this._field.Module;
			}
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00125FA6 File Offset: 0x001241A6
		public override Type[] GetRequiredCustomModifiers()
		{
			return this._field.GetRequiredCustomModifiers();
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x00125FB3 File Offset: 0x001241B3
		public override Type[] GetOptionalCustomModifiers()
		{
			return this._field.GetOptionalCustomModifiers();
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public override void SetValueDirect(TypedReference obj, object value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public override object GetValueDirect(TypedReference obj)
		{
			throw new NotImplementedException();
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06007C59 RID: 31833 RVA: 0x00125FC0 File Offset: 0x001241C0
		public override RuntimeFieldHandle FieldHandle
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06007C5A RID: 31834 RVA: 0x00125FD2 File Offset: 0x001241D2
		public override Type FieldType
		{
			get
			{
				return this._field.FieldType;
			}
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x00066B61 File Offset: 0x00064D61
		public override object GetValue(object obj)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00066B61 File Offset: 0x00064D61
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06007C5D RID: 31837 RVA: 0x00125FDF File Offset: 0x001241DF
		public override FieldAttributes Attributes
		{
			get
			{
				return this._field.Attributes;
			}
		}

		// Token: 0x040017A9 RID: 6057
		private FieldInfo _field;

		// Token: 0x040017AA RID: 6058
		private TypeBuilderInstantiation _type;
	}
}
