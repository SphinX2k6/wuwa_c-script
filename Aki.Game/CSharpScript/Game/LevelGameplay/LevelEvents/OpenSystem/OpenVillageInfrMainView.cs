using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DAA RID: 23978
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenVillageInfrMainView : OpenSystemBase
	{
		// Token: 0x0603A604 RID: 239108 RVA: 0x0107D17F File Offset: 0x0107B37F
		public OpenVillageInfrMainView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A605 RID: 239109 RVA: 0x0107D188 File Offset: 0x0107B388
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenVillageInfrMainView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenVillageInfrMainView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A606 RID: 239110 RVA: 0x0107D1C3 File Offset: 0x0107B3C3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.VillageInfrMainView);
		}
	}
}
