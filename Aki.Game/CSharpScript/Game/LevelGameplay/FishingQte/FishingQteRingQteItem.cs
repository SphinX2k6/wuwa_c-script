using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC7 RID: 24519
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingQteItem : UiPanelBase
	{
		// Token: 0x0603AE8F RID: 241295 RVA: 0x010A5695 File Offset: 0x010A3895
		public FishingQteRingQteItem(FishingQteGameInfo GameInfo, FishingQteRingInfo RingInfo, [Nullable(2)] IFishingQteConfig RingConfig)
		{
			this.GameInfo = GameInfo;
			this.RingInfo = RingInfo;
			this.RingConfig = RingConfig;
		}

		// Token: 0x0603AE90 RID: 241296 RVA: 0x010A56D4 File Offset: 0x010A38D4
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

		// Token: 0x0603AE91 RID: 241297 RVA: 0x010A571C File Offset: 0x010A391C
		protected override void OnStart()
		{
			this.TextureRing = base.GetItem(0);
			this.TextureRing.SetUIActive(false);
		}

		// Token: 0x0603AE92 RID: 241298 RVA: 0x010A5737 File Offset: 0x010A3937
		protected override void OnBeforeDestroy()
		{
			this.TextureRing = null;
			this.QteAreaTextures.Clear();
			this.PerfectAreaTextures.Clear();
			this.CachedTexture.Clear();
		}

		// Token: 0x0603AE93 RID: 241299 RVA: 0x010A5764 File Offset: 0x010A3964
		private int GetAreaRandomSize(List<int> rangeConfig)
		{
			int result = 3;
			if (rangeConfig.Count == 2)
			{
				result = this.RandomRangeInt(rangeConfig[0], rangeConfig[1]);
			}
			return result;
		}

		// Token: 0x0603AE94 RID: 241300 RVA: 0x010A5792 File Offset: 0x010A3992
		private int RandomRangeInt(int start, int end)
		{
			return Math.Min(end, (int)Math.Floor(MathUtils.Instance.GetRandomRange((double)start, (double)(end + 1))));
		}

		// Token: 0x0603AE95 RID: 241301 RVA: 0x010A57B0 File Offset: 0x010A39B0
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

		// Token: 0x0603AE96 RID: 241302 RVA: 0x010A583F File Offset: 0x010A3A3F
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

		// Token: 0x0603AE97 RID: 241303 RVA: 0x010A587C File Offset: 0x010A3A7C
		public void ResetAllArea()
		{
			foreach (int continuousIndex in this.QteAreaTextures.Keys)
			{
				this.ResetArea(continuousIndex, EFishingAreaType.QteArea);
			}
			foreach (int continuousIndex2 in this.PerfectAreaTextures.Keys)
			{
				this.ResetArea(continuousIndex2, EFishingAreaType.PerfectArea);
			}
		}

		// Token: 0x0603AE98 RID: 241304 RVA: 0x010A5920 File Offset: 0x010A3B20
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

		// Token: 0x0603AE99 RID: 241305 RVA: 0x010A5984 File Offset: 0x010A3B84
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

		// Token: 0x0603AE9A RID: 241306 RVA: 0x010A59E0 File Offset: 0x010A3BE0
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

		// Token: 0x0603AE9B RID: 241307 RVA: 0x010A5A68 File Offset: 0x010A3C68
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

		// Token: 0x0603AE9C RID: 241308 RVA: 0x010A5B80 File Offset: 0x010A3D80
		private void SpawnIncompleteRingAllArea()
		{
			this.ResetAllArea();
			List<RingArea> validAreas = this.RingInfo.GetValidAreas();
			for (int i = 0; i < validAreas.Count; i++)
			{
				this.SpawnAreaAtValidArea(i, validAreas[i]);
			}
		}

		// Token: 0x0603AE9D RID: 241309 RVA: 0x010A5BBE File Offset: 0x010A3DBE
		public void InitAllQteAreas()
		{
			if (this.RingInfo.IsWholeRing)
			{
				this.SpawnWholeRingAllArea();
				return;
			}
			this.SpawnIncompleteRingAllArea();
		}

		// Token: 0x0603AE9E RID: 241310 RVA: 0x010A5BDC File Offset: 0x010A3DDC
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

		// Token: 0x0603AE9F RID: 241311 RVA: 0x010A5C5F File Offset: 0x010A3E5F
		public UUIItem GetQteAreaTexture(int continuousIndex)
		{
			return this.QteAreaTextures[continuousIndex].GetRootItem();
		}

		// Token: 0x0603AEA0 RID: 241312 RVA: 0x010A5C72 File Offset: 0x010A3E72
		public UUIItem GetPerfectAreaTexture(int continuousIndex)
		{
			return this.PerfectAreaTextures[continuousIndex].GetRootItem();
		}

		// Token: 0x0603AEA1 RID: 241313 RVA: 0x010A5C88 File Offset: 0x010A3E88
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

		// Token: 0x0401EF81 RID: 126849
		protected FishingQteGameInfo GameInfo;

		// Token: 0x0401EF82 RID: 126850
		protected FishingQteRingInfo RingInfo;

		// Token: 0x0401EF83 RID: 126851
		[Nullable(2)]
		protected IFishingQteConfig RingConfig;

		// Token: 0x0401EF84 RID: 126852
		[Nullable(2)]
		private UUIItem TextureRing;

		// Token: 0x0401EF85 RID: 126853
		private Dictionary<int, FishingQteRingQteSingleItem> QteAreaTextures = new Dictionary<int, FishingQteRingQteSingleItem>();

		// Token: 0x0401EF86 RID: 126854
		private Dictionary<int, FishingQteRingQteSingleItem> PerfectAreaTextures = new Dictionary<int, FishingQteRingQteSingleItem>();

		// Token: 0x0401EF87 RID: 126855
		private List<FishingQteRingQteSingleItem> CachedTexture = new List<FishingQteRingQteSingleItem>();

		// Token: 0x0200B8EE RID: 47342
		[NullableContext(0)]
		private class EQteComponents
		{
			// Token: 0x0403911E RID: 233758
			public const int QteItem = 0;
		}
	}
}
