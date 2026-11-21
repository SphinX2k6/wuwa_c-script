using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Reflection
{
	// Token: 0x02000739 RID: 1849
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomAttributeData
	{
		// Token: 0x0600789C RID: 30876 RVA: 0x0011E9F7 File Offset: 0x0011CBF7
		public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			return target.GetCustomAttributesData();
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x0011EA0A File Offset: 0x0011CC0A
		public static IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			return target.GetCustomAttributesData();
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x0011EA1D File Offset: 0x0011CC1D
		public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			return target.GetCustomAttributesData();
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x0011EA30 File Offset: 0x0011CC30
		public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			ArgumentNullException.ThrowIfNull(target, "target");
			return target.GetCustomAttributesData();
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x00005ACC File Offset: 0x00003CCC
		protected CustomAttributeData()
		{
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x0011EA44 File Offset: 0x0011CC44
		public unsafe override string ToString()
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.Append('[');
			valueStringBuilder.Append(this.Constructor.DeclaringType.FullName);
			valueStringBuilder.Append('(');
			bool flag = true;
			IList<CustomAttributeTypedArgument> constructorArguments = this.ConstructorArguments;
			int count = constructorArguments.Count;
			for (int i = 0; i < count; i++)
			{
				if (!flag)
				{
					valueStringBuilder.Append(", ");
				}
				valueStringBuilder.Append(constructorArguments[i].ToString());
				flag = false;
			}
			IList<CustomAttributeNamedArgument> namedArguments = this.NamedArguments;
			int count2 = namedArguments.Count;
			for (int j = 0; j < count2; j++)
			{
				if (!flag)
				{
					valueStringBuilder.Append(", ");
				}
				valueStringBuilder.Append(namedArguments[j].ToString());
				flag = false;
			}
			valueStringBuilder.Append(")]");
			return valueStringBuilder.ToString();
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x0009264E File Offset: 0x0009084E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060078A3 RID: 30883 RVA: 0x00014656 File Offset: 0x00012856
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x0011EB51 File Offset: 0x0011CD51
		public virtual Type AttributeType
		{
			get
			{
				return this.Constructor.DeclaringType;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x060078A5 RID: 30885 RVA: 0x0001A4BA File Offset: 0x000186BA
		public virtual ConstructorInfo Constructor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x0001A4BA File Offset: 0x000186BA
		public virtual IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060078A7 RID: 30887 RVA: 0x0001A4BA File Offset: 0x000186BA
		public virtual IList<CustomAttributeNamedArgument> NamedArguments
		{
			get
			{
				return null;
			}
		}
	}
}
