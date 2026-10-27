using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014DB RID: 5339
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunSuccessView : UiViewBase
{
	// Token: 0x060097F1 RID: 38897 RVA: 0x0020D394 File Offset: 0x0020B594
	public ActivityRunSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060097F2 RID: 38898 RVA: 0x0020D3A0 File Offset: 0x0020B5A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060097F3 RID: 38899 RVA: 0x0020D53C File Offset: 0x0020B73C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRunSuccessView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRunSuccessView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060097F4 RID: 38900 RVA: 0x0020D580 File Offset: 0x0020B780
	private UniTask InitButtonAsync()
	{
		ActivityRunSuccessView.<InitButtonAsync>d__11 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<ActivityRunSuccessView.<InitButtonAsync>d__11>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060097F5 RID: 38901 RVA: 0x0020D5C4 File Offset: 0x0020B7C4
	private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
	{
		ActivityRunSuccessView.<CreateButton>d__12 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.buttonIndex = buttonIndex;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<ActivityRunSuccessView.<CreateButton>d__12>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x060097F6 RID: 38902 RVA: 0x0020D617 File Offset: 0x0020B817
	protected override void OnStart()
	{
		this.CurrentShowData = (this.OpenParam as RunEndData);
	}

	// Token: 0x060097F7 RID: 38903 RVA: 0x0020D62A File Offset: 0x0020B82A
	protected override void OnBeforeShow()
	{
		this.RefreshHead();
		this.RefreshScore();
		this.RefreshIfNewRecord();
		this.RefreshTime();
		this.InitAutoLeaveTimer();
	}

	// Token: 0x060097F8 RID: 38904 RVA: 0x0020D64A File Offset: 0x0020B84A
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x060097F9 RID: 38905 RVA: 0x0020D678 File Offset: 0x0020B878
	private void InitAutoLeaveTimer()
	{
		int leftSecondToAutoLeave = 31;
		this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			int leftSecondToAutoLeave;
			if (leftSecondToAutoLeave <= 0)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
				this.OnClickBtnLeave();
				return;
			}
			ActivityParkourButton activityParkourButton = this.ButtonMap[0];
			string textId = "InstanceDungeonLeftTimeToAutoLeave";
			string[] array = new string[1];
			int num = 0;
			leftSecondToAutoLeave = leftSecondToAutoLeave;
			leftSecondToAutoLeave--;
			array[num] = leftSecondToAutoLeave.ToString();
			activityParkourButton.SetFloatText(textId, array);
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x060097FA RID: 38906 RVA: 0x0020D6C4 File Offset: 0x0020B8C4
	private void RefreshTime()
	{
		string timeString = TimeUtil.Instance.GetTimeString((double)this.CurrentShowData.CurrentTime);
		base.GetText(10).SetText(timeString, true);
	}

	// Token: 0x060097FB RID: 38907 RVA: 0x0020D6F7 File Offset: 0x0020B8F7
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x060097FC RID: 38908 RVA: 0x0020D6FF File Offset: 0x0020B8FF
	private void RefreshIfNewRecord()
	{
		base.GetItem(9).SetUIActive(this.CurrentShowData.IfNewRecord);
	}

	// Token: 0x060097FD RID: 38909 RVA: 0x0020D71C File Offset: 0x0020B91C
	private void RefreshHead()
	{
		base.GetItem(12).SetUIActive(true);
		base.GetItem(13).SetUIActive(true);
		base.GetText(14).SetUIActive(false);
		UUITexture texture = base.GetTexture(2);
		texture.SetColor(FColor.FromHex("CC9548FF"));
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI", texture, null, null);
		UUIText text = base.GetText(1);
		text.SetColor(FColor.FromHex("FFFFFFFF"));
		text.ShowTextNew("GenericPromptTypes_3_GeneralText");
	}

	// Token: 0x060097FE RID: 38910 RVA: 0x0020D7A2 File Offset: 0x0020B9A2
	private void RefreshScore()
	{
		base.GetText(8).SetText(this.CurrentShowData.CurrentScore.ToString(), true);
	}

	// Token: 0x060097FF RID: 38911 RVA: 0x0020D7C1 File Offset: 0x0020B9C1
	private void OnClickContinueButton()
	{
		ActivityRunController.Instance.RequestTransToParkourChallenge(this.CurrentShowData.CurrentChallengeId);
	}

	// Token: 0x06009800 RID: 38912 RVA: 0x0020D7D8 File Offset: 0x0020B9D8
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x040042D8 RID: 17112
	private const int LEAVETIME = 30;

	// Token: 0x040042D9 RID: 17113
	private const string SUCCESS_OUTLINE_COLOR = "CC9548FF";

	// Token: 0x040042DA RID: 17114
	private const string TARGET_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x040042DB RID: 17115
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x040042DC RID: 17116
	[Nullable(2)]
	private RunEndData CurrentShowData;

	// Token: 0x040042DD RID: 17117
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ActivityParkourButton> ButtonMap;

	// Token: 0x02007B15 RID: 31509
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040287B3 RID: 165811
		public const int TxtTitle = 1;

		// Token: 0x040287B4 RID: 165812
		public const int TexIcon = 2;

		// Token: 0x040287B5 RID: 165813
		public const int ButtonHorizontalItem = 4;

		// Token: 0x040287B6 RID: 165814
		public const int ButtonItem = 5;

		// Token: 0x040287B7 RID: 165815
		public const int ScoreText = 8;

		// Token: 0x040287B8 RID: 165816
		public const int NewRecordItem = 9;

		// Token: 0x040287B9 RID: 165817
		public const int PassTimeText = 10;

		// Token: 0x040287BA RID: 165818
		public const int PassTimeDescText = 11;

		// Token: 0x040287BB RID: 165819
		public const int PnlRecord = 12;

		// Token: 0x040287BC RID: 165820
		public const int PnlPassTime = 13;

		// Token: 0x040287BD RID: 165821
		public const int TxtFailTip = 14;
	}

	// Token: 0x02007B16 RID: 31510
	[NullableContext(0)]
	private class EButtons
	{
		// Token: 0x040287BE RID: 165822
		public const int LeftButton = 0;

		// Token: 0x040287BF RID: 165823
		public const int RightButton = 1;
	}
}
