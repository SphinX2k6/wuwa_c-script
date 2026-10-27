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
	// Token: 0x020062BD RID: 25277
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPreWarmMainView : UiViewBase
	{
		// Token: 0x0603F901 RID: 260353 RVA: 0x00F5F7CD File Offset: 0x00F5D9CD
		public ActivityPreWarmMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F902 RID: 260354 RVA: 0x00F5F7D8 File Offset: 0x00F5D9D8
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

		// Token: 0x0603F903 RID: 260355 RVA: 0x00F5FAA0 File Offset: 0x00F5DCA0
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPreWarmMainView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPreWarmMainView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F904 RID: 260356 RVA: 0x00F5FAE4 File Offset: 0x00F5DCE4
		private UniTask LoadMaterial()
		{
			ActivityPreWarmMainView.<LoadMaterial>d__13 <LoadMaterial>d__;
			<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMaterial>d__.<>4__this = this;
			<LoadMaterial>d__.<>1__state = -1;
			<LoadMaterial>d__.<>t__builder.Start<ActivityPreWarmMainView.<LoadMaterial>d__13>(ref <LoadMaterial>d__);
			return <LoadMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x0603F905 RID: 260357 RVA: 0x00F5FB28 File Offset: 0x00F5DD28
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

		// Token: 0x0603F906 RID: 260358 RVA: 0x00F5FBD8 File Offset: 0x00F5DDD8
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

		// Token: 0x0603F907 RID: 260359 RVA: 0x00F5FC7A File Offset: 0x00F5DE7A
		private void OnTweenEnd()
		{
			this.TextPlayTweenComp.Stop();
			this.TextAnimDataComp.SetSelectorOffset(0f);
		}

		// Token: 0x0603F908 RID: 260360 RVA: 0x00F5FC98 File Offset: 0x00F5DE98
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

		// Token: 0x0603F909 RID: 260361 RVA: 0x00F5FD04 File Offset: 0x00F5DF04
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

		// Token: 0x0603F90A RID: 260362 RVA: 0x00F5FD8B File Offset: 0x00F5DF8B
		protected override void OnStart()
		{
			this.InitCaptionItem();
			this.InitText();
		}

		// Token: 0x0603F90B RID: 260363 RVA: 0x00F5FD9C File Offset: 0x00F5DF9C
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

		// Token: 0x0603F90C RID: 260364 RVA: 0x00F5FE6E File Offset: 0x00F5E06E
		private void InitCaptionItem()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.CaptionItem.SetCloseBtnActive(!this.IsParsing);
		}

		// Token: 0x0603F90D RID: 260365 RVA: 0x00F5FEAD File Offset: 0x00F5E0AD
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603F90E RID: 260366 RVA: 0x00F5FEB6 File Offset: 0x00F5E0B6
		private void RefreshInfo()
		{
			this.RefreshTitle();
			this.RefreshContentBg();
			this.RefreshLeftRightBtnState();
			this.RefreshDesc();
			this.RefreshShadowIcon();
			this.LastTime = Time.Instance.Now;
		}

		// Token: 0x0603F90F RID: 260367 RVA: 0x00F5FEE8 File Offset: 0x00F5E0E8
		private void RefreshTitle()
		{
			ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
			ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
			base.TrySetSpriteByPath((activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetTitleNumIconPath() : null, base.GetSprite(1), false, null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), (activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetTitle() : null, Array.Empty<object>());
		}

		// Token: 0x0603F910 RID: 260368 RVA: 0x00F5FF54 File Offset: 0x00F5E154
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

		// Token: 0x0603F911 RID: 260369 RVA: 0x00F5FFBC File Offset: 0x00F5E1BC
		private void RefreshContentBg()
		{
			ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
			ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
			base.TrySetTextureByPath((activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetBgPath() : null, base.GetTexture(3), null, null);
		}

		// Token: 0x0603F912 RID: 260370 RVA: 0x00F60004 File Offset: 0x00F5E204
		private void RefreshShadowIcon()
		{
			if (this.IsParsing)
			{
				ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
				ActivityPreWarmCollectItemData activityPreWarmCollectItemData = (instance != null) ? instance.GetCollectItemDataById(this.CurrentId) : null;
				base.TrySetTextureByPath((activityPreWarmCollectItemData != null) ? activityPreWarmCollectItemData.GetShadowIconPath() : null, base.GetTexture(4), null, null);
			}
		}

		// Token: 0x0603F913 RID: 260371 RVA: 0x00F60054 File Offset: 0x00F5E254
		private void OnClickBtnExpand()
		{
			this.OnDescInfoStateChange(true);
		}

		// Token: 0x0603F914 RID: 260372 RVA: 0x00F6005D File Offset: 0x00F5E25D
		private void OnClickBtnShrink()
		{
			this.OnDescInfoStateChange(false);
		}

		// Token: 0x0603F915 RID: 260373 RVA: 0x00F60068 File Offset: 0x00F5E268
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

		// Token: 0x0603F916 RID: 260374 RVA: 0x00F60105 File Offset: 0x00F5E305
		private void OnClickBtnLeft()
		{
			this.LogReport();
			this.OnChangeInfo(-1);
		}

		// Token: 0x0603F917 RID: 260375 RVA: 0x00F60114 File Offset: 0x00F5E314
		private void OnClickBtnRight()
		{
			this.LogReport();
			this.OnChangeInfo(1);
		}

		// Token: 0x0603F918 RID: 260376 RVA: 0x00F60124 File Offset: 0x00F5E324
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

		// Token: 0x0603F919 RID: 260377 RVA: 0x00F601DC File Offset: 0x00F5E3DC
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

		// Token: 0x0603F91A RID: 260378 RVA: 0x00F60240 File Offset: 0x00F5E440
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

		// Token: 0x040213E3 RID: 136163
		private PopupCaptionItem CaptionItem;

		// Token: 0x040213E4 RID: 136164
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x040213E5 RID: 136165
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x040213E6 RID: 136166
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x040213E7 RID: 136167
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x040213E8 RID: 136168
		private int CurrentId;

		// Token: 0x040213E9 RID: 136169
		private bool IsParsing;

		// Token: 0x040213EA RID: 136170
		private float ParsingDuration;

		// Token: 0x040213EB RID: 136171
		private int ActivityId;

		// Token: 0x040213EC RID: 136172
		private double LastTime;

		// Token: 0x0200C48E RID: 50318
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B4E7 RID: 242919
			public const int CaptionItem = 0;

			// Token: 0x0403B4E8 RID: 242920
			public const int CurrentNum = 1;

			// Token: 0x0403B4E9 RID: 242921
			public const int TitleTxt = 2;

			// Token: 0x0403B4EA RID: 242922
			public const int ContentBg = 3;

			// Token: 0x0403B4EB RID: 242923
			public const int ShadowIcon = 4;

			// Token: 0x0403B4EC RID: 242924
			public const int TxtDesc = 5;

			// Token: 0x0403B4ED RID: 242925
			public const int LoadingRoot = 6;

			// Token: 0x0403B4EE RID: 242926
			public const int DetailRoot = 7;

			// Token: 0x0403B4EF RID: 242927
			public const int BtnLeft = 8;

			// Token: 0x0403B4F0 RID: 242928
			public const int BtnRight = 9;

			// Token: 0x0403B4F1 RID: 242929
			public const int BtnExpand = 10;

			// Token: 0x0403B4F2 RID: 242930
			public const int BtnShrink = 11;

			// Token: 0x0403B4F3 RID: 242931
			public const int BtnJump = 12;

			// Token: 0x0403B4F4 RID: 242932
			public const int TexGlitch = 13;
		}
	}
}
