using System;
using System.Collections.Generic;
using System.IO;
using System.Private.CoreLib;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x020001B2 RID: 434
	internal static class SR
	{
		// Token: 0x06001CFF RID: 7423 RVA: 0x000625CC File Offset: 0x000607CC
		private static string InternalGetResourceString(string key)
		{
			if (key.Length == 0)
			{
				return key;
			}
			bool flag = false;
			string result;
			try
			{
				Monitor.Enter(SR._lock, ref flag);
				if (SR._currentlyLoading != null && SR._currentlyLoading.Count > 0 && SR._currentlyLoading.LastIndexOf(key) >= 0)
				{
					if (SR._infinitelyRecursingCount > 0)
					{
						return key;
					}
					SR._infinitelyRecursingCount++;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(197, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Encountered infinite recursion while looking up resource '");
					defaultInterpolatedStringHandler.AppendFormatted(key);
					defaultInterpolatedStringHandler.AppendLiteral("' in ");
					defaultInterpolatedStringHandler.AppendFormatted("System.Private.CoreLib");
					defaultInterpolatedStringHandler.AppendLiteral(". Verify the installation of .NET is complete and does not need repairing, and that the state of the process has not become corrupted.");
					Environment.FailFast(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				if (SR._currentlyLoading == null)
				{
					SR._currentlyLoading = new List<string>();
				}
				if (!SR._resourceManagerInited)
				{
					RuntimeHelpers.RunClassConstructor(typeof(ResourceManager).TypeHandle);
					RuntimeHelpers.RunClassConstructor(typeof(ResourceReader).TypeHandle);
					RuntimeHelpers.RunClassConstructor(typeof(RuntimeResourceSet).TypeHandle);
					RuntimeHelpers.RunClassConstructor(typeof(BinaryReader).TypeHandle);
					SR._resourceManagerInited = true;
				}
				SR._currentlyLoading.Add(key);
				string @string = SR.ResourceManager.GetString(key, null);
				SR._currentlyLoading.RemoveAt(SR._currentlyLoading.Count - 1);
				result = (@string ?? key);
			}
			catch
			{
				if (flag)
				{
					SR.s_resourceManager = null;
					SR._currentlyLoading = null;
				}
				throw;
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(SR._lock);
				}
			}
			return result;
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0006277C File Offset: 0x0006097C
		internal static bool UsingResourceKeys()
		{
			return SR.s_usingResourceKeys;
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00062784 File Offset: 0x00060984
		private static string GetResourceString(string resourceKey)
		{
			if (SR.UsingResourceKeys())
			{
				return resourceKey;
			}
			string result = null;
			try
			{
				result = SR.InternalGetResourceString(resourceKey);
			}
			catch (MissingManifestResourceException)
			{
			}
			return result;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000627BC File Offset: 0x000609BC
		internal unsafe static string Format(string resourceFormat, object p1)
		{
			if (SR.UsingResourceKeys())
			{
				string separator = ", ";
				<>y__InlineArray2<object> <>y__InlineArray = default(<>y__InlineArray2<object>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<object>, object>(ref <>y__InlineArray, 0) = resourceFormat;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<object>, object>(ref <>y__InlineArray, 1) = p1;
				return string.Join(separator, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<object>, object>(<>y__InlineArray, 2));
			}
			return string.Format(resourceFormat, p1);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00062808 File Offset: 0x00060A08
		internal unsafe static string Format(string resourceFormat, object p1, object p2)
		{
			if (SR.UsingResourceKeys())
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

		// Token: 0x06001D04 RID: 7428 RVA: 0x00062860 File Offset: 0x00060A60
		internal unsafe static string Format(string resourceFormat, object p1, object p2, object p3)
		{
			if (SR.UsingResourceKeys())
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

		// Token: 0x06001D05 RID: 7429 RVA: 0x000628C0 File Offset: 0x00060AC0
		internal static string Format(string resourceFormat, params object[] args)
		{
			if (args == null)
			{
				return resourceFormat;
			}
			if (SR.UsingResourceKeys())
			{
				return resourceFormat + ", " + string.Join(", ", args);
			}
			return string.Format(resourceFormat, args);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000628EC File Offset: 0x00060AEC
		internal unsafe static string Format(IFormatProvider provider, string resourceFormat, object p1)
		{
			if (SR.UsingResourceKeys())
			{
				string separator = ", ";
				<>y__InlineArray2<object> <>y__InlineArray = default(<>y__InlineArray2<object>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<object>, object>(ref <>y__InlineArray, 0) = resourceFormat;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<object>, object>(ref <>y__InlineArray, 1) = p1;
				return string.Join(separator, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<object>, object>(<>y__InlineArray, 2));
			}
			return string.Format(provider, resourceFormat, p1);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00062938 File Offset: 0x00060B38
		internal unsafe static string Format(IFormatProvider provider, string resourceFormat, object p1, object p2)
		{
			if (SR.UsingResourceKeys())
			{
				string separator = ", ";
				<>y__InlineArray3<object> <>y__InlineArray = default(<>y__InlineArray3<object>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<object>, object>(ref <>y__InlineArray, 0) = resourceFormat;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<object>, object>(ref <>y__InlineArray, 1) = p1;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<object>, object>(ref <>y__InlineArray, 2) = p2;
				return string.Join(separator, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<object>, object>(<>y__InlineArray, 3));
			}
			return string.Format(provider, resourceFormat, p1, p2);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0006298E File Offset: 0x00060B8E
		internal static ResourceManager ResourceManager
		{
			get
			{
				ResourceManager result;
				if ((result = SR.s_resourceManager) == null)
				{
					result = (SR.s_resourceManager = new ResourceManager(typeof(Strings)));
				}
				return result;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x000629AE File Offset: 0x00060BAE
		internal static string Acc_CreateAbstEx
		{
			get
			{
				return SR.GetResourceString("Acc_CreateAbstEx");
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x000629BA File Offset: 0x00060BBA
		internal static string Acc_CreateArgIterator
		{
			get
			{
				return SR.GetResourceString("Acc_CreateArgIterator");
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x000629C6 File Offset: 0x00060BC6
		internal static string Acc_CreateGenericEx
		{
			get
			{
				return SR.GetResourceString("Acc_CreateGenericEx");
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000629D2 File Offset: 0x00060BD2
		internal static string Acc_CreateInterfaceEx
		{
			get
			{
				return SR.GetResourceString("Acc_CreateInterfaceEx");
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000629DE File Offset: 0x00060BDE
		internal static string Acc_CreateVoid
		{
			get
			{
				return SR.GetResourceString("Acc_CreateVoid");
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000629EA File Offset: 0x00060BEA
		internal static string Acc_NotClassInit
		{
			get
			{
				return SR.GetResourceString("Acc_NotClassInit");
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000629F6 File Offset: 0x00060BF6
		internal static string Acc_ReadOnly
		{
			get
			{
				return SR.GetResourceString("Acc_ReadOnly");
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00062A02 File Offset: 0x00060C02
		internal static string Access_Void
		{
			get
			{
				return SR.GetResourceString("Access_Void");
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00062A0E File Offset: 0x00060C0E
		internal static string AggregateException_ctor_DefaultMessage
		{
			get
			{
				return SR.GetResourceString("AggregateException_ctor_DefaultMessage");
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00062A1A File Offset: 0x00060C1A
		internal static string AggregateException_ctor_InnerExceptionNull
		{
			get
			{
				return SR.GetResourceString("AggregateException_ctor_InnerExceptionNull");
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00062A26 File Offset: 0x00060C26
		internal static string AggregateException_DeserializationFailure
		{
			get
			{
				return SR.GetResourceString("AggregateException_DeserializationFailure");
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00062A32 File Offset: 0x00060C32
		internal static string AggregateException_InnerException
		{
			get
			{
				return SR.GetResourceString("AggregateException_InnerException");
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00062A3E File Offset: 0x00060C3E
		internal static string AppDomain_Name
		{
			get
			{
				return SR.GetResourceString("AppDomain_Name");
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00062A4A File Offset: 0x00060C4A
		internal static string AppDomain_NoContextPolicies
		{
			get
			{
				return SR.GetResourceString("AppDomain_NoContextPolicies");
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00062A56 File Offset: 0x00060C56
		internal static string AppDomain_Policy_PrincipalTwice
		{
			get
			{
				return SR.GetResourceString("AppDomain_Policy_PrincipalTwice");
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00062A62 File Offset: 0x00060C62
		internal static string Arg_AccessException
		{
			get
			{
				return SR.GetResourceString("Arg_AccessException");
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00062A6E File Offset: 0x00060C6E
		internal static string Arg_AccessViolationException
		{
			get
			{
				return SR.GetResourceString("Arg_AccessViolationException");
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00062A7A File Offset: 0x00060C7A
		internal static string Arg_AmbiguousImplementationException_NoMessage
		{
			get
			{
				return SR.GetResourceString("Arg_AmbiguousImplementationException_NoMessage");
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00062A86 File Offset: 0x00060C86
		internal static string Arg_AmbiguousMatchException_Attribute
		{
			get
			{
				return SR.GetResourceString("Arg_AmbiguousMatchException_Attribute");
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00062A92 File Offset: 0x00060C92
		internal static string Arg_AmbiguousMatchException_NoMessage
		{
			get
			{
				return SR.GetResourceString("Arg_AmbiguousMatchException_NoMessage");
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00062A9E File Offset: 0x00060C9E
		internal static string Arg_AmbiguousMatchException_MemberInfo
		{
			get
			{
				return SR.GetResourceString("Arg_AmbiguousMatchException_MemberInfo");
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00062AAA File Offset: 0x00060CAA
		internal static string Arg_ApplicationException
		{
			get
			{
				return SR.GetResourceString("Arg_ApplicationException");
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00062AB6 File Offset: 0x00060CB6
		internal static string Arg_ArgumentException
		{
			get
			{
				return SR.GetResourceString("Arg_ArgumentException");
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00062AC2 File Offset: 0x00060CC2
		internal static string Arg_ArgumentOutOfRangeException
		{
			get
			{
				return SR.GetResourceString("Arg_ArgumentOutOfRangeException");
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00062ACE File Offset: 0x00060CCE
		internal static string Arg_ArithmeticException
		{
			get
			{
				return SR.GetResourceString("Arg_ArithmeticException");
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00062ADA File Offset: 0x00060CDA
		internal static string Arg_ArrayLengthsDiffer
		{
			get
			{
				return SR.GetResourceString("Arg_ArrayLengthsDiffer");
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00062AE6 File Offset: 0x00060CE6
		internal static string Arg_ArrayPlusOffTooSmall
		{
			get
			{
				return SR.GetResourceString("Arg_ArrayPlusOffTooSmall");
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00062AF2 File Offset: 0x00060CF2
		internal static string Arg_ByteArrayTooSmallForValue
		{
			get
			{
				return SR.GetResourceString("Arg_ByteArrayTooSmallForValue");
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00062AFE File Offset: 0x00060CFE
		internal static string Arg_ArrayTypeMismatchException
		{
			get
			{
				return SR.GetResourceString("Arg_ArrayTypeMismatchException");
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00062B0A File Offset: 0x00060D0A
		internal static string Arg_ArrayZeroError
		{
			get
			{
				return SR.GetResourceString("Arg_ArrayZeroError");
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00062B16 File Offset: 0x00060D16
		internal static string Arg_BadDecimal
		{
			get
			{
				return SR.GetResourceString("Arg_BadDecimal");
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00062B22 File Offset: 0x00060D22
		internal static string Arg_BadImageFormatException
		{
			get
			{
				return SR.GetResourceString("Arg_BadImageFormatException");
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00062B2E File Offset: 0x00060D2E
		internal static string Arg_BogusIComparer
		{
			get
			{
				return SR.GetResourceString("Arg_BogusIComparer");
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00062B3A File Offset: 0x00060D3A
		internal static string InvalidOperation_IncompatibleComparer
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_IncompatibleComparer");
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00062B46 File Offset: 0x00060D46
		internal static string Arg_BufferTooSmall
		{
			get
			{
				return SR.GetResourceString("Arg_BufferTooSmall");
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00062B52 File Offset: 0x00060D52
		internal static string Arg_CannotBeNaN
		{
			get
			{
				return SR.GetResourceString("Arg_CannotBeNaN");
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00062B5E File Offset: 0x00060D5E
		internal static string Arg_CannotHaveNegativeValue
		{
			get
			{
				return SR.GetResourceString("Arg_CannotHaveNegativeValue");
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00062B6A File Offset: 0x00060D6A
		internal static string Arg_CannotMixComparisonInfrastructure
		{
			get
			{
				return SR.GetResourceString("Arg_CannotMixComparisonInfrastructure");
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00062B76 File Offset: 0x00060D76
		internal static string Arg_CannotUnloadAppDomainException
		{
			get
			{
				return SR.GetResourceString("Arg_CannotUnloadAppDomainException");
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00062B82 File Offset: 0x00060D82
		internal static string Arg_COMException
		{
			get
			{
				return SR.GetResourceString("Arg_COMException");
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00062B8E File Offset: 0x00060D8E
		internal static string Arg_CreatInstAccess
		{
			get
			{
				return SR.GetResourceString("Arg_CreatInstAccess");
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x00062B9A File Offset: 0x00060D9A
		internal static string Arg_CryptographyException
		{
			get
			{
				return SR.GetResourceString("Arg_CryptographyException");
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00062BA6 File Offset: 0x00060DA6
		internal static string Arg_CustomAttributeFormatException
		{
			get
			{
				return SR.GetResourceString("Arg_CustomAttributeFormatException");
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001D34 RID: 7476 RVA: 0x00062BB2 File Offset: 0x00060DB2
		internal static string Arg_DataMisalignedException
		{
			get
			{
				return SR.GetResourceString("Arg_DataMisalignedException");
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00062BBE File Offset: 0x00060DBE
		internal static string Arg_DecBitCtor
		{
			get
			{
				return SR.GetResourceString("Arg_DecBitCtor");
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00062BCA File Offset: 0x00060DCA
		internal static string Arg_DirectoryNotFoundException
		{
			get
			{
				return SR.GetResourceString("Arg_DirectoryNotFoundException");
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00062BD6 File Offset: 0x00060DD6
		internal static string Arg_DivideByZero
		{
			get
			{
				return SR.GetResourceString("Arg_DivideByZero");
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00062BE2 File Offset: 0x00060DE2
		internal static string Arg_DlgtTargMeth
		{
			get
			{
				return SR.GetResourceString("Arg_DlgtTargMeth");
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00062BEE File Offset: 0x00060DEE
		internal static string Arg_DlgtTypeMis
		{
			get
			{
				return SR.GetResourceString("Arg_DlgtTypeMis");
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00062BFA File Offset: 0x00060DFA
		internal static string Arg_DllNotFoundException
		{
			get
			{
				return SR.GetResourceString("Arg_DllNotFoundException");
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00062C06 File Offset: 0x00060E06
		internal static string Arg_DllNameCannotBeEmpty
		{
			get
			{
				return SR.GetResourceString("Arg_DllNameCannotBeEmpty");
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00062C12 File Offset: 0x00060E12
		internal static string Arg_DuplicateWaitObjectException
		{
			get
			{
				return SR.GetResourceString("Arg_DuplicateWaitObjectException");
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00062C1E File Offset: 0x00060E1E
		internal static string Arg_EHClauseNotFilter
		{
			get
			{
				return SR.GetResourceString("Arg_EHClauseNotFilter");
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00062C2A File Offset: 0x00060E2A
		internal static string Arg_EmptyArray
		{
			get
			{
				return SR.GetResourceString("Arg_EmptyArray");
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00062C36 File Offset: 0x00060E36
		internal static string Arg_EmptySpan
		{
			get
			{
				return SR.GetResourceString("Arg_EmptySpan");
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00062C42 File Offset: 0x00060E42
		internal static string Arg_EndOfStreamException
		{
			get
			{
				return SR.GetResourceString("Arg_EndOfStreamException");
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00062C4E File Offset: 0x00060E4E
		internal static string Arg_EntryPointNotFoundException
		{
			get
			{
				return SR.GetResourceString("Arg_EntryPointNotFoundException");
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00062C5A File Offset: 0x00060E5A
		internal static string Arg_EnumAndObjectMustBeSameType
		{
			get
			{
				return SR.GetResourceString("Arg_EnumAndObjectMustBeSameType");
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00062C66 File Offset: 0x00060E66
		internal static string Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType
		{
			get
			{
				return SR.GetResourceString("Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType");
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00062C72 File Offset: 0x00060E72
		internal static string Arg_EnumIllegalVal
		{
			get
			{
				return SR.GetResourceString("Arg_EnumIllegalVal");
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00062C7E File Offset: 0x00060E7E
		internal static string Arg_EnumUnderlyingTypeAndObjectMustBeSameType
		{
			get
			{
				return SR.GetResourceString("Arg_EnumUnderlyingTypeAndObjectMustBeSameType");
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00062C8A File Offset: 0x00060E8A
		internal static string Arg_EnumValueNotFound
		{
			get
			{
				return SR.GetResourceString("Arg_EnumValueNotFound");
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x00062C96 File Offset: 0x00060E96
		internal static string Arg_ExecutionEngineException
		{
			get
			{
				return SR.GetResourceString("Arg_ExecutionEngineException");
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00062CA2 File Offset: 0x00060EA2
		internal static string Arg_ExternalException
		{
			get
			{
				return SR.GetResourceString("Arg_ExternalException");
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00062CAE File Offset: 0x00060EAE
		internal static string Arg_EnC_ExpectedPrimitive
		{
			get
			{
				return SR.GetResourceString("Arg_EnC_ExpectedPrimitive");
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00062CBA File Offset: 0x00060EBA
		internal static string Arg_FieldAccessException
		{
			get
			{
				return SR.GetResourceString("Arg_FieldAccessException");
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x00062CC6 File Offset: 0x00060EC6
		internal static string Arg_FieldDeclTarget
		{
			get
			{
				return SR.GetResourceString("Arg_FieldDeclTarget");
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00062CD2 File Offset: 0x00060ED2
		internal static string Arg_FldGetArgErr
		{
			get
			{
				return SR.GetResourceString("Arg_FldGetArgErr");
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00062CDE File Offset: 0x00060EDE
		internal static string Arg_FldGetPropSet
		{
			get
			{
				return SR.GetResourceString("Arg_FldGetPropSet");
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00062CEA File Offset: 0x00060EEA
		internal static string Arg_FldSetArgErr
		{
			get
			{
				return SR.GetResourceString("Arg_FldSetArgErr");
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00062CF6 File Offset: 0x00060EF6
		internal static string Arg_FldSetGet
		{
			get
			{
				return SR.GetResourceString("Arg_FldSetGet");
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00062D02 File Offset: 0x00060F02
		internal static string Arg_FldSetInvoke
		{
			get
			{
				return SR.GetResourceString("Arg_FldSetInvoke");
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00062D0E File Offset: 0x00060F0E
		internal static string Arg_FldSetPropGet
		{
			get
			{
				return SR.GetResourceString("Arg_FldSetPropGet");
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00062D1A File Offset: 0x00060F1A
		internal static string Arg_FormatException
		{
			get
			{
				return SR.GetResourceString("Arg_FormatException");
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00062D26 File Offset: 0x00060F26
		internal static string Arg_GenericArgumentsAfterArrayOrPointerType
		{
			get
			{
				return SR.GetResourceString("Arg_GenericArgumentsAfterArrayOrPointerType");
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00062D32 File Offset: 0x00060F32
		internal static string Arg_GenericParameter
		{
			get
			{
				return SR.GetResourceString("Arg_GenericParameter");
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00062D3E File Offset: 0x00060F3E
		internal static string Arg_GetMethNotFnd
		{
			get
			{
				return SR.GetResourceString("Arg_GetMethNotFnd");
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00062D4A File Offset: 0x00060F4A
		internal static string Arg_GuidArrayCtor
		{
			get
			{
				return SR.GetResourceString("Arg_GuidArrayCtor");
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00062D56 File Offset: 0x00060F56
		internal static string Arg_HandleNotAsync
		{
			get
			{
				return SR.GetResourceString("Arg_HandleNotAsync");
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00062D62 File Offset: 0x00060F62
		internal static string Arg_HandleNotSync
		{
			get
			{
				return SR.GetResourceString("Arg_HandleNotSync");
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00062D6E File Offset: 0x00060F6E
		internal static string Arg_HexBinaryStylesNotSupported
		{
			get
			{
				return SR.GetResourceString("Arg_HexBinaryStylesNotSupported");
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00062D7A File Offset: 0x00060F7A
		internal static string Arg_HTCapacityOverflow
		{
			get
			{
				return SR.GetResourceString("Arg_HTCapacityOverflow");
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00062D86 File Offset: 0x00060F86
		internal static string Arg_IndexMustBeInt
		{
			get
			{
				return SR.GetResourceString("Arg_IndexMustBeInt");
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00062D92 File Offset: 0x00060F92
		internal static string Arg_IndexOutOfRangeException
		{
			get
			{
				return SR.GetResourceString("Arg_IndexOutOfRangeException");
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00062D9E File Offset: 0x00060F9E
		internal static string Arg_InsufficientExecutionStackException
		{
			get
			{
				return SR.GetResourceString("Arg_InsufficientExecutionStackException");
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00062DAA File Offset: 0x00060FAA
		internal static string Arg_InvalidANSIString
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidANSIString");
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00062DB6 File Offset: 0x00060FB6
		internal static string Arg_InvalidBase
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidBase");
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00062DC2 File Offset: 0x00060FC2
		internal static string Arg_InvalidCastException
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidCastException");
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00062DCE File Offset: 0x00060FCE
		internal static string Arg_InvalidComObjectException
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidComObjectException");
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x00062DDA File Offset: 0x00060FDA
		internal static string Arg_InvalidFilterCriteriaException
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidFilterCriteriaException");
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00062DE6 File Offset: 0x00060FE6
		internal static string Arg_InvalidHandle
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidHandle");
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00062DF2 File Offset: 0x00060FF2
		internal static string Arg_InvalidHexBinaryStyle
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidHexBinaryStyle");
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00062DFE File Offset: 0x00060FFE
		internal static string Arg_InvalidNeutralResourcesLanguage_Asm_Culture
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidNeutralResourcesLanguage_Asm_Culture");
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00062E0A File Offset: 0x0006100A
		internal static string Arg_InvalidNeutralResourcesLanguage_FallbackLoc
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidNeutralResourcesLanguage_FallbackLoc");
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00062E16 File Offset: 0x00061016
		internal static string Arg_InvalidSatelliteContract_Asm_Ver
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidSatelliteContract_Asm_Ver");
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00062E22 File Offset: 0x00061022
		internal static string Arg_InvalidOleVariantTypeException
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidOleVariantTypeException");
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00062E2E File Offset: 0x0006102E
		internal static string Arg_InvalidOperationException
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidOperationException");
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00062E3A File Offset: 0x0006103A
		internal static string Arg_InvalidTypeInRetType
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidTypeInRetType");
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x00062E46 File Offset: 0x00061046
		internal static string Arg_InvalidTypeInSignature
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidTypeInSignature");
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x00062E52 File Offset: 0x00061052
		internal static string Arg_IOException
		{
			get
			{
				return SR.GetResourceString("Arg_IOException");
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x00062E5E File Offset: 0x0006105E
		internal static string Arg_KeyNotFound
		{
			get
			{
				return SR.GetResourceString("Arg_KeyNotFound");
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00062E6A File Offset: 0x0006106A
		internal static string Arg_KeyNotFoundWithKey
		{
			get
			{
				return SR.GetResourceString("Arg_KeyNotFoundWithKey");
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00062E76 File Offset: 0x00061076
		internal static string Arg_LongerThanDestArray
		{
			get
			{
				return SR.GetResourceString("Arg_LongerThanDestArray");
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00062E82 File Offset: 0x00061082
		internal static string Arg_LongerThanSrcArray
		{
			get
			{
				return SR.GetResourceString("Arg_LongerThanSrcArray");
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00062E8E File Offset: 0x0006108E
		internal static string Arg_LongerThanSrcString
		{
			get
			{
				return SR.GetResourceString("Arg_LongerThanSrcString");
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00062E9A File Offset: 0x0006109A
		internal static string Arg_LowerBoundsMustMatch
		{
			get
			{
				return SR.GetResourceString("Arg_LowerBoundsMustMatch");
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00062EA6 File Offset: 0x000610A6
		internal static string Arg_MarshalDirectiveException
		{
			get
			{
				return SR.GetResourceString("Arg_MarshalDirectiveException");
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00062EB2 File Offset: 0x000610B2
		internal static string Arg_MethodAccessException
		{
			get
			{
				return SR.GetResourceString("Arg_MethodAccessException");
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00062EBE File Offset: 0x000610BE
		internal static string Arg_MissingFieldException
		{
			get
			{
				return SR.GetResourceString("Arg_MissingFieldException");
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00062ECA File Offset: 0x000610CA
		internal static string Arg_MissingManifestResourceException
		{
			get
			{
				return SR.GetResourceString("Arg_MissingManifestResourceException");
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00062ED6 File Offset: 0x000610D6
		internal static string Arg_MissingMemberException
		{
			get
			{
				return SR.GetResourceString("Arg_MissingMemberException");
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00062EE2 File Offset: 0x000610E2
		internal static string Arg_MissingMethodException
		{
			get
			{
				return SR.GetResourceString("Arg_MissingMethodException");
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x00062EEE File Offset: 0x000610EE
		internal static string Arg_MulticastNotSupportedException
		{
			get
			{
				return SR.GetResourceString("Arg_MulticastNotSupportedException");
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x00062EFA File Offset: 0x000610FA
		internal static string Arg_MustBeBoolean
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeBoolean");
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x00062F06 File Offset: 0x00061106
		internal static string Arg_MustBeByte
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeByte");
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00062F12 File Offset: 0x00061112
		internal static string Arg_MustBeChar
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeChar");
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x00062F1E File Offset: 0x0006111E
		internal static string Arg_MustBeDateOnly
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDateOnly");
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00062F2A File Offset: 0x0006112A
		internal static string Arg_MustBeTimeOnly
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeTimeOnly");
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00062F36 File Offset: 0x00061136
		internal static string Arg_MustBeDateTime
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDateTime");
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00062F42 File Offset: 0x00061142
		internal static string Arg_MustBeDateTimeOffset
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDateTimeOffset");
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00062F4E File Offset: 0x0006114E
		internal static string Arg_MustBeDecimal
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDecimal");
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00062F5A File Offset: 0x0006115A
		internal static string Arg_MustBeDelegate
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDelegate");
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00062F66 File Offset: 0x00061166
		internal static string Arg_MustBeDouble
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDouble");
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00062F72 File Offset: 0x00061172
		internal static string Arg_MustBeDriveLetterOrRootDir
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeDriveLetterOrRootDir");
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x00062F7E File Offset: 0x0006117E
		internal static string Arg_MustBeEnum
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeEnum");
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x00062F8A File Offset: 0x0006118A
		internal static string Arg_MustBeEnumBaseTypeOrEnum
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeEnumBaseTypeOrEnum");
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00062F96 File Offset: 0x00061196
		internal static string Arg_MustBeGuid
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeGuid");
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00062FA2 File Offset: 0x000611A2
		internal static string Arg_MustBeInt16
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeInt16");
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00062FAE File Offset: 0x000611AE
		internal static string Arg_MustBeInt32
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeInt32");
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00062FBA File Offset: 0x000611BA
		internal static string Arg_MustBeInt64
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeInt64");
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00062FC6 File Offset: 0x000611C6
		internal static string Arg_MustBeInt128
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeInt128");
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00062FD2 File Offset: 0x000611D2
		internal static string Arg_MustBeIntPtr
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeIntPtr");
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00062FDE File Offset: 0x000611DE
		internal static string Arg_MustBeInterface
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeInterface");
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00062FEA File Offset: 0x000611EA
		internal static string Arg_MustBeNFloat
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeNFloat");
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00062FF6 File Offset: 0x000611F6
		internal static string Arg_MustBePointer
		{
			get
			{
				return SR.GetResourceString("Arg_MustBePointer");
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00063002 File Offset: 0x00061202
		internal static string Arg_MustBePrimArray
		{
			get
			{
				return SR.GetResourceString("Arg_MustBePrimArray");
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0006300E File Offset: 0x0006120E
		internal static string Arg_MustBeRuntimeAssembly
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeRuntimeAssembly");
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x0006301A File Offset: 0x0006121A
		internal static string Arg_MustBeSByte
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeSByte");
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00063026 File Offset: 0x00061226
		internal static string Arg_MustBeSingle
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeSingle");
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00063032 File Offset: 0x00061232
		internal static string Arg_MustBeString
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeString");
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0006303E File Offset: 0x0006123E
		internal static string Arg_MustBeTimeSpan
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeTimeSpan");
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0006304A File Offset: 0x0006124A
		internal static string Arg_MustBeType
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeType");
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00063056 File Offset: 0x00061256
		internal static string Arg_MustBeTrue
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeTrue");
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00063062 File Offset: 0x00061262
		internal static string Arg_MustBeUInt16
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeUInt16");
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0006306E File Offset: 0x0006126E
		internal static string Arg_MustBeUInt32
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeUInt32");
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0006307A File Offset: 0x0006127A
		internal static string Arg_MustBeUInt64
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeUInt64");
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00063086 File Offset: 0x00061286
		internal static string Arg_MustBeUInt128
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeUInt128");
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x00063092 File Offset: 0x00061292
		internal static string Arg_MustBeUIntPtr
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeUIntPtr");
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0006309E File Offset: 0x0006129E
		internal static string Arg_MustBeVersion
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeVersion");
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000630AA File Offset: 0x000612AA
		internal static string Arg_MustContainEnumInfo
		{
			get
			{
				return SR.GetResourceString("Arg_MustContainEnumInfo");
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x000630B6 File Offset: 0x000612B6
		internal static string Arg_NamedParamNull
		{
			get
			{
				return SR.GetResourceString("Arg_NamedParamNull");
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000630C2 File Offset: 0x000612C2
		internal static string Arg_NamedParamTooBig
		{
			get
			{
				return SR.GetResourceString("Arg_NamedParamTooBig");
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000630CE File Offset: 0x000612CE
		internal static string Arg_Need1DArray
		{
			get
			{
				return SR.GetResourceString("Arg_Need1DArray");
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x000630DA File Offset: 0x000612DA
		internal static string Arg_Need2DArray
		{
			get
			{
				return SR.GetResourceString("Arg_Need2DArray");
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000630E6 File Offset: 0x000612E6
		internal static string Arg_Need3DArray
		{
			get
			{
				return SR.GetResourceString("Arg_Need3DArray");
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000630F2 File Offset: 0x000612F2
		internal static string Arg_NeedAtLeast1Rank
		{
			get
			{
				return SR.GetResourceString("Arg_NeedAtLeast1Rank");
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000630FE File Offset: 0x000612FE
		internal static string Arg_NoAccessSpec
		{
			get
			{
				return SR.GetResourceString("Arg_NoAccessSpec");
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0006310A File Offset: 0x0006130A
		internal static string Arg_NoDefCTorWithoutTypeName
		{
			get
			{
				return SR.GetResourceString("Arg_NoDefCTorWithoutTypeName");
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00063116 File Offset: 0x00061316
		internal static string Arg_NoDefCTor
		{
			get
			{
				return SR.GetResourceString("Arg_NoDefCTor");
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00063122 File Offset: 0x00061322
		internal static string Arg_NonZeroLowerBound
		{
			get
			{
				return SR.GetResourceString("Arg_NonZeroLowerBound");
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0006312E File Offset: 0x0006132E
		internal static string Arg_NoStaticVirtual
		{
			get
			{
				return SR.GetResourceString("Arg_NoStaticVirtual");
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x0006313A File Offset: 0x0006133A
		internal static string Arg_NotFiniteNumberException
		{
			get
			{
				return SR.GetResourceString("Arg_NotFiniteNumberException");
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00063146 File Offset: 0x00061346
		internal static string Arg_NotFoundIFace
		{
			get
			{
				return SR.GetResourceString("Arg_NotFoundIFace");
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00063152 File Offset: 0x00061352
		internal static string Arg_NotGenericMethodDefinition
		{
			get
			{
				return SR.GetResourceString("Arg_NotGenericMethodDefinition");
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0006315E File Offset: 0x0006135E
		internal static string Arg_NotGenericParameter
		{
			get
			{
				return SR.GetResourceString("Arg_NotGenericParameter");
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0006316A File Offset: 0x0006136A
		internal static string Arg_NotGenericTypeDefinition
		{
			get
			{
				return SR.GetResourceString("Arg_NotGenericTypeDefinition");
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00063176 File Offset: 0x00061376
		internal static string Arg_NotImplementedException
		{
			get
			{
				return SR.GetResourceString("Arg_NotImplementedException");
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00063182 File Offset: 0x00061382
		internal static string Arg_NotSupportedException
		{
			get
			{
				return SR.GetResourceString("Arg_NotSupportedException");
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0006318E File Offset: 0x0006138E
		internal static string Arg_NullReferenceException
		{
			get
			{
				return SR.GetResourceString("Arg_NullReferenceException");
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x0006319A File Offset: 0x0006139A
		internal static string Arg_ObjObjEx
		{
			get
			{
				return SR.GetResourceString("Arg_ObjObjEx");
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x000631A6 File Offset: 0x000613A6
		internal static string Arg_OleAutDateInvalid
		{
			get
			{
				return SR.GetResourceString("Arg_OleAutDateInvalid");
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x000631B2 File Offset: 0x000613B2
		internal static string Arg_OleAutDateScale
		{
			get
			{
				return SR.GetResourceString("Arg_OleAutDateScale");
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000631BE File Offset: 0x000613BE
		internal static string Arg_OverflowException
		{
			get
			{
				return SR.GetResourceString("Arg_OverflowException");
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x000631CA File Offset: 0x000613CA
		internal static string Arg_OutOfMemoryException
		{
			get
			{
				return SR.GetResourceString("Arg_OutOfMemoryException");
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000631D6 File Offset: 0x000613D6
		internal static string Arg_ParamName_Name
		{
			get
			{
				return SR.GetResourceString("Arg_ParamName_Name");
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x000631E2 File Offset: 0x000613E2
		internal static string Arg_ParmArraySize
		{
			get
			{
				return SR.GetResourceString("Arg_ParmArraySize");
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000631EE File Offset: 0x000613EE
		internal static string Arg_ParmCnt
		{
			get
			{
				return SR.GetResourceString("Arg_ParmCnt");
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x000631FA File Offset: 0x000613FA
		internal static string Arg_PathEmpty
		{
			get
			{
				return SR.GetResourceString("Arg_PathEmpty");
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00063206 File Offset: 0x00061406
		internal static string Arg_PlatformNotSupported
		{
			get
			{
				return SR.GetResourceString("Arg_PlatformNotSupported");
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00063212 File Offset: 0x00061412
		internal static string Arg_PropSetGet
		{
			get
			{
				return SR.GetResourceString("Arg_PropSetGet");
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0006321E File Offset: 0x0006141E
		internal static string Arg_PropSetInvoke
		{
			get
			{
				return SR.GetResourceString("Arg_PropSetInvoke");
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x0006322A File Offset: 0x0006142A
		internal static string Arg_RankException
		{
			get
			{
				return SR.GetResourceString("Arg_RankException");
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00063236 File Offset: 0x00061436
		internal static string Arg_RankIndices
		{
			get
			{
				return SR.GetResourceString("Arg_RankIndices");
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00063242 File Offset: 0x00061442
		internal static string Arg_RankMultiDimNotSupported
		{
			get
			{
				return SR.GetResourceString("Arg_RankMultiDimNotSupported");
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0006324E File Offset: 0x0006144E
		internal static string Arg_RanksAndBounds
		{
			get
			{
				return SR.GetResourceString("Arg_RanksAndBounds");
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0006325A File Offset: 0x0006145A
		internal static string Arg_RegValueTooLarge
		{
			get
			{
				return SR.GetResourceString("Arg_RegValueTooLarge");
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00063266 File Offset: 0x00061466
		internal static string Arg_RegKeyNotFound
		{
			get
			{
				return SR.GetResourceString("Arg_RegKeyNotFound");
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00063272 File Offset: 0x00061472
		internal static string Arg_RegSubKeyValueAbsent
		{
			get
			{
				return SR.GetResourceString("Arg_RegSubKeyValueAbsent");
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0006327E File Offset: 0x0006147E
		internal static string Arg_RegValStrLenBug
		{
			get
			{
				return SR.GetResourceString("Arg_RegValStrLenBug");
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0006328A File Offset: 0x0006148A
		internal static string Arg_ResMgrNotResSet
		{
			get
			{
				return SR.GetResourceString("Arg_ResMgrNotResSet");
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00063296 File Offset: 0x00061496
		internal static string Arg_ResourceFileUnsupportedVersion
		{
			get
			{
				return SR.GetResourceString("Arg_ResourceFileUnsupportedVersion");
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000632A2 File Offset: 0x000614A2
		internal static string Arg_ResourceNameNotExist
		{
			get
			{
				return SR.GetResourceString("Arg_ResourceNameNotExist");
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000632AE File Offset: 0x000614AE
		internal static string Arg_SafeArrayRankMismatchException
		{
			get
			{
				return SR.GetResourceString("Arg_SafeArrayRankMismatchException");
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000632BA File Offset: 0x000614BA
		internal static string Arg_SafeArrayTypeMismatchException
		{
			get
			{
				return SR.GetResourceString("Arg_SafeArrayTypeMismatchException");
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000632C6 File Offset: 0x000614C6
		internal static string Arg_SecurityException
		{
			get
			{
				return SR.GetResourceString("Arg_SecurityException");
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000632D2 File Offset: 0x000614D2
		internal static string SerializationException
		{
			get
			{
				return SR.GetResourceString("SerializationException");
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x000632DE File Offset: 0x000614DE
		internal static string Arg_SetMethNotFnd
		{
			get
			{
				return SR.GetResourceString("Arg_SetMethNotFnd");
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000632EA File Offset: 0x000614EA
		internal static string Arg_StackOverflowException
		{
			get
			{
				return SR.GetResourceString("Arg_StackOverflowException");
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000632F6 File Offset: 0x000614F6
		internal static string Arg_SurrogatesNotAllowedAsSingleChar
		{
			get
			{
				return SR.GetResourceString("Arg_SurrogatesNotAllowedAsSingleChar");
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00063302 File Offset: 0x00061502
		internal static string Arg_SynchronizationLockException
		{
			get
			{
				return SR.GetResourceString("Arg_SynchronizationLockException");
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0006330E File Offset: 0x0006150E
		internal static string Arg_SystemException
		{
			get
			{
				return SR.GetResourceString("Arg_SystemException");
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x0006331A File Offset: 0x0006151A
		internal static string Arg_TargetInvocationException
		{
			get
			{
				return SR.GetResourceString("Arg_TargetInvocationException");
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00063326 File Offset: 0x00061526
		internal static string Arg_TargetParameterCountException
		{
			get
			{
				return SR.GetResourceString("Arg_TargetParameterCountException");
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00063332 File Offset: 0x00061532
		internal static string Arg_ThreadStartException
		{
			get
			{
				return SR.GetResourceString("Arg_ThreadStartException");
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0006333E File Offset: 0x0006153E
		internal static string Arg_ThreadStateException
		{
			get
			{
				return SR.GetResourceString("Arg_ThreadStateException");
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0006334A File Offset: 0x0006154A
		internal static string Arg_TimeoutException
		{
			get
			{
				return SR.GetResourceString("Arg_TimeoutException");
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00063356 File Offset: 0x00061556
		internal static string Arg_TypeAccessException
		{
			get
			{
				return SR.GetResourceString("Arg_TypeAccessException");
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00063362 File Offset: 0x00061562
		internal static string Arg_TypedReference_Null
		{
			get
			{
				return SR.GetResourceString("Arg_TypedReference_Null");
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0006336E File Offset: 0x0006156E
		internal static string Arg_TypeLoadException
		{
			get
			{
				return SR.GetResourceString("Arg_TypeLoadException");
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0006337A File Offset: 0x0006157A
		internal static string Arg_TypeLoadNullStr
		{
			get
			{
				return SR.GetResourceString("Arg_TypeLoadNullStr");
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00063386 File Offset: 0x00061586
		internal static string Arg_TypeRefPrimitive
		{
			get
			{
				return SR.GetResourceString("Arg_TypeRefPrimitive");
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00063392 File Offset: 0x00061592
		internal static string Arg_TypeUnloadedException
		{
			get
			{
				return SR.GetResourceString("Arg_TypeUnloadedException");
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0006339E File Offset: 0x0006159E
		internal static string Arg_UnauthorizedAccessException
		{
			get
			{
				return SR.GetResourceString("Arg_UnauthorizedAccessException");
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x000633AA File Offset: 0x000615AA
		internal static string Arg_UnboundGenField
		{
			get
			{
				return SR.GetResourceString("Arg_UnboundGenField");
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000633B6 File Offset: 0x000615B6
		internal static string Arg_UnboundGenParam
		{
			get
			{
				return SR.GetResourceString("Arg_UnboundGenParam");
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x000633C2 File Offset: 0x000615C2
		internal static string Arg_UnknownTypeCode
		{
			get
			{
				return SR.GetResourceString("Arg_UnknownTypeCode");
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x000633CE File Offset: 0x000615CE
		internal static string Arg_UnreachableException
		{
			get
			{
				return SR.GetResourceString("Arg_UnreachableException");
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x000633DA File Offset: 0x000615DA
		internal static string Arg_VarMissNull
		{
			get
			{
				return SR.GetResourceString("Arg_VarMissNull");
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x000633E6 File Offset: 0x000615E6
		internal static string Arg_VersionString
		{
			get
			{
				return SR.GetResourceString("Arg_VersionString");
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000633F2 File Offset: 0x000615F2
		internal static string Arg_WrongType
		{
			get
			{
				return SR.GetResourceString("Arg_WrongType");
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000633FE File Offset: 0x000615FE
		internal static string Argument_AbsolutePathRequired
		{
			get
			{
				return SR.GetResourceString("Argument_AbsolutePathRequired");
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0006340A File Offset: 0x0006160A
		internal static string Argument_AddingDuplicate
		{
			get
			{
				return SR.GetResourceString("Argument_AddingDuplicate");
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00063416 File Offset: 0x00061616
		internal static string Argument_AddingDuplicate__
		{
			get
			{
				return SR.GetResourceString("Argument_AddingDuplicate__");
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00063422 File Offset: 0x00061622
		internal static string Argument_AddingDuplicateWithKey
		{
			get
			{
				return SR.GetResourceString("Argument_AddingDuplicateWithKey");
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x0006342E File Offset: 0x0006162E
		internal static string Argument_AdjustmentRulesNoNulls
		{
			get
			{
				return SR.GetResourceString("Argument_AdjustmentRulesNoNulls");
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0006343A File Offset: 0x0006163A
		internal static string Argument_AdjustmentRulesOutOfOrder
		{
			get
			{
				return SR.GetResourceString("Argument_AdjustmentRulesOutOfOrder");
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00063446 File Offset: 0x00061646
		internal static string Argument_AlignmentMustBePow2
		{
			get
			{
				return SR.GetResourceString("Argument_AlignmentMustBePow2");
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00063452 File Offset: 0x00061652
		internal static string Argument_AlreadyBoundOrSyncHandle
		{
			get
			{
				return SR.GetResourceString("Argument_AlreadyBoundOrSyncHandle");
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0006345E File Offset: 0x0006165E
		internal static string Argument_ArraysInvalid
		{
			get
			{
				return SR.GetResourceString("Argument_ArraysInvalid");
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0006346A File Offset: 0x0006166A
		internal static string Argument_ArrayParsingError
		{
			get
			{
				return SR.GetResourceString("Argument_ArrayParsingError");
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00063476 File Offset: 0x00061676
		internal static string Argument_AttributeNamesMustBeUnique
		{
			get
			{
				return SR.GetResourceString("Argument_AttributeNamesMustBeUnique");
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00063482 File Offset: 0x00061682
		internal static string Argument_BadConstructor
		{
			get
			{
				return SR.GetResourceString("Argument_BadConstructor");
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0006348E File Offset: 0x0006168E
		internal static string Argument_BadExceptionCodeGen
		{
			get
			{
				return SR.GetResourceString("Argument_BadExceptionCodeGen");
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0006349A File Offset: 0x0006169A
		internal static string Argument_BadFieldType
		{
			get
			{
				return SR.GetResourceString("Argument_BadFieldType");
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x000634A6 File Offset: 0x000616A6
		internal static string Argument_BadFormatSpecifier
		{
			get
			{
				return SR.GetResourceString("Argument_BadFormatSpecifier");
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x000634B2 File Offset: 0x000616B2
		internal static string Argument_BadParameterCountsForConstructor
		{
			get
			{
				return SR.GetResourceString("Argument_BadParameterCountsForConstructor");
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x000634BE File Offset: 0x000616BE
		internal static string Argument_BadParameterTypeForCAB
		{
			get
			{
				return SR.GetResourceString("Argument_BadParameterTypeForCAB");
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000634CA File Offset: 0x000616CA
		internal static string Argument_BadSigFormat
		{
			get
			{
				return SR.GetResourceString("Argument_BadSigFormat");
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x000634D6 File Offset: 0x000616D6
		internal static string Argument_BadSizeForData
		{
			get
			{
				return SR.GetResourceString("Argument_BadSizeForData");
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x000634E2 File Offset: 0x000616E2
		internal static string Argument_ByrefQualifierMustBeLastOneOfAType
		{
			get
			{
				return SR.GetResourceString("Argument_ByrefQualifierMustBeLastOneOfAType");
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000634EE File Offset: 0x000616EE
		internal static string Argument_CannotSetParentToInterface
		{
			get
			{
				return SR.GetResourceString("Argument_CannotSetParentToInterface");
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x000634FA File Offset: 0x000616FA
		internal static string Argument_CodepageNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_CodepageNotSupported");
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00063506 File Offset: 0x00061706
		internal static string Argument_CompareOptionOrdinal
		{
			get
			{
				return SR.GetResourceString("Argument_CompareOptionOrdinal");
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00063512 File Offset: 0x00061712
		internal static string Argument_ConflictingDateTimeRoundtripStyles
		{
			get
			{
				return SR.GetResourceString("Argument_ConflictingDateTimeRoundtripStyles");
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0006351E File Offset: 0x0006171E
		internal static string Argument_ConflictingDateTimeStyles
		{
			get
			{
				return SR.GetResourceString("Argument_ConflictingDateTimeStyles");
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0006352A File Offset: 0x0006172A
		internal static string Argument_ConstantDoesntMatch
		{
			get
			{
				return SR.GetResourceString("Argument_ConstantDoesntMatch");
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00063536 File Offset: 0x00061736
		internal static string Argument_ConstantNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_ConstantNotSupported");
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00063542 File Offset: 0x00061742
		internal static string Argument_ConstructorNeedGenericDeclaringType
		{
			get
			{
				return SR.GetResourceString("Argument_ConstructorNeedGenericDeclaringType");
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0006354E File Offset: 0x0006174E
		internal static string Argument_ConversionOverflow
		{
			get
			{
				return SR.GetResourceString("Argument_ConversionOverflow");
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x0006355A File Offset: 0x0006175A
		internal static string Argument_ConvertMismatch
		{
			get
			{
				return SR.GetResourceString("Argument_ConvertMismatch");
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00063566 File Offset: 0x00061766
		internal static string Argument_CultureIetfNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_CultureIetfNotSupported");
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00063572 File Offset: 0x00061772
		internal static string Argument_CultureInvalidIdentifier
		{
			get
			{
				return SR.GetResourceString("Argument_CultureInvalidIdentifier");
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0006357E File Offset: 0x0006177E
		internal static string Argument_CultureIsNeutral
		{
			get
			{
				return SR.GetResourceString("Argument_CultureIsNeutral");
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0006358A File Offset: 0x0006178A
		internal static string Argument_CultureNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_CultureNotSupported");
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x00063596 File Offset: 0x00061796
		internal static string Argument_CultureNotSupportedInInvariantMode
		{
			get
			{
				return SR.GetResourceString("Argument_CultureNotSupportedInInvariantMode");
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000635A2 File Offset: 0x000617A2
		internal static string InvalidOperation_ResolvedAssemblyMustBeRuntimeAssembly
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ResolvedAssemblyMustBeRuntimeAssembly");
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000635AE File Offset: 0x000617AE
		internal static string InvalidOperation_ResolvedAssemblyRequestedNameMismatch
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ResolvedAssemblyRequestedNameMismatch");
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000635BA File Offset: 0x000617BA
		internal static string Argument_CustomCultureCannotBePassedByNumber
		{
			get
			{
				return SR.GetResourceString("Argument_CustomCultureCannotBePassedByNumber");
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x000635C6 File Offset: 0x000617C6
		internal static string Argument_CustomModifierLengthInvalidLength
		{
			get
			{
				return SR.GetResourceString("Argument_CustomModifierLengthInvalidLength");
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x000635D2 File Offset: 0x000617D2
		internal static string Argument_DateTimeBadBinaryData
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeBadBinaryData");
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x000635DE File Offset: 0x000617DE
		internal static string Argument_DateTimeHasTicks
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeHasTicks");
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x000635EA File Offset: 0x000617EA
		internal static string Argument_DateTimeHasTimeOfDay
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeHasTimeOfDay");
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x000635F6 File Offset: 0x000617F6
		internal static string Argument_DateTimeIsInvalid
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeIsInvalid");
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00063602 File Offset: 0x00061802
		internal static string Argument_DateTimeIsNotAmbiguous
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeIsNotAmbiguous");
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0006360E File Offset: 0x0006180E
		internal static string Argument_DateTimeKindMustBeUnspecified
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeKindMustBeUnspecified");
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x0006361A File Offset: 0x0006181A
		internal static string Argument_DateTimeKindMustBeUnspecifiedOrUtc
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeKindMustBeUnspecifiedOrUtc");
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00063626 File Offset: 0x00061826
		internal static string Argument_DateTimeOffsetInvalidDateTimeStyles
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeOffsetInvalidDateTimeStyles");
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00063632 File Offset: 0x00061832
		internal static string Argument_DateTimeOffsetIsNotAmbiguous
		{
			get
			{
				return SR.GetResourceString("Argument_DateTimeOffsetIsNotAmbiguous");
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0006363E File Offset: 0x0006183E
		internal static string Argument_DestinationTooShort
		{
			get
			{
				return SR.GetResourceString("Argument_DestinationTooShort");
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x0006364A File Offset: 0x0006184A
		internal static string Argument_DuplicateTypeName
		{
			get
			{
				return SR.GetResourceString("Argument_DuplicateTypeName");
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00063656 File Offset: 0x00061856
		internal static string Argument_EmitWriteLineType
		{
			get
			{
				return SR.GetResourceString("Argument_EmitWriteLineType");
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00063662 File Offset: 0x00061862
		internal static string Argument_EmptyName
		{
			get
			{
				return SR.GetResourceString("Argument_EmptyName");
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0006366E File Offset: 0x0006186E
		internal static string Argument_EmptyWaithandleArray
		{
			get
			{
				return SR.GetResourceString("Argument_EmptyWaithandleArray");
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0006367A File Offset: 0x0006187A
		internal static string Argument_EncoderFallbackNotEmpty
		{
			get
			{
				return SR.GetResourceString("Argument_EncoderFallbackNotEmpty");
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00063686 File Offset: 0x00061886
		internal static string Argument_EncodingConversionOverflowBytes
		{
			get
			{
				return SR.GetResourceString("Argument_EncodingConversionOverflowBytes");
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00063692 File Offset: 0x00061892
		internal static string Argument_EncodingConversionOverflowChars
		{
			get
			{
				return SR.GetResourceString("Argument_EncodingConversionOverflowChars");
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0006369E File Offset: 0x0006189E
		internal static string Argument_EncodingNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_EncodingNotSupported");
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000636AA File Offset: 0x000618AA
		internal static string Argument_EnumTypeDoesNotMatch
		{
			get
			{
				return SR.GetResourceString("Argument_EnumTypeDoesNotMatch");
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000636B6 File Offset: 0x000618B6
		internal static string Argument_FallbackBufferNotEmpty
		{
			get
			{
				return SR.GetResourceString("Argument_FallbackBufferNotEmpty");
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000636C2 File Offset: 0x000618C2
		internal static string Argument_FieldDoesNotBelongToConstructorClass
		{
			get
			{
				return SR.GetResourceString("Argument_FieldDoesNotBelongToConstructorClass");
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000636CE File Offset: 0x000618CE
		internal static string Argument_FieldDoesNotHaveAValidType
		{
			get
			{
				return SR.GetResourceString("Argument_FieldDoesNotHaveAValidType");
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x000636DA File Offset: 0x000618DA
		internal static string Argument_FieldDoesNotHaveAValidValue
		{
			get
			{
				return SR.GetResourceString("Argument_FieldDoesNotHaveAValidValue");
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000636E6 File Offset: 0x000618E6
		internal static string Argument_FieldPropertyEventAndTypeHandleIncompatibility
		{
			get
			{
				return SR.GetResourceString("Argument_FieldPropertyEventAndTypeHandleIncompatibility");
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000636F2 File Offset: 0x000618F2
		internal static string Argument_FieldNeedGenericDeclaringType
		{
			get
			{
				return SR.GetResourceString("Argument_FieldNeedGenericDeclaringType");
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000636FE File Offset: 0x000618FE
		internal static string Argument_GenericArgsCount
		{
			get
			{
				return SR.GetResourceString("Argument_GenericArgsCount");
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x0006370A File Offset: 0x0006190A
		internal static string Argument_GenericArgumentCannotBeByrefOrPointerType
		{
			get
			{
				return SR.GetResourceString("Argument_GenericArgumentCannotBeByrefOrPointerType");
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00063716 File Offset: 0x00061916
		internal static string Argument_GenericParsingError
		{
			get
			{
				return SR.GetResourceString("Argument_GenericParsingError");
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00063722 File Offset: 0x00061922
		internal static string Argument_OpenGenericTypeNotPermitted
		{
			get
			{
				return SR.GetResourceString("Argument_OpenGenericTypeNotPermitted");
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0006372E File Offset: 0x0006192E
		internal static string Argument_GlobalMembersMustBeStatic
		{
			get
			{
				return SR.GetResourceString("Argument_GlobalMembersMustBeStatic");
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0006373A File Offset: 0x0006193A
		internal static string Argument_HasToBeArrayClass
		{
			get
			{
				return SR.GetResourceString("Argument_HasToBeArrayClass");
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00063746 File Offset: 0x00061946
		internal static string Argument_IdnBadBidi
		{
			get
			{
				return SR.GetResourceString("Argument_IdnBadBidi");
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00063752 File Offset: 0x00061952
		internal static string Argument_IdnBadLabelSize
		{
			get
			{
				return SR.GetResourceString("Argument_IdnBadLabelSize");
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0006375E File Offset: 0x0006195E
		internal static string Argument_IdnBadNameSize
		{
			get
			{
				return SR.GetResourceString("Argument_IdnBadNameSize");
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0006376A File Offset: 0x0006196A
		internal static string Argument_IdnBadPunycode
		{
			get
			{
				return SR.GetResourceString("Argument_IdnBadPunycode");
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00063776 File Offset: 0x00061976
		internal static string Argument_IdnBadStd3
		{
			get
			{
				return SR.GetResourceString("Argument_IdnBadStd3");
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00063782 File Offset: 0x00061982
		internal static string Argument_IdnIllegalName
		{
			get
			{
				return SR.GetResourceString("Argument_IdnIllegalName");
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0006378E File Offset: 0x0006198E
		internal static string Argument_IllegalEnvVarName
		{
			get
			{
				return SR.GetResourceString("Argument_IllegalEnvVarName");
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x0006379A File Offset: 0x0006199A
		internal static string Argument_ImplementIComparable
		{
			get
			{
				return SR.GetResourceString("Argument_ImplementIComparable");
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000637A6 File Offset: 0x000619A6
		internal static string Argument_InterfaceMap
		{
			get
			{
				return SR.GetResourceString("Argument_InterfaceMap");
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000637B2 File Offset: 0x000619B2
		internal static string Argument_InvalidAppendMode
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidAppendMode");
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000637BE File Offset: 0x000619BE
		internal static string Argument_InvalidPreallocateAccess
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidPreallocateAccess");
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x000637CA File Offset: 0x000619CA
		internal static string Argument_InvalidPreallocateMode
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidPreallocateMode");
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000637D6 File Offset: 0x000619D6
		internal static string Argument_InvalidUnixCreateMode
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidUnixCreateMode");
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x000637E2 File Offset: 0x000619E2
		internal static string Argument_InvalidArgumentForComparison
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidArgumentForComparison");
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000637EE File Offset: 0x000619EE
		internal static string Argument_InvalidArrayLength
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidArrayLength");
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x000637FA File Offset: 0x000619FA
		internal static string Argument_MultiDimensionalArrayCannotBeBound
		{
			get
			{
				return SR.GetResourceString("Argument_MultiDimensionalArrayCannotBeBound");
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00063806 File Offset: 0x00061A06
		internal static string Argument_IncompatibleArrayType
		{
			get
			{
				return SR.GetResourceString("Argument_IncompatibleArrayType");
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00063812 File Offset: 0x00061A12
		internal static string Argument_InvalidArrayType
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidArrayType");
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0006381E File Offset: 0x00061A1E
		internal static string InvalidAssemblyName
		{
			get
			{
				return SR.GetResourceString("InvalidAssemblyName");
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0006382A File Offset: 0x00061A2A
		internal static string Argument_InvalidCalendar
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCalendar");
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x00063836 File Offset: 0x00061A36
		internal static string Argument_InvalidCharInArraySpecification
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCharInArraySpecification");
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00063842 File Offset: 0x00061A42
		internal static string Argument_InvalidCharSequence
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCharSequence");
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0006384E File Offset: 0x00061A4E
		internal static string Argument_InvalidCharSequenceNoIndex
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCharSequenceNoIndex");
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0006385A File Offset: 0x00061A5A
		internal static string Argument_InvalidCodePageBytesIndex
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCodePageBytesIndex");
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00063866 File Offset: 0x00061A66
		internal static string Argument_InvalidCodePageConversionIndex
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCodePageConversionIndex");
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00063872 File Offset: 0x00061A72
		internal static string Argument_InvalidConstructorDeclaringType
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidConstructorDeclaringType");
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0006387E File Offset: 0x00061A7E
		internal static string Argument_InvalidCultureName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidCultureName");
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0006388A File Offset: 0x00061A8A
		internal static string Argument_InvalidPredefinedCultureName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidPredefinedCultureName");
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x00063896 File Offset: 0x00061A96
		internal static string Argument_InvalidDateTimeKind
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidDateTimeKind");
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x000638A2 File Offset: 0x00061AA2
		internal static string Argument_InvalidDateTimeStyles
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidDateTimeStyles");
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x000638AE File Offset: 0x00061AAE
		internal static string Argument_InvalidDateStyles
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidDateStyles");
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x000638BA File Offset: 0x00061ABA
		internal static string Argument_InvalidDigitSubstitution
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidDigitSubstitution");
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x000638C6 File Offset: 0x00061AC6
		internal static string Argument_InvalidElementName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidElementName");
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x000638D2 File Offset: 0x00061AD2
		internal static string Argument_InvalidElementTag
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidElementTag");
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x000638DE File Offset: 0x00061ADE
		internal static string Argument_InvalidElementText
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidElementText");
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x000638EA File Offset: 0x00061AEA
		internal static string Argument_InvalidElementValue
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidElementValue");
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x000638F6 File Offset: 0x00061AF6
		internal static string Argument_InvalidEnum
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidEnum");
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00063902 File Offset: 0x00061B02
		internal static string Argument_InvalidEnumValue
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidEnumValue");
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0006390E File Offset: 0x00061B0E
		internal static string Argument_InvalidFieldDeclaringType
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidFieldDeclaringType");
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0006391A File Offset: 0x00061B1A
		internal static string Argument_InvalidFileModeAndAccessCombo
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidFileModeAndAccessCombo");
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x00063926 File Offset: 0x00061B26
		internal static string Argument_InvalidFlag
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidFlag");
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00063932 File Offset: 0x00061B32
		internal static string Argument_InvalidGenericArg
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidGenericArg");
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0006393E File Offset: 0x00061B3E
		internal static string Argument_InvalidGenericArgumentsSeparator
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidGenericArgumentsSeparator");
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0006394A File Offset: 0x00061B4A
		internal static string Argument_InvalidGroupSize
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidGroupSize");
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00063956 File Offset: 0x00061B56
		internal static string Argument_InvalidHandle
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidHandle");
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00063962 File Offset: 0x00061B62
		internal static string Argument_InvalidHighSurrogate
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidHighSurrogate");
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x0006396E File Offset: 0x00061B6E
		internal static string Argument_InvalidId
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidId");
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0006397A File Offset: 0x00061B7A
		internal static string Argument_InvalidKindOfTypeForCA
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidKindOfTypeForCA");
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x00063986 File Offset: 0x00061B86
		internal static string Argument_InvalidLabel
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidLabel");
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00063992 File Offset: 0x00061B92
		internal static string Argument_InvalidLowSurrogate
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidLowSurrogate");
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x0006399E File Offset: 0x00061B9E
		internal static string Argument_InvalidMemberForNamedArgument
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidMemberForNamedArgument");
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x000639AA File Offset: 0x00061BAA
		internal static string Argument_InvalidMethodDeclaringType
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidMethodDeclaringType");
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x000639B6 File Offset: 0x00061BB6
		internal static string Argument_InvalidName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidName");
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x000639C2 File Offset: 0x00061BC2
		internal static string Argument_InvalidNativeDigitCount
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidNativeDigitCount");
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x000639CE File Offset: 0x00061BCE
		internal static string Argument_InvalidNativeDigitValue
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidNativeDigitValue");
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000639DA File Offset: 0x00061BDA
		internal static string Argument_InvalidNeutralRegionName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidNeutralRegionName");
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x000639E6 File Offset: 0x00061BE6
		internal static string Argument_InvalidNormalizationForm
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidNormalizationForm");
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000639F2 File Offset: 0x00061BF2
		internal static string Argument_InvalidNumberStyles
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidNumberStyles");
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x000639FE File Offset: 0x00061BFE
		internal static string Argument_InvalidOffLen
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidOffLen");
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00063A0A File Offset: 0x00061C0A
		internal static string Argument_InvalidOpCodeOnDynamicMethod
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidOpCodeOnDynamicMethod");
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00063A16 File Offset: 0x00061C16
		internal static string Argument_NullCharInPath
		{
			get
			{
				return SR.GetResourceString("Argument_NullCharInPath");
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00063A22 File Offset: 0x00061C22
		internal static string Argument_InvalidResourceCultureName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidResourceCultureName");
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00063A2E File Offset: 0x00061C2E
		internal static string Argument_InvalidSafeBufferOffLen
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidSafeBufferOffLen");
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00063A3A File Offset: 0x00061C3A
		internal static string Argument_InvalidSeekOrigin
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidSeekOrigin");
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00063A46 File Offset: 0x00061C46
		internal static string Argument_InvalidSerializedString
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidSerializedString");
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x00063A52 File Offset: 0x00061C52
		internal static string Argument_InvalidStartupHookSignature
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidStartupHookSignature");
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00063A5E File Offset: 0x00061C5E
		internal static string Argument_InvalidTimeSpanStyles
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidTimeSpanStyles");
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x00063A6A File Offset: 0x00061C6A
		internal static string Argument_InvalidToken
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidToken");
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00063A76 File Offset: 0x00061C76
		internal static string Argument_InvalidTypeForDynamicMethod
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidTypeForDynamicMethod");
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00063A82 File Offset: 0x00061C82
		internal static string Argument_InvalidTypeName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidTypeName");
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00063A8E File Offset: 0x00061C8E
		internal static string Argument_InvalidTypeWithPointersNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidTypeWithPointersNotSupported");
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00063A9A File Offset: 0x00061C9A
		internal static string Argument_InvalidUnity
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidUnity");
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00063AA6 File Offset: 0x00061CA6
		internal static string Argument_LabelUnmarked
		{
			get
			{
				return SR.GetResourceString("Argument_LabelUnmarked");
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00063AB2 File Offset: 0x00061CB2
		internal static string Argument_LongEnvVarValue
		{
			get
			{
				return SR.GetResourceString("Argument_LongEnvVarValue");
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00063ABE File Offset: 0x00061CBE
		internal static string Argument_MethodBodyMustBelongToType
		{
			get
			{
				return SR.GetResourceString("Argument_MethodBodyMustBelongToType");
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00063ACA File Offset: 0x00061CCA
		internal static string Argument_MethodDeclaringTypeGeneric
		{
			get
			{
				return SR.GetResourceString("Argument_MethodDeclaringTypeGeneric");
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00063AD6 File Offset: 0x00061CD6
		internal static string Argument_MethodNeedGenericDeclaringType
		{
			get
			{
				return SR.GetResourceString("Argument_MethodNeedGenericDeclaringType");
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00063AE2 File Offset: 0x00061CE2
		internal static string Argument_MinMaxValue
		{
			get
			{
				return SR.GetResourceString("Argument_MinMaxValue");
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x00063AEE File Offset: 0x00061CEE
		internal static string Argument_MismatchedArrays
		{
			get
			{
				return SR.GetResourceString("Argument_MismatchedArrays");
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00063AFA File Offset: 0x00061CFA
		internal static string Argument_MustBeFalse
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeFalse");
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00063B06 File Offset: 0x00061D06
		internal static string Argument_MustBeRuntimeAssembly
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeRuntimeAssembly");
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00063B12 File Offset: 0x00061D12
		internal static string Argument_MustBeRuntimeFieldInfo
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeRuntimeFieldInfo");
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00063B1E File Offset: 0x00061D1E
		internal static string Argument_MustBeRuntimeConstructorInfo
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeRuntimeConstructorInfo");
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00063B2A File Offset: 0x00061D2A
		internal static string Argument_MustBeRuntimeMethodInfo
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeRuntimeMethodInfo");
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00063B36 File Offset: 0x00061D36
		internal static string Argument_MustBeRuntimeMethod
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeRuntimeMethod");
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00063B42 File Offset: 0x00061D42
		internal static string Argument_MustBeRuntimeType
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeRuntimeType");
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x00063B4E File Offset: 0x00061D4E
		internal static string Argument_MustBeTypeBuilder
		{
			get
			{
				return SR.GetResourceString("Argument_MustBeTypeBuilder");
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00063B5A File Offset: 0x00061D5A
		internal static string Argument_MustHaveAttributeBaseClass
		{
			get
			{
				return SR.GetResourceString("Argument_MustHaveAttributeBaseClass");
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00063B66 File Offset: 0x00061D66
		internal static string Argument_NativeOverlappedAlreadyFree
		{
			get
			{
				return SR.GetResourceString("Argument_NativeOverlappedAlreadyFree");
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00063B72 File Offset: 0x00061D72
		internal static string Argument_NativeOverlappedWrongBoundHandle
		{
			get
			{
				return SR.GetResourceString("Argument_NativeOverlappedWrongBoundHandle");
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00063B7E File Offset: 0x00061D7E
		internal static string Argument_NeedGenericMethodDefinition
		{
			get
			{
				return SR.GetResourceString("Argument_NeedGenericMethodDefinition");
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00063B8A File Offset: 0x00061D8A
		internal static string Argument_NeedNonGenericType
		{
			get
			{
				return SR.GetResourceString("Argument_NeedNonGenericType");
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x00063B96 File Offset: 0x00061D96
		internal static string Argument_NeedStructWithNoRefs
		{
			get
			{
				return SR.GetResourceString("Argument_NeedStructWithNoRefs");
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00063BA2 File Offset: 0x00061DA2
		internal static string Argument_NegativeFieldOffsetNotPermitted
		{
			get
			{
				return SR.GetResourceString("Argument_NegativeFieldOffsetNotPermitted");
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00063BAE File Offset: 0x00061DAE
		internal static string Argument_NeverValidGenericArgument
		{
			get
			{
				return SR.GetResourceString("Argument_NeverValidGenericArgument");
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x00063BBA File Offset: 0x00061DBA
		internal static string Argument_NoEra
		{
			get
			{
				return SR.GetResourceString("Argument_NoEra");
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x00063BC6 File Offset: 0x00061DC6
		internal static string Argument_NoRegionInvariantCulture
		{
			get
			{
				return SR.GetResourceString("Argument_NoRegionInvariantCulture");
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00063BD2 File Offset: 0x00061DD2
		internal static string Argument_NotEnoughBytesToRead
		{
			get
			{
				return SR.GetResourceString("Argument_NotEnoughBytesToRead");
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00063BDE File Offset: 0x00061DDE
		internal static string Argument_NotEnoughBytesToWrite
		{
			get
			{
				return SR.GetResourceString("Argument_NotEnoughBytesToWrite");
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00063BEA File Offset: 0x00061DEA
		internal static string Argument_NotEnoughGenArguments
		{
			get
			{
				return SR.GetResourceString("Argument_NotEnoughGenArguments");
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00063BF6 File Offset: 0x00061DF6
		internal static string Argument_NotExceptionType
		{
			get
			{
				return SR.GetResourceString("Argument_NotExceptionType");
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00063C02 File Offset: 0x00061E02
		internal static string Argument_NotInExceptionBlock
		{
			get
			{
				return SR.GetResourceString("Argument_NotInExceptionBlock");
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00063C0E File Offset: 0x00061E0E
		internal static string Argument_NotMethodCallOpcode
		{
			get
			{
				return SR.GetResourceString("Argument_NotMethodCallOpcode");
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00063C1A File Offset: 0x00061E1A
		internal static string Argument_OffsetAndCapacityOutOfBounds
		{
			get
			{
				return SR.GetResourceString("Argument_OffsetAndCapacityOutOfBounds");
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00063C26 File Offset: 0x00061E26
		internal static string Argument_OffsetLocalMismatch
		{
			get
			{
				return SR.GetResourceString("Argument_OffsetLocalMismatch");
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00063C32 File Offset: 0x00061E32
		internal static string Argument_OffsetOutOfRange
		{
			get
			{
				return SR.GetResourceString("Argument_OffsetOutOfRange");
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00063C3E File Offset: 0x00061E3E
		internal static string Argument_OffsetPrecision
		{
			get
			{
				return SR.GetResourceString("Argument_OffsetPrecision");
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00063C4A File Offset: 0x00061E4A
		internal static string Argument_OffsetUtcMismatch
		{
			get
			{
				return SR.GetResourceString("Argument_OffsetUtcMismatch");
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x00063C56 File Offset: 0x00061E56
		internal static string Argument_OneOfCulturesNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_OneOfCulturesNotSupported");
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00063C62 File Offset: 0x00061E62
		internal static string Argument_OnlyMscorlib
		{
			get
			{
				return SR.GetResourceString("Argument_OnlyMscorlib");
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x00063C6E File Offset: 0x00061E6E
		internal static string Argument_OutOfOrderDateTimes
		{
			get
			{
				return SR.GetResourceString("Argument_OutOfOrderDateTimes");
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x00063C7A File Offset: 0x00061E7A
		internal static string Argument_PathEmpty
		{
			get
			{
				return SR.GetResourceString("Argument_PathEmpty");
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x00063C86 File Offset: 0x00061E86
		internal static string Argument_ParameterHasUnmatchedArgumentValue
		{
			get
			{
				return SR.GetResourceString("Argument_ParameterHasUnmatchedArgumentValue");
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00063C92 File Offset: 0x00061E92
		internal static string Argument_ParameterInvalidType
		{
			get
			{
				return SR.GetResourceString("Argument_ParameterInvalidType");
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x00063C9E File Offset: 0x00061E9E
		internal static string Argument_ParameterInvalidValue
		{
			get
			{
				return SR.GetResourceString("Argument_ParameterInvalidValue");
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00063CAA File Offset: 0x00061EAA
		internal static string Argument_TypeParseError
		{
			get
			{
				return SR.GetResourceString("Argument_TypeParseError");
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00063CB6 File Offset: 0x00061EB6
		internal static string Argument_PreAllocatedAlreadyAllocated
		{
			get
			{
				return SR.GetResourceString("Argument_PreAllocatedAlreadyAllocated");
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00063CC2 File Offset: 0x00061EC2
		internal static string Argument_RecursiveFallback
		{
			get
			{
				return SR.GetResourceString("Argument_RecursiveFallback");
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00063CCE File Offset: 0x00061ECE
		internal static string Argument_RecursiveFallbackBytes
		{
			get
			{
				return SR.GetResourceString("Argument_RecursiveFallbackBytes");
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00063CDA File Offset: 0x00061EDA
		internal static string Argument_RedefinedLabel
		{
			get
			{
				return SR.GetResourceString("Argument_RedefinedLabel");
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00063CE6 File Offset: 0x00061EE6
		internal static string Argument_ResolveType
		{
			get
			{
				return SR.GetResourceString("Argument_ResolveType");
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00063CF2 File Offset: 0x00061EF2
		internal static string Argument_ResultCalendarRange
		{
			get
			{
				return SR.GetResourceString("Argument_ResultCalendarRange");
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x00063CFE File Offset: 0x00061EFE
		internal static string Argument_SemaphoreInitialMaximum
		{
			get
			{
				return SR.GetResourceString("Argument_SemaphoreInitialMaximum");
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00063D0A File Offset: 0x00061F0A
		internal static string Argument_ShouldNotSpecifyExceptionType
		{
			get
			{
				return SR.GetResourceString("Argument_ShouldNotSpecifyExceptionType");
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x00063D16 File Offset: 0x00061F16
		internal static string Argument_ShouldOnlySetVisibilityFlags
		{
			get
			{
				return SR.GetResourceString("Argument_ShouldOnlySetVisibilityFlags");
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x00063D22 File Offset: 0x00061F22
		internal static string Argument_StreamNotReadable
		{
			get
			{
				return SR.GetResourceString("Argument_StreamNotReadable");
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x00063D2E File Offset: 0x00061F2E
		internal static string Argument_StreamNotWritable
		{
			get
			{
				return SR.GetResourceString("Argument_StreamNotWritable");
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00063D3A File Offset: 0x00061F3A
		internal static string Argument_StringFirstCharIsZero
		{
			get
			{
				return SR.GetResourceString("Argument_StringFirstCharIsZero");
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00063D46 File Offset: 0x00061F46
		internal static string Argument_TimeSpanHasSeconds
		{
			get
			{
				return SR.GetResourceString("Argument_TimeSpanHasSeconds");
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00063D52 File Offset: 0x00061F52
		internal static string Argument_ToExclusiveLessThanFromExclusive
		{
			get
			{
				return SR.GetResourceString("Argument_ToExclusiveLessThanFromExclusive");
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00063D5E File Offset: 0x00061F5E
		internal static string Argument_TransitionTimesAreIdentical
		{
			get
			{
				return SR.GetResourceString("Argument_TransitionTimesAreIdentical");
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00063D6A File Offset: 0x00061F6A
		internal static string Argument_TypedReferenceInvalidField
		{
			get
			{
				return SR.GetResourceString("Argument_TypedReferenceInvalidField");
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00063D76 File Offset: 0x00061F76
		internal static string Argument_TypeMustNotBeComImport
		{
			get
			{
				return SR.GetResourceString("Argument_TypeMustNotBeComImport");
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00063D82 File Offset: 0x00061F82
		internal static string Argument_UnclosedAssemblyQualifiedTypeName
		{
			get
			{
				return SR.GetResourceString("Argument_UnclosedAssemblyQualifiedTypeName");
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00063D8E File Offset: 0x00061F8E
		internal static string Argument_UnmanagedMemAccessorWrapAround
		{
			get
			{
				return SR.GetResourceString("Argument_UnmanagedMemAccessorWrapAround");
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00063D9A File Offset: 0x00061F9A
		internal static string Argument_UnmanagedTypeOnlyValidOnFields
		{
			get
			{
				return SR.GetResourceString("Argument_UnmanagedTypeOnlyValidOnFields");
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00063DA6 File Offset: 0x00061FA6
		internal static string Argument_UnmatchedFieldValueAndType
		{
			get
			{
				return SR.GetResourceString("Argument_UnmatchedFieldValueAndType");
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00063DB2 File Offset: 0x00061FB2
		internal static string Argument_UnmatchedMethodForLocal
		{
			get
			{
				return SR.GetResourceString("Argument_UnmatchedMethodForLocal");
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00063DBE File Offset: 0x00061FBE
		internal static string Argument_UnmatchedSquareBracketWhileParsingGenericArgAssemblyName
		{
			get
			{
				return SR.GetResourceString("Argument_UnmatchedSquareBracketWhileParsingGenericArgAssemblyName");
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00063DCA File Offset: 0x00061FCA
		internal static string Argument_UTCOutOfRange
		{
			get
			{
				return SR.GetResourceString("Argument_UTCOutOfRange");
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00063DD6 File Offset: 0x00061FD6
		internal static string ArgumentException_BufferNotFromPool
		{
			get
			{
				return SR.GetResourceString("ArgumentException_BufferNotFromPool");
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00063DE2 File Offset: 0x00061FE2
		internal static string ArgumentException_OtherNotArrayOfCorrectLength
		{
			get
			{
				return SR.GetResourceString("ArgumentException_OtherNotArrayOfCorrectLength");
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00063DEE File Offset: 0x00061FEE
		internal static string ArgumentException_NotIsomorphic
		{
			get
			{
				return SR.GetResourceString("ArgumentException_NotIsomorphic");
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00063DFA File Offset: 0x00061FFA
		internal static string ArgumentException_TupleIncorrectType
		{
			get
			{
				return SR.GetResourceString("ArgumentException_TupleIncorrectType");
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00063E06 File Offset: 0x00062006
		internal static string ArgumentException_TupleLastArgumentNotATuple
		{
			get
			{
				return SR.GetResourceString("ArgumentException_TupleLastArgumentNotATuple");
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00063E12 File Offset: 0x00062012
		internal static string ArgumentException_ValueTupleIncorrectType
		{
			get
			{
				return SR.GetResourceString("ArgumentException_ValueTupleIncorrectType");
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x00063E1E File Offset: 0x0006201E
		internal static string ArgumentException_ValueTupleLastArgumentNotAValueTuple
		{
			get
			{
				return SR.GetResourceString("ArgumentException_ValueTupleLastArgumentNotAValueTuple");
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00063E2A File Offset: 0x0006202A
		internal static string ArgumentNull_Array
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_Array");
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x00063E36 File Offset: 0x00062036
		internal static string ArgumentNull_ArrayElement
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_ArrayElement");
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00063E42 File Offset: 0x00062042
		internal static string ArgumentNull_ArrayValue
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_ArrayValue");
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00063E4E File Offset: 0x0006204E
		internal static string ArgumentNull_Child
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_Child");
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00063E5A File Offset: 0x0006205A
		internal static string ArgumentNull_Generic
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_Generic");
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x00063E66 File Offset: 0x00062066
		internal static string ArgumentNull_SafeHandle
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_SafeHandle");
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00063E72 File Offset: 0x00062072
		internal static string ArgumentNull_String
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_String");
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00063E7E File Offset: 0x0006207E
		internal static string ArgumentOutOfRange_ActualValue
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_ActualValue");
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00063E8A File Offset: 0x0006208A
		internal static string ArgumentOutOfRange_AddValue
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_AddValue");
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00063E96 File Offset: 0x00062096
		internal static string ArgumentOutOfRange_ArrayLB
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_ArrayLB");
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00063EA2 File Offset: 0x000620A2
		internal static string ArgumentOutOfRange_BadHourMinuteSecond
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond");
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00063EAE File Offset: 0x000620AE
		internal static string ArgumentOutOfRange_BadYearMonthDay
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_BadYearMonthDay");
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00063EBA File Offset: 0x000620BA
		internal static string ArgumentOutOfRange_BiggerThanCollection
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_BiggerThanCollection");
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x00063EC6 File Offset: 0x000620C6
		internal static string ArgumentOutOfRange_Bounds_Lower_Upper
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Bounds_Lower_Upper");
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00063ED2 File Offset: 0x000620D2
		internal static string ArgumentOutOfRange_CalendarRange
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_CalendarRange");
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00063EDE File Offset: 0x000620DE
		internal static string ArgumentOutOfRange_Capacity
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Capacity");
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00063EEA File Offset: 0x000620EA
		internal static string ArgumentOutOfRange_Count
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Count");
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00063EF6 File Offset: 0x000620F6
		internal static string ArgumentOutOfRange_DateArithmetic
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DateArithmetic");
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00063F02 File Offset: 0x00062102
		internal static string ArgumentOutOfRange_DateTimeBadMonths
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DateTimeBadMonths");
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00063F0E File Offset: 0x0006210E
		internal static string ArgumentOutOfRange_DateTimeBadTicks
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DateTimeBadTicks");
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x00063F1A File Offset: 0x0006211A
		internal static string ArgumentOutOfRange_TimeOnlyBadTicks
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_TimeOnlyBadTicks");
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00063F26 File Offset: 0x00062126
		internal static string ArgumentOutOfRange_DateTimeBadYears
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DateTimeBadYears");
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x00063F32 File Offset: 0x00062132
		internal static string ArgumentOutOfRange_Day
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Day");
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00063F3E File Offset: 0x0006213E
		internal static string ArgumentOutOfRange_DayOfWeek
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DayOfWeek");
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00063F4A File Offset: 0x0006214A
		internal static string ArgumentOutOfRange_DayParam
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DayParam");
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00063F56 File Offset: 0x00062156
		internal static string ArgumentOutOfRange_DecimalRound
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DecimalRound");
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x00063F62 File Offset: 0x00062162
		internal static string ArgumentOutOfRange_EndIndexStartIndex
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_EndIndexStartIndex");
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00063F6E File Offset: 0x0006216E
		internal static string ArgumentOutOfRange_Enum
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Enum");
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00063F7A File Offset: 0x0006217A
		internal static string ArgumentOutOfRange_Era
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Era");
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00063F86 File Offset: 0x00062186
		internal static string ArgumentOutOfRange_FileLengthTooBig
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig");
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00063F92 File Offset: 0x00062192
		internal static string ArgumentOutOfRange_FileTimeInvalid
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_FileTimeInvalid");
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00063F9E File Offset: 0x0006219E
		internal static string ArgumentOutOfRange_GetByteCountOverflow
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_GetByteCountOverflow");
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00063FAA File Offset: 0x000621AA
		internal static string ArgumentOutOfRange_GetCharCountOverflow
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_GetCharCountOverflow");
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00063FB6 File Offset: 0x000621B6
		internal static string ArgumentOutOfRange_HashtableLoadFactor
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_HashtableLoadFactor");
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00063FC2 File Offset: 0x000621C2
		internal static string ArgumentOutOfRange_HugeArrayNotSupported
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_HugeArrayNotSupported");
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00063FCE File Offset: 0x000621CE
		internal static string ArgumentOutOfRange_IndexMustBeLess
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_IndexMustBeLess");
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00063FDA File Offset: 0x000621DA
		internal static string ArgumentOutOfRange_IndexMustBeLessOrEqual
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_IndexMustBeLessOrEqual");
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00063FE6 File Offset: 0x000621E6
		internal static string ArgumentOutOfRange_IndexCount
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_IndexCount");
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00063FF2 File Offset: 0x000621F2
		internal static string ArgumentOutOfRange_IndexCountBuffer
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_IndexCountBuffer");
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00063FFE File Offset: 0x000621FE
		internal static string ArgumentOutOfRange_IndexLength
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_IndexLength");
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x0006400A File Offset: 0x0006220A
		internal static string ArgumentOutOfRange_IndexString
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_IndexString");
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00064016 File Offset: 0x00062216
		internal static string ArgumentOutOfRange_InvalidEraValue
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_InvalidEraValue");
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x00064022 File Offset: 0x00062222
		internal static string ArgumentOutOfRange_InvalidHighSurrogate
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_InvalidHighSurrogate");
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0006402E File Offset: 0x0006222E
		internal static string ArgumentOutOfRange_InvalidLowSurrogate
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_InvalidLowSurrogate");
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x0006403A File Offset: 0x0006223A
		internal static string ArgumentOutOfRange_InvalidUTF32
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_InvalidUTF32");
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x00064046 File Offset: 0x00062246
		internal static string ArgumentOutOfRange_LengthGreaterThanCapacity
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_LengthGreaterThanCapacity");
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00064052 File Offset: 0x00062252
		internal static string ArgumentOutOfRange_LessEqualToIntegerMaxVal
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_LessEqualToIntegerMaxVal");
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x0006405E File Offset: 0x0006225E
		internal static string ArgumentOutOfRange_ListInsert
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_ListInsert");
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0006406A File Offset: 0x0006226A
		internal static string ArgumentOutOfRange_Month
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Month");
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00064076 File Offset: 0x00062276
		internal static string ArgumentOutOfRange_DayNumber
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_DayNumber");
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00064082 File Offset: 0x00062282
		internal static string ArgumentOutOfRange_MonthParam
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_MonthParam");
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0006408E File Offset: 0x0006228E
		internal static string ArgumentOutOfRange_MustBeNonNegNum
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_MustBeNonNegNum");
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0006409A File Offset: 0x0006229A
		internal static string ArgumentOutOfRange_MustBePositive
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_MustBePositive");
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000640A6 File Offset: 0x000622A6
		internal static string ArgumentOutOfRange_NeedNonNegNum
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegNum");
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x000640B2 File Offset: 0x000622B2
		internal static string ArgumentOutOfRange_NeedNonNegOrNegative1
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1");
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000640BE File Offset: 0x000622BE
		internal static string ArgumentOutOfRange_NeedValidId
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_NeedValidId");
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x000640CA File Offset: 0x000622CA
		internal static string ArgumentOutOfRange_OffsetLength
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_OffsetLength");
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000640D6 File Offset: 0x000622D6
		internal static string ArgumentOutOfRange_OffsetOut
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_OffsetOut");
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x000640E2 File Offset: 0x000622E2
		internal static string ArgumentOutOfRange_ParamSequence
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_ParamSequence");
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x000640EE File Offset: 0x000622EE
		internal static string ArgumentOutOfRange_PartialWCHAR
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_PartialWCHAR");
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x000640FA File Offset: 0x000622FA
		internal static string ArgumentOutOfRange_PositionLessThanCapacityRequired
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired");
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x00064106 File Offset: 0x00062306
		internal static string ArgumentOutOfRange_Range
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Range");
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00064112 File Offset: 0x00062312
		internal static string ArgumentOutOfRange_RoundingDigits
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_RoundingDigits");
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0006411E File Offset: 0x0006231E
		internal static string ArgumentOutOfRange_RoundingDigits_MathF
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_RoundingDigits_MathF");
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0006412A File Offset: 0x0006232A
		internal static string ArgumentOutOfRange_SmallCapacity
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_SmallCapacity");
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00064136 File Offset: 0x00062336
		internal static string ArgumentOutOfRange_StartIndex
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_StartIndex");
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00064142 File Offset: 0x00062342
		internal static string ArgumentOutOfRange_StartIndexLargerThanLength
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_StartIndexLargerThanLength");
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0006414E File Offset: 0x0006234E
		internal static string ArgumentOutOfRange_StreamLength
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_StreamLength");
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0006415A File Offset: 0x0006235A
		internal static string ArgumentOutOfRange_UIntPtrMax
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_UIntPtrMax");
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x00064166 File Offset: 0x00062366
		internal static string ArgumentOutOfRange_UnmanagedMemStreamLength
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_UnmanagedMemStreamLength");
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00064172 File Offset: 0x00062372
		internal static string ArgumentOutOfRange_UnmanagedMemStreamWrapAround
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_UnmanagedMemStreamWrapAround");
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0006417E File Offset: 0x0006237E
		internal static string ArgumentOutOfRange_UtcOffset
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_UtcOffset");
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0006418A File Offset: 0x0006238A
		internal static string ArgumentOutOfRange_UtcOffsetAndDaylightDelta
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_UtcOffsetAndDaylightDelta");
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x00064196 File Offset: 0x00062396
		internal static string ArgumentOutOfRange_Week
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Week");
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000641A2 File Offset: 0x000623A2
		internal static string ArgumentOutOfRange_Year
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Year");
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x000641AE File Offset: 0x000623AE
		internal static string ArgumentOutOfRange_Generic_MustBeNonZero
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeNonZero");
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000641BA File Offset: 0x000623BA
		internal static string ArgumentOutOfRange_Generic_MustBeNonNegative
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeNonNegative");
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x000641C6 File Offset: 0x000623C6
		internal static string ArgumentOutOfRange_Generic_MustBeNonNegativeNonZero
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeNonNegativeNonZero");
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000641D2 File Offset: 0x000623D2
		internal static string ArgumentOutOfRange_Generic_MustBeLessOrEqual
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeLessOrEqual");
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000641DE File Offset: 0x000623DE
		internal static string ArgumentOutOfRange_Generic_MustBeLess
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeLess");
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x000641EA File Offset: 0x000623EA
		internal static string ArgumentOutOfRange_Generic_MustBeGreaterOrEqual
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeGreaterOrEqual");
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x000641F6 File Offset: 0x000623F6
		internal static string ArgumentOutOfRange_Generic_MustBeGreater
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeGreater");
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00064202 File Offset: 0x00062402
		internal static string ArgumentOutOfRange_Generic_MustBeEqual
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeEqual");
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0006420E File Offset: 0x0006240E
		internal static string ArgumentOutOfRange_Generic_MustBeNotEqual
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Generic_MustBeNotEqual");
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0006421A File Offset: 0x0006241A
		internal static string Arithmetic_NaN
		{
			get
			{
				return SR.GetResourceString("Arithmetic_NaN");
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00064226 File Offset: 0x00062426
		internal static string ArrayTypeMismatch_CantAssignType
		{
			get
			{
				return SR.GetResourceString("ArrayTypeMismatch_CantAssignType");
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x00064232 File Offset: 0x00062432
		internal static string AssemblyLoadContext_Unload_CannotUnloadIfNotCollectible
		{
			get
			{
				return SR.GetResourceString("AssemblyLoadContext_Unload_CannotUnloadIfNotCollectible");
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0006423E File Offset: 0x0006243E
		internal static string AssemblyLoadContext_Verify_NotUnloading
		{
			get
			{
				return SR.GetResourceString("AssemblyLoadContext_Verify_NotUnloading");
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0006424A File Offset: 0x0006244A
		internal static string AssertionFailed
		{
			get
			{
				return SR.GetResourceString("AssertionFailed");
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00064256 File Offset: 0x00062456
		internal static string AssertionFailed_Cnd
		{
			get
			{
				return SR.GetResourceString("AssertionFailed_Cnd");
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00064262 File Offset: 0x00062462
		internal static string AssumptionFailed
		{
			get
			{
				return SR.GetResourceString("AssumptionFailed");
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0006426E File Offset: 0x0006246E
		internal static string AssumptionFailed_Cnd
		{
			get
			{
				return SR.GetResourceString("AssumptionFailed_Cnd");
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0006427A File Offset: 0x0006247A
		internal static string AsyncMethodBuilder_InstanceNotInitialized
		{
			get
			{
				return SR.GetResourceString("AsyncMethodBuilder_InstanceNotInitialized");
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00064286 File Offset: 0x00062486
		internal static string BadImageFormat_BadILFormat
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_BadILFormat");
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00064292 File Offset: 0x00062492
		internal static string BadImageFormat_InvalidType
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_InvalidType");
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0006429E File Offset: 0x0006249E
		internal static string BadImageFormat_NegativeStringLength
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_NegativeStringLength");
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x000642AA File Offset: 0x000624AA
		internal static string BadImageFormat_ResType_SerBlobMismatch
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResType_SerBlobMismatch");
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x000642B6 File Offset: 0x000624B6
		internal static string BadImageFormat_ResourceDataLengthInvalid
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourceDataLengthInvalid");
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000642C2 File Offset: 0x000624C2
		internal static string BadImageFormat_ResourceNameCorrupted
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourceNameCorrupted");
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x000642CE File Offset: 0x000624CE
		internal static string BadImageFormat_ResourceNameCorrupted_NameIndex
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourceNameCorrupted_NameIndex");
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000642DA File Offset: 0x000624DA
		internal static string BadImageFormat_ResourcesDataInvalidOffset
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset");
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000642E6 File Offset: 0x000624E6
		internal static string BadImageFormat_ResourcesHeaderCorrupted
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted");
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x000642F2 File Offset: 0x000624F2
		internal static string BadImageFormat_ResourcesIndexTooLong
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourcesIndexTooLong");
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000642FE File Offset: 0x000624FE
		internal static string BadImageFormat_ResourcesNameInvalidOffset
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourcesNameInvalidOffset");
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0006430A File Offset: 0x0006250A
		internal static string BadImageFormat_ResourcesNameTooLong
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_ResourcesNameTooLong");
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00064316 File Offset: 0x00062516
		internal static string BadImageFormat_TypeMismatch
		{
			get
			{
				return SR.GetResourceString("BadImageFormat_TypeMismatch");
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00064322 File Offset: 0x00062522
		internal static string CancellationToken_CreateLinkedToken_TokensIsEmpty
		{
			get
			{
				return SR.GetResourceString("CancellationToken_CreateLinkedToken_TokensIsEmpty");
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0006432E File Offset: 0x0006252E
		internal static string CancellationTokenSource_Disposed
		{
			get
			{
				return SR.GetResourceString("CancellationTokenSource_Disposed");
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0006433A File Offset: 0x0006253A
		internal static string ConcurrentCollection_SyncRoot_NotSupported
		{
			get
			{
				return SR.GetResourceString("ConcurrentCollection_SyncRoot_NotSupported");
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x00064346 File Offset: 0x00062546
		internal static string CustomMarshaler_MultipleGetInstanceMethods
		{
			get
			{
				return SR.GetResourceString("CustomMarshaler_MultipleGetInstanceMethods");
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00064352 File Offset: 0x00062552
		internal static string CustomMarshaler_NoGetInstanceMethod
		{
			get
			{
				return SR.GetResourceString("CustomMarshaler_NoGetInstanceMethod");
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0006435E File Offset: 0x0006255E
		internal static string CustomMarshaler_UnassignedGenericParams
		{
			get
			{
				return SR.GetResourceString("CustomMarshaler_UnassignedGenericParams");
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x0006436A File Offset: 0x0006256A
		internal static string CustomMarshaler_NullReturnForGetInstance
		{
			get
			{
				return SR.GetResourceString("CustomMarshaler_NullReturnForGetInstance");
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00064376 File Offset: 0x00062576
		internal static string EventSource_AbstractMustNotDeclareEventMethods
		{
			get
			{
				return SR.GetResourceString("EventSource_AbstractMustNotDeclareEventMethods");
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00064382 File Offset: 0x00062582
		internal static string EventSource_AbstractMustNotDeclareKTOC
		{
			get
			{
				return SR.GetResourceString("EventSource_AbstractMustNotDeclareKTOC");
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0006438E File Offset: 0x0006258E
		internal static string EventSource_AddScalarOutOfRange
		{
			get
			{
				return SR.GetResourceString("EventSource_AddScalarOutOfRange");
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x0006439A File Offset: 0x0006259A
		internal static string EventSource_BadHexDigit
		{
			get
			{
				return SR.GetResourceString("EventSource_BadHexDigit");
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x000643A6 File Offset: 0x000625A6
		internal static string EventSource_ChannelTypeDoesNotMatchEventChannelValue
		{
			get
			{
				return SR.GetResourceString("EventSource_ChannelTypeDoesNotMatchEventChannelValue");
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x000643B2 File Offset: 0x000625B2
		internal static string EventSource_DataDescriptorsOutOfRange
		{
			get
			{
				return SR.GetResourceString("EventSource_DataDescriptorsOutOfRange");
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000643BE File Offset: 0x000625BE
		internal static string EventSource_DuplicateStringKey
		{
			get
			{
				return SR.GetResourceString("EventSource_DuplicateStringKey");
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x000643CA File Offset: 0x000625CA
		internal static string EventSource_EnumKindMismatch
		{
			get
			{
				return SR.GetResourceString("EventSource_EnumKindMismatch");
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x000643D6 File Offset: 0x000625D6
		internal static string EventSource_EvenHexDigits
		{
			get
			{
				return SR.GetResourceString("EventSource_EvenHexDigits");
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000643E2 File Offset: 0x000625E2
		internal static string EventSource_EventChannelOutOfRange
		{
			get
			{
				return SR.GetResourceString("EventSource_EventChannelOutOfRange");
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000643EE File Offset: 0x000625EE
		internal static string EventSource_EventIdReused
		{
			get
			{
				return SR.GetResourceString("EventSource_EventIdReused");
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000643FA File Offset: 0x000625FA
		internal static string EventSource_EventMustHaveTaskIfNonDefaultOpcode
		{
			get
			{
				return SR.GetResourceString("EventSource_EventMustHaveTaskIfNonDefaultOpcode");
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00064406 File Offset: 0x00062606
		internal static string EventSource_EventMustNotBeExplicitImplementation
		{
			get
			{
				return SR.GetResourceString("EventSource_EventMustNotBeExplicitImplementation");
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00064412 File Offset: 0x00062612
		internal static string EventSource_EventNameReused
		{
			get
			{
				return SR.GetResourceString("EventSource_EventNameReused");
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0006441E File Offset: 0x0006261E
		internal static string EventSource_EventParametersMismatch
		{
			get
			{
				return SR.GetResourceString("EventSource_EventParametersMismatch");
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0006442A File Offset: 0x0006262A
		internal static string EventSource_EventSourceGuidInUse
		{
			get
			{
				return SR.GetResourceString("EventSource_EventSourceGuidInUse");
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00064436 File Offset: 0x00062636
		internal static string EventSource_EventTooBig
		{
			get
			{
				return SR.GetResourceString("EventSource_EventTooBig");
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00064442 File Offset: 0x00062642
		internal static string EventSource_EventWithAdminChannelMustHaveMessage
		{
			get
			{
				return SR.GetResourceString("EventSource_EventWithAdminChannelMustHaveMessage");
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x0006444E File Offset: 0x0006264E
		internal static string EventSource_IllegalKeywordsValue
		{
			get
			{
				return SR.GetResourceString("EventSource_IllegalKeywordsValue");
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0006445A File Offset: 0x0006265A
		internal static string EventSource_IllegalOpcodeValue
		{
			get
			{
				return SR.GetResourceString("EventSource_IllegalOpcodeValue");
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00064466 File Offset: 0x00062666
		internal static string EventSource_IllegalTaskValue
		{
			get
			{
				return SR.GetResourceString("EventSource_IllegalTaskValue");
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00064472 File Offset: 0x00062672
		internal static string EventSource_IllegalValue
		{
			get
			{
				return SR.GetResourceString("EventSource_IllegalValue");
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0006447E File Offset: 0x0006267E
		internal static string EventSource_IncorrentlyAuthoredTypeInfo
		{
			get
			{
				return SR.GetResourceString("EventSource_IncorrentlyAuthoredTypeInfo");
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x0006448A File Offset: 0x0006268A
		internal static string EventSource_InvalidCommand
		{
			get
			{
				return SR.GetResourceString("EventSource_InvalidCommand");
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00064496 File Offset: 0x00062696
		internal static string EventSource_InvalidEventFormat
		{
			get
			{
				return SR.GetResourceString("EventSource_InvalidEventFormat");
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x000644A2 File Offset: 0x000626A2
		internal static string EventSource_KeywordCollision
		{
			get
			{
				return SR.GetResourceString("EventSource_KeywordCollision");
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x000644AE File Offset: 0x000626AE
		internal static string EventSource_KeywordNeedPowerOfTwo
		{
			get
			{
				return SR.GetResourceString("EventSource_KeywordNeedPowerOfTwo");
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x000644BA File Offset: 0x000626BA
		internal static string EventSource_ListenerCreatedInsideCallback
		{
			get
			{
				return SR.GetResourceString("EventSource_ListenerCreatedInsideCallback");
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000644C6 File Offset: 0x000626C6
		internal static string EventSource_ListenerNotFound
		{
			get
			{
				return SR.GetResourceString("EventSource_ListenerNotFound");
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x000644D2 File Offset: 0x000626D2
		internal static string EventSource_ListenerWriteFailure
		{
			get
			{
				return SR.GetResourceString("EventSource_ListenerWriteFailure");
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000644DE File Offset: 0x000626DE
		internal static string EventSource_MaxChannelExceeded
		{
			get
			{
				return SR.GetResourceString("EventSource_MaxChannelExceeded");
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x000644EA File Offset: 0x000626EA
		internal static string EventSource_MismatchIdToWriteEvent
		{
			get
			{
				return SR.GetResourceString("EventSource_MismatchIdToWriteEvent");
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x000644F6 File Offset: 0x000626F6
		internal static string EventSource_NeedGuid
		{
			get
			{
				return SR.GetResourceString("EventSource_NeedGuid");
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00064502 File Offset: 0x00062702
		internal static string EventSource_NeedName
		{
			get
			{
				return SR.GetResourceString("EventSource_NeedName");
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0006450E File Offset: 0x0006270E
		internal static string EventSource_NeedPositiveId
		{
			get
			{
				return SR.GetResourceString("EventSource_NeedPositiveId");
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0006451A File Offset: 0x0006271A
		internal static string EventSource_NoFreeBuffers
		{
			get
			{
				return SR.GetResourceString("EventSource_NoFreeBuffers");
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00064526 File Offset: 0x00062726
		internal static string EventSource_NonCompliantTypeError
		{
			get
			{
				return SR.GetResourceString("EventSource_NonCompliantTypeError");
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00064532 File Offset: 0x00062732
		internal static string EventSource_NoRelatedActivityId
		{
			get
			{
				return SR.GetResourceString("EventSource_NoRelatedActivityId");
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0006453E File Offset: 0x0006273E
		internal static string EventSource_NotSupportedArrayOfBinary
		{
			get
			{
				return SR.GetResourceString("EventSource_NotSupportedArrayOfBinary");
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0006454A File Offset: 0x0006274A
		internal static string EventSource_NotSupportedArrayOfNil
		{
			get
			{
				return SR.GetResourceString("EventSource_NotSupportedArrayOfNil");
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00064556 File Offset: 0x00062756
		internal static string EventSource_NotSupportedArrayOfNullTerminatedString
		{
			get
			{
				return SR.GetResourceString("EventSource_NotSupportedArrayOfNullTerminatedString");
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00064562 File Offset: 0x00062762
		internal static string EventSource_NotSupportedNestedArraysEnums
		{
			get
			{
				return SR.GetResourceString("EventSource_NotSupportedNestedArraysEnums");
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0006456E File Offset: 0x0006276E
		internal static string EventSource_NullInput
		{
			get
			{
				return SR.GetResourceString("EventSource_NullInput");
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0006457A File Offset: 0x0006277A
		internal static string EventSource_OpcodeCollision
		{
			get
			{
				return SR.GetResourceString("EventSource_OpcodeCollision");
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00064586 File Offset: 0x00062786
		internal static string EventSource_PinArrayOutOfRange
		{
			get
			{
				return SR.GetResourceString("EventSource_PinArrayOutOfRange");
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00064592 File Offset: 0x00062792
		internal static string EventSource_RecursiveTypeDefinition
		{
			get
			{
				return SR.GetResourceString("EventSource_RecursiveTypeDefinition");
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0006459E File Offset: 0x0006279E
		internal static string EventSource_StopsFollowStarts
		{
			get
			{
				return SR.GetResourceString("EventSource_StopsFollowStarts");
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000645AA File Offset: 0x000627AA
		internal static string EventSource_TaskCollision
		{
			get
			{
				return SR.GetResourceString("EventSource_TaskCollision");
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x000645B6 File Offset: 0x000627B6
		internal static string EventSource_TaskOpcodePairReused
		{
			get
			{
				return SR.GetResourceString("EventSource_TaskOpcodePairReused");
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x000645C2 File Offset: 0x000627C2
		internal static string EventSource_TooManyArgs
		{
			get
			{
				return SR.GetResourceString("EventSource_TooManyArgs");
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x000645CE File Offset: 0x000627CE
		internal static string EventSource_TooManyFields
		{
			get
			{
				return SR.GetResourceString("EventSource_TooManyFields");
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000645DA File Offset: 0x000627DA
		internal static string EventSource_ToString
		{
			get
			{
				return SR.GetResourceString("EventSource_ToString");
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000645E6 File Offset: 0x000627E6
		internal static string EventSource_TraitEven
		{
			get
			{
				return SR.GetResourceString("EventSource_TraitEven");
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x000645F2 File Offset: 0x000627F2
		internal static string EventSource_TypeMustBeSealedOrAbstract
		{
			get
			{
				return SR.GetResourceString("EventSource_TypeMustBeSealedOrAbstract");
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x000645FE File Offset: 0x000627FE
		internal static string EventSource_TypeMustDeriveFromEventSource
		{
			get
			{
				return SR.GetResourceString("EventSource_TypeMustDeriveFromEventSource");
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0006460A File Offset: 0x0006280A
		internal static string EventSource_UndefinedChannel
		{
			get
			{
				return SR.GetResourceString("EventSource_UndefinedChannel");
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00064616 File Offset: 0x00062816
		internal static string EventSource_UndefinedKeyword
		{
			get
			{
				return SR.GetResourceString("EventSource_UndefinedKeyword");
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00064622 File Offset: 0x00062822
		internal static string EventSource_UndefinedOpcode
		{
			get
			{
				return SR.GetResourceString("EventSource_UndefinedOpcode");
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x0006462E File Offset: 0x0006282E
		internal static string EventSource_UnknownEtwTrait
		{
			get
			{
				return SR.GetResourceString("EventSource_UnknownEtwTrait");
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0006463A File Offset: 0x0006283A
		internal static string EventSource_UnsupportedEventTypeInManifest
		{
			get
			{
				return SR.GetResourceString("EventSource_UnsupportedEventTypeInManifest");
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00064646 File Offset: 0x00062846
		internal static string EventSource_UnsupportedMessageProperty
		{
			get
			{
				return SR.GetResourceString("EventSource_UnsupportedMessageProperty");
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00064652 File Offset: 0x00062852
		internal static string EventSource_VarArgsParameterMismatch
		{
			get
			{
				return SR.GetResourceString("EventSource_VarArgsParameterMismatch");
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0006465E File Offset: 0x0006285E
		internal static string Exception_EmptyFieldForCustomAttributeType
		{
			get
			{
				return SR.GetResourceString("Exception_EmptyFieldForCustomAttributeType");
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0006466A File Offset: 0x0006286A
		internal static string Exception_EndOfInnerExceptionStack
		{
			get
			{
				return SR.GetResourceString("Exception_EndOfInnerExceptionStack");
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00064676 File Offset: 0x00062876
		internal static string Exception_EndStackTraceFromPreviousThrow
		{
			get
			{
				return SR.GetResourceString("Exception_EndStackTraceFromPreviousThrow");
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00064682 File Offset: 0x00062882
		internal static string Exception_InvalidCustomAttributeLength
		{
			get
			{
				return SR.GetResourceString("Exception_InvalidCustomAttributeLength");
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0006468E File Offset: 0x0006288E
		internal static string Exception_InvalidProlog
		{
			get
			{
				return SR.GetResourceString("Exception_InvalidProlog");
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x0006469A File Offset: 0x0006289A
		internal static string Exception_UnknownNamedType
		{
			get
			{
				return SR.GetResourceString("Exception_UnknownNamedType");
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x000646A6 File Offset: 0x000628A6
		internal static string Exception_UnknownMarshalAsAttributeField
		{
			get
			{
				return SR.GetResourceString("Exception_UnknownMarshalAsAttributeField");
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x000646B2 File Offset: 0x000628B2
		internal static string Exception_UnhandledSubType
		{
			get
			{
				return SR.GetResourceString("Exception_UnhandledSubType");
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x000646BE File Offset: 0x000628BE
		internal static string Exception_WasThrown
		{
			get
			{
				return SR.GetResourceString("Exception_WasThrown");
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x000646CA File Offset: 0x000628CA
		internal static string ExecutionContext_ExceptionInAsyncLocalNotification
		{
			get
			{
				return SR.GetResourceString("ExecutionContext_ExceptionInAsyncLocalNotification");
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x000646D6 File Offset: 0x000628D6
		internal static string FileNotFound_ResolveAssembly
		{
			get
			{
				return SR.GetResourceString("FileNotFound_ResolveAssembly");
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x000646E2 File Offset: 0x000628E2
		internal static string FileNotFound_LoadFile
		{
			get
			{
				return SR.GetResourceString("FileNotFound_LoadFile");
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000646EE File Offset: 0x000628EE
		internal static string Format_AttributeUsage
		{
			get
			{
				return SR.GetResourceString("Format_AttributeUsage");
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x000646FA File Offset: 0x000628FA
		internal static string Format_Bad7BitInt
		{
			get
			{
				return SR.GetResourceString("Format_Bad7BitInt");
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x00064706 File Offset: 0x00062906
		internal static string Format_BadBase64Char
		{
			get
			{
				return SR.GetResourceString("Format_BadBase64Char");
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00064712 File Offset: 0x00062912
		internal static string Format_BadBoolean
		{
			get
			{
				return SR.GetResourceString("Format_BadBoolean");
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x0006471E File Offset: 0x0006291E
		internal static string Format_BadDatePattern
		{
			get
			{
				return SR.GetResourceString("Format_BadDatePattern");
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x0006472A File Offset: 0x0006292A
		internal static string Format_BadDateTime
		{
			get
			{
				return SR.GetResourceString("Format_BadDateTime");
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00064736 File Offset: 0x00062936
		internal static string Format_BadDateOnly
		{
			get
			{
				return SR.GetResourceString("Format_BadDateOnly");
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00064742 File Offset: 0x00062942
		internal static string Format_BadTimeOnly
		{
			get
			{
				return SR.GetResourceString("Format_BadTimeOnly");
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0006474E File Offset: 0x0006294E
		internal static string Format_DateTimeOnlyContainsNoneDateParts
		{
			get
			{
				return SR.GetResourceString("Format_DateTimeOnlyContainsNoneDateParts");
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0006475A File Offset: 0x0006295A
		internal static string Format_BadDateTimeCalendar
		{
			get
			{
				return SR.GetResourceString("Format_BadDateTimeCalendar");
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00064766 File Offset: 0x00062966
		internal static string Format_BadDayOfWeek
		{
			get
			{
				return SR.GetResourceString("Format_BadDayOfWeek");
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00064772 File Offset: 0x00062972
		internal static string Format_BadFormatSpecifier
		{
			get
			{
				return SR.GetResourceString("Format_BadFormatSpecifier");
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x0006477E File Offset: 0x0006297E
		internal static string Format_NoFormatSpecifier
		{
			get
			{
				return SR.GetResourceString("Format_NoFormatSpecifier");
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0006478A File Offset: 0x0006298A
		internal static string Format_BadHexChar
		{
			get
			{
				return SR.GetResourceString("Format_BadHexChar");
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00064796 File Offset: 0x00062996
		internal static string Format_BadHexLength
		{
			get
			{
				return SR.GetResourceString("Format_BadHexLength");
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x000647A2 File Offset: 0x000629A2
		internal static string Format_BadQuote
		{
			get
			{
				return SR.GetResourceString("Format_BadQuote");
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x000647AE File Offset: 0x000629AE
		internal static string Format_BadTimeSpan
		{
			get
			{
				return SR.GetResourceString("Format_BadTimeSpan");
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x000647BA File Offset: 0x000629BA
		internal static string Format_DateOutOfRange
		{
			get
			{
				return SR.GetResourceString("Format_DateOutOfRange");
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x000647C6 File Offset: 0x000629C6
		internal static string Format_EmptyInputString
		{
			get
			{
				return SR.GetResourceString("Format_EmptyInputString");
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x000647D2 File Offset: 0x000629D2
		internal static string Format_ExtraJunkAtEnd
		{
			get
			{
				return SR.GetResourceString("Format_ExtraJunkAtEnd");
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x000647DE File Offset: 0x000629DE
		internal static string Format_GuidBrace
		{
			get
			{
				return SR.GetResourceString("Format_GuidBrace");
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x000647EA File Offset: 0x000629EA
		internal static string Format_GuidBraceAfterLastNumber
		{
			get
			{
				return SR.GetResourceString("Format_GuidBraceAfterLastNumber");
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x000647F6 File Offset: 0x000629F6
		internal static string Format_GuidComma
		{
			get
			{
				return SR.GetResourceString("Format_GuidComma");
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00064802 File Offset: 0x00062A02
		internal static string Format_GuidDashes
		{
			get
			{
				return SR.GetResourceString("Format_GuidDashes");
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0006480E File Offset: 0x00062A0E
		internal static string Format_GuidEndBrace
		{
			get
			{
				return SR.GetResourceString("Format_GuidEndBrace");
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x0006481A File Offset: 0x00062A1A
		internal static string Format_GuidHexPrefix
		{
			get
			{
				return SR.GetResourceString("Format_GuidHexPrefix");
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00064826 File Offset: 0x00062A26
		internal static string Format_GuidInvalidChar
		{
			get
			{
				return SR.GetResourceString("Format_GuidInvalidChar");
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00064832 File Offset: 0x00062A32
		internal static string Format_GuidInvLen
		{
			get
			{
				return SR.GetResourceString("Format_GuidInvLen");
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0006483E File Offset: 0x00062A3E
		internal static string Format_GuidUnrecognized
		{
			get
			{
				return SR.GetResourceString("Format_GuidUnrecognized");
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0006484A File Offset: 0x00062A4A
		internal static string Format_IndexOutOfRange
		{
			get
			{
				return SR.GetResourceString("Format_IndexOutOfRange");
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00064856 File Offset: 0x00062A56
		internal static string Format_InvalidEnumFormatSpecification
		{
			get
			{
				return SR.GetResourceString("Format_InvalidEnumFormatSpecification");
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00064862 File Offset: 0x00062A62
		internal static string Format_InvalidGuidFormatSpecification
		{
			get
			{
				return SR.GetResourceString("Format_InvalidGuidFormatSpecification");
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0006486E File Offset: 0x00062A6E
		internal static string Format_InvalidString
		{
			get
			{
				return SR.GetResourceString("Format_InvalidString");
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x0006487A File Offset: 0x00062A7A
		internal static string Format_InvalidStringWithValue
		{
			get
			{
				return SR.GetResourceString("Format_InvalidStringWithValue");
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00064886 File Offset: 0x00062A86
		internal static string Format_InvalidStringWithOffsetAndReason
		{
			get
			{
				return SR.GetResourceString("Format_InvalidStringWithOffsetAndReason");
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00064892 File Offset: 0x00062A92
		internal static string Format_UnexpectedClosingBrace
		{
			get
			{
				return SR.GetResourceString("Format_UnexpectedClosingBrace");
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0006489E File Offset: 0x00062A9E
		internal static string Format_UnclosedFormatItem
		{
			get
			{
				return SR.GetResourceString("Format_UnclosedFormatItem");
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x000648AA File Offset: 0x00062AAA
		internal static string Format_ExpectedAsciiDigit
		{
			get
			{
				return SR.GetResourceString("Format_ExpectedAsciiDigit");
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000648B6 File Offset: 0x00062AB6
		internal static string Format_MissingIncompleteDate
		{
			get
			{
				return SR.GetResourceString("Format_MissingIncompleteDate");
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x000648C2 File Offset: 0x00062AC2
		internal static string Format_NeedSingleChar
		{
			get
			{
				return SR.GetResourceString("Format_NeedSingleChar");
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000648CE File Offset: 0x00062ACE
		internal static string Format_NoParsibleDigits
		{
			get
			{
				return SR.GetResourceString("Format_NoParsibleDigits");
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x000648DA File Offset: 0x00062ADA
		internal static string Format_OffsetOutOfRange
		{
			get
			{
				return SR.GetResourceString("Format_OffsetOutOfRange");
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000648E6 File Offset: 0x00062AE6
		internal static string Format_RepeatDateTimePattern
		{
			get
			{
				return SR.GetResourceString("Format_RepeatDateTimePattern");
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x000648F2 File Offset: 0x00062AF2
		internal static string Format_StringZeroLength
		{
			get
			{
				return SR.GetResourceString("Format_StringZeroLength");
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000648FE File Offset: 0x00062AFE
		internal static string Format_UnknownDateTimeWord
		{
			get
			{
				return SR.GetResourceString("Format_UnknownDateTimeWord");
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0006490A File Offset: 0x00062B0A
		internal static string Format_UTCOutOfRange
		{
			get
			{
				return SR.GetResourceString("Format_UTCOutOfRange");
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00064916 File Offset: 0x00062B16
		internal static string Globalization_cp_1200
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_1200");
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00064922 File Offset: 0x00062B22
		internal static string Globalization_cp_12000
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_12000");
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0006492E File Offset: 0x00062B2E
		internal static string Globalization_cp_12001
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_12001");
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0006493A File Offset: 0x00062B3A
		internal static string Globalization_cp_1201
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_1201");
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x00064946 File Offset: 0x00062B46
		internal static string Globalization_cp_20127
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_20127");
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00064952 File Offset: 0x00062B52
		internal static string Globalization_cp_28591
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_28591");
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0006495E File Offset: 0x00062B5E
		internal static string Globalization_cp_65000
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_65000");
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x0006496A File Offset: 0x00062B6A
		internal static string Globalization_cp_65001
		{
			get
			{
				return SR.GetResourceString("Globalization_cp_65001");
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x00064976 File Offset: 0x00062B76
		internal static string IndexOutOfRange_UMSPosition
		{
			get
			{
				return SR.GetResourceString("IndexOutOfRange_UMSPosition");
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00064982 File Offset: 0x00062B82
		internal static string InsufficientMemory_MemFailPoint
		{
			get
			{
				return SR.GetResourceString("InsufficientMemory_MemFailPoint");
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0006498E File Offset: 0x00062B8E
		internal static string InsufficientMemory_MemFailPoint_TooBig
		{
			get
			{
				return SR.GetResourceString("InsufficientMemory_MemFailPoint_TooBig");
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0006499A File Offset: 0x00062B9A
		internal static string InsufficientMemory_MemFailPoint_VAFrag
		{
			get
			{
				return SR.GetResourceString("InsufficientMemory_MemFailPoint_VAFrag");
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000649A6 File Offset: 0x00062BA6
		internal static string Interop_Marshal_Unmappable_Char
		{
			get
			{
				return SR.GetResourceString("Interop_Marshal_Unmappable_Char");
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000649B2 File Offset: 0x00062BB2
		internal static string InvalidCast_CannotCastNullToValueType
		{
			get
			{
				return SR.GetResourceString("InvalidCast_CannotCastNullToValueType");
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000649BE File Offset: 0x00062BBE
		internal static string InvalidCast_DBNull
		{
			get
			{
				return SR.GetResourceString("InvalidCast_DBNull");
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000649CA File Offset: 0x00062BCA
		internal static string InvalidCast_DownCastArrayElement
		{
			get
			{
				return SR.GetResourceString("InvalidCast_DownCastArrayElement");
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000649D6 File Offset: 0x00062BD6
		internal static string InvalidCast_Empty
		{
			get
			{
				return SR.GetResourceString("InvalidCast_Empty");
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x000649E2 File Offset: 0x00062BE2
		internal static string InvalidCast_FromDBNull
		{
			get
			{
				return SR.GetResourceString("InvalidCast_FromDBNull");
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000649EE File Offset: 0x00062BEE
		internal static string InvalidCast_FromTo
		{
			get
			{
				return SR.GetResourceString("InvalidCast_FromTo");
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x000649FA File Offset: 0x00062BFA
		internal static string InvalidCast_IConvertible
		{
			get
			{
				return SR.GetResourceString("InvalidCast_IConvertible");
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x00064A06 File Offset: 0x00062C06
		internal static string InvalidOperation_AbstractMethod
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_AbstractMethod");
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x00064A12 File Offset: 0x00062C12
		internal static string InvalidOperation_AsyncFlowCtrlCtxMismatch
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_AsyncFlowCtrlCtxMismatch");
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00064A1E File Offset: 0x00062C1E
		internal static string InvalidOperation_AsyncIOInProgress
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_AsyncIOInProgress");
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00064A2A File Offset: 0x00062C2A
		internal static string InvalidOperation_BadEmptyMethodBody
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_BadEmptyMethodBody");
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00064A36 File Offset: 0x00062C36
		internal static string InvalidOperation_BadInstructionOrIndexOutOfBound
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_BadInstructionOrIndexOutOfBound");
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00064A42 File Offset: 0x00062C42
		internal static string InvalidOperation_BadInterfaceNotAbstract
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_BadInterfaceNotAbstract");
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00064A4E File Offset: 0x00062C4E
		internal static string InvalidOperation_BadInterfaceNotAbstractAndVirtual
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_BadInterfaceNotAbstractAndVirtual");
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00064A5A File Offset: 0x00062C5A
		internal static string InvalidOperation_CalledTwice
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_CalledTwice");
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x00064A66 File Offset: 0x00062C66
		internal static string InvalidOperation_CannotRegisterSecondResolver
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_CannotRegisterSecondResolver");
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00064A72 File Offset: 0x00062C72
		internal static string InvalidOperation_CannotRestoreUnsuppressedFlow
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_CannotRestoreUnsuppressedFlow");
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x00064A7E File Offset: 0x00062C7E
		internal static string InvalidOperation_CannotUseAFCOtherThread
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_CannotUseAFCOtherThread");
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x00064A8A File Offset: 0x00062C8A
		internal static string InvalidOperation_CollectionCorrupted
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_CollectionCorrupted");
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x00064A96 File Offset: 0x00062C96
		internal static string InvalidOperation_ComputerName
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ComputerName");
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00064AA2 File Offset: 0x00062CA2
		internal static string InvalidOperation_ConcurrentOperationsNotSupported
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ConcurrentOperationsNotSupported");
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00064AAE File Offset: 0x00062CAE
		internal static string InvalidOperation_DateTimeParsing
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_DateTimeParsing");
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x00064ABA File Offset: 0x00062CBA
		internal static string InvalidOperation_EnumEnded
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_EnumEnded");
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00064AC6 File Offset: 0x00062CC6
		internal static string InvalidOperation_EnumFailedVersion
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_EnumFailedVersion");
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00064AD2 File Offset: 0x00062CD2
		internal static string InvalidOperation_EnumNotStarted
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_EnumNotStarted");
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00064ADE File Offset: 0x00062CDE
		internal static string InvalidOperation_EnumOpCantHappen
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_EnumOpCantHappen");
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x00064AEA File Offset: 0x00062CEA
		internal static string InvalidOperation_GetVersion
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_GetVersion");
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00064AF6 File Offset: 0x00062CF6
		internal static string InvalidOperation_GlobalsHaveBeenCreated
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_GlobalsHaveBeenCreated");
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00064B02 File Offset: 0x00062D02
		internal static string InvalidOperation_HandleIsNotInitialized
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_HandleIsNotInitialized");
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00064B0E File Offset: 0x00062D0E
		internal static string InvalidOperation_HandleIsNotPinned
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_HandleIsNotPinned");
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00064B1A File Offset: 0x00062D1A
		internal static string InvalidOperation_InvalidUtf8
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_InvalidUtf8");
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00064B26 File Offset: 0x00062D26
		internal static string InvalidOperation_HashInsertFailed
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_HashInsertFailed");
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00064B32 File Offset: 0x00062D32
		internal static string InvalidOperation_IComparerFailed
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_IComparerFailed");
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00064B3E File Offset: 0x00062D3E
		internal static string InvalidOperation_MethodBaked
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_MethodBaked");
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00064B4A File Offset: 0x00062D4A
		internal static string InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod");
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00064B56 File Offset: 0x00062D56
		internal static string InvalidOperation_MustCallInitialize
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_MustCallInitialize");
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00064B62 File Offset: 0x00062D62
		internal static string InvalidOperation_NativeOverlappedReused
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NativeOverlappedReused");
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00064B6E File Offset: 0x00062D6E
		internal static string InvalidOperation_NoMultiModuleAssembly
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NoMultiModuleAssembly");
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00064B7A File Offset: 0x00062D7A
		internal static string InvalidOperation_NoPublicAddMethod
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NoPublicAddMethod");
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00064B86 File Offset: 0x00062D86
		internal static string InvalidOperation_NoPublicRemoveMethod
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NoPublicRemoveMethod");
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00064B92 File Offset: 0x00062D92
		internal static string InvalidOperation_NotADebugModule
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NotADebugModule");
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00064B9E File Offset: 0x00062D9E
		internal static string InvalidOperation_NotAllowedInDynamicMethod
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NotAllowedInDynamicMethod");
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00064BAA File Offset: 0x00062DAA
		internal static string InvalidOperation_NotAVarArgCallingConvention
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NotAVarArgCallingConvention");
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00064BB6 File Offset: 0x00062DB6
		internal static string InvalidOperation_NotGenericType
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NotGenericType");
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x00064BC2 File Offset: 0x00062DC2
		internal static string InvalidOperation_NotWithConcurrentGC
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NotWithConcurrentGC");
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00064BCE File Offset: 0x00062DCE
		internal static string InvalidOperation_NoValue
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NoValue");
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00064BDA File Offset: 0x00062DDA
		internal static string InvalidOperation_NullArray
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NullArray");
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00064BE6 File Offset: 0x00062DE6
		internal static string InvalidOperation_NullContext
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NullContext");
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x00064BF2 File Offset: 0x00062DF2
		internal static string InvalidOperation_Overlapped_Pack
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_Overlapped_Pack");
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00064BFE File Offset: 0x00062DFE
		internal static string InvalidOperation_ReadOnly
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ReadOnly");
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00064C0A File Offset: 0x00062E0A
		internal static string InvalidOperation_ResMgrBadResSet_Type
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ResMgrBadResSet_Type");
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00064C16 File Offset: 0x00062E16
		internal static string InvalidOperation_ResourceNotStream_Name
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ResourceNotStream_Name");
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00064C22 File Offset: 0x00062E22
		internal static string InvalidOperation_ResourceNotString_Name
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ResourceNotString_Name");
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00064C2E File Offset: 0x00062E2E
		internal static string InvalidOperation_ResourceNotString_Type
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ResourceNotString_Type");
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00064C3A File Offset: 0x00062E3A
		internal static string InvalidOperation_SetLatencyModeNoGC
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_SetLatencyModeNoGC");
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x00064C46 File Offset: 0x00062E46
		internal static string InvalidOperation_ShouldNotHaveMethodBody
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ShouldNotHaveMethodBody");
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00064C52 File Offset: 0x00062E52
		internal static string InvalidOperation_ThreadWrongThreadStart
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_ThreadWrongThreadStart");
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x00064C5E File Offset: 0x00062E5E
		internal static string InvalidOperation_TimeoutsNotSupported
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_TimeoutsNotSupported");
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00064C6A File Offset: 0x00062E6A
		internal static string InvalidOperation_TimerAlreadyClosed
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_TimerAlreadyClosed");
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00064C76 File Offset: 0x00062E76
		internal static string InvalidOperation_TypeHasBeenCreated
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_TypeHasBeenCreated");
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x00064C82 File Offset: 0x00062E82
		internal static string InvalidOperation_TypeNotCreated
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_TypeNotCreated");
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x00064C8E File Offset: 0x00062E8E
		internal static string InvalidOperation_UnderlyingArrayListChanged
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_UnderlyingArrayListChanged");
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00064C9A File Offset: 0x00062E9A
		internal static string InvalidOperation_UnknownEnumType
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_UnknownEnumType");
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00064CA6 File Offset: 0x00062EA6
		internal static string InvalidOperation_WrongAsyncResultOrEndCalledMultiple
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_WrongAsyncResultOrEndCalledMultiple");
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x00064CB2 File Offset: 0x00062EB2
		internal static string InvalidProgram_Default
		{
			get
			{
				return SR.GetResourceString("InvalidProgram_Default");
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00064CBE File Offset: 0x00062EBE
		internal static string InvariantFailed
		{
			get
			{
				return SR.GetResourceString("InvariantFailed");
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x00064CCA File Offset: 0x00062ECA
		internal static string InvariantFailed_Cnd
		{
			get
			{
				return SR.GetResourceString("InvariantFailed_Cnd");
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x00064CD6 File Offset: 0x00062ED6
		internal static string IO_NoFileTableInInMemoryAssemblies
		{
			get
			{
				return SR.GetResourceString("IO_NoFileTableInInMemoryAssemblies");
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00064CE2 File Offset: 0x00062EE2
		internal static string IO_EOF_ReadBeyondEOF
		{
			get
			{
				return SR.GetResourceString("IO_EOF_ReadBeyondEOF");
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x00064CEE File Offset: 0x00062EEE
		internal static string IO_FileLoad
		{
			get
			{
				return SR.GetResourceString("IO_FileLoad");
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00064CFA File Offset: 0x00062EFA
		internal static string IO_FileName_Name
		{
			get
			{
				return SR.GetResourceString("IO_FileName_Name");
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00064D06 File Offset: 0x00062F06
		internal static string IO_FileNotFound
		{
			get
			{
				return SR.GetResourceString("IO_FileNotFound");
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00064D12 File Offset: 0x00062F12
		internal static string IO_FileNotFound_FileName
		{
			get
			{
				return SR.GetResourceString("IO_FileNotFound_FileName");
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00064D1E File Offset: 0x00062F1E
		internal static string IO_AlreadyExists_Name
		{
			get
			{
				return SR.GetResourceString("IO_AlreadyExists_Name");
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00064D2A File Offset: 0x00062F2A
		internal static string IO_DiskFull_Path_AllocationSize
		{
			get
			{
				return SR.GetResourceString("IO_DiskFull_Path_AllocationSize");
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x00064D36 File Offset: 0x00062F36
		internal static string IO_FileTooLarge_Path_AllocationSize
		{
			get
			{
				return SR.GetResourceString("IO_FileTooLarge_Path_AllocationSize");
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00064D42 File Offset: 0x00062F42
		internal static string IO_BindHandleFailed
		{
			get
			{
				return SR.GetResourceString("IO_BindHandleFailed");
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00064D4E File Offset: 0x00062F4E
		internal static string IO_FileExists_Name
		{
			get
			{
				return SR.GetResourceString("IO_FileExists_Name");
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00064D5A File Offset: 0x00062F5A
		internal static string IO_FileTooLong2GB
		{
			get
			{
				return SR.GetResourceString("IO_FileTooLong2GB");
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00064D66 File Offset: 0x00062F66
		internal static string IO_FileTooLong
		{
			get
			{
				return SR.GetResourceString("IO_FileTooLong");
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00064D72 File Offset: 0x00062F72
		internal static string IO_FixedCapacity
		{
			get
			{
				return SR.GetResourceString("IO_FixedCapacity");
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x00064D7E File Offset: 0x00062F7E
		internal static string IO_InvalidStringLen_Len
		{
			get
			{
				return SR.GetResourceString("IO_InvalidStringLen_Len");
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00064D8A File Offset: 0x00062F8A
		internal static string IO_SeekAppendOverwrite
		{
			get
			{
				return SR.GetResourceString("IO_SeekAppendOverwrite");
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x00064D96 File Offset: 0x00062F96
		internal static string IO_SeekBeforeBegin
		{
			get
			{
				return SR.GetResourceString("IO_SeekBeforeBegin");
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x00064DA2 File Offset: 0x00062FA2
		internal static string IO_SetLengthAppendTruncate
		{
			get
			{
				return SR.GetResourceString("IO_SetLengthAppendTruncate");
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x00064DAE File Offset: 0x00062FAE
		internal static string IO_SharingViolation_File
		{
			get
			{
				return SR.GetResourceString("IO_SharingViolation_File");
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x00064DBA File Offset: 0x00062FBA
		internal static string IO_SharingViolation_NoFileName
		{
			get
			{
				return SR.GetResourceString("IO_SharingViolation_NoFileName");
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x00064DC6 File Offset: 0x00062FC6
		internal static string IO_StreamTooLong
		{
			get
			{
				return SR.GetResourceString("IO_StreamTooLong");
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00064DD2 File Offset: 0x00062FD2
		internal static string IO_PathNotFound_NoPathName
		{
			get
			{
				return SR.GetResourceString("IO_PathNotFound_NoPathName");
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00064DDE File Offset: 0x00062FDE
		internal static string IO_PathNotFound_Path
		{
			get
			{
				return SR.GetResourceString("IO_PathNotFound_Path");
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00064DEA File Offset: 0x00062FEA
		internal static string IO_PathTooLong
		{
			get
			{
				return SR.GetResourceString("IO_PathTooLong");
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x00064DF6 File Offset: 0x00062FF6
		internal static string IO_PathTooLong_Path
		{
			get
			{
				return SR.GetResourceString("IO_PathTooLong_Path");
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00064E02 File Offset: 0x00063002
		internal static string IO_UnknownFileName
		{
			get
			{
				return SR.GetResourceString("IO_UnknownFileName");
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x00064E0E File Offset: 0x0006300E
		internal static string IO_MaxAttemptsReached
		{
			get
			{
				return SR.GetResourceString("IO_MaxAttemptsReached");
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00064E1A File Offset: 0x0006301A
		internal static string Lazy_CreateValue_NoParameterlessCtorForT
		{
			get
			{
				return SR.GetResourceString("Lazy_CreateValue_NoParameterlessCtorForT");
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x00064E26 File Offset: 0x00063026
		internal static string Lazy_ctor_ModeInvalid
		{
			get
			{
				return SR.GetResourceString("Lazy_ctor_ModeInvalid");
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00064E32 File Offset: 0x00063032
		internal static string Lazy_StaticInit_InvalidOperation
		{
			get
			{
				return SR.GetResourceString("Lazy_StaticInit_InvalidOperation");
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x00064E3E File Offset: 0x0006303E
		internal static string Lazy_ToString_ValueNotCreated
		{
			get
			{
				return SR.GetResourceString("Lazy_ToString_ValueNotCreated");
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x00064E4A File Offset: 0x0006304A
		internal static string Lazy_Value_RecursiveCallsToValue
		{
			get
			{
				return SR.GetResourceString("Lazy_Value_RecursiveCallsToValue");
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x00064E56 File Offset: 0x00063056
		internal static string ManualResetEventSlim_ctor_TooManyWaiters
		{
			get
			{
				return SR.GetResourceString("ManualResetEventSlim_ctor_TooManyWaiters");
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00064E62 File Offset: 0x00063062
		internal static string MissingConstructor_Name
		{
			get
			{
				return SR.GetResourceString("MissingConstructor_Name");
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x00064E6E File Offset: 0x0006306E
		internal static string MissingField
		{
			get
			{
				return SR.GetResourceString("MissingField");
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00064E7A File Offset: 0x0006307A
		internal static string MissingField_Name
		{
			get
			{
				return SR.GetResourceString("MissingField_Name");
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x00064E86 File Offset: 0x00063086
		internal static string MissingManifestResource_MultipleBlobs
		{
			get
			{
				return SR.GetResourceString("MissingManifestResource_MultipleBlobs");
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00064E92 File Offset: 0x00063092
		internal static string MissingManifestResource_NoNeutralAsm
		{
			get
			{
				return SR.GetResourceString("MissingManifestResource_NoNeutralAsm");
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x00064E9E File Offset: 0x0006309E
		internal static string MissingManifestResource_NoNeutralDisk
		{
			get
			{
				return SR.GetResourceString("MissingManifestResource_NoNeutralDisk");
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x00064EAA File Offset: 0x000630AA
		internal static string MissingMember
		{
			get
			{
				return SR.GetResourceString("MissingMember");
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x00064EB6 File Offset: 0x000630B6
		internal static string MissingMember_Name
		{
			get
			{
				return SR.GetResourceString("MissingMember_Name");
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00064EC2 File Offset: 0x000630C2
		internal static string MissingMemberNestErr
		{
			get
			{
				return SR.GetResourceString("MissingMemberNestErr");
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00064ECE File Offset: 0x000630CE
		internal static string MissingMemberTypeRef
		{
			get
			{
				return SR.GetResourceString("MissingMemberTypeRef");
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00064EDA File Offset: 0x000630DA
		internal static string MissingMethod_Name
		{
			get
			{
				return SR.GetResourceString("MissingMethod_Name");
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x00064EE6 File Offset: 0x000630E6
		internal static string MissingSatelliteAssembly_Culture_Name
		{
			get
			{
				return SR.GetResourceString("MissingSatelliteAssembly_Culture_Name");
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00064EF2 File Offset: 0x000630F2
		internal static string MissingSatelliteAssembly_Default
		{
			get
			{
				return SR.GetResourceString("MissingSatelliteAssembly_Default");
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x00064EFE File Offset: 0x000630FE
		internal static string Multicast_Combine
		{
			get
			{
				return SR.GetResourceString("Multicast_Combine");
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00064F0A File Offset: 0x0006310A
		internal static string MustUseCCRewrite
		{
			get
			{
				return SR.GetResourceString("MustUseCCRewrite");
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00064F16 File Offset: 0x00063116
		internal static string NotSupported_AbstractNonCLS
		{
			get
			{
				return SR.GetResourceString("NotSupported_AbstractNonCLS");
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00064F22 File Offset: 0x00063122
		internal static string NotSupported_ActivAttr
		{
			get
			{
				return SR.GetResourceString("NotSupported_ActivAttr");
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x00064F2E File Offset: 0x0006312E
		internal static string NotSupported_AssemblyLoadFromHash
		{
			get
			{
				return SR.GetResourceString("NotSupported_AssemblyLoadFromHash");
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00064F3A File Offset: 0x0006313A
		internal static string NotSupported_ByRefLike
		{
			get
			{
				return SR.GetResourceString("NotSupported_ByRefLike");
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00064F46 File Offset: 0x00063146
		internal static string NotSupported_ByRefToByRefLikeReturn
		{
			get
			{
				return SR.GetResourceString("NotSupported_ByRefToByRefLikeReturn");
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00064F52 File Offset: 0x00063152
		internal static string NotSupported_ByRefToVoidReturn
		{
			get
			{
				return SR.GetResourceString("NotSupported_ByRefToVoidReturn");
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x00064F5E File Offset: 0x0006315E
		internal static string NotSupported_CallToVarArg
		{
			get
			{
				return SR.GetResourceString("NotSupported_CallToVarArg");
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00064F6A File Offset: 0x0006316A
		internal static string NotSupported_CannotCallEqualsOnSpan
		{
			get
			{
				return SR.GetResourceString("NotSupported_CannotCallEqualsOnSpan");
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x00064F76 File Offset: 0x00063176
		internal static string NotSupported_CannotCallGetHashCodeOnSpan
		{
			get
			{
				return SR.GetResourceString("NotSupported_CannotCallGetHashCodeOnSpan");
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00064F82 File Offset: 0x00063182
		internal static string NotSupported_ChangeType
		{
			get
			{
				return SR.GetResourceString("NotSupported_ChangeType");
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x00064F8E File Offset: 0x0006318E
		internal static string NotSupported_ContainsStackPtr
		{
			get
			{
				return SR.GetResourceString("NotSupported_ContainsStackPtr");
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x00064F9A File Offset: 0x0006319A
		internal static string NotSupported_CreateInstanceWithTypeBuilder
		{
			get
			{
				return SR.GetResourceString("NotSupported_CreateInstanceWithTypeBuilder");
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x00064FA6 File Offset: 0x000631A6
		internal static string NotSupported_DynamicAssembly
		{
			get
			{
				return SR.GetResourceString("NotSupported_DynamicAssembly");
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x00064FB2 File Offset: 0x000631B2
		internal static string NotSupported_DynamicMethodFlags
		{
			get
			{
				return SR.GetResourceString("NotSupported_DynamicMethodFlags");
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x00064FBE File Offset: 0x000631BE
		internal static string NotSupported_DynamicModule
		{
			get
			{
				return SR.GetResourceString("NotSupported_DynamicModule");
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00064FCA File Offset: 0x000631CA
		internal static string NotSupported_FixedSizeCollection
		{
			get
			{
				return SR.GetResourceString("NotSupported_FixedSizeCollection");
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00064FD6 File Offset: 0x000631D6
		internal static string InvalidOperation_SpanOverlappedOperation
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_SpanOverlappedOperation");
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00064FE2 File Offset: 0x000631E2
		internal static string InvalidOperation_TimeProviderNullLocalTimeZone
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_TimeProviderNullLocalTimeZone");
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00064FEE File Offset: 0x000631EE
		internal static string InvalidOperation_TimeProviderInvalidTimestampFrequency
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_TimeProviderInvalidTimestampFrequency");
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x00064FFA File Offset: 0x000631FA
		internal static string NotSupported_KeyCollectionSet
		{
			get
			{
				return SR.GetResourceString("NotSupported_KeyCollectionSet");
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00065006 File Offset: 0x00063206
		internal static string NotSupported_MaxWaitHandles
		{
			get
			{
				return SR.GetResourceString("NotSupported_MaxWaitHandles");
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x00065012 File Offset: 0x00063212
		internal static string NotSupported_MemStreamNotExpandable
		{
			get
			{
				return SR.GetResourceString("NotSupported_MemStreamNotExpandable");
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0006501E File Offset: 0x0006321E
		internal static string NotSupported_MustBeModuleBuilder
		{
			get
			{
				return SR.GetResourceString("NotSupported_MustBeModuleBuilder");
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0006502A File Offset: 0x0006322A
		internal static string NotSupported_NoCodepageData
		{
			get
			{
				return SR.GetResourceString("NotSupported_NoCodepageData");
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x00065036 File Offset: 0x00063236
		internal static string InvalidOperation_FunctionMissingUnmanagedCallersOnly
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_FunctionMissingUnmanagedCallersOnly");
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x00065042 File Offset: 0x00063242
		internal static string NotSupported_NonReflectedType
		{
			get
			{
				return SR.GetResourceString("NotSupported_NonReflectedType");
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0006504E File Offset: 0x0006324E
		internal static string NotImplemented_NoSupportForModOpt
		{
			get
			{
				return SR.GetResourceString("NotImplemented_NoSupportForModOpt");
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0006505A File Offset: 0x0006325A
		internal static string NotSupported_NoParentDefaultConstructor
		{
			get
			{
				return SR.GetResourceString("NotSupported_NoParentDefaultConstructor");
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x00065066 File Offset: 0x00063266
		internal static string NotSupported_NoTypeInfo
		{
			get
			{
				return SR.GetResourceString("NotSupported_NoTypeInfo");
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x00065072 File Offset: 0x00063272
		internal static string NotSupported_NYI
		{
			get
			{
				return SR.GetResourceString("NotSupported_NYI");
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0006507E File Offset: 0x0006327E
		internal static string NotSupported_ObsoleteResourcesFile
		{
			get
			{
				return SR.GetResourceString("NotSupported_ObsoleteResourcesFile");
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x0006508A File Offset: 0x0006328A
		internal static string NotSupported_OutputStreamUsingTypeBuilder
		{
			get
			{
				return SR.GetResourceString("NotSupported_OutputStreamUsingTypeBuilder");
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x00065096 File Offset: 0x00063296
		internal static string NotSupported_RangeCollection
		{
			get
			{
				return SR.GetResourceString("NotSupported_RangeCollection");
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x000650A2 File Offset: 0x000632A2
		internal static string NotSupported_Reading
		{
			get
			{
				return SR.GetResourceString("NotSupported_Reading");
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x000650AE File Offset: 0x000632AE
		internal static string NotSupported_ReadOnlyCollection
		{
			get
			{
				return SR.GetResourceString("NotSupported_ReadOnlyCollection");
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x000650BA File Offset: 0x000632BA
		internal static string NotSupported_ResourceObjectSerialization
		{
			get
			{
				return SR.GetResourceString("NotSupported_ResourceObjectSerialization");
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x000650C6 File Offset: 0x000632C6
		internal static string NotSupported_StringComparison
		{
			get
			{
				return SR.GetResourceString("NotSupported_StringComparison");
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x000650D2 File Offset: 0x000632D2
		internal static string NotSupported_SubclassOverride
		{
			get
			{
				return SR.GetResourceString("NotSupported_SubclassOverride");
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000650DE File Offset: 0x000632DE
		internal static string NotSupported_Type
		{
			get
			{
				return SR.GetResourceString("NotSupported_Type");
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x000650EA File Offset: 0x000632EA
		internal static string NotSupported_UmsSafeBuffer
		{
			get
			{
				return SR.GetResourceString("NotSupported_UmsSafeBuffer");
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000650F6 File Offset: 0x000632F6
		internal static string NotSupported_UnitySerHolder
		{
			get
			{
				return SR.GetResourceString("NotSupported_UnitySerHolder");
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x00065102 File Offset: 0x00063302
		internal static string NotSupported_UnreadableStream
		{
			get
			{
				return SR.GetResourceString("NotSupported_UnreadableStream");
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0006510E File Offset: 0x0006330E
		internal static string NotSupported_UnseekableStream
		{
			get
			{
				return SR.GetResourceString("NotSupported_UnseekableStream");
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x0006511A File Offset: 0x0006331A
		internal static string NotSupported_UnwritableStream
		{
			get
			{
				return SR.GetResourceString("NotSupported_UnwritableStream");
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00065126 File Offset: 0x00063326
		internal static string NotSupported_ValueCollectionSet
		{
			get
			{
				return SR.GetResourceString("NotSupported_ValueCollectionSet");
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x00065132 File Offset: 0x00063332
		internal static string NotSupported_Writing
		{
			get
			{
				return SR.GetResourceString("NotSupported_Writing");
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0006513E File Offset: 0x0006333E
		internal static string NotSupported_WrongResourceReader_Type
		{
			get
			{
				return SR.GetResourceString("NotSupported_WrongResourceReader_Type");
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x0006514A File Offset: 0x0006334A
		internal static string ObjectDisposed_FileClosed
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_FileClosed");
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00065156 File Offset: 0x00063356
		internal static string ObjectDisposed_Generic
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_Generic");
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00065162 File Offset: 0x00063362
		internal static string ObjectDisposed_ObjectName_Name
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_ObjectName_Name");
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0006516E File Offset: 0x0006336E
		internal static string ObjectDisposed_WriterClosed
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_WriterClosed");
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0006517A File Offset: 0x0006337A
		internal static string ObjectDisposed_ReaderClosed
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_ReaderClosed");
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x00065186 File Offset: 0x00063386
		internal static string ObjectDisposed_ResourceSet
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_ResourceSet");
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x00065192 File Offset: 0x00063392
		internal static string ObjectDisposed_StreamClosed
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_StreamClosed");
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0006519E File Offset: 0x0006339E
		internal static string ObjectDisposed_ViewAccessorClosed
		{
			get
			{
				return SR.GetResourceString("ObjectDisposed_ViewAccessorClosed");
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000651AA File Offset: 0x000633AA
		internal static string OperationCanceled
		{
			get
			{
				return SR.GetResourceString("OperationCanceled");
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x000651B6 File Offset: 0x000633B6
		internal static string Overflow_Byte
		{
			get
			{
				return SR.GetResourceString("Overflow_Byte");
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x000651C2 File Offset: 0x000633C2
		internal static string Overflow_Char
		{
			get
			{
				return SR.GetResourceString("Overflow_Char");
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x000651CE File Offset: 0x000633CE
		internal static string Overflow_Currency
		{
			get
			{
				return SR.GetResourceString("Overflow_Currency");
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x000651DA File Offset: 0x000633DA
		internal static string Overflow_Decimal
		{
			get
			{
				return SR.GetResourceString("Overflow_Decimal");
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x000651E6 File Offset: 0x000633E6
		internal static string Overflow_Duration
		{
			get
			{
				return SR.GetResourceString("Overflow_Duration");
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x000651F2 File Offset: 0x000633F2
		internal static string Overflow_Int16
		{
			get
			{
				return SR.GetResourceString("Overflow_Int16");
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x000651FE File Offset: 0x000633FE
		internal static string Overflow_Int32
		{
			get
			{
				return SR.GetResourceString("Overflow_Int32");
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0006520A File Offset: 0x0006340A
		internal static string Overflow_Int64
		{
			get
			{
				return SR.GetResourceString("Overflow_Int64");
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00065216 File Offset: 0x00063416
		internal static string Overflow_Int128
		{
			get
			{
				return SR.GetResourceString("Overflow_Int128");
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x00065222 File Offset: 0x00063422
		internal static string Overflow_MutexReacquireCount
		{
			get
			{
				return SR.GetResourceString("Overflow_MutexReacquireCount");
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0006522E File Offset: 0x0006342E
		internal static string Overflow_NegateTwosCompNum
		{
			get
			{
				return SR.GetResourceString("Overflow_NegateTwosCompNum");
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0006523A File Offset: 0x0006343A
		internal static string Overflow_NegativeUnsigned
		{
			get
			{
				return SR.GetResourceString("Overflow_NegativeUnsigned");
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x00065246 File Offset: 0x00063446
		internal static string Overflow_SByte
		{
			get
			{
				return SR.GetResourceString("Overflow_SByte");
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x00065252 File Offset: 0x00063452
		internal static string Overflow_TimeSpanElementTooLarge
		{
			get
			{
				return SR.GetResourceString("Overflow_TimeSpanElementTooLarge");
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0006525E File Offset: 0x0006345E
		internal static string Overflow_TimeSpanTooLong
		{
			get
			{
				return SR.GetResourceString("Overflow_TimeSpanTooLong");
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0006526A File Offset: 0x0006346A
		internal static string Overflow_UInt16
		{
			get
			{
				return SR.GetResourceString("Overflow_UInt16");
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x00065276 File Offset: 0x00063476
		internal static string Overflow_UInt32
		{
			get
			{
				return SR.GetResourceString("Overflow_UInt32");
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00065282 File Offset: 0x00063482
		internal static string Overflow_UInt64
		{
			get
			{
				return SR.GetResourceString("Overflow_UInt64");
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0006528E File Offset: 0x0006348E
		internal static string Overflow_UInt128
		{
			get
			{
				return SR.GetResourceString("Overflow_UInt128");
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0006529A File Offset: 0x0006349A
		internal static string PlatformNotSupported_ComInterop
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_ComInterop");
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x000652A6 File Offset: 0x000634A6
		internal static string PlatformNotSupported_ReflectionOnly
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_ReflectionOnly");
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000652B2 File Offset: 0x000634B2
		internal static string PlatformNotSupported_Remoting
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_Remoting");
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x000652BE File Offset: 0x000634BE
		internal static string PlatformNotSupported_SecureBinarySerialization
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_SecureBinarySerialization");
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x000652CA File Offset: 0x000634CA
		internal static string PlatformNotSupported_StrongNameSigning
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_StrongNameSigning");
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x000652D6 File Offset: 0x000634D6
		internal static string PlatformNotSupported_UnixFileMode
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_UnixFileMode");
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x000652E2 File Offset: 0x000634E2
		internal static string PlatformNotSupported_AppDomains
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_AppDomains");
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x000652EE File Offset: 0x000634EE
		internal static string PlatformNotSupported_CAS
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_CAS");
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x000652FA File Offset: 0x000634FA
		internal static string PlatformNotSupported_Principal
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_Principal");
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x00065306 File Offset: 0x00063506
		internal static string PlatformNotSupported_ThreadAbort
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_ThreadAbort");
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00065312 File Offset: 0x00063512
		internal static string PlatformNotSupported_ThreadSuspend
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_ThreadSuspend");
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0006531E File Offset: 0x0006351E
		internal static string PlatformNotSupported_UserDefinedSubclassesOfType
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_UserDefinedSubclassesOfType");
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x0006532A File Offset: 0x0006352A
		internal static string PostconditionFailed
		{
			get
			{
				return SR.GetResourceString("PostconditionFailed");
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x00065336 File Offset: 0x00063536
		internal static string PostconditionFailed_Cnd
		{
			get
			{
				return SR.GetResourceString("PostconditionFailed_Cnd");
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00065342 File Offset: 0x00063542
		internal static string PostconditionOnExceptionFailed
		{
			get
			{
				return SR.GetResourceString("PostconditionOnExceptionFailed");
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0006534E File Offset: 0x0006354E
		internal static string PostconditionOnExceptionFailed_Cnd
		{
			get
			{
				return SR.GetResourceString("PostconditionOnExceptionFailed_Cnd");
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x0006535A File Offset: 0x0006355A
		internal static string PreconditionFailed
		{
			get
			{
				return SR.GetResourceString("PreconditionFailed");
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x00065366 File Offset: 0x00063566
		internal static string PreconditionFailed_Cnd
		{
			get
			{
				return SR.GetResourceString("PreconditionFailed_Cnd");
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00065372 File Offset: 0x00063572
		internal static string Rank_MultiDimNotSupported
		{
			get
			{
				return SR.GetResourceString("Rank_MultiDimNotSupported");
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0006537E File Offset: 0x0006357E
		internal static string ResourceReaderIsClosed
		{
			get
			{
				return SR.GetResourceString("ResourceReaderIsClosed");
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x0006538A File Offset: 0x0006358A
		internal static string Resources_StreamNotValid
		{
			get
			{
				return SR.GetResourceString("Resources_StreamNotValid");
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00065396 File Offset: 0x00063596
		internal static string InvalidFilterCriteriaException_CritInt
		{
			get
			{
				return SR.GetResourceString("InvalidFilterCriteriaException_CritInt");
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x000653A2 File Offset: 0x000635A2
		internal static string InvalidFilterCriteriaException_CritString
		{
			get
			{
				return SR.GetResourceString("InvalidFilterCriteriaException_CritString");
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x000653AE File Offset: 0x000635AE
		internal static string RFLCT_Targ_ITargMismatch_WithType
		{
			get
			{
				return SR.GetResourceString("RFLCT_Targ_ITargMismatch_WithType");
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x000653BA File Offset: 0x000635BA
		internal static string RFLCT_Targ_StatFldReqTarg
		{
			get
			{
				return SR.GetResourceString("RFLCT_Targ_StatFldReqTarg");
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x000653C6 File Offset: 0x000635C6
		internal static string RFLCT_Targ_StatMethReqTarg
		{
			get
			{
				return SR.GetResourceString("RFLCT_Targ_StatMethReqTarg");
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x000653D2 File Offset: 0x000635D2
		internal static string RuntimeInstanceNotAllowed
		{
			get
			{
				return SR.GetResourceString("RuntimeInstanceNotAllowed");
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000653DE File Offset: 0x000635DE
		internal static string RuntimeWrappedException
		{
			get
			{
				return SR.GetResourceString("RuntimeWrappedException");
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x000653EA File Offset: 0x000635EA
		internal static string StandardOleMarshalObjectGetMarshalerFailed
		{
			get
			{
				return SR.GetResourceString("StandardOleMarshalObjectGetMarshalerFailed");
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000653F6 File Offset: 0x000635F6
		internal static string Security_CannotReadFileData
		{
			get
			{
				return SR.GetResourceString("Security_CannotReadFileData");
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x00065402 File Offset: 0x00063602
		internal static string Security_RegistryPermission
		{
			get
			{
				return SR.GetResourceString("Security_RegistryPermission");
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0006540E File Offset: 0x0006360E
		internal static string SemaphoreSlim_ctor_InitialCountWrong
		{
			get
			{
				return SR.GetResourceString("SemaphoreSlim_ctor_InitialCountWrong");
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x0006541A File Offset: 0x0006361A
		internal static string SemaphoreSlim_ctor_MaxCountWrong
		{
			get
			{
				return SR.GetResourceString("SemaphoreSlim_ctor_MaxCountWrong");
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x00065426 File Offset: 0x00063626
		internal static string SemaphoreSlim_Release_CountWrong
		{
			get
			{
				return SR.GetResourceString("SemaphoreSlim_Release_CountWrong");
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x00065432 File Offset: 0x00063632
		internal static string SemaphoreSlim_Wait_TimeoutWrong
		{
			get
			{
				return SR.GetResourceString("SemaphoreSlim_Wait_TimeoutWrong");
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0006543E File Offset: 0x0006363E
		internal static string Serialization_BadParameterInfo
		{
			get
			{
				return SR.GetResourceString("Serialization_BadParameterInfo");
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0006544A File Offset: 0x0006364A
		internal static string Serialization_CorruptField
		{
			get
			{
				return SR.GetResourceString("Serialization_CorruptField");
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x00065456 File Offset: 0x00063656
		internal static string Serialization_DateTimeTicksOutOfRange
		{
			get
			{
				return SR.GetResourceString("Serialization_DateTimeTicksOutOfRange");
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x00065462 File Offset: 0x00063662
		internal static string Serialization_DelegatesNotSupported
		{
			get
			{
				return SR.GetResourceString("Serialization_DelegatesNotSupported");
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0006546E File Offset: 0x0006366E
		internal static string Serialization_InsufficientState
		{
			get
			{
				return SR.GetResourceString("Serialization_InsufficientState");
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x0006547A File Offset: 0x0006367A
		internal static string Serialization_InvalidData
		{
			get
			{
				return SR.GetResourceString("Serialization_InvalidData");
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x00065486 File Offset: 0x00063686
		internal static string Serialization_InvalidEscapeSequence
		{
			get
			{
				return SR.GetResourceString("Serialization_InvalidEscapeSequence");
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x00065492 File Offset: 0x00063692
		internal static string Serialization_InvalidOnDeser
		{
			get
			{
				return SR.GetResourceString("Serialization_InvalidOnDeser");
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0006549E File Offset: 0x0006369E
		internal static string Serialization_InvalidType
		{
			get
			{
				return SR.GetResourceString("Serialization_InvalidType");
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000654AA File Offset: 0x000636AA
		internal static string Serialization_KeyValueDifferentSizes
		{
			get
			{
				return SR.GetResourceString("Serialization_KeyValueDifferentSizes");
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000654B6 File Offset: 0x000636B6
		internal static string Serialization_MissingDateTimeData
		{
			get
			{
				return SR.GetResourceString("Serialization_MissingDateTimeData");
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000654C2 File Offset: 0x000636C2
		internal static string Serialization_MissingKeys
		{
			get
			{
				return SR.GetResourceString("Serialization_MissingKeys");
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000654CE File Offset: 0x000636CE
		internal static string Serialization_MissingValues
		{
			get
			{
				return SR.GetResourceString("Serialization_MissingValues");
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x000654DA File Offset: 0x000636DA
		internal static string Serialization_NoParameterInfo
		{
			get
			{
				return SR.GetResourceString("Serialization_NoParameterInfo");
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000654E6 File Offset: 0x000636E6
		internal static string Serialization_NotFound
		{
			get
			{
				return SR.GetResourceString("Serialization_NotFound");
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000654F2 File Offset: 0x000636F2
		internal static string Serialization_NullKey
		{
			get
			{
				return SR.GetResourceString("Serialization_NullKey");
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000654FE File Offset: 0x000636FE
		internal static string Serialization_OptionalFieldVersionValue
		{
			get
			{
				return SR.GetResourceString("Serialization_OptionalFieldVersionValue");
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0006550A File Offset: 0x0006370A
		internal static string Serialization_SameNameTwice
		{
			get
			{
				return SR.GetResourceString("Serialization_SameNameTwice");
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00065516 File Offset: 0x00063716
		internal static string Serialization_StringBuilderCapacity
		{
			get
			{
				return SR.GetResourceString("Serialization_StringBuilderCapacity");
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00065522 File Offset: 0x00063722
		internal static string Serialization_StringBuilderMaxCapacity
		{
			get
			{
				return SR.GetResourceString("Serialization_StringBuilderMaxCapacity");
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0006552E File Offset: 0x0006372E
		internal static string SetterHasNoParams
		{
			get
			{
				return SR.GetResourceString("SetterHasNoParams");
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0006553A File Offset: 0x0006373A
		internal static string Lock_Enter_LockRecursionException
		{
			get
			{
				return SR.GetResourceString("Lock_Enter_LockRecursionException");
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00065546 File Offset: 0x00063746
		internal static string Lock_Enter_WaiterCountOverflow_OutOfMemoryException
		{
			get
			{
				return SR.GetResourceString("Lock_Enter_WaiterCountOverflow_OutOfMemoryException");
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00065552 File Offset: 0x00063752
		internal static string Lock_Exit_SynchronizationLockException
		{
			get
			{
				return SR.GetResourceString("Lock_Exit_SynchronizationLockException");
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0006555E File Offset: 0x0006375E
		internal static string SpinLock_IsHeldByCurrentThread
		{
			get
			{
				return SR.GetResourceString("SpinLock_IsHeldByCurrentThread");
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0006556A File Offset: 0x0006376A
		internal static string SpinLock_TryEnter_ArgumentOutOfRange
		{
			get
			{
				return SR.GetResourceString("SpinLock_TryEnter_ArgumentOutOfRange");
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x00065576 File Offset: 0x00063776
		internal static string SpinLock_TryEnter_LockRecursionException
		{
			get
			{
				return SR.GetResourceString("SpinLock_TryEnter_LockRecursionException");
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x00065582 File Offset: 0x00063782
		internal static string SpinLock_TryReliableEnter_ArgumentException
		{
			get
			{
				return SR.GetResourceString("SpinLock_TryReliableEnter_ArgumentException");
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0006558E File Offset: 0x0006378E
		internal static string SpinWait_SpinUntil_TimeoutWrong
		{
			get
			{
				return SR.GetResourceString("SpinWait_SpinUntil_TimeoutWrong");
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0006559A File Offset: 0x0006379A
		internal static string StackTrace_InFileILOffset
		{
			get
			{
				return SR.GetResourceString("StackTrace_InFileILOffset");
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000655A6 File Offset: 0x000637A6
		internal static string StackTrace_InFileLineNumber
		{
			get
			{
				return SR.GetResourceString("StackTrace_InFileLineNumber");
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x000655B2 File Offset: 0x000637B2
		internal static string TargetInvocation_MethodCannotBeInvoked
		{
			get
			{
				return SR.GetResourceString("TargetInvocation_MethodCannotBeInvoked");
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000655BE File Offset: 0x000637BE
		internal static string Task_ContinueWith_ESandLR
		{
			get
			{
				return SR.GetResourceString("Task_ContinueWith_ESandLR");
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000655CA File Offset: 0x000637CA
		internal static string Task_ContinueWith_NotOnAnything
		{
			get
			{
				return SR.GetResourceString("Task_ContinueWith_NotOnAnything");
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x000655D6 File Offset: 0x000637D6
		internal static string Task_InvalidTimerTimeSpan
		{
			get
			{
				return SR.GetResourceString("Task_InvalidTimerTimeSpan");
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000655E2 File Offset: 0x000637E2
		internal static string Task_Delay_InvalidMillisecondsDelay
		{
			get
			{
				return SR.GetResourceString("Task_Delay_InvalidMillisecondsDelay");
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000655EE File Offset: 0x000637EE
		internal static string Task_Dispose_NotCompleted
		{
			get
			{
				return SR.GetResourceString("Task_Dispose_NotCompleted");
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000655FA File Offset: 0x000637FA
		internal static string Task_FromAsync_LongRunning
		{
			get
			{
				return SR.GetResourceString("Task_FromAsync_LongRunning");
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x00065606 File Offset: 0x00063806
		internal static string Task_FromAsync_PreferFairness
		{
			get
			{
				return SR.GetResourceString("Task_FromAsync_PreferFairness");
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x00065612 File Offset: 0x00063812
		internal static string Task_MultiTaskContinuation_EmptyTaskList
		{
			get
			{
				return SR.GetResourceString("Task_MultiTaskContinuation_EmptyTaskList");
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0006561E File Offset: 0x0006381E
		internal static string Task_MultiTaskContinuation_FireOptions
		{
			get
			{
				return SR.GetResourceString("Task_MultiTaskContinuation_FireOptions");
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0006562A File Offset: 0x0006382A
		internal static string Task_MultiTaskContinuation_NullTask
		{
			get
			{
				return SR.GetResourceString("Task_MultiTaskContinuation_NullTask");
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x00065636 File Offset: 0x00063836
		internal static string Task_RunSynchronously_AlreadyStarted
		{
			get
			{
				return SR.GetResourceString("Task_RunSynchronously_AlreadyStarted");
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00065642 File Offset: 0x00063842
		internal static string Task_RunSynchronously_Continuation
		{
			get
			{
				return SR.GetResourceString("Task_RunSynchronously_Continuation");
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0006564E File Offset: 0x0006384E
		internal static string Task_RunSynchronously_Promise
		{
			get
			{
				return SR.GetResourceString("Task_RunSynchronously_Promise");
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0006565A File Offset: 0x0006385A
		internal static string Task_RunSynchronously_TaskCompleted
		{
			get
			{
				return SR.GetResourceString("Task_RunSynchronously_TaskCompleted");
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x00065666 File Offset: 0x00063866
		internal static string Task_Start_AlreadyStarted
		{
			get
			{
				return SR.GetResourceString("Task_Start_AlreadyStarted");
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00065672 File Offset: 0x00063872
		internal static string Task_Start_ContinuationTask
		{
			get
			{
				return SR.GetResourceString("Task_Start_ContinuationTask");
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0006567E File Offset: 0x0006387E
		internal static string Task_Start_Promise
		{
			get
			{
				return SR.GetResourceString("Task_Start_Promise");
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0006568A File Offset: 0x0006388A
		internal static string Task_Start_TaskCompleted
		{
			get
			{
				return SR.GetResourceString("Task_Start_TaskCompleted");
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x00065696 File Offset: 0x00063896
		internal static string Task_ThrowIfDisposed
		{
			get
			{
				return SR.GetResourceString("Task_ThrowIfDisposed");
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000656A2 File Offset: 0x000638A2
		internal static string Task_WaitMulti_NullTask
		{
			get
			{
				return SR.GetResourceString("Task_WaitMulti_NullTask");
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x000656AE File Offset: 0x000638AE
		internal static string Task_MustBeCompleted
		{
			get
			{
				return SR.GetResourceString("Task_MustBeCompleted");
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000656BA File Offset: 0x000638BA
		internal static string TaskT_ConfigureAwait_InvalidOptions
		{
			get
			{
				return SR.GetResourceString("TaskT_ConfigureAwait_InvalidOptions");
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x000656C6 File Offset: 0x000638C6
		internal static string TaskCanceledException_ctor_DefaultMessage
		{
			get
			{
				return SR.GetResourceString("TaskCanceledException_ctor_DefaultMessage");
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000656D2 File Offset: 0x000638D2
		internal static string TaskCompletionSourceT_TrySetException_NoExceptions
		{
			get
			{
				return SR.GetResourceString("TaskCompletionSourceT_TrySetException_NoExceptions");
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x000656DE File Offset: 0x000638DE
		internal static string TaskCompletionSourceT_TrySetException_NullException
		{
			get
			{
				return SR.GetResourceString("TaskCompletionSourceT_TrySetException_NullException");
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000656EA File Offset: 0x000638EA
		internal static string TaskExceptionHolder_UnhandledException
		{
			get
			{
				return SR.GetResourceString("TaskExceptionHolder_UnhandledException");
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x000656F6 File Offset: 0x000638F6
		internal static string TaskExceptionHolder_UnknownExceptionType
		{
			get
			{
				return SR.GetResourceString("TaskExceptionHolder_UnknownExceptionType");
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00065702 File Offset: 0x00063902
		internal static string TaskScheduler_ExecuteTask_WrongTaskScheduler
		{
			get
			{
				return SR.GetResourceString("TaskScheduler_ExecuteTask_WrongTaskScheduler");
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0006570E File Offset: 0x0006390E
		internal static string TaskScheduler_FromCurrentSynchronizationContext_NoCurrent
		{
			get
			{
				return SR.GetResourceString("TaskScheduler_FromCurrentSynchronizationContext_NoCurrent");
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0006571A File Offset: 0x0006391A
		internal static string TaskScheduler_InconsistentStateAfterTryExecuteTaskInline
		{
			get
			{
				return SR.GetResourceString("TaskScheduler_InconsistentStateAfterTryExecuteTaskInline");
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x00065726 File Offset: 0x00063926
		internal static string TaskSchedulerException_ctor_DefaultMessage
		{
			get
			{
				return SR.GetResourceString("TaskSchedulerException_ctor_DefaultMessage");
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00065732 File Offset: 0x00063932
		internal static string TaskT_DebuggerNoResult
		{
			get
			{
				return SR.GetResourceString("TaskT_DebuggerNoResult");
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0006573E File Offset: 0x0006393E
		internal static string TaskT_TransitionToFinal_AlreadyCompleted
		{
			get
			{
				return SR.GetResourceString("TaskT_TransitionToFinal_AlreadyCompleted");
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0006574A File Offset: 0x0006394A
		internal static string Thread_GetSetCompressedStack_NotSupported
		{
			get
			{
				return SR.GetResourceString("Thread_GetSetCompressedStack_NotSupported");
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x00065756 File Offset: 0x00063956
		internal static string Thread_Operation_RequiresCurrentThread
		{
			get
			{
				return SR.GetResourceString("Thread_Operation_RequiresCurrentThread");
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00065762 File Offset: 0x00063962
		internal static string Threading_AbandonedMutexException
		{
			get
			{
				return SR.GetResourceString("Threading_AbandonedMutexException");
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0006576E File Offset: 0x0006396E
		internal static string Threading_WaitHandleCannotBeOpenedException
		{
			get
			{
				return SR.GetResourceString("Threading_WaitHandleCannotBeOpenedException");
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x0006577A File Offset: 0x0006397A
		internal static string Threading_WaitHandleCannotBeOpenedException_InvalidHandle
		{
			get
			{
				return SR.GetResourceString("Threading_WaitHandleCannotBeOpenedException_InvalidHandle");
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x00065786 File Offset: 0x00063986
		internal static string Threading_WaitHandleTooManyPosts
		{
			get
			{
				return SR.GetResourceString("Threading_WaitHandleTooManyPosts");
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x00065792 File Offset: 0x00063992
		internal static string Threading_SemaphoreFullException
		{
			get
			{
				return SR.GetResourceString("Threading_SemaphoreFullException");
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0006579E File Offset: 0x0006399E
		internal static string Threading_ThreadInterrupted
		{
			get
			{
				return SR.GetResourceString("Threading_ThreadInterrupted");
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000657AA File Offset: 0x000639AA
		internal static string ThreadLocal_Value_RecursiveCallsToValue
		{
			get
			{
				return SR.GetResourceString("ThreadLocal_Value_RecursiveCallsToValue");
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000657B6 File Offset: 0x000639B6
		internal static string ThreadLocal_ValuesNotAvailable
		{
			get
			{
				return SR.GetResourceString("ThreadLocal_ValuesNotAvailable");
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x000657C2 File Offset: 0x000639C2
		internal static string TimeZoneNotFound_MissingData
		{
			get
			{
				return SR.GetResourceString("TimeZoneNotFound_MissingData");
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000657CE File Offset: 0x000639CE
		internal static string TypeInitialization_Default
		{
			get
			{
				return SR.GetResourceString("TypeInitialization_Default");
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000657DA File Offset: 0x000639DA
		internal static string TypeInitialization_Type
		{
			get
			{
				return SR.GetResourceString("TypeInitialization_Type");
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000657E6 File Offset: 0x000639E6
		internal static string TypeLoad_AssemblyEnumContainsMethodsError
		{
			get
			{
				return SR.GetResourceString("TypeLoad_AssemblyEnumContainsMethodsError");
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000657F2 File Offset: 0x000639F2
		internal static string TypeLoad_AssemblyInaccessibleInterfaceError
		{
			get
			{
				return SR.GetResourceString("TypeLoad_AssemblyInaccessibleInterfaceError");
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000657FE File Offset: 0x000639FE
		internal static string TypeLoad_AssemblySealedParentTypeError
		{
			get
			{
				return SR.GetResourceString("TypeLoad_AssemblySealedParentTypeError");
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0006580A File Offset: 0x00063A0A
		internal static string TypeLoad_ResolveNestedType
		{
			get
			{
				return SR.GetResourceString("TypeLoad_ResolveNestedType");
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x00065816 File Offset: 0x00063A16
		internal static string TypeLoad_ResolveType
		{
			get
			{
				return SR.GetResourceString("TypeLoad_ResolveType");
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00065822 File Offset: 0x00063A22
		internal static string TypeLoad_ResolveTypeFromAssembly
		{
			get
			{
				return SR.GetResourceString("TypeLoad_ResolveTypeFromAssembly");
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0006582E File Offset: 0x00063A2E
		internal static string UnauthorizedAccess_IODenied_NoPathName
		{
			get
			{
				return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName");
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0006583A File Offset: 0x00063A3A
		internal static string UnauthorizedAccess_IODenied_Path
		{
			get
			{
				return SR.GetResourceString("UnauthorizedAccess_IODenied_Path");
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x00065846 File Offset: 0x00063A46
		internal static string UnauthorizedAccess_MemStreamBuffer
		{
			get
			{
				return SR.GetResourceString("UnauthorizedAccess_MemStreamBuffer");
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x00065852 File Offset: 0x00063A52
		internal static string UnauthorizedAccess_RegistryKeyGeneric_Key
		{
			get
			{
				return SR.GetResourceString("UnauthorizedAccess_RegistryKeyGeneric_Key");
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0006585E File Offset: 0x00063A5E
		internal static string UnknownError_Num
		{
			get
			{
				return SR.GetResourceString("UnknownError_Num");
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0006586A File Offset: 0x00063A6A
		internal static string Verification_Exception
		{
			get
			{
				return SR.GetResourceString("Verification_Exception");
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00065876 File Offset: 0x00063A76
		internal static string Word_At
		{
			get
			{
				return SR.GetResourceString("Word_At");
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00065882 File Offset: 0x00063A82
		internal static string DebugAssertBanner
		{
			get
			{
				return SR.GetResourceString("DebugAssertBanner");
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x0006588E File Offset: 0x00063A8E
		internal static string DebugAssertLongMessage
		{
			get
			{
				return SR.GetResourceString("DebugAssertLongMessage");
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0006589A File Offset: 0x00063A9A
		internal static string DebugAssertShortMessage
		{
			get
			{
				return SR.GetResourceString("DebugAssertShortMessage");
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x000658A6 File Offset: 0x00063AA6
		internal static string LockRecursionException_ReadAfterWriteNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_ReadAfterWriteNotAllowed");
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000658B2 File Offset: 0x00063AB2
		internal static string LockRecursionException_RecursiveReadNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_RecursiveReadNotAllowed");
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x000658BE File Offset: 0x00063ABE
		internal static string LockRecursionException_RecursiveWriteNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_RecursiveWriteNotAllowed");
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000658CA File Offset: 0x00063ACA
		internal static string LockRecursionException_RecursiveUpgradeNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_RecursiveUpgradeNotAllowed");
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000658D6 File Offset: 0x00063AD6
		internal static string LockRecursionException_WriteAfterReadNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_WriteAfterReadNotAllowed");
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x000658E2 File Offset: 0x00063AE2
		internal static string SynchronizationLockException_MisMatchedUpgrade
		{
			get
			{
				return SR.GetResourceString("SynchronizationLockException_MisMatchedUpgrade");
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x000658EE File Offset: 0x00063AEE
		internal static string SynchronizationLockException_MisMatchedRead
		{
			get
			{
				return SR.GetResourceString("SynchronizationLockException_MisMatchedRead");
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x000658FA File Offset: 0x00063AFA
		internal static string SynchronizationLockException_IncorrectDispose
		{
			get
			{
				return SR.GetResourceString("SynchronizationLockException_IncorrectDispose");
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00065906 File Offset: 0x00063B06
		internal static string LockRecursionException_UpgradeAfterReadNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_UpgradeAfterReadNotAllowed");
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x00065912 File Offset: 0x00063B12
		internal static string LockRecursionException_UpgradeAfterWriteNotAllowed
		{
			get
			{
				return SR.GetResourceString("LockRecursionException_UpgradeAfterWriteNotAllowed");
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0006591E File Offset: 0x00063B1E
		internal static string SynchronizationLockException_MisMatchedWrite
		{
			get
			{
				return SR.GetResourceString("SynchronizationLockException_MisMatchedWrite");
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0006592A File Offset: 0x00063B2A
		internal static string NotSupported_SignatureType
		{
			get
			{
				return SR.GetResourceString("NotSupported_SignatureType");
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x00065936 File Offset: 0x00063B36
		internal static string HashCode_HashCodeNotSupported
		{
			get
			{
				return SR.GetResourceString("HashCode_HashCodeNotSupported");
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x00065942 File Offset: 0x00063B42
		internal static string HashCode_EqualityNotSupported
		{
			get
			{
				return SR.GetResourceString("HashCode_EqualityNotSupported");
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x0006594E File Offset: 0x00063B4E
		internal static string Arg_TypeNotSupported
		{
			get
			{
				return SR.GetResourceString("Arg_TypeNotSupported");
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0006595A File Offset: 0x00063B5A
		internal static string IO_InvalidReadLength
		{
			get
			{
				return SR.GetResourceString("IO_InvalidReadLength");
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x00065966 File Offset: 0x00063B66
		internal static string Arg_BasePathNotFullyQualified
		{
			get
			{
				return SR.GetResourceString("Arg_BasePathNotFullyQualified");
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00065972 File Offset: 0x00063B72
		internal static string Argument_OverlapAlignmentMismatch
		{
			get
			{
				return SR.GetResourceString("Argument_OverlapAlignmentMismatch");
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x0006597E File Offset: 0x00063B7E
		internal static string Arg_MustBeNullTerminatedString
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeNullTerminatedString");
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0006598A File Offset: 0x00063B8A
		internal static string ArgumentOutOfRange_Week_ISO
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_Week_ISO");
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00065996 File Offset: 0x00063B96
		internal static string Argument_BadPInvokeMethod
		{
			get
			{
				return SR.GetResourceString("Argument_BadPInvokeMethod");
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000659A2 File Offset: 0x00063BA2
		internal static string Argument_BadPInvokeOnInterface
		{
			get
			{
				return SR.GetResourceString("Argument_BadPInvokeOnInterface");
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x000659AE File Offset: 0x00063BAE
		internal static string Argument_BadTypeDef
		{
			get
			{
				return SR.GetResourceString("Argument_BadTypeDef");
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x000659BA File Offset: 0x00063BBA
		internal static string Argument_CannotExtractScalar
		{
			get
			{
				return SR.GetResourceString("Argument_CannotExtractScalar");
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000659C6 File Offset: 0x00063BC6
		internal static string Argument_CannotParsePrecision
		{
			get
			{
				return SR.GetResourceString("Argument_CannotParsePrecision");
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x000659D2 File Offset: 0x00063BD2
		internal static string Argument_GWithPrecisionNotSupported
		{
			get
			{
				return SR.GetResourceString("Argument_GWithPrecisionNotSupported");
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x000659DE File Offset: 0x00063BDE
		internal static string Argument_PrecisionTooLarge
		{
			get
			{
				return SR.GetResourceString("Argument_PrecisionTooLarge");
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x000659EA File Offset: 0x00063BEA
		internal static string Argument_PropertyClassUnmatchedWithConstructor
		{
			get
			{
				return SR.GetResourceString("Argument_PropertyClassUnmatchedWithConstructor");
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x000659F6 File Offset: 0x00063BF6
		internal static string Argument_PropertyInvalidType
		{
			get
			{
				return SR.GetResourceString("Argument_PropertyInvalidType");
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x00065A02 File Offset: 0x00063C02
		internal static string Argument_PropertyInvalidValue
		{
			get
			{
				return SR.GetResourceString("Argument_PropertyInvalidValue");
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x00065A0E File Offset: 0x00063C0E
		internal static string Argument_PropertyMissingSetter
		{
			get
			{
				return SR.GetResourceString("Argument_PropertyMissingSetter");
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x00065A1A File Offset: 0x00063C1A
		internal static string Argument_PropertyUnmatchingPropertyType
		{
			get
			{
				return SR.GetResourceString("Argument_PropertyUnmatchingPropertyType");
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x00065A26 File Offset: 0x00063C26
		internal static string AssemblyDependencyResolver_FailedToLoadHostpolicy
		{
			get
			{
				return SR.GetResourceString("AssemblyDependencyResolver_FailedToLoadHostpolicy");
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x00065A32 File Offset: 0x00063C32
		internal static string AssemblyDependencyResolver_FailedToResolveDependencies
		{
			get
			{
				return SR.GetResourceString("AssemblyDependencyResolver_FailedToResolveDependencies");
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x00065A3E File Offset: 0x00063C3E
		internal static string Argument_StructArrayTooLarge
		{
			get
			{
				return SR.GetResourceString("Argument_StructArrayTooLarge");
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x00065A4A File Offset: 0x00063C4A
		internal static string IndexOutOfRange_ArrayWithOffset
		{
			get
			{
				return SR.GetResourceString("IndexOutOfRange_ArrayWithOffset");
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x00065A56 File Offset: 0x00063C56
		internal static string Serialization_DangerousDeserialization_Switch
		{
			get
			{
				return SR.GetResourceString("Serialization_DangerousDeserialization_Switch");
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x00065A62 File Offset: 0x00063C62
		internal static string Argument_InvalidStartupHookSimpleAssemblyName
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidStartupHookSimpleAssemblyName");
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x00065A6E File Offset: 0x00063C6E
		internal static string Argument_StartupHookAssemblyLoadFailed
		{
			get
			{
				return SR.GetResourceString("Argument_StartupHookAssemblyLoadFailed");
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00065A7A File Offset: 0x00063C7A
		internal static string InvalidOperation_InvalidHandle
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_InvalidHandle");
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x00065A86 File Offset: 0x00063C86
		internal static string Argument_SpansMustHaveSameLength
		{
			get
			{
				return SR.GetResourceString("Argument_SpansMustHaveSameLength");
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x00065A92 File Offset: 0x00063C92
		internal static string NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed
		{
			get
			{
				return SR.GetResourceString("NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed");
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x00065A9E File Offset: 0x00063C9E
		internal static string GenericInvalidData
		{
			get
			{
				return SR.GetResourceString("GenericInvalidData");
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x00065AAA File Offset: 0x00063CAA
		internal static string Argument_ResourceScopeWrongDirection
		{
			get
			{
				return SR.GetResourceString("Argument_ResourceScopeWrongDirection");
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x00065AB6 File Offset: 0x00063CB6
		internal static string ArgumentNull_TypeRequiredByResourceScope
		{
			get
			{
				return SR.GetResourceString("ArgumentNull_TypeRequiredByResourceScope");
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x00065AC2 File Offset: 0x00063CC2
		internal static string Argument_BadResourceScopeTypeBits
		{
			get
			{
				return SR.GetResourceString("Argument_BadResourceScopeTypeBits");
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x00065ACE File Offset: 0x00063CCE
		internal static string Argument_BadResourceScopeVisibilityBits
		{
			get
			{
				return SR.GetResourceString("Argument_BadResourceScopeVisibilityBits");
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x00065ADA File Offset: 0x00063CDA
		internal static string Argument_EmptyString
		{
			get
			{
				return SR.GetResourceString("Argument_EmptyString");
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x00065AE6 File Offset: 0x00063CE6
		internal static string Argument_EmptyOrWhiteSpaceString
		{
			get
			{
				return SR.GetResourceString("Argument_EmptyOrWhiteSpaceString");
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x00065AF2 File Offset: 0x00063CF2
		internal static string Argument_FrameworkNameInvalid
		{
			get
			{
				return SR.GetResourceString("Argument_FrameworkNameInvalid");
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x00065AFE File Offset: 0x00063CFE
		internal static string Argument_FrameworkNameInvalidVersion
		{
			get
			{
				return SR.GetResourceString("Argument_FrameworkNameInvalidVersion");
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x00065B0A File Offset: 0x00063D0A
		internal static string Argument_FrameworkNameMissingVersion
		{
			get
			{
				return SR.GetResourceString("Argument_FrameworkNameMissingVersion");
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x00065B16 File Offset: 0x00063D16
		internal static string Argument_FrameworkNameTooShort
		{
			get
			{
				return SR.GetResourceString("Argument_FrameworkNameTooShort");
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x00065B22 File Offset: 0x00063D22
		internal static string Arg_SwitchExpressionException
		{
			get
			{
				return SR.GetResourceString("Arg_SwitchExpressionException");
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x00065B2E File Offset: 0x00063D2E
		internal static string Arg_ContextMarshalException
		{
			get
			{
				return SR.GetResourceString("Arg_ContextMarshalException");
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x00065B3A File Offset: 0x00063D3A
		internal static string Arg_AppDomainUnloadedException
		{
			get
			{
				return SR.GetResourceString("Arg_AppDomainUnloadedException");
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x00065B46 File Offset: 0x00063D46
		internal static string SwitchExpressionException_UnmatchedValue
		{
			get
			{
				return SR.GetResourceString("SwitchExpressionException_UnmatchedValue");
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x00065B52 File Offset: 0x00063D52
		internal static string Encoding_UTF7_Disabled
		{
			get
			{
				return SR.GetResourceString("Encoding_UTF7_Disabled");
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x00065B5E File Offset: 0x00063D5E
		internal static string Arg_MustBeHalf
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeHalf");
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x00065B6A File Offset: 0x00063D6A
		internal static string Arg_MustBeRune
		{
			get
			{
				return SR.GetResourceString("Arg_MustBeRune");
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x00065B76 File Offset: 0x00063D76
		internal static string BinaryFormatter_SerializationDisallowed
		{
			get
			{
				return SR.GetResourceString("BinaryFormatter_SerializationDisallowed");
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x00065B82 File Offset: 0x00063D82
		internal static string Argv_IncludeDoubleQuote
		{
			get
			{
				return SR.GetResourceString("Argv_IncludeDoubleQuote");
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x00065B8E File Offset: 0x00063D8E
		internal static string ResourceManager_ReflectionNotAllowed
		{
			get
			{
				return SR.GetResourceString("ResourceManager_ReflectionNotAllowed");
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00065B9A File Offset: 0x00063D9A
		internal static string InvalidOperation_AssemblyNotEditable
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_AssemblyNotEditable");
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x00065BA6 File Offset: 0x00063DA6
		internal static string InvalidOperation_EmptyQueue
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_EmptyQueue");
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00065BB2 File Offset: 0x00063DB2
		internal static string Arg_FileIsDirectory_Name
		{
			get
			{
				return SR.GetResourceString("Arg_FileIsDirectory_Name");
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x00065BBE File Offset: 0x00063DBE
		internal static string Arg_InvalidFileAttrs
		{
			get
			{
				return SR.GetResourceString("Arg_InvalidFileAttrs");
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00065BCA File Offset: 0x00063DCA
		internal static string Arg_Path2IsRooted
		{
			get
			{
				return SR.GetResourceString("Arg_Path2IsRooted");
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x00065BD6 File Offset: 0x00063DD6
		internal static string Arg_PathIsVolume
		{
			get
			{
				return SR.GetResourceString("Arg_PathIsVolume");
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00065BE2 File Offset: 0x00063DE2
		internal static string Argument_InvalidSubPath
		{
			get
			{
				return SR.GetResourceString("Argument_InvalidSubPath");
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00065BEE File Offset: 0x00063DEE
		internal static string IO_SourceDestMustBeDifferent
		{
			get
			{
				return SR.GetResourceString("IO_SourceDestMustBeDifferent");
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00065BFA File Offset: 0x00063DFA
		internal static string IO_SourceDestMustHaveSameRoot
		{
			get
			{
				return SR.GetResourceString("IO_SourceDestMustHaveSameRoot");
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x00065C06 File Offset: 0x00063E06
		internal static string PlatformNotSupported_FileEncryption
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_FileEncryption");
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600213C RID: 8508 RVA: 0x00065C12 File Offset: 0x00063E12
		internal static string Arg_MemberInfoNotFound
		{
			get
			{
				return SR.GetResourceString("Arg_MemberInfoNotFound");
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x00065C1E File Offset: 0x00063E1E
		internal static string ThreadState_Dead_State
		{
			get
			{
				return SR.GetResourceString("ThreadState_Dead_State");
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x00065C2A File Offset: 0x00063E2A
		internal static string NullReference_InvokeNullRefReturned
		{
			get
			{
				return SR.GetResourceString("NullReference_InvokeNullRefReturned");
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x00065C36 File Offset: 0x00063E36
		internal static string PlatformNotSupported_ReflectionEmit
		{
			get
			{
				return SR.GetResourceString("PlatformNotSupported_ReflectionEmit");
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x00065C42 File Offset: 0x00063E42
		internal static string NotSupported_IncompleteTypes
		{
			get
			{
				return SR.GetResourceString("NotSupported_IncompleteTypes");
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x00065C4E File Offset: 0x00063E4E
		internal static string Security_InvalidAssemblyPublicKey
		{
			get
			{
				return SR.GetResourceString("Security_InvalidAssemblyPublicKey");
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00065C5A File Offset: 0x00063E5A
		internal static string ClassLoad_General
		{
			get
			{
				return SR.GetResourceString("ClassLoad_General");
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x00065C66 File Offset: 0x00063E66
		internal static string ClassLoad_General_Hex
		{
			get
			{
				return SR.GetResourceString("ClassLoad_General_Hex");
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00065C72 File Offset: 0x00063E72
		internal static string ArgumentOutOfRange_NotGreaterThanBufferLength
		{
			get
			{
				return SR.GetResourceString("ArgumentOutOfRange_NotGreaterThanBufferLength");
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x00065C7E File Offset: 0x00063E7E
		internal static string NoMetadataTokenAvailable
		{
			get
			{
				return SR.GetResourceString("NoMetadataTokenAvailable");
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x00065C8A File Offset: 0x00063E8A
		internal static string ArgumentException_InvalidTypeArgument
		{
			get
			{
				return SR.GetResourceString("ArgumentException_InvalidTypeArgument");
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x00065C96 File Offset: 0x00063E96
		internal static string Argument_CannotBeByRefType
		{
			get
			{
				return SR.GetResourceString("Argument_CannotBeByRefType");
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x00065CA2 File Offset: 0x00063EA2
		internal static string CannotCreateByRefOfByRef
		{
			get
			{
				return SR.GetResourceString("CannotCreateByRefOfByRef");
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x00065CAE File Offset: 0x00063EAE
		internal static string CannotCreatePointerOfByRef
		{
			get
			{
				return SR.GetResourceString("CannotCreatePointerOfByRef");
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00065CBA File Offset: 0x00063EBA
		internal static string TypeLoad_MethodOverrideNotVirtual
		{
			get
			{
				return SR.GetResourceString("TypeLoad_MethodOverrideNotVirtual");
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x00065CC6 File Offset: 0x00063EC6
		internal static string Argument_DirectorySeparatorInvalid
		{
			get
			{
				return SR.GetResourceString("Argument_DirectorySeparatorInvalid");
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x00065CD2 File Offset: 0x00063ED2
		internal static string InvalidOperation_NotFunctionPointer
		{
			get
			{
				return SR.GetResourceString("InvalidOperation_NotFunctionPointer");
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x00065CDE File Offset: 0x00063EDE
		internal static string NotSupported_ModifiedType
		{
			get
			{
				return SR.GetResourceString("NotSupported_ModifiedType");
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600214E RID: 8526 RVA: 0x00065CEA File Offset: 0x00063EEA
		internal static string Argument_UnexpectedStateForKnownCallback
		{
			get
			{
				return SR.GetResourceString("Argument_UnexpectedStateForKnownCallback");
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x00065CF6 File Offset: 0x00063EF6
		internal static string OutOfMemory_StringTooLong
		{
			get
			{
				return SR.GetResourceString("OutOfMemory_StringTooLong");
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00065D02 File Offset: 0x00063F02
		internal static string Argument_SearchValues_UnsupportedStringComparison
		{
			get
			{
				return SR.GetResourceString("Argument_SearchValues_UnsupportedStringComparison");
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x00065D0E File Offset: 0x00063F0E
		internal static string ComVariant_SizeMustMatchVariantSize
		{
			get
			{
				return SR.GetResourceString("ComVariant_SizeMustMatchVariantSize");
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x00065D1A File Offset: 0x00063F1A
		internal static string ComVariant_TypeIsNotSupportedType
		{
			get
			{
				return SR.GetResourceString("ComVariant_TypeIsNotSupportedType");
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x00065D26 File Offset: 0x00063F26
		internal static string ComVariant_VT_DECIMAL_NotSupported_CreateRaw
		{
			get
			{
				return SR.GetResourceString("ComVariant_VT_DECIMAL_NotSupported_CreateRaw");
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x00065D32 File Offset: 0x00063F32
		internal static string ComVariant_VT_DECIMAL_NotSupported_RawDataRef
		{
			get
			{
				return SR.GetResourceString("ComVariant_VT_DECIMAL_NotSupported_RawDataRef");
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x00065D3E File Offset: 0x00063F3E
		internal static string ComVariant_VT_VARIANT_In_Variant
		{
			get
			{
				return SR.GetResourceString("ComVariant_VT_VARIANT_In_Variant");
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x00065D4A File Offset: 0x00063F4A
		internal static string UnsupportedType
		{
			get
			{
				return SR.GetResourceString("UnsupportedType");
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x00065D56 File Offset: 0x00063F56
		internal static string NotSupported_EmitDebugInfo
		{
			get
			{
				return SR.GetResourceString("NotSupported_EmitDebugInfo");
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x00065D62 File Offset: 0x00063F62
		internal static string NotSupported_ReferenceEnumOrPrimitiveTypeRequired
		{
			get
			{
				return SR.GetResourceString("NotSupported_ReferenceEnumOrPrimitiveTypeRequired");
			}
		}

		// Token: 0x04000578 RID: 1400
		private static readonly object _lock = new object();

		// Token: 0x04000579 RID: 1401
		private static List<string> _currentlyLoading;

		// Token: 0x0400057A RID: 1402
		private static int _infinitelyRecursingCount;

		// Token: 0x0400057B RID: 1403
		private static bool _resourceManagerInited;

		// Token: 0x0400057C RID: 1404
		private static readonly bool s_usingResourceKeys = true;

		// Token: 0x0400057D RID: 1405
		private static ResourceManager s_resourceManager;
	}
}
