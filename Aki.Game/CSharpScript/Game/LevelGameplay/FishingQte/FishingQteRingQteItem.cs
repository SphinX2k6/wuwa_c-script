using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E46 RID: 28230
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingQteItem : UiPanelBase
	{
		// Token: 0x06044D02 RID: 281858 RVA: 0x010FB111 File Offset: 0x010F9311
		public FishingQteRingQteItem(FishingQteGameInfo GameInfo, FishingQteRingInfo RingInfo, [Nullable(2)] IFishingQteConfig RingConfig)
		{
			this.GameInfo = GameInfo;
			this.RingInfo = RingInfo;
			this.RingConfig = RingConfig;
		}

		// Token: 0x06044D03 RID: 281859 RVA: 0x010FB150 File Offset: 0x010F9350
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06044D04 RID: 281860 RVA: 0x010FB198 File Offset: 0x010F9398
		protected override void OnStart()
		{
			this.TextureRing = base.GetItem(0);
			this.TextureRing.SetUIActive(false);
		}

		// Token: 0x06044D05 RID: 281861 RVA: 0x010FB1B3 File Offset: 0x010F93B3
		protected override void OnBeforeDestroy()
		{
			this.TextureRing = null;
			this.QteAreaTextures.Clear();
			this.PerfectAreaTextures.Clear();
			this.CachedTexture.Clear();
		}

		// Token: 0x06044D06 RID: 281862 RVA: 0x010FB1E0 File Offset: 0x010F93E0
		private int GetAreaRandomSize(List<int> rangeConfig)
		{
			int result = 3;
			if (rangeConfig.Count == 2)
			{
				result = this.RandomRangeInt(rangeConfig[0], rangeConfig[1]);
			}
			return result;
		}

		// Token: 0x06044D07 RID: 281863 RVA: 0x010FB20E File Offset: 0x010F940E
		private int RandomRangeInt(int start, int end)
		{
			return Math.Min(end, (int)Math.Floor(MathUtils.Instance.GetRandomRange((double)start, (double)(end + 1))));
		}

		// Token: 0x06044D08 RID: 281864 RVA: 0x010FB22C File Offset: 0x010F942C
		public void ResetArea(int continuousIndex, EFishingAreaType areaType)
		{
			if (areaType != EFishingAreaType.QteArea)
			{
				if (areaType != EFishingAreaType.PerfectArea)
				{
					return;
				}
				this.RingInfo.RemovePerfectArea(continuousIndex);
				FishingQteRingQteSingleItem fishingQteRingQteSingleItem;
				if (this.PerfectAreaTextures.TryGetValue(continuousIndex, out fishingQteRingQteSingleItem))
				{
					fishingQteRingQteSingleItem.SetUiActive(false);
					this.CachedTexture.Add(fishingQteRingQteSingleItem);
					this.PerfectAreaTextures.Remove(continuousIndex);
				}
			}
			else
			{
				this.RingInfo.RemoveQteArea(continuousIndex);
				FishingQteRingQteSingleItem fishingQteRingQteSingleItem2;
				if (this.QteAreaTextures.TryGetValue(continuousIndex, out fishingQteRingQteSingleItem2))
				{
					fishingQteRingQteSingleItem2.SetUiActive(false);
					this.CachedTexture.Add(fishingQteRingQteSingleItem2);
					this.QteAreaTextures.Remove(continuousIndex);
					return;
				}
			}
		}

		// Token: 0x06044D09 RID: 281865 RVA: 0x010FB2BB File Offset: 0x010F94BB
		public void ResetAreaInLink(int continuousIndex, EFishingAreaType areaType)
		{
			if (areaType != EFishingAreaType.QteArea)
			{
				if (areaType != EFishingAreaType.PerfectArea)
				{
					return;
				}
				this.ResetArea(continuousIndex, EFishingAreaType.PerfectArea);
				this.ResetArea(continuousIndex, EFishingAreaType.QteArea);
			}
			else
			{
				this.ResetArea(continuousIndex, EFishingAreaType.QteArea);
				if (this.PerfectAreaTextures.ContainsKey(continuousIndex))
				{
					this.ResetArea(continuousIndex, EFishingAreaType.PerfectArea);
					return;
				}
			}
		}

		// Token: 0x06044D0A RID: 281866 RVA: 0x010FB2F8 File Offset: 0x010F94F8
		public void ResetAllArea()
		{
			foreach (int continuousIndex in this.QteAreaTextures.Keys.ToList<int>())
			{
				this.ResetArea(continuousIndex, EFishingAreaType.QteArea);
			}
			foreach (int continuousIndex2 in this.PerfectAreaTextures.Keys.ToList<int>())
			{
				this.ResetArea(continuousIndex2, EFishingAreaType.PerfectArea);
			}
		}

		// Token: 0x06044D0B RID: 281867 RVA: 0x010FB3A4 File Offset: 0x010F95A4
		private UniTask GenerateAreaWithTexture(int continuousIndex, EFishingAreaType areaType, int startIndex, int areaSize)
		{
			FishingQteRingQteItem.<GenerateAreaWithTexture>d__16 <GenerateAreaWithTexture>d__;
			<GenerateAreaWithTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GenerateAreaWithTexture>d__.<>4__this = this;
			<GenerateAreaWithTexture>d__.continuousIndex = continuousIndex;
			<GenerateAreaWithTexture>d__.areaType = areaType;
			<GenerateAreaWithTexture>d__.startIndex = startIndex;
			<GenerateAreaWithTexture>d__.areaSize = areaSize;
			<GenerateAreaWithTexture>d__.<>1__state = -1;
			<GenerateAreaWithTexture>d__.<>t__builder.Start<FishingQteRingQteItem.<GenerateAreaWithTexture>d__16>(ref <GenerateAreaWithTexture>d__);
			return <GenerateAreaWithTexture>d__.<>t__builder.Task;
		}

		// Token: 0x06044D0C RID: 281868 RVA: 0x010FB408 File Offset: 0x010F9608
		private UniTask GenerateQteArea(int continuousIndex, int startIndex, int areaSize)
		{
			FishingQteRingQteItem.<GenerateQteArea>d__17 <GenerateQteArea>d__;
			<GenerateQteArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GenerateQteArea>d__.<>4__this = this;
			<GenerateQteArea>d__.continuousIndex = continuousIndex;
			<GenerateQteArea>d__.startIndex = startIndex;
			<GenerateQteArea>d__.areaSize = areaSize;
			<GenerateQteArea>d__.<>1__state = -1;
			<GenerateQteArea>d__.<>t__builder.Start<FishingQteRingQteItem.<GenerateQteArea>d__17>(ref <GenerateQteArea>d__);
			return <GenerateQteArea>d__.<>t__builder.Task;
		}

		// Token: 0x06044D0D RID: 281869 RVA: 0x010FB464 File Offset: 0x010F9664
		public void SpawnAreaAtValidArea(int continuousIndex, RingArea validArea)
		{
			int startCellIndex = validArea.StartCellIndex;
			int endCellIndex = validArea.EndCellIndex;
			int num = FishingQteDefine.calculateCellSize(startCellIndex, endCellIndex);
			int areaRandomSize = this.GetAreaRandomSize(this.RingConfig.RandomArea);
			if (num <= areaRandomSize)
			{
				this.GenerateQteArea(continuousIndex, startCellIndex, num);
				return;
			}
			if (endCellIndex >= startCellIndex)
			{
				int startIndex = this.RandomRangeInt(startCellIndex, endCellIndex - areaRandomSize + 1);
				this.GenerateQteArea(continuousIndex, startIndex, areaRandomSize);
				return;
			}
			int num2 = startCellIndex + num - 1;
			int startIndex2 = this.RandomRangeInt(startCellIndex, num2 - areaRandomSize + 1) % 36;
			this.GenerateQteArea(continuousIndex, startIndex2, areaRandomSize);
		}

		// Token: 0x06044D0E RID: 281870 RVA: 0x010FB4EC File Offset: 0x010F96EC
		private void SpawnWholeRingAllArea()
		{
			ContinuousRingArea continuousRingArea;
			int num = this.RingInfo.GetQteAreas().TryGetValue(0, out continuousRingArea) ? continuousRingArea.StartCellIndex : 0;
			this.ResetAllArea();
			if (this.RingConfig.MultiBoxGroup == 0 || 36 % this.RingConfig.MultiBoxGroup != 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[FishingQte]格子扩展配置有误：不可被等分";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置组数", this.RingConfig.MultiBoxGroup);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int num2 = 36 / this.RingConfig.MultiBoxGroup;
			int multiBoxGroup = this.RingConfig.MultiBoxGroup;
			int num3 = this.RandomRangeInt(1, 36);
			if (multiBoxGroup == 1 && num != 0)
			{
				int areaRandomSize = this.GetAreaRandomSize(this.RingConfig.RandomArea);
				int startIndex = (num + 18) % 36;
				this.GenerateQteArea(0, startIndex, areaRandomSize);
				return;
			}
			for (int i = 0; i < multiBoxGroup; i++)
			{
				int areaRandomSize2 = this.GetAreaRandomSize(this.RingConfig.RandomArea);
				int startIndex2 = i * num2 + num3 + 1;
				this.GenerateQteArea(i, startIndex2, areaRandomSize2);
			}
		}

		// Token: 0x06044D0F RID: 281871 RVA: 0x010FB604 File Offset: 0x010F9804
		private void SpawnIncompleteRingAllArea()
		{
			this.ResetAllArea();
			List<RingArea> validAreas = this.RingInfo.GetValidAreas();
			for (int i = 0; i < validAreas.Count; i++)
			{
				this.SpawnAreaAtValidArea(i, validAreas[i]);
			}
		}

		// Token: 0x06044D10 RID: 281872 RVA: 0x010FB642 File Offset: 0x010F9842
		public void InitAllQteAreas()
		{
			if (this.RingInfo.IsWholeRing)
			{
				this.SpawnWholeRingAllArea();
				return;
			}
			this.SpawnIncompleteRingAllArea();
		}

		// Token: 0x06044D11 RID: 281873 RVA: 0x010FB660 File Offset: 0x010F9860
		public void SpawnContinuousArea(int continuousIndex, EFishingAreaType type = EFishingAreaType.QteArea)
		{
			if (this.RingInfo.IsWholeRing)
			{
				switch (this.RingConfig.RefreshType)
				{
				case 0:
					break;
				case 1:
					this.SpawnWholeRingAllArea();
					return;
				case 2:
					this.ResetAreaInLink(continuousIndex, type);
					if (this.RingInfo.GetQteAreas().Count == 0)
					{
						this.SpawnWholeRingAllArea();
						return;
					}
					break;
				default:
					return;
				}
			}
			else
			{
				List<RingArea> validAreas = this.RingInfo.GetValidAreas();
				this.ResetAreaInLink(continuousIndex, type);
				this.SpawnAreaAtValidArea(continuousIndex, validAreas[continuousIndex]);
			}
		}

		// Token: 0x06044D12 RID: 281874 RVA: 0x010FB6E3 File Offset: 0x010F98E3
		public UUIItem GetQteAreaTexture(int continuousIndex)
		{
			return this.QteAreaTextures[continuousIndex].GetRootItem();
		}

		// Token: 0x06044D13 RID: 281875 RVA: 0x010FB6F6 File Offset: 0x010F98F6
		public UUIItem GetPerfectAreaTexture(int continuousIndex)
		{
			return this.PerfectAreaTextures[continuousIndex].GetRootItem();
		}

		// Token: 0x06044D14 RID: 281876 RVA: 0x010FB70C File Offset: 0x010F990C
		public void PlayAnim(string sequenceName)
		{
			if (!(sequenceName == "Fail"))
			{
				if (!(sequenceName == "Success"))
				{
					if (!(sequenceName == "PerfectQte"))
					{
						return;
					}
					goto IL_DC;
				}
			}
			else
			{
				foreach (FishingQteRingQteSingleItem fishingQteRingQteSingleItem in this.QteAreaTextures.Values)
				{
					fishingQteRingQteSingleItem.PlayAnim(sequenceName);
				}
				using (Dictionary<int, FishingQteRingQteSingleItem>.ValueCollection.Enumerator enumerator = this.PerfectAreaTextures.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						FishingQteRingQteSingleItem fishingQteRingQteSingleItem2 = enumerator.Current;
						fishingQteRingQteSingleItem2.PlayAnim(sequenceName);
					}
					return;
				}
			}
			using (Dictionary<int, FishingQteRingQteSingleItem>.ValueCollection.Enumerator enumerator = this.QteAreaTextures.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FishingQteRingQteSingleItem fishingQteRingQteSingleItem3 = enumerator.Current;
					fishingQteRingQteSingleItem3.PlayAnim(sequenceName);
				}
				return;
			}
			IL_DC:
			foreach (FishingQteRingQteSingleItem fishingQteRingQteSingleItem4 in this.PerfectAreaTextures.Values)
			{
				fishingQteRingQteSingleItem4.PlayAnim(sequenceName);
			}
		}

		// Token: 0x04023CCC RID: 146636
		protected FishingQteGameInfo GameInfo;

		// Token: 0x04023CCD RID: 146637
		protected FishingQteRingInfo RingInfo;

		// Token: 0x04023CCE RID: 146638
		[Nullable(2)]
		protected IFishingQteConfig RingConfig;

		// Token: 0x04023CCF RID: 146639
		[Nullable(2)]
		private UUIItem TextureRing;

		// Token: 0x04023CD0 RID: 146640
		private Dictionary<int, FishingQteRingQteSingleItem> QteAreaTextures = new Dictionary<int, FishingQteRingQteSingleItem>();

		// Token: 0x04023CD1 RID: 146641
		private Dictionary<int, FishingQteRingQteSingleItem> PerfectAreaTextures = new Dictionary<int, FishingQteRingQteSingleItem>();

		// Token: 0x04023CD2 RID: 146642
		private List<FishingQteRingQteSingleItem> CachedTexture = new List<FishingQteRingQteSingleItem>();

		// Token: 0x0200CCFE RID: 52478
		[NullableContext(0)]
		private class EQteComponents
		{
			// Token: 0x0403DCFC RID: 253180
			public const int QteItem = 0;
		}
	}
}
