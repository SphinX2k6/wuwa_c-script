using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D41 RID: 23873
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class OpenSystemBase
	{
		// Token: 0x0603A4C5 RID: 238789 RVA: 0x0107A687 File Offset: 0x01078887
		public OpenSystemBase(LevelEventOpenSystem eventBase)
		{
			this.EventBase = eventBase;
		}

		// Token: 0x0603A4C6 RID: 238790
		[NullableContext(2)]
		public abstract EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null);

		// Token: 0x0603A4C7 RID: 238791 RVA: 0x0107A698 File Offset: 0x01078898
		[return: Nullable(0)]
		public virtual UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemBase.<ExecuteOpenView>d__3 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemBase.<ExecuteOpenView>d__3>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0401EC29 RID: 125993
		protected LevelEventOpenSystem EventBase;
	}
}
