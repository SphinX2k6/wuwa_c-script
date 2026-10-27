using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002196 RID: 8598
[NullableContext(1)]
[Nullable(0)]
public class LordChallengeResultView : UiViewBase
{
	// Token: 0x06010B6A RID: 68458 RVA: 0x0040F645 File Offset: 0x0040D845
	public LordChallengeResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010B6B RID: 68459 RVA: 0x0040F650 File Offset: 0x0040D850
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText))
		};
	}

	// Token: 0x06010B6C RID: 68460 RVA: 0x0040F760 File Offset: 0x0040D960
	protected override UniTask OnBeforeStartAsync()
	{
		LordChallengeResultView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordChallengeResultView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B6D RID: 68461 RVA: 0x0040F7A4 File Offset: 0x0040D9A4
	private UniTask InitButtonAsync()
	{
		LordChallengeResultView.<InitButtonAsync>d__12 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<LordChallengeResultView.<InitButtonAsync>d__12>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B6E RID: 68462 RVA: 0x0040F7E8 File Offset: 0x0040D9E8
	private UniTask CreateButton(UUIItem uiItem, int buttonIndex, string title, Action clickFunction)
	{
		LordChallengeResultView.<CreateButton>d__13 <CreateButton>d__;
		<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButton>d__.<>4__this = this;
		<CreateButton>d__.buttonIndex = buttonIndex;
		<CreateButton>d__.title = title;
		<CreateButton>d__.clickFunction = clickFunction;
		<CreateButton>d__.<>1__state = -1;
		<CreateButton>d__.<>t__builder.Start<LordChallengeResultView.<CreateButton>d__13>(ref <CreateButton>d__);
		return <CreateButton>d__.<>t__builder.Task;
	}

	// Token: 0x06010B6F RID: 68463 RVA: 0x0040F844 File Offset: 0x0040DA44
	protected override void OnStart()
	{
		this.CurrentShowData = (this.OpenParam as IResultData);
	}

	// Token: 0x06010B70 RID: 68464 RVA: 0x0040F857 File Offset: 0x0040DA57
	protected override void OnBeforeShow()
	{
		this.RefreshHead();
		this.RefreshScore();
		this.RefreshTime();
		this.InitAutoLeaveTimer();
	}

	// Token: 0x06010B71 RID: 68465 RVA: 0x0040F871 File Offset: 0x0040DA71
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x06010B72 RID: 68466 RVA: 0x0040F8A0 File Offset: 0x0040DAA0
	private void InitAutoLeaveTimer()
	{
		int leftSecondToAutoLeave = this.CurrentShowData.AutoCloseTime + 1;
		this.AutoLeaveTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			int leftSecondToAutoLeave;
			if (leftSecondToAutoLeave <= 0)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
				this.OnClickBtnLeave();
				return;
			}
			LordChallengeResultButton valueOrDefault = this.ButtonMap.GetValueOrDefault(-1);
			string textId = "Text_InstanceDungeonLeftTimeToAutoLeave_Text";
			string[] array = new string[1];
			int num = 0;
			leftSecondToAutoLeave = leftSecondToAutoLeave;
			leftSecondToAutoLeave--;
			array[num] = leftSecondToAutoLeave.ToString();
			valueOrDefault.SetFloatText(textId, array);
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06010B73 RID: 68467 RVA: 0x0040F8F8 File Offset: 0x0040DAF8
	private void RefreshTime()
	{
		bool flag = this.CurrentShowData.PassTime != null;
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			string timeString = TimeUtil.Instance.GetTimeString((double)this.CurrentShowData.PassTime.Value);
			base.GetText(10).SetText(timeString, true);
		}
	}

	// Token: 0x06010B74 RID: 68468 RVA: 0x0040F960 File Offset: 0x0040DB60
	private void RefreshScore()
	{
		IResultData currentShowData = this.CurrentShowData;
		bool flag = currentShowData != null && currentShowData.Score != null;
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			base.GetText(8).SetText(this.CurrentShowData.Score.Value.ToString(), true);
			UUIItem item2 = base.GetItem(9);
			IResultData currentShowData2 = this.CurrentShowData;
			item2.SetUIActive(currentShowData2 != null && currentShowData2.IsNewRecord);
		}
	}

	// Token: 0x06010B75 RID: 68469 RVA: 0x0040F9E6 File Offset: 0x0040DBE6
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x06010B76 RID: 68470 RVA: 0x0040F9F0 File Offset: 0x0040DBF0
	private void RefreshHead()
	{
		IResultData currentShowData = this.CurrentShowData;
		bool flag = currentShowData != null && currentShowData.Result == EGamePlayResult.Success;
		base.GetItem(12).SetUIActive(flag);
		base.GetItem(13).SetUIActive(flag);
		base.GetText(14).SetUIActive(!flag);
		UUITexture texture = base.GetTexture(2);
		string path = flag ? "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI" : "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";
		string hexStr = flag ? "C48B29FF" : "B33100FF";
		string textStringId = flag ? "GenericPromptTypes_3_GeneralText" : "GenericPromptTypes_4_GeneralText";
		texture.SetColor(FColor.FromHex(hexStr));
		base.SetTextureByPath(path, texture, null, null);
		UUIText text = base.GetText(1);
		text.SetColor(FColor.FromHex(hexStr));
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x06010B77 RID: 68471 RVA: 0x0040FAC1 File Offset: 0x0040DCC1
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x04007F4A RID: 32586
	private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

	// Token: 0x04007F4B RID: 32587
	private const string SUCCESS_TEX = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x04007F4C RID: 32588
	private const string FAIL_OUTLINE_COLOR = "B33100FF";

	// Token: 0x04007F4D RID: 32589
	private const string FAIL_TEX = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x04007F4E RID: 32590
	private const int CLOSE_BUTTON_KEY = -1;

	// Token: 0x04007F4F RID: 32591
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x04007F50 RID: 32592
	[Nullable(2)]
	private IResultData CurrentShowData;

	// Token: 0x04007F51 RID: 32593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, LordChallengeResultButton> ButtonMap;

	// Token: 0x020086BD RID: 34493
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402BD64 RID: 179556
		public const int TxtTitle = 1;

		// Token: 0x0402BD65 RID: 179557
		public const int TexIcon = 2;

		// Token: 0x0402BD66 RID: 179558
		public const int ButtonHorizontalItem = 4;

		// Token: 0x0402BD67 RID: 179559
		public const int ButtonItem = 5;

		// Token: 0x0402BD68 RID: 179560
		public const int ScoreText = 8;

		// Token: 0x0402BD69 RID: 179561
		public const int NewRecordItem = 9;

		// Token: 0x0402BD6A RID: 179562
		public const int PassTimeText = 10;

		// Token: 0x0402BD6B RID: 179563
		public const int PassTimeDescText = 11;

		// Token: 0x0402BD6C RID: 179564
		public const int PnlRecord = 12;

		// Token: 0x0402BD6D RID: 179565
		public const int PnlPassTime = 13;

		// Token: 0x0402BD6E RID: 179566
		public const int TxtFailTip = 14;
	}
}
