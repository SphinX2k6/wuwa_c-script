using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003EE RID: 1006
	[NullableContext(1)]
	[Nullable(0)]
	public static class LazyInitializer
	{
		// Token: 0x06004037 RID: 16439 RVA: 0x000D66F9 File Offset: 0x000D48F9
		public static T EnsureInitialized<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>([Nullable(2)] [NotNull] ref T target) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target);
			}
			return result;
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x000D6710 File Offset: 0x000D4910
		private static T EnsureInitializedCore<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>([NotNull] ref T target) where T : class
		{
			try
			{
				Interlocked.CompareExchange<T>(ref target, Activator.CreateInstance<T>(), default(T));
			}
			catch (MissingMethodException)
			{
				throw new MissingMemberException(SR.Lazy_CreateValue_NoParameterlessCtorForT);
			}
			return target;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x000D6758 File Offset: 0x000D4958
		public static T EnsureInitialized<T>([Nullable(2)] [NotNull] ref T target, Func<T> valueFactory) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target, valueFactory);
			}
			return result;
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x000D6770 File Offset: 0x000D4970
		private static T EnsureInitializedCore<T>([NotNull] ref T target, Func<T> valueFactory) where T : class
		{
			T t = valueFactory();
			if (t == null)
			{
				throw new InvalidOperationException(SR.Lazy_StaticInit_InvalidOperation);
			}
			T value = t;
			Interlocked.CompareExchange<T>(ref target, value, default(T));
			return target;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x000D67AF File Offset: 0x000D49AF
		public static T EnsureInitialized<[Nullable(2), DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>([AllowNull] ref T target, ref bool initialized, [Nullable(2)] [NotNullIfNotNull("syncLock")] ref object syncLock)
		{
			if (Volatile.Read(ref initialized))
			{
				return target;
			}
			return LazyInitializer.EnsureInitializedCore<T>(ref target, ref initialized, ref syncLock);
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x000D67C8 File Offset: 0x000D49C8
		private static T EnsureInitializedCore<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T>([AllowNull] ref T target, ref bool initialized, [NotNull] ref object syncLock)
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (!Volatile.Read(ref initialized))
				{
					try
					{
						target = Activator.CreateInstance<T>();
					}
					catch (MissingMethodException)
					{
						throw new MissingMemberException(SR.Lazy_CreateValue_NoParameterlessCtorForT);
					}
					Volatile.Write(ref initialized, true);
				}
			}
			return target;
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x000D683C File Offset: 0x000D4A3C
		public static T EnsureInitialized<[Nullable(2)] T>([AllowNull] ref T target, ref bool initialized, [Nullable(2)] [NotNullIfNotNull("syncLock")] ref object syncLock, Func<T> valueFactory)
		{
			if (Volatile.Read(ref initialized))
			{
				return target;
			}
			return LazyInitializer.EnsureInitializedCore<T>(ref target, ref initialized, ref syncLock, valueFactory);
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x000D6858 File Offset: 0x000D4A58
		private static T EnsureInitializedCore<T>([AllowNull] ref T target, ref bool initialized, [NotNull] ref object syncLock, Func<T> valueFactory)
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (!Volatile.Read(ref initialized))
				{
					target = valueFactory();
					Volatile.Write(ref initialized, true);
				}
			}
			return target;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x000D68B4 File Offset: 0x000D4AB4
		public static T EnsureInitialized<T>([Nullable(2)] [NotNull] ref T target, [Nullable(2)] [NotNullIfNotNull("syncLock")] ref object syncLock, Func<T> valueFactory) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target, ref syncLock, valueFactory);
			}
			return result;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x000D68D0 File Offset: 0x000D4AD0
		private static T EnsureInitializedCore<T>([NotNull] ref T target, [NotNull] ref object syncLock, Func<T> valueFactory) where T : class
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (Volatile.Read<T>(ref target) == null)
				{
					Volatile.Write<T>(ref target, valueFactory());
					if (target == null)
					{
						throw new InvalidOperationException(SR.Lazy_StaticInit_InvalidOperation);
					}
				}
			}
			return target;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x000D6944 File Offset: 0x000D4B44
		private static object EnsureLockInitialized([NotNull] ref object syncLock)
		{
			object result;
			if ((result = syncLock) == null)
			{
				result = (Interlocked.CompareExchange(ref syncLock, new object(), null) ?? syncLock);
			}
			return result;
		}
	}
}
