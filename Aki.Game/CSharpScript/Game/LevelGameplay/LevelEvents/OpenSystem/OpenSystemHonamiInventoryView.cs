using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BEE RID: 27630
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiInventoryView : OpenSystemBase
	{
		// Token: 0x060443DE RID: 279518 RVA: 0x010D15C3 File Offset: 0x010CF7C3
		public OpenSystemHonamiInventoryView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443DF RID: 279519 RVA: 0x010D15CC File Offset: 0x010CF7CC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiInventoryView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiInventoryView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443E0 RID: 279520 RVA: 0x010D1607 File Offset: 0x010CF807
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryBackpackView);
		}
	}
}
