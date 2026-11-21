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
	// Token: 0x02004B6F RID: 19311
	public class ComicView : UiViewBase, IUiViewResource
	{
		// Token: 0x0603040F RID: 197647 RVA: 0x00D71F84 File Offset: 0x00D70184
		[NullableContext(1)]
		public ComicView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030410 RID: 197648 RVA: 0x00D71F90 File Offset: 0x00D70190
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

		// Token: 0x06030411 RID: 197649 RVA: 0x00D71FD8 File Offset: 0x00D701D8
		[NullableContext(1)]
		public string GetExtraResourceId([Nullable(2)] object param)
		{
			int comicId = ((IComicViewOpenParam)param).ComicId;
			ComicDisplayConfig? comicDisplayConfig = ComicConfig.Instance.GetComicDisplayConfig(comicId);
			return ((comicDisplayConfig != null) ? comicDisplayConfig.GetValueOrDefault().ResourceId : null) ?? string.Empty;
		}

		// Token: 0x06030412 RID: 197650 RVA: 0x00D72024 File Offset: 0x00D70224
		protected override UniTask OnBeforeStartAsync()
		{
			ComicView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComicView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030413 RID: 197651 RVA: 0x00D72067 File Offset: 0x00D70267
		private void NextPage()
		{
			if (this.SwitchPromise != null)
			{
				return;
			}
			this.NextPageAsync();
		}

		// Token: 0x06030414 RID: 197652 RVA: 0x00D7207C File Offset: 0x00D7027C
		public UniTask NextPageAsync()
		{
			ComicView.<NextPageAsync>d__8 <NextPageAsync>d__;
			<NextPageAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NextPageAsync>d__.<>4__this = this;
			<NextPageAsync>d__.<>1__state = -1;
			<NextPageAsync>d__.<>t__builder.Start<ComicView.<NextPageAsync>d__8>(ref <NextPageAsync>d__);
			return <NextPageAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030415 RID: 197653 RVA: 0x00D720BF File Offset: 0x00D702BF
		private void OnComicPanelSkip()
		{
			base.CloseMe(null);
		}

		// Token: 0x06030416 RID: 197654 RVA: 0x00D720C8 File Offset: 0x00D702C8
		private void OnComicPanelComplete()
		{
			base.CloseMe(null);
		}

		// Token: 0x06030417 RID: 197655 RVA: 0x00D720D1 File Offset: 0x00D702D1
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

		// Token: 0x06030418 RID: 197656 RVA: 0x00D720F4 File Offset: 0x00D702F4
		protected override UniTask OnBeforeHideAsync()
		{
			ComicView.<OnBeforeHideAsync>d__12 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<ComicView.<OnBeforeHideAsync>d__12>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04019936 RID: 104758
		[Nullable(2)]
		private ComicPanel ComicPanel;

		// Token: 0x04019937 RID: 104759
		[Nullable(2)]
		private UniTaskCompletionSource SwitchPromise;

		// Token: 0x0200A79F RID: 42911
		private static class EComDefine
		{
			// Token: 0x04033CAE RID: 212142
			public const int ComicPanel = 0;
		}
	}
}
