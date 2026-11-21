using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200074D RID: 1869
public class LifePointDrawEntranceView : UiViewBase
{
	// Token: 0x060055E4 RID: 21988 RVA: 0x001C2D4F File Offset: 0x001C0F4F
	[NullableContext(1)]
	public LifePointDrawEntranceView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x001C2D64 File Offset: 0x001C0F64
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x001C2ED8 File Offset: 0x001C10D8
	protected override UniTask OnBeforeStartAsync()
	{
		LifePointDrawEntranceView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LifePointDrawEntranceView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060055E7 RID: 21991 RVA: 0x001C2F1B File Offset: 0x001C111B
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x001C2F24 File Offset: 0x001C1124
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshScrollPercentage();
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x001C2F34 File Offset: 0x001C1134
	public void RefreshView()
	{
		LifePointEntrance value = LifePointDrawConfig.Instance.GetLifePointEntranceById(this.LifePointDrawActivityData.Id).Value;
		int groupListLength = value.GroupListLength;
		int count = this.LifePointItemList.Count;
		for (int i = 0; i < count; i++)
		{
			if (i < groupListLength)
			{
				this.LifePointItemList[i].RefreshView(value.GroupList(i), this.LifePointDrawActivityData);
				this.LifePointItemList[i].SetUiActive(true);
				this.LifePointItemList[i].PlaySequence("Start");
			}
			else
			{
				this.LifePointItemList[i].SetUiActive(false);
			}
		}
		this.RefreshProgressText();
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x001C2FF0 File Offset: 0x001C11F0
	private void RefreshScrollPercentage()
	{
		LifePointEntrance value = LifePointDrawConfig.Instance.GetLifePointEntranceById(this.LifePointDrawActivityData.Id).Value;
		int groupListLength = value.GroupListLength;
		int num = 0;
		for (int i = 0; i < groupListLength; i++)
		{
			if (!LifePointDrawModel.Instance.GetGroupRewardState(this.LifePointDrawActivityData.Id, value.GroupList(i)))
			{
				num = i;
				break;
			}
		}
		UUIScrollViewWithScrollbarComponent scrollItem = base.GetScrollViewWithScrollbar(1);
		float percentage = (float)num / (float)groupListLength;
		if (percentage < 0f)
		{
			return;
		}
		Action<float> callback = delegate(float _)
		{
			scrollItem.SetScrollProgress(1f - percentage);
			scrollItem.OnLateUpdate.Unbind();
		};
		scrollItem.OnLateUpdate.Bind(callback);
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x001C30A8 File Offset: 0x001C12A8
	private void RefreshProgressText()
	{
		string progressByActivityId = LifePointDrawModel.Instance.GetProgressByActivityId(this.LifePointDrawActivityData.Id, "Colorful_Finish_Progress");
		UUIText text = base.GetText(9);
		if (text == null)
		{
			return;
		}
		text.SetText(progressByActivityId, true);
	}

	// Token: 0x04003B78 RID: 15224
	[Nullable(2)]
	private LifePointDrawActivityData LifePointDrawActivityData;

	// Token: 0x04003B79 RID: 15225
	[Nullable(1)]
	private readonly List<LifePointDrawItem> LifePointItemList = new List<LifePointDrawItem>();

	// Token: 0x04003B7A RID: 15226
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x02006A39 RID: 27193
	private class EComponent
	{
		// Token: 0x04022F4F RID: 143183
		public const int CaptionItem = 0;

		// Token: 0x04022F50 RID: 143184
		public const int ItemScroll = 1;

		// Token: 0x04022F51 RID: 143185
		public const int Point1 = 2;

		// Token: 0x04022F52 RID: 143186
		public const int Point2 = 3;

		// Token: 0x04022F53 RID: 143187
		public const int Point3 = 4;

		// Token: 0x04022F54 RID: 143188
		public const int Point4 = 5;

		// Token: 0x04022F55 RID: 143189
		public const int Point5 = 6;

		// Token: 0x04022F56 RID: 143190
		public const int Point6 = 7;

		// Token: 0x04022F57 RID: 143191
		public const int Point7 = 8;

		// Token: 0x04022F58 RID: 143192
		public const int ProgressText = 9;
	}
}
