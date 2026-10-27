using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056BF RID: 22207
	[NullableContext(1)]
	[Nullable(0)]
	public class PendingProcess<[Nullable(2)] T>
	{
		// Token: 0x060387D6 RID: 231382 RVA: 0x00D6B1DC File Offset: 0x00D693DC
		public PendingProcess(T processType)
		{
			this.ProcessId = ++PendingProcessDefine.Id;
			this.ProcessType = processType;
		}

		// Token: 0x17008793 RID: 34707
		// (get) Token: 0x060387D7 RID: 231383 RVA: 0x00D6B1FE File Offset: 0x00D693FE
		public T ProcessType { get; }

		// Token: 0x0401DAAE RID: 121518
		public int ProcessId;
	}
}
