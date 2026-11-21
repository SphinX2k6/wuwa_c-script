using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D44 RID: 23876
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemChangeWeaponExhibitView : OpenSystemBase
	{
		// Token: 0x0603A4CE RID: 238798 RVA: 0x0107A783 File Offset: 0x01078983
		public OpenSystemChangeWeaponExhibitView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4CF RID: 238799 RVA: 0x0107A78C File Offset: 0x0107898C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemChangeWeaponExhibitView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemChangeWeaponExhibitView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4D0 RID: 238800 RVA: 0x0107A7CF File Offset: 0x010789CF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SpringManorWeaponExhibitView);
		}
	}
}
