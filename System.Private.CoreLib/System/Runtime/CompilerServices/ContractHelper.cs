using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200068C RID: 1676
	[NullableContext(2)]
	[Nullable(0)]
	public static class ContractHelper
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060073DC RID: 29660 RVA: 0x00114560 File Offset: 0x00112760
		// (remove) Token: 0x060073DD RID: 29661 RVA: 0x00114594 File Offset: 0x00112794
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal static event EventHandler<ContractFailedEventArgs> InternalContractFailed;

		// Token: 0x060073DE RID: 29662 RVA: 0x001145C8 File Offset: 0x001127C8
		[DebuggerNonUserCode]
		public static string RaiseContractFailedEvent(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException)
		{
			if (failureKind < ContractFailureKind.Precondition || failureKind > ContractFailureKind.Assume)
			{
				throw new ArgumentException(SR.Format(SR.Arg_EnumIllegalVal, failureKind), "failureKind");
			}
			string text = "contract failed.";
			ContractFailedEventArgs contractFailedEventArgs = null;
			string result;
			try
			{
				text = ContractHelper.GetDisplayMessage(failureKind, userMessage, conditionText);
				EventHandler<ContractFailedEventArgs> internalContractFailed = ContractHelper.InternalContractFailed;
				if (internalContractFailed != null)
				{
					contractFailedEventArgs = new ContractFailedEventArgs(failureKind, text, conditionText, innerException);
					foreach (EventHandler<ContractFailedEventArgs> eventHandler in internalContractFailed.GetInvocationList())
					{
						try
						{
							eventHandler(null, contractFailedEventArgs);
						}
						catch (Exception thrownDuringHandler)
						{
							contractFailedEventArgs.thrownDuringHandler = thrownDuringHandler;
							contractFailedEventArgs.SetUnwind();
						}
					}
					if (contractFailedEventArgs.Unwind)
					{
						if (innerException == null)
						{
							innerException = contractFailedEventArgs.thrownDuringHandler;
						}
						throw new ContractException(failureKind, text, userMessage, conditionText, innerException);
					}
				}
			}
			finally
			{
				if (contractFailedEventArgs != null && contractFailedEventArgs.Handled)
				{
					result = null;
				}
				else
				{
					result = text;
				}
			}
			return result;
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x001146B0 File Offset: 0x001128B0
		[DebuggerNonUserCode]
		public static void TriggerFailure(ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, Exception innerException)
		{
			if (string.IsNullOrEmpty(displayMessage))
			{
				displayMessage = ContractHelper.GetDisplayMessage(kind, userMessage, conditionText);
			}
			Debug.ContractFailure(displayMessage, string.Empty, ContractHelper.GetFailureMessage(kind, null));
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x001146D8 File Offset: 0x001128D8
		private static string GetFailureMessage(ContractFailureKind failureKind, string conditionText)
		{
			bool flag = !string.IsNullOrEmpty(conditionText);
			switch (failureKind)
			{
			case ContractFailureKind.Precondition:
				if (!flag)
				{
					return SR.PreconditionFailed;
				}
				return SR.Format(SR.PreconditionFailed_Cnd, conditionText);
			case ContractFailureKind.Postcondition:
				if (!flag)
				{
					return SR.PostconditionFailed;
				}
				return SR.Format(SR.PostconditionFailed_Cnd, conditionText);
			case ContractFailureKind.PostconditionOnException:
				if (!flag)
				{
					return SR.PostconditionOnExceptionFailed;
				}
				return SR.Format(SR.PostconditionOnExceptionFailed_Cnd, conditionText);
			case ContractFailureKind.Invariant:
				if (!flag)
				{
					return SR.InvariantFailed;
				}
				return SR.Format(SR.InvariantFailed_Cnd, conditionText);
			case ContractFailureKind.Assert:
				if (!flag)
				{
					return SR.AssertionFailed;
				}
				return SR.Format(SR.AssertionFailed_Cnd, conditionText);
			case ContractFailureKind.Assume:
				if (!flag)
				{
					return SR.AssumptionFailed;
				}
				return SR.Format(SR.AssumptionFailed_Cnd, conditionText);
			default:
				Contract.Assume(false, "Unreachable code");
				return SR.AssumptionFailed;
			}
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x001147A0 File Offset: 0x001129A0
		private static string GetDisplayMessage(ContractFailureKind failureKind, string userMessage, string conditionText)
		{
			string text;
			if (!string.IsNullOrEmpty(conditionText))
			{
				text = ContractHelper.GetFailureMessage(failureKind, conditionText);
			}
			else
			{
				text = "";
			}
			if (!string.IsNullOrEmpty(userMessage))
			{
				return text + "  " + userMessage;
			}
			return text;
		}
	}
}
