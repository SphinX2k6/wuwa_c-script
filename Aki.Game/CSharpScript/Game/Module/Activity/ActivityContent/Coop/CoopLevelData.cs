using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005817 RID: 22551
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopLevelData
	{
		// Token: 0x17006B13 RID: 27411
		// (get) Token: 0x06037A8B RID: 227979 RVA: 0x00F8F628 File Offset: 0x00F8D828
		public bool IsShowDoingNew
		{
			get
			{
				return this.State == ECoopLevelStatus.Doing && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.CoopRoleNewLevelRedDot) as ServerStorageSet).Has(this.LevelId);
			}
		}

		// Token: 0x06037A8C RID: 227980 RVA: 0x00F8F654 File Offset: 0x00F8D854
		public CoopLevelData(int id)
		{
			this.LevelId = id;
			CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(id);
			this.Level = coopConfigById.Value.CoopLevel;
			this.RoleId = coopConfigById.Value.CoopRoleId;
			CoopRoleLevel? coopConfigById2 = CoopConfig.Instance.GetCoopConfigById(id);
			this.SubConditionId = coopConfigById2.Value.TaskGroupId;
			this.IsHaveSubCondition = (coopConfigById2.Value.TaskGroupId != 0);
			if (this.IsHaveSubCondition)
			{
				CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.SubConditionId);
				if (coopTaskConfigById.Value.CoopPreQuest != 0)
				{
					CoopPreTaskSubConditionData value = new CoopPreTaskSubConditionData(this.SubConditionId, ECoopSubConditionType.ECoopPreTaskSubConditionData);
					this.CoopSubConditionDataDict.Add(ECoopSubConditionType.ECoopPreTaskSubConditionData, value);
				}
				if (!string.IsNullOrEmpty(coopTaskConfigById.Value.TaskTitle2))
				{
					CoopProgressSubConditionData value2 = new CoopProgressSubConditionData(this.SubConditionId, ECoopSubConditionType.ECoopProgressSubConditionData);
					this.CoopSubConditionDataDict.Add(ECoopSubConditionType.ECoopProgressSubConditionData, value2);
				}
				if (!string.IsNullOrEmpty(coopTaskConfigById.Value.TaskTitle3))
				{
					CoopMapTaskSubConditionData1 value3 = new CoopMapTaskSubConditionData1(this.SubConditionId, ECoopSubConditionType.ECoopMapTaskSubConditionData1);
					this.CoopSubConditionDataDict.Add(ECoopSubConditionType.ECoopMapTaskSubConditionData1, value3);
				}
				if (!string.IsNullOrEmpty(coopTaskConfigById.Value.TaskTitle4))
				{
					CoopMapTaskSubConditionData2 value4 = new CoopMapTaskSubConditionData2(this.SubConditionId, ECoopSubConditionType.ECoopMapTaskSubConditionData2);
					this.CoopSubConditionDataDict.Add(ECoopSubConditionType.ECoopMapTaskSubConditionData2, value4);
				}
				if (!string.IsNullOrEmpty(coopTaskConfigById.Value.TaskTitle5))
				{
					CoopTimeMapTaskSubConditionData value5 = new CoopTimeMapTaskSubConditionData(this.SubConditionId, ECoopSubConditionType.ECoopTimeMapTaskSubConditionData);
					this.CoopSubConditionDataDict.Add(ECoopSubConditionType.ECoopTimeMapTaskSubConditionData, value5);
				}
			}
		}

		// Token: 0x06037A8D RID: 227981 RVA: 0x00F8F800 File Offset: 0x00F8DA00
		public void UpdateSubConditionState(CoopTaskCompleteInfo data)
		{
			foreach (CoopSubConditionDataBase coopSubConditionDataBase in this.CoopSubConditionDataDict.Values)
			{
				coopSubConditionDataBase.RefreshData(data);
			}
		}

		// Token: 0x06037A8E RID: 227982 RVA: 0x00F8F858 File Offset: 0x00F8DA58
		public List<CoopSubConditionDataBase> GetSubConditionList()
		{
			return new List<CoopSubConditionDataBase>(this.CoopSubConditionDataDict.Values);
		}

		// Token: 0x06037A8F RID: 227983 RVA: 0x00F8F86C File Offset: 0x00F8DA6C
		public bool IsAllSubConditionDone()
		{
			if (!this.IsHaveSubCondition)
			{
				return true;
			}
			using (Dictionary<ECoopSubConditionType, CoopSubConditionDataBase>.ValueCollection.Enumerator enumerator = this.CoopSubConditionDataDict.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsTaskDone())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0401D585 RID: 120197
		public int LevelId;

		// Token: 0x0401D586 RID: 120198
		public int Level;

		// Token: 0x0401D587 RID: 120199
		public int RoleId;

		// Token: 0x0401D588 RID: 120200
		public ECoopLevelStatus State;

		// Token: 0x0401D589 RID: 120201
		public bool IsHaveSubCondition;

		// Token: 0x0401D58A RID: 120202
		public int SubConditionId;

		// Token: 0x0401D58B RID: 120203
		public Dictionary<ECoopSubConditionType, CoopSubConditionDataBase> CoopSubConditionDataDict = new Dictionary<ECoopSubConditionType, CoopSubConditionDataBase>();
	}
}
