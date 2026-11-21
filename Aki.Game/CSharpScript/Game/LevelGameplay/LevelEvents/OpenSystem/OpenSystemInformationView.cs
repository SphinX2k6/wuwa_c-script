using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D6C RID: 23916
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInformationView : OpenSystemBase
	{
		// Token: 0x0603A545 RID: 238917 RVA: 0x0107B6C7 File Offset: 0x010798C7
		public OpenSystemInformationView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A546 RID: 238918 RVA: 0x0107B6D0 File Offset: 0x010798D0
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

		// Token: 0x0603A547 RID: 238919 RVA: 0x0107B71C File Offset: 0x0107991C
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
