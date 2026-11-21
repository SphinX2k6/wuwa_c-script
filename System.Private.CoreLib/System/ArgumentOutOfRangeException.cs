using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000CE RID: 206
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ArgumentOutOfRangeException : ArgumentException
	{
		// Token: 0x060009E2 RID: 2530 RVA: 0x0001E5FE File Offset: 0x0001C7FE
		public ArgumentOutOfRangeException() : base(SR.Arg_ArgumentOutOfRangeException)
		{
			base.HResult = -2146233086;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001E616 File Offset: 0x0001C816
		[NullableContext(2)]
		public ArgumentOutOfRangeException(string paramName) : base(SR.Arg_ArgumentOutOfRangeException, paramName)
		{
			base.HResult = -2146233086;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0001E62F File Offset: 0x0001C82F
		[NullableContext(2)]
		public ArgumentOutOfRangeException(string paramName, string message) : base(message ?? SR.Arg_ArgumentOutOfRangeException, paramName)
		{
			base.HResult = -2146233086;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0001E64D File Offset: 0x0001C84D
		[NullableContext(2)]
		public ArgumentOutOfRangeException(string message, Exception innerException) : base(message ?? SR.Arg_ArgumentOutOfRangeException, innerException)
		{
			base.HResult = -2146233086;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0001E66B File Offset: 0x0001C86B
		[NullableContext(2)]
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message) : base(message ?? SR.Arg_ArgumentOutOfRangeException, paramName)
		{
			this._actualValue = actualValue;
			base.HResult = -2146233086;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0001E690 File Offset: 0x0001C890
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._actualValue = info.GetValue("ActualValue", typeof(object));
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0001E6B5 File Offset: 0x0001C8B5
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ActualValue", this._actualValue, typeof(object));
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0001E6DC File Offset: 0x0001C8DC
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (this._actualValue == null)
				{
					return message;
				}
				string text = SR.Format(SR.ArgumentOutOfRange_ActualValue, this._actualValue);
				if (message == null)
				{
					return text;
				}
				return message + "\r\n" + text;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0001E71C File Offset: 0x0001C91C
		[Nullable(2)]
		public virtual object ActualValue
		{
			[NullableContext(2)]
			get
			{
				return this._actualValue;
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0001E724 File Offset: 0x0001C924
		[DoesNotReturn]
		private static void ThrowZero<T>(T value, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeNonZero, paramName, value));
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0001E743 File Offset: 0x0001C943
		[DoesNotReturn]
		private static void ThrowNegative<T>(T value, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeNonNegative, paramName, value));
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0001E762 File Offset: 0x0001C962
		[DoesNotReturn]
		private static void ThrowNegativeOrZero<T>(T value, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeNonNegativeNonZero, paramName, value));
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0001E781 File Offset: 0x0001C981
		[DoesNotReturn]
		private static void ThrowGreater<T>(T value, T other, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeLessOrEqual, paramName, value, other));
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0001E7A6 File Offset: 0x0001C9A6
		[DoesNotReturn]
		private static void ThrowGreaterEqual<T>(T value, T other, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeLess, paramName, value, other));
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0001E7CB File Offset: 0x0001C9CB
		[DoesNotReturn]
		private static void ThrowLess<T>(T value, T other, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeGreaterOrEqual, paramName, value, other));
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		[DoesNotReturn]
		private static void ThrowLessEqual<T>(T value, T other, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeGreater, paramName, value, other));
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001E815 File Offset: 0x0001CA15
		[DoesNotReturn]
		private static void ThrowEqual<T>(T value, T other, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeNotEqual, paramName, value ?? "null", other ?? "null"));
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001E84C File Offset: 0x0001CA4C
		[DoesNotReturn]
		private static void ThrowNotEqual<T>(T value, T other, string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, value, SR.Format(SR.ArgumentOutOfRange_Generic_MustBeEqual, paramName, value ?? "null", other ?? "null"));
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001E883 File Offset: 0x0001CA83
		public static void ThrowIfZero<[Nullable(0)] T>(T value, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : INumberBase<T>
		{
			if (INumberBase<T>.IsZero(value))
			{
				ArgumentOutOfRangeException.ThrowZero<T>(value, paramName);
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0001E89A File Offset: 0x0001CA9A
		public static void ThrowIfNegative<[Nullable(0)] T>(T value, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : INumberBase<T>
		{
			if (INumberBase<T>.IsNegative(value))
			{
				ArgumentOutOfRangeException.ThrowNegative<T>(value, paramName);
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0001E8B1 File Offset: 0x0001CAB1
		public static void ThrowIfNegativeOrZero<[Nullable(0)] T>(T value, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : INumberBase<T>
		{
			if (INumberBase<T>.IsNegative(value) || INumberBase<T>.IsZero(value))
			{
				ArgumentOutOfRangeException.ThrowNegativeOrZero<T>(value, paramName);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0001E8D6 File Offset: 0x0001CAD6
		public static void ThrowIfEqual<[Nullable(0)] T>(T value, T other, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : IEquatable<T>
		{
			if (EqualityComparer<T>.Default.Equals(value, other))
			{
				ArgumentOutOfRangeException.ThrowEqual<T>(value, other, paramName);
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0001E8EE File Offset: 0x0001CAEE
		public static void ThrowIfNotEqual<[Nullable(0)] T>(T value, T other, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : IEquatable<T>
		{
			if (!EqualityComparer<T>.Default.Equals(value, other))
			{
				ArgumentOutOfRangeException.ThrowNotEqual<T>(value, other, paramName);
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001E906 File Offset: 0x0001CB06
		public static void ThrowIfGreaterThan<[Nullable(0)] T>(T value, T other, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : IComparable<T>
		{
			if (value.CompareTo(other) > 0)
			{
				ArgumentOutOfRangeException.ThrowGreater<T>(value, other, paramName);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001E921 File Offset: 0x0001CB21
		public static void ThrowIfGreaterThanOrEqual<[Nullable(0)] T>(T value, T other, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : IComparable<T>
		{
			if (value.CompareTo(other) >= 0)
			{
				ArgumentOutOfRangeException.ThrowGreaterEqual<T>(value, other, paramName);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001E93C File Offset: 0x0001CB3C
		public static void ThrowIfLessThan<[Nullable(0)] T>(T value, T other, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : IComparable<T>
		{
			if (value.CompareTo(other) < 0)
			{
				ArgumentOutOfRangeException.ThrowLess<T>(value, other, paramName);
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0001E957 File Offset: 0x0001CB57
		public static void ThrowIfLessThanOrEqual<[Nullable(0)] T>(T value, T other, [Nullable(2)] [CallerArgumentExpression("value")] string paramName = null) where T : IComparable<T>
		{
			if (value.CompareTo(other) <= 0)
			{
				ArgumentOutOfRangeException.ThrowLessEqual<T>(value, other, paramName);
			}
		}

		// Token: 0x040002D8 RID: 728
		private readonly object _actualValue;
	}
}
