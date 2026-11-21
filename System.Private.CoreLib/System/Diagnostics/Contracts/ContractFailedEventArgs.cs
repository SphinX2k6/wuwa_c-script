using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x02000894 RID: 2196
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class ContractFailedEventArgs : EventArgs
	{
		// Token: 0x0600899A RID: 35226 RVA: 0x0014E429 File Offset: 0x0014C629
		public ContractFailedEventArgs(ContractFailureKind failureKind, string message, string condition, Exception originalException)
		{
			this._failureKind = failureKind;
			this._message = message;
			this._condition = condition;
			this._originalException = originalException;
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x0600899B RID: 35227 RVA: 0x0014E44E File Offset: 0x0014C64E
		public string Message
		{
			get
			{
				return this._message;
			}
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600899C RID: 35228 RVA: 0x0014E456 File Offset: 0x0014C656
		public string Condition
		{
			get
			{
				return this._condition;
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600899D RID: 35229 RVA: 0x0014E45E File Offset: 0x0014C65E
		public ContractFailureKind FailureKind
		{
			get
			{
				return this._failureKind;
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600899E RID: 35230 RVA: 0x0014E466 File Offset: 0x0014C666
		public Exception OriginalException
		{
			get
			{
				return this._originalException;
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x0014E46E File Offset: 0x0014C66E
		public bool Handled
		{
			get
			{
				return this._handled;
			}
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x0014E476 File Offset: 0x0014C676
		public void SetHandled()
		{
			this._handled = true;
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x060089A1 RID: 35233 RVA: 0x0014E47F File Offset: 0x0014C67F
		public bool Unwind
		{
			get
			{
				return this._unwind;
			}
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x0014E487 File Offset: 0x0014C687
		public void SetUnwind()
		{
			this._unwind = true;
		}

		// Token: 0x04001E4F RID: 7759
		private readonly ContractFailureKind _failureKind;

		// Token: 0x04001E50 RID: 7760
		private readonly string _message;

		// Token: 0x04001E51 RID: 7761
		private readonly string _condition;

		// Token: 0x04001E52 RID: 7762
		private readonly Exception _originalException;

		// Token: 0x04001E53 RID: 7763
		private bool _handled;

		// Token: 0x04001E54 RID: 7764
		private bool _unwind;

		// Token: 0x04001E55 RID: 7765
		internal Exception thrownDuringHandler;
	}
}
