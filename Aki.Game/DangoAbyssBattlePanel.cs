using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A2C RID: 6700
public class DangoAbyssBattlePanel : BattleVisibleChildView
{
	// Token: 0x0600C50F RID: 50447 RVA: 0x002CB328 File Offset: 0x002C9528
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

	// Token: 0x0600C510 RID: 50448 RVA: 0x002CB429 File Offset: 0x002C9629
	private void OnClickBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssInfoView, null, null);
	}

	// Token: 0x0600C511 RID: 50449 RVA: 0x002CB43C File Offset: 0x002C963C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssBattlePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssBattlePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C512 RID: 50450 RVA: 0x002CB47F File Offset: 0x002C967F
	private void OnRoomInfoUpdate()
	{
		this.RefreshProgressText();
		this.RefreshProgressElements();
		this.RefreshBarText();
	}

	// Token: 0x0600C513 RID: 50451 RVA: 0x002CB494 File Offset: 0x002C9694
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

	// Token: 0x0600C514 RID: 50452 RVA: 0x002CB4E5 File Offset: 0x002C96E5
	private void OnShareReviveTimesChange()
	{
		this.RefreshDeadText();
	}

	// Token: 0x0600C515 RID: 50453 RVA: 0x002CB4ED File Offset: 0x002C96ED
	private void OnRefreshTime(float _)
	{
		this.RefreshTimeText();
		this.RefreshProgressElements();
	}

	// Token: 0x0600C516 RID: 50454 RVA: 0x002CB4FC File Offset: 0x002C96FC
	private void RefreshProgressElements()
	{
		float instanceProgress = DangoAbyssModel.Instance.GetInstanceProgress();
		this.RefreshProgressSlider(instanceProgress);
		this.RefreshTreasureItem(instanceProgress);
	}

	// Token: 0x0600C517 RID: 50455 RVA: 0x002CB524 File Offset: 0x002C9724
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

	// Token: 0x0600C518 RID: 50456 RVA: 0x002CB565 File Offset: 0x002C9765
	protected override void OnBeforeShow()
	{
		this.RefreshProgressElements();
		this.RefreshDeadText();
		this.RefreshProgressText();
		this.RefreshBarText();
	}

	// Token: 0x0600C519 RID: 50457 RVA: 0x002CB580 File Offset: 0x002C9780
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

	// Token: 0x0600C51A RID: 50458 RVA: 0x002CB5AC File Offset: 0x002C97AC
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

	// Token: 0x0600C51B RID: 50459 RVA: 0x002CB5E0 File Offset: 0x002C97E0
	private void RefreshProgressSlider(float progress)
	{
		UUISliderComponent slider = base.GetSlider(2);
		if (slider == null)
		{
			return;
		}
		slider.SetValue(progress, true);
	}

	// Token: 0x0600C51C RID: 50460 RVA: 0x002CB5F8 File Offset: 0x002C97F8
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

	// Token: 0x0600C51D RID: 50461 RVA: 0x002CB624 File Offset: 0x002C9824
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

	// Token: 0x0600C51E RID: 50462 RVA: 0x002CB68C File Offset: 0x002C988C
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

	// Token: 0x04005AD6 RID: 23254
	[Nullable(1)]
	public Dictionary<int, int> RewardTimeMap = new Dictionary<int, int>();

	// Token: 0x04005AD7 RID: 23255
	public float FullTime;

	// Token: 0x04005AD8 RID: 23256
	[Nullable(2)]
	private DangoAbyssBattleTreasureRoot DangoAbyssBattleTreasureRoot;

	// Token: 0x04005AD9 RID: 23257
	[Nullable(2)]
	private TimerHandle RefreshTimer;

	// Token: 0x02007F72 RID: 32626
	private enum EComponent
	{
		// Token: 0x040299AE RID: 170414
		Button,
		// Token: 0x040299AF RID: 170415
		TimeText,
		// Token: 0x040299B0 RID: 170416
		ProgressSlider,
		// Token: 0x040299B1 RID: 170417
		RewardItemRoot,
		// Token: 0x040299B2 RID: 170418
		RewardItem,
		// Token: 0x040299B3 RID: 170419
		DeadText,
		// Token: 0x040299B4 RID: 170420
		ProgressText,
		// Token: 0x040299B5 RID: 170421
		TitleText,
		// Token: 0x040299B6 RID: 170422
		BarText
	}
}
