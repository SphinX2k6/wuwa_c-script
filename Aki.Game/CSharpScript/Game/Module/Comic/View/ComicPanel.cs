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
	// Token: 0x02004B6E RID: 19310
	[NullableContext(2)]
	[Nullable(0)]
	public class ComicPanel : UiPanelBase
	{
		// Token: 0x06030407 RID: 197639 RVA: 0x00D71D68 File Offset: 0x00D6FF68
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

		// Token: 0x06030408 RID: 197640 RVA: 0x00D71E74 File Offset: 0x00D70074
		protected override UniTask OnBeforeStartAsync()
		{
			ComicPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComicPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030409 RID: 197641 RVA: 0x00D71EB8 File Offset: 0x00D700B8
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

		// Token: 0x0603040A RID: 197642 RVA: 0x00D71F17 File Offset: 0x00D70117
		public void Skip()
		{
			Action onSkip = this.OnSkip;
			if (onSkip == null)
			{
				return;
			}
			onSkip();
		}

		// Token: 0x0603040B RID: 197643 RVA: 0x00D71F29 File Offset: 0x00D70129
		public void Complete()
		{
			Action onComplete = this.OnComplete;
			if (onComplete == null)
			{
				return;
			}
			onComplete();
		}

		// Token: 0x0603040C RID: 197644 RVA: 0x00D71F3B File Offset: 0x00D7013B
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

		// Token: 0x0603040D RID: 197645 RVA: 0x00D71F69 File Offset: 0x00D70169
		private void OnSkipButtonClick()
		{
			this.Skip();
		}

		// Token: 0x04019930 RID: 104752
		private int ComicConfigId;

		// Token: 0x04019931 RID: 104753
		private int CurPageIndex;

		// Token: 0x04019932 RID: 104754
		[Nullable(1)]
		private readonly List<UUIItem> ItemList = new List<UUIItem>();

		// Token: 0x04019933 RID: 104755
		private Action OnSkip;

		// Token: 0x04019934 RID: 104756
		private Action OnComplete;

		// Token: 0x04019935 RID: 104757
		public Action NextPageDelegate;

		// Token: 0x0200A79D RID: 42909
		[NullableContext(0)]
		private static class EComDefine
		{
			// Token: 0x04033CA6 RID: 212134
			public const int ContentRootItem = 0;

			// Token: 0x04033CA7 RID: 212135
			public const int NextPageButton = 1;

			// Token: 0x04033CA8 RID: 212136
			public const int SkipButton = 2;

			// Token: 0x04033CA9 RID: 212137
			public const int NextPageItem = 3;
		}
	}
}
