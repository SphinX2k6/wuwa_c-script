using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Generic
{
	// Token: 0x020009A1 RID: 2465
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class Comparer<[Nullable(2)] T> : IComparer, IComparer<T>
	{
		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060091D9 RID: 37337 RVA: 0x0016A78C File Offset: 0x0016898C
		public static Comparer<T> Default
		{
			get
			{
				Comparer<T> comparer = Comparer<T>.defaultComparer;
				if (comparer == null)
				{
					Interlocked.CompareExchange<Comparer<T>>(ref Comparer<T>.defaultComparer, Comparer<T>.CreateComparer(), null);
					comparer = Comparer<T>.defaultComparer;
				}
				return comparer;
			}
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x0016A7C0 File Offset: 0x001689C0
		private static Comparer<T> CreateComparer()
		{
			RuntimeType runtimeType = (RuntimeType)typeof(T);
			if (typeof(IComparable<T>).IsAssignableFrom(runtimeType))
			{
				return (Comparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(GenericComparer<>), runtimeType, null);
			}
			if (runtimeType.IsGenericType && runtimeType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				RuntimeType genericArgument = (RuntimeType)runtimeType.GetGenericArguments()[0];
				return (Comparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(NullableComparer<>), genericArgument, null);
			}
			if (runtimeType.IsEnum)
			{
				return (Comparer<T>)RuntimeType.CreateInstanceForAnotherGenericParameter(typeof(EnumComparer<>), runtimeType, null);
			}
			return new ObjectComparer<T>();
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x0016A86E File Offset: 0x00168A6E
		public static Comparer<T> Create(Comparison<T> comparison)
		{
			ArgumentNullException.ThrowIfNull(comparison, "comparison");
			return new ComparisonComparer<T>(comparison);
		}

		// Token: 0x060091DC RID: 37340
		[NullableContext(2)]
		public abstract int Compare(T x, T y);

		// Token: 0x060091DD RID: 37341 RVA: 0x0016A881 File Offset: 0x00168A81
		int IComparer.Compare(object x, object y)
		{
			if (x == null)
			{
				if (y != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				if (x is T && y is T)
				{
					return this.Compare((T)((object)x), (T)((object)y));
				}
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
				return 0;
			}
		}

		// Token: 0x04002259 RID: 8793
		private static volatile Comparer<T> defaultComparer;
	}
}
