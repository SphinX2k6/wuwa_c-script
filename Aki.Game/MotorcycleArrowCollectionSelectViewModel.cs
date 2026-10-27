using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

// Token: 0x02001CD7 RID: 7383
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionSelectViewModel
{
	// Token: 0x0600DF93 RID: 57235 RVA: 0x00345D7D File Offset: 0x00343F7D
	public static MotorcycleArrowCollectionSelectViewModel Create(MotorcycleArrowSubModel model)
	{
		return new MotorcycleArrowCollectionSelectViewModel
		{
			Model = model
		};
	}

	// Token: 0x0600DF94 RID: 57236 RVA: 0x00345D8B File Offset: 0x00343F8B
	private MotorcycleArrowCollectionSelectViewModel()
	{
	}

	// Token: 0x0600DF95 RID: 57237 RVA: 0x00345DBF File Offset: 0x00343FBF
	public void PushPendingData(MotorFightBossDropNotify data)
	{
		this.PendingData.Add(data);
	}

	// Token: 0x0600DF96 RID: 57238 RVA: 0x00345DD0 File Offset: 0x00343FD0
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

	// Token: 0x0600DF97 RID: 57239 RVA: 0x00345E2C File Offset: 0x0034402C
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

	// Token: 0x0600DF98 RID: 57240 RVA: 0x00345EC8 File Offset: 0x003440C8
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

	// Token: 0x0600DF99 RID: 57241 RVA: 0x00345F26 File Offset: 0x00344126
	[NullableContext(2)]
	public void SetSelectCollectionItem(MotorcycleArrowCollectionItemData collectionItem)
	{
		this.CurSelectCollectionItem = collectionItem;
	}

	// Token: 0x0600DF9A RID: 57242 RVA: 0x00345F2F File Offset: 0x0034412F
	public void SetMaxRefreshCount(int count)
	{
		this.MaxRefreshCount = count;
	}

	// Token: 0x0600DF9B RID: 57243 RVA: 0x00345F38 File Offset: 0x00344138
	public void SetRemainRefreshCount(int count)
	{
		this.RemainRefreshCount = count;
	}

	// Token: 0x0600DF9C RID: 57244 RVA: 0x00345F41 File Offset: 0x00344141
	public void OnOpenView()
	{
		this.ShowingViewProcess = true;
	}

	// Token: 0x0600DF9D RID: 57245 RVA: 0x00345F4C File Offset: 0x0034414C
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

	// Token: 0x0600DF9E RID: 57246 RVA: 0x00345FA0 File Offset: 0x003441A0
	public void ViewProcessFinish()
	{
		this.ShowingViewProcess = false;
	}

	// Token: 0x17001208 RID: 4616
	// (get) Token: 0x0600DF9F RID: 57247 RVA: 0x00345FA9 File Offset: 0x003441A9
	public MotorcycleArrowSubController Controller
	{
		get
		{
			return (MotorcycleArrowSubController)KuroSimpleCombatController.Instance.CurSubController;
		}
	}

	// Token: 0x0600DFA0 RID: 57248 RVA: 0x00345FBC File Offset: 0x003441BC
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

	// Token: 0x0600DFA1 RID: 57249 RVA: 0x00346000 File Offset: 0x00344200
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

	// Token: 0x0600DFA2 RID: 57250 RVA: 0x00346044 File Offset: 0x00344244
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

	// Token: 0x0600DFA3 RID: 57251 RVA: 0x00346120 File Offset: 0x00344320
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

	// Token: 0x0600DFA4 RID: 57252 RVA: 0x00346190 File Offset: 0x00344390
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

	// Token: 0x0600DFA5 RID: 57253 RVA: 0x003461DA File Offset: 0x003443DA
	public List<MotorcycleArrowCollectionItemData> GetAllMotorFightItemData()
	{
		return new List<MotorcycleArrowCollectionItemData>(this.ItemDataMap.Values);
	}

	// Token: 0x0600DFA6 RID: 57254 RVA: 0x003461EC File Offset: 0x003443EC
	public bool IsMotorFightItemEmpty()
	{
		return this.ItemDataMap.Count <= 0;
	}

	// Token: 0x0600DFA7 RID: 57255 RVA: 0x003461FF File Offset: 0x003443FF
	public void Clear()
	{
		this.ItemDataMap.Clear();
		this.TypeToItemDataMap.Clear();
		this.PendingData.Clear();
	}

	// Token: 0x040066E0 RID: 26336
	public MotorcycleArrowSubModel Model;

	// Token: 0x040066E1 RID: 26337
	public readonly List<MotorcycleArrowCollectionItemData> CollectionList = new List<MotorcycleArrowCollectionItemData>();

	// Token: 0x040066E2 RID: 26338
	[Nullable(2)]
	public MotorcycleArrowCollectionItemData CurSelectCollectionItem;

	// Token: 0x040066E3 RID: 26339
	public int SubLevelIndex;

	// Token: 0x040066E4 RID: 26340
	public int WaveGroupIndex;

	// Token: 0x040066E5 RID: 26341
	public int BossId;

	// Token: 0x040066E6 RID: 26342
	public int MaxRefreshCount;

	// Token: 0x040066E7 RID: 26343
	public int RemainRefreshCount;

	// Token: 0x040066E8 RID: 26344
	public bool ShowingViewProcess;

	// Token: 0x040066E9 RID: 26345
	public List<MotorFightBossDropNotify> PendingData = new List<MotorFightBossDropNotify>();

	// Token: 0x040066EA RID: 26346
	private readonly Dictionary<int, MotorcycleArrowCollectionItemData> ItemDataMap = new Dictionary<int, MotorcycleArrowCollectionItemData>();

	// Token: 0x040066EB RID: 26347
	private readonly Dictionary<int, MotorcycleArrowCollectionTypeItemData> TypeToItemDataMap = new Dictionary<int, MotorcycleArrowCollectionTypeItemData>();
}
