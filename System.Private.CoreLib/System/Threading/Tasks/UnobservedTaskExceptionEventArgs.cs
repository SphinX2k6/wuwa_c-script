using System;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	// Token: 0x020004E1 RID: 1249
	[NullableContext(1)]
	[Nullable(0)]
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		// Token: 0x0600477A RID: 18298 RVA: 0x000EE8B3 File Offset: 0x000ECAB3
		public UnobservedTaskExceptionEventArgs(AggregateException exception)
		{
			this.m_exception = exception;
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x000EE8C2 File Offset: 0x000ECAC2
		public void SetObserved()
		{
			this.m_observed = true;
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x000EE8CB File Offset: 0x000ECACB
		public bool Observed
		{
			get
			{
				return this.m_observed;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x000EE8D3 File Offset: 0x000ECAD3
		public AggregateException Exception
		{
			get
			{
				return this.m_exception;
			}
		}

		// Token: 0x040010BE RID: 4286
		private readonly AggregateException m_exception;

		// Token: 0x040010BF RID: 4287
		internal bool m_observed;
	}
}
