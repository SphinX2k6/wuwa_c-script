using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EFC RID: 7932
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuestItem : UiPanelBase, IGridProxy<EHonamiStoryQuestType>
{
	// Token: 0x0600F42B RID: 62507 RVA: 0x003AE7D8 File Offset: 0x003AC9D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F42C RID: 62508 RVA: 0x003AE8E6 File Offset: 0x003ACAE6
	protected override void OnStart()
	{
		this.TaskLayout = new GenericLayout<HonamiStoryQuestItemChildItem, HonamiStoryQuestDataBase>(base.GetVerticalLayout(1), new Func<HonamiStoryQuestItemChildItem>(this.InitQuestChildItem), null, false, true);
	}

	// Token: 0x0600F42D RID: 62509 RVA: 0x003AE90C File Offset: 0x003ACB0C
	private HonamiStoryQuestItemChildItem InitQuestChildItem()
	{
		HonamiStoryQuestItemChildItem honamiStoryQuestItemChildItem = new HonamiStoryQuestItemChildItem();
		if (this.OnClickTask != null)
		{
			honamiStoryQuestItemChildItem.BindOnClickTask(this.OnClickTask);
		}
		else
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "HonamiStoryQuestItem do not have callback", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.TaskChildItemList.Add(honamiStoryQuestItemChildItem);
		return honamiStoryQuestItemChildItem;
	}

	// Token: 0x1700130D RID: 4877
	// (get) Token: 0x0600F42E RID: 62510 RVA: 0x003AE961 File Offset: 0x003ACB61
	// (set) Token: 0x0600F42F RID: 62511 RVA: 0x003AE969 File Offset: 0x003ACB69
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<EHonamiStoryQuestType>, EHonamiStoryQuestType> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x1700130E RID: 4878
	// (get) Token: 0x0600F430 RID: 62512 RVA: 0x003AE972 File Offset: 0x003ACB72
	// (set) Token: 0x0600F431 RID: 62513 RVA: 0x003AE97A File Offset: 0x003ACB7A
	public int GridIndex { get; set; }

	// Token: 0x1700130F RID: 4879
	// (get) Token: 0x0600F432 RID: 62514 RVA: 0x003AE983 File Offset: 0x003ACB83
	// (set) Token: 0x0600F433 RID: 62515 RVA: 0x003AE98B File Offset: 0x003ACB8B
	public int DisplayIndex { get; set; }

	// Token: 0x0600F434 RID: 62516 RVA: 0x003AE994 File Offset: 0x003ACB94
	public UniTask RefreshAsync(EHonamiStoryQuestType data, bool isSelected, int gridIndex)
	{
		HonamiStoryQuestItem.<RefreshAsync>d__21 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<HonamiStoryQuestItem.<RefreshAsync>d__21>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F435 RID: 62517 RVA: 0x003AE9DF File Offset: 0x003ACBDF
	public void BindOnClickTask(Action<HonamiStoryQuestItemChildItem> callback)
	{
		this.OnClickTask = callback;
	}

	// Token: 0x0600F436 RID: 62518 RVA: 0x003AE9E8 File Offset: 0x003ACBE8
	private void RefreshItem()
	{
		if (this.TaskType == EHonamiStoryQuestType.Main)
		{
			base.GetText(2).ShowTextNew("HonamiStory_MainMission");
			return;
		}
		base.GetText(2).ShowTextNew("HonamiStory_SideMission");
	}

	// Token: 0x0600F437 RID: 62519 RVA: 0x003AEA16 File Offset: 0x003ACC16
	public IReadOnlyList<HonamiStoryQuestItemChildItem> GetTaskChildItemList()
	{
		return this.TaskChildItemList;
	}

	// Token: 0x0600F438 RID: 62520 RVA: 0x003AEA1E File Offset: 0x003ACC1E
	public void Clear()
	{
	}

	// Token: 0x0600F439 RID: 62521 RVA: 0x003AEA20 File Offset: 0x003ACC20
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600F43A RID: 62522 RVA: 0x003AEA22 File Offset: 0x003ACC22
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600F43B RID: 62523 RVA: 0x003AEA24 File Offset: 0x003ACC24
	public object GetKey(EHonamiStoryQuestType data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x04007105 RID: 28933
	private EHonamiStoryQuestType TaskType = EHonamiStoryQuestType.Main;

	// Token: 0x04007106 RID: 28934
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryQuestItemChildItem, HonamiStoryQuestDataBase> TaskLayout;

	// Token: 0x04007107 RID: 28935
	private readonly List<HonamiStoryQuestItemChildItem> TaskChildItemList = new List<HonamiStoryQuestItemChildItem>();

	// Token: 0x04007108 RID: 28936
	private int ScrollToHandle = -1;

	// Token: 0x04007109 RID: 28937
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<HonamiStoryQuestItemChildItem> OnClickTask;

	// Token: 0x020084FB RID: 34043
	[NullableContext(0)]
	private enum EHonamiStoryQuestItemComponent
	{
		// Token: 0x0402B464 RID: 177252
		RootItem,
		// Token: 0x0402B465 RID: 177253
		TaskLayout,
		// Token: 0x0402B466 RID: 177254
		TitleText,
		// Token: 0x0402B467 RID: 177255
		TitleSprite,
		// Token: 0x0402B468 RID: 177256
		TitleItem,
		// Token: 0x0402B469 RID: 177257
		TaskItem,
		// Token: 0x0402B46A RID: 177258
		TitleBgItem
	}
}
