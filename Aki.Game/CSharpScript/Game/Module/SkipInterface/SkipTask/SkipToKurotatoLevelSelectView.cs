using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B79 RID: 15225
	public class SkipToKurotatoLevelSelectView : SkipTask
	{
		// Token: 0x060270BE RID: 159934 RVA: 0x00AEE77C File Offset: 0x00AEC97C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			base.Finish();
			int levelId = Convert.ToInt32(data[0]);
			KurotatoActivityController instance = KurotatoActivityController.Instance;
			KurotatoActivityData kurotatoActivityData = (instance != null) ? instance.GetActivityData() : null;
			KurotatoConfig instance2 = KurotatoConfig.Instance;
			KurotatoLevel? kurotatoLevel = (instance2 != null) ? instance2.GetLevelConfig(levelId) : null;
			if (kurotatoActivityData == null || kurotatoLevel == null || !kurotatoActivityData.IsStageEntranceUnLock((EKurotatoLevelMode)kurotatoLevel.Value.LevelGroup))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("KurotatoLevelLockedTip", Array.Empty<object>());
				return;
			}
			KurotatoLevelSelectViewData kurotatoLevelSelectViewData = new KurotatoLevelSelectViewData();
			kurotatoLevelSelectViewData.LevelId = levelId;
			UiManager.Instance.OpenView(EUiViewName.KurotatoLevelSelectView, kurotatoLevelSelectViewData, null);
		}
	}
}
