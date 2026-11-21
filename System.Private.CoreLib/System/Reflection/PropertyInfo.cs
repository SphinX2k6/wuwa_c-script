using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000771 RID: 1905
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class PropertyInfo : MemberInfo
	{
		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x00027484 File Offset: 0x00025684
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Property;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06007A01 RID: 31233
		[Nullable(1)]
		public abstract Type PropertyType { [NullableContext(1)] get; }

		// Token: 0x06007A02 RID: 31234
		[NullableContext(1)]
		public abstract ParameterInfo[] GetIndexParameters();

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06007A03 RID: 31235
		public abstract PropertyAttributes Attributes { get; }

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06007A04 RID: 31236 RVA: 0x0012174F File Offset: 0x0011F94F
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & PropertyAttributes.SpecialName) > PropertyAttributes.None;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06007A05 RID: 31237
		public abstract bool CanRead { get; }

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06007A06 RID: 31238
		public abstract bool CanWrite { get; }

		// Token: 0x06007A07 RID: 31239 RVA: 0x00121760 File Offset: 0x0011F960
		[NullableContext(1)]
		public MethodInfo[] GetAccessors()
		{
			return this.GetAccessors(false);
		}

		// Token: 0x06007A08 RID: 31240
		[NullableContext(1)]
		public abstract MethodInfo[] GetAccessors(bool nonPublic);

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06007A09 RID: 31241 RVA: 0x00121769 File Offset: 0x0011F969
		public virtual MethodInfo GetMethod
		{
			get
			{
				return this.GetGetMethod(true);
			}
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00121772 File Offset: 0x0011F972
		public MethodInfo GetGetMethod()
		{
			return this.GetGetMethod(false);
		}

		// Token: 0x06007A0B RID: 31243
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x0012177B File Offset: 0x0011F97B
		public virtual MethodInfo SetMethod
		{
			get
			{
				return this.GetSetMethod(true);
			}
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x00121784 File Offset: 0x0011F984
		public MethodInfo GetSetMethod()
		{
			return this.GetSetMethod(false);
		}

		// Token: 0x06007A0E RID: 31246
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		// Token: 0x06007A0F RID: 31247 RVA: 0x0001A563 File Offset: 0x00018763
		[NullableContext(1)]
		public virtual Type GetModifiedPropertyType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0001A550 File Offset: 0x00018750
		[NullableContext(1)]
		public virtual Type[] GetOptionalCustomModifiers()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0001A550 File Offset: 0x00018750
		[NullableContext(1)]
		public virtual Type[] GetRequiredCustomModifiers()
		{
			return Type.EmptyTypes;
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0012178D File Offset: 0x0011F98D
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object GetValue(object obj)
		{
			return this.GetValue(obj, null);
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x00121797 File Offset: 0x0011F997
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual object GetValue(object obj, object[] index)
		{
			return this.GetValue(obj, BindingFlags.Default, null, index, null);
		}

		// Token: 0x06007A14 RID: 31252
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		// Token: 0x06007A15 RID: 31253 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual object GetConstantValue()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual object GetRawConstantValue()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x001217A4 File Offset: 0x0011F9A4
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
			this.SetValue(obj, value, null);
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x001217AF File Offset: 0x0011F9AF
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void SetValue(object obj, object value, object[] index)
		{
			this.SetValue(obj, value, BindingFlags.Default, null, index, null);
		}

		// Token: 0x06007A19 RID: 31257
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		// Token: 0x06007A1A RID: 31258 RVA: 0x001191DA File Offset: 0x001173DA
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x001191E3 File Offset: 0x001173E3
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x0011699B File Offset: 0x00114B9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x001217BD File Offset: 0x0011F9BD
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			return !(left == right);
		}
	}
}
