using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200658D RID: 25997
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackOriginalData
	{
		// Token: 0x0604129A RID: 266906 RVA: 0x00FCAD9C File Offset: 0x00FC8F9C
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

		// Token: 0x0604129B RID: 266907 RVA: 0x00FCAEF8 File Offset: 0x00FC90F8
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

		// Token: 0x0604129C RID: 266908 RVA: 0x00FCB0AC File Offset: 0x00FC92AC
		public void SetQuicklySellData(int shapeId, int ratio)
		{
			this.QuicklySellDataId = shapeId;
			this.QuicklySellRatio = ratio;
		}

		// Token: 0x0604129D RID: 266909 RVA: 0x00FCB0BC File Offset: 0x00FC92BC
		public void SetBackpackDataListFromServer(List<FishingItemInfo> dataList)
		{
			this.ItemDataMap.Clear();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.ItemDataMap.Add(fishingItemInfo.IncrId, value);
			}
		}

		// Token: 0x0604129E RID: 266910 RVA: 0x00FCB128 File Offset: 0x00FC9328
		public List<DockyardItemBlockOriginalData> GetBackpackItemList()
		{
			return this.ItemDataMap.Values.ToList<DockyardItemBlockOriginalData>();
		}

		// Token: 0x0604129F RID: 266911 RVA: 0x00FCB13A File Offset: 0x00FC933A
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetBackpackItemData(int uniqueId)
		{
			return this.ItemDataMap.GetValueOrDefault(uniqueId);
		}

		// Token: 0x17009551 RID: 38225
		// (get) Token: 0x060412A0 RID: 266912 RVA: 0x00FCB148 File Offset: 0x00FC9348
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

		// Token: 0x17009552 RID: 38226
		// (get) Token: 0x060412A1 RID: 266913 RVA: 0x00FCB1D4 File Offset: 0x00FC93D4
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

		// Token: 0x060412A2 RID: 266914 RVA: 0x00FCB260 File Offset: 0x00FC9460
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

		// Token: 0x060412A3 RID: 266915 RVA: 0x00FCB2C0 File Offset: 0x00FC94C0
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

		// Token: 0x04021F0F RID: 139023
		private readonly Dictionary<int, DockyardItemBlockOriginalData> ItemDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x04021F10 RID: 139024
		public readonly List<List<int>> PosDataDoublyList = new List<List<int>>();

		// Token: 0x04021F11 RID: 139025
		public int QuicklySellDataId;

		// Token: 0x04021F12 RID: 139026
		public int QuicklySellRatio;
	}
}
