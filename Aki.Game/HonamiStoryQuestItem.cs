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

// Token: 0x020013BE RID: 5054
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryQuestItem : UiPanelBase, IGridProxy<EHonamiStoryQuestType>
{
	// Token: 0x0600C84A RID: 51274 RVA: 0x003BA2CC File Offset: 0x003B84CC
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

	// Token: 0x0600C84B RID: 51275 RVA: 0x003BA3DA File Offset: 0x003B85DA
	protected override void OnStart()
	{
		this.TaskLayout = new GenericLayout<HonamiStoryQuestItemChildItem, HonamiStoryQuestDataBase>(base.GetVerticalLayout(1), new Func<HonamiStoryQuestItemChildItem>(this.InitQuestChildItem), null, false, true);
	}

	// Token: 0x0600C84C RID: 51276 RVA: 0x003BA400 File Offset: 0x003B8600
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

	// Token: 0x17001337 RID: 4919
	// (get) Token: 0x0600C84D RID: 51277 RVA: 0x003BA455 File Offset: 0x003B8655
	// (set) Token: 0x0600C84E RID: 51278 RVA: 0x003BA45D File Offset: 0x003B865D
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

	// Token: 0x17001338 RID: 4920
	// (get) Token: 0x0600C84F RID: 51279 RVA: 0x003BA466 File Offset: 0x003B8666
	// (set) Token: 0x0600C850 RID: 51280 RVA: 0x003BA46E File Offset: 0x003B866E
	public int GridIndex { get; set; }

	// Token: 0x17001339 RID: 4921
	// (get) Token: 0x0600C851 RID: 51281 RVA: 0x003BA477 File Offset: 0x003B8677
	// (set) Token: 0x0600C852 RID: 51282 RVA: 0x003BA47F File Offset: 0x003B867F
	public int DisplayIndex { get; set; }

	// Token: 0x0600C853 RID: 51283 RVA: 0x003BA488 File Offset: 0x003B8688
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

	// Token: 0x0600C854 RID: 51284 RVA: 0x003BA4D3 File Offset: 0x003B86D3
	public void BindOnClickTask(Action<HonamiStoryQuestItemChildItem> callback)
	{
		this.OnClickTask = callback;
	}

	// Token: 0x0600C855 RID: 51285 RVA: 0x003BA4DC File Offset: 0x003B86DC
	private void RefreshItem()
	{
		if (this.TaskType == EHonamiStoryQuestType.Main)
		{
			base.GetText(2).ShowTextNew("HonamiStory_MainMission");
			return;
		}
		base.GetText(2).ShowTextNew("HonamiStory_SideMission");
	}

	// Token: 0x0600C856 RID: 51286 RVA: 0x003BA50A File Offset: 0x003B870A
	public IReadOnlyList<HonamiStoryQuestItemChildItem> GetTaskChildItemList()
	{
		return this.TaskChildItemList;
	}

	// Token: 0x0600C857 RID: 51287 RVA: 0x003BA512 File Offset: 0x003B8712
	public void Clear()
	{
	}

	// Token: 0x0600C858 RID: 51288 RVA: 0x003BA514 File Offset: 0x003B8714
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C859 RID: 51289 RVA: 0x003BA516 File Offset: 0x003B8716
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C85A RID: 51290 RVA: 0x003BA518 File Offset: 0x003B8718
	public object GetKey(EHonamiStoryQuestType data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x040071E6 RID: 29158
	private EHonamiStoryQuestType TaskType = EHonamiStoryQuestType.Main;

	// Token: 0x040071E7 RID: 29159
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryQuestItemChildItem, HonamiStoryQuestDataBase> TaskLayout;

	// Token: 0x040071E8 RID: 29160
	private readonly List<HonamiStoryQuestItemChildItem> TaskChildItemList = new List<HonamiStoryQuestItemChildItem>();

	// Token: 0x040071E9 RID: 29161
	private int ScrollToHandle = -1;

	// Token: 0x040071EA RID: 29162
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<HonamiStoryQuestItemChildItem> OnClickTask;

	// Token: 0x02007680 RID: 30336
	[NullableContext(0)]
	private enum EHonamiStoryQuestItemComponent
	{
		// Token: 0x04026788 RID: 157576
		RootItem,
		// Token: 0x04026789 RID: 157577
		TaskLayout,
		// Token: 0x0402678A RID: 157578
		TitleText,
		// Token: 0x0402678B RID: 157579
		TitleSprite,
		// Token: 0x0402678C RID: 157580
		TitleItem,
		// Token: 0x0402678D RID: 157581
		TaskItem,
		// Token: 0x0402678E RID: 157582
		TitleBgItem
	}
}
