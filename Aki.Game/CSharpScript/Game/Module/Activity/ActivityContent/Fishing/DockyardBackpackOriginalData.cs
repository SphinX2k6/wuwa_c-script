using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200550B RID: 21771
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackOriginalData
	{
		// Token: 0x06035F5F RID: 221023 RVA: 0x00F11D4C File Offset: 0x00F0FF4C
		private void PrintPosDataLog()
		{
			if (DockyardModel.Instance.IsPrintLog)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ItemDataMap.Values)
				{
					stringBuilder.Append(dockyardItemBlockOriginalData.IncId);
					stringBuilder.Append(':');
					stringBuilder.Append(dockyardItemBlockOriginalData.ItemId);
					stringBuilder.Append(',');
				}
				foreach (List<int> list in this.PosDataDoublyList)
				{
					stringBuilder.Append('\n');
					foreach (int num in list)
					{
						stringBuilder.Append(num.ToString().PadLeft(4, ' '));
						stringBuilder.Append(',');
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Dockyard;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "捕鱼背包数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("道具以及格子数据", stringBuilder.ToString());
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06035F60 RID: 221024 RVA: 0x00F11EA8 File Offset: 0x00F100A8
		public void RefreshPosData()
		{
			this.PosDataDoublyList.Clear();
			int fishingCabinShape = DockyardModel.Instance.FishingCabinShape;
			FishingGridItemShape fishingShapeConfig = FishingConfig.Instance.GetFishingShapeConfig(fishingCabinShape);
			for (int i = 0; i < 7; i++)
			{
				this.PosDataDoublyList.Add(new List<int>());
				for (int j = 0; j < 8; j++)
				{
					int[] arrayIntArray = fishingShapeConfig.FillState()[i].GetArrayIntArray();
					if (j >= arrayIntArray.Length || arrayIntArray[j] == 0)
					{
						this.PosDataDoublyList[i].Add(-1);
					}
					else
					{
						this.PosDataDoublyList[i].Add(0);
					}
				}
			}
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ItemDataMap.Values)
			{
				List<List<int>> list = DockyardPanelUtil.RotateOriginalPosData(dockyardItemBlockOriginalData.PosDoublyList, dockyardItemBlockOriginalData.Rotate);
				int num = 0;
				int count = list.Count;
				int num2 = 0;
				int count2 = list[0].Count;
				for (int k = num; k < count; k++)
				{
					for (int l = num2; l < count2; l++)
					{
						if (list[k][l] == 1)
						{
							int index = k + dockyardItemBlockOriginalData.GetServerData().Pos.Y;
							int index2 = l + dockyardItemBlockOriginalData.GetServerData().Pos.X;
							this.PosDataDoublyList[index][index2] = dockyardItemBlockOriginalData.IncId;
						}
					}
				}
			}
			EventSystem.Instance.Emit(EEventName.FishingRefreshBackpackData);
			this.PrintPosDataLog();
		}

		// Token: 0x06035F61 RID: 221025 RVA: 0x00F1205C File Offset: 0x00F1025C
		public void SetQuicklySellData(int shapeId, int ratio)
		{
			this.QuicklySellDataId = shapeId;
			this.QuicklySellRatio = ratio;
		}

		// Token: 0x06035F62 RID: 221026 RVA: 0x00F1206C File Offset: 0x00F1026C
		public void SetBackpackDataListFromServer(IEnumerable<FishingItemInfo> dataList)
		{
			this.ItemDataMap.Clear();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.ItemDataMap.Add(fishingItemInfo.IncrId, value);
			}
		}

		// Token: 0x06035F63 RID: 221027 RVA: 0x00F120D4 File Offset: 0x00F102D4
		public List<DockyardItemBlockOriginalData> GetBackpackItemList()
		{
			return new List<DockyardItemBlockOriginalData>(this.ItemDataMap.Values);
		}

		// Token: 0x06035F64 RID: 221028 RVA: 0x00F120E6 File Offset: 0x00F102E6
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetBackpackItemData(int uniqueId)
		{
			return this.ItemDataMap.GetValueOrDefault(uniqueId);
		}

		// Token: 0x170068B3 RID: 26803
		// (get) Token: 0x06035F65 RID: 221029 RVA: 0x00F120F4 File Offset: 0x00F102F4
		public int BackpackUseSize
		{
			get
			{
				int num = 0;
				foreach (List<int> list in this.PosDataDoublyList)
				{
					using (List<int>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current > 0)
							{
								num++;
							}
						}
					}
				}
				return num;
			}
		}

		// Token: 0x170068B4 RID: 26804
		// (get) Token: 0x06035F66 RID: 221030 RVA: 0x00F12180 File Offset: 0x00F10380
		public int BackpackSize
		{
			get
			{
				int num = 0;
				foreach (List<int> list in this.PosDataDoublyList)
				{
					using (List<int>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current > -1)
							{
								num++;
							}
						}
					}
				}
				return num;
			}
		}

		// Token: 0x06035F67 RID: 221031 RVA: 0x00F1220C File Offset: 0x00F1040C
		public int GetItemCountByItemId(int itemId)
		{
			int num = 0;
			using (Dictionary<int, DockyardItemBlockOriginalData>.ValueCollection.Enumerator enumerator = this.ItemDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ItemId == itemId)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06035F68 RID: 221032 RVA: 0x00F1226C File Offset: 0x00F1046C
		public List<DockyardItemBlockOriginalData> GetItemListByItemId(int itemId)
		{
			List<DockyardItemBlockOriginalData> list = new List<DockyardItemBlockOriginalData>();
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ItemDataMap.Values)
			{
				if (dockyardItemBlockOriginalData.ItemId == itemId)
				{
					list.Add(dockyardItemBlockOriginalData);
				}
			}
			return list;
		}

		// Token: 0x0401C840 RID: 116800
		private readonly Dictionary<int, DockyardItemBlockOriginalData> ItemDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x0401C841 RID: 116801
		public readonly List<List<int>> PosDataDoublyList = new List<List<int>>();

		// Token: 0x0401C842 RID: 116802
		public int QuicklySellDataId;

		// Token: 0x0401C843 RID: 116803
		public int QuicklySellRatio;
	}
}
