using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D8A RID: 23946
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueBattleShop : OpenSystemBase
	{
		// Token: 0x0603A59F RID: 239007 RVA: 0x0107C40F File Offset: 0x0107A60F
		public OpenSystemRogueBattleShop(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5A0 RID: 239008 RVA: 0x0107C418 File Offset: 0x0107A618
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueBattleShop.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueBattleShop.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5A1 RID: 239009 RVA: 0x0107C453 File Offset: 0x0107A653
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RogueBattleShopView);
		}
	}
}
