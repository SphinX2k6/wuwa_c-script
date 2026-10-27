using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A21 RID: 18977
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdData
	{
		// Token: 0x06031450 RID: 201808 RVA: 0x00B6D191 File Offset: 0x00B6B391
		public static TrapDefenseBdData Create(TrapDefenseBd config)
		{
			TrapDefenseBdData trapDefenseBdData = new TrapDefenseBdData(config.Id);
			trapDefenseBdData.Config = config;
			trapDefenseBdData.Init();
			return trapDefenseBdData;
		}

		// Token: 0x06031451 RID: 201809 RVA: 0x00B6D1AC File Offset: 0x00B6B3AC
		private TrapDefenseBdData(int id)
		{
			this.Id = id;
			this.SumProgress = 1;
		}

		// Token: 0x06031452 RID: 201810 RVA: 0x00B6D1D8 File Offset: 0x00B6B3D8
		private void Init()
		{
			foreach (TrapDefenseBdGroup config in TrapDefenseConfig.Instance.GetBdGroupListByBdId(this.Id))
			{
				TrapDefenseBdBuffData trapDefenseBdBuffData = TrapDefenseBdBuffData.Create(config);
				this.BdBuffDataList.Add(trapDefenseBdBuffData);
				this.BdBuffDataMap[config.Id] = trapDefenseBdBuffData;
			}
			this.SumProgress = this.Config.GoldBuffCount;
		}

		// Token: 0x06031453 RID: 201811 RVA: 0x00B6D260 File Offset: 0x00B6B460
		public bool IsActive()
		{
			using (List<TrapDefenseBdBuffData>.Enumerator enumerator = this.BdBuffDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsActive)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06031454 RID: 201812 RVA: 0x00B6D2BC File Offset: 0x00B6B4BC
		public void SetUnlock(bool unlock)
		{
			this.IsUnlock = unlock;
		}

		// Token: 0x06031455 RID: 201813 RVA: 0x00B6D2C5 File Offset: 0x00B6B4C5
		public bool IsUnlockInTheUi()
		{
			TrapDefenseBdSumViewModel viewModelBdSum = TrapDefenseModel.Instance.ViewModelBdSum;
			return (viewModelBdSum != null && viewModelBdSum.IsInstance) || this.IsUnlock;
		}

		// Token: 0x06031456 RID: 201814 RVA: 0x00B6D2E7 File Offset: 0x00B6B4E7
		public List<TrapDefenseBdBuffData> GetGoldQualityBuffDataList()
		{
			return this.GetQualityBuffDataList(ETrapDefenseBdBuffQuality.Gold);
		}

		// Token: 0x06031457 RID: 201815 RVA: 0x00B6D2F0 File Offset: 0x00B6B4F0
		public List<TrapDefenseBdBuffData> GetQualityBuffDataList(ETrapDefenseBdBuffQuality quality)
		{
			List<TrapDefenseBdBuffData> list = new List<TrapDefenseBdBuffData>();
			foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.BdBuffDataList)
			{
				if (trapDefenseBdBuffData.Config.Quality == (int)quality)
				{
					list.Add(trapDefenseBdBuffData);
				}
			}
			return list;
		}

		// Token: 0x06031458 RID: 201816 RVA: 0x00B6D358 File Offset: 0x00B6B558
		public int GetCurrentActiveProgressNum()
		{
			int num = 0;
			foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.BdBuffDataList)
			{
				num += trapDefenseBdBuffData.GetActiveBdProgressNum();
			}
			return num;
		}

		// Token: 0x06031459 RID: 201817 RVA: 0x00B6D3B0 File Offset: 0x00B6B5B0
		public List<ITrapDefenseBdProgressInfo> GetBdProgressInfoList()
		{
			List<ITrapDefenseBdProgressInfo> list = new List<ITrapDefenseBdProgressInfo>();
			int currentActiveProgressNum = this.GetCurrentActiveProgressNum();
			ValueTuple<int, ETrapDefenseResKey> bdProgressArrowPos = this.GetBdProgressArrowPos(currentActiveProgressNum);
			int item = bdProgressArrowPos.Item1;
			ETrapDefenseResKey item2 = bdProgressArrowPos.Item2;
			for (int i = 0; i < this.SumProgress; i++)
			{
				list.Add(new TrapDefenseBdProgressInfo
				{
					BdData = this,
					IsActive = (i < currentActiveProgressNum),
					IsShowQualityArrow = (i + 1 == item),
					QualityArrowRes = item2
				});
			}
			return list;
		}

		// Token: 0x0603145A RID: 201818 RVA: 0x00B6D425 File Offset: 0x00B6B625
		[NullableContext(0)]
		public ValueTuple<int, ETrapDefenseResKey> GetBdProgressArrowPos(int activeNum)
		{
			if (this.Config.PurpleBuffCount > activeNum)
			{
				return new ValueTuple<int, ETrapDefenseResKey>(this.Config.PurpleBuffCount, ETrapDefenseResKey.BdProgressArrowQualityPurple);
			}
			return new ValueTuple<int, ETrapDefenseResKey>(this.Config.GoldBuffCount, ETrapDefenseResKey.BdProgressArrowQualityGold);
		}

		// Token: 0x0603145B RID: 201819 RVA: 0x00B6D460 File Offset: 0x00B6B660
		public ETrapDefenseBdBuffQuality GetCurActiveQualityPool()
		{
			int currentActiveProgressNum = this.GetCurrentActiveProgressNum();
			if (this.Config.PurpleBuffCount > currentActiveProgressNum)
			{
				return ETrapDefenseBdBuffQuality.Blue;
			}
			if (this.Config.GoldBuffCount > currentActiveProgressNum)
			{
				return ETrapDefenseBdBuffQuality.Purple;
			}
			return ETrapDefenseBdBuffQuality.Gold;
		}

		// Token: 0x0603145C RID: 201820 RVA: 0x00B6D495 File Offset: 0x00B6B695
		[NullableContext(2)]
		public void SetPreAddedBuff(TrapDefenseBdBuffData buff = null)
		{
			this.PreAddedBdBuffData = buff;
		}

		// Token: 0x0603145D RID: 201821 RVA: 0x00B6D4A0 File Offset: 0x00B6B6A0
		[NullableContext(0)]
		public ValueTuple<bool, ETrapDefenseBdBuffQuality> PreAddedBuffIsActiveNewQuality(int preAdd = -1)
		{
			if (this.IsZeroBdType())
			{
				return new ValueTuple<bool, ETrapDefenseBdBuffQuality>(false, ETrapDefenseBdBuffQuality.Purple);
			}
			int num = (preAdd == -1) ? ((this.PreAddedBdBuffData != null) ? 1 : 0) : preAdd;
			int num2 = this.GetCurrentActiveProgressNum() + num;
			if (num2 == this.Config.PurpleBuffCount)
			{
				return new ValueTuple<bool, ETrapDefenseBdBuffQuality>(true, ETrapDefenseBdBuffQuality.Purple);
			}
			if (num2 == this.Config.GoldBuffCount)
			{
				return new ValueTuple<bool, ETrapDefenseBdBuffQuality>(true, ETrapDefenseBdBuffQuality.Gold);
			}
			if (num2 < this.Config.PurpleBuffCount)
			{
				return new ValueTuple<bool, ETrapDefenseBdBuffQuality>(false, ETrapDefenseBdBuffQuality.Blue);
			}
			if (num2 < this.Config.GoldBuffCount)
			{
				return new ValueTuple<bool, ETrapDefenseBdBuffQuality>(false, ETrapDefenseBdBuffQuality.Purple);
			}
			return new ValueTuple<bool, ETrapDefenseBdBuffQuality>(false, ETrapDefenseBdBuffQuality.Gold);
		}

		// Token: 0x0603145E RID: 201822 RVA: 0x00B6D536 File Offset: 0x00B6B736
		public int GetSumProgressForStageMode(int addNum = 0)
		{
			if (this.GetCurrentActiveProgressNum() + addNum >= this.Config.PurpleBuffCount)
			{
				return this.Config.GoldBuffCount;
			}
			return this.Config.PurpleBuffCount;
		}

		// Token: 0x0603145F RID: 201823 RVA: 0x00B6D564 File Offset: 0x00B6B764
		public bool IsZeroBdType()
		{
			return this.Config.Id == 0;
		}

		// Token: 0x06031460 RID: 201824 RVA: 0x00B6D574 File Offset: 0x00B6B774
		public string GetShowActorLabelStr()
		{
			int id = this.Id;
			int purpleBuffCount = this.Config.PurpleBuffCount;
			int goldBuffCount = this.Config.GoldBuffCount;
			int count = this.BdBuffDataList.Count;
			bool value = this.IsActive();
			bool isUnlock = this.IsUnlock;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 6);
			defaultInterpolatedStringHandler.AppendLiteral("BdDesc_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			defaultInterpolatedStringHandler.AppendLiteral("_Gold-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(goldBuffCount);
			defaultInterpolatedStringHandler.AppendLiteral("_Purple-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(purpleBuffCount);
			defaultInterpolatedStringHandler.AppendLiteral("_BuffLen-");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			defaultInterpolatedStringHandler.AppendLiteral("_Active-");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(value);
			defaultInterpolatedStringHandler.AppendLiteral("_Unlock-");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(isUnlock);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06031461 RID: 201825 RVA: 0x00B6D648 File Offset: 0x00B6B848
		public IReadOnlyList<TrapDefenseBdBuffData> GetBdBuffShowListForSumView()
		{
			TrapDefenseBdSumViewModel viewModelBdSum = TrapDefenseModel.Instance.ViewModelBdSum;
			if (viewModelBdSum != null && viewModelBdSum.IsInstance)
			{
				List<TrapDefenseBdBuffData> list = new List<TrapDefenseBdBuffData>();
				foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.BdBuffDataList)
				{
					if (trapDefenseBdBuffData.IsActive)
					{
						list.Add(trapDefenseBdBuffData);
					}
				}
				TrapDefenseBdBuffData[] array = list.ToArray();
				Array.Sort<TrapDefenseBdBuffData>(array, new Comparison<TrapDefenseBdBuffData>(this.SortBdBuffQuality));
				return array;
			}
			List<TrapDefenseBdBuffData> bdBuffDataList = this.BdBuffDataList;
			bdBuffDataList.Sort(new Comparison<TrapDefenseBdBuffData>(this.SortBdBuffQuality));
			return bdBuffDataList;
		}

		// Token: 0x06031462 RID: 201826 RVA: 0x00B6D6F4 File Offset: 0x00B6B8F4
		public int SortBdBuffQuality(TrapDefenseBdBuffData a, TrapDefenseBdBuffData b)
		{
			int quality = a.Config.Quality;
			int quality2 = b.Config.Quality;
			if (quality != quality2)
			{
				return quality2 - quality;
			}
			return b.Id - a.Id;
		}

		// Token: 0x0401A56E RID: 107886
		public int Id;

		// Token: 0x0401A56F RID: 107887
		public TrapDefenseBd Config;

		// Token: 0x0401A570 RID: 107888
		public int SumProgress;

		// Token: 0x0401A571 RID: 107889
		public readonly List<TrapDefenseBdBuffData> BdBuffDataList = new List<TrapDefenseBdBuffData>();

		// Token: 0x0401A572 RID: 107890
		public readonly Dictionary<int, TrapDefenseBdBuffData> BdBuffDataMap = new Dictionary<int, TrapDefenseBdBuffData>();

		// Token: 0x0401A573 RID: 107891
		[Nullable(2)]
		public TrapDefenseBdBuffData PreAddedBdBuffData;

		// Token: 0x0401A574 RID: 107892
		public bool IsUnlock;
	}
}
