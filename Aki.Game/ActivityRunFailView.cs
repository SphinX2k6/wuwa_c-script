using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200098F RID: 2447
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunFailView : UiViewBase
{
	// Token: 0x06006B92 RID: 27538 RVA: 0x00216508 File Offset: 0x00214708
	public ActivityRunFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006B93 RID: 27539 RVA: 0x00216514 File Offset: 0x00214714
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x00216714 File Offset: 0x00214914
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRunFailView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRunFailView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006B95 RID: 27541 RVA: 0x00216757 File Offset: 0x00214957
	protected override void OnStart()
	{
		this.CurrentShowData = (this.OpenParam as RunEndData);
		this.InitAutoLeaveTimer();
	}

	// Token: 0x06006B96 RID: 27542 RVA: 0x00216770 File Offset: 0x00214970
	protected override void OnBeforeShow()
	{
		base.GetItem(12).SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetTexture(16).SetUIActive(false);
		base.GetTexture(17).SetUIActive(false);
		base.GetText(14).SetUIActive(true);
		UUINiagara uiNiagara = base.GetUiNiagara(15);
		if (uiNiagara != null)
		{
			uiNiagara.SetUIActive(false);
		}
		this.RefreshHead();
	}

	// Token: 0x06006B97 RID: 27543 RVA: 0x002167E0 File Offset: 0x002149E0
	private void RefreshHead()
	{
		UUITexture texture = base.GetTexture(2);
		texture.SetColor(FColor.FromHex("63323AFF"));
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI", texture, null, null);
		base.GetText(1).ShowTextNew("GenericPromptTypes_4_GeneralText");
	}

	// Token: 0x06006B98 RID: 27544 RVA: 0x0021682C File Offset: 0x00214A2C
	private UniTask InitButtonAsync()
	{
		ActivityRunFailView.<InitButtonAsync>d__14 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<ActivityRunFailView.<InitButtonAsync>d__14>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006B99 RID: 27545 RVA: 0x0021686F File Offset: 0x00214A6F
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06006B9A RID: 27546 RVA: 0x0021689C File Offset: 0x00214A9C
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

	// Token: 0x06006B9B RID: 27547 RVA: 0x002168E7 File Offset: 0x00214AE7
	protected override void OnBeforeDestroy()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(15);
		if (uiNiagara != null)
		{
			uiNiagara.SetUIActive(true);
		}
		base.GetTexture(16).SetUIActive(true);
		base.GetTexture(17).SetUIActive(true);
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06006B9C RID: 27548 RVA: 0x00216920 File Offset: 0x00214B20
	private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
	{
		ActivityRunFailView.<CreateButton>d__18 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.buttonIndex = buttonIndex;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<ActivityRunFailView.<CreateButton>d__18>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x00216973 File Offset: 0x00214B73
	private void OnClickContinueButton()
	{
		ActivityRunController.Instance.RequestTransToParkourChallenge(this.CurrentShowData.CurrentChallengeId);
	}

	// Token: 0x06006B9E RID: 27550 RVA: 0x0021698A File Offset: 0x00214B8A
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400436A RID: 17258
	private const int LEAVETIME = 30;

	// Token: 0x0400436B RID: 17259
	private const string FAIL_OUTLINE_COLOR = "63323AFF";

	// Token: 0x0400436C RID: 17260
	private const string TARGET_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x0400436D RID: 17261
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x0400436E RID: 17262
	[Nullable(2)]
	private RunEndData CurrentShowData;

	// Token: 0x0400436F RID: 17263
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ActivityParkourButton> ButtonMap;

	// Token: 0x02006C9A RID: 27802
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023ACA RID: 146122
		public const int TxtTitle = 1;

		// Token: 0x04023ACB RID: 146123
		public const int TexIcon = 2;

		// Token: 0x04023ACC RID: 146124
		public const int ButtonHorizontalItem = 4;

		// Token: 0x04023ACD RID: 146125
		public const int ButtonItem = 5;

		// Token: 0x04023ACE RID: 146126
		public const int ScoreText = 8;

		// Token: 0x04023ACF RID: 146127
		public const int NewRecordItem = 9;

		// Token: 0x04023AD0 RID: 146128
		public const int PassTimeText = 10;

		// Token: 0x04023AD1 RID: 146129
		public const int PassTimeDescText = 11;

		// Token: 0x04023AD2 RID: 146130
		public const int PnlRecord = 12;

		// Token: 0x04023AD3 RID: 146131
		public const int PnlPassTime = 13;

		// Token: 0x04023AD4 RID: 146132
		public const int Desc = 14;

		// Token: 0x04023AD5 RID: 146133
		public const int TitleNia = 15;

		// Token: 0x04023AD6 RID: 146134
		public const int TexTitleBgL = 16;

		// Token: 0x04023AD7 RID: 146135
		public const int TexTitleBgR = 17;
	}

	// Token: 0x02006C9B RID: 27803
	[NullableContext(0)]
	private class EButtons
	{
		// Token: 0x04023AD8 RID: 146136
		public const int LeftButton = 0;

		// Token: 0x04023AD9 RID: 146137
		public const int RightButton = 1;
	}
}
