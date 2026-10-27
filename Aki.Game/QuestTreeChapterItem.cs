using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026BE RID: 9918
[NullableContext(2)]
[Nullable(0)]
public class QuestTreeChapterItem : UiPanelBase
{
	// Token: 0x06014556 RID: 83286 RVA: 0x005253FC File Offset: 0x005235FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickToggleChapter));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014557 RID: 83287 RVA: 0x00525612 File Offset: 0x00523812
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		QuestTreeModel.Instance.ViewModelMain.AddOnLocatingNode(new Action<QuestTreeChapterData, bool>(this.OnLocatingNode));
	}

	// Token: 0x06014558 RID: 83288 RVA: 0x00525640 File Offset: 0x00523840
	protected override void OnBeforeDestroy()
	{
		QuestTreeModel.Instance.ViewModelMain.RemoveOnLocatingNode(new Action<QuestTreeChapterData, bool>(this.OnLocatingNode));
	}

	// Token: 0x06014559 RID: 83289 RVA: 0x00525660 File Offset: 0x00523860
	[NullableContext(1)]
	public UniTask LoadOrRefresh(QuestTreeChapterData data, UUIItem parent)
	{
		QuestTreeChapterItem.<LoadOrRefresh>d__7 <LoadOrRefresh>d__;
		<LoadOrRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadOrRefresh>d__.<>4__this = this;
		<LoadOrRefresh>d__.data = data;
		<LoadOrRefresh>d__.parent = parent;
		<LoadOrRefresh>d__.<>1__state = -1;
		<LoadOrRefresh>d__.<>t__builder.Start<QuestTreeChapterItem.<LoadOrRefresh>d__7>(ref <LoadOrRefresh>d__);
		return <LoadOrRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x0601455A RID: 83290 RVA: 0x005256B4 File Offset: 0x005238B4
	private UniTask RefreshImages()
	{
		QuestTreeChapterItem.<RefreshImages>d__8 <RefreshImages>d__;
		<RefreshImages>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshImages>d__.<>4__this = this;
		<RefreshImages>d__.<>1__state = -1;
		<RefreshImages>d__.<>t__builder.Start<QuestTreeChapterItem.<RefreshImages>d__8>(ref <RefreshImages>d__);
		return <RefreshImages>d__.<>t__builder.Task;
	}

	// Token: 0x0601455B RID: 83291 RVA: 0x005256F8 File Offset: 0x005238F8
	private void RefreshInfo()
	{
		if (this.Data == null)
		{
			return;
		}
		if (this.Data.IsUnlock)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.Config.Value.RegionName, Array.Empty<object>());
		}
		else
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText("???", true);
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), this.Data.IsUnlock ? this.Data.Config.Value.Name : "QuestTree_Hide", Array.Empty<object>());
		ValueTuple<int, int> progress = this.Data.Progress;
		int item = progress.Item1;
		int item2 = progress.Item2;
		UUIText text2 = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("</color>/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		if (!this.Data.IsUnlock)
		{
			base.GetText(2).SetText("<color=#ffffff>0</color>/??", true);
		}
		base.GetItem(10).SetUIActive(false);
		base.GetItem(12).SetUIActive(this.Data.IsTracking);
		base.GetItem(11).SetUIActive(this.Data.IsUnlock && !this.Data.IsTracking);
		base.GetItem(9).SetUIActive(!this.Data.IsUnlock);
		base.GetSprite(6).SetUIActive(this.Data.IsUnlock);
		base.GetItem(5).SetUIActive(this.Data.HasAvailableQuest);
	}

	// Token: 0x0601455C RID: 83292 RVA: 0x005258BC File Offset: 0x00523ABC
	private void OnClickToggleChapter(EToggleState _)
	{
		base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		if (!this.Data.IsUnlock)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("QuestTree_ChapterIsLocked", Array.Empty<object>());
			return;
		}
		QuestTreeController.Instance.OpenChapterView(this.Data.Id, null);
		QuestTreeModel.Instance.ViewModelMain.SetShouldLocateToDefaultNode(false);
	}

	// Token: 0x0601455D RID: 83293 RVA: 0x0052592A File Offset: 0x00523B2A
	public int GetChapterId()
	{
		QuestTreeChapterData data = this.Data;
		if (data == null)
		{
			return 0;
		}
		return data.Id;
	}

	// Token: 0x0601455E RID: 83294 RVA: 0x0052593D File Offset: 0x00523B3D
	public UUIItem GetToggleUiItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.GetRootComponent();
	}

	// Token: 0x0601455F RID: 83295 RVA: 0x00525954 File Offset: 0x00523B54
	private void OnLocatingNode(QuestTreeChapterData data, bool tween)
	{
		if (data == this.Data)
		{
			UUIItem rootComponent = base.GetExtendToggle(3).GetRootComponent();
			QuestTreeNodeLocatingHelper locatingHelper = QuestTreeModel.Instance.ViewModelMain.LocatingHelper;
			if (locatingHelper != null)
			{
				locatingHelper.LocateToNode(rootComponent, tween, false);
			}
			if (data != null && data.IsTracking)
			{
				this.SeqPlayer.PlayLevelSequenceByName("Jumpy", false, null, false);
			}
			if (Info.Instance.IsInGamepad())
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(rootComponent, true, false, false);
			}
		}
	}

	// Token: 0x040098E3 RID: 39139
	private QuestTreeChapterData Data;

	// Token: 0x040098E4 RID: 39140
	private bool IsLoaded;

	// Token: 0x040098E5 RID: 39141
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02008D1E RID: 36126
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DCE3 RID: 187619
		public const int TextureRegion = 0;

		// Token: 0x0402DCE4 RID: 187620
		public const int TextRegionName = 1;

		// Token: 0x0402DCE5 RID: 187621
		public const int TextProgress = 2;

		// Token: 0x0402DCE6 RID: 187622
		public const int ToggleChapter = 3;

		// Token: 0x0402DCE7 RID: 187623
		public const int TextureImage = 4;

		// Token: 0x0402DCE8 RID: 187624
		public const int ItemAvailable = 5;

		// Token: 0x0402DCE9 RID: 187625
		public const int SpriteTopLine = 6;

		// Token: 0x0402DCEA RID: 187626
		public const int TextName = 7;

		// Token: 0x0402DCEB RID: 187627
		public const int TextureRomanNumber = 8;

		// Token: 0x0402DCEC RID: 187628
		public const int ItemLock = 9;

		// Token: 0x0402DCED RID: 187629
		public const int ItemFinish = 10;

		// Token: 0x0402DCEE RID: 187630
		public const int ItemInProgress = 11;

		// Token: 0x0402DCEF RID: 187631
		public const int ItemTracking = 12;
	}
}
