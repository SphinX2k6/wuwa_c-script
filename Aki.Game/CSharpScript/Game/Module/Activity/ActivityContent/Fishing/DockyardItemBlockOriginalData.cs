using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005516 RID: 21782
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemBlockOriginalData
	{
		// Token: 0x170068BE RID: 26814
		// (get) Token: 0x0603600C RID: 221196 RVA: 0x00F147BE File Offset: 0x00F129BE
		public int IncId
		{
			get
			{
				return this.ServerData.IncrId;
			}
		}

		// Token: 0x170068BF RID: 26815
		// (get) Token: 0x0603600D RID: 221197 RVA: 0x00F147CB File Offset: 0x00F129CB
		public int ItemId
		{
			get
			{
				return this.ServerData.ItemId;
			}
		}

		// Token: 0x170068C0 RID: 26816
		// (get) Token: 0x0603600E RID: 221198 RVA: 0x00F147D8 File Offset: 0x00F129D8
		public int Quality
		{
			get
			{
				return this.ServerData.Quality;
			}
		}

		// Token: 0x170068C1 RID: 26817
		// (get) Token: 0x0603600F RID: 221199 RVA: 0x00F147E5 File Offset: 0x00F129E5
		public int Size
		{
			get
			{
				return this.ServerData.Size;
			}
		}

		// Token: 0x170068C2 RID: 26818
		// (get) Token: 0x06036010 RID: 221200 RVA: 0x00F147F2 File Offset: 0x00F129F2
		public int Price
		{
			get
			{
				return this.ServerData.Price;
			}
		}

		// Token: 0x170068C3 RID: 26819
		// (get) Token: 0x06036011 RID: 221201 RVA: 0x00F147FF File Offset: 0x00F129FF
		public int Cup
		{
			get
			{
				return (int)this.ServerData.Cup;
			}
		}

		// Token: 0x170068C4 RID: 26820
		// (get) Token: 0x06036012 RID: 221202 RVA: 0x00F1480C File Offset: 0x00F12A0C
		public FishingItemRotate Rotate
		{
			get
			{
				return this.ServerData.Rotate;
			}
		}

		// Token: 0x170068C5 RID: 26821
		// (get) Token: 0x06036013 RID: 221203 RVA: 0x00F14819 File Offset: 0x00F12A19
		public int PosX
		{
			get
			{
				return this.ServerData.Pos.X;
			}
		}

		// Token: 0x170068C6 RID: 26822
		// (get) Token: 0x06036014 RID: 221204 RVA: 0x00F1482B File Offset: 0x00F12A2B
		public int PosY
		{
			get
			{
				return this.ServerData.Pos.Y;
			}
		}

		// Token: 0x170068C7 RID: 26823
		// (get) Token: 0x06036015 RID: 221205 RVA: 0x00F1483D File Offset: 0x00F12A3D
		public bool IsCanSell
		{
			get
			{
				return this.ServerData.Price > 0;
			}
		}

		// Token: 0x06036016 RID: 221206 RVA: 0x00F14850 File Offset: 0x00F12A50
		public DockyardItemBlockOriginalData(FishingItemInfo data)
		{
			this.ServerData = data;
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(this.ServerData.ItemId);
			IntArray[] array = FishingConfig.Instance.GetFishingShapeConfig(fishingItemConfig.Value.Shap).FillState();
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			int i = 0;
			int num5 = array.Length;
			while (i < num5)
			{
				this.PosDoublyList.Add(new List<int>());
				int j = 0;
				int arrayIntLength = array[i].ArrayIntLength;
				while (j < arrayIntLength)
				{
					int num6 = array[i].ArrayInt(j);
					this.PosDoublyList[i].Add(num6);
					this.PosDataList.Add(new PanelPos
					{
						RowIndex = i,
						ColIndex = j
					});
					if (num6 == 1)
					{
						num = ((num == -1) ? i : Math.Min(num, i));
						num2 = ((num2 == -1) ? i : Math.Max(num2, i));
						num3 = ((num3 == -1) ? j : Math.Min(num3, j));
						num4 = ((num4 == -1) ? j : Math.Max(num4, j));
					}
					j++;
				}
				i++;
			}
			this.ValidStartPos = new PanelPos
			{
				RowIndex = num,
				ColIndex = num3
			};
			for (int k = 0; k < num2 - num + 1; k++)
			{
				this.ValidDoublyList.Add(new List<int>());
				for (int l = 0; l < num4 - num3 + 1; l++)
				{
					this.ValidDoublyList[k].Add(this.PosDoublyList[k + num][l + num3]);
				}
			}
		}

		// Token: 0x06036017 RID: 221207 RVA: 0x00F14A51 File Offset: 0x00F12C51
		public FishingItemInfo GetServerData()
		{
			return this.ServerData;
		}

		// Token: 0x0401C871 RID: 116849
		private readonly FishingItemInfo ServerData;

		// Token: 0x0401C872 RID: 116850
		public List<List<int>> PosDoublyList = new List<List<int>>();

		// Token: 0x0401C873 RID: 116851
		public List<List<int>> ValidDoublyList = new List<List<int>>();

		// Token: 0x0401C874 RID: 116852
		public readonly List<IPanelPos> PosDataList = new List<IPanelPos>();

		// Token: 0x0401C875 RID: 116853
		public IPanelPos ValidStartPos = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};
	}
}
