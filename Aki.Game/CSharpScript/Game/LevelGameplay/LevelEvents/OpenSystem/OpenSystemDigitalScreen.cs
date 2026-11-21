using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.DigitalScreen;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D50 RID: 23888
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDigitalScreen : OpenSystemBase
	{
		// Token: 0x0603A4F2 RID: 238834 RVA: 0x0107AC37 File Offset: 0x01078E37
		public OpenSystemDigitalScreen(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4F3 RID: 238835 RVA: 0x0107AC40 File Offset: 0x01078E40
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDigitalScreen.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDigitalScreen.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4F4 RID: 238836 RVA: 0x0107AC8C File Offset: 0x01078E8C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.DigitalScreenaView);
			}
			DigitalScreen? dataConfig = DigitalScreenModel.Instance.GetDataConfig(inParams.BoardId);
			if (dataConfig != null && dataConfig.GetValueOrDefault().Prefab == 0)
			{
				return new EUiViewName?(EUiViewName.DigitalScreenaView);
			}
			if (dataConfig != null && dataConfig.GetValueOrDefault().Prefab == 1)
			{
				return new EUiViewName?(EUiViewName.DigitalScreenbView);
			}
			return new EUiViewName?(EUiViewName.DigitalScreenaView);
		}
	}
}
