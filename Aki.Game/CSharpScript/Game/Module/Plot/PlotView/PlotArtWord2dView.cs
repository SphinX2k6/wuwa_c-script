using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200504A RID: 20554
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotArtWord2dView : UiViewBase
	{
		// Token: 0x060349A1 RID: 215457 RVA: 0x00C6CB60 File Offset: 0x00C6AD60
		public PlotArtWord2dView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060349A2 RID: 215458 RVA: 0x00C6CBB0 File Offset: 0x00C6ADB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060349A3 RID: 215459 RVA: 0x00C6CC1C File Offset: 0x00C6AE1C
		protected override UniTask OnBeforeStartAsync()
		{
			PlotArtWord2dView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PlotArtWord2dView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349A4 RID: 215460 RVA: 0x00C6CC60 File Offset: 0x00C6AE60
		protected override void OnStart()
		{
			if (string.IsNullOrEmpty(this.SequenceName))
			{
				return;
			}
			AUIBaseActor rootActor = this.RootActor;
			USequencePlayContext usequencePlayContext = (rootActor != null) ? rootActor.GetSequencePlayContextOfKey(this.SequenceName) : null;
			if (usequencePlayContext == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[PlotArtWord2dView]界面上找不到指定Sequence";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sequenceName", this.SequenceName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			usequencePlayContext.bIsAsync = false;
			usequencePlayContext.ExecutePlay();
			AUIBaseActor rootActor2 = this.RootActor;
			this.SequenceActor = ((rootActor2 != null) ? rootActor2.GetSequencePlayerByKey(this.SequenceName) : null);
			if (this.SequenceActor == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.HYF;
				string message2 = "[PlotArtWord2dView]Sequence播放器分配失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("sequenceName", this.SequenceName);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			foreach (ValueTuple<FMovieSceneObjectBindingID, AActor> valueTuple3 in this.PendingBindings)
			{
				ALevelSequenceActor sequenceActor = this.SequenceActor;
				FMovieSceneObjectBindingID item = valueTuple3.Item1;
				TArray<AActor> tarray = new TArray<AActor>
				{
					valueTuple3.Item2
				};
				sequenceActor.SetBinding(item, tarray, false);
			}
			if (this.PendingBindings.Count > 0)
			{
				ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play));
				}
			}
			if (this.Segments.Count > 0)
			{
				this.CurSegmentIndex = 0;
				this.PlaySegment(this.CurSegmentIndex);
			}
		}

		// Token: 0x060349A5 RID: 215461 RVA: 0x00C6CDE8 File Offset: 0x00C6AFE8
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<ULevelSequence> LoadSequenceAssetAsync(string sequenceName)
		{
			PlotArtWord2dView.<LoadSequenceAssetAsync>d__12 <LoadSequenceAssetAsync>d__;
			<LoadSequenceAssetAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ULevelSequence>.Create();
			<LoadSequenceAssetAsync>d__.<>4__this = this;
			<LoadSequenceAssetAsync>d__.sequenceName = sequenceName;
			<LoadSequenceAssetAsync>d__.<>1__state = -1;
			<LoadSequenceAssetAsync>d__.<>t__builder.Start<PlotArtWord2dView.<LoadSequenceAssetAsync>d__12>(ref <LoadSequenceAssetAsync>d__);
			return <LoadSequenceAssetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349A6 RID: 215462 RVA: 0x00C6CE33 File Offset: 0x00C6B033
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.RefreshContentVisible();
		}

		// Token: 0x060349A7 RID: 215463 RVA: 0x00C6CE6C File Offset: 0x00C6B06C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x060349A8 RID: 215464 RVA: 0x00C6CE9F File Offset: 0x00C6B09F
		protected override void OnBeforeDestroy()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (sequenceActor != null)
			{
				ULevelSequencePlayer sequencePlayer = sequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.Stop();
				}
			}
			this.TextPanels.Clear();
			this.PendingBindings.Clear();
		}

		// Token: 0x060349A9 RID: 215465 RVA: 0x00C6CED3 File Offset: 0x00C6B0D3
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			this.RefreshContentVisible();
		}

		// Token: 0x060349AA RID: 215466 RVA: 0x00C6CEDB File Offset: 0x00C6B0DB
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			this.RefreshContentVisible();
		}

		// Token: 0x060349AB RID: 215467 RVA: 0x00C6CEE4 File Offset: 0x00C6B0E4
		private bool IsUiClean()
		{
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
			return (topView == null || UiModel.Instance.CanShowPlotViewWhiteList.Contains(topView.ViewInfo.Name)) && UiModel.Instance.PopList.Count == 0;
		}

		// Token: 0x060349AC RID: 215468 RVA: 0x00C6CF30 File Offset: 0x00C6B130
		private void RefreshContentVisible()
		{
			bool flag = this.IsUiClean();
			if (flag == this.ContentVisible)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			this.ContentVisible = flag;
			item.SetUIActive(flag);
		}

		// Token: 0x060349AD RID: 215469 RVA: 0x00C6CF68 File Offset: 0x00C6B168
		public void SwitchToNextMark()
		{
			if (this.CurSegmentIndex + 1 >= this.Segments.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[PlotArtWord2dView]已在最后一个循环段, 忽略切换标记信号";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("curIndex", this.CurSegmentIndex);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.CurSegmentIndex++;
			this.PlaySegment(this.CurSegmentIndex);
		}

		// Token: 0x060349AE RID: 215470 RVA: 0x00C6CFD8 File Offset: 0x00C6B1D8
		private void CollectLoopSegments(UMovieScene movieScene)
		{
			TArray<FMovieSceneMarkedFrame> markedFrames = movieScene.MarkedFrames;
			List<ValueTuple<string, int>> list = new List<ValueTuple<string, int>>();
			for (int i = 0; i < markedFrames.Num(); i++)
			{
				FMovieSceneMarkedFrame fmovieSceneMarkedFrame = markedFrames.Get(i);
				list.Add(new ValueTuple<string, int>(fmovieSceneMarkedFrame.Label, fmovieSceneMarkedFrame.FrameNumber.Value));
			}
			list.Sort(([TupleElementNames(new string[]
			{
				"Label",
				"Frame"
			})] [Nullable(new byte[]
			{
				0,
				1
			})] ValueTuple<string, int> left, [TupleElementNames(new string[]
			{
				"Label",
				"Frame"
			})] [Nullable(new byte[]
			{
				0,
				1
			})] ValueTuple<string, int> right) => left.Item2.CompareTo(right.Item2));
			if (list.Count % 2 != 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[PlotArtWord2dView]Sequence标记数不是偶数, 末尾标记被忽略";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("count", list.Count);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.Segments = new List<ValueTuple<string, string>>();
			int num = 0;
			while (num + 1 < list.Count)
			{
				this.Segments.Add(new ValueTuple<string, string>(list[num].Item1, list[num + 1].Item1));
				num += 2;
			}
		}

		// Token: 0x060349AF RID: 215471 RVA: 0x00C6D0D8 File Offset: 0x00C6B2D8
		private UniTask CreateTextPanelsAsync(UMovieScene movieScene)
		{
			PlotArtWord2dView.<CreateTextPanelsAsync>d__22 <CreateTextPanelsAsync>d__;
			<CreateTextPanelsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTextPanelsAsync>d__.<>4__this = this;
			<CreateTextPanelsAsync>d__.movieScene = movieScene;
			<CreateTextPanelsAsync>d__.<>1__state = -1;
			<CreateTextPanelsAsync>d__.<>t__builder.Start<PlotArtWord2dView.<CreateTextPanelsAsync>d__22>(ref <CreateTextPanelsAsync>d__);
			return <CreateTextPanelsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349B0 RID: 215472 RVA: 0x00C6D124 File Offset: 0x00C6B324
		private HashSet<string> CollectBindingGuidsByTag(TMap<FName, FMovieSceneObjectBindingIDs> bindingGroups, string tag)
		{
			HashSet<string> hashSet = new HashSet<string>();
			FMovieSceneObjectBindingIDs fmovieSceneObjectBindingIDs;
			if (!bindingGroups.TryGetValue(new FName(tag), out fmovieSceneObjectBindingIDs) || fmovieSceneObjectBindingIDs == null)
			{
				return hashSet;
			}
			for (int i = 0; i < fmovieSceneObjectBindingIDs.IDs.Num(); i++)
			{
				FGuid guid = fmovieSceneObjectBindingIDs.IDs.Get(i).Guid;
				HashSet<string> hashSet2 = hashSet;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted<uint>(guid.A);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<uint>(guid.B);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<uint>(guid.C);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<uint>(guid.D);
				hashSet2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return hashSet;
		}

		// Token: 0x060349B1 RID: 215473 RVA: 0x00C6D1F0 File Offset: 0x00C6B3F0
		private UniTask CreateTextPanelAsync(PlotArtWord2dTextPanel panel, AActor copyActor, string tag, FMovieSceneObjectBindingID bindingId, float languageScale)
		{
			PlotArtWord2dView.<CreateTextPanelAsync>d__24 <CreateTextPanelAsync>d__;
			<CreateTextPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTextPanelAsync>d__.<>4__this = this;
			<CreateTextPanelAsync>d__.panel = panel;
			<CreateTextPanelAsync>d__.copyActor = copyActor;
			<CreateTextPanelAsync>d__.tag = tag;
			<CreateTextPanelAsync>d__.bindingId = bindingId;
			<CreateTextPanelAsync>d__.languageScale = languageScale;
			<CreateTextPanelAsync>d__.<>1__state = -1;
			<CreateTextPanelAsync>d__.<>t__builder.Start<PlotArtWord2dView.<CreateTextPanelAsync>d__24>(ref <CreateTextPanelAsync>d__);
			return <CreateTextPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349B2 RID: 215474 RVA: 0x00C6D260 File Offset: 0x00C6B460
		private void PlaySegment(int index)
		{
			if (index < 0 || index >= this.Segments.Count)
			{
				return;
			}
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (sequenceActor != null) ? sequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				return;
			}
			ValueTuple<string, string> valueTuple = this.Segments[index];
			ulevelSequencePlayer.PlayTo_Loop(new FMovieSceneSequencePlaybackParams(new FFrameTime(), 0f, valueTuple.Item2, EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play), valueTuple.Item1);
		}

		// Token: 0x0401C089 RID: 114825
		private readonly List<PlotArtWord2dTextPanel> TextPanels = new List<PlotArtWord2dTextPanel>();

		// Token: 0x0401C08A RID: 114826
		[Nullable(2)]
		private ALevelSequenceActor SequenceActor;

		// Token: 0x0401C08B RID: 114827
		private string SequenceName = string.Empty;

		// Token: 0x0401C08C RID: 114828
		[TupleElementNames(new string[]
		{
			"BindingId",
			"TextActor"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly List<ValueTuple<FMovieSceneObjectBindingID, AActor>> PendingBindings = new List<ValueTuple<FMovieSceneObjectBindingID, AActor>>();

		// Token: 0x0401C08D RID: 114829
		[TupleElementNames(new string[]
		{
			"StartLabel",
			"EndLabel"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private List<ValueTuple<string, string>> Segments = new List<ValueTuple<string, string>>();

		// Token: 0x0401C08E RID: 114830
		private int CurSegmentIndex = -1;

		// Token: 0x0401C08F RID: 114831
		private bool ContentVisible = true;

		// Token: 0x0200B19E RID: 45470
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035DE0 RID: 220640
			ItemContent,
			// Token: 0x04035DE1 RID: 220641
			ItemText
		}
	}
}
