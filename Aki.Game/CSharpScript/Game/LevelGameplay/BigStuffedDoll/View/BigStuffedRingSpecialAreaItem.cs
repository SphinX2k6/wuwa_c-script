using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060DC RID: 24796
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedRingSpecialAreaItem : BigStuffedRingSubItem<ESubItemType>
	{
		// Token: 0x0603B73E RID: 243518 RVA: 0x010D3620 File Offset: 0x010D1820
		public BigStuffedRingSpecialAreaItem(int ringId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig> config, BigStuffedRingInfo ringInfo) : base(ringId, config)
		{
			this.Type = ESubItemType.SpecialArea;
			this.RingInfo = ringInfo;
		}

		// Token: 0x0603B73F RID: 243519 RVA: 0x010D367F File Offset: 0x010D187F
		protected override void OnStart()
		{
			base.OnStart();
			this.TextureRing.SetUIActive(false);
			this.SpawnAllContinuousArea();
		}

		// Token: 0x0603B740 RID: 243520 RVA: 0x010D3699 File Offset: 0x010D1899
		protected override void OnBeforeDestroy()
		{
			this.GoodAreaTextures.Clear();
			this.PerfectAreaTextures.Clear();
			this.BonusAreaTextures.Clear();
			this.CachedTexture.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603B741 RID: 243521 RVA: 0x010D36CD File Offset: 0x010D18CD
		public void SpawnAllContinuousArea()
		{
			this.ClearAndRecycleAllTextures();
			this.SpawnAllGoodAreas();
			this.SpawnAllPerfectOrBonusAreas();
			this.AdjustAllTexturesHierarchy();
		}

		// Token: 0x0603B742 RID: 243522 RVA: 0x010D36E8 File Offset: 0x010D18E8
		public void SpawnSingleContinuousArea(int continuousIndex)
		{
			this.ClearAndRecycleTextures(continuousIndex);
			bool bMultiBox = false;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					bMultiBox = (this.RingConfig.AsT1.MultiBoxGroup != 1);
				}
				else if (this.RingConfig.IsT2)
				{
					bMultiBox = (this.RingConfig.AsT2.MultiBoxGroup != 1);
				}
			}
			this.SpawnSingleGoodArea(continuousIndex, bMultiBox);
			this.SpawnPerfectOrBonusArea(continuousIndex);
			this.AdjustTexturesHierarchy(continuousIndex);
		}

		// Token: 0x0603B743 RID: 243523 RVA: 0x010D3770 File Offset: 0x010D1970
		private void SpawnAllGoodAreas()
		{
			List<Area> validAreas = this.RingInfo.GetValidAreas();
			this.RingInfo.GetGoodAreas().Clear();
			bool flag = false;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					flag = (this.RingConfig.AsT1.InvalidBoxLength == 0);
				}
				else if (this.RingConfig.IsT2)
				{
					flag = (this.RingConfig.AsT2.InvalidBox.Count == 0);
				}
			}
			if (flag)
			{
				if (this.RingConfig.HasValue)
				{
					if (this.RingConfig.IsT1)
					{
						int multiBoxGroup = this.RingConfig.AsT1.MultiBoxGroup;
						for (int i = 0; i < multiBoxGroup; i++)
						{
							this.SpawnSingleGoodArea(i, multiBoxGroup != 1);
						}
						return;
					}
					if (this.RingConfig.IsT2)
					{
						int multiBoxGroup2 = this.RingConfig.AsT2.MultiBoxGroup;
						for (int j = 0; j < multiBoxGroup2; j++)
						{
							this.SpawnSingleGoodArea(j, multiBoxGroup2 != 1);
						}
						return;
					}
				}
			}
			else
			{
				for (int k = 0; k < validAreas.Count; k++)
				{
					this.SpawnSingleGoodArea(k, false);
				}
			}
		}

		// Token: 0x0603B744 RID: 243524 RVA: 0x010D38AC File Offset: 0x010D1AAC
		private void SpawnSingleGoodArea(int continuousIndex, bool bMultiBox)
		{
			this.RingInfo.RemoveGoodArea(continuousIndex);
			List<Area> validAreas = this.RingInfo.GetValidAreas();
			bool flag = false;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					flag = (this.RingConfig.AsT1.InvalidBoxLength == 0);
				}
				else if (this.RingConfig.IsT2)
				{
					flag = (this.RingConfig.AsT2.InvalidBox.Count == 0);
				}
			}
			if (!flag)
			{
				if (continuousIndex < validAreas.Count)
				{
					this.SpawnGoodAreaAtValidArea(continuousIndex, validAreas[continuousIndex]);
				}
				return;
			}
			if (!bMultiBox)
			{
				if (this.LastGoodArea != null)
				{
					int startIndex = (this.LastGoodArea.StartCellIndex + 18) % 36;
					int areaSize = 0;
					if (this.RingConfig.HasValue)
					{
						if (this.RingConfig.IsT1)
						{
							areaSize = this.GetGoodAreaRandomSize(this.RingConfig.AsT1.GetRandomBoxBytes());
						}
						else if (this.RingConfig.IsT2)
						{
							areaSize = this.GetGoodAreaRandomSize(this.RingConfig.AsT2.RandomBox);
						}
					}
					this.SetUpRing(continuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.GoodArea, startIndex, areaSize);
				}
				else
				{
					this.SpawnGoodAreaAtValidArea(continuousIndex, validAreas[continuousIndex]);
				}
				ContinuousArea goodArea = this.RingInfo.GetGoodArea(continuousIndex);
				this.LastGoodArea = new ContinuousArea(continuousIndex, goodArea.StartCellIndex, goodArea.EndCellIndex, goodArea.ArrowDirection);
				return;
			}
			int num = 1;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					num = this.RingConfig.AsT1.MultiBoxGroup;
				}
				else if (this.RingConfig.IsT2)
				{
					num = this.RingConfig.AsT2.MultiBoxGroup;
				}
			}
			if (36 % num != 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]格子扩展配置有误：不可被等分";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置组数", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int num2 = 0;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					num2 = this.GetGoodAreaRandomSize(this.RingConfig.AsT1.GetRandomBoxBytes());
				}
				else if (this.RingConfig.IsT2)
				{
					num2 = this.GetGoodAreaRandomSize(this.RingConfig.AsT2.RandomBox);
				}
			}
			int num3 = 36 / num;
			int start = continuousIndex * num3 + continuousIndex + 1;
			int num4 = continuousIndex * num3;
			int startIndex2 = this.RandomRangeInt(start, num4 - num2);
			this.SetUpRing(continuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.GoodArea, startIndex2, num2);
		}

		// Token: 0x0603B745 RID: 243525 RVA: 0x010D3B34 File Offset: 0x010D1D34
		private void SpawnGoodAreaAtValidArea(int continuousIndex, Area validArea)
		{
			int startCellIndex = validArea.StartCellIndex;
			int endCellIndex = validArea.EndCellIndex;
			int num = BigStuffedDefine.calculateCellSize(startCellIndex, endCellIndex);
			int num2 = 0;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					num2 = this.GetGoodAreaRandomSize(this.RingConfig.AsT1.GetRandomBoxBytes());
				}
				else if (this.RingConfig.IsT2)
				{
					num2 = this.GetGoodAreaRandomSize(this.RingConfig.AsT2.RandomBox);
				}
			}
			if (num < num2)
			{
				this.SetUpRing(continuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.GoodArea, startCellIndex, num);
				return;
			}
			if (endCellIndex >= startCellIndex)
			{
				int startIndex = this.RandomRangeInt(startCellIndex, endCellIndex - num2 + 1);
				this.SetUpRing(continuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.GoodArea, startIndex, num2);
				return;
			}
			int num3 = startCellIndex + num - 1;
			int startIndex2 = this.RandomRangeInt(startCellIndex, num3 - num2 + 1) % 36;
			this.SetUpRing(continuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.GoodArea, startIndex2, num2);
		}

		// Token: 0x0603B746 RID: 243526 RVA: 0x010D3C08 File Offset: 0x010D1E08
		private void SpawnAllPerfectOrBonusAreas()
		{
			this.RingInfo.GetPerfectAreas().Clear();
			int num = 0;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					num = this.RingConfig.AsT1.PerfectBox;
				}
				else if (this.RingConfig.IsT2)
				{
					num = this.RingConfig.AsT2.PerfectBox;
				}
			}
			if (num == 0)
			{
				return;
			}
			foreach (KeyValuePair<int, ContinuousArea> keyValuePair in this.RingInfo.GetGoodAreas())
			{
				int key = keyValuePair.Key;
				this.SpawnPerfectOrBonusArea(key);
			}
		}

		// Token: 0x0603B747 RID: 243527 RVA: 0x010D3CD0 File Offset: 0x010D1ED0
		private void SpawnPerfectOrBonusArea(int continuousIndex)
		{
			this.RingInfo.RemovePerfectArea(continuousIndex);
			int num = 0;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					num = this.RingConfig.AsT1.PerfectBox;
				}
				else if (this.RingConfig.IsT2)
				{
					num = this.RingConfig.AsT2.PerfectBox;
				}
			}
			int num2 = num;
			if (num2 == 0)
			{
				return;
			}
			ContinuousArea goodArea = this.RingInfo.GetGoodArea(continuousIndex);
			if (goodArea == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]生成完美格子错误：找不到连续区域";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("连续区域索引", continuousIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int startCellIndex = goodArea.StartCellIndex;
			int endCellIndex = goodArea.EndCellIndex;
			int num3 = BigStuffedDefine.calculateCellSize(startCellIndex, endCellIndex);
			int startIndex = this.RandomRangeInt(startCellIndex, startCellIndex + num3 - num2) % 36;
			if (!this.CheckCanLevelUpToBonus())
			{
				this.SetUpRing(goodArea.ContinuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.PerfectArea, startIndex, num2);
				return;
			}
			this.SetUpRing(goodArea.ContinuousIndex, BigStuffedRingSpecialAreaItem.EAreaType.BonusArea, startIndex, num2);
		}

		// Token: 0x0603B748 RID: 243528 RVA: 0x010D3DD4 File Offset: 0x010D1FD4
		private bool CheckCanLevelUpToBonus()
		{
			float currentScore = BigStuffedDollModel.Instance.CurrentScore;
			float num = 0f;
			if (this.RingConfig.HasValue)
			{
				if (this.RingConfig.IsT1)
				{
					for (int i = 0; i < this.RingConfig.AsT1.BonusRateLength; i++)
					{
						DicIntInt? dicIntInt = this.RingConfig.AsT1.BonusRate(i);
						int key = dicIntInt.Value.Key;
						int value = dicIntInt.Value.Value;
						if (currentScore < (float)key)
						{
							break;
						}
						num = (float)value;
					}
				}
				else if (this.RingConfig.IsT2)
				{
					foreach (KeyValuePair<int, int> keyValuePair in this.RingConfig.AsT2.BonusRate)
					{
						int key2 = keyValuePair.Key;
						int value2 = keyValuePair.Value;
						if (currentScore < (float)key2)
						{
							break;
						}
						num = (float)value2;
					}
				}
			}
			return num != 0f && (float)this.RandomRangeInt(0, 100) <= num;
		}

		// Token: 0x0603B749 RID: 243529 RVA: 0x010D3F08 File Offset: 0x010D2108
		private void AdjustAllTexturesHierarchy()
		{
			foreach (KeyValuePair<int, UUITexture> keyValuePair in this.PerfectAreaTextures)
			{
				keyValuePair.Value.SetAsLastHierarchy();
			}
			foreach (KeyValuePair<int, UUITexture> keyValuePair2 in this.BonusAreaTextures)
			{
				keyValuePair2.Value.SetAsLastHierarchy();
			}
		}

		// Token: 0x0603B74A RID: 243530 RVA: 0x010D3FA8 File Offset: 0x010D21A8
		private void AdjustTexturesHierarchy(int continuousIndex)
		{
			UUITexture uuitexture;
			if (this.PerfectAreaTextures.TryGetValue(continuousIndex, out uuitexture) && uuitexture != null)
			{
				uuitexture.SetAsLastHierarchy();
			}
			UUITexture uuitexture2;
			if (this.BonusAreaTextures.TryGetValue(continuousIndex, out uuitexture2) && uuitexture2 != null)
			{
				uuitexture2.SetAsLastHierarchy();
			}
		}

		// Token: 0x0603B74B RID: 243531 RVA: 0x010D3FE8 File Offset: 0x010D21E8
		private void SetUpRing(int continuousIndex, BigStuffedRingSpecialAreaItem.EAreaType areaType, int startIndex, int areaSize)
		{
			UUITexture uuitexture = null;
			if (this.CachedTexture.Count > 0)
			{
				uuitexture = this.CachedTexture[this.CachedTexture.Count - 1];
				this.CachedTexture.RemoveAt(this.CachedTexture.Count - 1);
			}
			if (uuitexture == null)
			{
				uuitexture = (LguiUtil.Instance.DuplicateActor(this.TextureRing.GetOwner(), this.RootItem).GetComponentByClass(UUITexture.StaticClass()) as UUITexture);
			}
			float num = (float)(startIndex - 1) * 10f;
			UUIItem uuiitem = uuitexture;
			FRotator frotator = Rotator.Create(0f, -num, 0f).ToUeRotator();
			uuiitem.SetUIRelativeRotation(frotator);
			uuitexture.SetFillAmount((float)areaSize / 36f);
			uuitexture.SetCustomMaterialScalarParameter(this.ProgressParamName, (float)areaSize / 36f);
			int endCellIndex = (startIndex + areaSize - 1) % 36;
			switch (areaType)
			{
			case BigStuffedRingSpecialAreaItem.EAreaType.GoodArea:
				this.RingInfo.AddGoodArea(continuousIndex, startIndex, endCellIndex);
				this.GoodAreaTextures[continuousIndex] = uuitexture;
				uuitexture.SetColor(FColor.FromHex("#ECEACF"));
				break;
			case BigStuffedRingSpecialAreaItem.EAreaType.PerfectArea:
				this.RingInfo.AddPerfectArea(continuousIndex, startIndex, endCellIndex);
				this.PerfectAreaTextures[continuousIndex] = uuitexture;
				uuitexture.SetColor(FColor.FromHex("#FFBF3E"));
				break;
			case BigStuffedRingSpecialAreaItem.EAreaType.BonusArea:
				this.RingInfo.AddBonusArea(continuousIndex, startIndex, endCellIndex);
				this.BonusAreaTextures[continuousIndex] = uuitexture;
				uuitexture.SetColor(FColor.FromHex("#FC6F07"));
				break;
			}
			uuitexture.SetUIActive(true);
		}

		// Token: 0x0603B74C RID: 243532 RVA: 0x010D4164 File Offset: 0x010D2364
		[NullableContext(0)]
		private unsafe int GetGoodAreaRandomSize(Span<int> rangeConfig)
		{
			int result = 3;
			if (rangeConfig.Length == 2)
			{
				result = this.RandomRangeInt(*rangeConfig[0], *rangeConfig[1]);
			}
			return result;
		}

		// Token: 0x0603B74D RID: 243533 RVA: 0x010D4198 File Offset: 0x010D2398
		private int GetGoodAreaRandomSize(int[] rangeConfig)
		{
			int result = 3;
			if (rangeConfig.Length == 2)
			{
				result = this.RandomRangeInt(rangeConfig[0], rangeConfig[1]);
			}
			return result;
		}

		// Token: 0x0603B74E RID: 243534 RVA: 0x010D41BB File Offset: 0x010D23BB
		private int RandomRangeInt(int start, int end)
		{
			return Math.Min(end, (int)Math.Floor(MathUtils.Instance.GetRandomRange((double)start, (double)(end + 1))));
		}

		// Token: 0x0603B74F RID: 243535 RVA: 0x010D41DC File Offset: 0x010D23DC
		private void ClearAndRecycleAllTextures()
		{
			foreach (KeyValuePair<int, UUITexture> keyValuePair in this.GoodAreaTextures)
			{
				UUITexture value = keyValuePair.Value;
				this.CachedTexture.Add(value);
				value.SetUIActive(false);
			}
			this.GoodAreaTextures.Clear();
			foreach (KeyValuePair<int, UUITexture> keyValuePair2 in this.PerfectAreaTextures)
			{
				UUITexture value2 = keyValuePair2.Value;
				this.CachedTexture.Add(value2);
				value2.SetUIActive(false);
			}
			this.PerfectAreaTextures.Clear();
			foreach (KeyValuePair<int, UUITexture> keyValuePair3 in this.BonusAreaTextures)
			{
				UUITexture value3 = keyValuePair3.Value;
				this.CachedTexture.Add(value3);
				value3.SetUIActive(false);
			}
			this.BonusAreaTextures.Clear();
		}

		// Token: 0x0603B750 RID: 243536 RVA: 0x010D4318 File Offset: 0x010D2518
		private void ClearAndRecycleTextures(int continuousIndex)
		{
			UUITexture uuitexture;
			if (this.GoodAreaTextures.TryGetValue(continuousIndex, out uuitexture))
			{
				this.CachedTexture.Add(uuitexture);
				uuitexture.SetUIActive(false);
				this.GoodAreaTextures.Remove(continuousIndex);
			}
			UUITexture uuitexture2;
			if (this.PerfectAreaTextures.TryGetValue(continuousIndex, out uuitexture2))
			{
				this.CachedTexture.Add(uuitexture2);
				uuitexture2.SetUIActive(false);
				this.PerfectAreaTextures.Remove(continuousIndex);
			}
			UUITexture uuitexture3;
			if (this.BonusAreaTextures.TryGetValue(continuousIndex, out uuitexture3))
			{
				this.CachedTexture.Add(uuitexture3);
				uuitexture3.SetUIActive(false);
				this.BonusAreaTextures.Remove(continuousIndex);
			}
		}

		// Token: 0x0401F586 RID: 128390
		private readonly Dictionary<int, UUITexture> GoodAreaTextures = new Dictionary<int, UUITexture>();

		// Token: 0x0401F587 RID: 128391
		private readonly Dictionary<int, UUITexture> PerfectAreaTextures = new Dictionary<int, UUITexture>();

		// Token: 0x0401F588 RID: 128392
		private readonly Dictionary<int, UUITexture> BonusAreaTextures = new Dictionary<int, UUITexture>();

		// Token: 0x0401F589 RID: 128393
		private readonly FName ProgressParamName = new FName("Progress");

		// Token: 0x0401F58A RID: 128394
		[Nullable(2)]
		private ContinuousArea LastGoodArea;

		// Token: 0x0401F58B RID: 128395
		private readonly List<UUITexture> CachedTexture = new List<UUITexture>();

		// Token: 0x0401F58C RID: 128396
		[Nullable(2)]
		private readonly BigStuffedRingInfo RingInfo;

		// Token: 0x0200B985 RID: 47493
		[NullableContext(0)]
		private enum EAreaType
		{
			// Token: 0x04039342 RID: 234306
			GoodArea,
			// Token: 0x04039343 RID: 234307
			PerfectArea,
			// Token: 0x04039344 RID: 234308
			BonusArea
		}
	}
}
