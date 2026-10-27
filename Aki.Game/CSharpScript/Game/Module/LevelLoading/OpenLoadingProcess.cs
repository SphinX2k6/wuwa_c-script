using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056C0 RID: 22208
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenLoadingProcess<[Nullable(2)] T> : PendingProcess<EProcessType>
	{
		// Token: 0x060387D8 RID: 231384 RVA: 0x00D6B206 File Offset: 0x00D69406
		public OpenLoadingProcess(ELoadingReason reason, T perform, Action callback, [Nullable(2)] string context, params object[] parameters) : base(EProcessType.OpenLoading)
		{
			this.Reason = reason;
			this.Perform = perform;
			this.Callback = callback;
			this.Context = context;
			this.Params = parameters;
		}

		// Token: 0x0401DAB0 RID: 121520
		public ELoadingReason Reason;

		// Token: 0x0401DAB1 RID: 121521
		public T Perform;

		// Token: 0x0401DAB2 RID: 121522
		public Action Callback;

		// Token: 0x0401DAB3 RID: 121523
		[Nullable(2)]
		public string Context;

		// Token: 0x0401DAB4 RID: 121524
		public object[] Params;
	}
}
