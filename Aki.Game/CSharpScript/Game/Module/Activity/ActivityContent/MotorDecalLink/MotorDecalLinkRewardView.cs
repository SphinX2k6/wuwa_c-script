using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x0200643D RID: 25661
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkRewardView : UiViewBase
	{
		// Token: 0x0604080C RID: 264204 RVA: 0x00F9CE23 File Offset: 0x00F9B023
		public MotorDecalLinkRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0604080D RID: 264205 RVA: 0x00F9CE50 File Offset: 0x00F9B050
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUITexture)),
				new ValueTuple<int, Type>(13, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(delegate()
				{
					this.OnClickMoveBtn(-1);
				})),
				new ValueTuple<int, Delegate>(2, new Action(delegate()
				{
					this.OnClickMoveBtn(1);
				})),
				new ValueTuple<int, Delegate>(6, new Action<EToggleState>(delegate(EToggleState _)
				{
					this.OnDecalToggleStateChanged(0);
				})),
				new ValueTuple<int, Delegate>(8, new Action<EToggleState>(delegate(EToggleState _)
				{
					this.OnDecalToggleStateChanged(1);
				}))
			};
		}

		// Token: 0x0604080E RID: 264206 RVA: 0x00F9D00C File Offset: 0x00F9B20C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorDecalLinkRewardView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorDecalLinkRewardView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604080F RID: 264207 RVA: 0x00F9D050 File Offset: 0x00F9B250
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if ((sequenceName == "Sle" && eventName == "On") || (sequenceName == "Change" && eventName == "On"))
			{
				MotorDecalLinkMainViewModel viewModel = this.ViewModel;
				MotorDecalLinkIpViewModel motorDecalLinkIpViewModel = (viewModel != null) ? viewModel.GetCurrentIpViewModel() : null;
				if (motorDecalLinkIpViewModel != null)
				{
					this.RefreshStickerPreview(motorDecalLinkIpViewModel);
				}
			}
		}

		// Token: 0x06040810 RID: 264208 RVA: 0x00F9D0AE File Offset: 0x00F9B2AE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x06040811 RID: 264209 RVA: 0x00F9D0E8 File Offset: 0x00F9B2E8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x06040812 RID: 264210 RVA: 0x00F9D122 File Offset: 0x00F9B322
		private void OnActivityRefresh(int eventActivityId)
		{
			if (eventActivityId != this.ActivityId || this.ViewModel == null)
			{
				return;
			}
			this.Refresh(this.ViewModel, true);
		}

		// Token: 0x06040813 RID: 264211 RVA: 0x00F9D143 File Offset: 0x00F9B343
		private MotorDecalLinkQuestItem QuestItemProxyCreate()
		{
			return new MotorDecalLinkQuestItem();
		}

		// Token: 0x06040814 RID: 264212 RVA: 0x00F9D14A File Offset: 0x00F9B34A
		private MotorDecalLinkRewardViewDotItem CreateDotItem()
		{
			return new MotorDecalLinkRewardViewDotItem();
		}

		// Token: 0x06040815 RID: 264213 RVA: 0x00F9D154 File Offset: 0x00F9B354
		private void OnDecalToggleStateChanged(int index)
		{
			this.SelectedDecalIndex = index;
			for (int i = 0; i < this.DecalToggleList.Count; i++)
			{
				if (i != index)
				{
					UUIExtendToggle uuiextendToggle = this.DecalToggleList[i];
					if (uuiextendToggle != null)
					{
						uuiextendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					}
				}
			}
			LevelSequencePlayer viewRootSeqPlayer = this.ViewRootSeqPlayer;
			if (viewRootSeqPlayer == null)
			{
				return;
			}
			viewRootSeqPlayer.PlayLevelSequenceByName("Sle", false, null, false);
		}

		// Token: 0x06040816 RID: 264214 RVA: 0x00F9D1C0 File Offset: 0x00F9B3C0
		public void Refresh(MotorDecalLinkMainViewModel viewModel, bool isFastMode)
		{
			this.RefreshDotItem(viewModel);
			MotorDecalLinkIpViewModel currentIpViewModel = viewModel.GetCurrentIpViewModel();
			if (currentIpViewModel == null)
			{
				return;
			}
			UUITexture texture = base.GetTexture(5);
			string nameLogoPath = currentIpViewModel.GetNameLogoPath();
			base.SetTextureByPath(nameLogoPath, texture, null, null);
			string message = "Reward Logo";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("nameLogoPath", nameLogoPath);
			MotorDecalLinkUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.RefreshDecal(currentIpViewModel, isFastMode);
			List<MotorDecalLinkQuestViewModel> questViewModelList = currentIpViewModel.QuestViewModelList;
			GenericScrollViewNew<MotorDecalLinkQuestItem, MotorDecalLinkQuestViewModel> questScrollView = this.QuestScrollView;
			if (questScrollView == null)
			{
				return;
			}
			questScrollView.RefreshByData(questViewModelList, delegate
			{
				UUIInturnAnimController questAnimController = this.QuestAnimController;
				if (questAnimController == null)
				{
					return;
				}
				questAnimController.Play("", -1, false);
			}, false);
		}

		// Token: 0x06040817 RID: 264215 RVA: 0x00F9D24C File Offset: 0x00F9B44C
		private void RefreshDecal(MotorDecalLinkIpViewModel ip, bool isFastMode)
		{
			int ipId = ip.IpId;
			int? currentIpId = this.CurrentIpId;
			if (ipId == currentIpId.GetValueOrDefault() & currentIpId != null)
			{
				return;
			}
			this.CurrentIpId = new int?(ip.IpId);
			List<string> decalTexturePaths = ip.DecalTexturePaths;
			bool flag = decalTexturePaths.Count >= 1;
			bool flag2 = decalTexturePaths.Count >= 2;
			string text = (decalTexturePaths.Count > 0) ? (decalTexturePaths[0] ?? "") : "";
			string path = (decalTexturePaths.Count >= 2) ? (decalTexturePaths[1] ?? "") : "";
			UUIExtendToggle uuiextendToggle = this.DecalToggleList[0];
			if (uuiextendToggle != null)
			{
				uuiextendToggle.RootUIComp.Get().SetUIActive(flag);
			}
			if (flag && !string.IsNullOrEmpty(text))
			{
				UUITexture texture = base.GetTexture(7);
				if (texture != null)
				{
					texture.SetUIActive(true);
				}
				base.SetTextureByPath(text, base.GetTexture(7), null, null);
			}
			else
			{
				UUITexture texture2 = base.GetTexture(7);
				if (texture2 != null)
				{
					texture2.SetUIActive(false);
				}
			}
			UUIExtendToggle uuiextendToggle2 = this.DecalToggleList[1];
			if (uuiextendToggle2 != null)
			{
				uuiextendToggle2.RootUIComp.Get().SetUIActive(flag2);
			}
			if (flag2)
			{
				UUITexture texture3 = base.GetTexture(9);
				if (texture3 != null)
				{
					texture3.SetUIActive(true);
				}
				base.SetTextureByPath(path, base.GetTexture(9), null, null);
			}
			else
			{
				UUITexture texture4 = base.GetTexture(9);
				if (texture4 != null)
				{
					texture4.SetUIActive(false);
				}
			}
			if (decalTexturePaths.Count >= 1)
			{
				UUIExtendToggle uuiextendToggle3 = this.DecalToggleList[0];
				if (uuiextendToggle3 != null)
				{
					uuiextendToggle3.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				}
				UUIExtendToggle uuiextendToggle4 = this.DecalToggleList[1];
				if (uuiextendToggle4 != null)
				{
					uuiextendToggle4.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				this.SelectedDecalIndex = 0;
			}
			if (!isFastMode)
			{
				LevelSequencePlayer stickerRootSeqPlayer = this.StickerRootSeqPlayer;
				if (stickerRootSeqPlayer != null)
				{
					stickerRootSeqPlayer.PlayLevelSequenceByName("Sle", false, null, false);
				}
				LevelSequencePlayer viewRootSeqPlayer = this.ViewRootSeqPlayer;
				if (viewRootSeqPlayer == null)
				{
					return;
				}
				viewRootSeqPlayer.PlayLevelSequenceByName("Change", false, null, false);
			}
		}

		// Token: 0x06040818 RID: 264216 RVA: 0x00F9D460 File Offset: 0x00F9B660
		private void RefreshStickerPreview(MotorDecalLinkIpViewModel ip)
		{
			string text = (this.SelectedDecalIndex >= 0 && this.SelectedDecalIndex < ip.DecalPreviewPaths.Count) ? ip.DecalPreviewPaths[this.SelectedDecalIndex] : "";
			UUITexture texture = base.GetTexture(12);
			string message = "Reward 贴纸预览";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", text);
			MotorDecalLinkUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (!string.IsNullOrEmpty(text) && texture != null)
			{
				base.SetTextureByPath(text, texture, null, null);
			}
		}

		// Token: 0x06040819 RID: 264217 RVA: 0x00F9D4E8 File Offset: 0x00F9B6E8
		private void RefreshDotItem(MotorDecalLinkMainViewModel viewModel)
		{
			if (this.DotLayout == null)
			{
				return;
			}
			int count = viewModel.IpList.Count;
			if (this.DotDataList.Count != count)
			{
				this.DotDataList.Clear();
				for (int i = 0; i < count; i++)
				{
					this.DotDataList.Add(false);
				}
			}
			for (int j = 0; j < count; j++)
			{
				this.DotDataList[j] = (j == viewModel.CurrentIpIndex);
			}
			this.DotLayout.RefreshByData(this.DotDataList, null, false);
		}

		// Token: 0x0604081A RID: 264218 RVA: 0x00F9D56F File Offset: 0x00F9B76F
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0604081B RID: 264219 RVA: 0x00F9D578 File Offset: 0x00F9B778
		private void OnClickMoveBtn(int delta)
		{
			if (this.ViewModel == null)
			{
				return;
			}
			this.ViewModel.MoveSelectIpIndex(delta);
			this.Refresh(this.ViewModel, false);
		}

		// Token: 0x040218AE RID: 137390
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040218AF RID: 137391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MotorDecalLinkRewardViewDotItem, bool> DotLayout;

		// Token: 0x040218B0 RID: 137392
		[Nullable(2)]
		private MotorDecalLinkMainViewModel ViewModel;

		// Token: 0x040218B1 RID: 137393
		private List<bool> DotDataList = new List<bool>();

		// Token: 0x040218B2 RID: 137394
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MotorDecalLinkQuestItem, MotorDecalLinkQuestViewModel> QuestScrollView;

		// Token: 0x040218B3 RID: 137395
		private int ActivityId;

		// Token: 0x040218B4 RID: 137396
		private int? CurrentIpId = new int?(0);

		// Token: 0x040218B5 RID: 137397
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<UUIExtendToggle> DecalToggleList = new List<UUIExtendToggle>();

		// Token: 0x040218B6 RID: 137398
		private int SelectedDecalIndex;

		// Token: 0x040218B7 RID: 137399
		[Nullable(2)]
		private LevelSequencePlayer StickerRootSeqPlayer;

		// Token: 0x040218B8 RID: 137400
		[Nullable(2)]
		private LevelSequencePlayer ViewRootSeqPlayer;

		// Token: 0x040218B9 RID: 137401
		[Nullable(2)]
		private UUIInturnAnimController QuestAnimController;
	}
}
