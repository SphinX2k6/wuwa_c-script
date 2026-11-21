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
	// Token: 0x02004019 RID: 16409
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotArtWord2dView : UiViewBase
	{
		// Token: 0x06029883 RID: 170115 RVA: 0x00BB9CCC File Offset: 0x00BB7ECC
		public PlotArtWord2dView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06029884 RID: 170116 RVA: 0x00BB9D1C File Offset: 0x00BB7F1C
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

		// Token: 0x06029885 RID: 170117 RVA: 0x00BB9D88 File Offset: 0x00BB7F88
		protected override UniTask OnBeforeStartAsync()
		{
			PlotArtWord2dView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PlotArtWord2dView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029886 RID: 170118 RVA: 0x00BB9DCC File Offset: 0x00BB7FCC
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
					sequencePlayer.SetPlaybackPosition(new FMovieSceneSequencePlaybackParams
					{
						PositionType = EMovieScenePositionType.Frame,
						UpdateMethod = EUpdatePositionMethod.Play
					});
				}
			}
			if (this.Segments.Count > 0)
			{
				this.CurSegmentIndex = 0;
				this.PlaySegment(this.CurSegmentIndex);
			}
		}

		// Token: 0x06029887 RID: 170119 RVA: 0x00BB9F54 File Offset: 0x00BB8154
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

		// Token: 0x06029888 RID: 170120 RVA: 0x00BB9F9F File Offset: 0x00BB819F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.RefreshContentVisible();
		}

		// Token: 0x06029889 RID: 170121 RVA: 0x00BB9FD8 File Offset: 0x00BB81D8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x0602988A RID: 170122 RVA: 0x00BBA00B File Offset: 0x00BB820B
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

		// Token: 0x0602988B RID: 170123 RVA: 0x00BBA03F File Offset: 0x00BB823F
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			this.RefreshContentVisible();
		}

		// Token: 0x0602988C RID: 170124 RVA: 0x00BBA047 File Offset: 0x00BB8247
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			this.RefreshContentVisible();
		}

		// Token: 0x0602988D RID: 170125 RVA: 0x00BBA050 File Offset: 0x00BB8250
		private bool IsUiClean()
		{
			UiViewBase topView = UiModel.Instance.GetTopView(ELayerType.Normal);
			return (topView == null || UiModel.Instance.CanShowPlotViewWhiteList.Contains(topView.ViewInfo.Name)) && UiModel.Instance.PopList.Count == 0;
		}

		// Token: 0x0602988E RID: 170126 RVA: 0x00BBA09C File Offset: 0x00BB829C
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

		// Token: 0x0602988F RID: 170127 RVA: 0x00BBA0D4 File Offset: 0x00BB82D4
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

		// Token: 0x06029890 RID: 170128 RVA: 0x00BBA144 File Offset: 0x00BB8344
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

		// Token: 0x06029891 RID: 170129 RVA: 0x00BBA244 File Offset: 0x00BB8444
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

		// Token: 0x06029892 RID: 170130 RVA: 0x00BBA290 File Offset: 0x00BB8490
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

		// Token: 0x06029893 RID: 170131 RVA: 0x00BBA35C File Offset: 0x00BB855C
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

		// Token: 0x06029894 RID: 170132 RVA: 0x00BBA3CC File Offset: 0x00BB85CC
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
			ulevelSequencePlayer.PlayTo_Loop(new FMovieSceneSequencePlaybackParams
			{
				MarkedFrame = valueTuple.Item2,
				PositionType = EMovieScenePositionType.MarkedFrame,
				UpdateMethod = EUpdatePositionMethod.Play
			}, valueTuple.Item1);
		}

		// Token: 0x04016AAC RID: 92844
		private readonly List<PlotArtWord2dTextPanel> TextPanels = new List<PlotArtWord2dTextPanel>();

		// Token: 0x04016AAD RID: 92845
		[Nullable(2)]
		private ALevelSequenceActor SequenceActor;

		// Token: 0x04016AAE RID: 92846
		private string SequenceName = string.Empty;

		// Token: 0x04016AAF RID: 92847
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

		// Token: 0x04016AB0 RID: 92848
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

		// Token: 0x04016AB1 RID: 92849
		private int CurSegmentIndex = -1;

		// Token: 0x04016AB2 RID: 92850
		private bool ContentVisible = true;

		// Token: 0x02009BD8 RID: 39896
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04030835 RID: 198709
			ItemContent,
			// Token: 0x04030836 RID: 198710
			ItemText
		}
	}
}
