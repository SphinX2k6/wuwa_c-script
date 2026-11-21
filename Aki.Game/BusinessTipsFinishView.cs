using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007DF RID: 2015
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsFinishView : UiViewBase
{
	// Token: 0x06005BDD RID: 23517 RVA: 0x001DA0B7 File Offset: 0x001D82B7
	[NullableContext(1)]
	public BusinessTipsFinishView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x001DA0C0 File Offset: 0x001D82C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnConfirm))
		};
	}

	// Token: 0x06005BDF RID: 23519 RVA: 0x001DA1AC File Offset: 0x001D83AC
	private UniTask InitCaptionItem()
	{
		BusinessTipsFinishView.<InitCaptionItem>d__9 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BusinessTipsFinishView.<InitCaptionItem>d__9>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x001DA1F0 File Offset: 0x001D83F0
	private void InitSequenceData()
	{
		if (MoonChasingBusinessModel.Instance.GetResultData().EvaluationLevel < 7)
		{
			UiViewData uiViewData = new UiViewData();
			uiViewData.StartSequenceName = "Start01";
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.SetSequenceName(uiViewData);
		}
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x001DA234 File Offset: 0x001D8434
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsFinishView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsFinishView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x001DA278 File Offset: 0x001D8478
	protected override void OnAfterPlayStartSequence()
	{
		AudioSystem.Instance.PostEvent("play_ui_figure_up_end");
		RewardItem firstReward = this.FirstReward;
		if (firstReward != null)
		{
			firstReward.ShowAddValue().Forget();
		}
		RewardItem secondReward = this.SecondReward;
		if (secondReward == null)
		{
			return;
		}
		secondReward.ShowAddValue().ContinueWith(delegate()
		{
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.TimerHandle = null;
				UUIButtonComponent button = base.GetButton(6);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(true);
				}
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlaySequencePurely("AtnStart", false, false);
			}, 1000f, null, null, true, 1f);
		}).Forget();
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x001DA2D1 File Offset: 0x001D84D1
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Unbind();
		}
		this.RemoveTimerHandle();
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x001DA2EF File Offset: 0x001D84EF
	private void RemoveTimerHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x001DA311 File Offset: 0x001D8511
	[NullableContext(1)]
	private CharacterItemWithLine InitCharacterItem()
	{
		return new CharacterItemWithLine();
	}

	// Token: 0x06005BE6 RID: 23526 RVA: 0x001DA318 File Offset: 0x001D8518
	private void OnConfirm()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int popularityValue = MoonChasingModel.Instance.GetPopularityValue();
		int playerRoleId = MoonChasingBusinessModel.Instance.GetPlayerRoleId();
		string title = (resultData.LastPopularity < popularityValue) ? "Moonfiesta_Title1" : "Moonfiesta_Title2";
		MoonChasingPopularityUpData popularityUpData = new MoonChasingPopularityUpData(playerRoleId, resultData.LastPopularity, popularityValue, resultData.GetRoleDialog(), title);
		MoonChasingController.Instance.OpenTipsPopularityUpView(popularityUpData);
	}

	// Token: 0x06005BE7 RID: 23527 RVA: 0x001DA37A File Offset: 0x001D857A
	[NullableContext(1)]
	private void PlayNewAudio(string sequenceName, string eventName)
	{
		if (eventName == "New01" && MoonChasingBusinessModel.Instance.GetResultData().IsBest)
		{
			AudioSystem.Instance.PostEvent("play_ui_zhuiyuejie_positive");
		}
	}

	// Token: 0x04003D58 RID: 15704
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithLine> CharacterListModule;

	// Token: 0x04003D59 RID: 15705
	protected RewardItem FirstReward;

	// Token: 0x04003D5A RID: 15706
	protected RewardItem SecondReward;

	// Token: 0x04003D5B RID: 15707
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003D5C RID: 15708
	private TimerHandle TimerHandle;

	// Token: 0x04003D5D RID: 15709
	private const int TWEEN_TIME = 1;

	// Token: 0x02006B09 RID: 27401
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402334A RID: 144202
		public const int Texture = 0;

		// Token: 0x0402334B RID: 144203
		public const int UnChangeItem = 1;

		// Token: 0x0402334C RID: 144204
		public const int NewRecordItem = 2;

		// Token: 0x0402334D RID: 144205
		public const int FirstReward = 3;

		// Token: 0x0402334E RID: 144206
		public const int SecondReward = 4;

		// Token: 0x0402334F RID: 144207
		public const int CharacterListItem = 5;

		// Token: 0x04023350 RID: 144208
		public const int ConfirmBtn = 6;

		// Token: 0x04023351 RID: 144209
		public const int CaptionItem = 7;
	}
}
