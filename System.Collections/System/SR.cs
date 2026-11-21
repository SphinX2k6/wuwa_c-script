using System;
using System.Resources;
using FxResources.System.Collections;

namespace System
{
	// Token: 0x02000003 RID: 3
	internal static class SR
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal static bool UsingResourceKeys()
		{
			return System.SR.s_usingResourceKeys;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
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

		// Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
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

		// Token: 0x06000004 RID: 4 RVA: 0x000020E0 File Offset: 0x000002E0
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

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002135 File Offset: 0x00000335
		internal static ResourceManager ResourceManager
		{
			get
			{
				ResourceManager result;
				if ((result = System.SR.s_resourceManager) == null)
				{
					result = (System.SR.s_resourceManager = new ResourceManager(typeof(FxResources.System.Collections.SR)));
				}
				return result;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002155 File Offset: 0x00000355
		internal static string Arg_NonZeroLowerBound
		{
			get
			{
				return System.SR.GetResourceString("Arg_NonZeroLowerBound");
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002161 File Offset: 0x00000361
		internal static string Arg_WrongType
		{
			get
			{
				return System.SR.GetResourceString("Arg_WrongType");
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000216D File Offset: 0x0000036D
		internal static string Arg_ArrayPlusOffTooSmall
		{
			get
			{
				return System.SR.GetResourceString("Arg_ArrayPlusOffTooSmall");
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002179 File Offset: 0x00000379
		internal static string ArgumentOutOfRange_SmallCapacity
		{
			get
			{
				return System.SR.GetResourceString("ArgumentOutOfRange_SmallCapacity");
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002185 File Offset: 0x00000385
		internal static string Argument_InvalidOffLen
		{
			get
			{
				return System.SR.GetResourceString("Argument_InvalidOffLen");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002191 File Offset: 0x00000391
		internal static string Argument_AddingDuplicate
		{
			get
			{
				return System.SR.GetResourceString("Argument_AddingDuplicate");
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000219D File Offset: 0x0000039D
		internal static string InvalidOperation_ConcurrentOperationsNotSupported
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_ConcurrentOperationsNotSupported");
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000021A9 File Offset: 0x000003A9
		internal static string InvalidOperation_EmptyQueue
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_EmptyQueue");
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000021B5 File Offset: 0x000003B5
		internal static string InvalidOperation_EnumOpCantHappen
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_EnumOpCantHappen");
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021C1 File Offset: 0x000003C1
		internal static string InvalidOperation_EnumFailedVersion
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_EnumFailedVersion");
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021CD File Offset: 0x000003CD
		internal static string InvalidOperation_EmptyStack
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_EmptyStack");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000021D9 File Offset: 0x000003D9
		internal static string InvalidOperation_EnumNotStarted
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_EnumNotStarted");
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021E5 File Offset: 0x000003E5
		internal static string InvalidOperation_EnumEnded
		{
			get
			{
				return System.SR.GetResourceString("InvalidOperation_EnumEnded");
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000021F1 File Offset: 0x000003F1
		internal static string NotSupported_KeyCollectionSet
		{
			get
			{
				return System.SR.GetResourceString("NotSupported_KeyCollectionSet");
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021FD File Offset: 0x000003FD
		internal static string NotSupported_ValueCollectionSet
		{
			get
			{
				return System.SR.GetResourceString("NotSupported_ValueCollectionSet");
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002209 File Offset: 0x00000409
		internal static string Arg_ArrayLengthsDiffer
		{
			get
			{
				return System.SR.GetResourceString("Arg_ArrayLengthsDiffer");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002215 File Offset: 0x00000415
		internal static string Arg_BitArrayTypeUnsupported
		{
			get
			{
				return System.SR.GetResourceString("Arg_BitArrayTypeUnsupported");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002221 File Offset: 0x00000421
		internal static string Arg_HTCapacityOverflow
		{
			get
			{
				return System.SR.GetResourceString("Arg_HTCapacityOverflow");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000222D File Offset: 0x0000042D
		internal static string Arg_InsufficientSpace
		{
			get
			{
				return System.SR.GetResourceString("Arg_InsufficientSpace");
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002239 File Offset: 0x00000439
		internal static string Arg_RankMultiDimNotSupported
		{
			get
			{
				return System.SR.GetResourceString("Arg_RankMultiDimNotSupported");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002245 File Offset: 0x00000445
		internal static string Argument_ArrayTooLarge
		{
			get
			{
				return System.SR.GetResourceString("Argument_ArrayTooLarge");
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002251 File Offset: 0x00000451
		internal static string Argument_IncompatibleArrayType
		{
			get
			{
				return System.SR.GetResourceString("Argument_IncompatibleArrayType");
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000225D File Offset: 0x0000045D
		internal static string ArgumentOutOfRange_BiggerThanCollection
		{
			get
			{
				return System.SR.GetResourceString("ArgumentOutOfRange_BiggerThanCollection");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002269 File Offset: 0x00000469
		internal static string ArgumentOutOfRange_IndexMustBeLess
		{
			get
			{
				return System.SR.GetResourceString("ArgumentOutOfRange_IndexMustBeLess");
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002275 File Offset: 0x00000475
		internal static string ArgumentOutOfRange_IndexMustBeLessOrEqual
		{
			get
			{
				return System.SR.GetResourceString("ArgumentOutOfRange_IndexMustBeLessOrEqual");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002281 File Offset: 0x00000481
		internal static string ExternalLinkedListNode
		{
			get
			{
				return System.SR.GetResourceString("ExternalLinkedListNode");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000228D File Offset: 0x0000048D
		internal static string LinkedListEmpty
		{
			get
			{
				return System.SR.GetResourceString("LinkedListEmpty");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002299 File Offset: 0x00000499
		internal static string LinkedListNodeIsAttached
		{
			get
			{
				return System.SR.GetResourceString("LinkedListNodeIsAttached");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000022A5 File Offset: 0x000004A5
		internal static string NotSupported_SortedListNestedWrite
		{
			get
			{
				return System.SR.GetResourceString("NotSupported_SortedListNestedWrite");
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000022B1 File Offset: 0x000004B1
		internal static string SortedSet_LowerValueGreaterThanUpperValue
		{
			get
			{
				return System.SR.GetResourceString("SortedSet_LowerValueGreaterThanUpperValue");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000022BD File Offset: 0x000004BD
		internal static string Serialization_InvalidOnDeser
		{
			get
			{
				return System.SR.GetResourceString("Serialization_InvalidOnDeser");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000022C9 File Offset: 0x000004C9
		internal static string Serialization_MismatchedCount
		{
			get
			{
				return System.SR.GetResourceString("Serialization_MismatchedCount");
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000022D5 File Offset: 0x000004D5
		internal static string Serialization_MissingValues
		{
			get
			{
				return System.SR.GetResourceString("Serialization_MissingValues");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000022E1 File Offset: 0x000004E1
		internal static string Arg_KeyNotFoundWithKey
		{
			get
			{
				return System.SR.GetResourceString("Arg_KeyNotFoundWithKey");
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly bool s_usingResourceKeys = true;

		// Token: 0x04000002 RID: 2
		private static ResourceManager s_resourceManager;
	}
}
