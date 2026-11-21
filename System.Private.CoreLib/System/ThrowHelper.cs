using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	// Token: 0x020001C2 RID: 450
	[StackTraceHidden]
	internal static class ThrowHelper
	{
		// Token: 0x060021AC RID: 8620 RVA: 0x000668AE File Offset: 0x00064AAE
		[DoesNotReturn]
		internal static void ThrowArithmeticException(string message)
		{
			throw new ArithmeticException(message);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000668B6 File Offset: 0x00064AB6
		[DoesNotReturn]
		internal static void ThrowAccessViolationException()
		{
			throw new AccessViolationException();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000668BD File Offset: 0x00064ABD
		[DoesNotReturn]
		internal static void ThrowArrayTypeMismatchException()
		{
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000668C4 File Offset: 0x00064AC4
		[DoesNotReturn]
		internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType)
		{
			throw new ArgumentException(SR.Format(SR.Argument_InvalidTypeWithPointersNotSupported, targetType));
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000668D6 File Offset: 0x00064AD6
		[DoesNotReturn]
		internal static void ThrowIndexOutOfRangeException()
		{
			throw new IndexOutOfRangeException();
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x000668DD File Offset: 0x00064ADD
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException()
		{
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000668E4 File Offset: 0x00064AE4
		[DoesNotReturn]
		internal static void ThrowArgumentException_DestinationTooShort()
		{
			throw new ArgumentException(SR.Argument_DestinationTooShort, "destination");
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000668F5 File Offset: 0x00064AF5
		[DoesNotReturn]
		internal static void ThrowArgumentException_InvalidTimeSpanStyles()
		{
			throw new ArgumentException(SR.Argument_InvalidTimeSpanStyles, "styles");
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00066906 File Offset: 0x00064B06
		[DoesNotReturn]
		internal static void ThrowArgumentException_InvalidEnumValue<TEnum>(TEnum value, [CallerArgumentExpression("value")] string argumentName = "")
		{
			throw new ArgumentException(SR.Format(SR.Argument_InvalidEnumValue, value, typeof(TEnum).Name), argumentName);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0006692D File Offset: 0x00064B2D
		[DoesNotReturn]
		internal static void ThrowArgumentException_OverlapAlignmentMismatch()
		{
			throw new ArgumentException(SR.Argument_OverlapAlignmentMismatch);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00066939 File Offset: 0x00064B39
		[DoesNotReturn]
		internal static void ThrowArgumentException_CannotExtractScalar(ExceptionArgument argument)
		{
			throw ThrowHelper.GetArgumentException(ExceptionResource.Argument_CannotExtractScalar, argument);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00066943 File Offset: 0x00064B43
		[DoesNotReturn]
		internal static void ThrowArgumentException_TupleIncorrectType(object obj)
		{
			throw new ArgumentException(SR.Format(SR.ArgumentException_ValueTupleIncorrectType, obj.GetType()), "other");
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0006695F File Offset: 0x00064B5F
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_IndexMustBeLessException()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00066969 File Offset: 0x00064B69
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00066973 File Offset: 0x00064B73
		[DoesNotReturn]
		internal static void ThrowArgumentException_BadComparer(object comparer)
		{
			throw new ArgumentException(SR.Format(SR.Arg_BogusIComparer, comparer));
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00066985 File Offset: 0x00064B85
		[DoesNotReturn]
		internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00066990 File Offset: 0x00064B90
		[DoesNotReturn]
		internal static void ThrowValueArgumentOutOfRange_NeedNonNegNumException()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0006699A File Offset: 0x00064B9A
		[DoesNotReturn]
		internal static void ThrowLengthArgumentOutOfRange_ArgumentOutOfRange_NeedNonNegNum()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.length, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000669A5 File Offset: 0x00064BA5
		[DoesNotReturn]
		internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLessOrEqual()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000669AE File Offset: 0x00064BAE
		[DoesNotReturn]
		internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x000669B7 File Offset: 0x00064BB7
		[DoesNotReturn]
		internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000669C1 File Offset: 0x00064BC1
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_Year()
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(ExceptionArgument.year, ExceptionResource.ArgumentOutOfRange_Year);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000669CB File Offset: 0x00064BCB
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_Month(int month)
		{
			throw new ArgumentOutOfRangeException("month", month, SR.ArgumentOutOfRange_Month);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000669E2 File Offset: 0x00064BE2
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_DayNumber(int dayNumber)
		{
			throw new ArgumentOutOfRangeException("dayNumber", dayNumber, SR.ArgumentOutOfRange_DayNumber);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x000669F9 File Offset: 0x00064BF9
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_BadYearMonthDay()
		{
			throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00066A06 File Offset: 0x00064C06
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_BadHourMinuteSecond()
		{
			throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadHourMinuteSecond);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00066A13 File Offset: 0x00064C13
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_TimeSpanTooLong()
		{
			throw new ArgumentOutOfRangeException(null, SR.Overflow_TimeSpanTooLong);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00066A20 File Offset: 0x00064C20
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_RoundingDigits(string name)
		{
			throw new ArgumentOutOfRangeException(name, SR.ArgumentOutOfRange_RoundingDigits);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00066A2D File Offset: 0x00064C2D
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_RoundingDigits_MathF(string name)
		{
			throw new ArgumentOutOfRangeException(name, SR.ArgumentOutOfRange_RoundingDigits_MathF);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00066A3A File Offset: 0x00064C3A
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRange_Range<T>(string parameterName, T value, T minInclusive, T maxInclusive)
		{
			throw new ArgumentOutOfRangeException(parameterName, value, SR.Format(SR.ArgumentOutOfRange_Range, minInclusive, maxInclusive));
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00066A5E File Offset: 0x00064C5E
		[DoesNotReturn]
		internal static void ThrowOverflowException()
		{
			throw new OverflowException();
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0001000A File Offset: 0x0000E20A
		[DoesNotReturn]
		internal static void ThrowOverflowException_NegateTwosCompNum()
		{
			throw new OverflowException(SR.Overflow_NegateTwosCompNum);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00066A65 File Offset: 0x00064C65
		[DoesNotReturn]
		internal static void ThrowOverflowException_TimeSpanTooLong()
		{
			throw new OverflowException(SR.Overflow_TimeSpanTooLong);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00066A71 File Offset: 0x00064C71
		[DoesNotReturn]
		internal static void ThrowOverflowException_TimeSpanDuration()
		{
			throw new OverflowException(SR.Overflow_Duration);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00066A7D File Offset: 0x00064C7D
		[DoesNotReturn]
		internal static void ThrowArgumentException_Arg_CannotBeNaN()
		{
			throw new ArgumentException(SR.Arg_CannotBeNaN);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00066A89 File Offset: 0x00064C89
		[DoesNotReturn]
		internal static void ThrowArgumentException_Arg_CannotBeNaN(ExceptionArgument argument)
		{
			throw new ArgumentException(SR.Arg_CannotBeNaN, ThrowHelper.GetArgumentName(argument));
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00066A9B File Offset: 0x00064C9B
		[DoesNotReturn]
		internal static void ThrowWrongKeyTypeArgumentException<T>(T key, Type targetType)
		{
			throw ThrowHelper.GetWrongKeyTypeArgumentException(key, targetType);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00066AA9 File Offset: 0x00064CA9
		[DoesNotReturn]
		internal static void ThrowWrongValueTypeArgumentException<T>(T value, Type targetType)
		{
			throw ThrowHelper.GetWrongValueTypeArgumentException(value, targetType);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00066AB7 File Offset: 0x00064CB7
		private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key)
		{
			return new ArgumentException(SR.Format(SR.Argument_AddingDuplicateWithKey, key));
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00066AC9 File Offset: 0x00064CC9
		[DoesNotReturn]
		internal static void ThrowAddingDuplicateWithKeyArgumentException<T>(T key)
		{
			throw ThrowHelper.GetAddingDuplicateWithKeyArgumentException(key);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00066AD6 File Offset: 0x00064CD6
		[DoesNotReturn]
		internal static void ThrowKeyNotFoundException<T>(T key)
		{
			throw ThrowHelper.GetKeyNotFoundException(key);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00066AE3 File Offset: 0x00064CE3
		[DoesNotReturn]
		internal static void ThrowArgumentException(ExceptionResource resource)
		{
			throw ThrowHelper.GetArgumentException(resource);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00066AEB File Offset: 0x00064CEB
		[DoesNotReturn]
		internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument)
		{
			throw ThrowHelper.GetArgumentException(resource, argument);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00066AF4 File Offset: 0x00064CF4
		[DoesNotReturn]
		internal static void ThrowArgumentException_HandleNotSync(string paramName)
		{
			throw new ArgumentException(SR.Arg_HandleNotSync, paramName);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00066B01 File Offset: 0x00064D01
		[DoesNotReturn]
		internal static void ThrowArgumentException_HandleNotAsync(string paramName)
		{
			throw new ArgumentException(SR.Arg_HandleNotAsync, paramName);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00066B0E File Offset: 0x00064D0E
		[DoesNotReturn]
		internal static void ThrowArgumentNullException(ExceptionArgument argument)
		{
			throw new ArgumentNullException(ThrowHelper.GetArgumentName(argument));
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00066B1B File Offset: 0x00064D1B
		[DoesNotReturn]
		internal static void ThrowArgumentNullException(ExceptionArgument argument, ExceptionResource resource)
		{
			throw new ArgumentNullException(ThrowHelper.GetArgumentName(argument), ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x00066B2E File Offset: 0x00064D2E
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
		{
			throw new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument));
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00066B3B File Offset: 0x00064D3B
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(argument, resource);
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00066B44 File Offset: 0x00064D44
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, int paramNumber, ExceptionResource resource)
		{
			throw ThrowHelper.GetArgumentOutOfRangeException(argument, paramNumber, resource);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00066B4E File Offset: 0x00064D4E
		[DoesNotReturn]
		internal static void ThrowEndOfFileException()
		{
			throw ThrowHelper.CreateEndOfFileException();
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00066B55 File Offset: 0x00064D55
		internal static Exception CreateEndOfFileException()
		{
			return new EndOfStreamException(SR.IO_EOF_ReadBeyondEOF);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00066B61 File Offset: 0x00064D61
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00066B68 File Offset: 0x00064D68
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException(ExceptionResource resource)
		{
			throw ThrowHelper.GetInvalidOperationException(resource);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00066B70 File Offset: 0x00064D70
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException(ExceptionResource resource, Exception e)
		{
			throw new InvalidOperationException(ThrowHelper.GetResourceString(resource), e);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00066B7E File Offset: 0x00064D7E
		[DoesNotReturn]
		internal static void ThrowSerializationException(ExceptionResource resource)
		{
			throw new SerializationException(ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00066B8B File Offset: 0x00064D8B
		[DoesNotReturn]
		internal static void ThrowRankException(ExceptionResource resource)
		{
			throw new RankException(ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00066B98 File Offset: 0x00064D98
		[DoesNotReturn]
		internal static void ThrowNotSupportedException(ExceptionResource resource)
		{
			throw new NotSupportedException(ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00066BA5 File Offset: 0x00064DA5
		[DoesNotReturn]
		internal static void ThrowNotSupportedException_UnseekableStream()
		{
			throw new NotSupportedException(SR.NotSupported_UnseekableStream);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00066BB1 File Offset: 0x00064DB1
		[DoesNotReturn]
		internal static void ThrowNotSupportedException_UnreadableStream()
		{
			throw new NotSupportedException(SR.NotSupported_UnreadableStream);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00066BBD File Offset: 0x00064DBD
		[DoesNotReturn]
		internal static void ThrowNotSupportedException_UnwritableStream()
		{
			throw new NotSupportedException(SR.NotSupported_UnwritableStream);
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00066BC9 File Offset: 0x00064DC9
		[DoesNotReturn]
		internal static void ThrowObjectDisposedException(object instance)
		{
			throw new ObjectDisposedException((instance != null) ? instance.GetType().FullName : null);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00066BE1 File Offset: 0x00064DE1
		[DoesNotReturn]
		internal static void ThrowObjectDisposedException(Type type)
		{
			throw new ObjectDisposedException((type != null) ? type.FullName : null);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00066BF4 File Offset: 0x00064DF4
		[DoesNotReturn]
		internal static void ThrowObjectDisposedException_StreamClosed(string objectName)
		{
			throw new ObjectDisposedException(objectName, SR.ObjectDisposed_StreamClosed);
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00066C01 File Offset: 0x00064E01
		[DoesNotReturn]
		internal static void ThrowObjectDisposedException_FileClosed()
		{
			throw new ObjectDisposedException(null, SR.ObjectDisposed_FileClosed);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00066C0E File Offset: 0x00064E0E
		[DoesNotReturn]
		internal static void ThrowObjectDisposedException(ExceptionResource resource)
		{
			throw new ObjectDisposedException(null, ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0001A563 File Offset: 0x00018763
		[DoesNotReturn]
		internal static void ThrowNotSupportedException()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00066C1C File Offset: 0x00064E1C
		[DoesNotReturn]
		internal static void ThrowAggregateException(List<Exception> exceptions)
		{
			throw new AggregateException(exceptions);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00066C24 File Offset: 0x00064E24
		[DoesNotReturn]
		internal static void ThrowOutOfMemoryException()
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00066C2B File Offset: 0x00064E2B
		[DoesNotReturn]
		internal static void ThrowDivideByZeroException()
		{
			throw new DivideByZeroException();
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00066C32 File Offset: 0x00064E32
		[DoesNotReturn]
		internal static void ThrowOutOfMemoryException_StringTooLong()
		{
			throw new OutOfMemoryException(SR.OutOfMemory_StringTooLong);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00066C3E File Offset: 0x00064E3E
		[DoesNotReturn]
		internal static void ThrowOutOfMemoryException_LockEnter_WaiterCountOverflow()
		{
			throw new OutOfMemoryException(SR.Lock_Enter_WaiterCountOverflow_OutOfMemoryException);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00066C4A File Offset: 0x00064E4A
		[DoesNotReturn]
		internal static void ThrowArgumentException_Argument_IncompatibleArrayType()
		{
			throw new ArgumentException(SR.Argument_IncompatibleArrayType);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00066C56 File Offset: 0x00064E56
		[DoesNotReturn]
		internal static void ThrowArgumentException_InvalidHandle(string paramName)
		{
			throw new ArgumentException(SR.Arg_InvalidHandle, paramName);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00066C63 File Offset: 0x00064E63
		[DoesNotReturn]
		internal static void ThrowUnexpectedStateForKnownCallback(object state)
		{
			throw new ArgumentOutOfRangeException("state", state, SR.Argument_UnexpectedStateForKnownCallback);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00066C75 File Offset: 0x00064E75
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00066C81 File Offset: 0x00064E81
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00066C8D File Offset: 0x00064E8D
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_EnumCurrent(int index)
		{
			throw ThrowHelper.GetInvalidOperationException_EnumCurrent(index);
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00066C95 File Offset: 0x00064E95
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00066CA1 File Offset: 0x00064EA1
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00066CAD File Offset: 0x00064EAD
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_InvalidOperation_NoValue()
		{
			throw new InvalidOperationException(SR.InvalidOperation_NoValue);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00066CB9 File Offset: 0x00064EB9
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
		{
			throw new InvalidOperationException(SR.InvalidOperation_ConcurrentOperationsNotSupported);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00066CC5 File Offset: 0x00064EC5
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_HandleIsNotInitialized()
		{
			throw new InvalidOperationException(SR.InvalidOperation_HandleIsNotInitialized);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00066CD1 File Offset: 0x00064ED1
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_HandleIsNotPinned()
		{
			throw new InvalidOperationException(SR.InvalidOperation_HandleIsNotPinned);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00066CDD File Offset: 0x00064EDD
		[DoesNotReturn]
		internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count)
		{
			throw ThrowHelper.GetArraySegmentCtorValidationFailedException(array, offset, count);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00066CE7 File Offset: 0x00064EE7
		[DoesNotReturn]
		internal static void ThrowInvalidOperationException_InvalidUtf8()
		{
			throw new InvalidOperationException(SR.InvalidOperation_InvalidUtf8);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00066CF3 File Offset: 0x00064EF3
		[DoesNotReturn]
		internal static void ThrowFormatException_BadFormatSpecifier()
		{
			throw new FormatException(SR.Argument_BadFormatSpecifier);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00066CFF File Offset: 0x00064EFF
		[DoesNotReturn]
		internal static void ThrowFormatException_NeedSingleChar()
		{
			throw new FormatException(SR.Format_NeedSingleChar);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00066D0B File Offset: 0x00064F0B
		[DoesNotReturn]
		internal static void ThrowFormatException_BadBoolean(ReadOnlySpan<char> value)
		{
			throw new FormatException(SR.Format(SR.Format_BadBoolean, new string(value)));
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00066D22 File Offset: 0x00064F22
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException_PrecisionTooLarge()
		{
			throw new ArgumentOutOfRangeException("precision", SR.Format(SR.Argument_PrecisionTooLarge, 99));
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00066D3F File Offset: 0x00064F3F
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException_SymbolDoesNotFit()
		{
			throw new ArgumentOutOfRangeException("symbol", SR.Argument_BadFormatSpecifier);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00066D50 File Offset: 0x00064F50
		[DoesNotReturn]
		internal static void ThrowArgumentOutOfRangeException_NeedNonNegNum(string paramName)
		{
			throw new ArgumentOutOfRangeException(paramName, SR.ArgumentOutOfRange_NeedNonNegNum);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00066D5D File Offset: 0x00064F5D
		[DoesNotReturn]
		internal static void ArgumentOutOfRangeException_Enum_Value()
		{
			throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_Enum);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00066D70 File Offset: 0x00064F70
		[DoesNotReturn]
		internal static void ThrowApplicationException(int hr)
		{
			Exception ex = Marshal.GetExceptionForHR(hr);
			if (ex != null && !string.IsNullOrEmpty(ex.Message))
			{
				ex = new ApplicationException(ex.Message);
			}
			else
			{
				ex = new ApplicationException();
			}
			ex.HResult = hr;
			throw ex;
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00066DB0 File Offset: 0x00064FB0
		[DoesNotReturn]
		internal static void ThrowFormatInvalidString()
		{
			throw new FormatException(SR.Format_InvalidString);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00066DBC File Offset: 0x00064FBC
		[DoesNotReturn]
		internal static void ThrowFormatInvalidString(int offset, ExceptionResource resource)
		{
			throw new FormatException(SR.Format(SR.Format_InvalidStringWithOffsetAndReason, offset, ThrowHelper.GetResourceString(resource)));
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00066DD9 File Offset: 0x00064FD9
		[DoesNotReturn]
		internal static void ThrowFormatIndexOutOfRange()
		{
			throw new FormatException(SR.Format_IndexOutOfRange);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00066DE5 File Offset: 0x00064FE5
		[DoesNotReturn]
		internal static void ThrowSynchronizationLockException_LockExit()
		{
			throw new SynchronizationLockException(SR.Lock_Exit_SynchronizationLockException);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00066DF4 File Offset: 0x00064FF4
		internal static AmbiguousMatchException GetAmbiguousMatchException(MemberInfo memberInfo)
		{
			Type declaringType = memberInfo.DeclaringType;
			return new AmbiguousMatchException(SR.Format(SR.Arg_AmbiguousMatchException_MemberInfo, declaringType, memberInfo));
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00066E19 File Offset: 0x00065019
		internal static AmbiguousMatchException GetAmbiguousMatchException(Attribute attribute)
		{
			return new AmbiguousMatchException(SR.Format(SR.Arg_AmbiguousMatchException_Attribute, attribute));
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00066E2C File Offset: 0x0006502C
		private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count)
		{
			if (array == null)
			{
				return new ArgumentNullException("array");
			}
			if (offset < 0)
			{
				return new ArgumentOutOfRangeException("offset", SR.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (count < 0)
			{
				return new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_NeedNonNegNum);
			}
			return new ArgumentException(SR.Argument_InvalidOffLen);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00066E79 File Offset: 0x00065079
		private static ArgumentException GetArgumentException(ExceptionResource resource)
		{
			return new ArgumentException(ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00066E86 File Offset: 0x00065086
		private static InvalidOperationException GetInvalidOperationException(ExceptionResource resource)
		{
			return new InvalidOperationException(ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00066E93 File Offset: 0x00065093
		private static ArgumentException GetWrongKeyTypeArgumentException(object key, Type targetType)
		{
			return new ArgumentException(SR.Format(SR.Arg_WrongType, key, targetType), "key");
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00066EAB File Offset: 0x000650AB
		private static ArgumentException GetWrongValueTypeArgumentException(object value, Type targetType)
		{
			return new ArgumentException(SR.Format(SR.Arg_WrongType, value, targetType), "value");
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00066EC3 File Offset: 0x000650C3
		private static KeyNotFoundException GetKeyNotFoundException(object key)
		{
			return new KeyNotFoundException(SR.Format(SR.Arg_KeyNotFoundWithKey, key));
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00066ED5 File Offset: 0x000650D5
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			return new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument), ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00066EE8 File Offset: 0x000650E8
		private static ArgumentException GetArgumentException(ExceptionResource resource, ExceptionArgument argument)
		{
			return new ArgumentException(ThrowHelper.GetResourceString(resource), ThrowHelper.GetArgumentName(argument));
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00066EFB File Offset: 0x000650FB
		private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, int paramNumber, ExceptionResource resource)
		{
			return new ArgumentOutOfRangeException(ThrowHelper.GetArgumentName(argument) + "[" + paramNumber.ToString() + "]", ThrowHelper.GetResourceString(resource));
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00066F24 File Offset: 0x00065124
		private static InvalidOperationException GetInvalidOperationException_EnumCurrent(int index)
		{
			return new InvalidOperationException((index < 0) ? SR.InvalidOperation_EnumNotStarted : SR.InvalidOperation_EnumEnded);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00066F3C File Offset: 0x0006513C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName)
		{
			if (default(T) != null && value == null)
			{
				ThrowHelper.ThrowArgumentNullException(argName);
			}
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00066F62 File Offset: 0x00065162
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowForUnsupportedNumericsVectorBaseType<T>()
		{
			if (!Vector<T>.IsSupported)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			}
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00066F72 File Offset: 0x00065172
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowForUnsupportedIntrinsicsVector64BaseType<T>()
		{
			if (!Vector64<T>.IsSupported)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			}
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00066F82 File Offset: 0x00065182
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowForUnsupportedIntrinsicsVector128BaseType<T>()
		{
			if (!Vector128<T>.IsSupported)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			}
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00066F92 File Offset: 0x00065192
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowForUnsupportedIntrinsicsVector256BaseType<T>()
		{
			if (!Vector256<T>.IsSupported)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			}
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00066FA2 File Offset: 0x000651A2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ThrowForUnsupportedIntrinsicsVector512BaseType<T>()
		{
			if (!Vector512<T>.IsSupported)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			}
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x00066FB4 File Offset: 0x000651B4
		private static string GetArgumentName(ExceptionArgument argument)
		{
			switch (argument)
			{
			case ExceptionArgument.obj:
				return "obj";
			case ExceptionArgument.dictionary:
				return "dictionary";
			case ExceptionArgument.array:
				return "array";
			case ExceptionArgument.info:
				return "info";
			case ExceptionArgument.key:
				return "key";
			case ExceptionArgument.text:
				return "text";
			case ExceptionArgument.values:
				return "values";
			case ExceptionArgument.value:
				return "value";
			case ExceptionArgument.startIndex:
				return "startIndex";
			case ExceptionArgument.task:
				return "task";
			case ExceptionArgument.bytes:
				return "bytes";
			case ExceptionArgument.byteIndex:
				return "byteIndex";
			case ExceptionArgument.byteCount:
				return "byteCount";
			case ExceptionArgument.ch:
				return "ch";
			case ExceptionArgument.chars:
				return "chars";
			case ExceptionArgument.charIndex:
				return "charIndex";
			case ExceptionArgument.charCount:
				return "charCount";
			case ExceptionArgument.s:
				return "s";
			case ExceptionArgument.input:
				return "input";
			case ExceptionArgument.ownedMemory:
				return "ownedMemory";
			case ExceptionArgument.list:
				return "list";
			case ExceptionArgument.index:
				return "index";
			case ExceptionArgument.capacity:
				return "capacity";
			case ExceptionArgument.collection:
				return "collection";
			case ExceptionArgument.item:
				return "item";
			case ExceptionArgument.converter:
				return "converter";
			case ExceptionArgument.match:
				return "match";
			case ExceptionArgument.count:
				return "count";
			case ExceptionArgument.action:
				return "action";
			case ExceptionArgument.comparison:
				return "comparison";
			case ExceptionArgument.exceptions:
				return "exceptions";
			case ExceptionArgument.exception:
				return "exception";
			case ExceptionArgument.pointer:
				return "pointer";
			case ExceptionArgument.start:
				return "start";
			case ExceptionArgument.format:
				return "format";
			case ExceptionArgument.formats:
				return "formats";
			case ExceptionArgument.culture:
				return "culture";
			case ExceptionArgument.comparer:
				return "comparer";
			case ExceptionArgument.comparable:
				return "comparable";
			case ExceptionArgument.source:
				return "source";
			case ExceptionArgument.length:
				return "length";
			case ExceptionArgument.comparisonType:
				return "comparisonType";
			case ExceptionArgument.manager:
				return "manager";
			case ExceptionArgument.sourceBytesToCopy:
				return "sourceBytesToCopy";
			case ExceptionArgument.callBack:
				return "callBack";
			case ExceptionArgument.creationOptions:
				return "creationOptions";
			case ExceptionArgument.function:
				return "function";
			case ExceptionArgument.scheduler:
				return "scheduler";
			case ExceptionArgument.continuation:
				return "continuation";
			case ExceptionArgument.continuationAction:
				return "continuationAction";
			case ExceptionArgument.continuationFunction:
				return "continuationFunction";
			case ExceptionArgument.tasks:
				return "tasks";
			case ExceptionArgument.asyncResult:
				return "asyncResult";
			case ExceptionArgument.beginMethod:
				return "beginMethod";
			case ExceptionArgument.endMethod:
				return "endMethod";
			case ExceptionArgument.endFunction:
				return "endFunction";
			case ExceptionArgument.cancellationToken:
				return "cancellationToken";
			case ExceptionArgument.continuationOptions:
				return "continuationOptions";
			case ExceptionArgument.delay:
				return "delay";
			case ExceptionArgument.millisecondsDelay:
				return "millisecondsDelay";
			case ExceptionArgument.millisecondsTimeout:
				return "millisecondsTimeout";
			case ExceptionArgument.stateMachine:
				return "stateMachine";
			case ExceptionArgument.timeout:
				return "timeout";
			case ExceptionArgument.type:
				return "type";
			case ExceptionArgument.sourceIndex:
				return "sourceIndex";
			case ExceptionArgument.sourceArray:
				return "sourceArray";
			case ExceptionArgument.destinationIndex:
				return "destinationIndex";
			case ExceptionArgument.destinationArray:
				return "destinationArray";
			case ExceptionArgument.pHandle:
				return "pHandle";
			case ExceptionArgument.handle:
				return "handle";
			case ExceptionArgument.other:
				return "other";
			case ExceptionArgument.newSize:
				return "newSize";
			case ExceptionArgument.lengths:
				return "lengths";
			case ExceptionArgument.len:
				return "len";
			case ExceptionArgument.keys:
				return "keys";
			case ExceptionArgument.indices:
				return "indices";
			case ExceptionArgument.index1:
				return "index1";
			case ExceptionArgument.index2:
				return "index2";
			case ExceptionArgument.index3:
				return "index3";
			case ExceptionArgument.endIndex:
				return "endIndex";
			case ExceptionArgument.elementType:
				return "elementType";
			case ExceptionArgument.arrayIndex:
				return "arrayIndex";
			case ExceptionArgument.year:
				return "year";
			case ExceptionArgument.codePoint:
				return "codePoint";
			case ExceptionArgument.str:
				return "str";
			case ExceptionArgument.options:
				return "options";
			case ExceptionArgument.prefix:
				return "prefix";
			case ExceptionArgument.suffix:
				return "suffix";
			case ExceptionArgument.buffer:
				return "buffer";
			case ExceptionArgument.buffers:
				return "buffers";
			case ExceptionArgument.offset:
				return "offset";
			case ExceptionArgument.stream:
				return "stream";
			case ExceptionArgument.anyOf:
				return "anyOf";
			case ExceptionArgument.overlapped:
				return "overlapped";
			case ExceptionArgument.minimumBytes:
				return "minimumBytes";
			case ExceptionArgument.arrayType:
				return "arrayType";
			case ExceptionArgument.divisor:
				return "divisor";
			case ExceptionArgument.factor:
				return "factor";
			case ExceptionArgument.set:
				return "set";
			default:
				return "";
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000673B0 File Offset: 0x000655B0
		private static string GetResourceString(ExceptionResource resource)
		{
			switch (resource)
			{
			case ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual:
				return SR.ArgumentOutOfRange_IndexMustBeLessOrEqual;
			case ExceptionResource.ArgumentOutOfRange_IndexMustBeLess:
				return SR.ArgumentOutOfRange_IndexMustBeLess;
			case ExceptionResource.ArgumentOutOfRange_IndexCount:
				return SR.ArgumentOutOfRange_IndexCount;
			case ExceptionResource.ArgumentOutOfRange_IndexCountBuffer:
				return SR.ArgumentOutOfRange_IndexCountBuffer;
			case ExceptionResource.ArgumentOutOfRange_Count:
				return SR.ArgumentOutOfRange_Count;
			case ExceptionResource.ArgumentOutOfRange_Year:
				return SR.ArgumentOutOfRange_Year;
			case ExceptionResource.Arg_ArrayPlusOffTooSmall:
				return SR.Arg_ArrayPlusOffTooSmall;
			case ExceptionResource.Arg_ByteArrayTooSmallForValue:
				return SR.Arg_ByteArrayTooSmallForValue;
			case ExceptionResource.NotSupported_ReadOnlyCollection:
				return SR.NotSupported_ReadOnlyCollection;
			case ExceptionResource.Arg_RankMultiDimNotSupported:
				return SR.Arg_RankMultiDimNotSupported;
			case ExceptionResource.Arg_NonZeroLowerBound:
				return SR.Arg_NonZeroLowerBound;
			case ExceptionResource.ArgumentOutOfRange_GetCharCountOverflow:
				return SR.ArgumentOutOfRange_GetCharCountOverflow;
			case ExceptionResource.ArgumentOutOfRange_ListInsert:
				return SR.ArgumentOutOfRange_ListInsert;
			case ExceptionResource.ArgumentOutOfRange_NeedNonNegNum:
				return SR.ArgumentOutOfRange_NeedNonNegNum;
			case ExceptionResource.ArgumentOutOfRange_NotGreaterThanBufferLength:
				return SR.ArgumentOutOfRange_NotGreaterThanBufferLength;
			case ExceptionResource.ArgumentOutOfRange_SmallCapacity:
				return SR.ArgumentOutOfRange_SmallCapacity;
			case ExceptionResource.Argument_InvalidOffLen:
				return SR.Argument_InvalidOffLen;
			case ExceptionResource.Argument_CannotExtractScalar:
				return SR.Argument_CannotExtractScalar;
			case ExceptionResource.ArgumentOutOfRange_BiggerThanCollection:
				return SR.ArgumentOutOfRange_BiggerThanCollection;
			case ExceptionResource.Serialization_MissingKeys:
				return SR.Serialization_MissingKeys;
			case ExceptionResource.Serialization_NullKey:
				return SR.Serialization_NullKey;
			case ExceptionResource.NotSupported_KeyCollectionSet:
				return SR.NotSupported_KeyCollectionSet;
			case ExceptionResource.NotSupported_ValueCollectionSet:
				return SR.NotSupported_ValueCollectionSet;
			case ExceptionResource.InvalidOperation_NullArray:
				return SR.InvalidOperation_NullArray;
			case ExceptionResource.TaskT_TransitionToFinal_AlreadyCompleted:
				return SR.TaskT_TransitionToFinal_AlreadyCompleted;
			case ExceptionResource.TaskCompletionSourceT_TrySetException_NullException:
				return SR.TaskCompletionSourceT_TrySetException_NullException;
			case ExceptionResource.TaskCompletionSourceT_TrySetException_NoExceptions:
				return SR.TaskCompletionSourceT_TrySetException_NoExceptions;
			case ExceptionResource.NotSupported_StringComparison:
				return SR.NotSupported_StringComparison;
			case ExceptionResource.ConcurrentCollection_SyncRoot_NotSupported:
				return SR.ConcurrentCollection_SyncRoot_NotSupported;
			case ExceptionResource.Task_MultiTaskContinuation_NullTask:
				return SR.Task_MultiTaskContinuation_NullTask;
			case ExceptionResource.InvalidOperation_WrongAsyncResultOrEndCalledMultiple:
				return SR.InvalidOperation_WrongAsyncResultOrEndCalledMultiple;
			case ExceptionResource.Task_MultiTaskContinuation_EmptyTaskList:
				return SR.Task_MultiTaskContinuation_EmptyTaskList;
			case ExceptionResource.Task_Start_TaskCompleted:
				return SR.Task_Start_TaskCompleted;
			case ExceptionResource.Task_Start_Promise:
				return SR.Task_Start_Promise;
			case ExceptionResource.Task_Start_ContinuationTask:
				return SR.Task_Start_ContinuationTask;
			case ExceptionResource.Task_Start_AlreadyStarted:
				return SR.Task_Start_AlreadyStarted;
			case ExceptionResource.Task_RunSynchronously_Continuation:
				return SR.Task_RunSynchronously_Continuation;
			case ExceptionResource.Task_RunSynchronously_Promise:
				return SR.Task_RunSynchronously_Promise;
			case ExceptionResource.Task_RunSynchronously_TaskCompleted:
				return SR.Task_RunSynchronously_TaskCompleted;
			case ExceptionResource.Task_RunSynchronously_AlreadyStarted:
				return SR.Task_RunSynchronously_AlreadyStarted;
			case ExceptionResource.AsyncMethodBuilder_InstanceNotInitialized:
				return SR.AsyncMethodBuilder_InstanceNotInitialized;
			case ExceptionResource.Task_ContinueWith_ESandLR:
				return SR.Task_ContinueWith_ESandLR;
			case ExceptionResource.Task_ContinueWith_NotOnAnything:
				return SR.Task_ContinueWith_NotOnAnything;
			case ExceptionResource.Task_InvalidTimerTimeSpan:
				return SR.Task_InvalidTimerTimeSpan;
			case ExceptionResource.Task_Delay_InvalidMillisecondsDelay:
				return SR.Task_Delay_InvalidMillisecondsDelay;
			case ExceptionResource.Task_Dispose_NotCompleted:
				return SR.Task_Dispose_NotCompleted;
			case ExceptionResource.Task_ThrowIfDisposed:
				return SR.Task_ThrowIfDisposed;
			case ExceptionResource.Task_WaitMulti_NullTask:
				return SR.Task_WaitMulti_NullTask;
			case ExceptionResource.ArgumentException_OtherNotArrayOfCorrectLength:
				return SR.ArgumentException_OtherNotArrayOfCorrectLength;
			case ExceptionResource.ArgumentNull_Array:
				return SR.ArgumentNull_Array;
			case ExceptionResource.ArgumentNull_SafeHandle:
				return SR.ArgumentNull_SafeHandle;
			case ExceptionResource.ArgumentOutOfRange_EndIndexStartIndex:
				return SR.ArgumentOutOfRange_EndIndexStartIndex;
			case ExceptionResource.ArgumentOutOfRange_Enum:
				return SR.ArgumentOutOfRange_Enum;
			case ExceptionResource.ArgumentOutOfRange_HugeArrayNotSupported:
				return SR.ArgumentOutOfRange_HugeArrayNotSupported;
			case ExceptionResource.Argument_AddingDuplicate:
				return SR.Argument_AddingDuplicate;
			case ExceptionResource.Argument_InvalidArgumentForComparison:
				return SR.Argument_InvalidArgumentForComparison;
			case ExceptionResource.Arg_LowerBoundsMustMatch:
				return SR.Arg_LowerBoundsMustMatch;
			case ExceptionResource.Arg_MustBeType:
				return SR.Arg_MustBeType;
			case ExceptionResource.Arg_Need1DArray:
				return SR.Arg_Need1DArray;
			case ExceptionResource.Arg_Need2DArray:
				return SR.Arg_Need2DArray;
			case ExceptionResource.Arg_Need3DArray:
				return SR.Arg_Need3DArray;
			case ExceptionResource.Arg_NeedAtLeast1Rank:
				return SR.Arg_NeedAtLeast1Rank;
			case ExceptionResource.Arg_RankIndices:
				return SR.Arg_RankIndices;
			case ExceptionResource.Arg_RanksAndBounds:
				return SR.Arg_RanksAndBounds;
			case ExceptionResource.InvalidOperation_IComparerFailed:
				return SR.InvalidOperation_IComparerFailed;
			case ExceptionResource.NotSupported_FixedSizeCollection:
				return SR.NotSupported_FixedSizeCollection;
			case ExceptionResource.Rank_MultiDimNotSupported:
				return SR.Rank_MultiDimNotSupported;
			case ExceptionResource.Arg_TypeNotSupported:
				return SR.Arg_TypeNotSupported;
			case ExceptionResource.Argument_SpansMustHaveSameLength:
				return SR.Argument_SpansMustHaveSameLength;
			case ExceptionResource.Argument_InvalidFlag:
				return SR.Argument_InvalidFlag;
			case ExceptionResource.CancellationTokenSource_Disposed:
				return SR.CancellationTokenSource_Disposed;
			case ExceptionResource.Argument_AlignmentMustBePow2:
				return SR.Argument_AlignmentMustBePow2;
			case ExceptionResource.InvalidOperation_SpanOverlappedOperation:
				return SR.InvalidOperation_SpanOverlappedOperation;
			case ExceptionResource.InvalidOperation_TimeProviderNullLocalTimeZone:
				return SR.InvalidOperation_TimeProviderNullLocalTimeZone;
			case ExceptionResource.InvalidOperation_TimeProviderInvalidTimestampFrequency:
				return SR.InvalidOperation_TimeProviderInvalidTimestampFrequency;
			case ExceptionResource.Format_UnexpectedClosingBrace:
				return SR.Format_UnexpectedClosingBrace;
			case ExceptionResource.Format_UnclosedFormatItem:
				return SR.Format_UnclosedFormatItem;
			case ExceptionResource.Format_ExpectedAsciiDigit:
				return SR.Format_ExpectedAsciiDigit;
			case ExceptionResource.Argument_HasToBeArrayClass:
				return SR.Argument_HasToBeArrayClass;
			case ExceptionResource.InvalidOperation_IncompatibleComparer:
				return SR.InvalidOperation_IncompatibleComparer;
			default:
				return "";
			}
		}
	}
}
