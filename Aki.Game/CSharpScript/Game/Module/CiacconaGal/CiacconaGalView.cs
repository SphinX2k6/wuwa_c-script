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
	// Token: 0x02004BC3 RID: 19395
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalView : UiViewBase
	{
		// Token: 0x060306AA RID: 198314 RVA: 0x00D7DCFF File Offset: 0x00D7BEFF
		public CiacconaGalView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060306AB RID: 198315 RVA: 0x00D7DD08 File Offset: 0x00D7BF08
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

		// Token: 0x060306AC RID: 198316 RVA: 0x00D7DE76 File Offset: 0x00D7C076
		protected override void OnBeforeShow()
		{
			this.WarmUpIcon();
			base.GetTexture(3).SetUIActive(false);
		}

		// Token: 0x060306AD RID: 198317 RVA: 0x00D7DE8C File Offset: 0x00D7C08C
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060306AE RID: 198318 RVA: 0x00D7DED0 File Offset: 0x00D7C0D0
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

		// Token: 0x060306AF RID: 198319 RVA: 0x00D7DF6C File Offset: 0x00D7C16C
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

		// Token: 0x060306B0 RID: 198320 RVA: 0x00D7E038 File Offset: 0x00D7C238
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCiacconaAvgReChoose, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChoose));
			EventSystem.Instance.Add(EEventName.OnCiacconaReChooseConfirm, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChooseConfirm));
			EventSystem.Instance.Add(EEventName.OnCiacconaReChooseCancel, new Action(this.OnCiacconaAvgReChooseCancel));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x060306B1 RID: 198321 RVA: 0x00D7E0B8 File Offset: 0x00D7C2B8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaAvgReChoose, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChoose));
			EventSystem.Instance.Remove(EEventName.OnCiacconaReChooseConfirm, new Action<CiacconaGalStepData, CiacconaGalChoiceData>(this.OnCiacconaAvgReChooseConfirm));
			EventSystem.Instance.Remove(EEventName.OnCiacconaReChooseCancel, new Action(this.OnCiacconaAvgReChooseCancel));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x060306B2 RID: 198322 RVA: 0x00D7E138 File Offset: 0x00D7C338
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

		// Token: 0x060306B3 RID: 198323 RVA: 0x00D7E16C File Offset: 0x00D7C36C
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

		// Token: 0x060306B4 RID: 198324 RVA: 0x00D7E1B8 File Offset: 0x00D7C3B8
		private void WarmUpIcon()
		{
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon01"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon02"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon03"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon04"), this.MemoryTag);
			ResourceSystem.Instance.Load<UTexture>(UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningIcon05"), this.MemoryTag);
		}

		// Token: 0x060306B5 RID: 198325 RVA: 0x00D7E268 File Offset: 0x00D7C468
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

		// Token: 0x060306B6 RID: 198326 RVA: 0x00D7E338 File Offset: 0x00D7C538
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

		// Token: 0x060306B7 RID: 198327 RVA: 0x00D7E4BC File Offset: 0x00D7C6BC
		private void OnGalPlayerStateChange(ECiacconaGalPlayerState state)
		{
			this.CurState = state;
			base.GetItem(4).SetUIActive((state == ECiacconaGalPlayerState.Playing || state == ECiacconaGalPlayerState.Skipping) && !this.IsViewHide);
			base.GetItem(5).SetUIActive(state == ECiacconaGalPlayerState.Pausing && !this.IsViewHide);
		}

		// Token: 0x060306B8 RID: 198328 RVA: 0x00D7E50C File Offset: 0x00D7C70C
		private void OnClickMask()
		{
			if (this.IsViewHide)
			{
				this.ShowAvg();
				return;
			}
			CiacconaGalController.Instance.GalPlayer.OnClick(null);
		}

		// Token: 0x060306B9 RID: 198329 RVA: 0x00D7E540 File Offset: 0x00D7C740
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

		// Token: 0x060306BA RID: 198330 RVA: 0x00D7E594 File Offset: 0x00D7C794
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

		// Token: 0x060306BB RID: 198331 RVA: 0x00D7E60B File Offset: 0x00D7C80B
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

		// Token: 0x060306BC RID: 198332 RVA: 0x00D7E644 File Offset: 0x00D7C844
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

		// Token: 0x060306BD RID: 198333 RVA: 0x00D7E6F4 File Offset: 0x00D7C8F4
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

		// Token: 0x060306BE RID: 198334 RVA: 0x00D7E730 File Offset: 0x00D7C930
		private void OnActivitySequenceEmitEvent(string eventName)
		{
			if (eventName == "Change")
			{
				this.UpdateImageAsync(this.NextImagePath).Forget();
			}
		}

		// Token: 0x060306BF RID: 198335 RVA: 0x00D7E750 File Offset: 0x00D7C950
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

		// Token: 0x04019A5C RID: 105052
		private CiacconaGalStepPlayerNormalPanel GalPanelNormal;

		// Token: 0x04019A5D RID: 105053
		private CiacconaGalStepPlayerReChoosePanel GalPanelReChoose;

		// Token: 0x04019A5E RID: 105054
		private PopupCaptionItem CaptionItem;

		// Token: 0x04019A5F RID: 105055
		private CiacconaTitleInspirationItem CiacconaTitleItem;

		// Token: 0x04019A60 RID: 105056
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04019A61 RID: 105057
		private int CurStepId;

		// Token: 0x04019A62 RID: 105058
		private int AudioHandle;

		// Token: 0x04019A63 RID: 105059
		private string CurImagePath;

		// Token: 0x04019A64 RID: 105060
		private int MusicHandle;

		// Token: 0x04019A65 RID: 105061
		private string NextImagePath;

		// Token: 0x04019A66 RID: 105062
		private bool IsViewHide;

		// Token: 0x04019A67 RID: 105063
		private bool IsReChoosing;

		// Token: 0x04019A68 RID: 105064
		private ECiacconaGalPlayerState CurState;

		// Token: 0x0200A7CE RID: 42958
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D51 RID: 212305
			public const int ItemCaption = 0;

			// Token: 0x04033D52 RID: 212306
			public const int ItemContent = 1;

			// Token: 0x04033D53 RID: 212307
			public const int BtnMask = 2;

			// Token: 0x04033D54 RID: 212308
			public const int TextureImage = 3;

			// Token: 0x04033D55 RID: 212309
			public const int ItemOnGoing = 4;

			// Token: 0x04033D56 RID: 212310
			public const int ItemContinue = 5;

			// Token: 0x04033D57 RID: 212311
			public const int BtnHide = 6;
		}
	}
}
