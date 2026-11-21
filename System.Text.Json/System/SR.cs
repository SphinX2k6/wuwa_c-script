using System;
using System.Resources;
using FxResources.System.Text.Json;

namespace System
{
	// Token: 0x02000004 RID: 4
	internal static class SR
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020DC File Offset: 0x000002DC
		internal static bool UsingResourceKeys()
		{
			return System.SR.s_usingResourceKeys;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020E4 File Offset: 0x000002E4
		private static string GetResourceString(string resourceKey)
		{
			if (System.SR.UsingResourceKeys())
			{
				return resourceKey;
			}
			string result = null;
			try
			{
				result = System.SR.ResourceManager.GetString(resourceKey);
			}
			catch (MissingManifestResourceException)
			{
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002120 File Offset: 0x00000320
		internal unsafe static string Format(string resourceFormat, object p1)
		{
			if (System.SR.UsingResourceKeys())
			{
				string separator = ", ";
				<>y__InlineArray2<object> <>y__InlineArray = default(<>y__InlineArray2<object>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<object>, object>(ref <>y__InlineArray, 0) = resourceFormat;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<object>, object>(ref <>y__InlineArray, 1) = p1;
				return string.Join(separator, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<object>, object>(<>y__InlineArray, 2));
			}
			return string.Format(resourceFormat, p1);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000216C File Offset: 0x0000036C
		internal unsafe static string Format(string resourceFormat, object p1, object p2)
		{
			if (System.SR.UsingResourceKeys())
			{
				string separator = ", ";
				<>y__InlineArray3<object> <>y__InlineArray = default(<>y__InlineArray3<object>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<object>, object>(ref <>y__InlineArray, 0) = resourceFormat;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<object>, object>(ref <>y__InlineArray, 1) = p1;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<object>, object>(ref <>y__InlineArray, 2) = p2;
				return string.Join(separator, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<object>, object>(<>y__InlineArray, 3));
			}
			return string.Format(resourceFormat, p1, p2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021C4 File Offset: 0x000003C4
		internal unsafe static string Format(string resourceFormat, object p1, object p2, object p3)
		{
			if (System.SR.UsingResourceKeys())
			{
				string separator = ", ";
				<>y__InlineArray4<object> <>y__InlineArray = default(<>y__InlineArray4<object>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 0) = resourceFormat;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 1) = p1;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 2) = p2;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<object>, object>(ref <>y__InlineArray, 3) = p3;
				return string.Join(separator, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<object>, object>(<>y__InlineArray, 4));
			}
			return string.Format(resourceFormat, p1, p2, p3);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002224 File Offset: 0x00000424
		internal static string Format(string resourceFormat, params object[] args)
		{
			if (args == null)
			{
				return resourceFormat;
			}
			if (System.SR.UsingResourceKeys())
			{
				return resourceFormat + ", " + string.Join(", ", args);
			}
			return string.Format(resourceFormat, args);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002250 File Offset: 0x00000450
		internal static ResourceManager ResourceManager
		{
			get
			{
				ResourceManager result;
				if ((result = System.SR.s_resourceManager) == null)
				{
					result = (System.SR.s_resourceManager = new ResourceManager(typeof(FxResources.System.Text.Json.SR)));
				}
				return result;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002270 File Offset: 0x00000470
		internal static string ArrayDepthTooLarge
		{
			get
			{
				return System.SR.GetResourceString("ArrayDepthTooLarge");
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000227C File Offset: 0x0000047C
		internal static string CannotReadIncompleteUTF16
		{
			get
			{
				return System.SR.GetResourceString("CannotReadIncompleteUTF16");
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002288 File Offset: 0x00000488
		internal static string CannotReadInvalidUTF16
		{
			get
			{
				return System.SR.GetResourceString("CannotReadInvalidUTF16");
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002294 File Offset: 0x00000494
		internal static string CannotStartObjectArrayAfterPrimitiveOrClose
		{
			get
			{
				return System.SR.GetResourceString("CannotStartObjectArrayAfterPrimitiveOrClose");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000022A0 File Offset: 0x000004A0
		internal static string CannotStartObjectArrayWithoutProperty
		{
			get
			{
				return System.SR.GetResourceString("CannotStartObjectArrayWithoutProperty");
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000022AC File Offset: 0x000004AC
		internal static string CannotTranscodeInvalidUtf8
		{
			get
			{
				return System.SR.GetResourceString("CannotTranscodeInvalidUtf8");
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000022B8 File Offset: 0x000004B8
		internal static string CannotDecodeInvalidBase64
		{
			get
			{
				return System.SR.GetResourceString("CannotDecodeInvalidBase64");
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000022C4 File Offset: 0x000004C4
		internal static string CannotTranscodeInvalidUtf16
		{
			get
			{
				return System.SR.GetResourceString("CannotTranscodeInvalidUtf16");
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000022D0 File Offset: 0x000004D0
		internal static string CannotEncodeInvalidUTF16
		{
			get
			{
				return System.SR.GetResourceString("CannotEncodeInvalidUTF16");
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000022DC File Offset: 0x000004DC
		internal static string CannotEncodeInvalidUTF8
		{
			get
			{
				return System.SR.GetResourceString("CannotEncodeInvalidUTF8");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000022E8 File Offset: 0x000004E8
		internal static string CannotWritePropertyWithinArray
		{
			get
			{
				return System.SR.GetResourceString("CannotWritePropertyWithinArray");
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000022F4 File Offset: 0x000004F4
		internal static string CannotWritePropertyAfterProperty
		{
			get
			{
				return System.SR.GetResourceString("CannotWritePropertyAfterProperty");
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002300 File Offset: 0x00000500
		internal static string CannotWriteValueAfterPrimitiveOrClose
		{
			get
			{
				return System.SR.GetResourceString("CannotWriteValueAfterPrimitiveOrClose");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000230C File Offset: 0x0000050C
		internal static string CannotWriteValueWithinObject
		{
			get
			{
				return System.SR.GetResourceString("CannotWriteValueWithinObject");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002318 File Offset: 0x00000518
		internal static string DepthTooLarge
		{
			get
			{
				return System.SR.GetResourceString("DepthTooLarge");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002324 File Offset: 0x00000524
		internal static string DestinationTooShort
		{
			get
			{
				return System.SR.GetResourceString("DestinationTooShort");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002330 File Offset: 0x00000530
		internal static string EndOfCommentNotFound
		{
			get
			{
				return System.SR.GetResourceString("EndOfCommentNotFound");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000233C File Offset: 0x0000053C
		internal static string EndOfStringNotFound
		{
			get
			{
				return System.SR.GetResourceString("EndOfStringNotFound");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002348 File Offset: 0x00000548
		internal static string ExpectedEndAfterSingleJson
		{
			get
			{
				return System.SR.GetResourceString("ExpectedEndAfterSingleJson");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002354 File Offset: 0x00000554
		internal static string ExpectedEndOfDigitNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedEndOfDigitNotFound");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002360 File Offset: 0x00000560
		internal static string ExpectedFalse
		{
			get
			{
				return System.SR.GetResourceString("ExpectedFalse");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000236C File Offset: 0x0000056C
		internal static string ExpectedJsonTokens
		{
			get
			{
				return System.SR.GetResourceString("ExpectedJsonTokens");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002378 File Offset: 0x00000578
		internal static string ExpectedOneCompleteToken
		{
			get
			{
				return System.SR.GetResourceString("ExpectedOneCompleteToken");
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002384 File Offset: 0x00000584
		internal static string ExpectedNextDigitEValueNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedNextDigitEValueNotFound");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002390 File Offset: 0x00000590
		internal static string ExpectedNull
		{
			get
			{
				return System.SR.GetResourceString("ExpectedNull");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000239C File Offset: 0x0000059C
		internal static string ExpectedSeparatorAfterPropertyNameNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedSeparatorAfterPropertyNameNotFound");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000023A8 File Offset: 0x000005A8
		internal static string ExpectedStartOfPropertyNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedStartOfPropertyNotFound");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000023B4 File Offset: 0x000005B4
		internal static string ExpectedStartOfPropertyOrValueNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedStartOfPropertyOrValueNotFound");
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000023C0 File Offset: 0x000005C0
		internal static string ExpectedStartOfValueNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedStartOfValueNotFound");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000023CC File Offset: 0x000005CC
		internal static string ExpectedTrue
		{
			get
			{
				return System.SR.GetResourceString("ExpectedTrue");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000023D8 File Offset: 0x000005D8
		internal static string ExpectedValueAfterPropertyNameNotFound
		{
			get
			{
				return System.SR.GetResourceString("ExpectedValueAfterPropertyNameNotFound");
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000023E4 File Offset: 0x000005E4
		internal static string FailedToGetLargerSpan
		{
			get
			{
				return System.SR.GetResourceString("FailedToGetLargerSpan");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000023F0 File Offset: 0x000005F0
		internal static string FoundInvalidCharacter
		{
			get
			{
				return System.SR.GetResourceString("FoundInvalidCharacter");
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000023FC File Offset: 0x000005FC
		internal static string InvalidCast
		{
			get
			{
				return System.SR.GetResourceString("InvalidCast");
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002408 File Offset: 0x00000608
		internal static string InvalidCharacterAfterEscapeWithinString
		{
			get
			{
				return System.SR.GetResourceString("InvalidCharacterAfterEscapeWithinString");
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002414 File Offset: 0x00000614
		internal static string InvalidCharacterWithinString
		{
			get
			{
				return System.SR.GetResourceString("InvalidCharacterWithinString");
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002420 File Offset: 0x00000620
		internal static string UnsupportedEnumIdentifier
		{
			get
			{
				return System.SR.GetResourceString("UnsupportedEnumIdentifier");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000242C File Offset: 0x0000062C
		internal static string InvalidEndOfJsonNonPrimitive
		{
			get
			{
				return System.SR.GetResourceString("InvalidEndOfJsonNonPrimitive");
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002438 File Offset: 0x00000638
		internal static string InvalidHexCharacterWithinString
		{
			get
			{
				return System.SR.GetResourceString("InvalidHexCharacterWithinString");
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002444 File Offset: 0x00000644
		internal static string JsonDocumentDoesNotSupportComments
		{
			get
			{
				return System.SR.GetResourceString("JsonDocumentDoesNotSupportComments");
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002450 File Offset: 0x00000650
		internal static string JsonElementHasWrongType
		{
			get
			{
				return System.SR.GetResourceString("JsonElementHasWrongType");
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000245C File Offset: 0x0000065C
		internal static string JsonElementDeepEqualsInsufficientExecutionStack
		{
			get
			{
				return System.SR.GetResourceString("JsonElementDeepEqualsInsufficientExecutionStack");
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002468 File Offset: 0x00000668
		internal static string JsonNumberExponentTooLarge
		{
			get
			{
				return System.SR.GetResourceString("JsonNumberExponentTooLarge");
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002474 File Offset: 0x00000674
		internal static string DefaultTypeInfoResolverImmutable
		{
			get
			{
				return System.SR.GetResourceString("DefaultTypeInfoResolverImmutable");
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002480 File Offset: 0x00000680
		internal static string TypeInfoResolverChainImmutable
		{
			get
			{
				return System.SR.GetResourceString("TypeInfoResolverChainImmutable");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000248C File Offset: 0x0000068C
		internal static string TypeInfoImmutable
		{
			get
			{
				return System.SR.GetResourceString("TypeInfoImmutable");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002498 File Offset: 0x00000698
		internal static string MaxDepthMustBePositive
		{
			get
			{
				return System.SR.GetResourceString("MaxDepthMustBePositive");
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000024A4 File Offset: 0x000006A4
		internal static string CommentHandlingMustBeValid
		{
			get
			{
				return System.SR.GetResourceString("CommentHandlingMustBeValid");
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000024B0 File Offset: 0x000006B0
		internal static string MismatchedObjectArray
		{
			get
			{
				return System.SR.GetResourceString("MismatchedObjectArray");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000024BC File Offset: 0x000006BC
		internal static string CannotWriteEndAfterProperty
		{
			get
			{
				return System.SR.GetResourceString("CannotWriteEndAfterProperty");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000024C8 File Offset: 0x000006C8
		internal static string ObjectDepthTooLarge
		{
			get
			{
				return System.SR.GetResourceString("ObjectDepthTooLarge");
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000024D4 File Offset: 0x000006D4
		internal static string PropertyNameTooLarge
		{
			get
			{
				return System.SR.GetResourceString("PropertyNameTooLarge");
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000024E0 File Offset: 0x000006E0
		internal static string FormatDecimal
		{
			get
			{
				return System.SR.GetResourceString("FormatDecimal");
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000024EC File Offset: 0x000006EC
		internal static string FormatDouble
		{
			get
			{
				return System.SR.GetResourceString("FormatDouble");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000024F8 File Offset: 0x000006F8
		internal static string FormatInt32
		{
			get
			{
				return System.SR.GetResourceString("FormatInt32");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002504 File Offset: 0x00000704
		internal static string FormatInt64
		{
			get
			{
				return System.SR.GetResourceString("FormatInt64");
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002510 File Offset: 0x00000710
		internal static string FormatSingle
		{
			get
			{
				return System.SR.GetResourceString("FormatSingle");
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000251C File Offset: 0x0000071C
		internal static string FormatUInt32
		{
			get
			{
				return System.SR.GetResourceString("FormatUInt32");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002528 File Offset: 0x00000728
		internal static string FormatUInt64
		{
			get
			{
				return System.SR.GetResourceString("FormatUInt64");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002534 File Offset: 0x00000734
		internal static string RequiredDigitNotFoundAfterDecimal
		{
			get
			{
				return System.SR.GetResourceString("RequiredDigitNotFoundAfterDecimal");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002540 File Offset: 0x00000740
		internal static string RequiredDigitNotFoundAfterSign
		{
			get
			{
				return System.SR.GetResourceString("RequiredDigitNotFoundAfterSign");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000254C File Offset: 0x0000074C
		internal static string RequiredDigitNotFoundEndOfData
		{
			get
			{
				return System.SR.GetResourceString("RequiredDigitNotFoundEndOfData");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002558 File Offset: 0x00000758
		internal static string SpecialNumberValuesNotSupported
		{
			get
			{
				return System.SR.GetResourceString("SpecialNumberValuesNotSupported");
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002564 File Offset: 0x00000764
		internal static string ValueTooLarge
		{
			get
			{
				return System.SR.GetResourceString("ValueTooLarge");
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002570 File Offset: 0x00000770
		internal static string ZeroDepthAtEnd
		{
			get
			{
				return System.SR.GetResourceString("ZeroDepthAtEnd");
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000257C File Offset: 0x0000077C
		internal static string DeserializeUnableToConvertValue
		{
			get
			{
				return System.SR.GetResourceString("DeserializeUnableToConvertValue");
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002588 File Offset: 0x00000788
		internal static string DeserializeWrongType
		{
			get
			{
				return System.SR.GetResourceString("DeserializeWrongType");
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002594 File Offset: 0x00000794
		internal static string SerializationInvalidBufferSize
		{
			get
			{
				return System.SR.GetResourceString("SerializationInvalidBufferSize");
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000025A0 File Offset: 0x000007A0
		internal static string InvalidComparison
		{
			get
			{
				return System.SR.GetResourceString("InvalidComparison");
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000025AC File Offset: 0x000007AC
		internal static string UnsupportedFormat
		{
			get
			{
				return System.SR.GetResourceString("UnsupportedFormat");
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000025B8 File Offset: 0x000007B8
		internal static string ExpectedStartOfPropertyOrValueAfterComment
		{
			get
			{
				return System.SR.GetResourceString("ExpectedStartOfPropertyOrValueAfterComment");
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000025C4 File Offset: 0x000007C4
		internal static string TrailingCommaNotAllowedBeforeArrayEnd
		{
			get
			{
				return System.SR.GetResourceString("TrailingCommaNotAllowedBeforeArrayEnd");
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000025D0 File Offset: 0x000007D0
		internal static string TrailingCommaNotAllowedBeforeObjectEnd
		{
			get
			{
				return System.SR.GetResourceString("TrailingCommaNotAllowedBeforeObjectEnd");
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000025DC File Offset: 0x000007DC
		internal static string SerializerOptionsReadOnly
		{
			get
			{
				return System.SR.GetResourceString("SerializerOptionsReadOnly");
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000025E8 File Offset: 0x000007E8
		internal static string SerializerOptions_InvalidChainedResolver
		{
			get
			{
				return System.SR.GetResourceString("SerializerOptions_InvalidChainedResolver");
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000025F4 File Offset: 0x000007F4
		internal static string StreamNotWritable
		{
			get
			{
				return System.SR.GetResourceString("StreamNotWritable");
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002600 File Offset: 0x00000800
		internal static string CannotWriteCommentWithEmbeddedDelimiter
		{
			get
			{
				return System.SR.GetResourceString("CannotWriteCommentWithEmbeddedDelimiter");
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000260C File Offset: 0x0000080C
		internal static string SerializerPropertyNameConflict
		{
			get
			{
				return System.SR.GetResourceString("SerializerPropertyNameConflict");
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002618 File Offset: 0x00000818
		internal static string SerializerPropertyNameNull
		{
			get
			{
				return System.SR.GetResourceString("SerializerPropertyNameNull");
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002624 File Offset: 0x00000824
		internal static string SerializationDataExtensionPropertyInvalid
		{
			get
			{
				return System.SR.GetResourceString("SerializationDataExtensionPropertyInvalid");
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002630 File Offset: 0x00000830
		internal static string PropertyTypeNotNullable
		{
			get
			{
				return System.SR.GetResourceString("PropertyTypeNotNullable");
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000263C File Offset: 0x0000083C
		internal static string SerializationDuplicateTypeAttribute
		{
			get
			{
				return System.SR.GetResourceString("SerializationDuplicateTypeAttribute");
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002648 File Offset: 0x00000848
		internal static string ExtensionDataConflictsWithUnmappedMemberHandling
		{
			get
			{
				return System.SR.GetResourceString("ExtensionDataConflictsWithUnmappedMemberHandling");
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002654 File Offset: 0x00000854
		internal static string SerializationNotSupportedType
		{
			get
			{
				return System.SR.GetResourceString("SerializationNotSupportedType");
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002660 File Offset: 0x00000860
		internal static string TypeRequiresAsyncSerialization
		{
			get
			{
				return System.SR.GetResourceString("TypeRequiresAsyncSerialization");
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000266C File Offset: 0x0000086C
		internal static string InvalidCharacterAtStartOfComment
		{
			get
			{
				return System.SR.GetResourceString("InvalidCharacterAtStartOfComment");
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002678 File Offset: 0x00000878
		internal static string UnexpectedEndOfDataWhileReadingComment
		{
			get
			{
				return System.SR.GetResourceString("UnexpectedEndOfDataWhileReadingComment");
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002684 File Offset: 0x00000884
		internal static string CannotSkip
		{
			get
			{
				return System.SR.GetResourceString("CannotSkip");
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002690 File Offset: 0x00000890
		internal static string NotEnoughData
		{
			get
			{
				return System.SR.GetResourceString("NotEnoughData");
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000269C File Offset: 0x0000089C
		internal static string UnexpectedEndOfLineSeparator
		{
			get
			{
				return System.SR.GetResourceString("UnexpectedEndOfLineSeparator");
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000026A8 File Offset: 0x000008A8
		internal static string JsonSerializerDoesNotSupportComments
		{
			get
			{
				return System.SR.GetResourceString("JsonSerializerDoesNotSupportComments");
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000026B4 File Offset: 0x000008B4
		internal static string DeserializeNoConstructor
		{
			get
			{
				return System.SR.GetResourceString("DeserializeNoConstructor");
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000026C0 File Offset: 0x000008C0
		internal static string DeserializeInterfaceOrAbstractType
		{
			get
			{
				return System.SR.GetResourceString("DeserializeInterfaceOrAbstractType");
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000026CC File Offset: 0x000008CC
		internal static string DeserializationMustSpecifyTypeDiscriminator
		{
			get
			{
				return System.SR.GetResourceString("DeserializationMustSpecifyTypeDiscriminator");
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000026D8 File Offset: 0x000008D8
		internal static string SerializationConverterOnAttributeNotCompatible
		{
			get
			{
				return System.SR.GetResourceString("SerializationConverterOnAttributeNotCompatible");
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000026E4 File Offset: 0x000008E4
		internal static string SerializationConverterOnAttributeInvalid
		{
			get
			{
				return System.SR.GetResourceString("SerializationConverterOnAttributeInvalid");
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000026F0 File Offset: 0x000008F0
		internal static string SerializationConverterRead
		{
			get
			{
				return System.SR.GetResourceString("SerializationConverterRead");
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000026FC File Offset: 0x000008FC
		internal static string SerializationConverterNotCompatible
		{
			get
			{
				return System.SR.GetResourceString("SerializationConverterNotCompatible");
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002708 File Offset: 0x00000908
		internal static string ResolverTypeNotCompatible
		{
			get
			{
				return System.SR.GetResourceString("ResolverTypeNotCompatible");
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002714 File Offset: 0x00000914
		internal static string ResolverTypeInfoOptionsNotCompatible
		{
			get
			{
				return System.SR.GetResourceString("ResolverTypeInfoOptionsNotCompatible");
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002720 File Offset: 0x00000920
		internal static string SerializationConverterWrite
		{
			get
			{
				return System.SR.GetResourceString("SerializationConverterWrite");
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000272C File Offset: 0x0000092C
		internal static string NamingPolicyReturnNull
		{
			get
			{
				return System.SR.GetResourceString("NamingPolicyReturnNull");
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002738 File Offset: 0x00000938
		internal static string SerializationDuplicateAttribute
		{
			get
			{
				return System.SR.GetResourceString("SerializationDuplicateAttribute");
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002744 File Offset: 0x00000944
		internal static string SerializeUnableToSerialize
		{
			get
			{
				return System.SR.GetResourceString("SerializeUnableToSerialize");
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002750 File Offset: 0x00000950
		internal static string FormatByte
		{
			get
			{
				return System.SR.GetResourceString("FormatByte");
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000275C File Offset: 0x0000095C
		internal static string FormatInt16
		{
			get
			{
				return System.SR.GetResourceString("FormatInt16");
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002768 File Offset: 0x00000968
		internal static string FormatSByte
		{
			get
			{
				return System.SR.GetResourceString("FormatSByte");
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002774 File Offset: 0x00000974
		internal static string FormatUInt16
		{
			get
			{
				return System.SR.GetResourceString("FormatUInt16");
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002780 File Offset: 0x00000980
		internal static string SerializerCycleDetected
		{
			get
			{
				return System.SR.GetResourceString("SerializerCycleDetected");
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000278C File Offset: 0x0000098C
		internal static string InvalidLeadingZeroInNumber
		{
			get
			{
				return System.SR.GetResourceString("InvalidLeadingZeroInNumber");
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002798 File Offset: 0x00000998
		internal static string MetadataCannotParsePreservedObjectToImmutable
		{
			get
			{
				return System.SR.GetResourceString("MetadataCannotParsePreservedObjectToImmutable");
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000027A4 File Offset: 0x000009A4
		internal static string MetadataDuplicateIdFound
		{
			get
			{
				return System.SR.GetResourceString("MetadataDuplicateIdFound");
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000027B0 File Offset: 0x000009B0
		internal static string MetadataIdCannotBeCombinedWithRef
		{
			get
			{
				return System.SR.GetResourceString("MetadataIdCannotBeCombinedWithRef");
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000027BC File Offset: 0x000009BC
		internal static string MetadataInvalidReferenceToValueType
		{
			get
			{
				return System.SR.GetResourceString("MetadataInvalidReferenceToValueType");
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000027C8 File Offset: 0x000009C8
		internal static string MetadataInvalidTokenAfterValues
		{
			get
			{
				return System.SR.GetResourceString("MetadataInvalidTokenAfterValues");
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000027D4 File Offset: 0x000009D4
		internal static string MetadataPreservedArrayFailed
		{
			get
			{
				return System.SR.GetResourceString("MetadataPreservedArrayFailed");
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000027E0 File Offset: 0x000009E0
		internal static string MetadataInvalidPropertyInArrayMetadata
		{
			get
			{
				return System.SR.GetResourceString("MetadataInvalidPropertyInArrayMetadata");
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000027EC File Offset: 0x000009EC
		internal static string MetadataStandaloneValuesProperty
		{
			get
			{
				return System.SR.GetResourceString("MetadataStandaloneValuesProperty");
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000027F8 File Offset: 0x000009F8
		internal static string MetadataReferenceCannotContainOtherProperties
		{
			get
			{
				return System.SR.GetResourceString("MetadataReferenceCannotContainOtherProperties");
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002804 File Offset: 0x00000A04
		internal static string MetadataReferenceNotFound
		{
			get
			{
				return System.SR.GetResourceString("MetadataReferenceNotFound");
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002810 File Offset: 0x00000A10
		internal static string MetadataValueWasNotString
		{
			get
			{
				return System.SR.GetResourceString("MetadataValueWasNotString");
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000281C File Offset: 0x00000A1C
		internal static string MetadataInvalidPropertyWithLeadingDollarSign
		{
			get
			{
				return System.SR.GetResourceString("MetadataInvalidPropertyWithLeadingDollarSign");
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002828 File Offset: 0x00000A28
		internal static string MetadataUnexpectedProperty
		{
			get
			{
				return System.SR.GetResourceString("MetadataUnexpectedProperty");
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002834 File Offset: 0x00000A34
		internal static string UnmappedJsonProperty
		{
			get
			{
				return System.SR.GetResourceString("UnmappedJsonProperty");
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002840 File Offset: 0x00000A40
		internal static string DuplicateMetadataProperty
		{
			get
			{
				return System.SR.GetResourceString("DuplicateMetadataProperty");
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000284C File Offset: 0x00000A4C
		internal static string MultipleMembersBindWithConstructorParameter
		{
			get
			{
				return System.SR.GetResourceString("MultipleMembersBindWithConstructorParameter");
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002858 File Offset: 0x00000A58
		internal static string ConstructorParamIncompleteBinding
		{
			get
			{
				return System.SR.GetResourceString("ConstructorParamIncompleteBinding");
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002864 File Offset: 0x00000A64
		internal static string ObjectWithParameterizedCtorRefMetadataNotSupported
		{
			get
			{
				return System.SR.GetResourceString("ObjectWithParameterizedCtorRefMetadataNotSupported");
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002870 File Offset: 0x00000A70
		internal static string SerializerConverterFactoryReturnsNull
		{
			get
			{
				return System.SR.GetResourceString("SerializerConverterFactoryReturnsNull");
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000287C File Offset: 0x00000A7C
		internal static string SerializationNotSupportedParentType
		{
			get
			{
				return System.SR.GetResourceString("SerializationNotSupportedParentType");
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002888 File Offset: 0x00000A88
		internal static string ExtensionDataCannotBindToCtorParam
		{
			get
			{
				return System.SR.GetResourceString("ExtensionDataCannotBindToCtorParam");
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002894 File Offset: 0x00000A94
		internal static string BufferMaximumSizeExceeded
		{
			get
			{
				return System.SR.GetResourceString("BufferMaximumSizeExceeded");
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000028A0 File Offset: 0x00000AA0
		internal static string CannotSerializeInvalidType
		{
			get
			{
				return System.SR.GetResourceString("CannotSerializeInvalidType");
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000028AC File Offset: 0x00000AAC
		internal static string SerializeTypeInstanceNotSupported
		{
			get
			{
				return System.SR.GetResourceString("SerializeTypeInstanceNotSupported");
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000028B8 File Offset: 0x00000AB8
		internal static string JsonIncludeOnInaccessibleProperty
		{
			get
			{
				return System.SR.GetResourceString("JsonIncludeOnInaccessibleProperty");
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000028C4 File Offset: 0x00000AC4
		internal static string CannotSerializeInvalidMember
		{
			get
			{
				return System.SR.GetResourceString("CannotSerializeInvalidMember");
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000028D0 File Offset: 0x00000AD0
		internal static string CannotPopulateCollection
		{
			get
			{
				return System.SR.GetResourceString("CannotPopulateCollection");
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000028DC File Offset: 0x00000ADC
		internal static string ConstructorContainsNullParameterNames
		{
			get
			{
				return System.SR.GetResourceString("ConstructorContainsNullParameterNames");
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000028E8 File Offset: 0x00000AE8
		internal static string DefaultIgnoreConditionAlreadySpecified
		{
			get
			{
				return System.SR.GetResourceString("DefaultIgnoreConditionAlreadySpecified");
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000028F4 File Offset: 0x00000AF4
		internal static string DefaultIgnoreConditionInvalid
		{
			get
			{
				return System.SR.GetResourceString("DefaultIgnoreConditionInvalid");
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002900 File Offset: 0x00000B00
		internal static string DictionaryKeyTypeNotSupported
		{
			get
			{
				return System.SR.GetResourceString("DictionaryKeyTypeNotSupported");
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000290C File Offset: 0x00000B0C
		internal static string IgnoreConditionOnValueTypeInvalid
		{
			get
			{
				return System.SR.GetResourceString("IgnoreConditionOnValueTypeInvalid");
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002918 File Offset: 0x00000B18
		internal static string NumberHandlingOnPropertyInvalid
		{
			get
			{
				return System.SR.GetResourceString("NumberHandlingOnPropertyInvalid");
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002924 File Offset: 0x00000B24
		internal static string ConverterCanConvertMultipleTypes
		{
			get
			{
				return System.SR.GetResourceString("ConverterCanConvertMultipleTypes");
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002930 File Offset: 0x00000B30
		internal static string MetadataReferenceOfTypeCannotBeAssignedToType
		{
			get
			{
				return System.SR.GetResourceString("MetadataReferenceOfTypeCannotBeAssignedToType");
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000293C File Offset: 0x00000B3C
		internal static string DeserializeUnableToAssignValue
		{
			get
			{
				return System.SR.GetResourceString("DeserializeUnableToAssignValue");
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002948 File Offset: 0x00000B48
		internal static string DeserializeUnableToAssignNull
		{
			get
			{
				return System.SR.GetResourceString("DeserializeUnableToAssignNull");
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002954 File Offset: 0x00000B54
		internal static string SerializerConverterFactoryReturnsJsonConverterFactory
		{
			get
			{
				return System.SR.GetResourceString("SerializerConverterFactoryReturnsJsonConverterFactory");
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002960 File Offset: 0x00000B60
		internal static string SerializerConverterFactoryInvalidArgument
		{
			get
			{
				return System.SR.GetResourceString("SerializerConverterFactoryInvalidArgument");
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000296C File Offset: 0x00000B6C
		internal static string NodeElementWrongType
		{
			get
			{
				return System.SR.GetResourceString("NodeElementWrongType");
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002978 File Offset: 0x00000B78
		internal static string NodeElementCannotBeObjectOrArray
		{
			get
			{
				return System.SR.GetResourceString("NodeElementCannotBeObjectOrArray");
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002984 File Offset: 0x00000B84
		internal static string NodeAlreadyHasParent
		{
			get
			{
				return System.SR.GetResourceString("NodeAlreadyHasParent");
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002990 File Offset: 0x00000B90
		internal static string NodeCycleDetected
		{
			get
			{
				return System.SR.GetResourceString("NodeCycleDetected");
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000299C File Offset: 0x00000B9C
		internal static string NodeUnableToConvert
		{
			get
			{
				return System.SR.GetResourceString("NodeUnableToConvert");
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000029A8 File Offset: 0x00000BA8
		internal static string NodeUnableToConvertElement
		{
			get
			{
				return System.SR.GetResourceString("NodeUnableToConvertElement");
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000029B4 File Offset: 0x00000BB4
		internal static string NodeValueNotAllowed
		{
			get
			{
				return System.SR.GetResourceString("NodeValueNotAllowed");
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000029C0 File Offset: 0x00000BC0
		internal static string NodeWrongType
		{
			get
			{
				return System.SR.GetResourceString("NodeWrongType");
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000029CC File Offset: 0x00000BCC
		internal static string NodeParentWrongType
		{
			get
			{
				return System.SR.GetResourceString("NodeParentWrongType");
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000029D8 File Offset: 0x00000BD8
		internal static string SerializerContextOptionsReadOnly
		{
			get
			{
				return System.SR.GetResourceString("SerializerContextOptionsReadOnly");
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000029E4 File Offset: 0x00000BE4
		internal static string NoMetadataForType
		{
			get
			{
				return System.SR.GetResourceString("NoMetadataForType");
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000029F0 File Offset: 0x00000BF0
		internal static string AmbiguousMetadataForType
		{
			get
			{
				return System.SR.GetResourceString("AmbiguousMetadataForType");
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000029FC File Offset: 0x00000BFC
		internal static string NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty
		{
			get
			{
				return System.SR.GetResourceString("NodeJsonObjectCustomConverterNotAllowedOnExtensionProperty");
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002A08 File Offset: 0x00000C08
		internal static string NoMetadataForTypeProperties
		{
			get
			{
				return System.SR.GetResourceString("NoMetadataForTypeProperties");
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002A14 File Offset: 0x00000C14
		internal static string FieldCannotBeVirtual
		{
			get
			{
				return System.SR.GetResourceString("FieldCannotBeVirtual");
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002A20 File Offset: 0x00000C20
		internal static string MissingFSharpCoreMember
		{
			get
			{
				return System.SR.GetResourceString("MissingFSharpCoreMember");
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002A2C File Offset: 0x00000C2C
		internal static string FSharpDiscriminatedUnionsNotSupported
		{
			get
			{
				return System.SR.GetResourceString("FSharpDiscriminatedUnionsNotSupported");
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002A38 File Offset: 0x00000C38
		internal static string Polymorphism_DerivedConverterDoesNotSupportMetadata
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_DerivedConverterDoesNotSupportMetadata");
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002A44 File Offset: 0x00000C44
		internal static string Polymorphism_TypeDoesNotSupportPolymorphism
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_TypeDoesNotSupportPolymorphism");
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002A50 File Offset: 0x00000C50
		internal static string Polymorphism_DerivedTypeIsNotSupported
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_DerivedTypeIsNotSupported");
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002A5C File Offset: 0x00000C5C
		internal static string Polymorphism_DerivedTypeIsAlreadySpecified
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_DerivedTypeIsAlreadySpecified");
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002A68 File Offset: 0x00000C68
		internal static string Polymorphism_TypeDicriminatorIdIsAlreadySpecified
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_TypeDicriminatorIdIsAlreadySpecified");
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002A74 File Offset: 0x00000C74
		internal static string Polymorphism_InvalidCustomTypeDiscriminatorPropertyName
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_InvalidCustomTypeDiscriminatorPropertyName");
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002A80 File Offset: 0x00000C80
		internal static string Polymorphism_ConfigurationDoesNotSpecifyDerivedTypes
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_ConfigurationDoesNotSpecifyDerivedTypes");
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002A8C File Offset: 0x00000C8C
		internal static string Polymorphism_UnrecognizedTypeDiscriminator
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_UnrecognizedTypeDiscriminator");
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002A98 File Offset: 0x00000C98
		internal static string Polymorphism_RuntimeTypeNotSupported
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_RuntimeTypeNotSupported");
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002AA4 File Offset: 0x00000CA4
		internal static string Polymorphism_RuntimeTypeDiamondAmbiguity
		{
			get
			{
				return System.SR.GetResourceString("Polymorphism_RuntimeTypeDiamondAmbiguity");
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002AB0 File Offset: 0x00000CB0
		internal static string InvalidJsonTypeInfoOperationForKind
		{
			get
			{
				return System.SR.GetResourceString("InvalidJsonTypeInfoOperationForKind");
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002ABC File Offset: 0x00000CBC
		internal static string OnDeserializingCallbacksNotSupported
		{
			get
			{
				return System.SR.GetResourceString("OnDeserializingCallbacksNotSupported");
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002AC8 File Offset: 0x00000CC8
		internal static string CreateObjectConverterNotCompatible
		{
			get
			{
				return System.SR.GetResourceString("CreateObjectConverterNotCompatible");
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002AD4 File Offset: 0x00000CD4
		internal static string JsonPropertyInfoBoundToDifferentParent
		{
			get
			{
				return System.SR.GetResourceString("JsonPropertyInfoBoundToDifferentParent");
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002AE0 File Offset: 0x00000CE0
		internal static string JsonSerializerOptionsNoTypeInfoResolverSpecified
		{
			get
			{
				return System.SR.GetResourceString("JsonSerializerOptionsNoTypeInfoResolverSpecified");
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002AEC File Offset: 0x00000CEC
		internal static string JsonSerializerIsReflectionDisabled
		{
			get
			{
				return System.SR.GetResourceString("JsonSerializerIsReflectionDisabled");
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002AF8 File Offset: 0x00000CF8
		internal static string JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo
		{
			get
			{
				return System.SR.GetResourceString("JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo");
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002B04 File Offset: 0x00000D04
		internal static string JsonPropertyRequiredAndNotDeserializable
		{
			get
			{
				return System.SR.GetResourceString("JsonPropertyRequiredAndNotDeserializable");
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002B10 File Offset: 0x00000D10
		internal static string JsonPropertyRequiredAndExtensionData
		{
			get
			{
				return System.SR.GetResourceString("JsonPropertyRequiredAndExtensionData");
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002B1C File Offset: 0x00000D1C
		internal static string JsonRequiredPropertiesMissing
		{
			get
			{
				return System.SR.GetResourceString("JsonRequiredPropertiesMissing");
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002B28 File Offset: 0x00000D28
		internal static string ObjectCreationHandlingPopulateNotSupportedByConverter
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPopulateNotSupportedByConverter");
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002B34 File Offset: 0x00000D34
		internal static string ObjectCreationHandlingPropertyMustHaveAGetter
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPropertyMustHaveAGetter");
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002B40 File Offset: 0x00000D40
		internal static string ObjectCreationHandlingPropertyValueTypeMustHaveASetter
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPropertyValueTypeMustHaveASetter");
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002B4C File Offset: 0x00000D4C
		internal static string ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization");
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002B58 File Offset: 0x00000D58
		internal static string ObjectCreationHandlingPropertyCannotAllowReadOnlyMember
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPropertyCannotAllowReadOnlyMember");
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002B64 File Offset: 0x00000D64
		internal static string ObjectCreationHandlingPropertyCannotAllowReferenceHandling
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPropertyCannotAllowReferenceHandling");
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002B70 File Offset: 0x00000D70
		internal static string ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors
		{
			get
			{
				return System.SR.GetResourceString("ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors");
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002B7C File Offset: 0x00000D7C
		internal static string FormatInt128
		{
			get
			{
				return System.SR.GetResourceString("FormatInt128");
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00002B88 File Offset: 0x00000D88
		internal static string FormatUInt128
		{
			get
			{
				return System.SR.GetResourceString("FormatUInt128");
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002B94 File Offset: 0x00000D94
		internal static string FormatHalf
		{
			get
			{
				return System.SR.GetResourceString("FormatHalf");
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002BA0 File Offset: 0x00000DA0
		internal static string InvalidIndentCharacter
		{
			get
			{
				return System.SR.GetResourceString("InvalidIndentCharacter");
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002BAC File Offset: 0x00000DAC
		internal static string InvalidIndentSize
		{
			get
			{
				return System.SR.GetResourceString("InvalidIndentSize");
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002BB8 File Offset: 0x00000DB8
		internal static string PipeWriterCanceled
		{
			get
			{
				return System.SR.GetResourceString("PipeWriterCanceled");
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002BC4 File Offset: 0x00000DC4
		internal static string PipeWriter_DoesNotImplementUnflushedBytes
		{
			get
			{
				return System.SR.GetResourceString("PipeWriter_DoesNotImplementUnflushedBytes");
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002BD0 File Offset: 0x00000DD0
		internal static string InvalidNewLine
		{
			get
			{
				return System.SR.GetResourceString("InvalidNewLine");
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002BDC File Offset: 0x00000DDC
		internal static string PropertyGetterDisallowNull
		{
			get
			{
				return System.SR.GetResourceString("PropertyGetterDisallowNull");
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002BE8 File Offset: 0x00000DE8
		internal static string PropertySetterDisallowNull
		{
			get
			{
				return System.SR.GetResourceString("PropertySetterDisallowNull");
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002BF4 File Offset: 0x00000DF4
		internal static string ConstructorParameterDisallowNull
		{
			get
			{
				return System.SR.GetResourceString("ConstructorParameterDisallowNull");
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002C00 File Offset: 0x00000E00
		internal static string JsonSchemaExporter_ReferenceHandlerPreserve_NotSupported
		{
			get
			{
				return System.SR.GetResourceString("JsonSchemaExporter_ReferenceHandlerPreserve_NotSupported");
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002C0C File Offset: 0x00000E0C
		internal static string JsonSchemaExporter_DepthTooLarge
		{
			get
			{
				return System.SR.GetResourceString("JsonSchemaExporter_DepthTooLarge");
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly bool s_usingResourceKeys = true;

		// Token: 0x04000002 RID: 2
		private static ResourceManager s_resourceManager;
	}
}
