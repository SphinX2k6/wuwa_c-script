using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001299 RID: 4761
public class LifePointDrawEntranceView : UiViewBase
{
	// Token: 0x0600824D RID: 33357 RVA: 0x001BA07F File Offset: 0x001B827F
	[NullableContext(1)]
	public LifePointDrawEntranceView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600824E RID: 33358 RVA: 0x001BA094 File Offset: 0x001B8294
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

	// Token: 0x0600824F RID: 33359 RVA: 0x001BA208 File Offset: 0x001B8408
	protected override UniTask OnBeforeStartAsync()
	{
		LifePointDrawEntranceView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LifePointDrawEntranceView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008250 RID: 33360 RVA: 0x001BA24B File Offset: 0x001B844B
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06008251 RID: 33361 RVA: 0x001BA254 File Offset: 0x001B8454
	protected override void OnBeforeShow()
	{
		this.RefreshView();
		this.RefreshScrollPercentage();
	}

	// Token: 0x06008252 RID: 33362 RVA: 0x001BA264 File Offset: 0x001B8464
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

	// Token: 0x06008253 RID: 33363 RVA: 0x001BA320 File Offset: 0x001B8520
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

	// Token: 0x06008254 RID: 33364 RVA: 0x001BA3D8 File Offset: 0x001B85D8
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

	// Token: 0x04003AE0 RID: 15072
	[Nullable(2)]
	private LifePointDrawActivityData LifePointDrawActivityData;

	// Token: 0x04003AE1 RID: 15073
	[Nullable(1)]
	private readonly List<LifePointDrawItem> LifePointItemList = new List<LifePointDrawItem>();

	// Token: 0x04003AE2 RID: 15074
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x020078AE RID: 30894
	private class EComponent
	{
		// Token: 0x04027C1E RID: 162846
		public const int CaptionItem = 0;

		// Token: 0x04027C1F RID: 162847
		public const int ItemScroll = 1;

		// Token: 0x04027C20 RID: 162848
		public const int Point1 = 2;

		// Token: 0x04027C21 RID: 162849
		public const int Point2 = 3;

		// Token: 0x04027C22 RID: 162850
		public const int Point3 = 4;

		// Token: 0x04027C23 RID: 162851
		public const int Point4 = 5;

		// Token: 0x04027C24 RID: 162852
		public const int Point5 = 6;

		// Token: 0x04027C25 RID: 162853
		public const int Point6 = 7;

		// Token: 0x04027C26 RID: 162854
		public const int Point7 = 8;

		// Token: 0x04027C27 RID: 162855
		public const int ProgressText = 9;
	}
}
