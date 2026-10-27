using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006598 RID: 26008
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardItemBlockOriginalData
	{
		// Token: 0x1700955C RID: 38236
		// (get) Token: 0x06041347 RID: 267079 RVA: 0x00FCD7AA File Offset: 0x00FCB9AA
		public int IncId
		{
			get
			{
				return this.ServerData.IncrId;
			}
		}

		// Token: 0x1700955D RID: 38237
		// (get) Token: 0x06041348 RID: 267080 RVA: 0x00FCD7B7 File Offset: 0x00FCB9B7
		public int ItemId
		{
			get
			{
				return this.ServerData.ItemId;
			}
		}

		// Token: 0x1700955E RID: 38238
		// (get) Token: 0x06041349 RID: 267081 RVA: 0x00FCD7C4 File Offset: 0x00FCB9C4
		public int Quality
		{
			get
			{
				return this.ServerData.Quality;
			}
		}

		// Token: 0x1700955F RID: 38239
		// (get) Token: 0x0604134A RID: 267082 RVA: 0x00FCD7D1 File Offset: 0x00FCB9D1
		public int Size
		{
			get
			{
				return this.ServerData.Size;
			}
		}

		// Token: 0x17009560 RID: 38240
		// (get) Token: 0x0604134B RID: 267083 RVA: 0x00FCD7DE File Offset: 0x00FCB9DE
		public int Price
		{
			get
			{
				return this.ServerData.Price;
			}
		}

		// Token: 0x17009561 RID: 38241
		// (get) Token: 0x0604134C RID: 267084 RVA: 0x00FCD7EB File Offset: 0x00FCB9EB
		public int Cup
		{
			get
			{
				return (int)this.ServerData.Cup;
			}
		}

		// Token: 0x17009562 RID: 38242
		// (get) Token: 0x0604134D RID: 267085 RVA: 0x00FCD7F8 File Offset: 0x00FCB9F8
		public FishingItemRotate Rotate
		{
			get
			{
				return this.ServerData.Rotate;
			}
		}

		// Token: 0x17009563 RID: 38243
		// (get) Token: 0x0604134E RID: 267086 RVA: 0x00FCD805 File Offset: 0x00FCBA05
		public int PosX
		{
			get
			{
				return this.ServerData.Pos.X;
			}
		}

		// Token: 0x17009564 RID: 38244
		// (get) Token: 0x0604134F RID: 267087 RVA: 0x00FCD817 File Offset: 0x00FCBA17
		public int PosY
		{
			get
			{
				return this.ServerData.Pos.Y;
			}
		}

		// Token: 0x17009565 RID: 38245
		// (get) Token: 0x06041350 RID: 267088 RVA: 0x00FCD829 File Offset: 0x00FCBA29
		public bool IsCanSell
		{
			get
			{
				return this.ServerData.Price > 0;
			}
		}

		// Token: 0x06041351 RID: 267089 RVA: 0x00FCD83C File Offset: 0x00FCBA3C
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

		// Token: 0x06041352 RID: 267090 RVA: 0x00FCDA3D File Offset: 0x00FCBC3D
		public FishingItemInfo GetServerData()
		{
			return this.ServerData;
		}

		// Token: 0x04021F40 RID: 139072
		private readonly FishingItemInfo ServerData;

		// Token: 0x04021F41 RID: 139073
		public List<List<int>> PosDoublyList = new List<List<int>>();

		// Token: 0x04021F42 RID: 139074
		public List<List<int>> ValidDoublyList = new List<List<int>>();

		// Token: 0x04021F43 RID: 139075
		public readonly List<IPanelPos> PosDataList = new List<IPanelPos>();

		// Token: 0x04021F44 RID: 139076
		public IPanelPos ValidStartPos = new PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};
	}
}
