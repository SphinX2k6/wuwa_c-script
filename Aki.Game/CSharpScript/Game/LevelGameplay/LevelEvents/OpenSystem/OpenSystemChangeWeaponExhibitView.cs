using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BCB RID: 27595
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemChangeWeaponExhibitView : OpenSystemBase
	{
		// Token: 0x06044376 RID: 279414 RVA: 0x010D082F File Offset: 0x010CEA2F
		public OpenSystemChangeWeaponExhibitView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044377 RID: 279415 RVA: 0x010D0838 File Offset: 0x010CEA38
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

		// Token: 0x06044378 RID: 279416 RVA: 0x010D087B File Offset: 0x010CEA7B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SpringManorWeaponExhibitView);
		}
	}
}
