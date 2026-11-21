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
	// Token: 0x02004114 RID: 16660
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaMainView : PhantomArenaRootViewBase<PhantomArenaMainViewModel>
	{
		// Token: 0x0602A156 RID: 172374 RVA: 0x00BE5D62 File Offset: 0x00BE3F62
		public PhantomArenaMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602A157 RID: 172375 RVA: 0x00BE5D78 File Offset: 0x00BE3F78
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

		// Token: 0x0602A158 RID: 172376 RVA: 0x00BE5E2C File Offset: 0x00BE402C
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

		// Token: 0x0602A159 RID: 172377 RVA: 0x00BE5F75 File Offset: 0x00BE4175
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
		}

		// Token: 0x0602A15A RID: 172378 RVA: 0x00BE5F99 File Offset: 0x00BE4199
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.GuideFocusNeedUiTabView, new Action<GuideStepInfo, GuideFocusNew>(this.OnGuideFocusNeedUiTabView));
		}

		// Token: 0x0602A15B RID: 172379 RVA: 0x00BE5FC0 File Offset: 0x00BE41C0
		protected override void OnRegisterDefaultChildView()
		{
			IPhantomArenaMainViewOpenParam phantomArenaMainViewOpenParam = this.OpenParam as IPhantomArenaMainViewOpenParam;
			this.DefaultChildViewName = new EPhantomArenaChildViewName?(phantomArenaMainViewOpenParam.OpenView);
		}

		// Token: 0x0602A15C RID: 172380 RVA: 0x00BE5FEA File Offset: 0x00BE41EA
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(1);
		}

		// Token: 0x0602A15D RID: 172381 RVA: 0x00BE5FFC File Offset: 0x00BE41FC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A15E RID: 172382 RVA: 0x00BE603F File Offset: 0x00BE423F
		private void ChangeRoleTexture(int newTextureCardRoleId, bool bPlayAnim)
		{
			if (this.ViewModel.TextureCardRoleId == newTextureCardRoleId)
			{
				return;
			}
			this.ViewModel.TextureCardRoleId = newTextureCardRoleId;
			this.RefreshRoleTexture(bPlayAnim);
		}

		// Token: 0x0602A15F RID: 172383 RVA: 0x00BE6063 File Offset: 0x00BE4263
		private void RefreshRoleTextureWithoutAnim()
		{
			this.RefreshRoleTexture(false);
		}

		// Token: 0x0602A160 RID: 172384 RVA: 0x00BE606C File Offset: 0x00BE426C
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

		// Token: 0x0602A161 RID: 172385 RVA: 0x00BE60E8 File Offset: 0x00BE42E8
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

		// Token: 0x0602A162 RID: 172386 RVA: 0x00BE6130 File Offset: 0x00BE4330
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

		// Token: 0x0602A163 RID: 172387 RVA: 0x00BE6178 File Offset: 0x00BE4378
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

		// Token: 0x0602A164 RID: 172388 RVA: 0x00BE61DC File Offset: 0x00BE43DC
		public void SetRoleTextureUiActive(bool active)
		{
			base.GetTexture(2).SetUIActive(active);
			base.GetItem(6).SetUIActive(active);
		}

		// Token: 0x0602A165 RID: 172389 RVA: 0x00BE61F8 File Offset: 0x00BE43F8
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

		// Token: 0x0602A166 RID: 172390 RVA: 0x00BE623C File Offset: 0x00BE443C
		public UniTask RefreshRoleTextureAsync()
		{
			PhantomArenaMainView.<RefreshRoleTextureAsync>d__22 <RefreshRoleTextureAsync>d__;
			<RefreshRoleTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleTextureAsync>d__.<>4__this = this;
			<RefreshRoleTextureAsync>d__.<>1__state = -1;
			<RefreshRoleTextureAsync>d__.<>t__builder.Start<PhantomArenaMainView.<RefreshRoleTextureAsync>d__22>(ref <RefreshRoleTextureAsync>d__);
			return <RefreshRoleTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A167 RID: 172391 RVA: 0x00BE6280 File Offset: 0x00BE4480
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

		// Token: 0x0602A168 RID: 172392 RVA: 0x00BE62C9 File Offset: 0x00BE44C9
		private void OnSeqStart(string seqName)
		{
		}

		// Token: 0x0602A169 RID: 172393 RVA: 0x00BE62CB File Offset: 0x00BE44CB
		private void OnSeqEnd(string seqName)
		{
			if (seqName == "RoleHide".ToString())
			{
				this.SetRoleTextureUiActive(false);
			}
		}

		// Token: 0x0602A16A RID: 172394 RVA: 0x00BE62E8 File Offset: 0x00BE44E8
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

		// Token: 0x0602A16B RID: 172395 RVA: 0x00BE6311 File Offset: 0x00BE4511
		[NullableContext(2)]
		public PhantomArenaMainViewSwitchItem GetSwitchItem()
		{
			return this.SwitchItem;
		}

		// Token: 0x0602A16C RID: 172396 RVA: 0x00BE6319 File Offset: 0x00BE4519
		public void SetViewTitle(string title)
		{
			this.CaptionItem.SetTitleLocalText(title);
		}

		// Token: 0x0602A16D RID: 172397 RVA: 0x00BE6327 File Offset: 0x00BE4527
		public void SetViewIcon(string icon)
		{
			this.CaptionItem.SetTitleIconByResourceId(icon);
		}

		// Token: 0x0602A16E RID: 172398 RVA: 0x00BE6338 File Offset: 0x00BE4538
		public void SetViewHelpId(int helpId)
		{
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(helpId);
			});
		}

		// Token: 0x0602A16F RID: 172399 RVA: 0x00BE6369 File Offset: 0x00BE4569
		public void SetViewHelpBtnActive(bool bActive)
		{
			this.CaptionItem.SetHelpBtnActive(bActive);
		}

		// Token: 0x0602A170 RID: 172400 RVA: 0x00BE6377 File Offset: 0x00BE4577
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

		// Token: 0x0602A171 RID: 172401 RVA: 0x00BE63B0 File Offset: 0x00BE45B0
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

		// Token: 0x04016F2F RID: 93999
		[Nullable(2)]
		private PhantomArenaMainViewSwitchItem SwitchItem;

		// Token: 0x04016F30 RID: 94000
		[Nullable(2)]
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04016F31 RID: 94001
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x04016F32 RID: 94002
		protected Dictionary<int, PhantomArenaMainViewRoleSpineItem> RoleSpineMap = new Dictionary<int, PhantomArenaMainViewRoleSpineItem>();

		// Token: 0x04016F33 RID: 94003
		[Nullable(2)]
		protected PhantomArenaMainViewRoleSpineItem CurShowRoleSpine;

		// Token: 0x02009CDD RID: 40157
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030C41 RID: 199745
			public const int CaptionItem = 0;

			// Token: 0x04030C42 RID: 199746
			public const int ContentItem = 1;

			// Token: 0x04030C43 RID: 199747
			public const int LightTextureA = 2;

			// Token: 0x04030C44 RID: 199748
			public const int SwitchItem = 3;

			// Token: 0x04030C45 RID: 199749
			public const int FrameItem = 4;

			// Token: 0x04030C46 RID: 199750
			public const int LightTextureB = 5;

			// Token: 0x04030C47 RID: 199751
			public const int RoleRootItem = 6;
		}
	}
}
