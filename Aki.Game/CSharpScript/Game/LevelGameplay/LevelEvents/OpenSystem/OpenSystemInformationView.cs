using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF3 RID: 27635
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInformationView : OpenSystemBase
	{
		// Token: 0x060443ED RID: 279533 RVA: 0x010D1773 File Offset: 0x010CF973
		public OpenSystemInformationView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443EE RID: 279534 RVA: 0x010D177C File Offset: 0x010CF97C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemInformationView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemInformationView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443EF RID: 279535 RVA: 0x010D17C8 File Offset: 0x010CF9C8
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			EUiViewName? result = null;
			IInformationViewConfig informationViewConfig = inParams.InformationViewConfig;
			int valueOrDefault = ((informationViewConfig != null) ? informationViewConfig.InfoDisplayGroup : null).GetValueOrDefault();
			InfoDisplayGroup? infoDisplayGroup = (valueOrDefault > 0) ? ConfigInfoDisplayGroupById.GetConfig(valueOrDefault, true) : null;
			int id = (((infoDisplayGroup != null) ? infoDisplayGroup.GetValueOrDefault().InfoListLength : 0) > 0) ? infoDisplayGroup.Value.InfoList(0) : inParams.BoardId;
			InfoDisplayController.EInfoDisplayViewEnum infoDisplayType = (InfoDisplayController.EInfoDisplayViewEnum)InfoDisplayModuleConfig.Instance.GetInfoDisplayType(id);
			if (infoDisplayType == InfoDisplayController.EInfoDisplayViewEnum.TypeOne)
			{
				result = new EUiViewName?(EUiViewName.InfoDisplayTypeOneView);
			}
			else if (infoDisplayType == InfoDisplayController.EInfoDisplayViewEnum.TypeTwo)
			{
				result = new EUiViewName?(EUiViewName.InfoDisplayTypeTwoView);
			}
			else if (infoDisplayType == InfoDisplayController.EInfoDisplayViewEnum.TypeThree)
			{
				result = new EUiViewName?(EUiViewName.InfoDisplayTypeThreeView);
			}
			else if (infoDisplayType == InfoDisplayController.EInfoDisplayViewEnum.TypeFour)
			{
				result = new EUiViewName?(EUiViewName.InfoDisplayTypeFourNewView);
			}
			else if (infoDisplayType == InfoDisplayController.EInfoDisplayViewEnum.TypeFive)
			{
				result = new EUiViewName?(EUiViewName.InfoDisplayTypeFiveView);
			}
			return result;
		}
	}
}
