using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068EF RID: 26863
	public class CoopProgressSubConditionData : CoopSubConditionDataBase
	{
		// Token: 0x0604300A RID: 274442 RVA: 0x01052248 File Offset: 0x01050448
		public CoopProgressSubConditionData(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle2 ?? "");
		}

		// Token: 0x0604300B RID: 274443 RVA: 0x01052294 File Offset: 0x01050494
		public override bool IsShowJumpBtn()
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.Id);
			return coopTaskConfigById != null && (coopTaskConfigById.Value.ItemId != 0 || coopTaskConfigById.Value.Condition2MapId != 0);
		}

		// Token: 0x0604300C RID: 274444 RVA: 0x010522E2 File Offset: 0x010504E2
		public override bool IsTaskDone()
		{
			if (this.Target == 0)
			{
				return this.IsDone;
			}
			return this.Current >= this.Target;
		}

		// Token: 0x0604300D RID: 274445 RVA: 0x01052304 File Offset: 0x01050504
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			ConditionTask task = data.Task;
			this.Current = ((task != null) ? task.Current : 0);
			ConditionTask task2 = data.Task;
			this.Target = ((task2 != null) ? task2.Target : 0);
			ConditionTask task3 = data.Task;
			this.IsDone = (task3 != null && task3.Status == ConditionTaskState.ConditionTaskFinish);
		}

		// Token: 0x0604300E RID: 274446 RVA: 0x0105235C File Offset: 0x0105055C
		public override void OnJumpClick()
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.Id);
			if (coopTaskConfigById != null && coopTaskConfigById.Value.ItemId != 0)
			{
				SkipTaskManager.RunByConfigId(840001, coopTaskConfigById.Value.ItemId);
			}
			if (coopTaskConfigById != null && coopTaskConfigById.Value.Condition2MapId != 0 && coopTaskConfigById.Value.Condition2MarkId != 0)
			{
				OneOf<MapMark, DynamicMapMark> value = MapConfig.Instance.SearchMarkConfig(coopTaskConfigById.Value.Condition2MarkId).Value;
				WorldMapViewOpenParams data;
				if (value.IsT1)
				{
					data = new WorldMapViewOpenParams
					{
						MarkType = (EMarkType)value.AsT1.ObjectType,
						MarkId = new int?(value.AsT1.MarkId),
						OpenFogId = new int?(0)
					};
				}
				else
				{
					data = new WorldMapViewOpenParams
					{
						MarkType = (EMarkType)value.AsT2.ObjectType,
						MarkId = new int?(value.AsT2.MarkId),
						OpenFogId = new int?(0)
					};
				}
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			}
		}

		// Token: 0x04022E23 RID: 142883
		private bool IsDone;
	}
}
