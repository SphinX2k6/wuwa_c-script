using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200132B RID: 4907
[NullableContext(2)]
[Nullable(0)]
public class BusinessTipsFinishView : UiViewBase
{
	// Token: 0x06008842 RID: 34882 RVA: 0x001D124B File Offset: 0x001CF44B
	[NullableContext(1)]
	public BusinessTipsFinishView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008843 RID: 34883 RVA: 0x001D1254 File Offset: 0x001CF454
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

	// Token: 0x06008844 RID: 34884 RVA: 0x001D1340 File Offset: 0x001CF540
	private UniTask InitCaptionItem()
	{
		BusinessTipsFinishView.<InitCaptionItem>d__9 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BusinessTipsFinishView.<InitCaptionItem>d__9>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008845 RID: 34885 RVA: 0x001D1384 File Offset: 0x001CF584
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

	// Token: 0x06008846 RID: 34886 RVA: 0x001D13C8 File Offset: 0x001CF5C8
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsFinishView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsFinishView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008847 RID: 34887 RVA: 0x001D140C File Offset: 0x001CF60C
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

	// Token: 0x06008848 RID: 34888 RVA: 0x001D1465 File Offset: 0x001CF665
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Unbind();
		}
		this.RemoveTimerHandle();
	}

	// Token: 0x06008849 RID: 34889 RVA: 0x001D1483 File Offset: 0x001CF683
	private void RemoveTimerHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600884A RID: 34890 RVA: 0x001D14A5 File Offset: 0x001CF6A5
	[NullableContext(1)]
	private CharacterItemWithLine InitCharacterItem()
	{
		return new CharacterItemWithLine();
	}

	// Token: 0x0600884B RID: 34891 RVA: 0x001D14AC File Offset: 0x001CF6AC
	private void OnConfirm()
	{
		DelegationResultData resultData = MoonChasingBusinessModel.Instance.GetResultData();
		int popularityValue = MoonChasingModel.Instance.GetPopularityValue();
		int playerRoleId = MoonChasingBusinessModel.Instance.GetPlayerRoleId();
		string title = (resultData.LastPopularity < popularityValue) ? "Moonfiesta_Title1" : "Moonfiesta_Title2";
		MoonChasingPopularityUpData popularityUpData = new MoonChasingPopularityUpData(playerRoleId, resultData.LastPopularity, popularityValue, resultData.GetRoleDialog(), title);
		MoonChasingController.Instance.OpenTipsPopularityUpView(popularityUpData);
	}

	// Token: 0x0600884C RID: 34892 RVA: 0x001D150E File Offset: 0x001CF70E
	[NullableContext(1)]
	private void PlayNewAudio(string sequenceName, string eventName)
	{
		if (eventName == "New01" && MoonChasingBusinessModel.Instance.GetResultData().IsBest)
		{
			AudioSystem.Instance.PostEvent("play_ui_zhuiyuejie_positive");
		}
	}

	// Token: 0x04003CC0 RID: 15552
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected CharacterListModule<CharacterItemWithLine> CharacterListModule;

	// Token: 0x04003CC1 RID: 15553
	protected RewardItem FirstReward;

	// Token: 0x04003CC2 RID: 15554
	protected RewardItem SecondReward;

	// Token: 0x04003CC3 RID: 15555
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003CC4 RID: 15556
	private TimerHandle TimerHandle;

	// Token: 0x04003CC5 RID: 15557
	private const int TWEEN_TIME = 1;

	// Token: 0x0200797F RID: 31103
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402801D RID: 163869
		public const int Texture = 0;

		// Token: 0x0402801E RID: 163870
		public const int UnChangeItem = 1;

		// Token: 0x0402801F RID: 163871
		public const int NewRecordItem = 2;

		// Token: 0x04028020 RID: 163872
		public const int FirstReward = 3;

		// Token: 0x04028021 RID: 163873
		public const int SecondReward = 4;

		// Token: 0x04028022 RID: 163874
		public const int CharacterListItem = 5;

		// Token: 0x04028023 RID: 163875
		public const int ConfirmBtn = 6;

		// Token: 0x04028024 RID: 163876
		public const int CaptionItem = 7;
	}
}
