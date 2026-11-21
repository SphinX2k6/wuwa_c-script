using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000993 RID: 2451
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunSuccessView : UiViewBase
{
	// Token: 0x06006BCB RID: 27595 RVA: 0x002170D4 File Offset: 0x002152D4
	public ActivityRunSuccessView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006BCC RID: 27596 RVA: 0x002170E0 File Offset: 0x002152E0
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

	// Token: 0x06006BCD RID: 27597 RVA: 0x0021727C File Offset: 0x0021547C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRunSuccessView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRunSuccessView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006BCE RID: 27598 RVA: 0x002172C0 File Offset: 0x002154C0
	private UniTask InitButtonAsync()
	{
		ActivityRunSuccessView.<InitButtonAsync>d__11 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<ActivityRunSuccessView.<InitButtonAsync>d__11>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006BCF RID: 27599 RVA: 0x00217304 File Offset: 0x00215504
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

	// Token: 0x06006BD0 RID: 27600 RVA: 0x00217357 File Offset: 0x00215557
	protected override void OnStart()
	{
		this.CurrentShowData = (this.OpenParam as RunEndData);
	}

	// Token: 0x06006BD1 RID: 27601 RVA: 0x0021736A File Offset: 0x0021556A
	protected override void OnBeforeShow()
	{
		this.RefreshHead();
		this.RefreshScore();
		this.RefreshIfNewRecord();
		this.RefreshTime();
		this.InitAutoLeaveTimer();
	}

	// Token: 0x06006BD2 RID: 27602 RVA: 0x0021738A File Offset: 0x0021558A
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06006BD3 RID: 27603 RVA: 0x002173B8 File Offset: 0x002155B8
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

	// Token: 0x06006BD4 RID: 27604 RVA: 0x00217404 File Offset: 0x00215604
	private void RefreshTime()
	{
		string timeString = TimeUtil.Instance.GetTimeString((double)this.CurrentShowData.CurrentTime);
		base.GetText(10).SetText(timeString, true);
	}

	// Token: 0x06006BD5 RID: 27605 RVA: 0x00217437 File Offset: 0x00215637
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06006BD6 RID: 27606 RVA: 0x0021743F File Offset: 0x0021563F
	private void RefreshIfNewRecord()
	{
		base.GetItem(9).SetUIActive(this.CurrentShowData.IfNewRecord);
	}

	// Token: 0x06006BD7 RID: 27607 RVA: 0x0021745C File Offset: 0x0021565C
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

	// Token: 0x06006BD8 RID: 27608 RVA: 0x002174E2 File Offset: 0x002156E2
	private void RefreshScore()
	{
		base.GetText(8).SetText(this.CurrentShowData.CurrentScore.ToString(), true);
	}

	// Token: 0x06006BD9 RID: 27609 RVA: 0x00217501 File Offset: 0x00215701
	private void OnClickContinueButton()
	{
		ActivityRunController.Instance.RequestTransToParkourChallenge(this.CurrentShowData.CurrentChallengeId);
	}

	// Token: 0x06006BDA RID: 27610 RVA: 0x00217518 File Offset: 0x00215718
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400437D RID: 17277
	private const int LEAVETIME = 30;

	// Token: 0x0400437E RID: 17278
	private const string SUCCESS_OUTLINE_COLOR = "CC9548FF";

	// Token: 0x0400437F RID: 17279
	private const string TARGET_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x04004380 RID: 17280
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x04004381 RID: 17281
	[Nullable(2)]
	private RunEndData CurrentShowData;

	// Token: 0x04004382 RID: 17282
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ActivityParkourButton> ButtonMap;

	// Token: 0x02006CA1 RID: 27809
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023AF1 RID: 146161
		public const int TxtTitle = 1;

		// Token: 0x04023AF2 RID: 146162
		public const int TexIcon = 2;

		// Token: 0x04023AF3 RID: 146163
		public const int ButtonHorizontalItem = 4;

		// Token: 0x04023AF4 RID: 146164
		public const int ButtonItem = 5;

		// Token: 0x04023AF5 RID: 146165
		public const int ScoreText = 8;

		// Token: 0x04023AF6 RID: 146166
		public const int NewRecordItem = 9;

		// Token: 0x04023AF7 RID: 146167
		public const int PassTimeText = 10;

		// Token: 0x04023AF8 RID: 146168
		public const int PassTimeDescText = 11;

		// Token: 0x04023AF9 RID: 146169
		public const int PnlRecord = 12;

		// Token: 0x04023AFA RID: 146170
		public const int PnlPassTime = 13;

		// Token: 0x04023AFB RID: 146171
		public const int TxtFailTip = 14;
	}

	// Token: 0x02006CA2 RID: 27810
	[NullableContext(0)]
	private class EButtons
	{
		// Token: 0x04023AFC RID: 146172
		public const int LeftButton = 0;

		// Token: 0x04023AFD RID: 146173
		public const int RightButton = 1;
	}
}
