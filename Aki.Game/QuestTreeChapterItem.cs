using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BA9 RID: 7081
[NullableContext(2)]
[Nullable(0)]
public class QuestTreeChapterItem : UiPanelBase
{
	// Token: 0x06011A38 RID: 72248 RVA: 0x00534134 File Offset: 0x00532334
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

	// Token: 0x06011A39 RID: 72249 RVA: 0x0053434A File Offset: 0x0053254A
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		QuestTreeModel.Instance.ViewModelMain.AddOnLocatingNode(new Action<QuestTreeChapterData, bool>(this.OnLocatingNode));
	}

	// Token: 0x06011A3A RID: 72250 RVA: 0x00534378 File Offset: 0x00532578
	protected override void OnBeforeDestroy()
	{
		QuestTreeModel.Instance.ViewModelMain.RemoveOnLocatingNode(new Action<QuestTreeChapterData, bool>(this.OnLocatingNode));
	}

	// Token: 0x06011A3B RID: 72251 RVA: 0x00534398 File Offset: 0x00532598
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

	// Token: 0x06011A3C RID: 72252 RVA: 0x005343EC File Offset: 0x005325EC
	private UniTask RefreshImages()
	{
		QuestTreeChapterItem.<RefreshImages>d__8 <RefreshImages>d__;
		<RefreshImages>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshImages>d__.<>4__this = this;
		<RefreshImages>d__.<>1__state = -1;
		<RefreshImages>d__.<>t__builder.Start<QuestTreeChapterItem.<RefreshImages>d__8>(ref <RefreshImages>d__);
		return <RefreshImages>d__.<>t__builder.Task;
	}

	// Token: 0x06011A3D RID: 72253 RVA: 0x00534430 File Offset: 0x00532630
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

	// Token: 0x06011A3E RID: 72254 RVA: 0x005345F4 File Offset: 0x005327F4
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

	// Token: 0x06011A3F RID: 72255 RVA: 0x00534662 File Offset: 0x00532862
	public int GetChapterId()
	{
		QuestTreeChapterData data = this.Data;
		if (data == null)
		{
			return 0;
		}
		return data.Id;
	}

	// Token: 0x06011A40 RID: 72256 RVA: 0x00534675 File Offset: 0x00532875
	public UUIItem GetToggleUiItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.GetRootComponent();
	}

	// Token: 0x06011A41 RID: 72257 RVA: 0x0053468C File Offset: 0x0053288C
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

	// Token: 0x04009A3B RID: 39483
	private QuestTreeChapterData Data;

	// Token: 0x04009A3C RID: 39484
	private bool IsLoaded;

	// Token: 0x04009A3D RID: 39485
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02007EA7 RID: 32423
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028FFA RID: 167930
		public const int TextureRegion = 0;

		// Token: 0x04028FFB RID: 167931
		public const int TextRegionName = 1;

		// Token: 0x04028FFC RID: 167932
		public const int TextProgress = 2;

		// Token: 0x04028FFD RID: 167933
		public const int ToggleChapter = 3;

		// Token: 0x04028FFE RID: 167934
		public const int TextureImage = 4;

		// Token: 0x04028FFF RID: 167935
		public const int ItemAvailable = 5;

		// Token: 0x04029000 RID: 167936
		public const int SpriteTopLine = 6;

		// Token: 0x04029001 RID: 167937
		public const int TextName = 7;

		// Token: 0x04029002 RID: 167938
		public const int TextureRomanNumber = 8;

		// Token: 0x04029003 RID: 167939
		public const int ItemLock = 9;

		// Token: 0x04029004 RID: 167940
		public const int ItemFinish = 10;

		// Token: 0x04029005 RID: 167941
		public const int ItemInProgress = 11;

		// Token: 0x04029006 RID: 167942
		public const int ItemTracking = 12;
	}
}
