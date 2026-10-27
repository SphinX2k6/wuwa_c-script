using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068C7 RID: 26823
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopLevelData
	{
		// Token: 0x170097D3 RID: 38867
		// (get) Token: 0x06042F33 RID: 274227 RVA: 0x0104E000 File Offset: 0x0104C200
		public bool IsShowDoingNew
		{
			get
			{
				return this.State == ECoopLevelStatus.Doing && !(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.CoopRoleNewLevelRedDot) as ServerStorageSet).Has(this.LevelId);
			}
		}

		// Token: 0x06042F34 RID: 274228 RVA: 0x0104E02C File Offset: 0x0104C22C
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

		// Token: 0x06042F35 RID: 274229 RVA: 0x0104E1D8 File Offset: 0x0104C3D8
		public void UpdateSubConditionState(CoopTaskCompleteInfo data)
		{
			foreach (CoopSubConditionDataBase coopSubConditionDataBase in this.CoopSubConditionDataDict.Values)
			{
				coopSubConditionDataBase.RefreshData(data);
			}
		}

		// Token: 0x06042F36 RID: 274230 RVA: 0x0104E230 File Offset: 0x0104C430
		public List<CoopSubConditionDataBase> GetSubConditionList()
		{
			return new List<CoopSubConditionDataBase>(this.CoopSubConditionDataDict.Values);
		}

		// Token: 0x06042F37 RID: 274231 RVA: 0x0104E244 File Offset: 0x0104C444
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

		// Token: 0x04022D29 RID: 142633
		public int LevelId;

		// Token: 0x04022D2A RID: 142634
		public int Level;

		// Token: 0x04022D2B RID: 142635
		public int RoleId;

		// Token: 0x04022D2C RID: 142636
		public ECoopLevelStatus State;

		// Token: 0x04022D2D RID: 142637
		public bool IsHaveSubCondition;

		// Token: 0x04022D2E RID: 142638
		public int SubConditionId;

		// Token: 0x04022D2F RID: 142639
		public Dictionary<ECoopSubConditionType, CoopSubConditionDataBase> CoopSubConditionDataDict = new Dictionary<ECoopSubConditionType, CoopSubConditionDataBase>();
	}
}
