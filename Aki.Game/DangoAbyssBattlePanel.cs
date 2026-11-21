using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EEB RID: 3819
public class DangoAbyssBattlePanel : BattleVisibleChildView
{
	// Token: 0x0600991F RID: 39199 RVA: 0x002D6448 File Offset: 0x002D4648
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
		};
	}

	// Token: 0x06009920 RID: 39200 RVA: 0x002D6549 File Offset: 0x002D4749
	private void OnClickBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssInfoView, null, null);
	}

	// Token: 0x06009921 RID: 39201 RVA: 0x002D655C File Offset: 0x002D475C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssBattlePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssBattlePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009922 RID: 39202 RVA: 0x002D659F File Offset: 0x002D479F
	private void OnRoomInfoUpdate()
	{
		this.RefreshProgressText();
		this.RefreshProgressElements();
		this.RefreshBarText();
	}

	// Token: 0x06009923 RID: 39203 RVA: 0x002D65B4 File Offset: 0x002D47B4
	private void RefreshBarText()
	{
		float instanceProgress = DangoAbyssModel.Instance.GetInstanceProgress();
		UUIText text = base.GetText(8);
		if (text == null)
		{
			return;
		}
		text.SetText(StringUtils.Format("{0}%", new string[]
		{
			(instanceProgress * 100f).ToString("F0")
		}), true);
	}

	// Token: 0x06009924 RID: 39204 RVA: 0x002D6605 File Offset: 0x002D4805
	private void OnShareReviveTimesChange()
	{
		this.RefreshDeadText();
	}

	// Token: 0x06009925 RID: 39205 RVA: 0x002D660D File Offset: 0x002D480D
	private void OnRefreshTime(float _)
	{
		this.RefreshTimeText();
		this.RefreshProgressElements();
	}

	// Token: 0x06009926 RID: 39206 RVA: 0x002D661C File Offset: 0x002D481C
	private void RefreshProgressElements()
	{
		float instanceProgress = DangoAbyssModel.Instance.GetInstanceProgress();
		this.RefreshProgressSlider(instanceProgress);
		this.RefreshTreasureItem(instanceProgress);
	}

	// Token: 0x06009927 RID: 39207 RVA: 0x002D6644 File Offset: 0x002D4844
	private void RefreshTreasureItem(float progress)
	{
		DangoAbyssBattlePanel.<>c__DisplayClass13_0 CS$<>8__locals1 = new DangoAbyssBattlePanel.<>c__DisplayClass13_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.progress = progress;
		UiAsyncTask task = new UiAsyncTask("DangoAbyss.UpdateRoomData", delegate()
		{
			DangoAbyssBattlePanel.<>c__DisplayClass13_0.<<RefreshTreasureItem>b__0>d <<RefreshTreasureItem>b__0>d;
			<<RefreshTreasureItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshTreasureItem>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshTreasureItem>b__0>d.<>1__state = -1;
			<<RefreshTreasureItem>b__0>d.<>t__builder.Start<DangoAbyssBattlePanel.<>c__DisplayClass13_0.<<RefreshTreasureItem>b__0>d>(ref <<RefreshTreasureItem>b__0>d);
			return <<RefreshTreasureItem>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06009928 RID: 39208 RVA: 0x002D6685 File Offset: 0x002D4885
	protected override void OnBeforeShow()
	{
		this.RefreshProgressElements();
		this.RefreshDeadText();
		this.RefreshProgressText();
		this.RefreshBarText();
	}

	// Token: 0x06009929 RID: 39209 RVA: 0x002D66A0 File Offset: 0x002D48A0
	private void RefreshDeadText()
	{
		string instanceReviveTipTips = DangoAbyssModel.Instance.GetInstanceReviveTipTips();
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.SetText(instanceReviveTipTips, true);
	}

	// Token: 0x0600992A RID: 39210 RVA: 0x002D66CC File Offset: 0x002D48CC
	private void RefreshProgressText()
	{
		string instanceFloorText = DangoAbyssModel.Instance.GetInstanceFloorText();
		UUIText text = base.GetText(6);
		if (text == null)
		{
			return;
		}
		text.SetText(instanceFloorText ?? "", true);
	}

	// Token: 0x0600992B RID: 39211 RVA: 0x002D6700 File Offset: 0x002D4900
	private void RefreshProgressSlider(float progress)
	{
		UUISliderComponent slider = base.GetSlider(2);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(progress, true);
	}

	// Token: 0x0600992C RID: 39212 RVA: 0x002D6718 File Offset: 0x002D4918
	private void RefreshTimeText()
	{
		string instanceRemainTimeText = DangoAbyssModel.Instance.GetInstanceRemainTimeText();
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(instanceRemainTimeText, true);
	}

	// Token: 0x0600992D RID: 39213 RVA: 0x002D6744 File Offset: 0x002D4944
	protected override void OnBeforeDestroy()
	{
		if (this.RefreshTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
		EventSystem.Instance.Remove(EEventName.OnShareReviveTimesChange, new Action(this.OnShareReviveTimesChange));
		EventSystem.Instance.Remove(EEventName.OnAbyssRoomInfoUpdate, new Action(this.OnRoomInfoUpdate));
	}

	// Token: 0x0600992E RID: 39214 RVA: 0x002D67AC File Offset: 0x002D49AC
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "DangoMissionButton"))
		{
			return null;
		}
		UUIButtonComponent button = base.GetButton(0);
		UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x04005BA5 RID: 23461
	[Nullable(1)]
	public Dictionary<int, int> RewardTimeMap = new Dictionary<int, int>();

	// Token: 0x04005BA6 RID: 23462
	public float FullTime;

	// Token: 0x04005BA7 RID: 23463
	[Nullable(2)]
	private DangoAbyssBattleTreasureRoot DangoAbyssBattleTreasureRoot;

	// Token: 0x04005BA8 RID: 23464
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x02007101 RID: 28929
	private enum EComponent
	{
		// Token: 0x04024CEB RID: 150763
		Button,
		// Token: 0x04024CEC RID: 150764
		TimeText,
		// Token: 0x04024CED RID: 150765
		ProgressSlider,
		// Token: 0x04024CEE RID: 150766
		RewardItemRoot,
		// Token: 0x04024CEF RID: 150767
		RewardItem,
		// Token: 0x04024CF0 RID: 150768
		DeadText,
		// Token: 0x04024CF1 RID: 150769
		ProgressText,
		// Token: 0x04024CF2 RID: 150770
		TitleText,
		// Token: 0x04024CF3 RID: 150771
		BarText
	}
}
