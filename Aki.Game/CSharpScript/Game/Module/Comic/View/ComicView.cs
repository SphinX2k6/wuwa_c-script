using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Comic.View
{
	// Token: 0x02005B8F RID: 23439
	public class ComicView : UiViewBase, IUiViewResource
	{
		// Token: 0x0603B4C2 RID: 242882 RVA: 0x00E21A18 File Offset: 0x00E1FC18
		[NullableContext(1)]
		public ComicView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B4C3 RID: 242883 RVA: 0x00E21A24 File Offset: 0x00E1FC24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B4C4 RID: 242884 RVA: 0x00E21A6C File Offset: 0x00E1FC6C
		[NullableContext(1)]
		public string GetExtraResourceId([Nullable(2)] object param)
		{
			int comicId = ((IComicViewOpenParam)param).ComicId;
			ComicDisplayConfig? comicDisplayConfig = ComicConfig.Instance.GetComicDisplayConfig(comicId);
			return ((comicDisplayConfig != null) ? comicDisplayConfig.GetValueOrDefault().ResourceId : null) ?? string.Empty;
		}

		// Token: 0x0603B4C5 RID: 242885 RVA: 0x00E21AB8 File Offset: 0x00E1FCB8
		protected override UniTask OnBeforeStartAsync()
		{
			ComicView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComicView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B4C6 RID: 242886 RVA: 0x00E21AFB File Offset: 0x00E1FCFB
		private void NextPage()
		{
			if (this.SwitchPromise != null)
			{
				return;
			}
			this.NextPageAsync();
		}

		// Token: 0x0603B4C7 RID: 242887 RVA: 0x00E21B10 File Offset: 0x00E1FD10
		public UniTask NextPageAsync()
		{
			ComicView.<NextPageAsync>d__8 <NextPageAsync>d__;
			<NextPageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NextPageAsync>d__.<>4__this = this;
			<NextPageAsync>d__.<>1__state = -1;
			<NextPageAsync>d__.<>t__builder.Start<ComicView.<NextPageAsync>d__8>(ref <NextPageAsync>d__);
			return <NextPageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B4C8 RID: 242888 RVA: 0x00E21B53 File Offset: 0x00E1FD53
		private void OnComicPanelSkip()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B4C9 RID: 242889 RVA: 0x00E21B5C File Offset: 0x00E1FD5C
		private void OnComicPanelComplete()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B4CA RID: 242890 RVA: 0x00E21B65 File Offset: 0x00E1FD65
		[NullableContext(1)]
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Comic_Switch")
			{
				UniTaskCompletionSource switchPromise = this.SwitchPromise;
				if (switchPromise == null)
				{
					return;
				}
				switchPromise.TrySetResult();
			}
		}

		// Token: 0x0603B4CB RID: 242891 RVA: 0x00E21B88 File Offset: 0x00E1FD88
		protected override UniTask OnBeforeHideAsync()
		{
			ComicView.<OnBeforeHideAsync>d__12 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<ComicView.<OnBeforeHideAsync>d__12>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401EE85 RID: 126597
		[Nullable(2)]
		private ComicPanel ComicPanel;

		// Token: 0x0401EE86 RID: 126598
		[Nullable(2)]
		private UniTaskCompletionSource SwitchPromise;

		// Token: 0x0200BD95 RID: 48533
		private static class EComDefine
		{
			// Token: 0x040392E0 RID: 234208
			public const int ComicPanel = 0;
		}
	}
}
