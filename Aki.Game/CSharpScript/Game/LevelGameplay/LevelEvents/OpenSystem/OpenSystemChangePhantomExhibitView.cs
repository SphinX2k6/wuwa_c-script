using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BCA RID: 27594
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemChangePhantomExhibitView : OpenSystemBase
	{
		// Token: 0x06044373 RID: 279411 RVA: 0x010D07D7 File Offset: 0x010CE9D7
		public OpenSystemChangePhantomExhibitView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044374 RID: 279412 RVA: 0x010D07E0 File Offset: 0x010CE9E0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemChangePhantomExhibitView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemChangePhantomExhibitView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044375 RID: 279413 RVA: 0x010D0823 File Offset: 0x010CEA23
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SpringManorPhantomExhibitView);
		}
	}
}
