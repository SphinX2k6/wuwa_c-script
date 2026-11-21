using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BEC RID: 19436
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BossPilingModel : ModelBase
	{
		// Token: 0x06030805 RID: 198661 RVA: 0x00D826B3 File Offset: 0x00D808B3
		public BossPilingActivityData GetActivityData()
		{
			if (this.ActivityData == null)
			{
				this.ActivityData = BossPilingController.Instance.GetActivityData();
			}
			return this.ActivityData;
		}

		// Token: 0x06030806 RID: 198662 RVA: 0x00D826D4 File Offset: 0x00D808D4
		public Dictionary<int, List<BossPilingBuffCountInfo>> GetBuffList(int levelId, bool inGame)
		{
			Dictionary<int, List<BossPilingBuffCountInfo>> dictionary = new Dictionary<int, List<BossPilingBuffCountInfo>>();
			if (!inGame)
			{
				BossPilingLevels? levelInfo = BossPilingConfig.Instance.GetLevelInfo(levelId);
				if (levelInfo.Value.RareBuffGroup().Length != 0)
				{
					List<BossPilingBuffCountInfo> list = new List<BossPilingBuffCountInfo>();
					foreach (int buffId in levelInfo.Value.RareBuffGroupIter())
					{
						BossPilingBuffCountInfo item = new BossPilingBuffCountInfo
						{
							BuffId = buffId,
							Count = 1
						};
						list.Add(item);
					}
					dictionary[5] = list;
				}
				if (levelInfo.Value.BuffGroup().Length != 0)
				{
					List<BossPilingBuffCountInfo> list2 = new List<BossPilingBuffCountInfo>();
					foreach (int buffId2 in levelInfo.Value.BuffGroupIter())
					{
						BossPilingBuffCountInfo item2 = new BossPilingBuffCountInfo
						{
							BuffId = buffId2,
							Count = 1
						};
						list2.Add(item2);
					}
					dictionary[4] = list2;
				}
			}
			else
			{
				Dictionary<int, int> dungeonBuff = this.GetActivityData().GetDungeonBuff();
				List<BossPilingBuffCountInfo> list3 = new List<BossPilingBuffCountInfo>();
				List<BossPilingBuffCountInfo> list4 = new List<BossPilingBuffCountInfo>();
				foreach (KeyValuePair<int, int> keyValuePair in dungeonBuff)
				{
					int num;
					int num2;
					keyValuePair.Deconstruct(out num, out num2);
					int num3 = num;
					int count = num2;
					int quality = BossPilingConfig.Instance.GetBuffInfo(num3).Value.Quality;
					BossPilingBuffCountInfo item3 = new BossPilingBuffCountInfo
					{
						BuffId = num3,
						Count = count
					};
					if (quality < 5)
					{
						list4.Add(item3);
					}
					else
					{
						list3.Add(item3);
					}
				}
				if (list3.Count > 0)
				{
					dictionary[5] = list3;
				}
				if (list4.Count > 0)
				{
					dictionary[4] = list4;
				}
			}
			return dictionary;
		}

		// Token: 0x06030807 RID: 198663 RVA: 0x00D828E4 File Offset: 0x00D80AE4
		public bool CheckIsBossPiling()
		{
			InstanceDungeon? instanceDungeon;
			return ((GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().InstSubType : -1) == 55;
		}

		// Token: 0x06030808 RID: 198664 RVA: 0x00D8291C File Offset: 0x00D80B1C
		[NullableContext(0)]
		public ValueTuple<int, bool> GetLevelIdAndHalfByInstId(int instId)
		{
			if (this.InstLevelInfo.Count == 0)
			{
				foreach (BossPilingLevelInfo bossPilingLevelInfo in this.ActivityData.GetAllLevelInfo())
				{
					BossPilingLevels? levelInfo = BossPilingConfig.Instance.GetLevelInfo(bossPilingLevelInfo.Id);
					for (int i = 0; i < levelInfo.Value.InstIds().Length; i++)
					{
						this.InstLevelInfo[levelInfo.Value.InstIds()[i]] = new ValueTuple<int, bool>(bossPilingLevelInfo.Id, i == 0);
					}
				}
			}
			return this.InstLevelInfo[instId];
		}

		// Token: 0x06030809 RID: 198665 RVA: 0x00D829E4 File Offset: 0x00D80BE4
		public void CloseActivityView(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(BossPilingController.Instance.ActivityId))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
				confirmBoxDataNew.FunctionMap[1] = new Action(this.<CloseActivityView>g__ConfirmCallback|8_0);
				confirmBoxDataNew.FunctionMap[0] = new Action(this.<CloseActivityView>g__ConfirmCallback|8_0);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			}
		}

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x0603080A RID: 198666 RVA: 0x00D82A47 File Offset: 0x00D80C47
		public static BossPilingModel Instance
		{
			get
			{
				return BossPilingModel._Instance;
			}
		}

		// Token: 0x0603080B RID: 198667 RVA: 0x00D82A4E File Offset: 0x00D80C4E
		public static BossPilingModel GetOrCreateInstance()
		{
			if (BossPilingModel._Instance == null)
			{
				BossPilingModel.CreateInstance();
			}
			return BossPilingModel._Instance;
		}

		// Token: 0x0603080C RID: 198668 RVA: 0x00D82A62 File Offset: 0x00D80C62
		public static bool CreateInstance()
		{
			if (BossPilingModel._Instance != null)
			{
				return true;
			}
			BossPilingModel._Instance = new BossPilingModel();
			return true;
		}

		// Token: 0x0603080D RID: 198669 RVA: 0x00D82A78 File Offset: 0x00D80C78
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603080E RID: 198670 RVA: 0x00D82A7A File Offset: 0x00D80C7A
		public static void ResetStaticDefaultValue()
		{
			BossPilingModel._Instance = null;
		}

		// Token: 0x0603080F RID: 198671 RVA: 0x00D82A82 File Offset: 0x00D80C82
		static BossPilingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingModel.CreateStaticDefaultValue), new Action(BossPilingModel.ResetStaticDefaultValue));
		}

		// Token: 0x06030811 RID: 198673 RVA: 0x00D82ABF File Offset: 0x00D80CBF
		[CompilerGenerated]
		private void <CloseActivityView>g__ConfirmCallback|8_0()
		{
			if (this.CheckIsBossPiling())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
				return;
			}
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x04019AC8 RID: 105160
		[Nullable(2)]
		protected BossPilingActivityData ActivityData;

		// Token: 0x04019AC9 RID: 105161
		[Nullable(new byte[]
		{
			1,
			0
		})]
		protected Dictionary<int, ValueTuple<int, bool>> InstLevelInfo = new Dictionary<int, ValueTuple<int, bool>>();

		// Token: 0x04019ACA RID: 105162
		public List<int> InstKeyBuffList = new List<int>();

		// Token: 0x04019ACB RID: 105163
		public int InstBuffAcquireCount;

		// Token: 0x04019ACC RID: 105164
		[Nullable(2)]
		private static BossPilingModel _Instance;
	}
}
