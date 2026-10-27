using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE3 RID: 23523
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalView : UiViewBase
	{
		// Token: 0x0603B75F RID: 243551 RVA: 0x00E2D9F7 File Offset: 0x00E2BBF7
		public CiacconaGalView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B760 RID: 243552 RVA: 0x00E2DA00 File Offset: 0x00E2BC00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickMask));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.HideAvg));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B761 RID: 243553 RVA: 0x00E2DB6E File Offset: 0x00E2BD6E
		protected override void OnBeforeShow()
		{
			this.WarmUpIcon();
			base.GetTexture(3).SetUIActive(false);
		}

		// Token: 0x0603B762 RID: 243554 RVA: 0x00E2DB84 File Offset: 0x00E2BD84
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B763 RID: 243555 RVA: 0x00E2DBC8 File Offset: 0x00E2BDC8
		protected override void OnStart()
		{
			CiacconaGalController.Instance.AddOnStepDataUpdate(new Action<int>(this.OnDataUpdate));
			CiacconaGalController.Instance.GalPlayer.AddOnStateChange(new Action<ECiacconaGalPlayerState>(this.OnGalPlayerStateChange));
			CiacconaGalController.Instance.SetGalViewReady(true);
			int curHandlingChapterId = CiacconaGalController.Instance.GalPlayer.CurHandlingChapterId;
			CiacconaGalChapterData chapterDataById = CiacconaGalModel.Instance.GetChapterDataById(curHandlingChapterId);
			if (!string.IsNullOrEmpty(chapterDataById.MusicEvent))
			{
				this.MusicHandle = AudioSystem.Instance.PostEvent(chapterDataById.MusicEvent);
			}
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B764 RID: 243556 RVA: 0x00E2DC64 File Offset: 0x00E2BE64
		protected override void OnBeforeDestroy()
		{
			CiacconaGalController.Instance.SetGalViewReady(false);
			CiacconaGalController.Instance.GalPlayer.RemoveOnStateChange(new Action<ECiacconaGalPlayerState>(this.OnGalPlayerStateChange));
			CiacconaGalController.Instance.RemoveOnStepDataUpdate(new Action<int>(this.OnDataUpdate));
			if (this.AudioHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(500)
				}));
			}
			if (this.MusicHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.MusicHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(500)
				}));
			}
			EventSystem.Instance.Emit<bool>(EEventName.OnCiacconaAvgInspirationChoiceShow, false);
		}

		// Token: 0x0603B765 RID: 243557 RVA: 0x00E2DD30 File Offset: 0x00E2BF30
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCiacconaAvgReChoose, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChoose));
			EventSystem.Instance.Add(EEventName.OnCiacconaReChooseConfirm, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChooseConfirm));
			EventSystem.Instance.Add(EEventName.OnCiacconaReChooseCancel, new Action(this.OnCiacconaAvgReChooseCancel));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603B766 RID: 243558 RVA: 0x00E2DDB0 File Offset: 0x00E2BFB0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaAvgReChoose, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChoose));
			EventSystem.Instance.Remove(EEventName.OnCiacconaReChooseConfirm, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChooseConfirm));
			EventSystem.Instance.Remove(EEventName.OnCiacconaReChooseCancel, new Action(this.OnCiacconaAvgReChooseCancel));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603B767 RID: 243559 RVA: 0x00E2DE30 File Offset: 0x00E2C030
		private void PlayImageChangeAnim(string imagePath)
		{
			this.NextImagePath = imagePath;
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Next", false, null, false);
		}

		// Token: 0x0603B768 RID: 243560 RVA: 0x00E2DE64 File Offset: 0x00E2C064
		private UniTask UpdateImageAsync(string path)
		{
			CiacconaGalView.<UpdateImageAsync>d__23 <UpdateImageAsync>d__;
			<UpdateImageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateImageAsync>d__.<>4__this = this;
			<UpdateImageAsync>d__.path = path;
			<UpdateImageAsync>d__.<>1__state = -1;
			<UpdateImageAsync>d__.<>t__builder.Start<CiacconaGalView.<UpdateImageAsync>d__23>(ref <UpdateImageAsync>d__);
			return <UpdateImageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B769 RID: 243561 RVA: 0x00E2DEB0 File Offset: 0x00E2C0B0
		private void WarmUpIcon()
		{
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon01"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon02"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon03"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon04"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon05"), this.MemoryTag);
		}

		// Token: 0x0603B76A RID: 243562 RVA: 0x00E2DF60 File Offset: 0x00E2C160
		private void ShowAvg()
		{
			this.IsViewHide = false;
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Show", false, null, false);
			}
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetUiActive(true);
			}
			CiacconaGalStepPlayerNormalPanel galPanelNormal = this.GalPanelNormal;
			if (galPanelNormal != null)
			{
				galPanelNormal.SetActive(!this.IsReChoosing);
			}
			if (!this.IsReChoosing)
			{
				CiacconaGalStepPlayerNormalPanel galPanelNormal2 = this.GalPanelNormal;
				if (galPanelNormal2 != null)
				{
					galPanelNormal2.PlayStart();
				}
			}
			CiacconaGalStepPlayerReChoosePanel galPanelReChoose = this.GalPanelReChoose;
			if (galPanelReChoose != null)
			{
				galPanelReChoose.SetActive(this.IsReChoosing);
			}
			if (this.IsReChoosing)
			{
				CiacconaGalStepPlayerReChoosePanel galPanelReChoose2 = this.GalPanelReChoose;
				if (galPanelReChoose2 != null)
				{
					galPanelReChoose2.PlayStart();
				}
			}
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			this.OnGalPlayerStateChange(this.CurState);
		}

		// Token: 0x0603B76B RID: 243563 RVA: 0x00E2E030 File Offset: 0x00E2C230
		private void OnDataUpdate(int stepId)
		{
			this.GalPanelNormal.Refresh();
			if (this.CurStepId != stepId)
			{
				this.CurStepId = stepId;
				CiacconaGalStepData stepDataById = CiacconaGalModel.Instance.GetStepDataById(stepId);
				AudioSystem.Instance.PostEvent("play_ui_ia_com_click_small");
				if (!string.IsNullOrEmpty(stepDataById.ImagePath))
				{
					this.PlayImageChangeAnim(stepDataById.ImagePath);
				}
				if (string.IsNullOrEmpty(this.CurImagePath))
				{
					CiacconaGalStepData[] curStepDataList = CiacconaGalModel.Instance.GetCurStepDataList();
					for (int i = curStepDataList.Length - 1; i >= 0; i--)
					{
						CiacconaGalStepData ciacconaGalStepData = curStepDataList[i];
						if (!string.IsNullOrEmpty(ciacconaGalStepData.ImagePath))
						{
							this.UpdateImageAsync(ciacconaGalStepData.ImagePath).Forget();
							break;
						}
					}
				}
				if (!string.IsNullOrEmpty(stepDataById.AudioEvent))
				{
					if (this.AudioHandle != 0)
					{
						AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
						{
							TransitionDuration = new int?(500)
						}));
					}
					this.AudioHandle = AudioSystem.Instance.PostEvent(stepDataById.AudioEvent);
				}
				if (!string.IsNullOrEmpty(stepDataById.MusicState))
				{
					string musicState = stepDataById.MusicState;
					AudioSystem.Instance.SetState("caccona_gal_music", musicState, true);
				}
				if (stepDataById.SubEndingId != 0)
				{
					CiacconaGalSubEndingData subEndingDataById = CiacconaGalModel.Instance.GetSubEndingDataById(stepDataById.SubEndingId);
					if ((!subEndingDataById.IsFinished || subEndingDataById.IsFaked) && subEndingDataById.ShouldExitOnFirstFinish)
					{
						this.UiViewSequence.HideSequenceName = "Close02";
						this.UiViewSequence.CloseSequenceName = "Close02";
					}
				}
			}
		}

		// Token: 0x0603B76C RID: 243564 RVA: 0x00E2E1B4 File Offset: 0x00E2C3B4
		private void OnGalPlayerStateChange(ECiacconaGalPlayerState state)
		{
			this.CurState = state;
			base.GetItem(4).SetUIActive((state == ECiacconaGalPlayerState.Playing || state == ECiacconaGalPlayerState.Skipping) && !this.IsViewHide);
			base.GetItem(5).SetUIActive(state == ECiacconaGalPlayerState.Pausing && !this.IsViewHide);
		}

		// Token: 0x0603B76D RID: 243565 RVA: 0x00E2E204 File Offset: 0x00E2C404
		private void OnClickMask()
		{
			if (this.IsViewHide)
			{
				this.ShowAvg();
				return;
			}
			CiacconaGalController.Instance.GalPlayer.OnClick(null);
		}

		// Token: 0x0603B76E RID: 243566 RVA: 0x00E2E238 File Offset: 0x00E2C438
		private void OnCiacconaAvgReChoose(CiacconaGalStepData stepData, CiacconaGalChoiceData choiceData)
		{
			if (this.IsViewHide)
			{
				return;
			}
			this.GalPanelNormal.PlayCloseAsync().Forget();
			this.GalPanelReChoose.SetActive(true);
			this.GalPanelReChoose.PlayStart();
			this.GalPanelReChoose.Refresh(stepData, choiceData);
			this.IsReChoosing = true;
		}

		// Token: 0x0603B76F RID: 243567 RVA: 0x00E2E28C File Offset: 0x00E2C48C
		private void OnCiacconaAvgReChooseConfirm(CiacconaGalStepData stepData, CiacconaGalChoiceData choiceData)
		{
			if (this.IsViewHide)
			{
				return;
			}
			this.GalPanelNormal.SetActive(true);
			this.GalPanelNormal.PlayStart();
			this.GalPanelReChoose.PlayCloseAsync().Forget();
			stepData.ChosenId = choiceData.Id;
			int toStepId = (choiceData.ToStepId == 0) ? stepData.NextStepId : choiceData.ToStepId;
			CiacconaGalController.Instance.GalPlayer.TryContinue(toStepId);
			this.IsReChoosing = false;
		}

		// Token: 0x0603B770 RID: 243568 RVA: 0x00E2E303 File Offset: 0x00E2C503
		private void OnCiacconaAvgReChooseCancel()
		{
			if (this.IsViewHide)
			{
				return;
			}
			this.GalPanelNormal.SetActive(true);
			this.GalPanelNormal.PlayStart();
			this.GalPanelReChoose.PlayCloseAsync().Forget();
			this.IsReChoosing = false;
		}

		// Token: 0x0603B771 RID: 243569 RVA: 0x00E2E33C File Offset: 0x00E2C53C
		private void HideAvg()
		{
			this.IsViewHide = true;
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Hide", false, null, false);
			}
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetUiActive(false);
			}
			base.GetButton(6).RootUIComp.Get().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			if (this.IsReChoosing)
			{
				CiacconaGalStepPlayerReChoosePanel galPanelReChoose = this.GalPanelReChoose;
				if (galPanelReChoose == null)
				{
					return;
				}
				galPanelReChoose.PlayCloseAsync().Forget();
				return;
			}
			else
			{
				CiacconaGalStepPlayerNormalPanel galPanelNormal = this.GalPanelNormal;
				if (galPanelNormal == null)
				{
					return;
				}
				galPanelNormal.PlayCloseAsync().Forget();
				return;
			}
		}

		// Token: 0x0603B772 RID: 243570 RVA: 0x00E2E3EC File Offset: 0x00E2C5EC
		private void OnExit()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CiacconaAvgExit);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				if (CiacconaGalController.Instance.GalPlayer.GetCurState() == ECiacconaGalPlayerState.SubEnding)
				{
					CiacconaGalController.Instance.ExitAvg().Forget();
					return;
				}
				base.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603B773 RID: 243571 RVA: 0x00E2E428 File Offset: 0x00E2C628
		private void OnActivitySequenceEmitEvent(string eventName)
		{
			if (eventName == "Change")
			{
				this.UpdateImageAsync(this.NextImagePath).Forget();
			}
		}

		// Token: 0x0603B774 RID: 243572 RVA: 0x00E2E448 File Offset: 0x00E2C648
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
			string a = configParams[0];
			if (a == "ChoicesSelect" || a == "FirstChoice")
			{
				return this.GalPanelNormal.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			if (a == "Inspiration")
			{
				CiacconaTitleInspirationItem ciacconaTitleItem = this.CiacconaTitleItem;
				UUIItem uuiitem = (ciacconaTitleItem != null) ? ciacconaTitleItem.GetRootItem() : null;
				if (uuiitem != null)
				{
					return new UUIItem[]
					{
						uuiitem,
						uuiitem
					};
				}
			}
			return null;
		}

		// Token: 0x0401EFAB RID: 126891
		private CiacconaGalStepPlayerNormalPanel GalPanelNormal;

		// Token: 0x0401EFAC RID: 126892
		private CiacconaGalStepPlayerReChoosePanel GalPanelReChoose;

		// Token: 0x0401EFAD RID: 126893
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401EFAE RID: 126894
		private CiacconaTitleInspirationItem CiacconaTitleItem;

		// Token: 0x0401EFAF RID: 126895
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401EFB0 RID: 126896
		private int CurStepId;

		// Token: 0x0401EFB1 RID: 126897
		private int AudioHandle;

		// Token: 0x0401EFB2 RID: 126898
		private string CurImagePath;

		// Token: 0x0401EFB3 RID: 126899
		private int MusicHandle;

		// Token: 0x0401EFB4 RID: 126900
		private string NextImagePath;

		// Token: 0x0401EFB5 RID: 126901
		private bool IsViewHide;

		// Token: 0x0401EFB6 RID: 126902
		private bool IsReChoosing;

		// Token: 0x0401EFB7 RID: 126903
		private ECiacconaGalPlayerState CurState;

		// Token: 0x0200BDC5 RID: 48581
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403938C RID: 234380
			public const int ItemCaption = 0;

			// Token: 0x0403938D RID: 234381
			public const int ItemContent = 1;

			// Token: 0x0403938E RID: 234382
			public const int BtnMask = 2;

			// Token: 0x0403938F RID: 234383
			public const int TextureImage = 3;

			// Token: 0x04039390 RID: 234384
			public const int ItemOnGoing = 4;

			// Token: 0x04039391 RID: 234385
			public const int ItemContinue = 5;

			// Token: 0x04039392 RID: 234386
			public const int BtnHide = 6;
		}
	}
}
