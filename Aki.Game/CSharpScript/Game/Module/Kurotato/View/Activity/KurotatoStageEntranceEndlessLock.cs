using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200578D RID: 22413
	public class KurotatoStageEntranceEndlessLock : UiPanelBase
	{
		// Token: 0x06038EED RID: 233197 RVA: 0x00D88410 File Offset: 0x00D86610
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

		// Token: 0x06038EEE RID: 233198 RVA: 0x00D8847C File Offset: 0x00D8667C
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

		// Token: 0x0200B9B4 RID: 47540
		private enum ELockComponents
		{
			// Token: 0x04038265 RID: 229989
			UpText,
			// Token: 0x04038266 RID: 229990
			DownText
		}
	}
}
