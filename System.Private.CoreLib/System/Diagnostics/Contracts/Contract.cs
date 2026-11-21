using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x020008A0 RID: 2208
	[NullableContext(1)]
	[Nullable(0)]
	public static class Contract
	{
		// Token: 0x060089B7 RID: 35255 RVA: 0x0014E546 File Offset: 0x0014C746
		[Conditional("DEBUG")]
		[Conditional("CONTRACTS_FULL")]
		public static void Assume([DoesNotReturnIf(false)] bool condition)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assume, null, null, null);
			}
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x0014E554 File Offset: 0x0014C754
		[NullableContext(2)]
		[Conditional("DEBUG")]
		[Conditional("CONTRACTS_FULL")]
		public static void Assume([DoesNotReturnIf(false)] bool condition, string userMessage)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assume, userMessage, null, null);
			}
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x0014E562 File Offset: 0x0014C762
		[Conditional("DEBUG")]
		[Conditional("CONTRACTS_FULL")]
		public static void Assert([DoesNotReturnIf(false)] bool condition)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assert, null, null, null);
			}
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x0014E570 File Offset: 0x0014C770
		[NullableContext(2)]
		[Conditional("DEBUG")]
		[Conditional("CONTRACTS_FULL")]
		public static void Assert([DoesNotReturnIf(false)] bool condition, string userMessage)
		{
			if (!condition)
			{
				Contract.ReportFailure(ContractFailureKind.Assert, userMessage, null, null);
			}
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x0014E57E File Offset: 0x0014C77E
		[Conditional("CONTRACTS_FULL")]
		public static void Requires(bool condition)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires");
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x0014E57E File Offset: 0x0014C77E
		[NullableContext(2)]
		[Conditional("CONTRACTS_FULL")]
		public static void Requires(bool condition, string userMessage)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires");
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x0014E58B File Offset: 0x0014C78B
		[NullableContext(0)]
		public static void Requires<TException>(bool condition) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires<TException>");
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x0014E58B File Offset: 0x0014C78B
		[NullableContext(0)]
		public static void Requires<TException>(bool condition, [Nullable(2)] string userMessage) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Precondition, "Requires<TException>");
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x0014E598 File Offset: 0x0014C798
		[Conditional("CONTRACTS_FULL")]
		public static void Ensures(bool condition)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Postcondition, "Ensures");
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x0014E598 File Offset: 0x0014C798
		[NullableContext(2)]
		[Conditional("CONTRACTS_FULL")]
		public static void Ensures(bool condition, string userMessage)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Postcondition, "Ensures");
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x0014E5A5 File Offset: 0x0014C7A5
		[NullableContext(0)]
		[Conditional("CONTRACTS_FULL")]
		public static void EnsuresOnThrow<TException>(bool condition) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.PostconditionOnException, "EnsuresOnThrow");
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x0014E5A5 File Offset: 0x0014C7A5
		[NullableContext(0)]
		[Conditional("CONTRACTS_FULL")]
		public static void EnsuresOnThrow<TException>(bool condition, [Nullable(2)] string userMessage) where TException : Exception
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.PostconditionOnException, "EnsuresOnThrow");
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x0014E5B4 File Offset: 0x0014C7B4
		public static T Result<[Nullable(2)] T>()
		{
			return default(T);
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x0014E5CA File Offset: 0x0014C7CA
		public static T ValueAtReturn<[Nullable(2)] T>(out T value)
		{
			value = default(T);
			return value;
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x0014E5DC File Offset: 0x0014C7DC
		public static T OldValue<[Nullable(2)] T>(T value)
		{
			return default(T);
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x0014E5F2 File Offset: 0x0014C7F2
		[Conditional("CONTRACTS_FULL")]
		public static void Invariant(bool condition)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Invariant, "Invariant");
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x0014E5F2 File Offset: 0x0014C7F2
		[NullableContext(2)]
		[Conditional("CONTRACTS_FULL")]
		public static void Invariant(bool condition, string userMessage)
		{
			Contract.AssertMustUseRewriter(ContractFailureKind.Invariant, "Invariant");
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x0014E600 File Offset: 0x0014C800
		public static bool ForAll(int fromInclusive, int toExclusive, Predicate<int> predicate)
		{
			if (fromInclusive > toExclusive)
			{
				throw new ArgumentException(SR.Argument_ToExclusiveLessThanFromExclusive);
			}
			ArgumentNullException.ThrowIfNull(predicate, "predicate");
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				if (!predicate(i))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x0014E640 File Offset: 0x0014C840
		public static bool ForAll<[Nullable(2)] T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			ArgumentNullException.ThrowIfNull(predicate, "predicate");
			foreach (T obj in collection)
			{
				if (!predicate(obj))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x0014E6A8 File Offset: 0x0014C8A8
		public static bool Exists(int fromInclusive, int toExclusive, Predicate<int> predicate)
		{
			if (fromInclusive > toExclusive)
			{
				throw new ArgumentException(SR.Argument_ToExclusiveLessThanFromExclusive);
			}
			ArgumentNullException.ThrowIfNull(predicate, "predicate");
			for (int i = fromInclusive; i < toExclusive; i++)
			{
				if (predicate(i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x0014E6E8 File Offset: 0x0014C8E8
		public static bool Exists<[Nullable(2)] T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			ArgumentNullException.ThrowIfNull(predicate, "predicate");
			foreach (T obj in collection)
			{
				if (predicate(obj))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Conditional("CONTRACTS_FULL")]
		public static void EndContractBlock()
		{
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x0014E750 File Offset: 0x0014C950
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "StackFrame.GetMethod is only used to help diagnosing incorrect use of contracts. It handles missing or incomplete metadata.")]
		private static void AssertMustUseRewriter(ContractFailureKind kind, string contractKind)
		{
			Assembly assembly = typeof(Contract).Assembly;
			StackTrace stackTrace = new StackTrace();
			Assembly assembly2 = null;
			for (int i = 0; i < stackTrace.FrameCount; i++)
			{
				MethodBase method = stackTrace.GetFrame(i).GetMethod();
				Assembly assembly3;
				if (method == null)
				{
					assembly3 = null;
				}
				else
				{
					Type declaringType = method.DeclaringType;
					assembly3 = ((declaringType != null) ? declaringType.Assembly : null);
				}
				Assembly assembly4 = assembly3;
				if (assembly4 != null && assembly4 != assembly)
				{
					assembly2 = assembly4;
					break;
				}
			}
			if (assembly2 == null)
			{
				assembly2 = assembly;
			}
			string name = assembly2.GetName().Name;
			ContractHelper.TriggerFailure(kind, SR.Format(SR.MustUseCCRewrite, contractKind, name), null, null, null);
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x0014E7F0 File Offset: 0x0014C9F0
		[DebuggerNonUserCode]
		private static void ReportFailure(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException)
		{
			if (failureKind < ContractFailureKind.Precondition || failureKind > ContractFailureKind.Assume)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumIllegalVal, failureKind), "failureKind");
			}
			string text = ContractHelper.RaiseContractFailedEvent(failureKind, userMessage, conditionText, innerException);
			if (text == null)
			{
				return;
			}
			ContractHelper.TriggerFailure(failureKind, text, userMessage, conditionText, innerException);
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060089CF RID: 35279 RVA: 0x0014E838 File Offset: 0x0014CA38
		// (remove) Token: 0x060089D0 RID: 35280 RVA: 0x0014E840 File Offset: 0x0014CA40
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static event EventHandler<ContractFailedEventArgs> ContractFailed
		{
			add
			{
				ContractHelper.InternalContractFailed += value;
			}
			remove
			{
				ContractHelper.InternalContractFailed -= value;
			}
		}
	}
}
