using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C2F RID: 27695
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemWorldMap : OpenSystemBase
	{
		// Token: 0x060444A6 RID: 279718 RVA: 0x010D3172 File Offset: 0x010D1372
		public OpenSystemWorldMap(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060444A7 RID: 279719 RVA: 0x010D317C File Offset: 0x010D137C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemWorldMap.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemWorldMap.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060444A8 RID: 279720 RVA: 0x010D31BF File Offset: 0x010D13BF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.WorldMapView);
		}
	}
}
