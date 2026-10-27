using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BFD RID: 27645
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMingSuTi : OpenSystemBase
	{
		// Token: 0x0604440B RID: 279563 RVA: 0x010D1C8B File Offset: 0x010CFE8B
		public OpenSystemMingSuTi(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604440C RID: 279564 RVA: 0x010D1C94 File Offset: 0x010CFE94
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMingSuTi.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMingSuTi.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604440D RID: 279565 RVA: 0x010D1CD8 File Offset: 0x010CFED8
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.MingSuView);
			}
			switch (inParams.BoardId)
			{
			case 1:
				return new EUiViewName?(EUiViewName.MingSuView);
			case 2:
				return new EUiViewName?(EUiViewName.CollectItemView);
			case 3:
				return new EUiViewName?(EUiViewName.DarkCoastDeliveryMainView);
			case 4:
				return new EUiViewName?(EUiViewName.PupuVillageItemView);
			case 5:
				return new EUiViewName?(EUiViewName.PupuVillageItemViewQIQIU);
			case 6:
				return new EUiViewName?(EUiViewName.LaHaiLuoCollectView);
			case 7:
				return new EUiViewName?(EUiViewName.RiLingCollectView);
			case 8:
				return new EUiViewName?(EUiViewName.MengZhouCollectView);
			default:
				return new EUiViewName?(EUiViewName.MingSuView);
			}
		}
	}
}
