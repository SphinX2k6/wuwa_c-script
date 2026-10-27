using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BC8 RID: 27592
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class OpenSystemBase
	{
		// Token: 0x0604436D RID: 279405 RVA: 0x010D0733 File Offset: 0x010CE933
		public OpenSystemBase(LevelEventOpenSystem eventBase)
		{
			this.EventBase = eventBase;
		}

		// Token: 0x0604436E RID: 279406
		[NullableContext(2)]
		public abstract EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null);

		// Token: 0x0604436F RID: 279407 RVA: 0x010D0744 File Offset: 0x010CE944
		[return: Nullable(0)]
		public virtual UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemBase.<ExecuteOpenView>d__3 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemBase.<ExecuteOpenView>d__3>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x04023987 RID: 145799
		protected LevelEventOpenSystem EventBase;
	}
}
