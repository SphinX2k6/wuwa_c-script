using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x02004969 RID: 18793
	public class GiantActivitySubView : ActivitySubViewBase
	{
		// Token: 0x0602F205 RID: 193029 RVA: 0x00D23660 File Offset: 0x00D21860
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602F206 RID: 193030 RVA: 0x00D2370C File Offset: 0x00D2190C
		protected override UniTask OnBeforeStartAsync()
		{
			GiantActivitySubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantActivitySubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F207 RID: 193031 RVA: 0x00D2374F File Offset: 0x00D2194F
		private void OnEnterButtonClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
					return;
				}
				EventSystem.Instance.Emit<bool>(EEventName.ChangeActivityViewNeedBlurState, false);
				IGiantSystemMainOpenParam param = new GiantSystemMainOpenParam
				{
					ActivityId = this.ActivityBaseData.Id
				};
				UiManager.Instance.OpenView(EUiViewName.GiantSystemMainView, param, null);
			});
		}

		// Token: 0x0602F208 RID: 193032 RVA: 0x00D2376D File Offset: 0x00D2196D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotDirty));
		}

		// Token: 0x0602F209 RID: 193033 RVA: 0x00D2378B File Offset: 0x00D2198B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotDirty));
		}

		// Token: 0x0602F20A RID: 193034 RVA: 0x00D237AC File Offset: 0x00D219AC
		private void OnRedDotDirty(int activityId)
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (activityId == num.GetValueOrDefault() & num != null)
			{
				GiantActivityInfoPanel infoPanel = this.InfoPanel;
				if (infoPanel == null)
				{
					return;
				}
				infoPanel.RefreshFunctionArea();
			}
		}

		// Token: 0x0602F20B RID: 193035 RVA: 0x00D23800 File Offset: 0x00D21A00
		protected override void OnRefreshView()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			this.InfoPanel.SetTitle(this.ActivityBaseData.GetTitle());
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.InfoPanel.SetTimer(item, item2);
			this.InfoPanel.SetDesc(localConfig.Value.Desc);
			this.InfoPanel.SetReward(this.ActivityBaseData.GetPreviewReward(null));
			this.InfoPanel.RefreshFunctionArea();
			this.RefreshProgress();
		}

		// Token: 0x0602F20C RID: 193036 RVA: 0x00D238A4 File Offset: 0x00D21AA4
		private void RefreshProgress()
		{
			bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(preGuideQuestFinishState);
			}
			if (!preGuideQuestFinishState)
			{
				return;
			}
			GiantModel instance = GiantModel.Instance;
			double num = (instance != null) ? instance.GetTotalStableValue() : 0.0;
			int[] totalNodeGoals = GiantConfig.GetTotalNodeGoals();
			int value = (totalNodeGoals.Length != 0) ? totalNodeGoals[totalNodeGoals.Length - 1] : 0;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602F20D RID: 193037 RVA: 0x00D23954 File Offset: 0x00D21B54
		protected override void OnTimer(float gap)
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			GiantActivityInfoPanel infoPanel = this.InfoPanel;
			if (infoPanel == null)
			{
				return;
			}
			infoPanel.SetTimer(item, item2);
		}

		// Token: 0x0401903F RID: 102463
		[Nullable(2)]
		private GiantActivityInfoPanel InfoPanel;

		// Token: 0x0200A61D RID: 42525
		private class EComponent
		{
			// Token: 0x04033615 RID: 210453
			public const int ComActivityInfo = 0;

			// Token: 0x04033616 RID: 210454
			public const int PnlProgress = 1;

			// Token: 0x04033617 RID: 210455
			public const int TxtValue01 = 2;

			// Token: 0x04033618 RID: 210456
			public const int TxtValue02 = 3;
		}
	}
}
