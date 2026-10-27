using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Comic.View
{
	// Token: 0x02005B8E RID: 23438
	[NullableContext(2)]
	[Nullable(0)]
	public class ComicPanel : UiPanelBase
	{
		// Token: 0x0603B4BA RID: 242874 RVA: 0x00E217FC File Offset: 0x00E1F9FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnNextPageButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnSkipButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B4BB RID: 242875 RVA: 0x00E21908 File Offset: 0x00E1FB08
		protected override UniTask OnBeforeStartAsync()
		{
			ComicPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComicPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B4BC RID: 242876 RVA: 0x00E2194C File Offset: 0x00E1FB4C
		public void NextPage()
		{
			if (this.CurPageIndex + 1 >= this.ItemList.Count)
			{
				return;
			}
			this.ItemList[this.CurPageIndex].SetUIActive(false);
			this.CurPageIndex++;
			this.ItemList[this.CurPageIndex].SetUIActive(true);
		}

		// Token: 0x0603B4BD RID: 242877 RVA: 0x00E219AB File Offset: 0x00E1FBAB
		public void Skip()
		{
			Action onSkip = this.OnSkip;
			if (onSkip == null)
			{
				return;
			}
			onSkip();
		}

		// Token: 0x0603B4BE RID: 242878 RVA: 0x00E219BD File Offset: 0x00E1FBBD
		public void Complete()
		{
			Action onComplete = this.OnComplete;
			if (onComplete == null)
			{
				return;
			}
			onComplete();
		}

		// Token: 0x0603B4BF RID: 242879 RVA: 0x00E219CF File Offset: 0x00E1FBCF
		private void OnNextPageButtonClick()
		{
			if (this.CurPageIndex + 1 >= this.ItemList.Count)
			{
				this.Complete();
				return;
			}
			Action nextPageDelegate = this.NextPageDelegate;
			if (nextPageDelegate == null)
			{
				return;
			}
			nextPageDelegate();
		}

		// Token: 0x0603B4C0 RID: 242880 RVA: 0x00E219FD File Offset: 0x00E1FBFD
		private void OnSkipButtonClick()
		{
			this.Skip();
		}

		// Token: 0x0401EE7F RID: 126591
		private int ComicConfigId;

		// Token: 0x0401EE80 RID: 126592
		private int CurPageIndex;

		// Token: 0x0401EE81 RID: 126593
		[Nullable(1)]
		private readonly List<UUIItem> ItemList = new List<UUIItem>();

		// Token: 0x0401EE82 RID: 126594
		private Action OnSkip;

		// Token: 0x0401EE83 RID: 126595
		private Action OnComplete;

		// Token: 0x0401EE84 RID: 126596
		public Action NextPageDelegate;

		// Token: 0x0200BD93 RID: 48531
		[NullableContext(0)]
		private static class EComDefine
		{
			// Token: 0x040392D8 RID: 234200
			public const int ContentRootItem = 0;

			// Token: 0x040392D9 RID: 234201
			public const int NextPageButton = 1;

			// Token: 0x040392DA RID: 234202
			public const int SkipButton = 2;

			// Token: 0x040392DB RID: 234203
			public const int NextPageItem = 3;
		}
	}
}
