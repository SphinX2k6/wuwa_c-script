using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BA5 RID: 23461
	[NullableContext(2)]
	[Nullable(0)]
	public class SignalDeviceGuideView : UiViewBase
	{
		// Token: 0x06039B0A RID: 236298 RVA: 0x010328F4 File Offset: 0x01030AF4
		[NullableContext(1)]
		public SignalDeviceGuideView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039B0B RID: 236299 RVA: 0x01032904 File Offset: 0x01030B04
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnCloseClick)),
				new ValueTuple<int, Delegate>(7, new Action(this.PrePage)),
				new ValueTuple<int, Delegate>(8, new Action(this.NextPage))
			};
		}

		// Token: 0x06039B0C RID: 236300 RVA: 0x01032AA8 File Offset: 0x01030CA8
		private void PrePage()
		{
			if (this.MoveTween == null && this.NowPage > 0)
			{
				UUIItem rootItem = this.CurrentShowPanel.GetRootItem();
				FVector relativeLocation = rootItem.RelativeLocation;
				UUIItem item = base.GetItem(12);
				item.SetUIRelativeLocation(new FVector(-item.Width, item.RelativeLocation.Y, item.RelativeLocation.Z));
				this.InitLastPanel();
				this.LastShowPanel.GetRootItem().SetUIRelativeLocation(new FVector(rootItem.Width, relativeLocation.Y, relativeLocation.Z));
				this.RefreshView(this.NowPage - 1);
				this.MoveTween = ULTweenBPLibrary.LocalPositionXTo(item, 0f, 0.3f, 0f, LTweenEase.InOutCubic);
				this.MoveTween.OnCompleteCallBack.Bind(delegate()
				{
					this.MoveTween = null;
				});
			}
		}

		// Token: 0x06039B0D RID: 236301 RVA: 0x01032B84 File Offset: 0x01030D84
		private void NextPage()
		{
			if (this.MoveTween == null && this.NowPage < this.PageArray.Length - 1)
			{
				UUIItem rootItem = this.CurrentShowPanel.GetRootItem();
				FVector relativeLocation = rootItem.RelativeLocation;
				UUIItem item = base.GetItem(12);
				item.SetUIRelativeLocation(new FVector(item.Width, item.RelativeLocation.Y, item.RelativeLocation.Z));
				this.InitLastPanel();
				this.LastShowPanel.GetRootItem().SetUIRelativeLocation(new FVector(-rootItem.Width, relativeLocation.Y, relativeLocation.Z));
				this.RefreshView(this.NowPage + 1);
				this.MoveTween = ULTweenBPLibrary.LocalPositionXTo(item, 0f, 0.3f, 0f, LTweenEase.InOutCubic);
				this.MoveTween.OnCompleteCallBack.Bind(delegate()
				{
					this.MoveTween = null;
				});
			}
		}

		// Token: 0x06039B0E RID: 236302 RVA: 0x01032C68 File Offset: 0x01030E68
		protected override void OnBeforeDestroy()
		{
			if (this.PageDotLayout != null)
			{
				this.PageDotLayout.ClearChildren();
				this.PageDotLayout = null;
			}
			this.CurrentShowPanel.Destroy(null);
			this.CurrentShowPanel = null;
			if (this.LastShowPanel != null)
			{
				this.LastShowPanel.Destroy(null);
				this.LastShowPanel = null;
			}
			if (this.MoveTween != null)
			{
				this.MoveTween.Kill(false);
				this.MoveTween = null;
			}
		}

		// Token: 0x06039B0F RID: 236303 RVA: 0x01032CD8 File Offset: 0x01030ED8
		[NullableContext(1)]
		private ILayoutItem<TutorialPageItem> InitDetail(object p, UUIItem uiItem, int index)
		{
			TutorialPageItem tutorialPageItem = new TutorialPageItem(uiItem);
			tutorialPageItem.Init();
			tutorialPageItem.UpdateShow(false);
			return new LayoutItem<TutorialPageItem>
			{
				Key = index,
				Value = tutorialPageItem
			};
		}

		// Token: 0x06039B10 RID: 236304 RVA: 0x01032D14 File Offset: 0x01030F14
		private void PlayAtOnce()
		{
			this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		}

		// Token: 0x06039B11 RID: 236305 RVA: 0x01032D3C File Offset: 0x01030F3C
		private void InitLastPanel()
		{
			if (this.LastShowPanel == null)
			{
				UUIItem uiItem = LguiUtil.Instance.CopyItem(base.GetItem(3), base.GetItem(12));
				this.LastShowPanel = new GuideTutorialPagePanel();
				this.LastShowPanel.Init(uiItem);
			}
			this.CurrentShowPanel.PlayAnime(true);
			this.LastShowPanel.PlayAnime(false);
		}

		// Token: 0x06039B12 RID: 236306 RVA: 0x01032D9C File Offset: 0x01030F9C
		protected override UniTask OnBeforeStartAsync()
		{
			SignalDeviceGuideView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SignalDeviceGuideView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039B13 RID: 236307 RVA: 0x01032DE0 File Offset: 0x01030FE0
		protected override void OnStart()
		{
			this.PageDotLayout = new GenericLayoutNew<TutorialPageItem>(base.GetHorizontalLayout(5), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TutorialPageItem>(this.InitDetail), base.GetItem(6));
			this.PageArray = GuideConfig.Instance.GetGuideTutorialPageIds(34033);
			if (this.PageArray.Length <= 1)
			{
				base.GetButton(7).RootUIComp.Get().SetUIActive(false);
				base.GetButton(8).RootUIComp.Get().SetUIActive(false);
				base.GetItem(4).SetUIActive(false);
			}
			else
			{
				base.GetButton(7).RootUIComp.Get().SetUIActive(true);
				base.GetButton(8).RootUIComp.Get().SetUIActive(true);
				base.GetItem(4).SetUIActive(true);
				this.PageDotLayout.RebuildLayoutByDataNew<int>(this.PageArray, null);
			}
			base.GetText(14).SetUIActive(false);
			this.RefreshView(0);
		}

		// Token: 0x06039B14 RID: 236308 RVA: 0x01032EE5 File Offset: 0x010310E5
		protected override void OnBeforeShow()
		{
			this.PlayAtOnce();
		}

		// Token: 0x06039B15 RID: 236309 RVA: 0x01032EF0 File Offset: 0x010310F0
		private void RefreshView(int index)
		{
			if (this.PageArray.Length > 1)
			{
				this.PageDotLayout.GetLayoutItemByIndex(this.NowPage).UpdateShow(false);
				this.PageDotLayout.GetLayoutItemByIndex(index).UpdateShow(true);
				base.GetButton(7).SetSelfInteractive(index > 0);
				base.GetButton(8).SetSelfInteractive(index < this.PageArray.Length - 1);
				if (this.LastShowPanel != null)
				{
					GuideTutorialPage? guideTutorialPage = GuideConfig.Instance.GetGuideTutorialPage(this.PageArray[this.NowPage]);
					this.LastShowPanel.RefreshPage(guideTutorialPage);
				}
			}
			this.NowPage = index;
			GuideTutorialPage? guideTutorialPage2 = GuideConfig.Instance.GetGuideTutorialPage(this.PageArray[this.NowPage]);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), guideTutorialPage2.Value.Title, Array.Empty<object>());
			this.CurrentShowPanel.RefreshPage(guideTutorialPage2);
		}

		// Token: 0x06039B16 RID: 236310 RVA: 0x01032FD6 File Offset: 0x010311D6
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401E730 RID: 124720
		public const float TWEEN_TIME = 0.3f;

		// Token: 0x0401E731 RID: 124721
		public const int GUIDE_ID = 34033;

		// Token: 0x0401E732 RID: 124722
		public bool IsPopView = true;

		// Token: 0x0401E733 RID: 124723
		private int[] PageArray;

		// Token: 0x0401E734 RID: 124724
		private int NowPage;

		// Token: 0x0401E735 RID: 124725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<TutorialPageItem> PageDotLayout;

		// Token: 0x0401E736 RID: 124726
		private GuideTutorialPagePanel CurrentShowPanel;

		// Token: 0x0401E737 RID: 124727
		private GuideTutorialPagePanel LastShowPanel;

		// Token: 0x0401E738 RID: 124728
		private ULTweener MoveTween;
	}
}
