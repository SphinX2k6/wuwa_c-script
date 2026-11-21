using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004764 RID: 18276
	public class KurotatoStageEntranceEndlessLock : UiPanelBase
	{
		// Token: 0x0602DDFD RID: 187901 RVA: 0x00CD716C File Offset: 0x00CD536C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DDFE RID: 187902 RVA: 0x00CD71D8 File Offset: 0x00CD53D8
		public void RefreshView()
		{
			int levelId = KurotatoConfig.Instance.GetLevelGroupConfig(3).Value.LevelId;
			if (levelId <= 0)
			{
				return;
			}
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			KurotatoLevelData kurotatoLevelData = activityData.GetKurotatoLevelData(levelId);
			if (kurotatoLevelData == null)
			{
				return;
			}
			if (!kurotatoLevelData.IsReachUnlockTime())
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Kurotato_Level_Select_UnlockTip2", null);
				long endlessLevelUnlockTime = activityData.GetEndlessLevelUnlockTime();
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText(endlessLevelUnlockTime, localTextNew);
				base.GetText(1).SetText(remainTimeText, true);
				return;
			}
			KurotatoLevel value = KurotatoConfig.Instance.GetLevelConfig(levelId).Value;
			KurotatoLevel value2 = KurotatoConfig.Instance.GetLevelConfig(value.PerId).Value;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(value2.Name);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Kurotato_Level_Select_UnlockTip", new <>z__ReadOnlySingleElementList<object>(multiTextByKey));
		}

		// Token: 0x0200A3CA RID: 41930
		private enum ELockComponents
		{
			// Token: 0x04032C56 RID: 207958
			UpText,
			// Token: 0x04032C57 RID: 207959
			DownText
		}
	}
}
