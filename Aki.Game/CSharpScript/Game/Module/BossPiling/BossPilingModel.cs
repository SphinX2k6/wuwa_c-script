using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005C0C RID: 23564
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BossPilingModel : ModelBase
	{
		// Token: 0x0603B8BA RID: 243898 RVA: 0x00E32373 File Offset: 0x00E30573
		public BossPilingActivityData GetActivityData()
		{
			if (this.ActivityData == null)
			{
				this.ActivityData = BossPilingController.Instance.GetActivityData();
			}
			return this.ActivityData;
		}

		// Token: 0x0603B8BB RID: 243899 RVA: 0x00E32394 File Offset: 0x00E30594
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

		// Token: 0x0603B8BC RID: 243900 RVA: 0x00E325A4 File Offset: 0x00E307A4
		public bool CheckIsBossPiling()
		{
			InstanceDungeon? instanceDungeon;
			return ((GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().InstSubType : -1) == 55;
		}

		// Token: 0x0603B8BD RID: 243901 RVA: 0x00E325DC File Offset: 0x00E307DC
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

		// Token: 0x0603B8BE RID: 243902 RVA: 0x00E326A4 File Offset: 0x00E308A4
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

		// Token: 0x17008DA9 RID: 36265
		// (get) Token: 0x0603B8BF RID: 243903 RVA: 0x00E32707 File Offset: 0x00E30907
		public static BossPilingModel Instance
		{
			get
			{
				return BossPilingModel._Instance;
			}
		}

		// Token: 0x0603B8C0 RID: 243904 RVA: 0x00E3270E File Offset: 0x00E3090E
		public static BossPilingModel GetOrCreateInstance()
		{
			if (BossPilingModel._Instance == null)
			{
				BossPilingModel.CreateInstance();
			}
			return BossPilingModel._Instance;
		}

		// Token: 0x0603B8C1 RID: 243905 RVA: 0x00E32722 File Offset: 0x00E30922
		public static bool CreateInstance()
		{
			if (BossPilingModel._Instance != null)
			{
				return true;
			}
			BossPilingModel._Instance = new BossPilingModel();
			return true;
		}

		// Token: 0x0603B8C2 RID: 243906 RVA: 0x00E32738 File Offset: 0x00E30938
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B8C3 RID: 243907 RVA: 0x00E3273A File Offset: 0x00E3093A
		public static void ResetStaticDefaultValue()
		{
			BossPilingModel._Instance = null;
		}

		// Token: 0x0603B8C4 RID: 243908 RVA: 0x00E32742 File Offset: 0x00E30942
		static BossPilingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingModel.CreateStaticDefaultValue), new Action(BossPilingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0603B8C6 RID: 243910 RVA: 0x00E3277F File Offset: 0x00E3097F
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

		// Token: 0x0401F017 RID: 126999
		[Nullable(2)]
		protected BossPilingActivityData ActivityData;

		// Token: 0x0401F018 RID: 127000
		[Nullable(new byte[]
		{
			1,
			0
		})]
		protected Dictionary<int, ValueTuple<int, bool>> InstLevelInfo = new Dictionary<int, ValueTuple<int, bool>>();

		// Token: 0x0401F019 RID: 127001
		public List<int> InstKeyBuffList = new List<int>();

		// Token: 0x0401F01A RID: 127002
		public int InstBuffAcquireCount;

		// Token: 0x0401F01B RID: 127003
		[Nullable(2)]
		private static BossPilingModel _Instance;
	}
}
