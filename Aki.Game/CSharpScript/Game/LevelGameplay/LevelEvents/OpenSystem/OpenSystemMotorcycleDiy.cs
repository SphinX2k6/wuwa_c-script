using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C01 RID: 27649
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMotorcycleDiy : OpenSystemBase
	{
		// Token: 0x06044417 RID: 279575 RVA: 0x010D1E4B File Offset: 0x010D004B
		public OpenSystemMotorcycleDiy(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044418 RID: 279576 RVA: 0x010D1E54 File Offset: 0x010D0054
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMotorcycleDiy.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMotorcycleDiy.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044419 RID: 279577 RVA: 0x010D1E8F File Offset: 0x010D008F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MotorcycleDiyRootView);
		}
	}
}
