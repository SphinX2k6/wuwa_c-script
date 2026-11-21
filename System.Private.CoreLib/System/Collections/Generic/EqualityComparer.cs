using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	// Token: 0x020009A3 RID: 2467
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class EqualityComparer<[Nullable(2)] T> : IEqualityComparer, IEqualityComparer<T>
	{
		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060091E5 RID: 37349 RVA: 0x0016A908 File Offset: 0x00168B08
		public static EqualityComparer<T> Default
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				EqualityComparer<T> equalityComparer = EqualityComparer<T>.defaultComparer;
				if (equalityComparer == null)
				{
					Interlocked.CompareExchange<EqualityComparer<T>>(ref EqualityComparer<T>.defaultComparer, EqualityComparer<T>.CreateComparer(), null);
					equalityComparer = EqualityComparer<T>.defaultComparer;
				}
				return equalityComparer;
			}
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x0016A93C File Offset: 0x00168B3C
		private static EqualityComparer<T> CreateComparer()
		{
			RuntimeType runtimeType = (RuntimeType)typeof(T);
			if (runtimeType == typeof(string))
			{
				return (EqualityComparer<T>)new StringEqualityComparer();
			}
			if (typeof(IEquatable<T>).IsAssignableFrom(runtimeType))
			{
				return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(GenericEqualityComparer<>), runtimeType, null);
			}
			if (runtimeType.IsGenericType && runtimeType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				RuntimeType genericArgument = (RuntimeType)runtimeType.GetGenericArguments()[0];
				return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(NullableEqualityComparer<>), genericArgument, null);
			}
			if (runtimeType.IsEnum)
			{
				return (EqualityComparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(EnumEqualityComparer<>), runtimeType, null);
			}
			return new ObjectEqualityComparer<T>();
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x0016AA07 File Offset: 0x00168C07
		public static EqualityComparer<T> Create([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<T, T, bool> equals, [Nullable(new byte[]
		{
			2,
			1
		})] Func<T, int> getHashCode = null)
		{
			ArgumentNullException.ThrowIfNull(equals, "equals");
			if (getHashCode == null)
			{
				getHashCode = delegate(T _)
				{
					throw new NotSupportedException();
				};
			}
			return new DelegateEqualityComparer<T>(equals, getHashCode);
		}

		// Token: 0x060091E8 RID: 37352
		[NullableContext(2)]
		public abstract bool Equals(T x, T y);

		// Token: 0x060091E9 RID: 37353
		public abstract int GetHashCode([DisallowNull] T obj);

		// Token: 0x060091EA RID: 37354 RVA: 0x0016AA3F File Offset: 0x00168C3F
		int IEqualityComparer.GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			if (obj is T)
			{
				return this.GetHashCode((T)((object)obj));
			}
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			return 0;
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x0016AA63 File Offset: 0x00168C63
		bool IEqualityComparer.Equals(object x, object y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			if (x is T && y is T)
			{
				return this.Equals((T)((object)x), (T)((object)y));
			}
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
			return false;
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x0016AAA0 File Offset: 0x00168CA0
		internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
		{
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (this.Equals(array[i], value))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x0016AAD4 File Offset: 0x00168CD4
		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			int num = startIndex - count + 1;
			for (int i = startIndex; i >= num; i--)
			{
				if (this.Equals(array[i], value))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0400225A RID: 8794
		private static volatile EqualityComparer<T> defaultComparer;
	}
}
