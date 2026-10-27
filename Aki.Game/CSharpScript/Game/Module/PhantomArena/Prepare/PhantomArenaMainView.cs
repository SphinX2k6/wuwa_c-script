using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Guide.StepInfo;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005144 RID: 20804
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaMainView : PhantomArenaRootViewBase<PhantomArenaMainViewModel>
	{
		// Token: 0x0603525A RID: 217690 RVA: 0x00C98862 File Offset: 0x00C96A62
		public PhantomArenaMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603525B RID: 217691 RVA: 0x00C98878 File Offset: 0x00C96A78
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUITexture)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0603525C RID: 217692 RVA: 0x00C9892C File Offset: 0x00C96B2C
		protected override void OnRegisterViewData()
		{
			IPhantomArenaMainViewOpenParam phantomArenaMainViewOpenParam = this.OpenParam as IPhantomArenaMainViewOpenParam;
			this.ViewModel = new PhantomArenaMainViewModel();
			this.ActivityId = phantomArenaMainViewOpenParam.ActivityId;
			this.ViewModel.ActivityId = this.ActivityId;
			this.ViewModel.RecommendDeck = phantomArenaMainViewOpenParam.RecommendDeck;
			this.ViewModel.Init(phantomArenaMainViewOpenParam.ChallengeId);
			this.ViewModel.SetGetSwitchItemFunc(new Func<PhantomArenaMainViewSwitchItem>(this.GetSwitchItem));
			this.ViewModel.RefreshRoleTexture = new Action(this.RefreshRoleTextureWithoutAnim);
			this.ViewModel.ChangeRoleTexture = new Action<int, bool>(this.ChangeRoleTexture);
			this.ViewModel.ShowRoleTexture = new Action<bool>(this.ShowRoleTexture);
			this.ViewModel.HideRoleTexture = new Action<bool>(this.HideRoleTexture);
			this.ViewModel.PlayRoleTextureShowAnim = new Action(this.PlayRoleTextureShowAnim);
			this.ViewModel.SetViewTitle = new Action<string>(this.SetViewTitle);
			this.ViewModel.SetViewIcon = new Action<string>(this.SetViewIcon);
			this.ViewModel.SetViewHelpId = new Action<int>(this.SetViewHelpId);
			this.ViewModel.SetViewHelpBtnActive = new Action<bool>(this.SetViewHelpBtnActive);
		}

		// Token: 0x0603525D RID: 217693 RVA: 0x00C98A75 File Offset: 0x00C96C75
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
		}

		// Token: 0x0603525E RID: 217694 RVA: 0x00C98A99 File Offset: 0x00C96C99
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
		}

		// Token: 0x0603525F RID: 217695 RVA: 0x00C98AC0 File Offset: 0x00C96CC0
		protected override void OnRegisterDefaultChildView()
		{
			IPhantomArenaMainViewOpenParam phantomArenaMainViewOpenParam = this.OpenParam as IPhantomArenaMainViewOpenParam;
			this.DefaultChildViewName = new EPhantomArenaChildViewName?(phantomArenaMainViewOpenParam.OpenView);
		}

		// Token: 0x06035260 RID: 217696 RVA: 0x00C98AEA File Offset: 0x00C96CEA
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(1);
		}

		// Token: 0x06035261 RID: 217697 RVA: 0x00C98AFC File Offset: 0x00C96CFC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035262 RID: 217698 RVA: 0x00C98B3F File Offset: 0x00C96D3F
		private void ChangeRoleTexture(int newTextureCardRoleId, bool bPlayAnim)
		{
			if (this.ViewModel.TextureCardRoleId == newTextureCardRoleId)
			{
				return;
			}
			this.ViewModel.TextureCardRoleId = newTextureCardRoleId;
			this.RefreshRoleTexture(bPlayAnim);
		}

		// Token: 0x06035263 RID: 217699 RVA: 0x00C98B63 File Offset: 0x00C96D63
		private void RefreshRoleTextureWithoutAnim()
		{
			this.RefreshRoleTexture(false);
		}

		// Token: 0x06035264 RID: 217700 RVA: 0x00C98B6C File Offset: 0x00C96D6C
		public void ShowRoleTexture(bool bPlayAnim)
		{
			if (this.ViewModel.RoleTextureActive)
			{
				return;
			}
			if (this.ViewModel.TextureCardRoleId <= 0)
			{
				return;
			}
			this.ViewModel.RoleTextureActive = true;
			this.SetRoleTextureUiActive(true);
			if (bPlayAnim)
			{
				string sequenceName = "RoleShow";
				if (this.SequencePlayer.CheckSeqActorIsSeqPlaying(sequenceName))
				{
					this.SequencePlayer.ReplaySequenceByKey(sequenceName);
					return;
				}
				this.SequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
			}
		}

		// Token: 0x06035265 RID: 217701 RVA: 0x00C98BE8 File Offset: 0x00C96DE8
		public void PlayRoleTextureChangeAnim()
		{
			string sequenceName = "RoleShow";
			if (this.SequencePlayer.CheckSeqActorIsSeqPlaying(sequenceName))
			{
				this.SequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			this.SequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}

		// Token: 0x06035266 RID: 217702 RVA: 0x00C98C30 File Offset: 0x00C96E30
		public void PlayRoleTextureShowAnim()
		{
			string sequenceName = "RoleShow";
			if (this.SequencePlayer.CheckSeqActorIsSeqPlaying(sequenceName))
			{
				this.SequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			this.SequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}

		// Token: 0x06035267 RID: 217703 RVA: 0x00C98C78 File Offset: 0x00C96E78
		public void HideRoleTexture(bool bPlayAnim)
		{
			if (!this.ViewModel.RoleTextureActive)
			{
				return;
			}
			this.ViewModel.RoleTextureActive = false;
			if (bPlayAnim)
			{
				string sequenceName = "RoleHide";
				if (this.SequencePlayer.CheckSeqActorIsSeqPlaying(sequenceName))
				{
					this.SequencePlayer.ReplaySequenceByKey(sequenceName);
					return;
				}
				this.SequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
			}
		}

		// Token: 0x06035268 RID: 217704 RVA: 0x00C98CDC File Offset: 0x00C96EDC
		public void SetRoleTextureUiActive(bool active)
		{
			base.GetTexture(2).SetUIActive(active);
			base.GetItem(6).SetUIActive(active);
		}

		// Token: 0x06035269 RID: 217705 RVA: 0x00C98CF8 File Offset: 0x00C96EF8
		public void RefreshRoleTexture(bool bPlayAnim)
		{
			PhantomArenaMainView.<>c__DisplayClass21_0 CS$<>8__locals1 = new PhantomArenaMainView.<>c__DisplayClass21_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.bPlayAnim = bPlayAnim;
			UiAsyncTask task = new UiAsyncTask("PhantomArenaMainView", delegate()
			{
				PhantomArenaMainView.<>c__DisplayClass21_0.<<RefreshRoleTexture>b__0>d <<RefreshRoleTexture>b__0>d;
				<<RefreshRoleTexture>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshRoleTexture>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshRoleTexture>b__0>d.<>1__state = -1;
				<<RefreshRoleTexture>b__0>d.<>t__builder.Start<PhantomArenaMainView.<>c__DisplayClass21_0.<<RefreshRoleTexture>b__0>d>(ref <<RefreshRoleTexture>b__0>d);
				return <<RefreshRoleTexture>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603526A RID: 217706 RVA: 0x00C98D3C File Offset: 0x00C96F3C
		public UniTask RefreshRoleTextureAsync()
		{
			PhantomArenaMainView.<RefreshRoleTextureAsync>d__22 <RefreshRoleTextureAsync>d__;
			<RefreshRoleTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleTextureAsync>d__.<>4__this = this;
			<RefreshRoleTextureAsync>d__.<>1__state = -1;
			<RefreshRoleTextureAsync>d__.<>t__builder.Start<PhantomArenaMainView.<RefreshRoleTextureAsync>d__22>(ref <RefreshRoleTextureAsync>d__);
			return <RefreshRoleTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603526B RID: 217707 RVA: 0x00C98D80 File Offset: 0x00C96F80
		private void ChangeToShowRoleSpine(int newTextureCardRoleId)
		{
			if (this.CurShowRoleSpine != null)
			{
				this.CurShowRoleSpine.GetRootItem().SetUIActive(false);
			}
			PhantomArenaMainViewRoleSpineItem phantomArenaMainViewRoleSpineItem;
			if (this.RoleSpineMap.TryGetValue(newTextureCardRoleId, out phantomArenaMainViewRoleSpineItem))
			{
				phantomArenaMainViewRoleSpineItem.GetRootItem().SetUIActive(true);
				this.CurShowRoleSpine = phantomArenaMainViewRoleSpineItem;
			}
		}

		// Token: 0x0603526C RID: 217708 RVA: 0x00C98DC9 File Offset: 0x00C96FC9
		private void OnSeqStart(string seqName)
		{
		}

		// Token: 0x0603526D RID: 217709 RVA: 0x00C98DCB File Offset: 0x00C96FCB
		private void OnSeqEnd(string seqName)
		{
			if (seqName == "RoleHide".ToString())
			{
				this.SetRoleTextureUiActive(false);
			}
		}

		// Token: 0x0603526E RID: 217710 RVA: 0x00C98DE8 File Offset: 0x00C96FE8
		private void OnBackBtnClick()
		{
			Action overrideCloseFunc = this.ViewModel.GetOverrideCloseFunc();
			if (overrideCloseFunc != null)
			{
				overrideCloseFunc();
				return;
			}
			base.Back();
		}

		// Token: 0x0603526F RID: 217711 RVA: 0x00C98E11 File Offset: 0x00C97011
		[NullableContext(2)]
		public PhantomArenaMainViewSwitchItem GetSwitchItem()
		{
			return this.SwitchItem;
		}

		// Token: 0x06035270 RID: 217712 RVA: 0x00C98E19 File Offset: 0x00C97019
		public void SetViewTitle(string title)
		{
			this.CaptionItem.SetTitleLocalText(title);
		}

		// Token: 0x06035271 RID: 217713 RVA: 0x00C98E27 File Offset: 0x00C97027
		public void SetViewIcon(string icon)
		{
			this.CaptionItem.SetTitleIconByResourceId(icon);
		}

		// Token: 0x06035272 RID: 217714 RVA: 0x00C98E38 File Offset: 0x00C97038
		public void SetViewHelpId(int helpId)
		{
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(helpId);
			});
		}

		// Token: 0x06035273 RID: 217715 RVA: 0x00C98E69 File Offset: 0x00C97069
		public void SetViewHelpBtnActive(bool bActive)
		{
			this.CaptionItem.SetHelpBtnActive(bActive);
		}

		// Token: 0x06035274 RID: 217716 RVA: 0x00C98E77 File Offset: 0x00C97077
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "SwitchItem"))
			{
				return base.GetCurChildView().GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			PhantomArenaMainViewSwitchItem switchItem = this.GetSwitchItem();
			if (switchItem == null)
			{
				return null;
			}
			return switchItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x06035275 RID: 217717 RVA: 0x00C98EB0 File Offset: 0x00C970B0
		private void OnGuideFocusNeedUiTabView(GuideStepInfo stepInfo, GuideFocusNew focusConf)
		{
			PhantomArenaChildViewBase curChildView = base.GetCurChildView();
			EPhantomArenaChildViewName? ephantomArenaChildViewName;
			if (((curChildView.ViewName != null) ? ephantomArenaChildViewName.GetValueOrDefault().ToString() : null) != focusConf.DynamicTabName)
			{
				return;
			}
			stepInfo.ViewData.SetAttachedView(curChildView);
		}

		// Token: 0x0401C4FA RID: 115962
		[Nullable(2)]
		private PhantomArenaMainViewSwitchItem SwitchItem;

		// Token: 0x0401C4FB RID: 115963
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401C4FC RID: 115964
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401C4FD RID: 115965
		protected Dictionary<int, PhantomArenaMainViewRoleSpineItem> RoleSpineMap = new Dictionary<int, PhantomArenaMainViewRoleSpineItem>();

		// Token: 0x0401C4FE RID: 115966
		[Nullable(2)]
		protected PhantomArenaMainViewRoleSpineItem CurShowRoleSpine;

		// Token: 0x0200B2A4 RID: 45732
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040361EC RID: 221676
			public const int CaptionItem = 0;

			// Token: 0x040361ED RID: 221677
			public const int ContentItem = 1;

			// Token: 0x040361EE RID: 221678
			public const int LightTextureA = 2;

			// Token: 0x040361EF RID: 221679
			public const int SwitchItem = 3;

			// Token: 0x040361F0 RID: 221680
			public const int FrameItem = 4;

			// Token: 0x040361F1 RID: 221681
			public const int LightTextureB = 5;

			// Token: 0x040361F2 RID: 221682
			public const int RoleRootItem = 6;
		}
	}
}
