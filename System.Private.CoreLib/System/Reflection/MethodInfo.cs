using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200075A RID: 1882
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MethodInfo : MethodBase
	{
		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06007948 RID: 31048 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Method;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06007949 RID: 31049 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual ParameterInfo ReturnParameter
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x0600794A RID: 31050 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Type ReturnType
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x0001A51E File Offset: 0x0001871E
		public override Type[] GetGenericArguments()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual MethodInfo GetGenericMethodDefinition()
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x0001A51E File Offset: 0x0001871E
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("If some of the generic arguments are annotated (either with DynamicallyAccessedMembersAttribute, or generic constraints), trimming can't validate that the requirements of those annotations are met.")]
		public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x0600794E RID: 31054
		public abstract MethodInfo GetBaseDefinition();

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x0600794F RID: 31055
		public abstract ICustomAttributeProvider ReturnTypeCustomAttributes { get; }

		// Token: 0x06007950 RID: 31056 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual Delegate CreateDelegate(Type delegateType)
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x0001A51E File Offset: 0x0001871E
		public virtual Delegate CreateDelegate(Type delegateType, [Nullable(2)] object target)
		{
			throw new NotSupportedException(SR.NotSupported_SubclassOverride);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x0011FF84 File Offset: 0x0011E184
		public T CreateDelegate<[Nullable(0)] T>() where T : Delegate
		{
			return (T)((object)this.CreateDelegate(typeof(T)));
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x0011FF9B File Offset: 0x0011E19B
		public T CreateDelegate<[Nullable(0)] T>([Nullable(2)] object target) where T : Delegate
		{
			return (T)((object)this.CreateDelegate(typeof(T), target));
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x0011E9C4 File Offset: 0x0011CBC4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x0011E9CD File Offset: 0x0011CBCD
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x0011699B File Offset: 0x00114B9B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(MethodInfo left, MethodInfo right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x0011FFB3 File Offset: 0x0011E1B3
		[NullableContext(2)]
		public static bool operator !=(MethodInfo left, MethodInfo right)
		{
			return !(left == right);
		}
	}
}
