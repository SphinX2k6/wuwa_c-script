using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C16 RID: 27670
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueTowerTrial : OpenSystemBase
	{
		// Token: 0x06044456 RID: 279638 RVA: 0x010D26E3 File Offset: 0x010D08E3
		public OpenSystemRogueTowerTrial(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044457 RID: 279639 RVA: 0x010D26EC File Offset: 0x010D08EC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueTowerTrial.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueTowerTrial.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044458 RID: 279640 RVA: 0x010D2728 File Offset: 0x010D0928
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
