using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200167A RID: 5754
[NullableContext(1)]
[Nullable(0)]
public class LordChallengeResultView : UiViewBase
{
	// Token: 0x0600DFFB RID: 57339 RVA: 0x0041BF2D File Offset: 0x0041A12D
	public LordChallengeResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DFFC RID: 57340 RVA: 0x0041BF38 File Offset: 0x0041A138
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

	// Token: 0x0600DFFD RID: 57341 RVA: 0x0041C048 File Offset: 0x0041A248
	protected override UniTask OnBeforeStartAsync()
	{
		LordChallengeResultView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordChallengeResultView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFFE RID: 57342 RVA: 0x0041C08C File Offset: 0x0041A28C
	private UniTask InitButtonAsync()
	{
		LordChallengeResultView.<InitButtonAsync>d__12 <InitButtonAsync>d__;
		<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitButtonAsync>d__.<>4__this = this;
		<InitButtonAsync>d__.<>1__state = -1;
		<InitButtonAsync>d__.<>t__builder.Start<LordChallengeResultView.<InitButtonAsync>d__12>(ref <InitButtonAsync>d__);
		return <InitButtonAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFFF RID: 57343 RVA: 0x0041C0D0 File Offset: 0x0041A2D0
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

	// Token: 0x0600E000 RID: 57344 RVA: 0x0041C12C File Offset: 0x0041A32C
	protected override void OnStart()
	{
		this.CurrentShowData = (this.OpenParam as IResultData);
	}

	// Token: 0x0600E001 RID: 57345 RVA: 0x0041C13F File Offset: 0x0041A33F
	protected override void OnBeforeShow()
	{
		this.RefreshHead();
		this.RefreshScore();
		this.RefreshTime();
		this.InitAutoLeaveTimer();
	}

	// Token: 0x0600E002 RID: 57346 RVA: 0x0041C159 File Offset: 0x0041A359
	private void ClearAutoLeaveTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.AutoLeaveTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLeaveTimerId);
		}
		this.AutoLeaveTimerId = null;
	}

	// Token: 0x0600E003 RID: 57347 RVA: 0x0041C188 File Offset: 0x0041A388
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

	// Token: 0x0600E004 RID: 57348 RVA: 0x0041C1E0 File Offset: 0x0041A3E0
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

	// Token: 0x0600E005 RID: 57349 RVA: 0x0041C248 File Offset: 0x0041A448
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

	// Token: 0x0600E006 RID: 57350 RVA: 0x0041C2CE File Offset: 0x0041A4CE
	protected override void OnBeforeDestroy()
	{
		this.ClearAutoLeaveTimer();
	}

	// Token: 0x0600E007 RID: 57351 RVA: 0x0041C2D8 File Offset: 0x0041A4D8
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

	// Token: 0x0600E008 RID: 57352 RVA: 0x0041C3A9 File Offset: 0x0041A5A9
	private void OnClickBtnLeave()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008091 RID: 32913
	private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

	// Token: 0x04008092 RID: 32914
	private const string SUCCESS_TEX = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x04008093 RID: 32915
	private const string FAIL_OUTLINE_COLOR = "B33100FF";

	// Token: 0x04008094 RID: 32916
	private const string FAIL_TEX = "/Game/Aki/UI/UIResources/Common/Image/IconForceLogo/T_Logo_10_UI.T_Logo_10_UI";

	// Token: 0x04008095 RID: 32917
	private const int CLOSE_BUTTON_KEY = -1;

	// Token: 0x04008096 RID: 32918
	[Nullable(2)]
	private TimerHandle AutoLeaveTimerId;

	// Token: 0x04008097 RID: 32919
	[Nullable(2)]
	private IResultData CurrentShowData;

	// Token: 0x04008098 RID: 32920
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, LordChallengeResultButton> ButtonMap;

	// Token: 0x02007848 RID: 30792
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027085 RID: 159877
		public const int TxtTitle = 1;

		// Token: 0x04027086 RID: 159878
		public const int TexIcon = 2;

		// Token: 0x04027087 RID: 159879
		public const int ButtonHorizontalItem = 4;

		// Token: 0x04027088 RID: 159880
		public const int ButtonItem = 5;

		// Token: 0x04027089 RID: 159881
		public const int ScoreText = 8;

		// Token: 0x0402708A RID: 159882
		public const int NewRecordItem = 9;

		// Token: 0x0402708B RID: 159883
		public const int PassTimeText = 10;

		// Token: 0x0402708C RID: 159884
		public const int PassTimeDescText = 11;

		// Token: 0x0402708D RID: 159885
		public const int PnlRecord = 12;

		// Token: 0x0402708E RID: 159886
		public const int PnlPassTime = 13;

		// Token: 0x0402708F RID: 159887
		public const int TxtFailTip = 14;
	}
}
