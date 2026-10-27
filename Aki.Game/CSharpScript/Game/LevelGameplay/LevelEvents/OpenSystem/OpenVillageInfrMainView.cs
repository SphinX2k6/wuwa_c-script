using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C31 RID: 27697
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenVillageInfrMainView : OpenSystemBase
	{
		// Token: 0x060444AC RID: 279724 RVA: 0x010D322B File Offset: 0x010D142B
		public OpenVillageInfrMainView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060444AD RID: 279725 RVA: 0x010D3234 File Offset: 0x010D1434
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenVillageInfrMainView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenVillageInfrMainView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060444AE RID: 279726 RVA: 0x010D326F File Offset: 0x010D146F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.VillageInfrMainView);
		}
	}
}
