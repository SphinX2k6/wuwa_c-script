using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C17 RID: 27671
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRoleDescription : OpenSystemBase
	{
		// Token: 0x06044459 RID: 279641 RVA: 0x010D273E File Offset: 0x010D093E
		public OpenSystemRoleDescription(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604445A RID: 279642 RVA: 0x010D2748 File Offset: 0x010D0948
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRoleDescription.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRoleDescription.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604445B RID: 279643 RVA: 0x010D278B File Offset: 0x010D098B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RoleNewJoinTipView);
		}
	}
}
