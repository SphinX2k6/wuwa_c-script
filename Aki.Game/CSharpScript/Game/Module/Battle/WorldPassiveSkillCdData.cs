using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C61 RID: 23649
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldPassiveSkillCdData
	{
		// Token: 0x0603BC7C RID: 244860 RVA: 0x00E4709A File Offset: 0x00E4529A
		public void Clear()
		{
			this.EntitySkillCdMap.Clear();
			this.AllShareSkillCdData.Clear();
			this.OffRoleSkillCdMap.Clear();
		}

		// Token: 0x0603BC7D RID: 244861 RVA: 0x00E470C0 File Offset: 0x00E452C0
		public PassiveSkillCdInfo InitPassiveSkillCd(Entity entity, in PassiveSkill passiveSkill)
		{
			PassiveSkill passiveSkill2 = passiveSkill;
			float num = passiveSkill2.CdThreshold;
			if (num < 0f)
			{
				num = ConfigCommonParamById.GetFloatConfig("PassiveSkillCdThreshold").GetValueOrDefault();
			}
			passiveSkill2 = passiveSkill;
			long id = passiveSkill2.Id;
			passiveSkill2 = passiveSkill;
			float cdtime = passiveSkill2.CDTime;
			passiveSkill2 = passiveSkill;
			return this.InitSkillCdCommon(entity, id, cdtime, passiveSkill2.IsShareAllCdSkill, new float?(num));
		}

		// Token: 0x0603BC7E RID: 244862 RVA: 0x00E47130 File Offset: 0x00E45330
		public PassiveSkillCdInfo InitSkillCdCommon(Entity entity, long skillId, float skillCd, bool isShareAllCdSkill, float? threshold = null)
		{
			int id = entity.Id;
			PassiveSkillCdData passiveSkillCdData;
			if (isShareAllCdSkill)
			{
				passiveSkillCdData = this.AllShareSkillCdData;
			}
			else if (!this.EntitySkillCdMap.TryGetValue(id, out passiveSkillCdData))
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				if (component.IsRole())
				{
					int pbDataId = component.GetPbDataId();
					PassiveSkillCdData passiveSkillCdData2;
					if (this.OffRoleSkillCdMap.Remove(pbDataId, out passiveSkillCdData2))
					{
						passiveSkillCdData = passiveSkillCdData2;
					}
					else
					{
						passiveSkillCdData = new PassiveSkillCdData();
					}
				}
				else
				{
					passiveSkillCdData = new PassiveSkillCdData();
				}
				this.EntitySkillCdMap[id] = passiveSkillCdData;
			}
			PassiveSkillCdInfo passiveSkillCdInfo;
			if (!passiveSkillCdData.SkillCdInfoMap.TryGetValue(skillId, out passiveSkillCdInfo))
			{
				passiveSkillCdInfo = new PassiveSkillCdInfo
				{
					SkillId = skillId,
					SkillCd = skillCd,
					IsShareAllCdSkill = isShareAllCdSkill,
					CurMaxCd = 0f
				};
				if (threshold != null)
				{
					passiveSkillCdInfo.Threshold = threshold.Value;
				}
				long num;
				if (passiveSkillCdData.ServerSkillCd.Remove(skillId, out num))
				{
					double serverTimeStamp = Time.Instance.ServerTimeStamp;
					if ((double)num > serverTimeStamp)
					{
						passiveSkillCdInfo.SkillCdFinishStampMap[id] = Time.Instance.FlowTime + ((double)num - serverTimeStamp);
					}
				}
				passiveSkillCdData.SkillCdInfoMap[skillId] = passiveSkillCdInfo;
			}
			passiveSkillCdInfo.EntityIds.Add(entity.Id);
			return passiveSkillCdInfo;
		}

		// Token: 0x0603BC7F RID: 244863 RVA: 0x00E4725C File Offset: 0x00E4545C
		public void RemoveEntity(Entity entity)
		{
			int id = entity.Id;
			PassiveSkillCdData passiveSkillCdData;
			if (this.EntitySkillCdMap.Remove(id, out passiveSkillCdData))
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				if (component.IsRole())
				{
					int pbDataId = component.GetPbDataId();
					foreach (PassiveSkillCdInfo passiveSkillCdInfo in passiveSkillCdData.SkillCdInfoMap.Values)
					{
						passiveSkillCdInfo.EntityIds.Clear();
					}
					this.OffRoleSkillCdMap[pbDataId] = passiveSkillCdData;
				}
			}
			foreach (PassiveSkillCdInfo passiveSkillCdInfo2 in this.AllShareSkillCdData.SkillCdInfoMap.Values)
			{
				passiveSkillCdInfo2.EntityIds.Remove(id);
			}
		}

		// Token: 0x0603BC80 RID: 244864 RVA: 0x00E47344 File Offset: 0x00E45544
		public void HandlePassiveSkillNotify(PassiveSkillNotify notify)
		{
			double serverTimeStamp = Time.Instance.ServerTimeStamp;
			foreach (RolePassiveSkillInfo rolePassiveSkillInfo in notify.RolePassiveSkillInfoList)
			{
				ValueTuple<int?, PassiveSkillCdData> valueTuple = this.FindSkillCdDataByRoleId(rolePassiveSkillInfo.RoleId);
				int? item = valueTuple.Item1;
				PassiveSkillCdData passiveSkillCdData = valueTuple.Item2;
				if (passiveSkillCdData == null)
				{
					passiveSkillCdData = new PassiveSkillCdData();
					this.OffRoleSkillCdMap[rolePassiveSkillInfo.RoleId] = passiveSkillCdData;
				}
				foreach (PassiveSkillInfo passiveSkillInfo in rolePassiveSkillInfo.PassiveSkillInfoList)
				{
					long skillCdEndTime = passiveSkillInfo.SkillCdEndTime;
					if ((double)skillCdEndTime > serverTimeStamp)
					{
						long skillId = passiveSkillInfo.SkillId;
						PassiveSkillCdInfo valueOrDefault = passiveSkillCdData.SkillCdInfoMap.GetValueOrDefault(skillId);
						if (valueOrDefault != null && item != null)
						{
							valueOrDefault.SkillCdFinishStampMap.Remove(item.Value);
							valueOrDefault.SkillCdFinishStampMap[item.Value] = Time.Instance.FlowTime + ((double)skillCdEndTime - serverTimeStamp);
						}
						else
						{
							passiveSkillCdData.ServerSkillCd[skillId] = skillCdEndTime;
						}
					}
				}
			}
		}

		// Token: 0x0603BC81 RID: 244865 RVA: 0x00E474AC File Offset: 0x00E456AC
		[return: TupleElementNames(new string[]
		{
			"entityId",
			"skillCdData"
		})]
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private ValueTuple<int?, PassiveSkillCdData> FindSkillCdDataByRoleId(int roleId)
		{
			PassiveSkillCdData item;
			if (this.OffRoleSkillCdMap.TryGetValue(roleId, out item))
			{
				return new ValueTuple<int?, PassiveSkillCdData>(null, item);
			}
			foreach (KeyValuePair<int, PassiveSkillCdData> keyValuePair in this.EntitySkillCdMap)
			{
				int num;
				PassiveSkillCdData passiveSkillCdData;
				keyValuePair.Deconstruct(out num, out passiveSkillCdData);
				int num2 = num;
				PassiveSkillCdData item2 = passiveSkillCdData;
				EntityHandle handle = CharacterModel.Instance.GetHandle(num2);
				if (handle != null && handle.Valid)
				{
					CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
					if (component.IsRole() && component.GetPbDataId() == roleId)
					{
						return new ValueTuple<int?, PassiveSkillCdData>(new int?(num2), item2);
					}
				}
			}
			return new ValueTuple<int?, PassiveSkillCdData>(null, null);
		}

		// Token: 0x0401F211 RID: 127505
		public readonly Dictionary<int, PassiveSkillCdData> EntitySkillCdMap = new Dictionary<int, PassiveSkillCdData>();

		// Token: 0x0401F212 RID: 127506
		public readonly PassiveSkillCdData AllShareSkillCdData = new PassiveSkillCdData();

		// Token: 0x0401F213 RID: 127507
		public readonly Dictionary<int, PassiveSkillCdData> OffRoleSkillCdMap = new Dictionary<int, PassiveSkillCdData>();
	}
}
