using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BDB RID: 27611
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDrinksSelectRoleView : OpenSystemBase
	{
		// Token: 0x060443A6 RID: 279462 RVA: 0x010D0F42 File Offset: 0x010CF142
		public OpenSystemDrinksSelectRoleView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443A7 RID: 279463 RVA: 0x010D0F4C File Offset: 0x010CF14C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDrinksSelectRoleView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDrinksSelectRoleView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443A8 RID: 279464 RVA: 0x010D0F88 File Offset: 0x010CF188
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return null;
		}
	}
}
