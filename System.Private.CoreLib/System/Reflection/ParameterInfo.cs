using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x0200076B RID: 1899
	[NullableContext(1)]
	[Nullable(0)]
	public class ParameterInfo : ICustomAttributeProvider, IObjectReference
	{
		// Token: 0x060079DB RID: 31195 RVA: 0x00005ACC File Offset: 0x00003CCC
		protected ParameterInfo()
		{
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x00121456 File Offset: 0x0011F656
		public virtual ParameterAttributes Attributes
		{
			get
			{
				return this.AttrsImpl;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x0012145E File Offset: 0x0011F65E
		public virtual MemberInfo Member
		{
			get
			{
				return this.MemberImpl;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x060079DE RID: 31198 RVA: 0x00121466 File Offset: 0x0011F666
		[Nullable(2)]
		public virtual string Name
		{
			[NullableContext(2)]
			get
			{
				return this.NameImpl;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x0012146E File Offset: 0x0011F66E
		public virtual Type ParameterType
		{
			get
			{
				return this.ClassImpl;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060079E0 RID: 31200 RVA: 0x00121476 File Offset: 0x0011F676
		public virtual int Position
		{
			get
			{
				return this.PositionImpl;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x060079E1 RID: 31201 RVA: 0x0012147E File Offset: 0x0011F67E
		public bool IsIn
		{
			get
			{
				return (this.Attributes & ParameterAttributes.In) > ParameterAttributes.None;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0012148B File Offset: 0x0011F68B
		public bool IsLcid
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Lcid) > ParameterAttributes.None;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x00121498 File Offset: 0x0011F698
		public bool IsOptional
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Optional) > ParameterAttributes.None;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x001214A6 File Offset: 0x0011F6A6
		public bool IsOut
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Out) > ParameterAttributes.None;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x001214B3 File Offset: 0x0011F6B3
		public bool IsRetval
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Retval) > ParameterAttributes.None;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Nullable(2)]
		public virtual object DefaultValue
		{
			[NullableContext(2)]
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x060079E7 RID: 31207 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Nullable(2)]
		public virtual object RawDefaultValue
		{
			[NullableContext(2)]
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060079E8 RID: 31208 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool HasDefaultValue
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x001214C0 File Offset: 0x0011F6C0
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			return false;
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x001214CE File Offset: 0x0011F6CE
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x001214D6 File Offset: 0x0011F6D6
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return Array.Empty<object>();
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x001214DD File Offset: 0x0011F6DD
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			ArgumentNullException.ThrowIfNull(attributeType, "attributeType");
			return Array.Empty<object>();
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x0001A563 File Offset: 0x00018763
		public virtual Type GetModifiedParameterType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x0001A550 File Offset: 0x00018750
		public virtual Type[] GetOptionalCustomModifiers()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x0001A550 File Offset: 0x00018750
		public virtual Type[] GetRequiredCustomModifiers()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x001214EF File Offset: 0x0011F6EF
		public virtual int MetadataToken
		{
			get
			{
				return 134217728;
			}
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x001214F8 File Offset: 0x0011F6F8
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public unsafe object GetRealObject(StreamingContext context)
		{
			if (this.MemberImpl == null)
			{
				throw new SerializationException(SR.Serialization_InsufficientState);
			}
			MemberTypes memberType = this.MemberImpl.MemberType;
			if (memberType != MemberTypes.Constructor && memberType != MemberTypes.Method)
			{
				if (memberType != MemberTypes.Property)
				{
					throw new SerializationException(SR.Serialization_NoParameterInfo);
				}
				ReadOnlySpan<ParameterInfo> readOnlySpan = ((PropertyInfo)this.MemberImpl).GetIndexParameters();
				if (this.PositionImpl > -1 && this.PositionImpl < readOnlySpan.Length)
				{
					return *readOnlySpan[this.PositionImpl];
				}
				throw new SerializationException(SR.Serialization_BadParameterInfo);
			}
			else if (this.PositionImpl == -1)
			{
				if (this.MemberImpl.MemberType == MemberTypes.Method)
				{
					return ((MethodInfo)this.MemberImpl).ReturnParameter;
				}
				throw new SerializationException(SR.Serialization_BadParameterInfo);
			}
			else
			{
				ReadOnlySpan<ParameterInfo> readOnlySpan = ((MethodBase)this.MemberImpl).GetParametersAsSpan();
				if (this.PositionImpl < readOnlySpan.Length)
				{
					return *readOnlySpan[this.PositionImpl];
				}
				throw new SerializationException(SR.Serialization_BadParameterInfo);
			}
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x001215FC File Offset: 0x0011F7FC
		public override string ToString()
		{
			string text = this.ParameterType.FormatTypeName();
			string name = this.Name;
			if (name != null)
			{
				return text + " " + name;
			}
			return text;
		}

		// Token: 0x040016F2 RID: 5874
		protected ParameterAttributes AttrsImpl;

		// Token: 0x040016F3 RID: 5875
		[Nullable(2)]
		protected Type ClassImpl;

		// Token: 0x040016F4 RID: 5876
		[Nullable(2)]
		protected object DefaultValueImpl;

		// Token: 0x040016F5 RID: 5877
		protected MemberInfo MemberImpl;

		// Token: 0x040016F6 RID: 5878
		[Nullable(2)]
		protected string NameImpl;

		// Token: 0x040016F7 RID: 5879
		protected int PositionImpl;

		// Token: 0x040016F8 RID: 5880
		private const int MetadataToken_ParamDef = 134217728;
	}
}
