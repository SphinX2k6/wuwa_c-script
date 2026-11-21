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
	// Token: 0x020053BB RID: 21435
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkRewardView : UiViewBase
	{
		// Token: 0x060354CD RID: 218317 RVA: 0x00EE3D9F File Offset: 0x00EE1F9F
		public MotorDecalLinkRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060354CE RID: 218318 RVA: 0x00EE3DCC File Offset: 0x00EE1FCC
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

		// Token: 0x060354CF RID: 218319 RVA: 0x00EE3F88 File Offset: 0x00EE2188
		protected override UniTask OnBeforeStartAsync()
		{
			MotorDecalLinkRewardView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorDecalLinkRewardView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060354D0 RID: 218320 RVA: 0x00EE3FCC File Offset: 0x00EE21CC
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

		// Token: 0x060354D1 RID: 218321 RVA: 0x00EE402A File Offset: 0x00EE222A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x060354D2 RID: 218322 RVA: 0x00EE4064 File Offset: 0x00EE2264
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ActivityViewRefreshCurrent, new Action<int>(this.OnActivityRefresh));
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnActivityRefresh));
		}

		// Token: 0x060354D3 RID: 218323 RVA: 0x00EE409E File Offset: 0x00EE229E
		private void OnActivityRefresh(int eventActivityId)
		{
			if (eventActivityId != this.ActivityId || this.ViewModel == null)
			{
				return;
			}
			this.Refresh(this.ViewModel, true);
		}

		// Token: 0x060354D4 RID: 218324 RVA: 0x00EE40BF File Offset: 0x00EE22BF
		private MotorDecalLinkQuestItem QuestItemProxyCreate()
		{
			return new MotorDecalLinkQuestItem();
		}

		// Token: 0x060354D5 RID: 218325 RVA: 0x00EE40C6 File Offset: 0x00EE22C6
		private MotorDecalLinkRewardViewDotItem CreateDotItem()
		{
			return new MotorDecalLinkRewardViewDotItem();
		}

		// Token: 0x060354D6 RID: 218326 RVA: 0x00EE40D0 File Offset: 0x00EE22D0
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

		// Token: 0x060354D7 RID: 218327 RVA: 0x00EE413C File Offset: 0x00EE233C
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

		// Token: 0x060354D8 RID: 218328 RVA: 0x00EE41C8 File Offset: 0x00EE23C8
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

		// Token: 0x060354D9 RID: 218329 RVA: 0x00EE43DC File Offset: 0x00EE25DC
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

		// Token: 0x060354DA RID: 218330 RVA: 0x00EE4464 File Offset: 0x00EE2664
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

		// Token: 0x060354DB RID: 218331 RVA: 0x00EE44EB File Offset: 0x00EE26EB
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060354DC RID: 218332 RVA: 0x00EE44F4 File Offset: 0x00EE26F4
		private void OnClickMoveBtn(int delta)
		{
			if (this.ViewModel == null)
			{
				return;
			}
			this.ViewModel.MoveSelectIpIndex(delta);
			this.Refresh(this.ViewModel, false);
		}

		// Token: 0x0401C1DD RID: 115165
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C1DE RID: 115166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<MotorDecalLinkRewardViewDotItem, bool> DotLayout;

		// Token: 0x0401C1DF RID: 115167
		[Nullable(2)]
		private MotorDecalLinkMainViewModel ViewModel;

		// Token: 0x0401C1E0 RID: 115168
		private List<bool> DotDataList = new List<bool>();

		// Token: 0x0401C1E1 RID: 115169
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MotorDecalLinkQuestItem, MotorDecalLinkQuestViewModel> QuestScrollView;

		// Token: 0x0401C1E2 RID: 115170
		private int ActivityId;

		// Token: 0x0401C1E3 RID: 115171
		private int? CurrentIpId = new int?(0);

		// Token: 0x0401C1E4 RID: 115172
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<UUIExtendToggle> DecalToggleList = new List<UUIExtendToggle>();

		// Token: 0x0401C1E5 RID: 115173
		private int SelectedDecalIndex;

		// Token: 0x0401C1E6 RID: 115174
		[Nullable(2)]
		private LevelSequencePlayer StickerRootSeqPlayer;

		// Token: 0x0401C1E7 RID: 115175
		[Nullable(2)]
		private LevelSequencePlayer ViewRootSeqPlayer;

		// Token: 0x0401C1E8 RID: 115176
		[Nullable(2)]
		private UUIInturnAnimController QuestAnimController;
	}
}
