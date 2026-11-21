using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x02004696 RID: 18070
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingProcess<[Nullable(2)] T>
	{
		// Token: 0x0602D6DD RID: 186077 RVA: 0x00CB9324 File Offset: 0x00CB7524
		public PendingProcess(T processType)
		{
			this.ProcessId = ++PendingProcessDefine.Id;
			this.ProcessType = processType;
		}

		// Token: 0x17005B5B RID: 23387
		// (get) Token: 0x0602D6DE RID: 186078 RVA: 0x00CB9346 File Offset: 0x00CB7546
		public T ProcessType { get; }

		// Token: 0x0401853B RID: 99643
		public int ProcessId;
	}
}
