using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C9 RID: 14793
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdData
	{
		// Token: 0x060261E0 RID: 156128 RVA: 0x00AB118D File Offset: 0x00AAF38D
		public static TrapDefenseBdData Create(TrapDefenseBd config)
		{
			TrapDefenseBdData trapDefenseBdData = new TrapDefenseBdData(config.Id);
			trapDefenseBdData.Config = config;
			trapDefenseBdData.Init();
			return trapDefenseBdData;
		}

		// Token: 0x060261E1 RID: 156129 RVA: 0x00AB11A8 File Offset: 0x00AAF3A8
		private TrapDefenseBdData(int id)
		{
			this.Id = id;
			this.SumProgress = 1;
		}

		// Token: 0x060261E2 RID: 156130 RVA: 0x00AB11D4 File Offset: 0x00AAF3D4
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

		// Token: 0x060261E3 RID: 156131 RVA: 0x00AB125C File Offset: 0x00AAF45C
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

		// Token: 0x060261E4 RID: 156132 RVA: 0x00AB12B8 File Offset: 0x00AAF4B8
		public void SetUnlock(bool unlock)
		{
			this.IsUnlock = unlock;
		}

		// Token: 0x060261E5 RID: 156133 RVA: 0x00AB12C1 File Offset: 0x00AAF4C1
		public bool IsUnlockInTheUi()
		{
			TrapDefenseBdSumViewModel viewModelBdSum = TrapDefenseModel.Instance.ViewModelBdSum;
			return (viewModelBdSum != null && viewModelBdSum.IsInstance) || this.IsUnlock;
		}

		// Token: 0x060261E6 RID: 156134 RVA: 0x00AB12E3 File Offset: 0x00AAF4E3
		public List<TrapDefenseBdBuffData> GetGoldQualityBuffDataList()
		{
			return this.GetQualityBuffDataList(ETrapDefenseBdBuffQuality.Gold);
		}

		// Token: 0x060261E7 RID: 156135 RVA: 0x00AB12EC File Offset: 0x00AAF4EC
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

		// Token: 0x060261E8 RID: 156136 RVA: 0x00AB1354 File Offset: 0x00AAF554
		public int GetCurrentActiveProgressNum()
		{
			int num = 0;
			foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.BdBuffDataList)
			{
				num += trapDefenseBdBuffData.GetActiveBdProgressNum();
			}
			return num;
		}

		// Token: 0x060261E9 RID: 156137 RVA: 0x00AB13AC File Offset: 0x00AAF5AC
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

		// Token: 0x060261EA RID: 156138 RVA: 0x00AB1421 File Offset: 0x00AAF621
		[NullableContext(0)]
		public ValueTuple<int, ETrapDefenseResKey> GetBdProgressArrowPos(int activeNum)
		{
			if (this.Config.PurpleBuffCount > activeNum)
			{
				return new ValueTuple<int, ETrapDefenseResKey>(this.Config.PurpleBuffCount, ETrapDefenseResKey.BdProgressArrowQualityPurple);
			}
			return new ValueTuple<int, ETrapDefenseResKey>(this.Config.GoldBuffCount, ETrapDefenseResKey.BdProgressArrowQualityGold);
		}

		// Token: 0x060261EB RID: 156139 RVA: 0x00AB145C File Offset: 0x00AAF65C
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

		// Token: 0x060261EC RID: 156140 RVA: 0x00AB1491 File Offset: 0x00AAF691
		[NullableContext(2)]
		public void SetPreAddedBuff(TrapDefenseBdBuffData buff = null)
		{
			this.PreAddedBdBuffData = buff;
		}

		// Token: 0x060261ED RID: 156141 RVA: 0x00AB149C File Offset: 0x00AAF69C
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

		// Token: 0x060261EE RID: 156142 RVA: 0x00AB1532 File Offset: 0x00AAF732
		public int GetSumProgressForStageMode(int addNum = 0)
		{
			if (this.GetCurrentActiveProgressNum() + addNum >= this.Config.PurpleBuffCount)
			{
				return this.Config.GoldBuffCount;
			}
			return this.Config.PurpleBuffCount;
		}

		// Token: 0x060261EF RID: 156143 RVA: 0x00AB1560 File Offset: 0x00AAF760
		public bool IsZeroBdType()
		{
			return this.Config.Id == 0;
		}

		// Token: 0x060261F0 RID: 156144 RVA: 0x00AB1570 File Offset: 0x00AAF770
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

		// Token: 0x060261F1 RID: 156145 RVA: 0x00AB1644 File Offset: 0x00AAF844
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

		// Token: 0x060261F2 RID: 156146 RVA: 0x00AB16F0 File Offset: 0x00AAF8F0
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

		// Token: 0x04014EC5 RID: 85701
		public int Id;

		// Token: 0x04014EC6 RID: 85702
		public TrapDefenseBd Config;

		// Token: 0x04014EC7 RID: 85703
		public int SumProgress;

		// Token: 0x04014EC8 RID: 85704
		public readonly List<TrapDefenseBdBuffData> BdBuffDataList = new List<TrapDefenseBdBuffData>();

		// Token: 0x04014EC9 RID: 85705
		public readonly Dictionary<int, TrapDefenseBdBuffData> BdBuffDataMap = new Dictionary<int, TrapDefenseBdBuffData>();

		// Token: 0x04014ECA RID: 85706
		[Nullable(2)]
		public TrapDefenseBdBuffData PreAddedBdBuffData;

		// Token: 0x04014ECB RID: 85707
		public bool IsUnlock;
	}
}
