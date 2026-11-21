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
	// Token: 0x020052B3 RID: 21171
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballMainRootView : PinballMainRootViewBase<PinballMainViewModel>
	{
		// Token: 0x06034B11 RID: 215825 RVA: 0x00EBC06A File Offset: 0x00EBA26A
		public PinballMainRootView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034B12 RID: 215826 RVA: 0x00EBC074 File Offset: 0x00EBA274
		protected override void OnRegisterDefaultChildView()
		{
			IPinballMainRootViewOpenParam pinballMainRootViewOpenParam = this.OpenParam as IPinballMainRootViewOpenParam;
			this.DefaultChildViewName = pinballMainRootViewOpenParam.ChildView;
			this.CheckChildViewParam(pinballMainRootViewOpenParam);
		}

		// Token: 0x06034B13 RID: 215827 RVA: 0x00EBC0A0 File Offset: 0x00EBA2A0
		protected override void OnRegisterContentItem()
		{
			this.ContentItem = base.GetItem(1);
		}

		// Token: 0x06034B14 RID: 215828 RVA: 0x00EBC0B0 File Offset: 0x00EBA2B0
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

		// Token: 0x06034B15 RID: 215829 RVA: 0x00EBC16C File Offset: 0x00EBA36C
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

		// Token: 0x06034B16 RID: 215830 RVA: 0x00EBC1FC File Offset: 0x00EBA3FC
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

		// Token: 0x06034B17 RID: 215831 RVA: 0x00EBC2A8 File Offset: 0x00EBA4A8
		protected override UniTask OnBeforeStartAsync()
		{
			PinballMainRootView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballMainRootView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B18 RID: 215832 RVA: 0x00EBC2EB File Offset: 0x00EBA4EB
		protected override void OnStart()
		{
			this.AddHomeBtnExtraCallback();
		}

		// Token: 0x06034B19 RID: 215833 RVA: 0x00EBC2F4 File Offset: 0x00EBA4F4
		protected override void OnBeforeHide()
		{
			PinballModel instance = PinballModel.Instance;
			PinballActivityData pinballActivityData = (instance != null) ? instance.ActivityData : null;
			if (pinballActivityData != null)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, pinballActivityData.Id);
			}
		}

		// Token: 0x06034B1A RID: 215834 RVA: 0x00EBC32C File Offset: 0x00EBA52C
		public void ChangePlanetTexture(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(2), null, null);
		}

		// Token: 0x06034B1B RID: 215835 RVA: 0x00EBC354 File Offset: 0x00EBA554
		public void ChangePlanetMaskTexture(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(3), null, null);
		}

		// Token: 0x06034B1C RID: 215836 RVA: 0x00EBC37C File Offset: 0x00EBA57C
		public void ChangePlanetSwitchTexture(string path)
		{
			base.SetTextureByPath(path, base.GetTexture(4), null, null);
		}

		// Token: 0x06034B1D RID: 215837 RVA: 0x00EBC3A1 File Offset: 0x00EBA5A1
		public void SetViewTitle(string title)
		{
			this.CaptionItem.SetTitleLocalText(title);
		}

		// Token: 0x06034B1E RID: 215838 RVA: 0x00EBC3AF File Offset: 0x00EBA5AF
		public void SetViewIcon(string icon)
		{
			this.CaptionItem.SetTitleIconByResourceId(icon).Forget();
		}

		// Token: 0x06034B1F RID: 215839 RVA: 0x00EBC3C4 File Offset: 0x00EBA5C4
		public void SetViewHelpId(int helpId)
		{
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(helpId);
			});
		}

		// Token: 0x06034B20 RID: 215840 RVA: 0x00EBC3F5 File Offset: 0x00EBA5F5
		public void SetViewHelpBtnActive(bool bActive)
		{
			this.CaptionItem.SetHelpBtnActive(bActive);
		}

		// Token: 0x06034B21 RID: 215841 RVA: 0x00EBC403 File Offset: 0x00EBA603
		private void OnBackBtnClick()
		{
			Action overrideCloseFunc = base.ViewModel.GetOverrideCloseFunc();
			if (overrideCloseFunc == null)
			{
				return;
			}
			overrideCloseFunc();
		}

		// Token: 0x06034B22 RID: 215842 RVA: 0x00EBC41A File Offset: 0x00EBA61A
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

		// Token: 0x0401BE75 RID: 114293
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200AF1A RID: 44826
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040361AF RID: 221615
			CaptionItem,
			// Token: 0x040361B0 RID: 221616
			Content,
			// Token: 0x040361B1 RID: 221617
			TexPlanet,
			// Token: 0x040361B2 RID: 221618
			TexPlanetMask,
			// Token: 0x040361B3 RID: 221619
			TexPlanetChange
		}
	}
}
