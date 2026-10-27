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
	// Token: 0x02006A48 RID: 27208
	[NullableContext(2)]
	[Nullable(0)]
	public class SignalDeviceGuideView : UiViewBase
	{
		// Token: 0x06043ABC RID: 277180 RVA: 0x0108E0EC File Offset: 0x0108C2EC
		[NullableContext(1)]
		public SignalDeviceGuideView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043ABD RID: 277181 RVA: 0x0108E0FC File Offset: 0x0108C2FC
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

		// Token: 0x06043ABE RID: 277182 RVA: 0x0108E2A0 File Offset: 0x0108C4A0
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

		// Token: 0x06043ABF RID: 277183 RVA: 0x0108E37C File Offset: 0x0108C57C
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

		// Token: 0x06043AC0 RID: 277184 RVA: 0x0108E460 File Offset: 0x0108C660
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

		// Token: 0x06043AC1 RID: 277185 RVA: 0x0108E4D0 File Offset: 0x0108C6D0
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

		// Token: 0x06043AC2 RID: 277186 RVA: 0x0108E50C File Offset: 0x0108C70C
		private void PlayAtOnce()
		{
			this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		}

		// Token: 0x06043AC3 RID: 277187 RVA: 0x0108E534 File Offset: 0x0108C734
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

		// Token: 0x06043AC4 RID: 277188 RVA: 0x0108E594 File Offset: 0x0108C794
		protected override UniTask OnBeforeStartAsync()
		{
			SignalDeviceGuideView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SignalDeviceGuideView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043AC5 RID: 277189 RVA: 0x0108E5D8 File Offset: 0x0108C7D8
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

		// Token: 0x06043AC6 RID: 277190 RVA: 0x0108E6DD File Offset: 0x0108C8DD
		protected override void OnBeforeShow()
		{
			this.PlayAtOnce();
		}

		// Token: 0x06043AC7 RID: 277191 RVA: 0x0108E6E8 File Offset: 0x0108C8E8
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

		// Token: 0x06043AC8 RID: 277192 RVA: 0x0108E7CE File Offset: 0x0108C9CE
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402353E RID: 144702
		public const float TWEEN_TIME = 0.3f;

		// Token: 0x0402353F RID: 144703
		public const int GUIDE_ID = 34033;

		// Token: 0x04023540 RID: 144704
		public bool IsPopView = true;

		// Token: 0x04023541 RID: 144705
		private int[] PageArray;

		// Token: 0x04023542 RID: 144706
		private int NowPage;

		// Token: 0x04023543 RID: 144707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<TutorialPageItem> PageDotLayout;

		// Token: 0x04023544 RID: 144708
		private GuideTutorialPagePanel CurrentShowPanel;

		// Token: 0x04023545 RID: 144709
		private GuideTutorialPagePanel LastShowPanel;

		// Token: 0x04023546 RID: 144710
		private ULTweener MoveTween;
	}
}
