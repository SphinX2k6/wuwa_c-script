using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006335 RID: 25397
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMainRootView : PinballMainRootViewBase<PinballMainViewModel>
	{
		// Token: 0x0603FE50 RID: 261712 RVA: 0x00F7510E File Offset: 0x00F7330E
		public PinballMainRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FE51 RID: 261713 RVA: 0x00F75118 File Offset: 0x00F73318
		protected override void OnRegisterDefaultChildView()
		{
			IPinballMainRootViewOpenParam pinballMainRootViewOpenParam = this.OpenParam as IPinballMainRootViewOpenParam;
			this.DefaultChildViewName = pinballMainRootViewOpenParam.ChildView;
			this.CheckChildViewParam(pinballMainRootViewOpenParam);
		}

		// Token: 0x0603FE52 RID: 261714 RVA: 0x00F75144 File Offset: 0x00F73344
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(1);
		}

		// Token: 0x0603FE53 RID: 261715 RVA: 0x00F75154 File Offset: 0x00F73354
		protected override void OnRegisterViewData()
		{
			base.ViewModel = new PinballMainViewModel();
			base.ViewModel.ChangePlanetTexture = new Action<string>(this.ChangePlanetTexture);
			base.ViewModel.ChangePlanetMaskTexture = new Action<string>(this.ChangePlanetMaskTexture);
			base.ViewModel.ChangePlanetSwitchTexture = new Action<string>(this.ChangePlanetSwitchTexture);
			base.ViewModel.SetViewTitle = new Action<string>(this.SetViewTitle);
			base.ViewModel.SetViewIcon = new Action<string>(this.SetViewIcon);
			base.ViewModel.SetViewHelpId = new Action<int>(this.SetViewHelpId);
			base.ViewModel.SetViewHelpBtnActive = new Action<bool>(this.SetViewHelpBtnActive);
		}

		// Token: 0x0603FE54 RID: 261716 RVA: 0x00F75210 File Offset: 0x00F73410
		private void CheckChildViewParam(IPinballMainRootViewOpenParam openParam)
		{
			if (openParam.LevelId != null)
			{
				int value = openParam.LevelId.Value;
				PinballActivityData activityData = PinballModel.Instance.ActivityData;
				int chapterIdByLevel = activityData.GetChapterIdByLevel(value);
				PinballChapterData chapterData = activityData.GetChapterData(chapterIdByLevel);
				PinballLevelRecordData levelData = activityData.GetLevelData(value);
				List<PinballLevelRecordData> levelDataListInChapter = activityData.GetLevelDataListInChapter(value);
				if (levelData != null)
				{
					base.ViewModel.SetSelectLevelData(levelData);
				}
				if (chapterData != null)
				{
					base.ViewModel.SetChapterData(chapterData);
				}
				if (levelDataListInChapter.Count > 0)
				{
					base.ViewModel.SetLevelDataList(levelDataListInChapter);
				}
			}
		}

		// Token: 0x0603FE55 RID: 261717 RVA: 0x00F752A0 File Offset: 0x00F734A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FE56 RID: 261718 RVA: 0x00F7534C File Offset: 0x00F7354C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMainRootView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMainRootView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE57 RID: 261719 RVA: 0x00F7538F File Offset: 0x00F7358F
		protected override void OnStart()
		{
			this.AddHomeBtnExtraCallback();
		}

		// Token: 0x0603FE58 RID: 261720 RVA: 0x00F75398 File Offset: 0x00F73598
		protected override void OnBeforeHide()
		{
			PinballModel instance = PinballModel.Instance;
			PinballActivityData pinballActivityData = (instance != null) ? instance.ActivityData : null;
			if (pinballActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, pinballActivityData.Id);
			}
		}

		// Token: 0x0603FE59 RID: 261721 RVA: 0x00F753D0 File Offset: 0x00F735D0
		public void ChangePlanetTexture(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(2), null, null);
		}

		// Token: 0x0603FE5A RID: 261722 RVA: 0x00F753F8 File Offset: 0x00F735F8
		public void ChangePlanetMaskTexture(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(3), null, null);
		}

		// Token: 0x0603FE5B RID: 261723 RVA: 0x00F75420 File Offset: 0x00F73620
		public void ChangePlanetSwitchTexture(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(4), null, null);
		}

		// Token: 0x0603FE5C RID: 261724 RVA: 0x00F75445 File Offset: 0x00F73645
		public void SetViewTitle(string title)
		{
			this.CaptionItem.SetTitleLocalText(title);
		}

		// Token: 0x0603FE5D RID: 261725 RVA: 0x00F75453 File Offset: 0x00F73653
		public void SetViewIcon(string icon)
		{
			this.CaptionItem.SetTitleIconByResourceId(icon).Forget();
		}

		// Token: 0x0603FE5E RID: 261726 RVA: 0x00F75468 File Offset: 0x00F73668
		public void SetViewHelpId(int helpId)
		{
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(helpId);
			});
		}

		// Token: 0x0603FE5F RID: 261727 RVA: 0x00F75499 File Offset: 0x00F73699
		public void SetViewHelpBtnActive(bool bActive)
		{
			this.CaptionItem.SetHelpBtnActive(bActive);
		}

		// Token: 0x0603FE60 RID: 261728 RVA: 0x00F754A7 File Offset: 0x00F736A7
		private void OnBackBtnClick()
		{
			Action overrideCloseFunc = base.ViewModel.GetOverrideCloseFunc();
			if (overrideCloseFunc == null)
			{
				return;
			}
			overrideCloseFunc();
		}

		// Token: 0x0603FE61 RID: 261729 RVA: 0x00F754BE File Offset: 0x00F736BE
		private void AddHomeBtnExtraCallback()
		{
			UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
			if (uiBehaviourHomeBtn == null)
			{
				return;
			}
			uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
			{
				PinballMainRootView.<>c.<<AddHomeBtnExtraCallback>b__19_0>d <<AddHomeBtnExtraCallback>b__19_0>d;
				<<AddHomeBtnExtraCallback>b__19_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<AddHomeBtnExtraCallback>b__19_0>d.<>1__state = -1;
				<<AddHomeBtnExtraCallback>b__19_0>d.<>t__builder.Start<PinballMainRootView.<>c.<<AddHomeBtnExtraCallback>b__19_0>d>(ref <<AddHomeBtnExtraCallback>b__19_0>d);
				return <<AddHomeBtnExtraCallback>b__19_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x04021546 RID: 136518
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200C533 RID: 50483
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B84D RID: 243789
			CaptionItem,
			// Token: 0x0403B84E RID: 243790
			Content,
			// Token: 0x0403B84F RID: 243791
			TexPlanet,
			// Token: 0x0403B850 RID: 243792
			TexPlanetMask,
			// Token: 0x0403B851 RID: 243793
			TexPlanetChange
		}
	}
}
