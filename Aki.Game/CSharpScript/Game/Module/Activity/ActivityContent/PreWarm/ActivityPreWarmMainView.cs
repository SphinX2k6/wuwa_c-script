using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x0200523B RID: 21051
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPreWarmMainView : UiViewBase
	{
		// Token: 0x060345C2 RID: 214466 RVA: 0x00EA6729 File Offset: 0x00EA4929
		public ActivityPreWarmMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060345C3 RID: 214467 RVA: 0x00EA6734 File Offset: 0x00EA4934
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnRight));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickBtnExpand));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickBtnShrink));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickBtnJump));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060345C4 RID: 214468 RVA: 0x00EA69FC File Offset: 0x00EA4BFC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPreWarmMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPreWarmMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060345C5 RID: 214469 RVA: 0x00EA6A40 File Offset: 0x00EA4C40
		private UniTask LoadMaterial()
		{
			ActivityPreWarmMainView.<LoadMaterial>d__13 <LoadMaterial>d__;
			<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMaterial>d__.<>4__this = this;
			<LoadMaterial>d__.<>1__state = -1;
			<LoadMaterial>d__.<>t__builder.Start<ActivityPreWarmMainView.<LoadMaterial>d__13>(ref <LoadMaterial>d__);
			return <LoadMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x060345C6 RID: 214470 RVA: 0x00EA6A84 File Offset: 0x00EA4C84
		private void InitText()
		{
			this.TextAnimDataComp = (base.GetText(5).GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.TextPlayTweenComp = (base.GetText(5).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			UUIEffectTextAnimation textAnimDataComp = this.TextAnimDataComp;
			if (textAnimDataComp != null)
			{
				textAnimDataComp.SetSelectorOffset(1f);
			}
			this.TextPlayTweenEndCb = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnTweenEnd));
			this.TextPlayTweenEndCbWrapper = this.TextPlayTweenComp.GetPlayTween().RegisterOnComplete(this.TextPlayTweenEndCb);
			base.GetText(5).SetUIActive(false);
		}

		// Token: 0x060345C7 RID: 214471 RVA: 0x00EA6B34 File Offset: 0x00EA4D34
		private void ShowText()
		{
			if (this.TextAnimDataComp == null || this.TextPlayTweenComp == null)
			{
				Log.Instance.Error(ELogModule.ActivityPreWarm, ELogAuthor.CB, "打字机组件未初始化", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityPreWarm;
			ELogAuthor author = ELogAuthor.CB;
			string message = "播放打字动画";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("时长", this.ParsingDuration);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TextAnimDataComp.SetSelectorOffset(1f);
			this.TextPlayTweenComp.GetPlayTween().duration = this.ParsingDuration;
			this.TextPlayTweenComp.Play();
		}

		// Token: 0x060345C8 RID: 214472 RVA: 0x00EA6BD6 File Offset: 0x00EA4DD6
		private void OnTweenEnd()
		{
			this.TextPlayTweenComp.Stop();
			this.TextAnimDataComp.SetSelectorOffset(0f);
		}

		// Token: 0x060345C9 RID: 214473 RVA: 0x00EA6BF4 File Offset: 0x00EA4DF4
		private void OnChangeInfo(int direction)
		{
			this.CurrentId += direction;
			this.RefreshInfo();
			if (this.UiViewSequence != null && this.UiViewSequence.HasSequenceNameInPlaying("Switch"))
			{
				this.UiViewSequence.ReplaySequence("Switch");
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Switch", false, null);
		}

		// Token: 0x060345CA RID: 214474 RVA: 0x00EA6C60 File Offset: 0x00EA4E60
		private void OnClickBtnJump()
		{
			Log.Instance.Info(ELogModule.ActivityPreWarm, ELogAuthor.CB, "点击跳过,设置5倍数", default(ReadOnlySpan<ValueTuple<string, object>>));
			ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
			if (textPlayTweenComp != null)
			{
				ULGUIPlayTween playTween = textPlayTweenComp.GetPlayTween();
				if (playTween != null)
				{
					ULTweener tweener = playTween.GetTweener();
					if (tweener != null)
					{
						tweener.SetSpeed(5f);
					}
				}
			}
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			ALevelSequenceActor sequencePlayerByKey = rootActor.GetSequencePlayerByKey("Start01");
			if (sequencePlayerByKey == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(5f);
		}

		// Token: 0x060345CB RID: 214475 RVA: 0x00EA6CE7 File Offset: 0x00EA4EE7
		protected override void OnStart()
		{
			this.InitCaptionItem();
			this.InitText();
		}

		// Token: 0x060345CC RID: 214476 RVA: 0x00EA6CF8 File Offset: 0x00EA4EF8
		protected override void OnBeforeShow()
		{
			if (this.IsParsing)
			{
				base.PlaySequence("Start01", delegate
				{
					Log.Instance.Info(ELogModule.ActivityPreWarm, ELogAuthor.CB, "解析动画播放完成", default(ReadOnlySpan<ValueTuple<string, object>>));
					PopupCaptionItem captionItem = this.CaptionItem;
					if (captionItem != null)
					{
						captionItem.SetCloseBtnActive(true);
					}
					UUIItem item2 = base.GetItem(6);
					if (item2 == null)
					{
						return;
					}
					item2.SetUIActive(false);
				}, false);
				AUIBaseActor rootActor = this.RootActor;
				FQualifiedFrameTime fqualifiedFrameTime;
				if (rootActor == null)
				{
					fqualifiedFrameTime = null;
				}
				else
				{
					ALevelSequenceActor sequencePlayerByKey = rootActor.GetSequencePlayerByKey("Start01");
					if (sequencePlayerByKey == null)
					{
						fqualifiedFrameTime = null;
					}
					else
					{
						ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
						fqualifiedFrameTime = ((sequencePlayer != null) ? sequencePlayer.GetDuration() : null);
					}
				}
				FQualifiedFrameTime fqualifiedFrameTime2 = fqualifiedFrameTime;
				if (fqualifiedFrameTime2 != null)
				{
					float num = (float)fqualifiedFrameTime2.Time.FrameNumber.Value + fqualifiedFrameTime2.Time.SubFrame;
					float num2 = (float)fqualifiedFrameTime2.Rate.Denominator / (float)fqualifiedFrameTime2.Rate.Numerator;
					float parsingDuration = num * num2;
					this.ParsingDuration = parsingDuration;
				}
			}
			else
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				base.PlaySequence("Start02", null, false);
			}
			this.RefreshInfo();
		}

		// Token: 0x060345CD RID: 214477 RVA: 0x00EA6DCA File Offset: 0x00EA4FCA
		private void InitCaptionItem()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.CaptionItem.SetCloseBtnActive(!this.IsParsing);
		}

		// Token: 0x060345CE RID: 214478 RVA: 0x00EA6E09 File Offset: 0x00EA5009
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060345CF RID: 214479 RVA: 0x00EA6E12 File Offset: 0x00EA5012
		private void RefreshInfo()
		{
			this.RefreshTitle();
			this.RefreshContentBg();
			this.RefreshLeftRightBtnState();
			this.RefreshDesc();
			this.RefreshShadowIcon();
			this.LastTime = Time.Instance.Now;
		}

		// Token: 0x060345D0 RID: 214480 RVA: 0x00EA6E44 File Offset: 0x00EA5044
		private void RefreshTitle()
		{
			ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
			ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
			base.TrySetSpriteByPath((activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetTitleNumIconPath() : null, base.GetSprite(1), false, null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), (activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetTitle() : null, Array.Empty<object>());
		}

		// Token: 0x060345D1 RID: 214481 RVA: 0x00EA6EB0 File Offset: 0x00EA50B0
		private void RefreshDesc()
		{
			ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
			ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), (activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetDesc() : null, Array.Empty<object>());
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			if (this.IsParsing)
			{
				this.ShowText();
			}
		}

		// Token: 0x060345D2 RID: 214482 RVA: 0x00EA6F18 File Offset: 0x00EA5118
		private void RefreshContentBg()
		{
			ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
			ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
			base.TrySetTextureByPath((activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetBgPath() : null, base.GetTexture(3), null, null);
		}

		// Token: 0x060345D3 RID: 214483 RVA: 0x00EA6F60 File Offset: 0x00EA5160
		private void RefreshShadowIcon()
		{
			if (this.IsParsing)
			{
				ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
				ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
				base.TrySetTextureByPath((activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetShadowIconPath() : null, base.GetTexture(4), null, null);
			}
		}

		// Token: 0x060345D4 RID: 214484 RVA: 0x00EA6FB0 File Offset: 0x00EA51B0
		private void OnClickBtnExpand()
		{
			this.OnDescInfoStateChange(true);
		}

		// Token: 0x060345D5 RID: 214485 RVA: 0x00EA6FB9 File Offset: 0x00EA51B9
		private void OnClickBtnShrink()
		{
			this.OnDescInfoStateChange(false);
		}

		// Token: 0x060345D6 RID: 214486 RVA: 0x00EA6FC4 File Offset: 0x00EA51C4
		private void OnDescInfoStateChange(bool isExpand)
		{
			UUIButtonComponent button = base.GetButton(10);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!isExpand);
			}
			UUIButtonComponent button2 = base.GetButton(11);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(isExpand);
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey(isExpand ? "InfoHide" : "InfoShow", false, false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.PlaySequence(isExpand ? "InfoShow" : "InfoHide", false, null);
		}

		// Token: 0x060345D7 RID: 214487 RVA: 0x00EA7061 File Offset: 0x00EA5261
		private void OnClickBtnLeft()
		{
			this.LogReport();
			this.OnChangeInfo(-1);
		}

		// Token: 0x060345D8 RID: 214488 RVA: 0x00EA7070 File Offset: 0x00EA5270
		private void OnClickBtnRight()
		{
			this.LogReport();
			this.OnChangeInfo(1);
		}

		// Token: 0x060345D9 RID: 214489 RVA: 0x00EA7080 File Offset: 0x00EA5280
		public void RefreshLeftRightBtnState()
		{
			if (this.IsParsing)
			{
				UUIButtonComponent button = base.GetButton(8);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				UUIButtonComponent button2 = base.GetButton(9);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				UUIButtonComponent button3 = base.GetButton(8);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(this.CurrentId > 1);
				}
				UUIButtonComponent button4 = base.GetButton(9);
				if (button4 == null)
				{
					return;
				}
				UUIItem uuiitem = button4.RootUIComp.Get();
				int currentId = this.CurrentId;
				ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
				uuiitem.SetUIActive(currentId < ((instance != null) ? instance.GetLastFinishedId() : 1));
				return;
			}
		}

		// Token: 0x060345DA RID: 214490 RVA: 0x00EA7138 File Offset: 0x00EA5338
		protected override void OnBeforeDestroy()
		{
			if (this.TextPlayTweenEndCbWrapper != null)
			{
				ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
				if (textPlayTweenComp != null)
				{
					ULGUIPlayTween playTween = textPlayTweenComp.GetPlayTween();
					if (playTween != null)
					{
						playTween.UnregisterOnComplete(this.TextPlayTweenEndCbWrapper);
					}
				}
				this.TextPlayTweenEndCbWrapper = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTweenEnd));
			this.TextPlayTweenEndCb = null;
			this.LogReport();
		}

		// Token: 0x060345DB RID: 214491 RVA: 0x00EA719C File Offset: 0x00EA539C
		private void LogReport()
		{
			if (this.LastTime == 0.0)
			{
				return;
			}
			double num = Time.Instance.Now - this.LastTime;
			if (num <= 1000.0)
			{
				return;
			}
			ActivityPreWarmStayLogEvent activityPreWarmStayLogEvent = new ActivityPreWarmStayLogEvent();
			activityPreWarmStayLogEvent.i_activity_id = this.ActivityId;
			activityPreWarmStayLogEvent.i_chapter_id = this.CurrentId;
			activityPreWarmStayLogEvent.i_cost_time = num * TimeUtil.Instance.Millisecond;
			LogReportController.Instance.LogReport(activityPreWarmStayLogEvent);
		}

		// Token: 0x0401BD12 RID: 113938
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BD13 RID: 113939
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401BD14 RID: 113940
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x0401BD15 RID: 113941
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x0401BD16 RID: 113942
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x0401BD17 RID: 113943
		private int CurrentId;

		// Token: 0x0401BD18 RID: 113944
		private bool IsParsing;

		// Token: 0x0401BD19 RID: 113945
		private float ParsingDuration;

		// Token: 0x0401BD1A RID: 113946
		private int ActivityId;

		// Token: 0x0401BD1B RID: 113947
		private double LastTime;

		// Token: 0x0200AE75 RID: 44661
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035E49 RID: 220745
			public const int CaptionItem = 0;

			// Token: 0x04035E4A RID: 220746
			public const int CurrentNum = 1;

			// Token: 0x04035E4B RID: 220747
			public const int TitleTxt = 2;

			// Token: 0x04035E4C RID: 220748
			public const int ContentBg = 3;

			// Token: 0x04035E4D RID: 220749
			public const int ShadowIcon = 4;

			// Token: 0x04035E4E RID: 220750
			public const int TxtDesc = 5;

			// Token: 0x04035E4F RID: 220751
			public const int LoadingRoot = 6;

			// Token: 0x04035E50 RID: 220752
			public const int DetailRoot = 7;

			// Token: 0x04035E51 RID: 220753
			public const int BtnLeft = 8;

			// Token: 0x04035E52 RID: 220754
			public const int BtnRight = 9;

			// Token: 0x04035E53 RID: 220755
			public const int BtnExpand = 10;

			// Token: 0x04035E54 RID: 220756
			public const int BtnShrink = 11;

			// Token: 0x04035E55 RID: 220757
			public const int BtnJump = 12;

			// Token: 0x04035E56 RID: 220758
			public const int TexGlitch = 13;
		}
	}
}
