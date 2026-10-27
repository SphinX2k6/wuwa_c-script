using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C11 RID: 27665
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueBattleShop : OpenSystemBase
	{
		// Token: 0x06044447 RID: 279623 RVA: 0x010D24BB File Offset: 0x010D06BB
		public OpenSystemRogueBattleShop(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044448 RID: 279624 RVA: 0x010D24C4 File Offset: 0x010D06C4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueBattleShop.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueBattleShop.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044449 RID: 279625 RVA: 0x010D24FF File Offset: 0x010D06FF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RogueBattleShopView);
		}
	}
}
