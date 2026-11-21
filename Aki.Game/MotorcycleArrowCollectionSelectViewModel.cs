using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

// Token: 0x02001199 RID: 4505
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionSelectViewModel
{
	// Token: 0x0600B3B0 RID: 46000 RVA: 0x003517A5 File Offset: 0x0034F9A5
	public static MotorcycleArrowCollectionSelectViewModel Create(MotorcycleArrowSubModel model)
	{
		return new MotorcycleArrowCollectionSelectViewModel
		{
			Model = model
		};
	}

	// Token: 0x0600B3B1 RID: 46001 RVA: 0x003517B3 File Offset: 0x0034F9B3
	private MotorcycleArrowCollectionSelectViewModel()
	{
	}

	// Token: 0x0600B3B2 RID: 46002 RVA: 0x003517E7 File Offset: 0x0034F9E7
	public void PushPendingData(MotorFightBossDropNotify data)
	{
		this.PendingData.Add(data);
	}

	// Token: 0x0600B3B3 RID: 46003 RVA: 0x003517F8 File Offset: 0x0034F9F8
	public bool SetCollectionList(MotorFightBossDropNotify dropData)
	{
		this.SubLevelIndex = dropData.SubLevelIndex;
		this.WaveGroupIndex = dropData.WaveGroupIndex;
		this.BossId = dropData.BossId;
		this.UpdateDrop(dropData.Drops);
		this.SetSelectCollectionId(null);
		this.RemainRefreshCount = this.MaxRefreshCount;
		return true;
	}

	// Token: 0x0600B3B4 RID: 46004 RVA: 0x00351854 File Offset: 0x0034FA54
	public void UpdateDrop(RepeatedField<MotorFightCollectionDrop> drops)
	{
		this.CollectionList.Clear();
		for (int i = 0; i < drops.Count; i++)
		{
			MotorFightCollectionDrop motorFightCollectionDrop = drops[i];
			MotorFightItem? config = ConfigMotorFightItemById.GetConfig(motorFightCollectionDrop.CollectionId, true);
			if (config != null)
			{
				MotorcycleArrowCollectionItemData item = MotorcycleArrowCollectionItemData.Create(config.Value, (int)motorFightCollectionDrop.Pos);
				this.CollectionList.Add(item);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiModel;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "[摩托战斗]不存在的藏品配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", motorFightCollectionDrop.CollectionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0600B3B5 RID: 46005 RVA: 0x003518F0 File Offset: 0x0034FAF0
	public void SetSelectCollectionId(int? id)
	{
		MotorcycleArrowCollectionItemData selectCollectionItem = null;
		if (id != null)
		{
			for (int i = 0; i < this.CollectionList.Count; i++)
			{
				if (this.CollectionList[i].Id == id.Value)
				{
					selectCollectionItem = this.CollectionList[i];
					break;
				}
			}
		}
		this.SetSelectCollectionItem(selectCollectionItem);
	}

	// Token: 0x0600B3B6 RID: 46006 RVA: 0x0035194E File Offset: 0x0034FB4E
	[NullableContext(2)]
	public void SetSelectCollectionItem(MotorcycleArrowCollectionItemData collectionItem)
	{
		this.CurSelectCollectionItem = collectionItem;
	}

	// Token: 0x0600B3B7 RID: 46007 RVA: 0x00351957 File Offset: 0x0034FB57
	public void SetMaxRefreshCount(int count)
	{
		this.MaxRefreshCount = count;
	}

	// Token: 0x0600B3B8 RID: 46008 RVA: 0x00351960 File Offset: 0x0034FB60
	public void SetRemainRefreshCount(int count)
	{
		this.RemainRefreshCount = count;
	}

	// Token: 0x0600B3B9 RID: 46009 RVA: 0x00351969 File Offset: 0x0034FB69
	public void OnOpenView()
	{
		this.ShowingViewProcess = true;
	}

	// Token: 0x0600B3BA RID: 46010 RVA: 0x00351974 File Offset: 0x0034FB74
	public void OnViewClose()
	{
		this.ShowingViewProcess = false;
		if (this.PendingData.Count > 0)
		{
			MotorFightBossDropNotify collectionList = this.PendingData[0];
			this.PendingData.RemoveAt(0);
			this.SetCollectionList(collectionList);
			UiManager.Instance.OpenView(EUiViewName.MotorcycleArrowCollectionSelectView, this, null);
		}
	}

	// Token: 0x0600B3BB RID: 46011 RVA: 0x003519C8 File Offset: 0x0034FBC8
	public void ViewProcessFinish()
	{
		this.ShowingViewProcess = false;
	}

	// Token: 0x17001232 RID: 4658
	// (get) Token: 0x0600B3BC RID: 46012 RVA: 0x003519D1 File Offset: 0x0034FBD1
	public MotorcycleArrowSubController Controller
	{
		get
		{
			return (MotorcycleArrowSubController)KuroSimpleCombatController.Instance.CurSubController;
		}
	}

	// Token: 0x0600B3BD RID: 46013 RVA: 0x003519E4 File Offset: 0x0034FBE4
	[NullableContext(0)]
	public UniTask<bool> RequestCollectionSelect()
	{
		MotorcycleArrowCollectionSelectViewModel.<RequestCollectionSelect>d__24 <RequestCollectionSelect>d__;
		<RequestCollectionSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestCollectionSelect>d__.<>4__this = this;
		<RequestCollectionSelect>d__.<>1__state = -1;
		<RequestCollectionSelect>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectViewModel.<RequestCollectionSelect>d__24>(ref <RequestCollectionSelect>d__);
		return <RequestCollectionSelect>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3BE RID: 46014 RVA: 0x00351A28 File Offset: 0x0034FC28
	[NullableContext(0)]
	public UniTask<bool> RequestUpdateCollectionList()
	{
		MotorcycleArrowCollectionSelectViewModel.<RequestUpdateCollectionList>d__25 <RequestUpdateCollectionList>d__;
		<RequestUpdateCollectionList>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestUpdateCollectionList>d__.<>4__this = this;
		<RequestUpdateCollectionList>d__.<>1__state = -1;
		<RequestUpdateCollectionList>d__.<>t__builder.Start<MotorcycleArrowCollectionSelectViewModel.<RequestUpdateCollectionList>d__25>(ref <RequestUpdateCollectionList>d__);
		return <RequestUpdateCollectionList>d__.<>t__builder.Task;
	}

	// Token: 0x0600B3BF RID: 46015 RVA: 0x00351A6C File Offset: 0x0034FC6C
	public void AddItemData(int itemId)
	{
		MotorFightItem? config = ConfigMotorFightItemById.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiModel;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "[摩托战斗]不存在的藏品配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		MotorFightItem value = config.Value;
		MotorcycleArrowCollectionItemData itemData;
		if (this.ItemDataMap.TryGetValue(value.Id, out itemData))
		{
			this.TypeToItemDataMap[value.Type].AddItemData(itemData, false);
			return;
		}
		MotorcycleArrowCollectionItemData motorcycleArrowCollectionItemData = MotorcycleArrowCollectionItemData.Create(value, 0);
		this.ItemDataMap[value.Id] = motorcycleArrowCollectionItemData;
		int type = value.Type;
		MotorcycleArrowCollectionTypeItemData motorcycleArrowCollectionTypeItemData;
		if (!this.TypeToItemDataMap.TryGetValue(type, out motorcycleArrowCollectionTypeItemData))
		{
			motorcycleArrowCollectionTypeItemData = new MotorcycleArrowCollectionTypeItemData(type);
			this.TypeToItemDataMap[type] = motorcycleArrowCollectionTypeItemData;
		}
		motorcycleArrowCollectionTypeItemData.AddItemData(motorcycleArrowCollectionItemData, true);
	}

	// Token: 0x0600B3C0 RID: 46016 RVA: 0x00351B48 File Offset: 0x0034FD48
	public List<int> GetSortedMotorFightItemTypeList()
	{
		List<MotorcycleArrowCollectionTypeItemData> list = new List<MotorcycleArrowCollectionTypeItemData>(this.TypeToItemDataMap.Values);
		list.Sort(delegate(MotorcycleArrowCollectionTypeItemData a, MotorcycleArrowCollectionTypeItemData b)
		{
			if (a.TotalCount != b.TotalCount)
			{
				return b.TotalCount - a.TotalCount;
			}
			for (int j = 5; j >= 1; j--)
			{
				int itemNumWithQuality = a.GetItemNumWithQuality(j);
				int itemNumWithQuality2 = b.GetItemNumWithQuality(j);
				if (itemNumWithQuality != itemNumWithQuality2)
				{
					return itemNumWithQuality2 - itemNumWithQuality;
				}
			}
			return 0;
		});
		List<int> list2 = new List<int>();
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(list[i].Type);
		}
		return list2;
	}

	// Token: 0x0600B3C1 RID: 46017 RVA: 0x00351BB8 File Offset: 0x0034FDB8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MotorcycleArrowCollectionItemData> GetMotorFightItemDataListByType(int type)
	{
		MotorcycleArrowCollectionTypeItemData motorcycleArrowCollectionTypeItemData;
		if (!this.TypeToItemDataMap.TryGetValue(type, out motorcycleArrowCollectionTypeItemData))
		{
			return null;
		}
		List<MotorcycleArrowCollectionItemData> itemList = motorcycleArrowCollectionTypeItemData.ItemList;
		itemList.Sort(delegate(MotorcycleArrowCollectionItemData a, MotorcycleArrowCollectionItemData b)
		{
			if (a.Config.Quality != b.Config.Quality)
			{
				return b.Config.Quality - a.Config.Quality;
			}
			if (a.Num != b.Num)
			{
				return b.Num - a.Num;
			}
			return b.Id - a.Id;
		});
		return itemList;
	}

	// Token: 0x0600B3C2 RID: 46018 RVA: 0x00351C02 File Offset: 0x0034FE02
	public List<MotorcycleArrowCollectionItemData> GetAllMotorFightItemData()
	{
		return new List<MotorcycleArrowCollectionItemData>(this.ItemDataMap.Values);
	}

	// Token: 0x0600B3C3 RID: 46019 RVA: 0x00351C14 File Offset: 0x0034FE14
	public bool IsMotorFightItemEmpty()
	{
		return this.ItemDataMap.Count <= 0;
	}

	// Token: 0x0600B3C4 RID: 46020 RVA: 0x00351C27 File Offset: 0x0034FE27
	public void Clear()
	{
		this.ItemDataMap.Clear();
		this.TypeToItemDataMap.Clear();
		this.PendingData.Clear();
	}

	// Token: 0x040067BF RID: 26559
	public MotorcycleArrowSubModel Model;

	// Token: 0x040067C0 RID: 26560
	public readonly List<MotorcycleArrowCollectionItemData> CollectionList = new List<MotorcycleArrowCollectionItemData>();

	// Token: 0x040067C1 RID: 26561
	[Nullable(2)]
	public MotorcycleArrowCollectionItemData CurSelectCollectionItem;

	// Token: 0x040067C2 RID: 26562
	public int SubLevelIndex;

	// Token: 0x040067C3 RID: 26563
	public int WaveGroupIndex;

	// Token: 0x040067C4 RID: 26564
	public int BossId;

	// Token: 0x040067C5 RID: 26565
	public int MaxRefreshCount;

	// Token: 0x040067C6 RID: 26566
	public int RemainRefreshCount;

	// Token: 0x040067C7 RID: 26567
	public bool ShowingViewProcess;

	// Token: 0x040067C8 RID: 26568
	public List<MotorFightBossDropNotify> PendingData = new List<MotorFightBossDropNotify>();

	// Token: 0x040067C9 RID: 26569
	private readonly Dictionary<int, MotorcycleArrowCollectionItemData> ItemDataMap = new Dictionary<int, MotorcycleArrowCollectionItemData>();

	// Token: 0x040067CA RID: 26570
	private readonly Dictionary<int, MotorcycleArrowCollectionTypeItemData> TypeToItemDataMap = new Dictionary<int, MotorcycleArrowCollectionTypeItemData>();
}
