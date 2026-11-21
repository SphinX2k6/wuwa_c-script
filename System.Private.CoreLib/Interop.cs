using System;
using System.Buffers;
using System.CodeDom.Compiler;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading;
using Internal.Win32.SafeHandles;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000002 RID: 2
internal static class Interop
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	internal unsafe static bool CallStringMethod<TArg1, TArg2, TArg3>(SpanFunc<char, TArg1, TArg2, TArg3, Interop.Globalization.ResultCode> interopCall, TArg1 arg1, TArg2 arg2, TArg3 arg3, out string result)
	{
		Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
		Interop.Globalization.ResultCode resultCode = interopCall(span, arg1, arg2, arg3);
		if (resultCode == Interop.Globalization.ResultCode.Success)
		{
			result = span.Slice(0, span.IndexOf('\0')).ToString();
			return true;
		}
		if (resultCode == Interop.Globalization.ResultCode.InsufficientBuffer)
		{
			span = new char[1280];
			if (interopCall(span, arg1, arg2, arg3) == Interop.Globalization.ResultCode.Success)
			{
				result = span.Slice(0, span.IndexOf('\0')).ToString();
				return true;
			}
		}
		result = null;
		return false;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020E8 File Offset: 0x000002E8
	internal unsafe static void GetRandomBytes(byte* buffer, int length)
	{
		Interop.BCrypt.NTSTATUS ntstatus = Interop.BCrypt.BCryptGenRandom(IntPtr.Zero, buffer, length, 2);
		if (ntstatus == Interop.BCrypt.NTSTATUS.STATUS_SUCCESS)
		{
			return;
		}
		if (ntstatus == (Interop.BCrypt.NTSTATUS)3221225495U)
		{
			throw new OutOfMemoryException();
		}
		throw new InvalidOperationException();
	}

	// Token: 0x02000003 RID: 3
	internal static class Globalization
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000211C File Offset: 0x0000031C
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetCalendars", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int GetCalendars(string localeName, CalendarId[] calendars, int calendarsCapacity)
		{
			int result;
			fixed (CalendarId* pinnableReference = ArrayMarshaller<CalendarId, CalendarId>.ManagedToUnmanagedIn.GetPinnableReference(calendars))
			{
				void* _calendars_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(localeName))
				{
					void* _localeName_native = (void*)pinnableReference2;
					result = Interop.Globalization.<GetCalendars>g____PInvoke|0_0((ushort*)_localeName_native, (CalendarId*)_calendars_native, calendarsCapacity);
				}
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000214C File Offset: 0x0000034C
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetCalendarInfo", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static Interop.Globalization.ResultCode GetCalendarInfo(string localeName, CalendarId calendarId, CalendarDataType calendarDataType, char* result, int resultCapacity)
		{
			Interop.Globalization.ResultCode result2;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
			{
				void* _localeName_native = (void*)pinnableReference;
				result2 = Interop.Globalization.<GetCalendarInfo>g____PInvoke|1_0((ushort*)_localeName_native, calendarId, calendarDataType, result, resultCapacity);
			}
			return result2;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002171 File Offset: 0x00000371
		internal unsafe static bool EnumCalendarInfo(method callback, bool localeName, void calendarId, char* calendarDataType, IntPtr context)
		{
			return Interop.Globalization.EnumCalendarInfo(callback, localeName, calendarId, calendarDataType, context);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002180 File Offset: 0x00000380
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_EnumCalendarInfo", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool EnumCalendarInfo(IntPtr callback, string localeName, CalendarId calendarId, CalendarDataType calendarDataType, IntPtr context)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
			{
				void* _localeName_native = (void*)pinnableReference;
				num = Interop.Globalization.<EnumCalendarInfo>g____PInvoke|3_0(callback, (ushort*)_localeName_native, calendarId, calendarDataType, context);
			}
			return num != 0;
		}

		// Token: 0x06000007 RID: 7
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLatestJapaneseEra")]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLatestJapaneseEra", ExactSpelling = true)]
		internal static extern int GetLatestJapaneseEra();

		// Token: 0x06000008 RID: 8 RVA: 0x000021A8 File Offset: 0x000003A8
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetJapaneseEraStartDate")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetJapaneseEraStartDate(int era, out int startYear, out int startMonth, out int startDay)
		{
			startYear = 0;
			startMonth = 0;
			startDay = 0;
			int num;
			fixed (int* ptr = &startDay)
			{
				int* _startDay_native = ptr;
				fixed (int* ptr2 = &startMonth)
				{
					int* _startMonth_native = ptr2;
					fixed (int* ptr3 = &startYear)
					{
						int* _startYear_native = ptr3;
						num = Interop.Globalization.<GetJapaneseEraStartDate>g____PInvoke|5_0(era, _startYear_native, _startMonth_native, _startDay_native);
					}
				}
			}
			return num != 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021E8 File Offset: 0x000003E8
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ChangeCase", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static void ChangeCase(char* src, int srcLen, char* dstBuffer, int dstBufferCapacity, [MarshalAs(UnmanagedType.Bool)] bool bToUpper)
		{
			int _bToUpper_native = (bToUpper > false) ? 1 : 0;
			Interop.Globalization.<ChangeCase>g____PInvoke|6_0(src, srcLen, dstBuffer, dstBufferCapacity, _bToUpper_native);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002208 File Offset: 0x00000408
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ChangeCaseInvariant", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static void ChangeCaseInvariant(char* src, int srcLen, char* dstBuffer, int dstBufferCapacity, [MarshalAs(UnmanagedType.Bool)] bool bToUpper)
		{
			int _bToUpper_native = (bToUpper > false) ? 1 : 0;
			Interop.Globalization.<ChangeCaseInvariant>g____PInvoke|7_0(src, srcLen, dstBuffer, dstBufferCapacity, _bToUpper_native);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002228 File Offset: 0x00000428
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ChangeCaseTurkish", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static void ChangeCaseTurkish(char* src, int srcLen, char* dstBuffer, int dstBufferCapacity, [MarshalAs(UnmanagedType.Bool)] bool bToUpper)
		{
			int _bToUpper_native = (bToUpper > false) ? 1 : 0;
			Interop.Globalization.<ChangeCaseTurkish>g____PInvoke|8_0(src, srcLen, dstBuffer, dstBufferCapacity, _bToUpper_native);
		}

		// Token: 0x0600000C RID: 12
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_InitOrdinalCasingPage", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_InitOrdinalCasingPage", ExactSpelling = true)]
		internal unsafe static extern void InitOrdinalCasingPage(int pageNumber, char* pTarget);

		// Token: 0x0600000D RID: 13 RVA: 0x00002248 File Offset: 0x00000448
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetSortHandle", StringMarshalling = StringMarshalling.Utf8)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static Interop.Globalization.ResultCode GetSortHandle(string localeName, out IntPtr sortHandle)
		{
			sortHandle = (IntPtr)0;
			Interop.Globalization.ResultCode result = Interop.Globalization.ResultCode.Success;
			Utf8StringMarshaller.ManagedToUnmanagedIn managedToUnmanagedIn = default(Utf8StringMarshaller.ManagedToUnmanagedIn);
			try
			{
				int num = 256;
				Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
				managedToUnmanagedIn.FromManaged(localeName, buffer);
				try
				{
					fixed (IntPtr* ptr = &sortHandle)
					{
						IntPtr* _sortHandle_native = ptr;
						result = Interop.Globalization.<GetSortHandle>g____PInvoke|10_0(managedToUnmanagedIn.ToUnmanaged(), _sortHandle_native);
					}
				}
				finally
				{
					IntPtr* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x0600000E RID: 14
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_CloseSortHandle")]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_CloseSortHandle", ExactSpelling = true)]
		internal static extern void CloseSortHandle(IntPtr handle);

		// Token: 0x0600000F RID: 15
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_CompareString", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_CompareString", ExactSpelling = true)]
		internal unsafe static extern int CompareString(IntPtr sortHandle, char* lpStr1, int cwStr1Len, char* lpStr2, int cwStr2Len, CompareOptions options);

		// Token: 0x06000010 RID: 16
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_IndexOf", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_IndexOf", ExactSpelling = true)]
		internal unsafe static extern int IndexOf(IntPtr sortHandle, char* target, int cwTargetLength, char* pSource, int cwSourceLength, CompareOptions options, int* matchLengthPtr);

		// Token: 0x06000011 RID: 17
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_LastIndexOf", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_LastIndexOf", ExactSpelling = true)]
		internal unsafe static extern int LastIndexOf(IntPtr sortHandle, char* target, int cwTargetLength, char* pSource, int cwSourceLength, CompareOptions options, int* matchLengthPtr);

		// Token: 0x06000012 RID: 18 RVA: 0x000022C4 File Offset: 0x000004C4
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_StartsWith", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool StartsWith(IntPtr sortHandle, char* target, int cwTargetLength, char* source, int cwSourceLength, CompareOptions options, int* matchedLength)
		{
			return Interop.Globalization.<StartsWith>g____PInvoke|15_0(sortHandle, target, cwTargetLength, source, cwSourceLength, options, matchedLength) != 0;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022D8 File Offset: 0x000004D8
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_EndsWith", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool EndsWith(IntPtr sortHandle, char* target, int cwTargetLength, char* source, int cwSourceLength, CompareOptions options, int* matchedLength)
		{
			return Interop.Globalization.<EndsWith>g____PInvoke|16_0(sortHandle, target, cwTargetLength, source, cwSourceLength, options, matchedLength) != 0;
		}

		// Token: 0x06000014 RID: 20
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetSortKey", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_GetSortKey", ExactSpelling = true)]
		internal unsafe static extern int GetSortKey(IntPtr sortHandle, char* str, int strLength, byte* sortKey, int sortKeyLength, CompareOptions options);

		// Token: 0x06000015 RID: 21
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetSortVersion")]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetSortVersion", ExactSpelling = true)]
		internal static extern int GetSortVersion(IntPtr sortHandle);

		// Token: 0x06000016 RID: 22
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_LoadICU")]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_LoadICU", ExactSpelling = true)]
		internal static extern int LoadICU();

		// Token: 0x06000017 RID: 23 RVA: 0x000022EC File Offset: 0x000004EC
		internal static void InitICUFunctions(IntPtr icuuc, IntPtr icuin, ReadOnlySpan<char> version, ReadOnlySpan<char> suffix)
		{
			Interop.Globalization.InitICUFunctions(icuuc, icuin, version.ToString(), (suffix.Length > 0) ? suffix.ToString() : null);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000231C File Offset: 0x0000051C
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_InitICUFunctions", StringMarshalling = StringMarshalling.Utf8)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static void InitICUFunctions(IntPtr icuuc, IntPtr icuin, string version, string suffix)
		{
			byte* _version_native = default(byte*);
			byte* _suffix_native = default(byte*);
			Utf8StringMarshaller.ManagedToUnmanagedIn managedToUnmanagedIn = default(Utf8StringMarshaller.ManagedToUnmanagedIn);
			Utf8StringMarshaller.ManagedToUnmanagedIn managedToUnmanagedIn2 = default(Utf8StringMarshaller.ManagedToUnmanagedIn);
			try
			{
				int num = 256;
				Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
				managedToUnmanagedIn.FromManaged(suffix, buffer);
				num = 256;
				buffer = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
				managedToUnmanagedIn2.FromManaged(version, buffer);
				_suffix_native = managedToUnmanagedIn.ToUnmanaged();
				_version_native = managedToUnmanagedIn2.ToUnmanaged();
				Interop.Globalization.<InitICUFunctions>g____PInvoke|23_0(icuuc, icuin, _version_native, _suffix_native);
			}
			finally
			{
				managedToUnmanagedIn.Free();
				managedToUnmanagedIn2.Free();
			}
		}

		// Token: 0x06000019 RID: 25
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetICUVersion")]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetICUVersion", ExactSpelling = true)]
		internal static extern int GetICUVersion();

		// Token: 0x0600001A RID: 26
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ToAscii", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_ToAscii", ExactSpelling = true)]
		internal unsafe static extern int ToAscii(uint flags, char* src, int srcLen, char* dstBuffer, int dstBufferCapacity);

		// Token: 0x0600001B RID: 27
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ToUnicode", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_ToUnicode", ExactSpelling = true)]
		internal unsafe static extern int ToUnicode(uint flags, char* src, int srcLen, char* dstBuffer, int dstBufferCapacity);

		// Token: 0x0600001C RID: 28 RVA: 0x000023CC File Offset: 0x000005CC
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleName", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetLocaleName(string localeName, char* value, int valueLength)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
			{
				void* _localeName_native = (void*)pinnableReference;
				num = Interop.Globalization.<GetLocaleName>g____PInvoke|29_0((ushort*)_localeName_native, value, valueLength);
			}
			return num != 0;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000023F4 File Offset: 0x000005F4
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleInfoString", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetLocaleInfoString(string localeName, uint localeStringData, char* value, int valueLength, string uiLocaleName = null)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(uiLocaleName))
			{
				void* _uiLocaleName_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(localeName))
				{
					void* _localeName_native = (void*)pinnableReference2;
					num = Interop.Globalization.<GetLocaleInfoString>g____PInvoke|30_0((ushort*)_localeName_native, localeStringData, value, valueLength, (ushort*)_uiLocaleName_native);
				}
			}
			return num != 0;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000242C File Offset: 0x0000062C
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_IsPredefinedLocale", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool IsPredefinedLocale(string localeName)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
			{
				void* _localeName_native = (void*)pinnableReference;
				num = Interop.Globalization.<IsPredefinedLocale>g____PInvoke|32_0((ushort*)_localeName_native);
			}
			return num != 0;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002450 File Offset: 0x00000650
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleTimeFormat", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetLocaleTimeFormat(string localeName, [MarshalAs(UnmanagedType.Bool)] bool shortFormat, char* value, int valueLength)
		{
			int _shortFormat_native = (shortFormat > false) ? 1 : 0;
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
			{
				void* _localeName_native = (void*)pinnableReference;
				num = Interop.Globalization.<GetLocaleTimeFormat>g____PInvoke|33_0((ushort*)_localeName_native, _shortFormat_native, value, valueLength);
			}
			return num != 0;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000247C File Offset: 0x0000067C
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleInfoInt", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetLocaleInfoInt(string localeName, uint localeNumberData, ref int value)
		{
			int num;
			fixed (int* ptr = &value)
			{
				int* _value_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
				{
					void* _localeName_native = (void*)pinnableReference;
					num = Interop.Globalization.<GetLocaleInfoInt>g____PInvoke|34_0((ushort*)_localeName_native, localeNumberData, _value_native);
				}
			}
			return num != 0;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000024AC File Offset: 0x000006AC
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleInfoGroupingSizes", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetLocaleInfoGroupingSizes(string localeName, uint localeGroupingData, ref int primaryGroupSize, ref int secondaryGroupSize)
		{
			int num;
			fixed (int* ptr = &secondaryGroupSize)
			{
				int* _secondaryGroupSize_native = ptr;
				fixed (int* ptr2 = &primaryGroupSize)
				{
					int* _primaryGroupSize_native = ptr2;
					fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
					{
						void* _localeName_native = (void*)pinnableReference;
						num = Interop.Globalization.<GetLocaleInfoGroupingSizes>g____PInvoke|35_0((ushort*)_localeName_native, localeGroupingData, _primaryGroupSize_native, _secondaryGroupSize_native);
					}
				}
			}
			return num != 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000024E8 File Offset: 0x000006E8
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocales", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int GetLocales([Out] char[] value, int valueLength)
		{
			int result;
			fixed (char* pinnableReference = ArrayMarshaller<char, char>.ManagedToUnmanagedIn.GetPinnableReference(value))
			{
				void* _value_native = (void*)pinnableReference;
				result = Interop.Globalization.<GetLocales>g____PInvoke|36_0((char*)_value_native, valueLength);
			}
			return result;
		}

		// Token: 0x06000023 RID: 35
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_IsNormalized", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_IsNormalized", ExactSpelling = true)]
		internal unsafe static extern int IsNormalized(NormalizationForm normalizationForm, char* src, int srcLen);

		// Token: 0x06000024 RID: 36
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_NormalizeString", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("System.Globalization.Native", CharSet = CharSet.Unicode, EntryPoint = "GlobalizationNative_NormalizeString", ExactSpelling = true)]
		internal unsafe static extern int NormalizeString(NormalizationForm normalizationForm, char* src, int srcLen, char* dstBuffer, int dstBufferCapacity);

		// Token: 0x06000025 RID: 37 RVA: 0x0000250C File Offset: 0x0000070C
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_WindowsIdToIanaId", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int WindowsIdToIanaId(string windowsId, IntPtr region, char* ianaId, int ianaIdLength)
		{
			int result;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(windowsId))
			{
				void* _windowsId_native = (void*)pinnableReference;
				result = Interop.Globalization.<WindowsIdToIanaId>g____PInvoke|42_0((ushort*)_windowsId_native, region, ianaId, ianaIdLength);
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002530 File Offset: 0x00000730
		[LibraryImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_IanaIdToWindowsId", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int IanaIdToWindowsId(string ianaId, char* windowsId, int windowsIdLength)
		{
			int result;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(ianaId))
			{
				void* _ianaId_native = (void*)pinnableReference;
				result = Interop.Globalization.<IanaIdToWindowsId>g____PInvoke|43_0((ushort*)_ianaId_native, windowsId, windowsIdLength);
			}
			return result;
		}

		// Token: 0x06000027 RID: 39
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetCalendars", ExactSpelling = true)]
		internal unsafe static extern int <GetCalendars>g____PInvoke|0_0(ushort* __localeName_native, CalendarId* __calendars_native, int __calendarsCapacity_native);

		// Token: 0x06000028 RID: 40
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetCalendarInfo", ExactSpelling = true)]
		internal unsafe static extern Interop.Globalization.ResultCode <GetCalendarInfo>g____PInvoke|1_0(ushort* __localeName_native, CalendarId __calendarId_native, CalendarDataType __calendarDataType_native, char* __result_native, int __resultCapacity_native);

		// Token: 0x06000029 RID: 41
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_EnumCalendarInfo", ExactSpelling = true)]
		internal unsafe static extern int <EnumCalendarInfo>g____PInvoke|3_0(IntPtr __callback_native, ushort* __localeName_native, CalendarId __calendarId_native, CalendarDataType __calendarDataType_native, IntPtr __context_native);

		// Token: 0x0600002A RID: 42
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetJapaneseEraStartDate", ExactSpelling = true)]
		internal unsafe static extern int <GetJapaneseEraStartDate>g____PInvoke|5_0(int __era_native, int* __startYear_native, int* __startMonth_native, int* __startDay_native);

		// Token: 0x0600002B RID: 43
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ChangeCase", ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static extern void <ChangeCase>g____PInvoke|6_0(char* __src_native, int __srcLen_native, char* __dstBuffer_native, int __dstBufferCapacity_native, int __bToUpper_native);

		// Token: 0x0600002C RID: 44
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ChangeCaseInvariant", ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static extern void <ChangeCaseInvariant>g____PInvoke|7_0(char* __src_native, int __srcLen_native, char* __dstBuffer_native, int __dstBufferCapacity_native, int __bToUpper_native);

		// Token: 0x0600002D RID: 45
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_ChangeCaseTurkish", ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static extern void <ChangeCaseTurkish>g____PInvoke|8_0(char* __src_native, int __srcLen_native, char* __dstBuffer_native, int __dstBufferCapacity_native, int __bToUpper_native);

		// Token: 0x0600002E RID: 46
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetSortHandle", ExactSpelling = true)]
		internal unsafe static extern Interop.Globalization.ResultCode <GetSortHandle>g____PInvoke|10_0(byte* __localeName_native, IntPtr* __sortHandle_native);

		// Token: 0x0600002F RID: 47
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_StartsWith", ExactSpelling = true)]
		internal unsafe static extern int <StartsWith>g____PInvoke|15_0(IntPtr __sortHandle_native, char* __target_native, int __cwTargetLength_native, char* __source_native, int __cwSourceLength_native, CompareOptions __options_native, int* __matchedLength_native);

		// Token: 0x06000030 RID: 48
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_EndsWith", ExactSpelling = true)]
		internal unsafe static extern int <EndsWith>g____PInvoke|16_0(IntPtr __sortHandle_native, char* __target_native, int __cwTargetLength_native, char* __source_native, int __cwSourceLength_native, CompareOptions __options_native, int* __matchedLength_native);

		// Token: 0x06000031 RID: 49
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_InitICUFunctions", ExactSpelling = true)]
		internal unsafe static extern void <InitICUFunctions>g____PInvoke|23_0(IntPtr __icuuc_native, IntPtr __icuin_native, byte* __version_native, byte* __suffix_native);

		// Token: 0x06000032 RID: 50
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleName", ExactSpelling = true)]
		internal unsafe static extern int <GetLocaleName>g____PInvoke|29_0(ushort* __localeName_native, char* __value_native, int __valueLength_native);

		// Token: 0x06000033 RID: 51
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleInfoString", ExactSpelling = true)]
		internal unsafe static extern int <GetLocaleInfoString>g____PInvoke|30_0(ushort* __localeName_native, uint __localeStringData_native, char* __value_native, int __valueLength_native, ushort* __uiLocaleName_native);

		// Token: 0x06000034 RID: 52
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_IsPredefinedLocale", ExactSpelling = true)]
		internal unsafe static extern int <IsPredefinedLocale>g____PInvoke|32_0(ushort* __localeName_native);

		// Token: 0x06000035 RID: 53
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleTimeFormat", ExactSpelling = true)]
		internal unsafe static extern int <GetLocaleTimeFormat>g____PInvoke|33_0(ushort* __localeName_native, int __shortFormat_native, char* __value_native, int __valueLength_native);

		// Token: 0x06000036 RID: 54
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleInfoInt", ExactSpelling = true)]
		internal unsafe static extern int <GetLocaleInfoInt>g____PInvoke|34_0(ushort* __localeName_native, uint __localeNumberData_native, int* __value_native);

		// Token: 0x06000037 RID: 55
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocaleInfoGroupingSizes", ExactSpelling = true)]
		internal unsafe static extern int <GetLocaleInfoGroupingSizes>g____PInvoke|35_0(ushort* __localeName_native, uint __localeGroupingData_native, int* __primaryGroupSize_native, int* __secondaryGroupSize_native);

		// Token: 0x06000038 RID: 56
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_GetLocales", ExactSpelling = true)]
		internal unsafe static extern int <GetLocales>g____PInvoke|36_0(char* __value_native, int __valueLength_native);

		// Token: 0x06000039 RID: 57
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_WindowsIdToIanaId", ExactSpelling = true)]
		internal unsafe static extern int <WindowsIdToIanaId>g____PInvoke|42_0(ushort* __windowsId_native, IntPtr __region_native, char* __ianaId_native, int __ianaIdLength_native);

		// Token: 0x0600003A RID: 58
		[CompilerGenerated]
		[DllImport("System.Globalization.Native", EntryPoint = "GlobalizationNative_IanaIdToWindowsId", ExactSpelling = true)]
		internal unsafe static extern int <IanaIdToWindowsId>g____PInvoke|43_0(ushort* __ianaId_native, char* __windowsId_native, int __windowsIdLength_native);

		// Token: 0x02000004 RID: 4
		internal enum ResultCode
		{
			// Token: 0x04000002 RID: 2
			Success,
			// Token: 0x04000003 RID: 3
			UnknownError,
			// Token: 0x04000004 RID: 4
			InsufficientBuffer,
			// Token: 0x04000005 RID: 5
			OutOfMemory,
			// Token: 0x04000006 RID: 6
			InvalidCodePoint
		}
	}

	// Token: 0x02000005 RID: 5
	internal enum BOOL
	{
		// Token: 0x04000008 RID: 8
		FALSE,
		// Token: 0x04000009 RID: 9
		TRUE
	}

	// Token: 0x02000006 RID: 6
	internal static class Kernel32
	{
		// Token: 0x0600003B RID: 59
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		internal unsafe static extern int LCIDToLocaleName(int locale, char* pLocaleName, int cchName, uint dwFlags);

		// Token: 0x0600003C RID: 60 RVA: 0x00002554 File Offset: 0x00000754
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int LocaleNameToLCID(string lpName, uint dwFlags)
		{
			int result;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpName))
			{
				void* _lpName_native = (void*)pinnableReference;
				result = Interop.Kernel32.<LocaleNameToLCID>g____PInvoke|26_0((ushort*)_lpName_native, dwFlags);
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002578 File Offset: 0x00000778
		[LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int LCMapStringEx(string lpLocaleName, uint dwMapFlags, char* lpSrcStr, int cchSrc, void* lpDestStr, int cchDest, void* lpVersionInformation, void* lpReserved, IntPtr sortHandle)
		{
			int result;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpLocaleName))
			{
				void* _lpLocaleName_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<LCMapStringEx>g____PInvoke|27_0((ushort*)_lpLocaleName_native, dwMapFlags, lpSrcStr, cchSrc, lpDestStr, cchDest, lpVersionInformation, lpReserved, sortHandle);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600003E RID: 62
		[LibraryImport("kernel32.dll", EntryPoint = "FindNLSStringEx", SetLastError = false)]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern int FindNLSStringEx(char* lpLocaleName, uint dwFindNLSStringFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, int* pcchFound, void* lpVersionInformation, void* lpReserved, IntPtr sortHandle);

		// Token: 0x0600003F RID: 63
		[LibraryImport("kernel32.dll", EntryPoint = "CompareStringEx")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern int CompareStringEx(char* lpLocaleName, uint dwCmpFlags, char* lpString1, int cchCount1, char* lpString2, int cchCount2, void* lpVersionInformation, void* lpReserved, IntPtr lParam);

		// Token: 0x06000040 RID: 64 RVA: 0x000025B8 File Offset: 0x000007B8
		[LibraryImport("kernel32.dll", EntryPoint = "CompareStringOrdinal")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int CompareStringOrdinal(char* lpString1, int cchCount1, char* lpString2, int cchCount2, [MarshalAs(UnmanagedType.Bool)] bool bIgnoreCase)
		{
			int _bIgnoreCase_native = (bIgnoreCase > false) ? 1 : 0;
			return Interop.Kernel32.<CompareStringOrdinal>g____PInvoke|30_0(lpString1, cchCount1, lpString2, cchCount2, _bIgnoreCase_native);
		}

		// Token: 0x06000041 RID: 65
		[LibraryImport("kernel32.dll", EntryPoint = "FindStringOrdinal", SetLastError = false)]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern int FindStringOrdinal(uint dwFindStringOrdinalFlags, char* lpStringSource, int cchSource, char* lpStringValue, int cchValue, Interop.BOOL bIgnoreCase);

		// Token: 0x06000042 RID: 66 RVA: 0x000025D5 File Offset: 0x000007D5
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool IsNLSDefinedString(int Function, uint dwFlags, IntPtr lpVersionInformation, char* lpString, int cchStr)
		{
			return Interop.Kernel32.<IsNLSDefinedString>g____PInvoke|32_0(Function, dwFlags, lpVersionInformation, lpString, cchStr) != 0;
		}

		// Token: 0x06000043 RID: 67
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL GetUserPreferredUILanguages(uint dwFlags, uint* pulNumLanguages, char* pwszLanguagesBuffer, uint* pcchLanguagesBuffer);

		// Token: 0x06000044 RID: 68 RVA: 0x000025E8 File Offset: 0x000007E8
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int GetLocaleInfoEx(string lpLocaleName, uint LCType, void* lpLCData, int cchData)
		{
			int result;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpLocaleName))
			{
				void* _lpLocaleName_native = (void*)pinnableReference;
				result = Interop.Kernel32.<GetLocaleInfoEx>g____PInvoke|34_0((ushort*)_lpLocaleName_native, LCType, lpLCData, cchData);
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000260B File Offset: 0x0000080B
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool EnumSystemLocalesEx(method lpLocaleEnumProcEx, char dwFlags, Interop.BOOL lParam, char* reserved)
		{
			return Interop.Kernel32.<EnumSystemLocalesEx>g____PInvoke|35_0(lpLocaleEnumProcEx, dwFlags, lParam, reserved) != 0;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000261C File Offset: 0x0000081C
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool EnumTimeFormatsEx(method lpTimeFmtEnumProcEx, bool lpLocaleName, Interop.BOOL dwFlags, char* lParam)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpLocaleName))
			{
				void* _lpLocaleName_native = (void*)pinnableReference;
				num = Interop.Kernel32.<EnumTimeFormatsEx>g____PInvoke|36_0(lpTimeFmtEnumProcEx, _lpLocaleName_native != null, dwFlags, lParam);
			}
			return num != 0;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002644 File Offset: 0x00000844
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int GetCalendarInfoEx(string lpLocaleName, uint Calendar, IntPtr lpReserved, uint CalType, IntPtr lpCalData, int cchData, out int lpValue)
		{
			lpValue = 0;
			int result;
			fixed (int* ptr = &lpValue)
			{
				int* _lpValue_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpLocaleName))
				{
					void* _lpLocaleName_native = (void*)pinnableReference;
					result = Interop.Kernel32.<GetCalendarInfoEx>g____PInvoke|37_0((ushort*)_lpLocaleName_native, Calendar, lpReserved, CalType, lpCalData, cchData, _lpValue_native);
				}
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000267C File Offset: 0x0000087C
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int GetCalendarInfoEx(string lpLocaleName, uint Calendar, IntPtr lpReserved, uint CalType, IntPtr lpCalData, int cchData, IntPtr lpValue)
		{
			int result;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpLocaleName))
			{
				void* _lpLocaleName_native = (void*)pinnableReference;
				result = Interop.Kernel32.<GetCalendarInfoEx>g____PInvoke|38_0((ushort*)_lpLocaleName_native, Calendar, lpReserved, CalType, lpCalData, cchData, lpValue);
			}
			return result;
		}

		// Token: 0x06000049 RID: 73
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern int GetUserGeoID(int geoClass);

		// Token: 0x0600004A RID: 74
		[LibraryImport("kernel32.dll", EntryPoint = "GetGeoInfoW")]
		[DllImport("kernel32.dll", EntryPoint = "GetGeoInfoW", ExactSpelling = true)]
		internal unsafe static extern int GetGeoInfo(int location, int geoType, char* lpGeoData, int cchData, int LangId);

		// Token: 0x0600004B RID: 75 RVA: 0x000026A8 File Offset: 0x000008A8
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool EnumCalendarInfoExEx(method pCalInfoEnumProcExEx, sbyte lpLocaleName, Interop.BOOL Calendar, char* lpReserved, uint CalType, IntPtr lParam)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpReserved))
			{
				void* _lpReserved_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(lpLocaleName))
				{
					void* _lpLocaleName_native = (void*)pinnableReference2;
					num = Interop.Kernel32.<EnumCalendarInfoExEx>g____PInvoke|41_0(pCalInfoEnumProcExEx, _lpLocaleName_native, Calendar, (char*)_lpReserved_native, CalType, lParam);
				}
			}
			return num != 0;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000026E0 File Offset: 0x000008E0
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetNLSVersionEx(int function, string localeName, Interop.Kernel32.NlsVersionInfoEx* lpVersionInformation)
		{
			int num;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(localeName))
			{
				void* _localeName_native = (void*)pinnableReference;
				num = Interop.Kernel32.<GetNLSVersionEx>g____PInvoke|43_0(function, (ushort*)_localeName_native, lpVersionInformation);
			}
			return num != 0;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002708 File Offset: 0x00000908
		[LibraryImport("kernel32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int ResolveLocaleName(string lpNameToResolve, char* lpLocaleName, int cchLocaleName)
		{
			int result;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpNameToResolve))
			{
				void* _lpNameToResolve_native = (void*)pinnableReference;
				result = Interop.Kernel32.<ResolveLocaleName>g____PInvoke|45_0((ushort*)_lpNameToResolve_native, lpLocaleName, cchLocaleName);
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000272C File Offset: 0x0000092C
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool CancelIoEx(SafeHandle handle, NativeOverlapped* lpOverlapped)
		{
			bool result = false;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<CancelIoEx>g____PInvoke|46_0(_handle_native, lpOverlapped);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000278C File Offset: 0x0000098C
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool CancelSynchronousIo(SafeThreadHandle hThread)
		{
			bool result = false;
			SafeHandleMarshaller<SafeThreadHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeThreadHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hThread);
				IntPtr _hThread_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<CancelSynchronousIo>g____PInvoke|48_0(_hThread_native);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000027E8 File Offset: 0x000009E8
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static IntPtr CreateIoCompletionPort(IntPtr FileHandle, IntPtr ExistingCompletionPort, UIntPtr CompletionKey, int NumberOfConcurrentThreads)
		{
			Marshal.SetLastSystemError(0);
			IntPtr result = Interop.Kernel32.<CreateIoCompletionPort>g____PInvoke|49_0(FileHandle, ExistingCompletionPort, CompletionKey, NumberOfConcurrentThreads);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002804 File Offset: 0x00000A04
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool PostQueuedCompletionStatus(IntPtr CompletionPort, uint dwNumberOfBytesTransferred, UIntPtr CompletionKey, IntPtr lpOverlapped)
		{
			Marshal.SetLastSystemError(0);
			int num = Interop.Kernel32.<PostQueuedCompletionStatus>g____PInvoke|50_0(CompletionPort, dwNumberOfBytesTransferred, CompletionKey, lpOverlapped);
			int lastSystemError = Marshal.GetLastSystemError();
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002830 File Offset: 0x00000A30
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetQueuedCompletionStatus(IntPtr CompletionPort, out uint lpNumberOfBytesTransferred, out UIntPtr CompletionKey, out IntPtr lpOverlapped, int dwMilliseconds)
		{
			lpNumberOfBytesTransferred = 0U;
			CompletionKey = (UIntPtr)((IntPtr)0);
			lpOverlapped = (IntPtr)0;
			int num;
			int lastSystemError;
			fixed (IntPtr* ptr = &lpOverlapped)
			{
				IntPtr* _lpOverlapped_native = ptr;
				fixed (UIntPtr* ptr2 = &CompletionKey)
				{
					UIntPtr* _CompletionKey_native = ptr2;
					fixed (uint* ptr3 = &lpNumberOfBytesTransferred)
					{
						uint* _lpNumberOfBytesTransferred_native = ptr3;
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<GetQueuedCompletionStatus>g____PInvoke|51_0(CompletionPort, _lpNumberOfBytesTransferred_native, _CompletionKey_native, _lpOverlapped_native, dwMilliseconds);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002888 File Offset: 0x00000A88
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetQueuedCompletionStatusEx(IntPtr CompletionPort, Interop.Kernel32.OVERLAPPED_ENTRY* lpCompletionPortEntries, int ulCount, out int ulNumEntriesRemoved, int dwMilliseconds, [MarshalAs(UnmanagedType.Bool)] bool fAlertable)
		{
			ulNumEntriesRemoved = 0;
			int _fAlertable_native = (fAlertable > false) ? 1 : 0;
			int num;
			int lastSystemError;
			fixed (int* ptr = &ulNumEntriesRemoved)
			{
				int* _ulNumEntriesRemoved_native = ptr;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<GetQueuedCompletionStatusEx>g____PInvoke|52_0(CompletionPort, lpCompletionPortEntries, ulCount, _ulNumEntriesRemoved_native, dwMilliseconds, _fAlertable_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000054 RID: 84
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void InitializeConditionVariable(Interop.Kernel32.CONDITION_VARIABLE* ConditionVariable);

		// Token: 0x06000055 RID: 85
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void WakeConditionVariable(Interop.Kernel32.CONDITION_VARIABLE* ConditionVariable);

		// Token: 0x06000056 RID: 86 RVA: 0x000028C7 File Offset: 0x00000AC7
		[LibraryImport("kernel32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool SleepConditionVariableCS(Interop.Kernel32.CONDITION_VARIABLE* ConditionVariable, Interop.Kernel32.CRITICAL_SECTION* CriticalSection, int dwMilliseconds)
		{
			return Interop.Kernel32.<SleepConditionVariableCS>g____PInvoke|57_0(ConditionVariable, CriticalSection, dwMilliseconds) != 0;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000028D4 File Offset: 0x00000AD4
		internal static int CopyFile(string src, string dst, bool failIfExists)
		{
			int flags = (failIfExists > false) ? 1 : 0;
			int num = 0;
			if (!Interop.Kernel32.CopyFileEx(src, dst, IntPtr.Zero, IntPtr.Zero, ref num, flags))
			{
				return Marshal.GetLastPInvokeError();
			}
			return 0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002908 File Offset: 0x00000B08
		[LibraryImport("kernel32.dll", EntryPoint = "CopyFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool CopyFileExPrivate(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags)
		{
			int num;
			int lastSystemError;
			fixed (int* ptr = &cancel)
			{
				int* _cancel_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(dst))
				{
					void* _dst_native = (void*)pinnableReference;
					fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(src))
					{
						void* _src_native = (void*)pinnableReference2;
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<CopyFileExPrivate>g____PInvoke|59_0((ushort*)_src_native, (ushort*)_dst_native, progressRoutine, progressData, _cancel_native, flags);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002961 File Offset: 0x00000B61
		internal static bool CopyFileEx(string src, string dst, IntPtr progressRoutine, IntPtr progressData, ref int cancel, int flags)
		{
			src = PathInternal.EnsureExtendedPrefixIfNeeded(src);
			dst = PathInternal.EnsureExtendedPrefixIfNeeded(dst);
			return Interop.Kernel32.CopyFileExPrivate(src, dst, progressRoutine, progressData, ref cancel, flags);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002980 File Offset: 0x00000B80
		[LibraryImport("kernel32.dll", EntryPoint = "CreateDirectoryW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool CreateDirectoryPrivate(string path, Interop.Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(path))
			{
				void* _path_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<CreateDirectoryPrivate>g____PInvoke|61_0((ushort*)_path_native, lpSecurityAttributes);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000029B6 File Offset: 0x00000BB6
		internal unsafe static bool CreateDirectory(string path, Interop.Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes)
		{
			path = PathInternal.EnsureExtendedPrefix(path);
			return Interop.Kernel32.CreateDirectoryPrivate(path, lpSecurityAttributes);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000029C8 File Offset: 0x00000BC8
		[LibraryImport("kernel32.dll", EntryPoint = "CreateFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		private unsafe static SafeFileHandle CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, Interop.Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)
		{
			bool flag = false;
			SafeFileHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(lpFileName))
					{
						void* _lpFileName_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<CreateFilePrivate>g____PInvoke|63_0((ushort*)_lpFileName_native, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A58 File Offset: 0x00000C58
		internal unsafe static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, Interop.Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)
		{
			lpFileName = PathInternal.EnsureExtendedPrefixIfNeeded(lpFileName);
			return Interop.Kernel32.CreateFilePrivate(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A71 File Offset: 0x00000C71
		internal static SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			lpFileName = PathInternal.EnsureExtendedPrefixIfNeeded(lpFileName);
			return Interop.Kernel32.CreateFilePrivate(lpFileName, dwDesiredAccess, dwShareMode, null, dwCreationDisposition, dwFlagsAndAttributes, IntPtr.Zero);
		}

		// Token: 0x0600005F RID: 95
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr CreateThreadpoolTimer(method pfnti, char pv, void pcbe);

		// Token: 0x06000060 RID: 96
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern IntPtr SetThreadpoolTimer(IntPtr pti, long* pftDueTime, uint msPeriod, uint msWindowLength);

		// Token: 0x06000061 RID: 97 RVA: 0x00002A90 File Offset: 0x00000C90
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static SafeThreadPoolIOHandle CreateThreadpoolIo(SafeHandle fl, method pfnio, short context, void pcbe)
		{
			bool flag = false;
			SafeThreadPoolIOHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeThreadPoolIOHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeThreadPoolIOHandle>.ManagedToUnmanagedOut();
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(fl);
				IntPtr _fl_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				value = Interop.Kernel32.<CreateThreadpoolIo>g____PInvoke|68_0(_fl_native, pfnio, context, pcbe);
				lastSystemError = Marshal.GetLastSystemError();
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000062 RID: 98
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void CloseThreadpoolIo(IntPtr pio);

		// Token: 0x06000063 RID: 99 RVA: 0x00002B14 File Offset: 0x00000D14
		[LibraryImport("kernel32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static void StartThreadpoolIo(SafeThreadPoolIOHandle pio)
		{
			SafeHandleMarshaller<SafeThreadPoolIOHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeThreadPoolIOHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(pio);
				Interop.Kernel32.<StartThreadpoolIo>g____PInvoke|70_0(managedToUnmanagedIn.ToUnmanaged());
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002B58 File Offset: 0x00000D58
		[LibraryImport("kernel32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static void CancelThreadpoolIo(SafeThreadPoolIOHandle pio)
		{
			SafeHandleMarshaller<SafeThreadPoolIOHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeThreadPoolIOHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(pio);
				Interop.Kernel32.<CancelThreadpoolIo>g____PInvoke|71_0(managedToUnmanagedIn.ToUnmanaged());
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
		}

		// Token: 0x06000065 RID: 101
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr CreateThreadpoolWork(method pfnwk, char pv, void pcbe);

		// Token: 0x06000066 RID: 102
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void SubmitThreadpoolWork(IntPtr pwk);

		// Token: 0x06000067 RID: 103
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void CloseThreadpoolWork(IntPtr pwk);

		// Token: 0x06000068 RID: 104
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr CreateThreadpoolWait(method pfnwa, sbyte pv, void pcbe);

		// Token: 0x06000069 RID: 105
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void SetThreadpoolWait(IntPtr pwa, IntPtr h, IntPtr pftTimeout);

		// Token: 0x0600006A RID: 106 RVA: 0x00002B9C File Offset: 0x00000D9C
		[LibraryImport("kernel32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static void WaitForThreadpoolWaitCallbacks(IntPtr pwa, [MarshalAs(UnmanagedType.Bool)] bool fCancelPendingCallbacks)
		{
			int _fCancelPendingCallbacks_native = (fCancelPendingCallbacks > false) ? 1 : 0;
			Interop.Kernel32.<WaitForThreadpoolWaitCallbacks>g____PInvoke|77_0(pwa, _fCancelPendingCallbacks_native);
		}

		// Token: 0x0600006B RID: 107
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void CloseThreadpoolWait(IntPtr pwa);

		// Token: 0x0600006C RID: 108 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[LibraryImport("kernel32.dll", EntryPoint = "DeleteFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool DeleteFilePrivate(string path)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(path))
			{
				void* _path_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<DeleteFilePrivate>g____PInvoke|80_0((ushort*)_path_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002BED File Offset: 0x00000DED
		internal static bool DeleteFile(string path)
		{
			path = PathInternal.EnsureExtendedPrefixIfNeeded(path);
			return Interop.Kernel32.DeleteFilePrivate(path);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002C00 File Offset: 0x00000E00
		[LibraryImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPointW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool DeleteVolumeMountPointPrivate(string mountPoint)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(mountPoint))
			{
				void* _mountPoint_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<DeleteVolumeMountPointPrivate>g____PInvoke|82_0((ushort*)_mountPoint_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002C35 File Offset: 0x00000E35
		internal static bool DeleteVolumeMountPoint(string mountPoint)
		{
			mountPoint = PathInternal.EnsureExtendedPrefixIfNeeded(mountPoint);
			return Interop.Kernel32.DeleteVolumeMountPointPrivate(mountPoint);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002C48 File Offset: 0x00000E48
		[LibraryImport("kernel32.dll", EntryPoint = "CreateFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		private unsafe static IntPtr CreateFilePrivate_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, Interop.Kernel32.SECURITY_ATTRIBUTES* lpSecurityAttributes, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile)
		{
			IntPtr result;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpFileName))
			{
				void* _lpFileName_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<CreateFilePrivate_IntPtr>g____PInvoke|84_0((ushort*)_lpFileName_native, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002C81 File Offset: 0x00000E81
		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			lpFileName = PathInternal.EnsureExtendedPrefixIfNeeded(lpFileName);
			return Interop.Kernel32.CreateFilePrivate_IntPtr(lpFileName, dwDesiredAccess, dwShareMode, null, dwCreationDisposition, dwFlagsAndAttributes, IntPtr.Zero);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[LibraryImport("kernel32.dll", EntryPoint = "CreateSymbolicLinkW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.U1)]
		private unsafe static bool CreateSymbolicLinkPrivate(string lpSymlinkFileName, string lpTargetFileName, int dwFlags)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpTargetFileName))
			{
				void* _lpTargetFileName_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(lpSymlinkFileName))
				{
					void* _lpSymlinkFileName_native = (void*)pinnableReference2;
					Marshal.SetLastSystemError(0);
					num = (int)Interop.Kernel32.<CreateSymbolicLinkPrivate>g____PInvoke|88_0((ushort*)_lpSymlinkFileName_native, (ushort*)_lpTargetFileName_native, dwFlags);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002CE8 File Offset: 0x00000EE8
		internal static void CreateSymbolicLink(string symlinkFileName, string targetFileName, bool isDirectory)
		{
			string path = symlinkFileName;
			symlinkFileName = PathInternal.EnsureExtendedPrefixIfNeeded(symlinkFileName);
			targetFileName = PathInternal.EnsureExtendedPrefixIfNeeded(targetFileName);
			int num = 0;
			Version version = Environment.OSVersion.Version;
			if (version.Major >= 11 || (version.Major == 10 && version.Build >= 14972))
			{
				num = 2;
			}
			if (isDirectory)
			{
				num |= 1;
			}
			if (!Interop.Kernel32.CreateSymbolicLinkPrivate(symlinkFileName, targetFileName, num))
			{
				throw Win32Marshal.GetExceptionForLastWin32Error(path);
			}
		}

		// Token: 0x06000074 RID: 116
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void InitializeCriticalSection(Interop.Kernel32.CRITICAL_SECTION* lpCriticalSection);

		// Token: 0x06000075 RID: 117
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void EnterCriticalSection(Interop.Kernel32.CRITICAL_SECTION* lpCriticalSection);

		// Token: 0x06000076 RID: 118
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void LeaveCriticalSection(Interop.Kernel32.CRITICAL_SECTION* lpCriticalSection);

		// Token: 0x06000077 RID: 119
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void DeleteCriticalSection(Interop.Kernel32.CRITICAL_SECTION* lpCriticalSection);

		// Token: 0x06000078 RID: 120 RVA: 0x00002D5C File Offset: 0x00000F5C
		[LibraryImport("kernel32.dll", EntryPoint = "DeviceIoControl", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool DeviceIoControl(SafeHandle hDevice, uint dwIoControlCode, void* lpInBuffer, uint nInBufferSize, void* lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped)
		{
			lpBytesReturned = 0U;
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hDevice);
				try
				{
					fixed (uint* ptr = &lpBytesReturned)
					{
						uint* _lpBytesReturned_native = ptr;
						IntPtr _hDevice_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<DeviceIoControl>g____PInvoke|97_0(_hDevice_native, dwIoControlCode, lpInBuffer, nInBufferSize, lpOutBuffer, nOutBufferSize, _lpBytesReturned_native, lpOverlapped);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					uint* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002DE8 File Offset: 0x00000FE8
		[LibraryImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStringsW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint ExpandEnvironmentStrings(string lpSrc, ref char lpDst, uint nSize)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpDst)
			{
				char* _lpDst_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpSrc))
				{
					void* _lpSrc_native = (void*)pinnableReference;
					Marshal.SetLastSystemError(0);
					result = Interop.Kernel32.<ExpandEnvironmentStrings>g____PInvoke|98_0((ushort*)_lpSrc_native, _lpDst_native, nSize);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002E24 File Offset: 0x00001024
		[LibraryImport("kernel32.dll", EntryPoint = "FindNextFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool FindNextFile(SafeFindHandle hndFindFile, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData)
		{
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeFindHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFindHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hndFindFile);
				try
				{
					fixed (Interop.Kernel32.WIN32_FIND_DATA* ptr = &lpFindFileData)
					{
						Interop.Kernel32.WIN32_FIND_DATA* _lpFindFileData_native = ptr;
						IntPtr _hndFindFile_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<FindNextFile>g____PInvoke|109_0(_hndFindFile_native, _lpFindFileData_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					Interop.Kernel32.WIN32_FIND_DATA* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600007B RID: 123
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL FileTimeToSystemTime(ulong* lpFileTime, Interop.Kernel32.SYSTEMTIME* lpSystemTime);

		// Token: 0x0600007C RID: 124 RVA: 0x00002EA4 File Offset: 0x000010A4
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool FindClose(IntPtr hFindFile)
		{
			Marshal.SetLastSystemError(0);
			int num = Interop.Kernel32.<FindClose>g____PInvoke|114_0(hFindFile);
			int lastSystemError = Marshal.GetLastSystemError();
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002ECC File Offset: 0x000010CC
		[LibraryImport("kernel32.dll", EntryPoint = "FindFirstFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		private unsafe static SafeFindHandle FindFirstFileExPrivate(string lpFileName, Interop.Kernel32.FINDEX_INFO_LEVELS fInfoLevelId, ref Interop.Kernel32.WIN32_FIND_DATA lpFindFileData, Interop.Kernel32.FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags)
		{
			bool flag = false;
			SafeFindHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeFindHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeFindHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				try
				{
					fixed (Interop.Kernel32.WIN32_FIND_DATA* ptr = &lpFindFileData)
					{
						Interop.Kernel32.WIN32_FIND_DATA* _lpFindFileData_native = ptr;
						try
						{
							fixed (char* ptr2 = Utf16StringMarshaller.GetPinnableReference(lpFileName))
							{
								void* _lpFileName_native = (void*)ptr2;
								Marshal.SetLastSystemError(0);
								value = Interop.Kernel32.<FindFirstFileExPrivate>g____PInvoke|115_0((ushort*)_lpFileName_native, fInfoLevelId, _lpFindFileData_native, fSearchOp, lpSearchFilter, dwAdditionalFlags);
								lastSystemError = Marshal.GetLastSystemError();
							}
						}
						finally
						{
							char* ptr2 = null;
						}
					}
				}
				finally
				{
					Interop.Kernel32.WIN32_FIND_DATA* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002F74 File Offset: 0x00001174
		internal static SafeFindHandle FindFirstFile(string fileName, ref Interop.Kernel32.WIN32_FIND_DATA data)
		{
			fileName = PathInternal.EnsureExtendedPrefixIfNeeded(fileName);
			return Interop.Kernel32.FindFirstFileExPrivate(fileName, Interop.Kernel32.FINDEX_INFO_LEVELS.FindExInfoBasic, ref data, Interop.Kernel32.FINDEX_SEARCH_OPS.FindExSearchNameMatch, IntPtr.Zero, 0);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002F90 File Offset: 0x00001190
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool FlushFileBuffers(SafeHandle hHandle)
		{
			bool result = false;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hHandle);
				IntPtr _hHandle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<FlushFileBuffers>g____PInvoke|119_0(_hHandle_native);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002FEC File Offset: 0x000011EC
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool FreeLibrary(IntPtr hModule)
		{
			Marshal.SetLastSystemError(0);
			int num = Interop.Kernel32.<FreeLibrary>g____PInvoke|120_0(hModule);
			int lastSystemError = Marshal.GetLastSystemError();
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000081 RID: 129
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern int GetLastError();

		// Token: 0x06000082 RID: 130
		[LibraryImport("kernel32.dll", EntryPoint = "GetComputerNameW")]
		[DllImport("kernel32.dll", EntryPoint = "GetComputerNameW", ExactSpelling = true)]
		private unsafe static extern int GetComputerName(char* lpBuffer, uint* nSize);

		// Token: 0x06000083 RID: 131 RVA: 0x00003014 File Offset: 0x00001214
		internal unsafe static string GetComputerName()
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)32], 16);
			uint length = (uint)span.Length;
			fixed (char* reference = MemoryMarshal.GetReference<char>(span))
			{
				if (Interop.Kernel32.GetComputerName(reference, &length) == 0)
				{
					return null;
				}
				return span.Slice(0, (int)length).ToString();
			}
		}

		// Token: 0x06000084 RID: 132
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern uint GetConsoleOutputCP();

		// Token: 0x06000085 RID: 133
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL GetCPInfo(uint codePage, Interop.Kernel32.CPINFO* lpCpInfo);

		// Token: 0x06000086 RID: 134 RVA: 0x00003064 File Offset: 0x00001264
		[LibraryImport("kernel32.dll", EntryPoint = "GetCurrentDirectoryW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetCurrentDirectory(uint nBufferLength, ref char lpBuffer)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpBuffer)
			{
				char* _lpBuffer_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetCurrentDirectory>g____PInvoke|131_0(nBufferLength, _lpBuffer_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000087 RID: 135
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr GetCurrentProcess();

		// Token: 0x06000088 RID: 136
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern uint GetCurrentProcessId();

		// Token: 0x06000089 RID: 137
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		public static extern int GetCurrentThreadId();

		// Token: 0x0600008A RID: 138 RVA: 0x00003090 File Offset: 0x00001290
		[LibraryImport("kernel32.dll", EntryPoint = "GetFileAttributesExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool GetFileAttributesExPrivate(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			int num;
			int lastSystemError;
			fixed (Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA* ptr = &lpFileInformation)
			{
				Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA* _lpFileInformation_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(name))
				{
					void* _name_native = (void*)pinnableReference;
					Marshal.SetLastSystemError(0);
					num = Interop.Kernel32.<GetFileAttributesExPrivate>g____PInvoke|135_0((ushort*)_name_native, fileInfoLevel, _lpFileInformation_native);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000030D2 File Offset: 0x000012D2
		internal static bool GetFileAttributesEx(string name, Interop.Kernel32.GET_FILEEX_INFO_LEVELS fileInfoLevel, ref Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			name = PathInternal.EnsureExtendedPrefixIfNeeded(name);
			return Interop.Kernel32.GetFileAttributesExPrivate(name, fileInfoLevel, ref lpFileInformation);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000030E4 File Offset: 0x000012E4
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetFileInformationByHandle(SafeFileHandle hFile, out Interop.Kernel32.BY_HANDLE_FILE_INFORMATION lpFileInformation)
		{
			lpFileInformation = default(Interop.Kernel32.BY_HANDLE_FILE_INFORMATION);
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				try
				{
					fixed (Interop.Kernel32.BY_HANDLE_FILE_INFORMATION* ptr = &lpFileInformation)
					{
						Interop.Kernel32.BY_HANDLE_FILE_INFORMATION* _lpFileInformation_native = ptr;
						IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<GetFileInformationByHandle>g____PInvoke|137_0(_hFile_native, _lpFileInformation_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					Interop.Kernel32.BY_HANDLE_FILE_INFORMATION* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003168 File Offset: 0x00001368
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetFileInformationByHandleEx(SafeFileHandle hFile, int FileInformationClass, void* lpFileInformation, uint dwBufferSize)
		{
			bool result = false;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<GetFileInformationByHandleEx>g____PInvoke|138_0(_hFile_native, FileInformationClass, lpFileInformation, dwBufferSize);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000031C8 File Offset: 0x000013C8
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static int GetFileType(SafeHandle hFile)
		{
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetFileType>g____PInvoke|139_0(_hFile_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003224 File Offset: 0x00001424
		[LibraryImport("kernel32.dll", EntryPoint = "GetFinalPathNameByHandleW", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetFinalPathNameByHandle(SafeFileHandle hFile, char* lpszFilePath, uint cchFilePath, uint dwFlags)
		{
			uint result = 0U;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetFinalPathNameByHandle>g____PInvoke|141_0(_hFile_native, lpszFilePath, cchFilePath, dwFlags);
				lastSystemError = Marshal.GetLastSystemError();
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003280 File Offset: 0x00001480
		[LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetFullPathNameW(ref char lpFileName, uint nBufferLength, ref char lpBuffer, IntPtr lpFilePart)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpBuffer)
			{
				char* _lpBuffer_native = ptr;
				fixed (char* ptr2 = &lpFileName)
				{
					char* _lpFileName_native = ptr2;
					Marshal.SetLastSystemError(0);
					result = Interop.Kernel32.<GetFullPathNameW>g____PInvoke|142_0(_lpFileName_native, nBufferLength, _lpBuffer_native, lpFilePart);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000032B4 File Offset: 0x000014B4
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static int GetLogicalDrives()
		{
			Marshal.SetLastSystemError(0);
			int result = Interop.Kernel32.<GetLogicalDrives>g____PInvoke|143_0();
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000032CC File Offset: 0x000014CC
		[LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetLongPathNameW(ref char lpszShortPath, ref char lpszLongPath, uint cchBuffer)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpszLongPath)
			{
				char* _lpszLongPath_native = ptr;
				fixed (char* ptr2 = &lpszShortPath)
				{
					char* _lpszShortPath_native = ptr2;
					Marshal.SetLastSystemError(0);
					result = Interop.Kernel32.<GetLongPathNameW>g____PInvoke|144_0(_lpszShortPath_native, _lpszLongPath_native, cchBuffer);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003300 File Offset: 0x00001500
		[LibraryImport("kernel32.dll", EntryPoint = "GetModuleFileNameW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetModuleFileName(IntPtr hModule, ref char lpFilename, uint nSize)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpFilename)
			{
				char* _lpFilename_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetModuleFileName>g____PInvoke|145_0(hModule, _lpFilename_native, nSize);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000094 RID: 148
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void GetNativeSystemInfo(Interop.Kernel32.SYSTEM_INFO* lpSystemInfo);

		// Token: 0x06000095 RID: 149 RVA: 0x00003330 File Offset: 0x00001530
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetOverlappedResult(SafeFileHandle hFile, NativeOverlapped* lpOverlapped, ref int lpNumberOfBytesTransferred, [MarshalAs(UnmanagedType.Bool)] bool bWait)
		{
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				int _bWait_native = (bWait > false) ? 1 : 0;
				managedToUnmanagedIn.FromManaged(hFile);
				try
				{
					fixed (int* ptr = &lpNumberOfBytesTransferred)
					{
						int* _lpNumberOfBytesTransferred_native = ptr;
						IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<GetOverlappedResult>g____PInvoke|147_0(_hFile_native, lpOverlapped, _lpNumberOfBytesTransferred_native, _bWait_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					int* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000033B8 File Offset: 0x000015B8
		[LibraryImport("kernel32.dll", EntryPoint = "K32GetProcessMemoryInfo")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetProcessMemoryInfo(IntPtr Process, ref Interop.Kernel32.PROCESS_MEMORY_COUNTERS ppsmemCounters, uint cb)
		{
			int num;
			fixed (Interop.Kernel32.PROCESS_MEMORY_COUNTERS* ptr = &ppsmemCounters)
			{
				Interop.Kernel32.PROCESS_MEMORY_COUNTERS* _ppsmemCounters_native = ptr;
				num = Interop.Kernel32.<GetProcessMemoryInfo>g____PInvoke|149_0(Process, _ppsmemCounters_native, cb);
			}
			return num != 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000033D8 File Offset: 0x000015D8
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetProcessTimes(IntPtr handleProcess, out long creation, out long exit, out long kernel, out long user)
		{
			creation = 0L;
			exit = 0L;
			kernel = 0L;
			user = 0L;
			int num;
			int lastSystemError;
			fixed (long* ptr = &user)
			{
				long* _user_native = ptr;
				fixed (long* ptr2 = &kernel)
				{
					long* _kernel_native = ptr2;
					fixed (long* ptr3 = &exit)
					{
						long* _exit_native = ptr3;
						fixed (long* ptr4 = &creation)
						{
							long* _creation_native = ptr4;
							Marshal.SetLastSystemError(0);
							num = Interop.Kernel32.<GetProcessTimes>g____PInvoke|150_0(handleProcess, _creation_native, _exit_native, _kernel_native, _user_native);
							lastSystemError = Marshal.GetLastSystemError();
						}
					}
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000098 RID: 152
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr GetStdHandle(int nStdHandle);

		// Token: 0x06000099 RID: 153 RVA: 0x00003444 File Offset: 0x00001644
		[LibraryImport("kernel32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetSystemDirectoryW(ref char lpBuffer, uint uSize)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpBuffer)
			{
				char* _lpBuffer_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetSystemDirectoryW>g____PInvoke|152_0(_lpBuffer_native, uSize);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600009A RID: 154
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void GetSystemInfo(Interop.Kernel32.SYSTEM_INFO* lpSystemInfo);

		// Token: 0x0600009B RID: 155
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void GetSystemTime(Interop.Kernel32.SYSTEMTIME* lpSystemTime);

		// Token: 0x0600009C RID: 156 RVA: 0x00003470 File Offset: 0x00001670
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetSystemTimes(out long idle, out long kernel, out long user)
		{
			idle = 0L;
			kernel = 0L;
			user = 0L;
			int num;
			int lastSystemError;
			fixed (long* ptr = &user)
			{
				long* _user_native = ptr;
				fixed (long* ptr2 = &kernel)
				{
					long* _kernel_native = ptr2;
					fixed (long* ptr3 = &idle)
					{
						long* _idle_native = ptr3;
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<GetSystemTimes>g____PInvoke|155_0(_idle_native, _kernel_native, _user_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000034C4 File Offset: 0x000016C4
		[LibraryImport("kernel32.dll", EntryPoint = "GetVolumeInformationW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetVolumeInformation(string drive, char* volumeName, int volumeNameBufLen, int* volSerialNumber, int* maxFileNameLen, out int fileSystemFlags, char* fileSystemName, int fileSystemNameBufLen)
		{
			fileSystemFlags = 0;
			int num;
			int lastSystemError;
			fixed (int* ptr = &fileSystemFlags)
			{
				int* _fileSystemFlags_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(drive))
				{
					void* _drive_native = (void*)pinnableReference;
					Marshal.SetLastSystemError(0);
					num = Interop.Kernel32.<GetVolumeInformation>g____PInvoke|156_0((ushort*)_drive_native, volumeName, volumeNameBufLen, volSerialNumber, maxFileNameLen, _fileSystemFlags_native, fileSystemName, fileSystemNameBufLen);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600009E RID: 158
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL GlobalMemoryStatusEx(Interop.Kernel32.MEMORYSTATUSEX* lpBuffer);

		// Token: 0x0600009F RID: 159 RVA: 0x00003514 File Offset: 0x00001714
		[LibraryImport("kernel32.dll", EntryPoint = "LoadLibraryExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static IntPtr LoadLibraryEx(string libFilename, IntPtr reserved, int flags)
		{
			IntPtr result;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(libFilename))
			{
				void* _libFilename_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<LoadLibraryEx>g____PInvoke|163_0((ushort*)_libFilename_native, reserved, flags);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000A0 RID: 160
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr LocalAlloc(uint uFlags, UIntPtr uBytes);

		// Token: 0x060000A1 RID: 161 RVA: 0x00003546 File Offset: 0x00001746
		internal unsafe static void* LocalAlloc(UIntPtr byteCount)
		{
			return Interop.Kernel32.LocalAlloc(0U, byteCount);
		}

		// Token: 0x060000A2 RID: 162
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr LocalFree(IntPtr hMem);

		// Token: 0x060000A3 RID: 163 RVA: 0x0000354F File Offset: 0x0000174F
		internal unsafe static void* LocalFree(void* ptr)
		{
			return Interop.Kernel32.LocalFree(ptr);
		}

		// Token: 0x060000A4 RID: 164
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr LocalReAlloc(IntPtr hMem, UIntPtr uBytes, uint uFlags);

		// Token: 0x060000A5 RID: 165 RVA: 0x00003557 File Offset: 0x00001757
		internal unsafe static void* LocalReAlloc(void* ptr, UIntPtr byteCount)
		{
			return Interop.Kernel32.LocalReAlloc(ptr, byteCount, 2U);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003564 File Offset: 0x00001764
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool LockFile(SafeFileHandle handle, int offsetLow, int offsetHigh, int countLow, int countHigh)
		{
			bool result = false;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<LockFile>g____PInvoke|175_0(_handle_native, offsetLow, offsetHigh, countLow, countHigh);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000035C8 File Offset: 0x000017C8
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool UnlockFile(SafeFileHandle handle, int offsetLow, int offsetHigh, int countLow, int countHigh)
		{
			bool result = false;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<UnlockFile>g____PInvoke|176_0(_handle_native, offsetLow, offsetHigh, countLow, countHigh);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000A8 RID: 168
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, byte* lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar);

		// Token: 0x060000A9 RID: 169 RVA: 0x0000362C File Offset: 0x0000182C
		[LibraryImport("kernel32.dll", EntryPoint = "MoveFileExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool MoveFileExPrivate(string src, string dst, uint flags)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(dst))
			{
				void* _dst_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(src))
				{
					void* _src_native = (void*)pinnableReference2;
					Marshal.SetLastSystemError(0);
					num = Interop.Kernel32.<MoveFileExPrivate>g____PInvoke|188_0((ushort*)_src_native, (ushort*)_dst_native, flags);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003674 File Offset: 0x00001874
		internal static bool MoveFile(string src, string dst, bool overwrite)
		{
			src = PathInternal.EnsureExtendedPrefixIfNeeded(src);
			dst = PathInternal.EnsureExtendedPrefixIfNeeded(dst);
			uint num = 2U;
			if (overwrite)
			{
				num |= 1U;
			}
			return Interop.Kernel32.MoveFileExPrivate(src, dst, num);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000036A4 File Offset: 0x000018A4
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal static SafeThreadHandle OpenThread(int dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwThreadId)
		{
			bool flag = false;
			SafeThreadHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeThreadHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeThreadHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				int _bInheritHandle_native = (bInheritHandle > false) ? 1 : 0;
				Marshal.SetLastSystemError(0);
				value = Interop.Kernel32.<OpenThread>g____PInvoke|191_0(dwDesiredAccess, _bInheritHandle_native, dwThreadId);
				lastSystemError = Marshal.GetLastSystemError();
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003714 File Offset: 0x00001914
		[LibraryImport("kernel32.dll", EntryPoint = "OutputDebugStringW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static void OutputDebugString(string message)
		{
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(message))
			{
				void* _message_native = (void*)pinnableReference;
				Interop.Kernel32.<OutputDebugString>g____PInvoke|193_0((ushort*)_message_native);
			}
		}

		// Token: 0x060000AD RID: 173
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL QueryPerformanceCounter(long* lpPerformanceCount);

		// Token: 0x060000AE RID: 174
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL QueryPerformanceFrequency(long* lpFrequency);

		// Token: 0x060000AF RID: 175 RVA: 0x00003734 File Offset: 0x00001934
		[LibraryImport("kernel32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool QueryUnbiasedInterruptTime(out ulong UnbiasedTime)
		{
			UnbiasedTime = 0UL;
			int num;
			fixed (ulong* ptr = &UnbiasedTime)
			{
				num = Interop.Kernel32.<QueryUnbiasedInterruptTime>g____PInvoke|196_0(ptr);
			}
			return num != 0;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003754 File Offset: 0x00001954
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int ReadFile(SafeHandle handle, byte* bytes, int numBytesToRead, IntPtr numBytesRead_mustBeZero, NativeOverlapped* overlapped)
		{
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<ReadFile>g____PInvoke|198_0(_handle_native, bytes, numBytesToRead, numBytesRead_mustBeZero, overlapped);
				lastSystemError = Marshal.GetLastSystemError();
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000037B4 File Offset: 0x000019B4
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int ReadFile(SafeHandle handle, byte* bytes, int numBytesToRead, out int numBytesRead, NativeOverlapped* overlapped)
		{
			numBytesRead = 0;
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				try
				{
					fixed (int* ptr = &numBytesRead)
					{
						int* _numBytesRead_native = ptr;
						IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						result = Interop.Kernel32.<ReadFile>g____PInvoke|199_0(_handle_native, bytes, numBytesToRead, _numBytesRead_native, overlapped);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					int* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003830 File Offset: 0x00001A30
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int ReadFileScatter(SafeHandle hFile, long* aSegmentArray, int nNumberOfBytesToRead, IntPtr lpReserved, NativeOverlapped* lpOverlapped)
		{
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<ReadFileScatter>g____PInvoke|200_0(_hFile_native, aSegmentArray, nNumberOfBytesToRead, lpReserved, lpOverlapped);
				lastSystemError = Marshal.GetLastSystemError();
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003890 File Offset: 0x00001A90
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int WriteFileGather(SafeHandle hFile, long* aSegmentArray, int nNumberOfBytesToWrite, IntPtr lpReserved, NativeOverlapped* lpOverlapped)
		{
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<WriteFileGather>g____PInvoke|201_0(_hFile_native, aSegmentArray, nNumberOfBytesToWrite, lpReserved, lpOverlapped);
				lastSystemError = Marshal.GetLastSystemError();
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000038F0 File Offset: 0x00001AF0
		[LibraryImport("kernel32.dll", EntryPoint = "RemoveDirectoryW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool RemoveDirectoryPrivate(string path)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(path))
			{
				void* _path_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<RemoveDirectoryPrivate>g____PInvoke|202_0((ushort*)_path_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003925 File Offset: 0x00001B25
		internal static bool RemoveDirectory(string path)
		{
			path = PathInternal.EnsureExtendedPrefixIfNeeded(path);
			return Interop.Kernel32.RemoveDirectoryPrivate(path);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003938 File Offset: 0x00001B38
		[LibraryImport("kernel32.dll", EntryPoint = "ReplaceFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool ReplaceFilePrivate(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(backupFileName))
			{
				void* _backupFileName_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(replacementFileName))
				{
					void* _replacementFileName_native = (void*)pinnableReference2;
					fixed (char* pinnableReference3 = Utf16StringMarshaller.GetPinnableReference(replacedFileName))
					{
						void* _replacedFileName_native = (void*)pinnableReference3;
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<ReplaceFilePrivate>g____PInvoke|208_0((ushort*)_replacedFileName_native, (ushort*)_replacementFileName_native, (ushort*)_backupFileName_native, dwReplaceFlags, lpExclude, lpReserved);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003996 File Offset: 0x00001B96
		internal static bool ReplaceFile(string replacedFileName, string replacementFileName, string backupFileName, int dwReplaceFlags, IntPtr lpExclude, IntPtr lpReserved)
		{
			replacedFileName = PathInternal.EnsureExtendedPrefixIfNeeded(replacedFileName);
			replacementFileName = PathInternal.EnsureExtendedPrefixIfNeeded(replacementFileName);
			backupFileName = PathInternal.EnsureExtendedPrefixIfNeeded(backupFileName);
			return Interop.Kernel32.ReplaceFilePrivate(replacedFileName, replacementFileName, backupFileName, dwReplaceFlags, lpExclude, lpReserved);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000039C0 File Offset: 0x00001BC0
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool SetConsoleCtrlHandler(method handler, [MarshalAs(UnmanagedType.Bool)] void Add)
		{
			int _Add_native = (Add > 0) ? 1 : 0;
			Marshal.SetLastSystemError(0);
			int num = Interop.Kernel32.<SetConsoleCtrlHandler>g____PInvoke|219_0(handler, _Add_native);
			int lastSystemError = Marshal.GetLastSystemError();
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000039F0 File Offset: 0x00001BF0
		[LibraryImport("kernel32.dll", EntryPoint = "SetCurrentDirectoryW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool SetCurrentDirectory(string path)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(path))
			{
				void* _path_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<SetCurrentDirectory>g____PInvoke|220_0((ushort*)_path_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003A28 File Offset: 0x00001C28
		[LibraryImport("kernel32.dll", EntryPoint = "SetFileAttributesW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool SetFileAttributesPrivate(string name, int attr)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(name))
			{
				void* _name_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<SetFileAttributesPrivate>g____PInvoke|221_0((ushort*)_name_native, attr);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003A5E File Offset: 0x00001C5E
		internal static bool SetFileAttributes(string name, int attr)
		{
			name = PathInternal.EnsureExtendedPrefixIfNeeded(name);
			return Interop.Kernel32.SetFileAttributesPrivate(name, attr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003A70 File Offset: 0x00001C70
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool SetFileInformationByHandle(SafeFileHandle hFile, int FileInformationClass, void* lpFileInformation, uint dwBufferSize)
		{
			bool result = false;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<SetFileInformationByHandle>g____PInvoke|223_0(_hFile_native, FileInformationClass, lpFileInformation, dwBufferSize);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool SetFilePointerEx(SafeFileHandle hFile, long liDistanceToMove, out long lpNewFilePointer, uint dwMoveMethod)
		{
			lpNewFilePointer = 0L;
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(hFile);
				try
				{
					fixed (long* ptr = &lpNewFilePointer)
					{
						long* _lpNewFilePointer_native = ptr;
						IntPtr _hFile_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<SetFilePointerEx>g____PInvoke|224_0(_hFile_native, liDistanceToMove, _lpNewFilePointer_native, dwMoveMethod);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					long* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000BE RID: 190
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void SetLastError(int errorCode);

		// Token: 0x060000BF RID: 191 RVA: 0x00003B54 File Offset: 0x00001D54
		[SuppressGCTransition]
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode)
		{
			lpOldMode = 0U;
			int num;
			int lastSystemError;
			fixed (uint* ptr = &lpOldMode)
			{
				uint* _lpOldMode_native = ptr;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<SetThreadErrorMode>g____PInvoke|226_0(dwNewMode, _lpOldMode_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000C0 RID: 192
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL SystemTimeToFileTime(Interop.Kernel32.SYSTEMTIME* lpSystemTime, ulong* lpFileTime);

		// Token: 0x060000C1 RID: 193
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern uint WaitForMultipleObjectsEx(uint nCount, IntPtr lpHandles, Interop.BOOL bWaitAll, uint dwMilliseconds, Interop.BOOL bAlertable);

		// Token: 0x060000C2 RID: 194
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern uint SignalObjectAndWait(IntPtr hObjectToSignal, IntPtr hObjectToWaitOn, uint dwMilliseconds, Interop.BOOL bAlertable);

		// Token: 0x060000C3 RID: 195
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern IntPtr GetCurrentThread();

		// Token: 0x060000C4 RID: 196 RVA: 0x00003B88 File Offset: 0x00001D88
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetThreadIOPendingFlag(IntPtr hThread, out Interop.BOOL lpIOIsPending)
		{
			lpIOIsPending = Interop.BOOL.FALSE;
			int num;
			int lastSystemError;
			fixed (Interop.BOOL* ptr = &lpIOIsPending)
			{
				Interop.BOOL* _lpIOIsPending_native = ptr;
				Marshal.SetLastSystemError(0);
				num = Interop.Kernel32.<GetThreadIOPendingFlag>g____PInvoke|249_0(hThread, _lpIOIsPending_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003BBC File Offset: 0x00001DBC
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetDynamicTimeZoneInformation(out Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation)
		{
			pTimeZoneInformation = default(Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION);
			uint result;
			int lastSystemError;
			fixed (Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION* ptr = &pTimeZoneInformation)
			{
				Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION* _pTimeZoneInformation_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetDynamicTimeZoneInformation>g____PInvoke|254_0(_pTimeZoneInformation_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003BEC File Offset: 0x00001DEC
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetTimeZoneInformation(out Interop.Kernel32.TIME_ZONE_INFORMATION lpTimeZoneInformation)
		{
			lpTimeZoneInformation = default(Interop.Kernel32.TIME_ZONE_INFORMATION);
			uint result;
			int lastSystemError;
			fixed (Interop.Kernel32.TIME_ZONE_INFORMATION* ptr = &lpTimeZoneInformation)
			{
				Interop.Kernel32.TIME_ZONE_INFORMATION* _lpTimeZoneInformation_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetTimeZoneInformation>g____PInvoke|255_0(_lpTimeZoneInformation_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000C7 RID: 199
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL TzSpecificLocalTimeToSystemTime(IntPtr lpTimeZoneInformation, Interop.Kernel32.SYSTEMTIME* lpLocalTime, Interop.Kernel32.SYSTEMTIME* lpUniversalTime);

		// Token: 0x060000C8 RID: 200
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern void* VirtualAlloc(void* lpAddress, UIntPtr dwSize, int flAllocationType, int flProtect);

		// Token: 0x060000C9 RID: 201 RVA: 0x00003C1C File Offset: 0x00001E1C
		[LibraryImport("kernel32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool VirtualFree(void* lpAddress, UIntPtr dwSize, int dwFreeType)
		{
			return Interop.Kernel32.<VirtualFree>g____PInvoke|259_0(lpAddress, dwSize, dwFreeType) != 0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003C2C File Offset: 0x00001E2C
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static UIntPtr VirtualQuery(void* lpAddress, ref Interop.Kernel32.MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength)
		{
			UIntPtr result;
			int lastSystemError;
			fixed (Interop.Kernel32.MEMORY_BASIC_INFORMATION* ptr = &lpBuffer)
			{
				Interop.Kernel32.MEMORY_BASIC_INFORMATION* _lpBuffer_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<VirtualQuery>g____PInvoke|260_0(lpAddress, _lpBuffer_native, dwLength);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000CB RID: 203
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern int WideCharToMultiByte(uint CodePage, uint dwFlags, char* lpWideCharStr, int cchWideChar, byte* lpMultiByteStr, int cbMultiByte, byte* lpDefaultChar, Interop.BOOL* lpUsedDefaultChar);

		// Token: 0x060000CC RID: 204 RVA: 0x00003C5C File Offset: 0x00001E5C
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int WriteFile(IntPtr handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, IntPtr mustBeZero)
		{
			numBytesWritten = 0;
			int result;
			int lastSystemError;
			fixed (int* ptr = &numBytesWritten)
			{
				int* _numBytesWritten_native = ptr;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<WriteFile>g____PInvoke|266_0(handle, bytes, numBytesToWrite, _numBytesWritten_native, mustBeZero);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003C90 File Offset: 0x00001E90
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int WriteFile(SafeHandle handle, byte* bytes, int numBytesToWrite, IntPtr numBytesWritten_mustBeZero, NativeOverlapped* lpOverlapped)
		{
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<WriteFile>g____PInvoke|268_0(_handle_native, bytes, numBytesToWrite, numBytesWritten_mustBeZero, lpOverlapped);
				lastSystemError = Marshal.GetLastSystemError();
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int WriteFile(SafeHandle handle, byte* bytes, int numBytesToWrite, out int numBytesWritten, NativeOverlapped* lpOverlapped)
		{
			numBytesWritten = 0;
			int result = 0;
			SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				try
				{
					fixed (int* ptr = &numBytesWritten)
					{
						int* _numBytesWritten_native = ptr;
						IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						result = Interop.Kernel32.<WriteFile>g____PInvoke|269_0(_handle_native, bytes, numBytesToWrite, _numBytesWritten_native, lpOverlapped);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					int* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003D6C File Offset: 0x00001F6C
		[LibraryImport("kernel32.dll", EntryPoint = "GetModuleHandleW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static IntPtr GetModuleHandle(string moduleName)
		{
			IntPtr result;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(moduleName))
			{
				void* _moduleName_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				result = Interop.Kernel32.<GetModuleHandle>g____PInvoke|270_0((ushort*)_moduleName_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003D9C File Offset: 0x00001F9C
		[LibraryImport("kernel32.dll")]
		[SuppressGCTransition]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetCurrentProcessorNumberEx(out Interop.Kernel32.PROCESSOR_NUMBER ProcNumber)
		{
			ProcNumber = default(Interop.Kernel32.PROCESSOR_NUMBER);
			uint result;
			fixed (Interop.Kernel32.PROCESSOR_NUMBER* ptr = &ProcNumber)
			{
				result = Interop.Kernel32.<GetCurrentProcessorNumberEx>g____PInvoke|272_0(ptr);
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal static extern void Sleep(uint milliseconds);

		// Token: 0x060000D2 RID: 210 RVA: 0x00003DBC File Offset: 0x00001FBC
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool CloseHandle(IntPtr handle)
		{
			Marshal.SetLastSystemError(0);
			int num = Interop.Kernel32.<CloseHandle>g____PInvoke|274_0(handle);
			int lastSystemError = Marshal.GetLastSystemError();
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003DE4 File Offset: 0x00001FE4
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool SetEvent(SafeWaitHandle handle)
		{
			bool result = false;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<SetEvent>g____PInvoke|285_0(_handle_native);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003E40 File Offset: 0x00002040
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool ResetEvent(SafeWaitHandle handle)
		{
			bool result = false;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<ResetEvent>g____PInvoke|286_0(_handle_native);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003E9C File Offset: 0x0000209C
		[LibraryImport("kernel32.dll", EntryPoint = "CreateEventExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static SafeWaitHandle CreateEventEx(IntPtr lpSecurityAttributes, string name, uint flags, uint desiredAccess)
		{
			bool flag = false;
			SafeWaitHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(name))
					{
						void* _name_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<CreateEventEx>g____PInvoke|287_0(lpSecurityAttributes, (ushort*)_name_native, flags, desiredAccess);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003F24 File Offset: 0x00002124
		[LibraryImport("kernel32.dll", EntryPoint = "OpenEventW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static SafeWaitHandle OpenEvent(uint desiredAccess, [MarshalAs(UnmanagedType.Bool)] bool inheritHandle, string name)
		{
			bool flag = false;
			SafeWaitHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				int _inheritHandle_native = (inheritHandle > false) ? 1 : 0;
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(name))
					{
						void* _name_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<OpenEvent>g____PInvoke|288_0(desiredAccess, _inheritHandle_native, (ushort*)_name_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003FB8 File Offset: 0x000021B8
		[LibraryImport("kernel32.dll", EntryPoint = "GetEnvironmentVariableW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static uint GetEnvironmentVariable(string lpName, ref char lpBuffer, uint nSize)
		{
			uint result;
			int lastSystemError;
			fixed (char* ptr = &lpBuffer)
			{
				char* _lpBuffer_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpName))
				{
					void* _lpName_native = (void*)pinnableReference;
					Marshal.SetLastSystemError(0);
					result = Interop.Kernel32.<GetEnvironmentVariable>g____PInvoke|289_0((ushort*)_lpName_native, _lpBuffer_native, nSize);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000D8 RID: 216
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern char* GetEnvironmentStringsW();

		// Token: 0x060000D9 RID: 217
		[LibraryImport("kernel32.dll")]
		[DllImport("kernel32.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL FreeEnvironmentStringsW(char* lpszEnvironmentBlock);

		// Token: 0x060000DA RID: 218 RVA: 0x00003FF2 File Offset: 0x000021F2
		[LibraryImport("kernel32.dll", EntryPoint = "FormatMessageW", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		private unsafe static int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, void* lpBuffer, int nSize, IntPtr arguments)
		{
			Marshal.SetLastSystemError(0);
			int result = Interop.Kernel32.<FormatMessage>g____PInvoke|298_0(dwFlags, lpSource, dwMessageId, dwLanguageId, lpBuffer, nSize, arguments);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004013 File Offset: 0x00002213
		internal static string GetMessage(int errorCode)
		{
			return Interop.Kernel32.GetMessage(errorCode, IntPtr.Zero);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004020 File Offset: 0x00002220
		internal unsafe static string GetMessage(int errorCode, IntPtr moduleHandle)
		{
			int num = 12800;
			if (moduleHandle != IntPtr.Zero)
			{
				num |= 2048;
			}
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			fixed (char* pinnableReference = span.GetPinnableReference())
			{
				char* lpBuffer = pinnableReference;
				int num2 = Interop.Kernel32.FormatMessage(num, moduleHandle, (uint)errorCode, 0, (void*)lpBuffer, span.Length, IntPtr.Zero);
				if (num2 > 0)
				{
					return Interop.Kernel32.GetAndTrimString(span.Slice(0, num2));
				}
			}
			if (Marshal.GetLastWin32Error() == 122)
			{
				IntPtr intPtr = (IntPtr)0;
				try
				{
					int num3 = Interop.Kernel32.FormatMessage(num | 256, moduleHandle, (uint)errorCode, 0, (void*)(&intPtr), 0, IntPtr.Zero);
					if (num3 > 0)
					{
						return Interop.Kernel32.GetAndTrimString(new ReadOnlySpan<char>(intPtr, num3));
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Unknown error (0x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(errorCode, "x");
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004128 File Offset: 0x00002328
		private unsafe static string GetAndTrimString(ReadOnlySpan<char> buffer)
		{
			int num = buffer.Length;
			while (num > 0 && *buffer[num - 1] <= 32)
			{
				num--;
			}
			return buffer.Slice(0, num).ToString();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004170 File Offset: 0x00002370
		[LibraryImport("kernel32.dll", EntryPoint = "OpenMutexW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static SafeWaitHandle OpenMutex(uint desiredAccess, [MarshalAs(UnmanagedType.Bool)] bool inheritHandle, string name)
		{
			bool flag = false;
			SafeWaitHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				int _inheritHandle_native = (inheritHandle > false) ? 1 : 0;
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(name))
					{
						void* _name_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<OpenMutex>g____PInvoke|303_0(desiredAccess, _inheritHandle_native, (ushort*)_name_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004204 File Offset: 0x00002404
		[LibraryImport("kernel32.dll", EntryPoint = "CreateMutexExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static SafeWaitHandle CreateMutexEx(IntPtr lpMutexAttributes, string name, uint flags, uint desiredAccess)
		{
			bool flag = false;
			SafeWaitHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(name))
					{
						void* _name_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<CreateMutexEx>g____PInvoke|304_0(lpMutexAttributes, (ushort*)_name_native, flags, desiredAccess);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000428C File Offset: 0x0000248C
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool ReleaseMutex(SafeWaitHandle handle)
		{
			bool result = false;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Kernel32.<ReleaseMutex>g____PInvoke|305_0(_handle_native);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000042E8 File Offset: 0x000024E8
		[LibraryImport("kernel32.dll", EntryPoint = "OpenSemaphoreW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static SafeWaitHandle OpenSemaphore(uint desiredAccess, [MarshalAs(UnmanagedType.Bool)] bool inheritHandle, string name)
		{
			bool flag = false;
			SafeWaitHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				int _inheritHandle_native = (inheritHandle > false) ? 1 : 0;
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(name))
					{
						void* _name_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<OpenSemaphore>g____PInvoke|306_0(desiredAccess, _inheritHandle_native, (ushort*)_name_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000437C File Offset: 0x0000257C
		[LibraryImport("kernel32.dll", EntryPoint = "CreateSemaphoreExW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static SafeWaitHandle CreateSemaphoreEx(IntPtr lpSecurityAttributes, int initialCount, int maximumCount, string name, uint flags, uint desiredAccess)
		{
			bool flag = false;
			SafeWaitHandle result = null;
			IntPtr value = (IntPtr)0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(name))
					{
						void* _name_native = (void*)ptr;
						Marshal.SetLastSystemError(0);
						value = Interop.Kernel32.<CreateSemaphoreEx>g____PInvoke|307_0(lpSecurityAttributes, initialCount, maximumCount, (ushort*)_name_native, flags, desiredAccess);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004408 File Offset: 0x00002608
		[LibraryImport("kernel32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool ReleaseSemaphore(SafeWaitHandle handle, int releaseCount, out int previousCount)
		{
			previousCount = 0;
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeWaitHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(handle);
				try
				{
					fixed (int* ptr = &previousCount)
					{
						int* _previousCount_native = ptr;
						IntPtr _handle_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Kernel32.<ReleaseSemaphore>g____PInvoke|308_0(_handle_native, releaseCount, _previousCount_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					int* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000448C File Offset: 0x0000268C
		[LibraryImport("kernel32.dll", EntryPoint = "SetEnvironmentVariableW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool SetEnvironmentVariable(string lpName, string lpValue)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpValue))
			{
				void* _lpValue_native = (void*)pinnableReference;
				fixed (char* pinnableReference2 = Utf16StringMarshaller.GetPinnableReference(lpName))
				{
					void* _lpName_native = (void*)pinnableReference2;
					Marshal.SetLastSystemError(0);
					num = Interop.Kernel32.<SetEnvironmentVariable>g____PInvoke|309_0((ushort*)_lpName_native, (ushort*)_lpValue_native);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060000E5 RID: 229
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "LocaleNameToLCID", ExactSpelling = true)]
		internal unsafe static extern int <LocaleNameToLCID>g____PInvoke|26_0(ushort* __lpName_native, uint __dwFlags_native);

		// Token: 0x060000E6 RID: 230
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "LCMapStringEx", ExactSpelling = true)]
		internal unsafe static extern int <LCMapStringEx>g____PInvoke|27_0(ushort* __lpLocaleName_native, uint __dwMapFlags_native, char* __lpSrcStr_native, int __cchSrc_native, void* __lpDestStr_native, int __cchDest_native, void* __lpVersionInformation_native, void* __lpReserved_native, IntPtr __sortHandle_native);

		// Token: 0x060000E7 RID: 231
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CompareStringOrdinal", ExactSpelling = true)]
		internal unsafe static extern int <CompareStringOrdinal>g____PInvoke|30_0(char* __lpString1_native, int __cchCount1_native, char* __lpString2_native, int __cchCount2_native, int __bIgnoreCase_native);

		// Token: 0x060000E8 RID: 232
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "IsNLSDefinedString", ExactSpelling = true)]
		internal unsafe static extern int <IsNLSDefinedString>g____PInvoke|32_0(int __Function_native, uint __dwFlags_native, IntPtr __lpVersionInformation_native, char* __lpString_native, int __cchStr_native);

		// Token: 0x060000E9 RID: 233
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetLocaleInfoEx", ExactSpelling = true)]
		internal unsafe static extern int <GetLocaleInfoEx>g____PInvoke|34_0(ushort* __lpLocaleName_native, uint __LCType_native, void* __lpLCData_native, int __cchData_native);

		// Token: 0x060000EA RID: 234
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "EnumSystemLocalesEx", ExactSpelling = true)]
		internal unsafe static extern int <EnumSystemLocalesEx>g____PInvoke|35_0(method __lpLocaleEnumProcEx_native, char __dwFlags_native, Interop.BOOL __lParam_native, char* __reserved_native);

		// Token: 0x060000EB RID: 235
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "EnumTimeFormatsEx", ExactSpelling = true)]
		internal unsafe static extern int <EnumTimeFormatsEx>g____PInvoke|36_0(method __lpTimeFmtEnumProcEx_native, bool __lpLocaleName_native, Interop.BOOL __dwFlags_native, char* __lParam_native);

		// Token: 0x060000EC RID: 236
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetCalendarInfoEx", ExactSpelling = true)]
		internal unsafe static extern int <GetCalendarInfoEx>g____PInvoke|37_0(ushort* __lpLocaleName_native, uint __Calendar_native, IntPtr __lpReserved_native, uint __CalType_native, IntPtr __lpCalData_native, int __cchData_native, int* __lpValue_native);

		// Token: 0x060000ED RID: 237
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetCalendarInfoEx", ExactSpelling = true)]
		internal unsafe static extern int <GetCalendarInfoEx>g____PInvoke|38_0(ushort* __lpLocaleName_native, uint __Calendar_native, IntPtr __lpReserved_native, uint __CalType_native, IntPtr __lpCalData_native, int __cchData_native, IntPtr __lpValue_native);

		// Token: 0x060000EE RID: 238
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "EnumCalendarInfoExEx", ExactSpelling = true)]
		internal unsafe static extern int <EnumCalendarInfoExEx>g____PInvoke|41_0(method __pCalInfoEnumProcExEx_native, sbyte __lpLocaleName_native, Interop.BOOL __Calendar_native, char* __lpReserved_native, uint __CalType_native, IntPtr __lParam_native);

		// Token: 0x060000EF RID: 239
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetNLSVersionEx", ExactSpelling = true)]
		internal unsafe static extern int <GetNLSVersionEx>g____PInvoke|43_0(int __function_native, ushort* __localeName_native, Interop.Kernel32.NlsVersionInfoEx* __lpVersionInformation_native);

		// Token: 0x060000F0 RID: 240
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ResolveLocaleName", ExactSpelling = true)]
		internal unsafe static extern int <ResolveLocaleName>g____PInvoke|45_0(ushort* __lpNameToResolve_native, char* __lpLocaleName_native, int __cchLocaleName_native);

		// Token: 0x060000F1 RID: 241
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CancelIoEx", ExactSpelling = true)]
		internal unsafe static extern int <CancelIoEx>g____PInvoke|46_0(IntPtr __handle_native, NativeOverlapped* __lpOverlapped_native);

		// Token: 0x060000F2 RID: 242
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CancelSynchronousIo", ExactSpelling = true)]
		internal static extern int <CancelSynchronousIo>g____PInvoke|48_0(IntPtr __hThread_native);

		// Token: 0x060000F3 RID: 243
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateIoCompletionPort", ExactSpelling = true)]
		internal static extern IntPtr <CreateIoCompletionPort>g____PInvoke|49_0(IntPtr __FileHandle_native, IntPtr __ExistingCompletionPort_native, UIntPtr __CompletionKey_native, int __NumberOfConcurrentThreads_native);

		// Token: 0x060000F4 RID: 244
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "PostQueuedCompletionStatus", ExactSpelling = true)]
		internal static extern int <PostQueuedCompletionStatus>g____PInvoke|50_0(IntPtr __CompletionPort_native, uint __dwNumberOfBytesTransferred_native, UIntPtr __CompletionKey_native, IntPtr __lpOverlapped_native);

		// Token: 0x060000F5 RID: 245
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetQueuedCompletionStatus", ExactSpelling = true)]
		internal unsafe static extern int <GetQueuedCompletionStatus>g____PInvoke|51_0(IntPtr __CompletionPort_native, uint* __lpNumberOfBytesTransferred_native, UIntPtr* __CompletionKey_native, IntPtr* __lpOverlapped_native, int __dwMilliseconds_native);

		// Token: 0x060000F6 RID: 246
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetQueuedCompletionStatusEx", ExactSpelling = true)]
		internal unsafe static extern int <GetQueuedCompletionStatusEx>g____PInvoke|52_0(IntPtr __CompletionPort_native, Interop.Kernel32.OVERLAPPED_ENTRY* __lpCompletionPortEntries_native, int __ulCount_native, int* __ulNumEntriesRemoved_native, int __dwMilliseconds_native, int __fAlertable_native);

		// Token: 0x060000F7 RID: 247
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SleepConditionVariableCS", ExactSpelling = true)]
		internal unsafe static extern int <SleepConditionVariableCS>g____PInvoke|57_0(Interop.Kernel32.CONDITION_VARIABLE* __ConditionVariable_native, Interop.Kernel32.CRITICAL_SECTION* __CriticalSection_native, int __dwMilliseconds_native);

		// Token: 0x060000F8 RID: 248
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CopyFileExW", ExactSpelling = true)]
		internal unsafe static extern int <CopyFileExPrivate>g____PInvoke|59_0(ushort* __src_native, ushort* __dst_native, IntPtr __progressRoutine_native, IntPtr __progressData_native, int* __cancel_native, int __flags_native);

		// Token: 0x060000F9 RID: 249
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateDirectoryW", ExactSpelling = true)]
		internal unsafe static extern int <CreateDirectoryPrivate>g____PInvoke|61_0(ushort* __path_native, Interop.Kernel32.SECURITY_ATTRIBUTES* __lpSecurityAttributes_native);

		// Token: 0x060000FA RID: 250
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateFileW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <CreateFilePrivate>g____PInvoke|63_0(ushort* __lpFileName_native, int __dwDesiredAccess_native, FileShare __dwShareMode_native, Interop.Kernel32.SECURITY_ATTRIBUTES* __lpSecurityAttributes_native, FileMode __dwCreationDisposition_native, int __dwFlagsAndAttributes_native, IntPtr __hTemplateFile_native);

		// Token: 0x060000FB RID: 251
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateThreadpoolIo", ExactSpelling = true)]
		internal static extern IntPtr <CreateThreadpoolIo>g____PInvoke|68_0(IntPtr __fl_native, method __pfnio_native, short __context_native, void __pcbe_native);

		// Token: 0x060000FC RID: 252
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "StartThreadpoolIo", ExactSpelling = true)]
		internal static extern void <StartThreadpoolIo>g____PInvoke|70_0(IntPtr __pio_native);

		// Token: 0x060000FD RID: 253
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CancelThreadpoolIo", ExactSpelling = true)]
		internal static extern void <CancelThreadpoolIo>g____PInvoke|71_0(IntPtr __pio_native);

		// Token: 0x060000FE RID: 254
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "WaitForThreadpoolWaitCallbacks", ExactSpelling = true)]
		internal static extern void <WaitForThreadpoolWaitCallbacks>g____PInvoke|77_0(IntPtr __pwa_native, int __fCancelPendingCallbacks_native);

		// Token: 0x060000FF RID: 255
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "DeleteFileW", ExactSpelling = true)]
		internal unsafe static extern int <DeleteFilePrivate>g____PInvoke|80_0(ushort* __path_native);

		// Token: 0x06000100 RID: 256
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "DeleteVolumeMountPointW", ExactSpelling = true)]
		internal unsafe static extern int <DeleteVolumeMountPointPrivate>g____PInvoke|82_0(ushort* __mountPoint_native);

		// Token: 0x06000101 RID: 257
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateFileW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <CreateFilePrivate_IntPtr>g____PInvoke|84_0(ushort* __lpFileName_native, int __dwDesiredAccess_native, FileShare __dwShareMode_native, Interop.Kernel32.SECURITY_ATTRIBUTES* __lpSecurityAttributes_native, FileMode __dwCreationDisposition_native, int __dwFlagsAndAttributes_native, IntPtr __hTemplateFile_native);

		// Token: 0x06000102 RID: 258
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateSymbolicLinkW", ExactSpelling = true)]
		internal unsafe static extern byte <CreateSymbolicLinkPrivate>g____PInvoke|88_0(ushort* __lpSymlinkFileName_native, ushort* __lpTargetFileName_native, int __dwFlags_native);

		// Token: 0x06000103 RID: 259
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "DeviceIoControl", ExactSpelling = true)]
		internal unsafe static extern int <DeviceIoControl>g____PInvoke|97_0(IntPtr __hDevice_native, uint __dwIoControlCode_native, void* __lpInBuffer_native, uint __nInBufferSize_native, void* __lpOutBuffer_native, uint __nOutBufferSize_native, uint* __lpBytesReturned_native, IntPtr __lpOverlapped_native);

		// Token: 0x06000104 RID: 260
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ExpandEnvironmentStringsW", ExactSpelling = true)]
		internal unsafe static extern uint <ExpandEnvironmentStrings>g____PInvoke|98_0(ushort* __lpSrc_native, char* __lpDst_native, uint __nSize_native);

		// Token: 0x06000105 RID: 261
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "FindNextFileW", ExactSpelling = true)]
		internal unsafe static extern int <FindNextFile>g____PInvoke|109_0(IntPtr __hndFindFile_native, Interop.Kernel32.WIN32_FIND_DATA* __lpFindFileData_native);

		// Token: 0x06000106 RID: 262
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "FindClose", ExactSpelling = true)]
		internal static extern int <FindClose>g____PInvoke|114_0(IntPtr __hFindFile_native);

		// Token: 0x06000107 RID: 263
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "FindFirstFileExW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <FindFirstFileExPrivate>g____PInvoke|115_0(ushort* __lpFileName_native, Interop.Kernel32.FINDEX_INFO_LEVELS __fInfoLevelId_native, Interop.Kernel32.WIN32_FIND_DATA* __lpFindFileData_native, Interop.Kernel32.FINDEX_SEARCH_OPS __fSearchOp_native, IntPtr __lpSearchFilter_native, int __dwAdditionalFlags_native);

		// Token: 0x06000108 RID: 264
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "FlushFileBuffers", ExactSpelling = true)]
		internal static extern int <FlushFileBuffers>g____PInvoke|119_0(IntPtr __hHandle_native);

		// Token: 0x06000109 RID: 265
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "FreeLibrary", ExactSpelling = true)]
		internal static extern int <FreeLibrary>g____PInvoke|120_0(IntPtr __hModule_native);

		// Token: 0x0600010A RID: 266
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetCurrentDirectoryW", ExactSpelling = true)]
		internal unsafe static extern uint <GetCurrentDirectory>g____PInvoke|131_0(uint __nBufferLength_native, char* __lpBuffer_native);

		// Token: 0x0600010B RID: 267
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetFileAttributesExW", ExactSpelling = true)]
		internal unsafe static extern int <GetFileAttributesExPrivate>g____PInvoke|135_0(ushort* __name_native, Interop.Kernel32.GET_FILEEX_INFO_LEVELS __fileInfoLevel_native, Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA* __lpFileInformation_native);

		// Token: 0x0600010C RID: 268
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetFileInformationByHandle", ExactSpelling = true)]
		internal unsafe static extern int <GetFileInformationByHandle>g____PInvoke|137_0(IntPtr __hFile_native, Interop.Kernel32.BY_HANDLE_FILE_INFORMATION* __lpFileInformation_native);

		// Token: 0x0600010D RID: 269
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetFileInformationByHandleEx", ExactSpelling = true)]
		internal unsafe static extern int <GetFileInformationByHandleEx>g____PInvoke|138_0(IntPtr __hFile_native, int __FileInformationClass_native, void* __lpFileInformation_native, uint __dwBufferSize_native);

		// Token: 0x0600010E RID: 270
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetFileType", ExactSpelling = true)]
		internal static extern int <GetFileType>g____PInvoke|139_0(IntPtr __hFile_native);

		// Token: 0x0600010F RID: 271
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetFinalPathNameByHandleW", ExactSpelling = true)]
		internal unsafe static extern uint <GetFinalPathNameByHandle>g____PInvoke|141_0(IntPtr __hFile_native, char* __lpszFilePath_native, uint __cchFilePath_native, uint __dwFlags_native);

		// Token: 0x06000110 RID: 272
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetFullPathNameW", ExactSpelling = true)]
		internal unsafe static extern uint <GetFullPathNameW>g____PInvoke|142_0(char* __lpFileName_native, uint __nBufferLength_native, char* __lpBuffer_native, IntPtr __lpFilePart_native);

		// Token: 0x06000111 RID: 273
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetLogicalDrives", ExactSpelling = true)]
		internal static extern int <GetLogicalDrives>g____PInvoke|143_0();

		// Token: 0x06000112 RID: 274
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetLongPathNameW", ExactSpelling = true)]
		internal unsafe static extern uint <GetLongPathNameW>g____PInvoke|144_0(char* __lpszShortPath_native, char* __lpszLongPath_native, uint __cchBuffer_native);

		// Token: 0x06000113 RID: 275
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetModuleFileNameW", ExactSpelling = true)]
		internal unsafe static extern uint <GetModuleFileName>g____PInvoke|145_0(IntPtr __hModule_native, char* __lpFilename_native, uint __nSize_native);

		// Token: 0x06000114 RID: 276
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetOverlappedResult", ExactSpelling = true)]
		internal unsafe static extern int <GetOverlappedResult>g____PInvoke|147_0(IntPtr __hFile_native, NativeOverlapped* __lpOverlapped_native, int* __lpNumberOfBytesTransferred_native, int __bWait_native);

		// Token: 0x06000115 RID: 277
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "K32GetProcessMemoryInfo", ExactSpelling = true)]
		internal unsafe static extern int <GetProcessMemoryInfo>g____PInvoke|149_0(IntPtr __Process_native, Interop.Kernel32.PROCESS_MEMORY_COUNTERS* __ppsmemCounters_native, uint __cb_native);

		// Token: 0x06000116 RID: 278
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetProcessTimes", ExactSpelling = true)]
		internal unsafe static extern int <GetProcessTimes>g____PInvoke|150_0(IntPtr __handleProcess_native, long* __creation_native, long* __exit_native, long* __kernel_native, long* __user_native);

		// Token: 0x06000117 RID: 279
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetSystemDirectoryW", ExactSpelling = true)]
		internal unsafe static extern uint <GetSystemDirectoryW>g____PInvoke|152_0(char* __lpBuffer_native, uint __uSize_native);

		// Token: 0x06000118 RID: 280
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetSystemTimes", ExactSpelling = true)]
		internal unsafe static extern int <GetSystemTimes>g____PInvoke|155_0(long* __idle_native, long* __kernel_native, long* __user_native);

		// Token: 0x06000119 RID: 281
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationW", ExactSpelling = true)]
		internal unsafe static extern int <GetVolumeInformation>g____PInvoke|156_0(ushort* __drive_native, char* __volumeName_native, int __volumeNameBufLen_native, int* __volSerialNumber_native, int* __maxFileNameLen_native, int* __fileSystemFlags_native, char* __fileSystemName_native, int __fileSystemNameBufLen_native);

		// Token: 0x0600011A RID: 282
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <LoadLibraryEx>g____PInvoke|163_0(ushort* __libFilename_native, IntPtr __reserved_native, int __flags_native);

		// Token: 0x0600011B RID: 283
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "LockFile", ExactSpelling = true)]
		internal static extern int <LockFile>g____PInvoke|175_0(IntPtr __handle_native, int __offsetLow_native, int __offsetHigh_native, int __countLow_native, int __countHigh_native);

		// Token: 0x0600011C RID: 284
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "UnlockFile", ExactSpelling = true)]
		internal static extern int <UnlockFile>g____PInvoke|176_0(IntPtr __handle_native, int __offsetLow_native, int __offsetHigh_native, int __countLow_native, int __countHigh_native);

		// Token: 0x0600011D RID: 285
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "MoveFileExW", ExactSpelling = true)]
		internal unsafe static extern int <MoveFileExPrivate>g____PInvoke|188_0(ushort* __src_native, ushort* __dst_native, uint __flags_native);

		// Token: 0x0600011E RID: 286
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "OpenThread", ExactSpelling = true)]
		internal static extern IntPtr <OpenThread>g____PInvoke|191_0(int __dwDesiredAccess_native, int __bInheritHandle_native, int __dwThreadId_native);

		// Token: 0x0600011F RID: 287
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "OutputDebugStringW", ExactSpelling = true)]
		internal unsafe static extern void <OutputDebugString>g____PInvoke|193_0(ushort* __message_native);

		// Token: 0x06000120 RID: 288
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "QueryUnbiasedInterruptTime", ExactSpelling = true)]
		internal unsafe static extern int <QueryUnbiasedInterruptTime>g____PInvoke|196_0(ulong* __UnbiasedTime_native);

		// Token: 0x06000121 RID: 289
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ReadFile", ExactSpelling = true)]
		internal unsafe static extern int <ReadFile>g____PInvoke|198_0(IntPtr __handle_native, byte* __bytes_native, int __numBytesToRead_native, IntPtr __numBytesRead_mustBeZero_native, NativeOverlapped* __overlapped_native);

		// Token: 0x06000122 RID: 290
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ReadFile", ExactSpelling = true)]
		internal unsafe static extern int <ReadFile>g____PInvoke|199_0(IntPtr __handle_native, byte* __bytes_native, int __numBytesToRead_native, int* __numBytesRead_native, NativeOverlapped* __overlapped_native);

		// Token: 0x06000123 RID: 291
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ReadFileScatter", ExactSpelling = true)]
		internal unsafe static extern int <ReadFileScatter>g____PInvoke|200_0(IntPtr __hFile_native, long* __aSegmentArray_native, int __nNumberOfBytesToRead_native, IntPtr __lpReserved_native, NativeOverlapped* __lpOverlapped_native);

		// Token: 0x06000124 RID: 292
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "WriteFileGather", ExactSpelling = true)]
		internal unsafe static extern int <WriteFileGather>g____PInvoke|201_0(IntPtr __hFile_native, long* __aSegmentArray_native, int __nNumberOfBytesToWrite_native, IntPtr __lpReserved_native, NativeOverlapped* __lpOverlapped_native);

		// Token: 0x06000125 RID: 293
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "RemoveDirectoryW", ExactSpelling = true)]
		internal unsafe static extern int <RemoveDirectoryPrivate>g____PInvoke|202_0(ushort* __path_native);

		// Token: 0x06000126 RID: 294
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ReplaceFileW", ExactSpelling = true)]
		internal unsafe static extern int <ReplaceFilePrivate>g____PInvoke|208_0(ushort* __replacedFileName_native, ushort* __replacementFileName_native, ushort* __backupFileName_native, int __dwReplaceFlags_native, IntPtr __lpExclude_native, IntPtr __lpReserved_native);

		// Token: 0x06000127 RID: 295
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetConsoleCtrlHandler", ExactSpelling = true)]
		internal static extern int <SetConsoleCtrlHandler>g____PInvoke|219_0(method __handler_native, void __Add_native);

		// Token: 0x06000128 RID: 296
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetCurrentDirectoryW", ExactSpelling = true)]
		internal unsafe static extern int <SetCurrentDirectory>g____PInvoke|220_0(ushort* __path_native);

		// Token: 0x06000129 RID: 297
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetFileAttributesW", ExactSpelling = true)]
		internal unsafe static extern int <SetFileAttributesPrivate>g____PInvoke|221_0(ushort* __name_native, int __attr_native);

		// Token: 0x0600012A RID: 298
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetFileInformationByHandle", ExactSpelling = true)]
		internal unsafe static extern int <SetFileInformationByHandle>g____PInvoke|223_0(IntPtr __hFile_native, int __FileInformationClass_native, void* __lpFileInformation_native, uint __dwBufferSize_native);

		// Token: 0x0600012B RID: 299
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetFilePointerEx", ExactSpelling = true)]
		internal unsafe static extern int <SetFilePointerEx>g____PInvoke|224_0(IntPtr __hFile_native, long __liDistanceToMove_native, long* __lpNewFilePointer_native, uint __dwMoveMethod_native);

		// Token: 0x0600012C RID: 300
		[CompilerGenerated]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", EntryPoint = "SetThreadErrorMode", ExactSpelling = true)]
		internal unsafe static extern int <SetThreadErrorMode>g____PInvoke|226_0(uint __dwNewMode_native, uint* __lpOldMode_native);

		// Token: 0x0600012D RID: 301
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetThreadIOPendingFlag", ExactSpelling = true)]
		internal unsafe static extern int <GetThreadIOPendingFlag>g____PInvoke|249_0(IntPtr __hThread_native, Interop.BOOL* __lpIOIsPending_native);

		// Token: 0x0600012E RID: 302
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetDynamicTimeZoneInformation", ExactSpelling = true)]
		internal unsafe static extern uint <GetDynamicTimeZoneInformation>g____PInvoke|254_0(Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION* __pTimeZoneInformation_native);

		// Token: 0x0600012F RID: 303
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetTimeZoneInformation", ExactSpelling = true)]
		internal unsafe static extern uint <GetTimeZoneInformation>g____PInvoke|255_0(Interop.Kernel32.TIME_ZONE_INFORMATION* __lpTimeZoneInformation_native);

		// Token: 0x06000130 RID: 304
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "VirtualFree", ExactSpelling = true)]
		internal unsafe static extern int <VirtualFree>g____PInvoke|259_0(void* __lpAddress_native, UIntPtr __dwSize_native, int __dwFreeType_native);

		// Token: 0x06000131 RID: 305
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "VirtualQuery", ExactSpelling = true)]
		internal unsafe static extern UIntPtr <VirtualQuery>g____PInvoke|260_0(void* __lpAddress_native, Interop.Kernel32.MEMORY_BASIC_INFORMATION* __lpBuffer_native, UIntPtr __dwLength_native);

		// Token: 0x06000132 RID: 306
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "WriteFile", ExactSpelling = true)]
		internal unsafe static extern int <WriteFile>g____PInvoke|266_0(IntPtr __handle_native, byte* __bytes_native, int __numBytesToWrite_native, int* __numBytesWritten_native, IntPtr __mustBeZero_native);

		// Token: 0x06000133 RID: 307
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "WriteFile", ExactSpelling = true)]
		internal unsafe static extern int <WriteFile>g____PInvoke|268_0(IntPtr __handle_native, byte* __bytes_native, int __numBytesToWrite_native, IntPtr __numBytesWritten_mustBeZero_native, NativeOverlapped* __lpOverlapped_native);

		// Token: 0x06000134 RID: 308
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "WriteFile", ExactSpelling = true)]
		internal unsafe static extern int <WriteFile>g____PInvoke|269_0(IntPtr __handle_native, byte* __bytes_native, int __numBytesToWrite_native, int* __numBytesWritten_native, NativeOverlapped* __lpOverlapped_native);

		// Token: 0x06000135 RID: 309
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetModuleHandleW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <GetModuleHandle>g____PInvoke|270_0(ushort* __moduleName_native);

		// Token: 0x06000136 RID: 310
		[CompilerGenerated]
		[SuppressGCTransition]
		[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessorNumberEx", ExactSpelling = true)]
		internal unsafe static extern uint <GetCurrentProcessorNumberEx>g____PInvoke|272_0(Interop.Kernel32.PROCESSOR_NUMBER* __ProcNumber_native);

		// Token: 0x06000137 RID: 311
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
		internal static extern int <CloseHandle>g____PInvoke|274_0(IntPtr __handle_native);

		// Token: 0x06000138 RID: 312
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetEvent", ExactSpelling = true)]
		internal static extern int <SetEvent>g____PInvoke|285_0(IntPtr __handle_native);

		// Token: 0x06000139 RID: 313
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ResetEvent", ExactSpelling = true)]
		internal static extern int <ResetEvent>g____PInvoke|286_0(IntPtr __handle_native);

		// Token: 0x0600013A RID: 314
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateEventExW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <CreateEventEx>g____PInvoke|287_0(IntPtr __lpSecurityAttributes_native, ushort* __name_native, uint __flags_native, uint __desiredAccess_native);

		// Token: 0x0600013B RID: 315
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "OpenEventW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <OpenEvent>g____PInvoke|288_0(uint __desiredAccess_native, int __inheritHandle_native, ushort* __name_native);

		// Token: 0x0600013C RID: 316
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "GetEnvironmentVariableW", ExactSpelling = true)]
		internal unsafe static extern uint <GetEnvironmentVariable>g____PInvoke|289_0(ushort* __lpName_native, char* __lpBuffer_native, uint __nSize_native);

		// Token: 0x0600013D RID: 317
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "FormatMessageW", ExactSpelling = true)]
		internal unsafe static extern int <FormatMessage>g____PInvoke|298_0(int __dwFlags_native, IntPtr __lpSource_native, uint __dwMessageId_native, int __dwLanguageId_native, void* __lpBuffer_native, int __nSize_native, IntPtr __arguments_native);

		// Token: 0x0600013E RID: 318
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "OpenMutexW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <OpenMutex>g____PInvoke|303_0(uint __desiredAccess_native, int __inheritHandle_native, ushort* __name_native);

		// Token: 0x0600013F RID: 319
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateMutexExW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <CreateMutexEx>g____PInvoke|304_0(IntPtr __lpMutexAttributes_native, ushort* __name_native, uint __flags_native, uint __desiredAccess_native);

		// Token: 0x06000140 RID: 320
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ReleaseMutex", ExactSpelling = true)]
		internal static extern int <ReleaseMutex>g____PInvoke|305_0(IntPtr __handle_native);

		// Token: 0x06000141 RID: 321
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "OpenSemaphoreW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <OpenSemaphore>g____PInvoke|306_0(uint __desiredAccess_native, int __inheritHandle_native, ushort* __name_native);

		// Token: 0x06000142 RID: 322
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "CreateSemaphoreExW", ExactSpelling = true)]
		internal unsafe static extern IntPtr <CreateSemaphoreEx>g____PInvoke|307_0(IntPtr __lpSecurityAttributes_native, int __initialCount_native, int __maximumCount_native, ushort* __name_native, uint __flags_native, uint __desiredAccess_native);

		// Token: 0x06000143 RID: 323
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "ReleaseSemaphore", ExactSpelling = true)]
		internal unsafe static extern int <ReleaseSemaphore>g____PInvoke|308_0(IntPtr __handle_native, int __releaseCount_native, int* __previousCount_native);

		// Token: 0x06000144 RID: 324
		[CompilerGenerated]
		[DllImport("kernel32.dll", EntryPoint = "SetEnvironmentVariableW", ExactSpelling = true)]
		internal unsafe static extern int <SetEnvironmentVariable>g____PInvoke|309_0(ushort* __lpName_native, ushort* __lpValue_native);

		// Token: 0x02000007 RID: 7
		internal struct NlsVersionInfoEx
		{
			// Token: 0x0400000A RID: 10
			internal int dwNLSVersionInfoSize;

			// Token: 0x0400000B RID: 11
			internal int dwNLSVersion;

			// Token: 0x0400000C RID: 12
			internal int dwDefinedVersion;

			// Token: 0x0400000D RID: 13
			internal int dwEffectiveId;

			// Token: 0x0400000E RID: 14
			internal Guid guidCustomVersion;
		}

		// Token: 0x02000008 RID: 8
		internal struct OVERLAPPED_ENTRY
		{
			// Token: 0x0400000F RID: 15
			public UIntPtr lpCompletionKey;

			// Token: 0x04000010 RID: 16
			public unsafe NativeOverlapped* lpOverlapped;

			// Token: 0x04000011 RID: 17
			public UIntPtr Internal;

			// Token: 0x04000012 RID: 18
			public uint dwNumberOfBytesTransferred;
		}

		// Token: 0x02000009 RID: 9
		internal struct CONDITION_VARIABLE
		{
			// Token: 0x04000013 RID: 19
			private IntPtr Ptr;
		}

		// Token: 0x0200000A RID: 10
		internal struct BY_HANDLE_FILE_INFORMATION
		{
			// Token: 0x04000014 RID: 20
			internal uint dwFileAttributes;

			// Token: 0x04000015 RID: 21
			internal Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x04000016 RID: 22
			internal Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x04000017 RID: 23
			internal Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x04000018 RID: 24
			internal uint dwVolumeSerialNumber;

			// Token: 0x04000019 RID: 25
			internal uint nFileSizeHigh;

			// Token: 0x0400001A RID: 26
			internal uint nFileSizeLow;

			// Token: 0x0400001B RID: 27
			internal uint nNumberOfLinks;

			// Token: 0x0400001C RID: 28
			internal uint nFileIndexHigh;

			// Token: 0x0400001D RID: 29
			internal uint nFileIndexLow;
		}

		// Token: 0x0200000B RID: 11
		internal struct CRITICAL_SECTION
		{
			// Token: 0x0400001E RID: 30
			private IntPtr DebugInfo;

			// Token: 0x0400001F RID: 31
			private int LockCount;

			// Token: 0x04000020 RID: 32
			private int RecursionCount;

			// Token: 0x04000021 RID: 33
			private IntPtr OwningThread;

			// Token: 0x04000022 RID: 34
			private IntPtr LockSemaphore;

			// Token: 0x04000023 RID: 35
			private UIntPtr SpinCount;
		}

		// Token: 0x0200000C RID: 12
		internal struct FILE_BASIC_INFO
		{
			// Token: 0x04000024 RID: 36
			internal long CreationTime;

			// Token: 0x04000025 RID: 37
			internal long LastAccessTime;

			// Token: 0x04000026 RID: 38
			internal long LastWriteTime;

			// Token: 0x04000027 RID: 39
			internal long ChangeTime;

			// Token: 0x04000028 RID: 40
			internal uint FileAttributes;
		}

		// Token: 0x0200000D RID: 13
		internal struct FILE_ALLOCATION_INFO
		{
			// Token: 0x04000029 RID: 41
			internal long AllocationSize;
		}

		// Token: 0x0200000E RID: 14
		internal struct FILE_END_OF_FILE_INFO
		{
			// Token: 0x0400002A RID: 42
			internal long EndOfFile;
		}

		// Token: 0x0200000F RID: 15
		internal struct FILE_STANDARD_INFO
		{
			// Token: 0x0400002B RID: 43
			internal long AllocationSize;

			// Token: 0x0400002C RID: 44
			internal long EndOfFile;

			// Token: 0x0400002D RID: 45
			internal uint NumberOfLinks;

			// Token: 0x0400002E RID: 46
			internal Interop.BOOL DeletePending;

			// Token: 0x0400002F RID: 47
			internal Interop.BOOL Directory;
		}

		// Token: 0x02000010 RID: 16
		internal struct FILE_TIME
		{
			// Token: 0x06000145 RID: 325 RVA: 0x000044D2 File Offset: 0x000026D2
			internal long ToTicks()
			{
				return (long)(((ulong)this.dwHighDateTime << 32) + (ulong)this.dwLowDateTime);
			}

			// Token: 0x06000146 RID: 326 RVA: 0x000044E6 File Offset: 0x000026E6
			internal DateTimeOffset ToDateTimeOffset()
			{
				return DateTimeOffset.FromFileTime(this.ToTicks());
			}

			// Token: 0x04000030 RID: 48
			internal uint dwLowDateTime;

			// Token: 0x04000031 RID: 49
			internal uint dwHighDateTime;
		}

		// Token: 0x02000011 RID: 17
		internal enum FINDEX_INFO_LEVELS : uint
		{
			// Token: 0x04000033 RID: 51
			FindExInfoStandard,
			// Token: 0x04000034 RID: 52
			FindExInfoBasic,
			// Token: 0x04000035 RID: 53
			FindExInfoMaxInfoLevel
		}

		// Token: 0x02000012 RID: 18
		internal enum FINDEX_SEARCH_OPS : uint
		{
			// Token: 0x04000037 RID: 55
			FindExSearchNameMatch,
			// Token: 0x04000038 RID: 56
			FindExSearchLimitToDirectories,
			// Token: 0x04000039 RID: 57
			FindExSearchLimitToDevices,
			// Token: 0x0400003A RID: 58
			FindExSearchMaxSearchOp
		}

		// Token: 0x02000013 RID: 19
		internal enum GET_FILEEX_INFO_LEVELS : uint
		{
			// Token: 0x0400003C RID: 60
			GetFileExInfoStandard,
			// Token: 0x0400003D RID: 61
			GetFileExMaxInfoLevel
		}

		// Token: 0x02000014 RID: 20
		internal struct CPINFO
		{
			// Token: 0x0400003E RID: 62
			internal int MaxCharSize;

			// Token: 0x0400003F RID: 63
			[FixedBuffer(typeof(byte), 2)]
			internal Interop.Kernel32.CPINFO.<DefaultChar>e__FixedBuffer DefaultChar;

			// Token: 0x04000040 RID: 64
			[FixedBuffer(typeof(byte), 12)]
			internal Interop.Kernel32.CPINFO.<LeadByte>e__FixedBuffer LeadByte;

			// Token: 0x02000015 RID: 21
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 2)]
			public struct <DefaultChar>e__FixedBuffer
			{
				// Token: 0x04000041 RID: 65
				public byte FixedElementField;
			}

			// Token: 0x02000016 RID: 22
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 12)]
			public struct <LeadByte>e__FixedBuffer
			{
				// Token: 0x04000042 RID: 66
				public byte FixedElementField;
			}
		}

		// Token: 0x02000017 RID: 23
		internal struct PROCESS_MEMORY_COUNTERS
		{
			// Token: 0x04000043 RID: 67
			public uint cb;

			// Token: 0x04000044 RID: 68
			public uint PageFaultCount;

			// Token: 0x04000045 RID: 69
			public UIntPtr PeakWorkingSetSize;

			// Token: 0x04000046 RID: 70
			public UIntPtr WorkingSetSize;

			// Token: 0x04000047 RID: 71
			public UIntPtr QuotaPeakPagedPoolUsage;

			// Token: 0x04000048 RID: 72
			public UIntPtr QuotaPagedPoolUsage;

			// Token: 0x04000049 RID: 73
			public UIntPtr QuotaPeakNonPagedPoolUsage;

			// Token: 0x0400004A RID: 74
			public UIntPtr QuotaNonPagedPoolUsage;

			// Token: 0x0400004B RID: 75
			public UIntPtr PagefileUsage;

			// Token: 0x0400004C RID: 76
			public UIntPtr PeakPagefileUsage;
		}

		// Token: 0x02000018 RID: 24
		internal struct MEMORY_BASIC_INFORMATION
		{
			// Token: 0x0400004D RID: 77
			internal unsafe void* BaseAddress;

			// Token: 0x0400004E RID: 78
			internal unsafe void* AllocationBase;

			// Token: 0x0400004F RID: 79
			internal uint AllocationProtect;

			// Token: 0x04000050 RID: 80
			internal UIntPtr RegionSize;

			// Token: 0x04000051 RID: 81
			internal uint State;

			// Token: 0x04000052 RID: 82
			internal uint Protect;

			// Token: 0x04000053 RID: 83
			internal uint Type;
		}

		// Token: 0x02000019 RID: 25
		internal struct MEMORYSTATUSEX
		{
			// Token: 0x04000054 RID: 84
			internal uint dwLength;

			// Token: 0x04000055 RID: 85
			internal uint dwMemoryLoad;

			// Token: 0x04000056 RID: 86
			internal ulong ullTotalPhys;

			// Token: 0x04000057 RID: 87
			internal ulong ullAvailPhys;

			// Token: 0x04000058 RID: 88
			internal ulong ullTotalPageFile;

			// Token: 0x04000059 RID: 89
			internal ulong ullAvailPageFile;

			// Token: 0x0400005A RID: 90
			internal ulong ullTotalVirtual;

			// Token: 0x0400005B RID: 91
			internal ulong ullAvailVirtual;

			// Token: 0x0400005C RID: 92
			internal ulong ullAvailExtendedVirtual;
		}

		// Token: 0x0200001A RID: 26
		internal struct SymbolicLinkReparseBuffer
		{
			// Token: 0x0400005D RID: 93
			internal uint ReparseTag;

			// Token: 0x0400005E RID: 94
			internal ushort ReparseDataLength;

			// Token: 0x0400005F RID: 95
			internal ushort Reserved;

			// Token: 0x04000060 RID: 96
			internal ushort SubstituteNameOffset;

			// Token: 0x04000061 RID: 97
			internal ushort SubstituteNameLength;

			// Token: 0x04000062 RID: 98
			internal ushort PrintNameOffset;

			// Token: 0x04000063 RID: 99
			internal ushort PrintNameLength;

			// Token: 0x04000064 RID: 100
			internal uint Flags;
		}

		// Token: 0x0200001B RID: 27
		internal struct MountPointReparseBuffer
		{
			// Token: 0x04000065 RID: 101
			public uint ReparseTag;

			// Token: 0x04000066 RID: 102
			public ushort ReparseDataLength;

			// Token: 0x04000067 RID: 103
			public ushort Reserved;

			// Token: 0x04000068 RID: 104
			public ushort SubstituteNameOffset;

			// Token: 0x04000069 RID: 105
			public ushort SubstituteNameLength;

			// Token: 0x0400006A RID: 106
			public ushort PrintNameOffset;

			// Token: 0x0400006B RID: 107
			public ushort PrintNameLength;
		}

		// Token: 0x0200001C RID: 28
		internal struct SECURITY_ATTRIBUTES
		{
			// Token: 0x0400006C RID: 108
			internal uint nLength;

			// Token: 0x0400006D RID: 109
			internal unsafe void* lpSecurityDescriptor;

			// Token: 0x0400006E RID: 110
			internal Interop.BOOL bInheritHandle;
		}

		// Token: 0x0200001D RID: 29
		internal struct STORAGE_READ_CAPACITY
		{
			// Token: 0x0400006F RID: 111
			internal uint Version;

			// Token: 0x04000070 RID: 112
			internal uint Size;

			// Token: 0x04000071 RID: 113
			internal uint BlockLength;

			// Token: 0x04000072 RID: 114
			internal long NumberOfBlocks;

			// Token: 0x04000073 RID: 115
			internal long DiskLength;
		}

		// Token: 0x0200001E RID: 30
		internal struct SYSTEM_INFO
		{
			// Token: 0x04000074 RID: 116
			internal ushort wProcessorArchitecture;

			// Token: 0x04000075 RID: 117
			internal ushort wReserved;

			// Token: 0x04000076 RID: 118
			internal int dwPageSize;

			// Token: 0x04000077 RID: 119
			internal IntPtr lpMinimumApplicationAddress;

			// Token: 0x04000078 RID: 120
			internal IntPtr lpMaximumApplicationAddress;

			// Token: 0x04000079 RID: 121
			internal IntPtr dwActiveProcessorMask;

			// Token: 0x0400007A RID: 122
			internal int dwNumberOfProcessors;

			// Token: 0x0400007B RID: 123
			internal int dwProcessorType;

			// Token: 0x0400007C RID: 124
			internal int dwAllocationGranularity;

			// Token: 0x0400007D RID: 125
			internal short wProcessorLevel;

			// Token: 0x0400007E RID: 126
			internal short wProcessorRevision;
		}

		// Token: 0x0200001F RID: 31
		internal struct SYSTEMTIME
		{
			// Token: 0x06000147 RID: 327 RVA: 0x000044F4 File Offset: 0x000026F4
			internal bool Equals(in Interop.Kernel32.SYSTEMTIME other)
			{
				return this.Year == other.Year && this.Month == other.Month && this.DayOfWeek == other.DayOfWeek && this.Day == other.Day && this.Hour == other.Hour && this.Minute == other.Minute && this.Second == other.Second && this.Milliseconds == other.Milliseconds;
			}

			// Token: 0x0400007F RID: 127
			internal ushort Year;

			// Token: 0x04000080 RID: 128
			internal ushort Month;

			// Token: 0x04000081 RID: 129
			internal ushort DayOfWeek;

			// Token: 0x04000082 RID: 130
			internal ushort Day;

			// Token: 0x04000083 RID: 131
			internal ushort Hour;

			// Token: 0x04000084 RID: 132
			internal ushort Minute;

			// Token: 0x04000085 RID: 133
			internal ushort Second;

			// Token: 0x04000086 RID: 134
			internal ushort Milliseconds;
		}

		// Token: 0x02000020 RID: 32
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			// Token: 0x06000148 RID: 328 RVA: 0x00004574 File Offset: 0x00002774
			internal unsafe string GetTimeZoneKeyName()
			{
				fixed (char* ptr = &this.TimeZoneKeyName.FixedElementField)
				{
					return new string(ptr);
				}
			}

			// Token: 0x04000087 RID: 135
			internal int Bias;

			// Token: 0x04000088 RID: 136
			[FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<StandardName>e__FixedBuffer StandardName;

			// Token: 0x04000089 RID: 137
			internal Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x0400008A RID: 138
			internal int StandardBias;

			// Token: 0x0400008B RID: 139
			[FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<DaylightName>e__FixedBuffer DaylightName;

			// Token: 0x0400008C RID: 140
			internal Interop.Kernel32.SYSTEMTIME DaylightDate;

			// Token: 0x0400008D RID: 141
			internal int DaylightBias;

			// Token: 0x0400008E RID: 142
			[FixedBuffer(typeof(char), 128)]
			internal Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION.<TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName;

			// Token: 0x0400008F RID: 143
			internal byte DynamicDaylightTimeDisabled;

			// Token: 0x02000021 RID: 33
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 64)]
			public struct <DaylightName>e__FixedBuffer
			{
				// Token: 0x04000090 RID: 144
				public char FixedElementField;
			}

			// Token: 0x02000022 RID: 34
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 64)]
			public struct <StandardName>e__FixedBuffer
			{
				// Token: 0x04000091 RID: 145
				public char FixedElementField;
			}

			// Token: 0x02000023 RID: 35
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 256)]
			public struct <TimeZoneKeyName>e__FixedBuffer
			{
				// Token: 0x04000092 RID: 146
				public char FixedElementField;
			}
		}

		// Token: 0x02000024 RID: 36
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct TIME_ZONE_INFORMATION
		{
			// Token: 0x06000149 RID: 329 RVA: 0x00004594 File Offset: 0x00002794
			internal unsafe TIME_ZONE_INFORMATION(in Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION dtzi)
			{
				fixed (Interop.Kernel32.TIME_ZONE_INFORMATION* ptr = &this)
				{
					ref Interop.Kernel32.TIME_ZONE_INFORMATION ptr2 = ref *ptr;
					fixed (Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION* ptr3 = &dtzi)
					{
						Interop.Kernel32.TIME_DYNAMIC_ZONE_INFORMATION* ptr4 = ptr3;
						ptr2 = *(Interop.Kernel32.TIME_ZONE_INFORMATION*)ptr4;
					}
				}
			}

			// Token: 0x0600014A RID: 330 RVA: 0x000045BC File Offset: 0x000027BC
			internal unsafe string GetStandardName()
			{
				fixed (char* ptr = &this.StandardName.FixedElementField)
				{
					return new string(ptr);
				}
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000045DC File Offset: 0x000027DC
			internal unsafe string GetDaylightName()
			{
				fixed (char* ptr = &this.DaylightName.FixedElementField)
				{
					return new string(ptr);
				}
			}

			// Token: 0x04000093 RID: 147
			internal int Bias;

			// Token: 0x04000094 RID: 148
			[FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_ZONE_INFORMATION.<StandardName>e__FixedBuffer StandardName;

			// Token: 0x04000095 RID: 149
			internal Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x04000096 RID: 150
			internal int StandardBias;

			// Token: 0x04000097 RID: 151
			[FixedBuffer(typeof(char), 32)]
			internal Interop.Kernel32.TIME_ZONE_INFORMATION.<DaylightName>e__FixedBuffer DaylightName;

			// Token: 0x04000098 RID: 152
			internal Interop.Kernel32.SYSTEMTIME DaylightDate;

			// Token: 0x04000099 RID: 153
			internal int DaylightBias;

			// Token: 0x02000025 RID: 37
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 64)]
			public struct <DaylightName>e__FixedBuffer
			{
				// Token: 0x0400009A RID: 154
				public char FixedElementField;
			}

			// Token: 0x02000026 RID: 38
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 64)]
			public struct <StandardName>e__FixedBuffer
			{
				// Token: 0x0400009B RID: 155
				public char FixedElementField;
			}
		}

		// Token: 0x02000027 RID: 39
		internal struct REG_TZI_FORMAT
		{
			// Token: 0x0600014C RID: 332 RVA: 0x000045FC File Offset: 0x000027FC
			internal REG_TZI_FORMAT(in Interop.Kernel32.TIME_ZONE_INFORMATION tzi)
			{
				this.Bias = tzi.Bias;
				this.StandardDate = tzi.StandardDate;
				this.StandardBias = tzi.StandardBias;
				this.DaylightDate = tzi.DaylightDate;
				this.DaylightBias = tzi.DaylightBias;
			}

			// Token: 0x0400009C RID: 156
			internal int Bias;

			// Token: 0x0400009D RID: 157
			internal int StandardBias;

			// Token: 0x0400009E RID: 158
			internal int DaylightBias;

			// Token: 0x0400009F RID: 159
			internal Interop.Kernel32.SYSTEMTIME StandardDate;

			// Token: 0x040000A0 RID: 160
			internal Interop.Kernel32.SYSTEMTIME DaylightDate;
		}

		// Token: 0x02000028 RID: 40
		internal struct WIN32_FILE_ATTRIBUTE_DATA
		{
			// Token: 0x0600014D RID: 333 RVA: 0x0000463C File Offset: 0x0000283C
			internal void PopulateFrom(ref Interop.Kernel32.WIN32_FIND_DATA findData)
			{
				this.dwFileAttributes = (int)findData.dwFileAttributes;
				this.ftCreationTime = findData.ftCreationTime;
				this.ftLastAccessTime = findData.ftLastAccessTime;
				this.ftLastWriteTime = findData.ftLastWriteTime;
				this.nFileSizeHigh = findData.nFileSizeHigh;
				this.nFileSizeLow = findData.nFileSizeLow;
			}

			// Token: 0x040000A1 RID: 161
			internal int dwFileAttributes;

			// Token: 0x040000A2 RID: 162
			internal Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x040000A3 RID: 163
			internal Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x040000A4 RID: 164
			internal Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x040000A5 RID: 165
			internal uint nFileSizeHigh;

			// Token: 0x040000A6 RID: 166
			internal uint nFileSizeLow;
		}

		// Token: 0x02000029 RID: 41
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct WIN32_FIND_DATA
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00004691 File Offset: 0x00002891
			internal ReadOnlySpan<char> cFileName
			{
				get
				{
					return MemoryMarshal.CreateReadOnlySpan<char>(ref this._cFileName.FixedElementField, 260);
				}
			}

			// Token: 0x040000A7 RID: 167
			internal uint dwFileAttributes;

			// Token: 0x040000A8 RID: 168
			internal Interop.Kernel32.FILE_TIME ftCreationTime;

			// Token: 0x040000A9 RID: 169
			internal Interop.Kernel32.FILE_TIME ftLastAccessTime;

			// Token: 0x040000AA RID: 170
			internal Interop.Kernel32.FILE_TIME ftLastWriteTime;

			// Token: 0x040000AB RID: 171
			internal uint nFileSizeHigh;

			// Token: 0x040000AC RID: 172
			internal uint nFileSizeLow;

			// Token: 0x040000AD RID: 173
			internal uint dwReserved0;

			// Token: 0x040000AE RID: 174
			internal uint dwReserved1;

			// Token: 0x040000AF RID: 175
			[FixedBuffer(typeof(char), 260)]
			private Interop.Kernel32.WIN32_FIND_DATA.<_cFileName>e__FixedBuffer _cFileName;

			// Token: 0x040000B0 RID: 176
			[FixedBuffer(typeof(char), 14)]
			private Interop.Kernel32.WIN32_FIND_DATA.<_cAlternateFileName>e__FixedBuffer _cAlternateFileName;

			// Token: 0x0200002A RID: 42
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 28)]
			public struct <_cAlternateFileName>e__FixedBuffer
			{
				// Token: 0x040000B1 RID: 177
				public char FixedElementField;
			}

			// Token: 0x0200002B RID: 43
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 520)]
			public struct <_cFileName>e__FixedBuffer
			{
				// Token: 0x040000B2 RID: 178
				public char FixedElementField;
			}
		}

		// Token: 0x0200002C RID: 44
		internal struct PROCESSOR_NUMBER
		{
			// Token: 0x040000B3 RID: 179
			public ushort Group;

			// Token: 0x040000B4 RID: 180
			public byte Number;

			// Token: 0x040000B5 RID: 181
			public byte Reserved;
		}
	}

	// Token: 0x0200002D RID: 45
	internal static class Normaliz
	{
		// Token: 0x0600014F RID: 335 RVA: 0x000046A8 File Offset: 0x000028A8
		[LibraryImport("Normaliz.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int IdnToAscii(uint dwFlags, char* lpUnicodeCharStr, int cchUnicodeChar, char* lpASCIICharStr, int cchASCIIChar)
		{
			Marshal.SetLastSystemError(0);
			int result = Interop.Normaliz.<IdnToAscii>g____PInvoke|0_0(dwFlags, lpUnicodeCharStr, cchUnicodeChar, lpASCIICharStr, cchASCIIChar);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000046C5 File Offset: 0x000028C5
		[LibraryImport("Normaliz.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int IdnToUnicode(uint dwFlags, char* lpASCIICharStr, int cchASCIIChar, char* lpUnicodeCharStr, int cchUnicodeChar)
		{
			Marshal.SetLastSystemError(0);
			int result = Interop.Normaliz.<IdnToUnicode>g____PInvoke|1_0(dwFlags, lpASCIICharStr, cchASCIIChar, lpUnicodeCharStr, cchUnicodeChar);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000046E2 File Offset: 0x000028E2
		[LibraryImport("Normaliz.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static Interop.BOOL IsNormalizedString(NormalizationForm normForm, char* source, int length)
		{
			Marshal.SetLastSystemError(0);
			Interop.BOOL result = Interop.Normaliz.<IsNormalizedString>g____PInvoke|4_0(normForm, source, length);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000046FC File Offset: 0x000028FC
		[LibraryImport("Normaliz.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int NormalizeString(NormalizationForm normForm, char* source, int sourceLength, char* destination, int destinationLength)
		{
			Marshal.SetLastSystemError(0);
			int result = Interop.Normaliz.<NormalizeString>g____PInvoke|5_0(normForm, source, sourceLength, destination, destinationLength);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x06000153 RID: 339
		[CompilerGenerated]
		[DllImport("Normaliz.dll", EntryPoint = "IdnToAscii", ExactSpelling = true)]
		internal unsafe static extern int <IdnToAscii>g____PInvoke|0_0(uint __dwFlags_native, char* __lpUnicodeCharStr_native, int __cchUnicodeChar_native, char* __lpASCIICharStr_native, int __cchASCIIChar_native);

		// Token: 0x06000154 RID: 340
		[CompilerGenerated]
		[DllImport("Normaliz.dll", EntryPoint = "IdnToUnicode", ExactSpelling = true)]
		internal unsafe static extern int <IdnToUnicode>g____PInvoke|1_0(uint __dwFlags_native, char* __lpASCIICharStr_native, int __cchASCIIChar_native, char* __lpUnicodeCharStr_native, int __cchUnicodeChar_native);

		// Token: 0x06000155 RID: 341
		[CompilerGenerated]
		[DllImport("Normaliz.dll", EntryPoint = "IsNormalizedString", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOL <IsNormalizedString>g____PInvoke|4_0(NormalizationForm __normForm_native, char* __source_native, int __length_native);

		// Token: 0x06000156 RID: 342
		[CompilerGenerated]
		[DllImport("Normaliz.dll", EntryPoint = "NormalizeString", ExactSpelling = true)]
		internal unsafe static extern int <NormalizeString>g____PInvoke|5_0(NormalizationForm __normForm_native, char* __source_native, int __sourceLength_native, char* __destination_native, int __destinationLength_native);
	}

	// Token: 0x0200002E RID: 46
	internal static class HostPolicy
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0000471C File Offset: 0x0000291C
		[LibraryImport("hostpolicy", StringMarshalling = StringMarshalling.Utf16)]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int corehost_resolve_component_dependencies(string componentMainAssemblyPath, Interop.HostPolicy.corehost_resolve_component_dependencies_result_fn result)
		{
			IntPtr _result_native = (result != null) ? Marshal.GetFunctionPointerForDelegate<Interop.HostPolicy.corehost_resolve_component_dependencies_result_fn>(result) : ((IntPtr)0);
			int result2;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(componentMainAssemblyPath))
			{
				void* _componentMainAssemblyPath_native = (void*)pinnableReference;
				result2 = Interop.HostPolicy.<corehost_resolve_component_dependencies>g____PInvoke|2_0((ushort*)_componentMainAssemblyPath_native, _result_native);
			}
			GC.KeepAlive(result);
			return result2;
		}

		// Token: 0x06000158 RID: 344
		[LibraryImport("hostpolicy")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("hostpolicy", ExactSpelling = true)]
		internal static extern IntPtr corehost_set_error_writer(IntPtr errorWriter);

		// Token: 0x06000159 RID: 345
		[CompilerGenerated]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("hostpolicy", EntryPoint = "corehost_resolve_component_dependencies", ExactSpelling = true)]
		internal unsafe static extern int <corehost_resolve_component_dependencies>g____PInvoke|2_0(ushort* __componentMainAssemblyPath_native, IntPtr __result_native);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600015B RID: 347
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void corehost_resolve_component_dependencies_result_fn(IntPtr assemblyPaths, IntPtr nativeSearchPaths, IntPtr resourceSearchPaths);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600015D RID: 349
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void corehost_error_writer_fn(IntPtr message);
	}

	// Token: 0x02000031 RID: 49
	internal static class Advapi32
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00004754 File Offset: 0x00002954
		[LibraryImport("advapi32.dll", EntryPoint = "EncryptFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool EncryptFilePrivate(string lpFileName)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpFileName))
			{
				void* _lpFileName_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Advapi32.<EncryptFilePrivate>g____PInvoke|6_0((ushort*)_lpFileName_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00004789 File Offset: 0x00002989
		internal static bool EncryptFile(string path)
		{
			path = PathInternal.EnsureExtendedPrefixIfNeeded(path);
			return Interop.Advapi32.EncryptFilePrivate(path);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000479C File Offset: 0x0000299C
		[LibraryImport("advapi32.dll", EntryPoint = "DecryptFileW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private unsafe static bool DecryptFileFilePrivate(string lpFileName, int dwReserved)
		{
			int num;
			int lastSystemError;
			fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpFileName))
			{
				void* _lpFileName_native = (void*)pinnableReference;
				Marshal.SetLastSystemError(0);
				num = Interop.Advapi32.<DecryptFileFilePrivate>g____PInvoke|8_0((ushort*)_lpFileName_native, dwReserved);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000047D2 File Offset: 0x000029D2
		internal static bool DecryptFile(string path)
		{
			path = PathInternal.EnsureExtendedPrefixIfNeeded(path);
			return Interop.Advapi32.DecryptFileFilePrivate(path, 0);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000047E4 File Offset: 0x000029E4
		[LibraryImport("advapi32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int EventActivityIdControl(Interop.Advapi32.ActivityControl ControlCode, ref Guid ActivityId)
		{
			int result;
			fixed (Guid* ptr = &ActivityId)
			{
				Guid* _ActivityId_native = ptr;
				result = Interop.Advapi32.<EventActivityIdControl>g____PInvoke|10_0(ControlCode, _ActivityId_native);
			}
			return result;
		}

		// Token: 0x06000163 RID: 355
		[LibraryImport("advapi32.dll")]
		[DllImport("advapi32.dll", ExactSpelling = true)]
		internal unsafe static extern uint EventRegister(Guid* providerId, method enableCallback, ushort callbackContext, void registrationHandle);

		// Token: 0x06000164 RID: 356
		[LibraryImport("advapi32.dll")]
		[DllImport("advapi32.dll", ExactSpelling = true)]
		internal unsafe static extern int EventSetInformation(long registrationHandle, Interop.Advapi32.EVENT_INFO_CLASS informationClass, void* eventInformation, uint informationLength);

		// Token: 0x06000165 RID: 357 RVA: 0x00004800 File Offset: 0x00002A00
		[LibraryImport("advapi32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int EnumerateTraceGuidsEx(Interop.Advapi32.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, out int ReturnLength)
		{
			ReturnLength = 0;
			int result;
			fixed (int* ptr = &ReturnLength)
			{
				int* _ReturnLength_native = ptr;
				result = Interop.Advapi32.<EnumerateTraceGuidsEx>g____PInvoke|17_0(TraceQueryInfoClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, _ReturnLength_native);
			}
			return result;
		}

		// Token: 0x06000166 RID: 358
		[LibraryImport("advapi32.dll")]
		[DllImport("advapi32.dll", ExactSpelling = true)]
		internal static extern uint EventUnregister(long registrationHandle);

		// Token: 0x06000167 RID: 359 RVA: 0x00004828 File Offset: 0x00002A28
		internal unsafe static int EventWriteTransfer(long registrationHandle, in EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
		{
			int num = Interop.Advapi32.EventWriteTransfer_PInvoke(registrationHandle, eventDescriptor, activityId, relatedActivityId, userDataCount, userData);
			if (num == 87 && relatedActivityId == null)
			{
				Guid empty = Guid.Empty;
				num = Interop.Advapi32.EventWriteTransfer_PInvoke(registrationHandle, eventDescriptor, activityId, &empty, userDataCount, userData);
			}
			return num;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004864 File Offset: 0x00002A64
		[LibraryImport("advapi32.dll", EntryPoint = "EventWriteTransfer")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		private unsafe static int EventWriteTransfer_PInvoke(long registrationHandle, in EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
		{
			int result;
			fixed (EventDescriptor* ptr = &eventDescriptor)
			{
				EventDescriptor* _eventDescriptor_native = ptr;
				result = Interop.Advapi32.<EventWriteTransfer_PInvoke>g____PInvoke|21_0(registrationHandle, _eventDescriptor_native, activityId, relatedActivityId, userDataCount, userData);
			}
			return result;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004888 File Offset: 0x00002A88
		[LibraryImport("advapi32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool GetTokenInformation(SafeTokenHandle TokenHandle, Interop.Advapi32.TOKEN_INFORMATION_CLASS TokenInformationClass, void* TokenInformation, uint TokenInformationLength, out uint ReturnLength)
		{
			ReturnLength = 0U;
			bool result = false;
			int num = 0;
			SafeHandleMarshaller<SafeTokenHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeTokenHandle>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(TokenHandle);
				try
				{
					fixed (uint* ptr = &ReturnLength)
					{
						uint* _ReturnLength_native = ptr;
						IntPtr _TokenHandle_native = managedToUnmanagedIn.ToUnmanaged();
						Marshal.SetLastSystemError(0);
						num = Interop.Advapi32.<GetTokenInformation>g____PInvoke|22_0(_TokenHandle_native, TokenInformationClass, TokenInformation, TokenInformationLength, _ReturnLength_native);
						lastSystemError = Marshal.GetLastSystemError();
					}
				}
				finally
				{
					uint* ptr = null;
				}
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004910 File Offset: 0x00002B10
		[LibraryImport("advapi32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool LookupAccountNameW(string lpSystemName, ref char lpAccountName, ref byte Sid, ref uint cbSid, ref char ReferencedDomainName, ref uint cchReferencedDomainName, out uint peUse)
		{
			peUse = 0U;
			int num;
			int lastSystemError;
			fixed (uint* ptr = &peUse)
			{
				uint* _peUse_native = ptr;
				fixed (uint* ptr2 = &cchReferencedDomainName)
				{
					uint* _cchReferencedDomainName_native = ptr2;
					fixed (char* ptr3 = &ReferencedDomainName)
					{
						char* _ReferencedDomainName_native = ptr3;
						fixed (uint* ptr4 = &cbSid)
						{
							uint* _cbSid_native = ptr4;
							fixed (byte* ptr5 = &Sid)
							{
								byte* _Sid_native = ptr5;
								fixed (char* ptr6 = &lpAccountName)
								{
									char* _lpAccountName_native = ptr6;
									fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpSystemName))
									{
										void* _lpSystemName_native = (void*)pinnableReference;
										Marshal.SetLastSystemError(0);
										num = Interop.Advapi32.<LookupAccountNameW>g____PInvoke|23_0((ushort*)_lpSystemName_native, _lpAccountName_native, _Sid_native, _cbSid_native, _ReferencedDomainName_native, _cchReferencedDomainName_native, _peUse_native);
										lastSystemError = Marshal.GetLastSystemError();
									}
								}
							}
						}
					}
				}
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000049A0 File Offset: 0x00002BA0
		[LibraryImport("advapi32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static bool OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, out SafeTokenHandle TokenHandle)
		{
			bool flag = false;
			TokenHandle = null;
			IntPtr value = (IntPtr)0;
			bool result = false;
			SafeHandleMarshaller<SafeTokenHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeTokenHandle>.ManagedToUnmanagedOut();
			int lastSystemError;
			try
			{
				Marshal.SetLastSystemError(0);
				int num = Interop.Advapi32.<OpenProcessToken>g____PInvoke|24_0(ProcessHandle, DesiredAccess, &value);
				lastSystemError = Marshal.GetLastSystemError();
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				result = (num != 0);
				TokenHandle = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x0600016C RID: 364
		[LibraryImport("advapi32.dll")]
		[DllImport("advapi32.dll", ExactSpelling = true)]
		internal static extern int RegCloseKey(IntPtr hKey);

		// Token: 0x0600016D RID: 365 RVA: 0x00004A10 File Offset: 0x00002C10
		[LibraryImport("advapi32.dll", EntryPoint = "RegDeleteValueW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int RegDeleteValue(SafeRegistryHandle hKey, string lpValueName)
		{
			int result = 0;
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(hKey);
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(lpValueName))
					{
						void* _lpValueName_native = (void*)ptr;
						result = Interop.Advapi32.<RegDeleteValue>g____PInvoke|28_0(managedToUnmanagedIn.ToUnmanaged(), (ushort*)_lpValueName_native);
					}
				}
				finally
				{
					char* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004A74 File Offset: 0x00002C74
		[LibraryImport("advapi32.dll", EntryPoint = "RegEnumKeyExW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, ref char lpName, ref int lpcbName, int[] lpReserved, [Out] char[] lpClass, int[] lpcbClass, long[] lpftLastWriteTime)
		{
			int result = 0;
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(hKey);
				try
				{
					fixed (long* ptr = ArrayMarshaller<long, long>.ManagedToUnmanagedIn.GetPinnableReference(lpftLastWriteTime))
					{
						void* _lpftLastWriteTime_native = (void*)ptr;
						try
						{
							fixed (int* ptr2 = ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(lpcbClass))
							{
								void* _lpcbClass_native = (void*)ptr2;
								try
								{
									fixed (char* ptr3 = ArrayMarshaller<char, char>.ManagedToUnmanagedIn.GetPinnableReference(lpClass))
									{
										void* _lpClass_native = (void*)ptr3;
										try
										{
											fixed (int* ptr4 = ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(lpReserved))
											{
												void* _lpReserved_native = (void*)ptr4;
												try
												{
													fixed (int* ptr5 = &lpcbName)
													{
														int* _lpcbName_native = ptr5;
														try
														{
															fixed (char* ptr6 = &lpName)
															{
																char* _lpName_native = ptr6;
																result = Interop.Advapi32.<RegEnumKeyEx>g____PInvoke|29_0(managedToUnmanagedIn.ToUnmanaged(), dwIndex, _lpName_native, _lpcbName_native, (int*)_lpReserved_native, (char*)_lpClass_native, (int*)_lpcbClass_native, (long*)_lpftLastWriteTime_native);
															}
														}
														finally
														{
															char* ptr6 = null;
														}
													}
												}
												finally
												{
													int* ptr5 = null;
												}
											}
										}
										finally
										{
											int* ptr4 = null;
										}
									}
								}
								finally
								{
									char* ptr3 = null;
								}
							}
						}
						finally
						{
							int* ptr2 = null;
						}
					}
				}
				finally
				{
					long* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00004B74 File Offset: 0x00002D74
		[LibraryImport("advapi32.dll", EntryPoint = "RegEnumValueW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int RegEnumValue(SafeRegistryHandle hKey, int dwIndex, [Out] char[] lpValueName, ref int lpcbValueName, IntPtr lpReserved_MustBeZero, int[] lpType, byte[] lpData, int[] lpcbData)
		{
			int result = 0;
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(hKey);
				try
				{
					fixed (int* ptr = ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(lpcbData))
					{
						void* _lpcbData_native = (void*)ptr;
						try
						{
							fixed (byte* ptr2 = ArrayMarshaller<byte, byte>.ManagedToUnmanagedIn.GetPinnableReference(lpData))
							{
								void* _lpData_native = (void*)ptr2;
								try
								{
									fixed (int* ptr3 = ArrayMarshaller<int, int>.ManagedToUnmanagedIn.GetPinnableReference(lpType))
									{
										void* _lpType_native = (void*)ptr3;
										try
										{
											fixed (int* ptr4 = &lpcbValueName)
											{
												int* _lpcbValueName_native = ptr4;
												try
												{
													fixed (char* ptr5 = ArrayMarshaller<char, char>.ManagedToUnmanagedIn.GetPinnableReference(lpValueName))
													{
														void* _lpValueName_native = (void*)ptr5;
														result = Interop.Advapi32.<RegEnumValue>g____PInvoke|30_0(managedToUnmanagedIn.ToUnmanaged(), dwIndex, (char*)_lpValueName_native, _lpcbValueName_native, lpReserved_MustBeZero, (int*)_lpType_native, (byte*)_lpData_native, (int*)_lpcbData_native);
													}
												}
												finally
												{
													char* ptr5 = null;
												}
											}
										}
										finally
										{
											int* ptr4 = null;
										}
									}
								}
								finally
								{
									int* ptr3 = null;
								}
							}
						}
						finally
						{
							byte* ptr2 = null;
						}
					}
				}
				finally
				{
					int* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004C58 File Offset: 0x00002E58
		[LibraryImport("advapi32.dll", EntryPoint = "RegOpenKeyExW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult)
		{
			bool flag = false;
			hkResult = null;
			IntPtr value = (IntPtr)0;
			int result = 0;
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedOut managedToUnmanagedOut = new SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedOut();
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(hKey);
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(lpSubKey))
					{
						void* _lpSubKey_native = (void*)ptr;
						result = Interop.Advapi32.<RegOpenKeyEx>g____PInvoke|36_0(managedToUnmanagedIn.ToUnmanaged(), (ushort*)_lpSubKey_native, ulOptions, samDesired, &value);
					}
				}
				finally
				{
					char* ptr = null;
				}
				flag = true;
				managedToUnmanagedOut.FromUnmanaged(value);
				hkResult = managedToUnmanagedOut.ToManaged();
			}
			finally
			{
				if (flag)
				{
					managedToUnmanagedOut.Free();
				}
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[LibraryImport("advapi32.dll", EntryPoint = "RegQueryValueExW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, int* lpReserved, int* lpType, byte* lpData, uint* lpcbData)
		{
			int result = 0;
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(hKey);
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(lpValueName))
					{
						void* _lpValueName_native = (void*)ptr;
						result = Interop.Advapi32.<RegQueryValueEx>g____PInvoke|39_0(managedToUnmanagedIn.ToUnmanaged(), (ushort*)_lpValueName_native, lpReserved, lpType, lpData, lpcbData);
					}
				}
				finally
				{
					char* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00004D5C File Offset: 0x00002F5C
		[LibraryImport("advapi32.dll", EntryPoint = "RegSetValueExW", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int RegSetValueEx(SafeRegistryHandle hKey, string lpValueName, int Reserved, int dwType, string lpData, int cbData)
		{
			int result = 0;
			SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeRegistryHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(hKey);
				try
				{
					fixed (char* ptr = Utf16StringMarshaller.GetPinnableReference(lpData))
					{
						void* _lpData_native = (void*)ptr;
						try
						{
							fixed (char* ptr2 = Utf16StringMarshaller.GetPinnableReference(lpValueName))
							{
								void* _lpValueName_native = (void*)ptr2;
								result = Interop.Advapi32.<RegSetValueEx>g____PInvoke|44_0(managedToUnmanagedIn.ToUnmanaged(), (ushort*)_lpValueName_native, Reserved, dwType, (ushort*)_lpData_native, cbData);
							}
						}
						finally
						{
							char* ptr2 = null;
						}
					}
				}
				finally
				{
					char* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x06000173 RID: 371
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "EncryptFileW", ExactSpelling = true)]
		internal unsafe static extern int <EncryptFilePrivate>g____PInvoke|6_0(ushort* __lpFileName_native);

		// Token: 0x06000174 RID: 372
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "DecryptFileW", ExactSpelling = true)]
		internal unsafe static extern int <DecryptFileFilePrivate>g____PInvoke|8_0(ushort* __lpFileName_native, int __dwReserved_native);

		// Token: 0x06000175 RID: 373
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "EventActivityIdControl", ExactSpelling = true)]
		internal unsafe static extern int <EventActivityIdControl>g____PInvoke|10_0(Interop.Advapi32.ActivityControl __ControlCode_native, Guid* __ActivityId_native);

		// Token: 0x06000176 RID: 374
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "EnumerateTraceGuidsEx", ExactSpelling = true)]
		internal unsafe static extern int <EnumerateTraceGuidsEx>g____PInvoke|17_0(Interop.Advapi32.TRACE_QUERY_INFO_CLASS __TraceQueryInfoClass_native, void* __InBuffer_native, int __InBufferSize_native, void* __OutBuffer_native, int __OutBufferSize_native, int* __ReturnLength_native);

		// Token: 0x06000177 RID: 375
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "EventWriteTransfer", ExactSpelling = true)]
		internal unsafe static extern int <EventWriteTransfer_PInvoke>g____PInvoke|21_0(long __registrationHandle_native, EventDescriptor* __eventDescriptor_native, Guid* __activityId_native, Guid* __relatedActivityId_native, int __userDataCount_native, EventProvider.EventData* __userData_native);

		// Token: 0x06000178 RID: 376
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "GetTokenInformation", ExactSpelling = true)]
		internal unsafe static extern int <GetTokenInformation>g____PInvoke|22_0(IntPtr __TokenHandle_native, Interop.Advapi32.TOKEN_INFORMATION_CLASS __TokenInformationClass_native, void* __TokenInformation_native, uint __TokenInformationLength_native, uint* __ReturnLength_native);

		// Token: 0x06000179 RID: 377
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "LookupAccountNameW", ExactSpelling = true)]
		internal unsafe static extern int <LookupAccountNameW>g____PInvoke|23_0(ushort* __lpSystemName_native, char* __lpAccountName_native, byte* __Sid_native, uint* __cbSid_native, char* __ReferencedDomainName_native, uint* __cchReferencedDomainName_native, uint* __peUse_native);

		// Token: 0x0600017A RID: 378
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", ExactSpelling = true)]
		internal unsafe static extern int <OpenProcessToken>g____PInvoke|24_0(IntPtr __ProcessHandle_native, int __DesiredAccess_native, IntPtr* __TokenHandle_native);

		// Token: 0x0600017B RID: 379
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "RegDeleteValueW", ExactSpelling = true)]
		internal unsafe static extern int <RegDeleteValue>g____PInvoke|28_0(IntPtr __hKey_native, ushort* __lpValueName_native);

		// Token: 0x0600017C RID: 380
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "RegEnumKeyExW", ExactSpelling = true)]
		internal unsafe static extern int <RegEnumKeyEx>g____PInvoke|29_0(IntPtr __hKey_native, int __dwIndex_native, char* __lpName_native, int* __lpcbName_native, int* __lpReserved_native, char* __lpClass_native, int* __lpcbClass_native, long* __lpftLastWriteTime_native);

		// Token: 0x0600017D RID: 381
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "RegEnumValueW", ExactSpelling = true)]
		internal unsafe static extern int <RegEnumValue>g____PInvoke|30_0(IntPtr __hKey_native, int __dwIndex_native, char* __lpValueName_native, int* __lpcbValueName_native, IntPtr __lpReserved_MustBeZero_native, int* __lpType_native, byte* __lpData_native, int* __lpcbData_native);

		// Token: 0x0600017E RID: 382
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "RegOpenKeyExW", ExactSpelling = true)]
		internal unsafe static extern int <RegOpenKeyEx>g____PInvoke|36_0(IntPtr __hKey_native, ushort* __lpSubKey_native, int __ulOptions_native, int __samDesired_native, IntPtr* __hkResult_native);

		// Token: 0x0600017F RID: 383
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "RegQueryValueExW", ExactSpelling = true)]
		internal unsafe static extern int <RegQueryValueEx>g____PInvoke|39_0(IntPtr __hKey_native, ushort* __lpValueName_native, int* __lpReserved_native, int* __lpType_native, byte* __lpData_native, uint* __lpcbData_native);

		// Token: 0x06000180 RID: 384
		[CompilerGenerated]
		[DllImport("advapi32.dll", EntryPoint = "RegSetValueExW", ExactSpelling = true)]
		internal unsafe static extern int <RegSetValueEx>g____PInvoke|44_0(IntPtr __hKey_native, ushort* __lpValueName_native, int __Reserved_native, int __dwType_native, ushort* __lpData_native, int __cbData_native);

		// Token: 0x02000032 RID: 50
		internal enum ActivityControl : uint
		{
			// Token: 0x040000B7 RID: 183
			EVENT_ACTIVITY_CTRL_GET_ID = 1U,
			// Token: 0x040000B8 RID: 184
			EVENT_ACTIVITY_CTRL_SET_ID,
			// Token: 0x040000B9 RID: 185
			EVENT_ACTIVITY_CTRL_CREATE_ID,
			// Token: 0x040000BA RID: 186
			EVENT_ACTIVITY_CTRL_GET_SET_ID,
			// Token: 0x040000BB RID: 187
			EVENT_ACTIVITY_CTRL_CREATE_SET_ID
		}

		// Token: 0x02000033 RID: 51
		internal struct EVENT_FILTER_DESCRIPTOR
		{
			// Token: 0x040000BC RID: 188
			public long Ptr;

			// Token: 0x040000BD RID: 189
			public int Size;

			// Token: 0x040000BE RID: 190
			public int Type;
		}

		// Token: 0x02000034 RID: 52
		internal enum EVENT_INFO_CLASS
		{
			// Token: 0x040000C0 RID: 192
			BinaryTrackInfo,
			// Token: 0x040000C1 RID: 193
			SetEnableAllKeywords,
			// Token: 0x040000C2 RID: 194
			SetTraits
		}

		// Token: 0x02000035 RID: 53
		internal enum TRACE_QUERY_INFO_CLASS
		{
			// Token: 0x040000C4 RID: 196
			TraceGuidQueryList,
			// Token: 0x040000C5 RID: 197
			TraceGuidQueryInfo,
			// Token: 0x040000C6 RID: 198
			TraceGuidQueryProcess,
			// Token: 0x040000C7 RID: 199
			TraceStackTracingInfo,
			// Token: 0x040000C8 RID: 200
			MaxTraceSetInfoClass
		}

		// Token: 0x02000036 RID: 54
		internal struct TRACE_GUID_INFO
		{
			// Token: 0x040000C9 RID: 201
			public int InstanceCount;

			// Token: 0x040000CA RID: 202
			public int Reserved;
		}

		// Token: 0x02000037 RID: 55
		internal struct TRACE_PROVIDER_INSTANCE_INFO
		{
			// Token: 0x040000CB RID: 203
			public int NextOffset;

			// Token: 0x040000CC RID: 204
			public int EnableCount;

			// Token: 0x040000CD RID: 205
			public int Pid;

			// Token: 0x040000CE RID: 206
			public int Flags;
		}

		// Token: 0x02000038 RID: 56
		internal struct TRACE_ENABLE_INFO
		{
			// Token: 0x040000CF RID: 207
			public int IsEnabled;

			// Token: 0x040000D0 RID: 208
			public byte Level;

			// Token: 0x040000D1 RID: 209
			public byte Reserved1;

			// Token: 0x040000D2 RID: 210
			public ushort LoggerId;

			// Token: 0x040000D3 RID: 211
			public int EnableProperty;

			// Token: 0x040000D4 RID: 212
			public int Reserved2;

			// Token: 0x040000D5 RID: 213
			public long MatchAnyKeyword;

			// Token: 0x040000D6 RID: 214
			public long MatchAllKeyword;
		}

		// Token: 0x02000039 RID: 57
		internal struct TOKEN_ELEVATION
		{
			// Token: 0x040000D7 RID: 215
			public Interop.BOOL TokenIsElevated;
		}

		// Token: 0x0200003A RID: 58
		internal enum TOKEN_INFORMATION_CLASS : uint
		{
			// Token: 0x040000D9 RID: 217
			TokenUser = 1U,
			// Token: 0x040000DA RID: 218
			TokenGroups,
			// Token: 0x040000DB RID: 219
			TokenPrivileges,
			// Token: 0x040000DC RID: 220
			TokenOwner,
			// Token: 0x040000DD RID: 221
			TokenPrimaryGroup,
			// Token: 0x040000DE RID: 222
			TokenDefaultDacl,
			// Token: 0x040000DF RID: 223
			TokenSource,
			// Token: 0x040000E0 RID: 224
			TokenType,
			// Token: 0x040000E1 RID: 225
			TokenImpersonationLevel,
			// Token: 0x040000E2 RID: 226
			TokenStatistics,
			// Token: 0x040000E3 RID: 227
			TokenRestrictedSids,
			// Token: 0x040000E4 RID: 228
			TokenSessionId,
			// Token: 0x040000E5 RID: 229
			TokenGroupsAndPrivileges,
			// Token: 0x040000E6 RID: 230
			TokenSessionReference,
			// Token: 0x040000E7 RID: 231
			TokenSandBoxInert,
			// Token: 0x040000E8 RID: 232
			TokenAuditPolicy,
			// Token: 0x040000E9 RID: 233
			TokenOrigin,
			// Token: 0x040000EA RID: 234
			TokenElevationType,
			// Token: 0x040000EB RID: 235
			TokenLinkedToken,
			// Token: 0x040000EC RID: 236
			TokenElevation,
			// Token: 0x040000ED RID: 237
			TokenHasRestrictions,
			// Token: 0x040000EE RID: 238
			TokenAccessInformation,
			// Token: 0x040000EF RID: 239
			TokenVirtualizationAllowed,
			// Token: 0x040000F0 RID: 240
			TokenVirtualizationEnabled,
			// Token: 0x040000F1 RID: 241
			TokenIntegrityLevel,
			// Token: 0x040000F2 RID: 242
			TokenUIAccess,
			// Token: 0x040000F3 RID: 243
			TokenMandatoryPolicy,
			// Token: 0x040000F4 RID: 244
			TokenLogonSid,
			// Token: 0x040000F5 RID: 245
			TokenIsAppContainer,
			// Token: 0x040000F6 RID: 246
			TokenCapabilities,
			// Token: 0x040000F7 RID: 247
			TokenAppContainerSid,
			// Token: 0x040000F8 RID: 248
			TokenAppContainerNumber,
			// Token: 0x040000F9 RID: 249
			TokenUserClaimAttributes,
			// Token: 0x040000FA RID: 250
			TokenDeviceClaimAttributes,
			// Token: 0x040000FB RID: 251
			TokenRestrictedUserClaimAttributes,
			// Token: 0x040000FC RID: 252
			TokenRestrictedDeviceClaimAttributes,
			// Token: 0x040000FD RID: 253
			TokenDeviceGroups,
			// Token: 0x040000FE RID: 254
			TokenRestrictedDeviceGroups,
			// Token: 0x040000FF RID: 255
			TokenSecurityAttributes,
			// Token: 0x04000100 RID: 256
			TokenIsRestricted,
			// Token: 0x04000101 RID: 257
			MaxTokenInfoClass
		}
	}

	// Token: 0x0200003B RID: 59
	internal static class BCrypt
	{
		// Token: 0x06000181 RID: 385
		[LibraryImport("BCrypt.dll")]
		[DllImport("BCrypt.dll", ExactSpelling = true)]
		internal unsafe static extern Interop.BCrypt.NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags);

		// Token: 0x0200003C RID: 60
		internal enum NTSTATUS : uint
		{
			// Token: 0x04000103 RID: 259
			STATUS_SUCCESS,
			// Token: 0x04000104 RID: 260
			STATUS_UNSUCCESSFUL = 3221225473U,
			// Token: 0x04000105 RID: 261
			STATUS_NOT_FOUND = 3221226021U,
			// Token: 0x04000106 RID: 262
			STATUS_INVALID_PARAMETER = 3221225485U,
			// Token: 0x04000107 RID: 263
			STATUS_NO_MEMORY = 3221225495U,
			// Token: 0x04000108 RID: 264
			STATUS_BUFFER_TOO_SMALL = 3221225507U,
			// Token: 0x04000109 RID: 265
			STATUS_AUTH_TAG_MISMATCH = 3221266434U
		}
	}

	// Token: 0x0200003D RID: 61
	internal static class Crypt32
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[LibraryImport("crypt32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool CryptProtectMemory(SafeBuffer pData, uint cbData, uint dwFlags)
		{
			bool result = false;
			SafeHandleMarshaller<SafeBuffer>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeBuffer>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(pData);
				IntPtr _pData_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Crypt32.<CryptProtectMemory>g____PInvoke|2_0(_pData_native, cbData, dwFlags);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00004E44 File Offset: 0x00003044
		[LibraryImport("crypt32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static bool CryptUnprotectMemory(SafeBuffer pData, uint cbData, uint dwFlags)
		{
			bool result = false;
			SafeHandleMarshaller<SafeBuffer>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeBuffer>.ManagedToUnmanagedIn);
			int lastSystemError;
			try
			{
				managedToUnmanagedIn.FromManaged(pData);
				IntPtr _pData_native = managedToUnmanagedIn.ToUnmanaged();
				Marshal.SetLastSystemError(0);
				int num = Interop.Crypt32.<CryptUnprotectMemory>g____PInvoke|3_0(_pData_native, cbData, dwFlags);
				lastSystemError = Marshal.GetLastSystemError();
				result = (num != 0);
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x06000184 RID: 388
		[CompilerGenerated]
		[DllImport("crypt32.dll", EntryPoint = "CryptProtectMemory", ExactSpelling = true)]
		internal static extern int <CryptProtectMemory>g____PInvoke|2_0(IntPtr __pData_native, uint __cbData_native, uint __dwFlags_native);

		// Token: 0x06000185 RID: 389
		[CompilerGenerated]
		[DllImport("crypt32.dll", EntryPoint = "CryptUnprotectMemory", ExactSpelling = true)]
		internal static extern int <CryptUnprotectMemory>g____PInvoke|3_0(IntPtr __pData_native, uint __cbData_native, uint __dwFlags_native);
	}

	// Token: 0x0200003E RID: 62
	internal enum BOOLEAN : byte
	{
		// Token: 0x0400010B RID: 267
		FALSE,
		// Token: 0x0400010C RID: 268
		TRUE
	}

	// Token: 0x0200003F RID: 63
	internal static class NtDll
	{
		// Token: 0x06000186 RID: 390
		[LibraryImport("ntdll.dll")]
		[DllImport("ntdll.dll", ExactSpelling = true)]
		private unsafe static extern uint NtCreateFile(IntPtr* FileHandle, Interop.NtDll.DesiredAccess DesiredAccess, Interop.OBJECT_ATTRIBUTES* ObjectAttributes, Interop.NtDll.IO_STATUS_BLOCK* IoStatusBlock, long* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, Interop.NtDll.CreateDisposition CreateDisposition, Interop.NtDll.CreateOptions CreateOptions, void* EaBuffer, uint EaLength);

		// Token: 0x06000187 RID: 391 RVA: 0x00004EA4 File Offset: 0x000030A4
		[return: TupleElementNames(new string[]
		{
			"status",
			"handle"
		})]
		internal unsafe static ValueTuple<uint, IntPtr> CreateFile(ReadOnlySpan<char> path, IntPtr rootDirectory, Interop.NtDll.CreateDisposition createDisposition, Interop.NtDll.DesiredAccess desiredAccess = Interop.NtDll.DesiredAccess.SYNCHRONIZE | Interop.NtDll.DesiredAccess.FILE_GENERIC_READ, FileShare shareAccess = FileShare.Read | FileShare.Write | FileShare.Delete, FileAttributes fileAttributes = FileAttributes.None, Interop.NtDll.CreateOptions createOptions = Interop.NtDll.CreateOptions.FILE_SYNCHRONOUS_IO_NONALERT, Interop.ObjectAttributes objectAttributes = Interop.ObjectAttributes.OBJ_CASE_INSENSITIVE, void* eaBuffer = null, uint eaLength = 0U, long* preallocationSize = null, Interop.SECURITY_QUALITY_OF_SERVICE* securityQualityOfService = null)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(path))
			{
				char* buffer = reference;
				Interop.UNICODE_STRING unicode_STRING = checked(new Interop.UNICODE_STRING
				{
					Length = (ushort)(path.Length * 2),
					MaximumLength = (ushort)(path.Length * 2),
					Buffer = buffer
				});
				Interop.OBJECT_ATTRIBUTES object_ATTRIBUTES = new Interop.OBJECT_ATTRIBUTES(&unicode_STRING, objectAttributes, rootDirectory, securityQualityOfService);
				IntPtr item;
				Interop.NtDll.IO_STATUS_BLOCK io_STATUS_BLOCK;
				return new ValueTuple<uint, IntPtr>(Interop.NtDll.NtCreateFile(&item, desiredAccess, &object_ATTRIBUTES, &io_STATUS_BLOCK, preallocationSize, fileAttributes, shareAccess, createDisposition, createOptions, eaBuffer, eaLength), item);
			}
		}

		// Token: 0x06000188 RID: 392
		[LibraryImport("ntdll.dll")]
		[DllImport("ntdll.dll", ExactSpelling = true)]
		public static extern uint RtlNtStatusToDosError(int Status);

		// Token: 0x06000189 RID: 393
		[LibraryImport("ntdll.dll")]
		[DllImport("ntdll.dll", ExactSpelling = true)]
		public unsafe static extern int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, Interop.NtDll.IO_STATUS_BLOCK* IoStatusBlock, IntPtr FileInformation, uint Length, Interop.NtDll.FILE_INFORMATION_CLASS FileInformationClass, Interop.BOOLEAN ReturnSingleEntry, Interop.UNICODE_STRING* FileName, Interop.BOOLEAN RestartScan);

		// Token: 0x0600018A RID: 394 RVA: 0x00004F24 File Offset: 0x00003124
		[LibraryImport("ntdll.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int NtQueryInformationFile(SafeFileHandle FileHandle, out Interop.NtDll.IO_STATUS_BLOCK IoStatusBlock, void* FileInformation, uint Length, uint FileInformationClass)
		{
			IoStatusBlock = default(Interop.NtDll.IO_STATUS_BLOCK);
			int result = 0;
			SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn managedToUnmanagedIn = default(SafeHandleMarshaller<SafeFileHandle>.ManagedToUnmanagedIn);
			try
			{
				managedToUnmanagedIn.FromManaged(FileHandle);
				try
				{
					fixed (Interop.NtDll.IO_STATUS_BLOCK* ptr = &IoStatusBlock)
					{
						Interop.NtDll.IO_STATUS_BLOCK* _IoStatusBlock_native = ptr;
						result = Interop.NtDll.<NtQueryInformationFile>g____PInvoke|17_0(managedToUnmanagedIn.ToUnmanaged(), _IoStatusBlock_native, FileInformation, Length, FileInformationClass);
					}
				}
				finally
				{
					Interop.NtDll.IO_STATUS_BLOCK* ptr = null;
				}
			}
			finally
			{
				managedToUnmanagedIn.Free();
			}
			return result;
		}

		// Token: 0x0600018B RID: 395
		[LibraryImport("ntdll.dll")]
		[DllImport("ntdll.dll", ExactSpelling = true)]
		internal unsafe static extern uint NtQuerySystemInformation(int SystemInformationClass, void* SystemInformation, uint SystemInformationLength, uint* ReturnLength);

		// Token: 0x0600018C RID: 396 RVA: 0x00004F8C File Offset: 0x0000318C
		[LibraryImport("ntdll.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		private unsafe static int RtlGetVersion(ref Interop.NtDll.RTL_OSVERSIONINFOEX lpVersionInformation)
		{
			int result;
			fixed (Interop.NtDll.RTL_OSVERSIONINFOEX* ptr = &lpVersionInformation)
			{
				result = Interop.NtDll.<RtlGetVersion>g____PInvoke|22_0(ptr);
			}
			return result;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004FA5 File Offset: 0x000031A5
		internal static int RtlGetVersionEx(out Interop.NtDll.RTL_OSVERSIONINFOEX osvi)
		{
			osvi = default(Interop.NtDll.RTL_OSVERSIONINFOEX);
			osvi.dwOSVersionInfoSize = (uint)sizeof(Interop.NtDll.RTL_OSVERSIONINFOEX);
			return Interop.NtDll.RtlGetVersion(ref osvi);
		}

		// Token: 0x0600018E RID: 398
		[CompilerGenerated]
		[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationFile", ExactSpelling = true)]
		internal unsafe static extern int <NtQueryInformationFile>g____PInvoke|17_0(IntPtr __FileHandle_native, Interop.NtDll.IO_STATUS_BLOCK* __IoStatusBlock_native, void* __FileInformation_native, uint __Length_native, uint __FileInformationClass_native);

		// Token: 0x0600018F RID: 399
		[CompilerGenerated]
		[DllImport("ntdll.dll", EntryPoint = "RtlGetVersion", ExactSpelling = true)]
		internal unsafe static extern int <RtlGetVersion>g____PInvoke|22_0(Interop.NtDll.RTL_OSVERSIONINFOEX* __lpVersionInformation_native);

		// Token: 0x02000040 RID: 64
		public enum CreateDisposition : uint
		{
			// Token: 0x0400010E RID: 270
			FILE_SUPERSEDE,
			// Token: 0x0400010F RID: 271
			FILE_OPEN,
			// Token: 0x04000110 RID: 272
			FILE_CREATE,
			// Token: 0x04000111 RID: 273
			FILE_OPEN_IF,
			// Token: 0x04000112 RID: 274
			FILE_OVERWRITE,
			// Token: 0x04000113 RID: 275
			FILE_OVERWRITE_IF
		}

		// Token: 0x02000041 RID: 65
		public enum CreateOptions : uint
		{
			// Token: 0x04000115 RID: 277
			FILE_DIRECTORY_FILE = 1U,
			// Token: 0x04000116 RID: 278
			FILE_WRITE_THROUGH,
			// Token: 0x04000117 RID: 279
			FILE_SEQUENTIAL_ONLY = 4U,
			// Token: 0x04000118 RID: 280
			FILE_NO_INTERMEDIATE_BUFFERING = 8U,
			// Token: 0x04000119 RID: 281
			FILE_SYNCHRONOUS_IO_ALERT = 16U,
			// Token: 0x0400011A RID: 282
			FILE_SYNCHRONOUS_IO_NONALERT = 32U,
			// Token: 0x0400011B RID: 283
			FILE_NON_DIRECTORY_FILE = 64U,
			// Token: 0x0400011C RID: 284
			FILE_CREATE_TREE_CONNECTION = 128U,
			// Token: 0x0400011D RID: 285
			FILE_COMPLETE_IF_OPLOCKED = 256U,
			// Token: 0x0400011E RID: 286
			FILE_NO_EA_KNOWLEDGE = 512U,
			// Token: 0x0400011F RID: 287
			FILE_RANDOM_ACCESS = 2048U,
			// Token: 0x04000120 RID: 288
			FILE_DELETE_ON_CLOSE = 4096U,
			// Token: 0x04000121 RID: 289
			FILE_OPEN_BY_FILE_ID = 8192U,
			// Token: 0x04000122 RID: 290
			FILE_OPEN_FOR_BACKUP_INTENT = 16384U,
			// Token: 0x04000123 RID: 291
			FILE_NO_COMPRESSION = 32768U,
			// Token: 0x04000124 RID: 292
			FILE_OPEN_REQUIRING_OPLOCK = 65536U,
			// Token: 0x04000125 RID: 293
			FILE_DISALLOW_EXCLUSIVE = 131072U,
			// Token: 0x04000126 RID: 294
			FILE_SESSION_AWARE = 262144U,
			// Token: 0x04000127 RID: 295
			FILE_RESERVE_OPFILTER = 1048576U,
			// Token: 0x04000128 RID: 296
			FILE_OPEN_REPARSE_POINT = 2097152U,
			// Token: 0x04000129 RID: 297
			FILE_OPEN_NO_RECALL = 4194304U
		}

		// Token: 0x02000042 RID: 66
		[Flags]
		public enum DesiredAccess : uint
		{
			// Token: 0x0400012B RID: 299
			FILE_READ_DATA = 1U,
			// Token: 0x0400012C RID: 300
			FILE_LIST_DIRECTORY = 1U,
			// Token: 0x0400012D RID: 301
			FILE_WRITE_DATA = 2U,
			// Token: 0x0400012E RID: 302
			FILE_ADD_FILE = 2U,
			// Token: 0x0400012F RID: 303
			FILE_APPEND_DATA = 4U,
			// Token: 0x04000130 RID: 304
			FILE_ADD_SUBDIRECTORY = 4U,
			// Token: 0x04000131 RID: 305
			FILE_CREATE_PIPE_INSTANCE = 4U,
			// Token: 0x04000132 RID: 306
			FILE_READ_EA = 8U,
			// Token: 0x04000133 RID: 307
			FILE_WRITE_EA = 16U,
			// Token: 0x04000134 RID: 308
			FILE_EXECUTE = 32U,
			// Token: 0x04000135 RID: 309
			FILE_TRAVERSE = 32U,
			// Token: 0x04000136 RID: 310
			FILE_DELETE_CHILD = 64U,
			// Token: 0x04000137 RID: 311
			FILE_READ_ATTRIBUTES = 128U,
			// Token: 0x04000138 RID: 312
			FILE_WRITE_ATTRIBUTES = 256U,
			// Token: 0x04000139 RID: 313
			FILE_ALL_ACCESS = 983551U,
			// Token: 0x0400013A RID: 314
			DELETE = 65536U,
			// Token: 0x0400013B RID: 315
			READ_CONTROL = 131072U,
			// Token: 0x0400013C RID: 316
			WRITE_DAC = 262144U,
			// Token: 0x0400013D RID: 317
			WRITE_OWNER = 524288U,
			// Token: 0x0400013E RID: 318
			SYNCHRONIZE = 1048576U,
			// Token: 0x0400013F RID: 319
			STANDARD_RIGHTS_READ = 131072U,
			// Token: 0x04000140 RID: 320
			STANDARD_RIGHTS_WRITE = 131072U,
			// Token: 0x04000141 RID: 321
			STANDARD_RIGHTS_EXECUTE = 131072U,
			// Token: 0x04000142 RID: 322
			FILE_GENERIC_READ = 2147483648U,
			// Token: 0x04000143 RID: 323
			FILE_GENERIC_WRITE = 1073741824U,
			// Token: 0x04000144 RID: 324
			FILE_GENERIC_EXECUTE = 536870912U
		}

		// Token: 0x02000043 RID: 67
		public struct IO_STATUS_BLOCK
		{
			// Token: 0x04000145 RID: 325
			public Interop.NtDll.IO_STATUS_BLOCK.IO_STATUS Status;

			// Token: 0x04000146 RID: 326
			public IntPtr Information;

			// Token: 0x02000044 RID: 68
			[StructLayout(LayoutKind.Explicit)]
			public struct IO_STATUS
			{
				// Token: 0x04000147 RID: 327
				[FieldOffset(0)]
				public uint Status;

				// Token: 0x04000148 RID: 328
				[FieldOffset(0)]
				public IntPtr Pointer;
			}
		}

		// Token: 0x02000045 RID: 69
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct FILE_FULL_DIR_INFORMATION
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000190 RID: 400 RVA: 0x00004FC0 File Offset: 0x000031C0
			public ReadOnlySpan<char> FileName
			{
				get
				{
					return MemoryMarshal.CreateReadOnlySpan<char>(ref this._fileName, (int)(this.FileNameLength / 2U));
				}
			}

			// Token: 0x06000191 RID: 401 RVA: 0x00004FD8 File Offset: 0x000031D8
			public unsafe static Interop.NtDll.FILE_FULL_DIR_INFORMATION* GetNextInfo(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
			{
				if (info == null)
				{
					return null;
				}
				uint nextEntryOffset = info->NextEntryOffset;
				if (nextEntryOffset == 0U)
				{
					return null;
				}
				return info + nextEntryOffset / (uint)sizeof(Interop.NtDll.FILE_FULL_DIR_INFORMATION);
			}

			// Token: 0x04000149 RID: 329
			public uint NextEntryOffset;

			// Token: 0x0400014A RID: 330
			public uint FileIndex;

			// Token: 0x0400014B RID: 331
			public Interop.LongFileTime CreationTime;

			// Token: 0x0400014C RID: 332
			public Interop.LongFileTime LastAccessTime;

			// Token: 0x0400014D RID: 333
			public Interop.LongFileTime LastWriteTime;

			// Token: 0x0400014E RID: 334
			public Interop.LongFileTime ChangeTime;

			// Token: 0x0400014F RID: 335
			public long EndOfFile;

			// Token: 0x04000150 RID: 336
			public long AllocationSize;

			// Token: 0x04000151 RID: 337
			public FileAttributes FileAttributes;

			// Token: 0x04000152 RID: 338
			public uint FileNameLength;

			// Token: 0x04000153 RID: 339
			public uint EaSize;

			// Token: 0x04000154 RID: 340
			private char _fileName;
		}

		// Token: 0x02000046 RID: 70
		public enum FILE_INFORMATION_CLASS : uint
		{
			// Token: 0x04000156 RID: 342
			FileDirectoryInformation = 1U,
			// Token: 0x04000157 RID: 343
			FileFullDirectoryInformation,
			// Token: 0x04000158 RID: 344
			FileBothDirectoryInformation,
			// Token: 0x04000159 RID: 345
			FileBasicInformation,
			// Token: 0x0400015A RID: 346
			FileStandardInformation,
			// Token: 0x0400015B RID: 347
			FileInternalInformation,
			// Token: 0x0400015C RID: 348
			FileEaInformation,
			// Token: 0x0400015D RID: 349
			FileAccessInformation,
			// Token: 0x0400015E RID: 350
			FileNameInformation,
			// Token: 0x0400015F RID: 351
			FileRenameInformation,
			// Token: 0x04000160 RID: 352
			FileLinkInformation,
			// Token: 0x04000161 RID: 353
			FileNamesInformation,
			// Token: 0x04000162 RID: 354
			FileDispositionInformation,
			// Token: 0x04000163 RID: 355
			FilePositionInformation,
			// Token: 0x04000164 RID: 356
			FileFullEaInformation,
			// Token: 0x04000165 RID: 357
			FileModeInformation,
			// Token: 0x04000166 RID: 358
			FileAlignmentInformation,
			// Token: 0x04000167 RID: 359
			FileAllInformation,
			// Token: 0x04000168 RID: 360
			FileAllocationInformation,
			// Token: 0x04000169 RID: 361
			FileEndOfFileInformation,
			// Token: 0x0400016A RID: 362
			FileAlternateNameInformation,
			// Token: 0x0400016B RID: 363
			FileStreamInformation,
			// Token: 0x0400016C RID: 364
			FilePipeInformation,
			// Token: 0x0400016D RID: 365
			FilePipeLocalInformation,
			// Token: 0x0400016E RID: 366
			FilePipeRemoteInformation,
			// Token: 0x0400016F RID: 367
			FileMailslotQueryInformation,
			// Token: 0x04000170 RID: 368
			FileMailslotSetInformation,
			// Token: 0x04000171 RID: 369
			FileCompressionInformation,
			// Token: 0x04000172 RID: 370
			FileObjectIdInformation,
			// Token: 0x04000173 RID: 371
			FileCompletionInformation,
			// Token: 0x04000174 RID: 372
			FileMoveClusterInformation,
			// Token: 0x04000175 RID: 373
			FileQuotaInformation,
			// Token: 0x04000176 RID: 374
			FileReparsePointInformation,
			// Token: 0x04000177 RID: 375
			FileNetworkOpenInformation,
			// Token: 0x04000178 RID: 376
			FileAttributeTagInformation,
			// Token: 0x04000179 RID: 377
			FileTrackingInformation,
			// Token: 0x0400017A RID: 378
			FileIdBothDirectoryInformation,
			// Token: 0x0400017B RID: 379
			FileIdFullDirectoryInformation,
			// Token: 0x0400017C RID: 380
			FileValidDataLengthInformation,
			// Token: 0x0400017D RID: 381
			FileShortNameInformation,
			// Token: 0x0400017E RID: 382
			FileIoCompletionNotificationInformation,
			// Token: 0x0400017F RID: 383
			FileIoStatusBlockRangeInformation,
			// Token: 0x04000180 RID: 384
			FileIoPriorityHintInformation,
			// Token: 0x04000181 RID: 385
			FileSfioReserveInformation,
			// Token: 0x04000182 RID: 386
			FileSfioVolumeInformation,
			// Token: 0x04000183 RID: 387
			FileHardLinkInformation,
			// Token: 0x04000184 RID: 388
			FileProcessIdsUsingFileInformation,
			// Token: 0x04000185 RID: 389
			FileNormalizedNameInformation,
			// Token: 0x04000186 RID: 390
			FileNetworkPhysicalNameInformation,
			// Token: 0x04000187 RID: 391
			FileIdGlobalTxDirectoryInformation,
			// Token: 0x04000188 RID: 392
			FileIsRemoteDeviceInformation,
			// Token: 0x04000189 RID: 393
			FileUnusedInformation,
			// Token: 0x0400018A RID: 394
			FileNumaNodeInformation,
			// Token: 0x0400018B RID: 395
			FileStandardLinkInformation,
			// Token: 0x0400018C RID: 396
			FileRemoteProtocolInformation,
			// Token: 0x0400018D RID: 397
			FileRenameInformationBypassAccessCheck,
			// Token: 0x0400018E RID: 398
			FileLinkInformationBypassAccessCheck,
			// Token: 0x0400018F RID: 399
			FileVolumeNameInformation,
			// Token: 0x04000190 RID: 400
			FileIdInformation,
			// Token: 0x04000191 RID: 401
			FileIdExtdDirectoryInformation,
			// Token: 0x04000192 RID: 402
			FileReplaceCompletionInformation,
			// Token: 0x04000193 RID: 403
			FileHardLinkFullIdInformation,
			// Token: 0x04000194 RID: 404
			FileIdExtdBothDirectoryInformation,
			// Token: 0x04000195 RID: 405
			FileDispositionInformationEx,
			// Token: 0x04000196 RID: 406
			FileRenameInformationEx,
			// Token: 0x04000197 RID: 407
			FileRenameInformationExBypassAccessCheck,
			// Token: 0x04000198 RID: 408
			FileDesiredStorageClassInformation,
			// Token: 0x04000199 RID: 409
			FileStatInformation
		}

		// Token: 0x02000047 RID: 71
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		internal struct RTL_OSVERSIONINFOEX
		{
			// Token: 0x0400019A RID: 410
			internal uint dwOSVersionInfoSize;

			// Token: 0x0400019B RID: 411
			internal uint dwMajorVersion;

			// Token: 0x0400019C RID: 412
			internal uint dwMinorVersion;

			// Token: 0x0400019D RID: 413
			internal uint dwBuildNumber;

			// Token: 0x0400019E RID: 414
			internal uint dwPlatformId;

			// Token: 0x0400019F RID: 415
			[FixedBuffer(typeof(char), 128)]
			internal Interop.NtDll.RTL_OSVERSIONINFOEX.<szCSDVersion>e__FixedBuffer szCSDVersion;

			// Token: 0x02000048 RID: 72
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Size = 256)]
			public struct <szCSDVersion>e__FixedBuffer
			{
				// Token: 0x040001A0 RID: 416
				public char FixedElementField;
			}
		}

		// Token: 0x02000049 RID: 73
		internal struct SYSTEM_LEAP_SECOND_INFORMATION
		{
			// Token: 0x040001A1 RID: 417
			public Interop.BOOLEAN Enabled;

			// Token: 0x040001A2 RID: 418
			public uint Flags;
		}
	}

	// Token: 0x0200004A RID: 74
	internal static class StatusOptions
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00004FFE File Offset: 0x000031FE
		internal static bool NT_SUCCESS(uint ntStatus)
		{
			return ntStatus >= 0U;
		}
	}

	// Token: 0x0200004B RID: 75
	internal struct UNICODE_STRING
	{
		// Token: 0x040001A3 RID: 419
		internal ushort Length;

		// Token: 0x040001A4 RID: 420
		internal ushort MaximumLength;

		// Token: 0x040001A5 RID: 421
		internal IntPtr Buffer;
	}

	// Token: 0x0200004C RID: 76
	internal struct SECURITY_QUALITY_OF_SERVICE
	{
		// Token: 0x040001A6 RID: 422
		public uint Length;

		// Token: 0x040001A7 RID: 423
		public Interop.ImpersonationLevel ImpersonationLevel;

		// Token: 0x040001A8 RID: 424
		public Interop.ContextTrackingMode ContextTrackingMode;

		// Token: 0x040001A9 RID: 425
		public Interop.BOOLEAN EffectiveOnly;
	}

	// Token: 0x0200004D RID: 77
	public enum ImpersonationLevel : uint
	{
		// Token: 0x040001AB RID: 427
		Anonymous,
		// Token: 0x040001AC RID: 428
		Identification,
		// Token: 0x040001AD RID: 429
		Impersonation,
		// Token: 0x040001AE RID: 430
		Delegation
	}

	// Token: 0x0200004E RID: 78
	public enum ContextTrackingMode : byte
	{
		// Token: 0x040001B0 RID: 432
		Static,
		// Token: 0x040001B1 RID: 433
		Dynamic
	}

	// Token: 0x0200004F RID: 79
	internal struct OBJECT_ATTRIBUTES
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00005007 File Offset: 0x00003207
		public unsafe OBJECT_ATTRIBUTES(Interop.UNICODE_STRING* objectName, Interop.ObjectAttributes attributes, IntPtr rootDirectory, Interop.SECURITY_QUALITY_OF_SERVICE* securityQualityOfService = null)
		{
			this.Length = (uint)sizeof(Interop.OBJECT_ATTRIBUTES);
			this.RootDirectory = rootDirectory;
			this.ObjectName = objectName;
			this.Attributes = attributes;
			this.SecurityDescriptor = null;
			this.SecurityQualityOfService = securityQualityOfService;
		}

		// Token: 0x040001B2 RID: 434
		public uint Length;

		// Token: 0x040001B3 RID: 435
		public IntPtr RootDirectory;

		// Token: 0x040001B4 RID: 436
		public unsafe Interop.UNICODE_STRING* ObjectName;

		// Token: 0x040001B5 RID: 437
		public Interop.ObjectAttributes Attributes;

		// Token: 0x040001B6 RID: 438
		public unsafe void* SecurityDescriptor;

		// Token: 0x040001B7 RID: 439
		public unsafe Interop.SECURITY_QUALITY_OF_SERVICE* SecurityQualityOfService;
	}

	// Token: 0x02000050 RID: 80
	[Flags]
	public enum ObjectAttributes : uint
	{
		// Token: 0x040001B9 RID: 441
		OBJ_INHERIT = 2U,
		// Token: 0x040001BA RID: 442
		OBJ_PERMANENT = 16U,
		// Token: 0x040001BB RID: 443
		OBJ_EXCLUSIVE = 32U,
		// Token: 0x040001BC RID: 444
		OBJ_CASE_INSENSITIVE = 64U,
		// Token: 0x040001BD RID: 445
		OBJ_OPENIF = 128U,
		// Token: 0x040001BE RID: 446
		OBJ_OPENLINK = 256U
	}

	// Token: 0x02000051 RID: 81
	internal static class OleAut32
	{
		// Token: 0x06000194 RID: 404 RVA: 0x0000503C File Offset: 0x0000323C
		[LibraryImport("oleaut32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static IntPtr SysAllocStringByteLen(byte[] str, uint len)
		{
			IntPtr result;
			fixed (byte* pinnableReference = ArrayMarshaller<byte, byte>.ManagedToUnmanagedIn.GetPinnableReference(str))
			{
				void* _str_native = (void*)pinnableReference;
				result = Interop.OleAut32.<SysAllocStringByteLen>g____PInvoke|0_0((byte*)_str_native, len);
			}
			return result;
		}

		// Token: 0x06000195 RID: 405
		[LibraryImport("oleaut32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		internal static extern IntPtr SysAllocStringLen(IntPtr src, uint len);

		// Token: 0x06000196 RID: 406
		[LibraryImport("oleaut32.dll")]
		[DllImport("oleaut32.dll", ExactSpelling = true)]
		internal static extern void SysFreeString(IntPtr bstr);

		// Token: 0x06000197 RID: 407
		[CompilerGenerated]
		[DllImport("oleaut32.dll", EntryPoint = "SysAllocStringByteLen", ExactSpelling = true)]
		internal unsafe static extern IntPtr <SysAllocStringByteLen>g____PInvoke|0_0(byte* __str_native, uint __len_native);
	}

	// Token: 0x02000052 RID: 82
	internal static class Ole32
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00005060 File Offset: 0x00003260
		[LibraryImport("ole32.dll", StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int CLSIDFromProgID(string lpszProgID, out Guid lpclsid)
		{
			lpclsid = default(Guid);
			int result;
			fixed (Guid* ptr = &lpclsid)
			{
				Guid* _lpclsid_native = ptr;
				fixed (char* pinnableReference = Utf16StringMarshaller.GetPinnableReference(lpszProgID))
				{
					void* _lpszProgID_native = (void*)pinnableReference;
					result = Interop.Ole32.<CLSIDFromProgID>g____PInvoke|0_0((ushort*)_lpszProgID_native, _lpclsid_native);
				}
			}
			return result;
		}

		// Token: 0x06000199 RID: 409
		[LibraryImport("ole32.dll")]
		[DllImport("ole32.dll", ExactSpelling = true)]
		internal unsafe static extern int CoCreateGuid(Guid* guid);

		// Token: 0x0600019A RID: 410 RVA: 0x00005090 File Offset: 0x00003290
		[LibraryImport("ole32.dll")]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int CoGetStandardMarshal(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out IntPtr ppMarshal)
		{
			ppMarshal = (IntPtr)0;
			int result;
			fixed (IntPtr* ptr = &ppMarshal)
			{
				IntPtr* _ppMarshal_native = ptr;
				fixed (Guid* ptr2 = &riid)
				{
					result = Interop.Ole32.<CoGetStandardMarshal>g____PInvoke|2_0(ptr2, pv, dwDestContext, pvDestContext, mshlflags, _ppMarshal_native);
				}
			}
			return result;
		}

		// Token: 0x0600019B RID: 411
		[LibraryImport("ole32.dll")]
		[DllImport("ole32.dll", ExactSpelling = true)]
		internal static extern IntPtr CoTaskMemAlloc(UIntPtr cb);

		// Token: 0x0600019C RID: 412
		[LibraryImport("ole32.dll")]
		[DllImport("ole32.dll", ExactSpelling = true)]
		internal static extern IntPtr CoTaskMemRealloc(IntPtr pv, UIntPtr cb);

		// Token: 0x0600019D RID: 413
		[LibraryImport("ole32.dll")]
		[DllImport("ole32.dll", ExactSpelling = true)]
		internal static extern void CoTaskMemFree(IntPtr ptr);

		// Token: 0x0600019E RID: 414
		[LibraryImport("ole32.dll")]
		[DllImport("ole32.dll", ExactSpelling = true)]
		internal static extern void PropVariantClear(IntPtr pObject);

		// Token: 0x0600019F RID: 415
		[CompilerGenerated]
		[DllImport("ole32.dll", EntryPoint = "CLSIDFromProgID", ExactSpelling = true)]
		internal unsafe static extern int <CLSIDFromProgID>g____PInvoke|0_0(ushort* __lpszProgID_native, Guid* __lpclsid_native);

		// Token: 0x060001A0 RID: 416
		[CompilerGenerated]
		[DllImport("ole32.dll", EntryPoint = "CoGetStandardMarshal", ExactSpelling = true)]
		internal unsafe static extern int <CoGetStandardMarshal>g____PInvoke|2_0(Guid* __riid_native, IntPtr __pv_native, int __dwDestContext_native, IntPtr __pvDestContext_native, int __mshlflags_native, IntPtr* __ppMarshal_native);
	}

	// Token: 0x02000053 RID: 83
	internal static class Secur32
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x000050C0 File Offset: 0x000032C0
		[LibraryImport("secur32.dll", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static Interop.BOOLEAN GetUserNameExW(int NameFormat, ref char lpNameBuffer, ref uint lpnSize)
		{
			Interop.BOOLEAN result;
			int lastSystemError;
			fixed (uint* ptr = &lpnSize)
			{
				uint* _lpnSize_native = ptr;
				fixed (char* ptr2 = &lpNameBuffer)
				{
					char* _lpNameBuffer_native = ptr2;
					Marshal.SetLastSystemError(0);
					result = Interop.Secur32.<GetUserNameExW>g____PInvoke|0_0(NameFormat, _lpNameBuffer_native, _lpnSize_native);
					lastSystemError = Marshal.GetLastSystemError();
				}
			}
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060001A2 RID: 418
		[CompilerGenerated]
		[DllImport("secur32.dll", EntryPoint = "GetUserNameExW", ExactSpelling = true)]
		internal unsafe static extern Interop.BOOLEAN <GetUserNameExW>g____PInvoke|0_0(int __NameFormat_native, char* __lpNameBuffer_native, uint* __lpnSize_native);
	}

	// Token: 0x02000054 RID: 84
	internal static class Shell32
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x000050F8 File Offset: 0x000032F8
		[LibraryImport("shell32.dll", SetLastError = false, StringMarshalling = StringMarshalling.Utf16)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int SHGetKnownFolderPath(in Guid rfid, uint dwFlags, IntPtr hToken, out string ppszPath)
		{
			bool flag = false;
			ppszPath = null;
			ushort* unmanaged = default(ushort*);
			int result = 0;
			try
			{
				try
				{
					fixed (Guid* ptr = &rfid)
					{
						result = Interop.Shell32.<SHGetKnownFolderPath>g____PInvoke|1_0(ptr, dwFlags, hToken, &unmanaged);
					}
				}
				finally
				{
					Guid* ptr = null;
				}
				flag = true;
				ppszPath = Utf16StringMarshaller.ConvertToManaged(unmanaged);
			}
			finally
			{
				if (flag)
				{
					Utf16StringMarshaller.Free(unmanaged);
				}
			}
			return result;
		}

		// Token: 0x060001A4 RID: 420
		[CompilerGenerated]
		[DllImport("shell32.dll", EntryPoint = "SHGetKnownFolderPath", ExactSpelling = true)]
		internal unsafe static extern int <SHGetKnownFolderPath>g____PInvoke|1_0(Guid* __rfid_native, uint __dwFlags_native, IntPtr __hToken_native, ushort** __ppszPath_native);
	}

	// Token: 0x02000055 RID: 85
	internal static class Ucrtbase
	{
		// Token: 0x060001A5 RID: 421
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void* _aligned_malloc(UIntPtr size, UIntPtr alignment);

		// Token: 0x060001A6 RID: 422
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void _aligned_free(void* ptr);

		// Token: 0x060001A7 RID: 423
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void* _aligned_realloc(void* ptr, UIntPtr size, UIntPtr alignment);

		// Token: 0x060001A8 RID: 424
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void* calloc(UIntPtr num, UIntPtr size);

		// Token: 0x060001A9 RID: 425
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void free(void* ptr);

		// Token: 0x060001AA RID: 426
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void* malloc(UIntPtr size);

		// Token: 0x060001AB RID: 427
		[LibraryImport("ucrtbase.dll")]
		[UnmanagedCallConv(CallConvs = new Type[]
		{
			typeof(CallConvCdecl)
		})]
		[DllImport("ucrtbase.dll", ExactSpelling = true)]
		internal unsafe static extern void* realloc(void* ptr, UIntPtr new_size);
	}

	// Token: 0x02000056 RID: 86
	internal static class User32
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0000515C File Offset: 0x0000335C
		[LibraryImport("user32.dll", EntryPoint = "LoadStringW", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		internal unsafe static int LoadString(IntPtr hInstance, uint uID, char* lpBuffer, int cchBufferMax)
		{
			Marshal.SetLastSystemError(0);
			int result = Interop.User32.<LoadString>g____PInvoke|207_0(hInstance, uID, lpBuffer, cchBufferMax);
			Marshal.SetLastPInvokeError(Marshal.GetLastSystemError());
			return result;
		}

		// Token: 0x060001AD RID: 429
		[LibraryImport("user32.dll", EntryPoint = "SendMessageTimeoutW")]
		[DllImport("user32.dll", EntryPoint = "SendMessageTimeoutW", ExactSpelling = true)]
		public unsafe static extern IntPtr SendMessageTimeout(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam, int flags, int timeout, IntPtr* pdwResult);

		// Token: 0x060001AE RID: 430
		[LibraryImport("user32.dll")]
		[DllImport("user32.dll", ExactSpelling = true)]
		internal static extern IntPtr GetProcessWindowStation();

		// Token: 0x060001AF RID: 431 RVA: 0x00005178 File Offset: 0x00003378
		[LibraryImport("user32.dll", SetLastError = true)]
		[GeneratedCode("Microsoft.Interop.LibraryImportGenerator", "42.42.42.42")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public unsafe static bool GetUserObjectInformationW(IntPtr hObj, int nIndex, void* pvBuffer, uint nLength, ref uint lpnLengthNeeded)
		{
			int num;
			int lastSystemError;
			fixed (uint* ptr = &lpnLengthNeeded)
			{
				uint* _lpnLengthNeeded_native = ptr;
				Marshal.SetLastSystemError(0);
				num = Interop.User32.<GetUserObjectInformationW>g____PInvoke|210_0(hObj, nIndex, pvBuffer, nLength, _lpnLengthNeeded_native);
				lastSystemError = Marshal.GetLastSystemError();
			}
			bool result = num != 0;
			Marshal.SetLastPInvokeError(lastSystemError);
			return result;
		}

		// Token: 0x060001B0 RID: 432
		[CompilerGenerated]
		[DllImport("user32.dll", EntryPoint = "LoadStringW", ExactSpelling = true)]
		internal unsafe static extern int <LoadString>g____PInvoke|207_0(IntPtr __hInstance_native, uint __uID_native, char* __lpBuffer_native, int __cchBufferMax_native);

		// Token: 0x060001B1 RID: 433
		[CompilerGenerated]
		[DllImport("user32.dll", EntryPoint = "GetUserObjectInformationW", ExactSpelling = true)]
		internal unsafe static extern int <GetUserObjectInformationW>g____PInvoke|210_0(IntPtr __hObj_native, int __nIndex_native, void* __pvBuffer_native, uint __nLength_native, uint* __lpnLengthNeeded_native);

		// Token: 0x02000057 RID: 87
		internal struct USEROBJECTFLAGS
		{
			// Token: 0x040001BF RID: 447
			public int fInherit;

			// Token: 0x040001C0 RID: 448
			public int fReserved;

			// Token: 0x040001C1 RID: 449
			public int dwFlags;
		}
	}

	// Token: 0x02000058 RID: 88
	internal struct LongFileTime
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x000051AD File Offset: 0x000033AD
		internal DateTimeOffset ToDateTimeOffset()
		{
			return new DateTimeOffset(DateTime.FromFileTimeUtc(this.TicksSince1601));
		}

		// Token: 0x040001C2 RID: 450
		internal long TicksSince1601;
	}
}
