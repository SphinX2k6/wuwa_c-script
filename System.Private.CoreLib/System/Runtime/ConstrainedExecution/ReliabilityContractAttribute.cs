using System;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x02000534 RID: 1332
	[Obsolete("The Constrained Execution Region (CER) feature is not supported.", DiagnosticId = "SYSLIB0004", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface, Inherited = false)]
	public sealed class ReliabilityContractAttribute : Attribute
	{
		// Token: 0x060048F9 RID: 18681 RVA: 0x000F207C File Offset: 0x000F027C
		public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		{
			this.ConsistencyGuarantee = consistencyGuarantee;
			this.Cer = cer;
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060048FA RID: 18682 RVA: 0x000F2092 File Offset: 0x000F0292
		public Consistency ConsistencyGuarantee { get; }

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x000F209A File Offset: 0x000F029A
		public Cer Cer { get; }
	}
}
