using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x02004697 RID: 18071
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenLoadingProcess<[Nullable(2)] T> : PendingProcess<EProcessType>
	{
		// Token: 0x0602D6DF RID: 186079 RVA: 0x00CB934E File Offset: 0x00CB754E
		public OpenLoadingProcess(ELoadingReason reason, T perform, Action callback, [Nullable(2)] string context, params object[] parameters) : base(EProcessType.OpenLoading)
		{
			this.Reason = reason;
			this.Perform = perform;
			this.Callback = callback;
			this.Context = context;
			this.Params = parameters;
		}

		// Token: 0x0401853D RID: 99645
		public ELoadingReason Reason;

		// Token: 0x0401853E RID: 99646
		public T Perform;

		// Token: 0x0401853F RID: 99647
		public Action Callback;

		// Token: 0x04018540 RID: 99648
		[Nullable(2)]
		public string Context;

		// Token: 0x04018541 RID: 99649
		public object[] Params;
	}
}
