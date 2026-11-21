using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000737 RID: 1847
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ConstructorInfo : MethodBase
	{
		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x000070DD File Offset: 0x000052DD
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Constructor;
			}
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x0011E9B8 File Offset: 0x0011CBB8
		[NullableContext(1)]
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Invoke([Nullable(2)] object[] parameters)
		{
			return this.Invoke(BindingFlags.Default, null, parameters, null);
		}

		// Token: 0x06007896 RID: 30870
		[return: Nullable(1)]
		public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		// Token: 0x06007897 RID: 30871 RVA: 0x0011E9C4 File Offset: 0x0011CBC4
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x0011E9CD File Offset: 0x0011CBCD
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x0011699B File Offset: 0x00114B9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x0011E9D5 File Offset: 0x0011CBD5
		public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			return !(left == right);
		}

		// Token: 0x04001620 RID: 5664
		[Nullable(1)]
		public static readonly string ConstructorName = ".ctor";

		// Token: 0x04001621 RID: 5665
		[Nullable(1)]
		public static readonly string TypeConstructorName = ".cctor";
	}
}
