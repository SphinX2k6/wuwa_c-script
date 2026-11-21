using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000664 RID: 1636
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastActivityTaskView : UiViewBase
{
	// Token: 0x06004BB2 RID: 19378 RVA: 0x0019AEC8 File Offset: 0x001990C8
	public BlackCoastActivityTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06004BB3 RID: 19379 RVA: 0x0019AEE4 File Offset: 0x001990E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickPre));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickNext));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004BB4 RID: 19380 RVA: 0x0019B0FC File Offset: 0x001992FC
	protected override UniTask OnBeforeStartAsync()
	{
		BlackCoastActivityTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BlackCoastActivityTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004BB5 RID: 19381 RVA: 0x0019B140 File Offset: 0x00199340
	private UniTask LoadMaterial()
	{
		BlackCoastActivityTaskView.<LoadMaterial>d__12 <LoadMaterial>d__;
		<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMaterial>d__.<>4__this = this;
		<LoadMaterial>d__.<>1__state = -1;
		<LoadMaterial>d__.<>t__builder.Start<BlackCoastActivityTaskView.<LoadMaterial>d__12>(ref <LoadMaterial>d__);
		return <LoadMaterial>d__.<>t__builder.Task;
	}

	// Token: 0x06004BB6 RID: 19382 RVA: 0x0019B184 File Offset: 0x00199384
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
	}

	// Token: 0x06004BB7 RID: 19383 RVA: 0x0019B1B4 File Offset: 0x001993B4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x06004BB8 RID: 19384 RVA: 0x0019B1D2 File Offset: 0x001993D2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshTaskLayout));
	}

	// Token: 0x06004BB9 RID: 19385 RVA: 0x0019B1F0 File Offset: 0x001993F0
	protected override void OnBeforeDestroy()
	{
		MediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.Clear();
		}
		this.MediaPlayer = null;
		this.CancelLoad();
	}

	// Token: 0x06004BBA RID: 19386 RVA: 0x0019B210 File Offset: 0x00199410
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x06004BBB RID: 19387 RVA: 0x0019B232 File Offset: 0x00199432
	private PageDot<int> InitPageDot()
	{
		return new PageDot<int>();
	}

	// Token: 0x06004BBC RID: 19388 RVA: 0x0019B239 File Offset: 0x00199439
	private BlackCoastTaskItem CreateTaskItem()
	{
		return new BlackCoastTaskItem();
	}

	// Token: 0x06004BBD RID: 19389 RVA: 0x0019B240 File Offset: 0x00199440
	private void OnRefreshTaskLayout(int activityId)
	{
		if (this.ActivityBaseData != null && this.ActivityBaseData.Id == activityId)
		{
			BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[this.CurrentSelectedIndex]);
			this.RefreshStageInfo();
			this.RefreshTaskList(stageById.GetTaskList(), false);
		}
	}

	// Token: 0x06004BBE RID: 19390 RVA: 0x0019B293 File Offset: 0x00199493
	private void OnClickPre()
	{
		this.RefreshView(this.CurrentSelectedIndex - 1);
	}

	// Token: 0x06004BBF RID: 19391 RVA: 0x0019B2A4 File Offset: 0x001994A4
	private void OnClickNext()
	{
		int index = this.CurrentSelectedIndex + 1;
		BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[index]);
		if (stageById.IsUnlock)
		{
			this.RefreshView(index);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId(stageById.GetLockConditionText(), Array.Empty<object>());
	}

	// Token: 0x06004BC0 RID: 19392 RVA: 0x0019B2F8 File Offset: 0x001994F8
	private UniTask InitView(int index)
	{
		BlackCoastActivityTaskView.<InitView>d__23 <InitView>d__;
		<InitView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitView>d__.<>4__this = this;
		<InitView>d__.index = index;
		<InitView>d__.<>1__state = -1;
		<InitView>d__.<>t__builder.Start<BlackCoastActivityTaskView.<InitView>d__23>(ref <InitView>d__);
		return <InitView>d__.<>t__builder.Task;
	}

	// Token: 0x06004BC1 RID: 19393 RVA: 0x0019B344 File Offset: 0x00199544
	private UniTask RefreshView(int index)
	{
		BlackCoastActivityTaskView.<RefreshView>d__24 <RefreshView>d__;
		<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshView>d__.<>4__this = this;
		<RefreshView>d__.index = index;
		<RefreshView>d__.<>1__state = -1;
		<RefreshView>d__.<>t__builder.Start<BlackCoastActivityTaskView.<RefreshView>d__24>(ref <RefreshView>d__);
		return <RefreshView>d__.<>t__builder.Task;
	}

	// Token: 0x06004BC2 RID: 19394 RVA: 0x0019B390 File Offset: 0x00199590
	private void RefreshStageInfo()
	{
		BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[this.CurrentSelectedIndex]);
		BlackCoastThemeStageRe? stageConfig = ActivityBlackCoastConfig.Instance.GetStageConfig(stageById.StageId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "BlackCoastTheme_TaskCompleteProgress", new <>z__ReadOnlySingleElementList<object>(stageById.GetTaskProgress()));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), stageConfig.Value.TitleDetail, Array.Empty<object>());
	}

	// Token: 0x06004BC3 RID: 19395 RVA: 0x0019B417 File Offset: 0x00199617
	private void RefreshTaskList(List<BlackCoastTaskData> data, bool playGridAnim = false)
	{
		this.TaskScroll.RefreshByData(data, null, playGridAnim);
	}

	// Token: 0x06004BC4 RID: 19396 RVA: 0x0019B428 File Offset: 0x00199628
	private void RefreshBg()
	{
		BlackCoastStageInfo stageById = this.ActivityBaseData.GetStageById(this.StageIdList[this.CurrentSelectedIndex]);
		this.MediaPlayer.PlayVideo(stageById.StageId.ToString(), stageById.GetVideoSource(), true);
	}

	// Token: 0x06004BC5 RID: 19397 RVA: 0x0019B472 File Offset: 0x00199672
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x040037DF RID: 14303
	protected ActivityBlackCoastData ActivityBaseData;

	// Token: 0x040037E0 RID: 14304
	private PopupCaptionItem CaptionItem;

	// Token: 0x040037E1 RID: 14305
	private GenericLayout<PageDot<int>, int> PageDotLayout;

	// Token: 0x040037E2 RID: 14306
	private GenericLayout<BlackCoastTaskItem, BlackCoastTaskData> TaskScroll;

	// Token: 0x040037E3 RID: 14307
	private List<int> StageIdList = new List<int>();

	// Token: 0x040037E4 RID: 14308
	private int CurrentSelectedIndex;

	// Token: 0x040037E5 RID: 14309
	private MediaPlayer MediaPlayer;

	// Token: 0x040037E6 RID: 14310
	private int HandleId = -1;

	// Token: 0x0200691E RID: 26910
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022A07 RID: 141831
		public const int Caption = 0;

		// Token: 0x04022A08 RID: 141832
		public const int PanelBg = 1;

		// Token: 0x04022A09 RID: 141833
		public const int DotLayout = 2;

		// Token: 0x04022A0A RID: 141834
		public const int Dot = 3;

		// Token: 0x04022A0B RID: 141835
		public const int TaskLayout = 4;

		// Token: 0x04022A0C RID: 141836
		public const int TaskItem = 5;

		// Token: 0x04022A0D RID: 141837
		public const int ButtonPre = 6;

		// Token: 0x04022A0E RID: 141838
		public const int ButtonNext = 7;

		// Token: 0x04022A0F RID: 141839
		public const int TextProgress = 8;

		// Token: 0x04022A10 RID: 141840
		public const int CG = 9;

		// Token: 0x04022A11 RID: 141841
		public const int TextName = 10;

		// Token: 0x04022A12 RID: 141842
		public const int TextureIcon = 11;
	}
}
