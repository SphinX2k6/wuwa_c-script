using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014D7 RID: 5335
[NullableContext(1)]
[Nullable(0)]
public class ActivityRunFailView : UiViewBase
{
	// Token: 0x060097B8 RID: 38840 RVA: 0x0020C7C8 File Offset: 0x0020A9C8
	public ActivityRunFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060097B9 RID: 38841 RVA: 0x0020C7D4 File Offset: 0x0020A9D4
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

	// Token: 0x060097BA RID: 38842 RVA: 0x0020C9D4 File Offset: 0x0020ABD4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRunFailView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRunFailView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060097BB RID: 38843 RVA: 0x0020CA17 File Offset: 0x0020AC17
	protected override void OnStart()
	{
		this.CurrentShowData = (this.OpenParam as RunEndData);
		this.InitAutoLeaveTimer();
	}

	// Token: 0x060097BC RID: 38844 RVA: 0x0020CA30 File Offset: 0x0020AC30
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

	// Token: 0x060097BD RID: 38845 RVA: 0x0020CAA0 File Offset: 0x0020ACA0
	private void RefreshHead()
	{
		UUITexture texture = base.GetTexture(2);
		texture.SetColor(FColor.FromHex("63323AFF"));
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI", texture, null, null);
		base.GetText(1).ShowTextNew("GenericPromptTypes_4_GeneralText");
	}

	// Token: 0x060097BE RID: 38846 RVA: 0x0020CAEC File Offset: 0x0020ACEC
	private UniTask InitButtonAsync()
	{
		ActivityRunFailView.<InitButtonAsync>d__14 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<ActivityRunFailView.<InitButtonAsync>d__14>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060097BF RID: 38847 RVA: 0x0020CB2F File Offset: 0x0020AD2F
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x060097C0 RID: 38848 RVA: 0x0020CB5C File Offset: 0x0020AD5C
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

	// Token: 0x060097C1 RID: 38849 RVA: 0x0020CBA7 File Offset: 0x0020ADA7
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

	// Token: 0x060097C2 RID: 38850 RVA: 0x0020CBE0 File Offset: 0x0020ADE0
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

	// Token: 0x060097C3 RID: 38851 RVA: 0x0020CC33 File Offset: 0x0020AE33
	private void OnClickContinueButton()
	{
		ActivityRunController.Instance.RequestTransToParkourChallenge(this.CurrentShowData.CurrentChallengeId);
	}

	// Token: 0x060097C4 RID: 38852 RVA: 0x0020CC4A File Offset: 0x0020AE4A
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x040042C5 RID: 17093
	private const int LEAVETIME = 30;

	// Token: 0x040042C6 RID: 17094
	private const string FAIL_OUTLINE_COLOR = "63323AFF";

	// Token: 0x040042C7 RID: 17095
	private const string TARGET_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x040042C8 RID: 17096
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x040042C9 RID: 17097
	[Nullable(2)]
	private RunEndData CurrentShowData;

	// Token: 0x040042CA RID: 17098
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ActivityParkourButton> ButtonMap;

	// Token: 0x02007B0E RID: 31502
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402878C RID: 165772
		public const int TxtTitle = 1;

		// Token: 0x0402878D RID: 165773
		public const int TexIcon = 2;

		// Token: 0x0402878E RID: 165774
		public const int ButtonHorizontalItem = 4;

		// Token: 0x0402878F RID: 165775
		public const int ButtonItem = 5;

		// Token: 0x04028790 RID: 165776
		public const int ScoreText = 8;

		// Token: 0x04028791 RID: 165777
		public const int NewRecordItem = 9;

		// Token: 0x04028792 RID: 165778
		public const int PassTimeText = 10;

		// Token: 0x04028793 RID: 165779
		public const int PassTimeDescText = 11;

		// Token: 0x04028794 RID: 165780
		public const int PnlRecord = 12;

		// Token: 0x04028795 RID: 165781
		public const int PnlPassTime = 13;

		// Token: 0x04028796 RID: 165782
		public const int Desc = 14;

		// Token: 0x04028797 RID: 165783
		public const int TitleNia = 15;

		// Token: 0x04028798 RID: 165784
		public const int TexTitleBgL = 16;

		// Token: 0x04028799 RID: 165785
		public const int TexTitleBgR = 17;
	}

	// Token: 0x02007B0F RID: 31503
	[NullableContext(0)]
	private class EButtons
	{
		// Token: 0x0402879A RID: 165786
		public const int LeftButton = 0;

		// Token: 0x0402879B RID: 165787
		public const int RightButton = 1;
	}
}
