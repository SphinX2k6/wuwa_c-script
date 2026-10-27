using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C64 RID: 23652
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldSkillCdData
	{
		// Token: 0x0603BC8C RID: 244876 RVA: 0x00E478DB File Offset: 0x00E45ADB
		public void Clear()
		{
			this.EntitySkillCdMap.Clear();
			this.AllShareSkillCdData.Clear();
			this.OffRoleSkillCdMap.Clear();
			this.MultiSkillMap.Clear();
		}

		// Token: 0x0603BC8D RID: 244877 RVA: 0x00E4790C File Offset: 0x00E45B0C
		public GroupSkillCdInfo InitSkillCd(Entity entity, int skillId, SSkillInfo skillInfo)
		{
			SSkillCooldownInfo cooldownConfig = skillInfo.CooldownConfig;
			return this.InitSkillCdCommon(entity, skillId, cooldownConfig.CdTime, cooldownConfig.CdDelay, cooldownConfig.MaxCount, cooldownConfig.ShareGroupId, cooldownConfig.IsShareAllCdSkill, cooldownConfig.CdTags);
		}

		// Token: 0x0603BC8E RID: 244878 RVA: 0x00E4794C File Offset: 0x00E45B4C
		public GroupSkillCdInfo InitSkillCdCommon(Entity entity, int skillId, float skillCd, float cdDelay, int maxCount, int shareGroupId, bool isShareAllCdSkill, TArray<FGameplayTag> cdTags)
		{
			SkillCdData skillCdData;
			if (isShareAllCdSkill)
			{
				skillCdData = this.AllShareSkillCdData;
			}
			else
			{
				int id = entity.Id;
				if (!this.EntitySkillCdMap.TryGetValue(id, out skillCdData))
				{
					CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
					if (component.IsRole())
					{
						int pbDataId = component.GetPbDataId();
						SkillCdData skillCdData2;
						if (this.OffRoleSkillCdMap.Remove((long)pbDataId, out skillCdData2))
						{
							skillCdData = skillCdData2;
						}
						else
						{
							skillCdData = new SkillCdData();
						}
					}
					else
					{
						skillCdData = new SkillCdData();
					}
					skillCdData.NeedTick = true;
					this.EntitySkillCdMap[id] = skillCdData;
				}
			}
			int num;
			if (skillCdData.SkillId2GroupIdMap.TryGetValue(skillId, out num))
			{
				GroupSkillCdInfo groupSkillCdInfo = skillCdData.GroupSkillCdInfoMap[num];
				groupSkillCdInfo.SkillCdInfoMap[skillId].SkillCd = skillCd;
				groupSkillCdInfo.EntityIds.Add(entity.Id);
				return groupSkillCdInfo;
			}
			if (shareGroupId != 0 && shareGroupId < 1000)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "自定义的冷却组不能小于1000";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			num = skillCdData.GenerateCdShareGroupId(shareGroupId);
			GroupSkillCdInfo groupSkillCdInfo2;
			if (!skillCdData.GroupSkillCdInfoMap.TryGetValue(num, out groupSkillCdInfo2))
			{
				groupSkillCdInfo2 = new GroupSkillCdInfo
				{
					GroupId = num,
					CurMaxCd = 0f,
					ConfigMaxCount = maxCount,
					LimitCountModify = maxCount,
					LimitCountAdd = 0,
					LimitCount = maxCount,
					RemainingCount = maxCount
				};
				for (int i = cdTags.Num() - 1; i >= 0; i--)
				{
					groupSkillCdInfo2.CdTags.Add(cdTags.Get(i).TagId());
				}
				if (shareGroupId != 0)
				{
					this.HandleServerCd(skillCdData.ServerGroupSkillCd, shareGroupId, groupSkillCdInfo2, skillId);
				}
				else
				{
					this.HandleServerCd(skillCdData.ServerSkillCd, skillId, groupSkillCdInfo2, skillId);
				}
				skillCdData.GroupSkillCdInfoMap[num] = groupSkillCdInfo2;
			}
			SkillCdInfo skillCdInfo = new SkillCdInfo
			{
				SkillId = skillId,
				SkillCd = skillCd,
				CdDelay = cdDelay,
				IsShareAllCdSkill = isShareAllCdSkill
			};
			if (maxCount != groupSkillCdInfo2.ConfigMaxCount)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "同一个冷却组的技能，可使用次数配置不一致";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("skillId", skillCdInfo.SkillId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			groupSkillCdInfo2.SkillCdInfoMap[skillId] = skillCdInfo;
			skillCdData.SkillId2GroupIdMap[skillId] = num;
			groupSkillCdInfo2.EntityIds.Add(entity.Id);
			return groupSkillCdInfo2;
		}

		// Token: 0x0603BC8F RID: 244879 RVA: 0x00E47B98 File Offset: 0x00E45D98
		private void HandleServerCd(Dictionary<int, List<long>> serverCdMap, int key, GroupSkillCdInfo groupSkillCdInfo, int skillId)
		{
			List<long> list;
			if (!serverCdMap.TryGetValue(key, out list))
			{
				return;
			}
			if (list.Count > 0)
			{
				double serverTimeStamp = Time.Instance.ServerTimeStamp;
				int num = 0;
				long num2 = 0L;
				foreach (long num3 in list)
				{
					if ((double)num3 > serverTimeStamp)
					{
						num++;
						if (num == 1)
						{
							groupSkillCdInfo.StartSkillCdTimer(skillId, (float)(((double)num3 - serverTimeStamp) * TimeUtil.Instance.Millisecond));
						}
						else
						{
							groupSkillCdInfo.SkillIdQueue.Push(skillId);
							groupSkillCdInfo.CdQueue.Push((float)((double)(num3 - num2) * TimeUtil.Instance.Millisecond));
						}
						num2 = num3;
					}
				}
				groupSkillCdInfo.RemainingCount -= num;
				groupSkillCdInfo.OnCountChanged();
			}
			serverCdMap.Remove(key);
		}

		// Token: 0x0603BC90 RID: 244880 RVA: 0x00E47C7C File Offset: 0x00E45E7C
		public MultiSkillData InitMultiSkill(int entityId)
		{
			MultiSkillData multiSkillData;
			if (this.MultiSkillMap.TryGetValue(entityId, out multiSkillData))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "重复初始化多段技能";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return multiSkillData;
			}
			multiSkillData = new MultiSkillData();
			this.MultiSkillMap[entityId] = multiSkillData;
			return multiSkillData;
		}

		// Token: 0x0603BC91 RID: 244881 RVA: 0x00E47CDC File Offset: 0x00E45EDC
		public void RemoveEntity(Entity entity)
		{
			int id = entity.Id;
			SkillCdData skillCdData;
			if (this.EntitySkillCdMap.Remove(id, out skillCdData))
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				if (component.IsRole())
				{
					int pbDataId = component.GetPbDataId();
					foreach (GroupSkillCdInfo groupSkillCdInfo in skillCdData.GroupSkillCdInfoMap.Values)
					{
						groupSkillCdInfo.EntityIds.Clear();
					}
					this.OffRoleSkillCdMap[(long)pbDataId] = skillCdData;
				}
			}
			foreach (GroupSkillCdInfo groupSkillCdInfo2 in this.AllShareSkillCdData.GroupSkillCdInfoMap.Values)
			{
				groupSkillCdInfo2.EntityIds.Remove(id);
			}
			this.RemoveMultiSkill(id);
		}

		// Token: 0x0603BC92 RID: 244882 RVA: 0x00E47DCC File Offset: 0x00E45FCC
		public void RemoveMultiSkill(int entityId)
		{
			this.MultiSkillMap.Remove(entityId);
		}

		// Token: 0x0603BC93 RID: 244883 RVA: 0x00E47DDC File Offset: 0x00E45FDC
		public void HandlePlayerSkillInfoPbNotify(PlayerSkillInfoPbNotify notify)
		{
			if (notify.PlayerSkillInfoPb == null)
			{
				return;
			}
			SkillInfoPb roleCommonSkillInfoPb = notify.PlayerSkillInfoPb.RoleCommonSkillInfoPb;
			if (roleCommonSkillInfoPb != null)
			{
				this.HandlePlayerSkillInfoPb(this.AllShareSkillCdData, roleCommonSkillInfoPb);
			}
			foreach (RoleSkillInfoPb roleSkillInfoPb in notify.PlayerSkillInfoPb.RoleSkillInfoPbList)
			{
				if (roleSkillInfoPb.SkillInfoPb != null)
				{
					SkillCdData skillCdData = this.FindSkillCdDataByRoleId((long)roleSkillInfoPb.RoleEntityConfigId);
					if (skillCdData == null)
					{
						skillCdData = new SkillCdData();
						this.OffRoleSkillCdMap[(long)roleSkillInfoPb.RoleEntityConfigId] = skillCdData;
					}
					this.HandlePlayerSkillInfoPb(skillCdData, roleSkillInfoPb.SkillInfoPb);
				}
			}
		}

		// Token: 0x0603BC94 RID: 244884 RVA: 0x00E47E8C File Offset: 0x00E4608C
		private void HandlePlayerSkillInfoPb(SkillCdData skillCdData, SkillInfoPb skillInfoPb)
		{
			long curTimeMs = (long)Time.Instance.ServerTimeStamp;
			foreach (SkillCdInfo skillCdInfo in skillInfoPb.SkillCdInfoList)
			{
				this.SaveServerSkillCd(skillCdInfo, curTimeMs, skillCdData.ServerSkillCd, (int)skillCdInfo.SkillId);
				this.UpdateSkillCdBySeverCd(skillCdData, skillCdInfo, 0);
			}
			foreach (SkillCdGroupInfo skillCdGroupInfo in skillInfoPb.SkillCdGroupInfoList)
			{
				SkillCdInfo skillCdInfo2 = skillCdGroupInfo.SkillCdInfo;
				if (skillCdInfo2 != null)
				{
					this.SaveServerSkillCd(skillCdInfo2, curTimeMs, skillCdData.ServerGroupSkillCd, skillCdGroupInfo.ShareGroupId);
					this.UpdateSkillCdBySeverCd(skillCdData, skillCdInfo2, skillCdGroupInfo.ShareGroupId);
				}
			}
		}

		// Token: 0x0603BC95 RID: 244885 RVA: 0x00E47F68 File Offset: 0x00E46168
		private bool UpdateSkillCdBySeverCd(SkillCdData skillCdData, SkillCdInfo skillCdInfo, int shareGroupId = 0)
		{
			int num = (int)skillCdInfo.SkillId;
			int key;
			if (!skillCdData.SkillId2GroupIdMap.TryGetValue(num, out key))
			{
				return false;
			}
			GroupSkillCdInfo groupSkillCdInfo;
			if (!skillCdData.GroupSkillCdInfoMap.TryGetValue(key, out groupSkillCdInfo))
			{
				return false;
			}
			if (shareGroupId != 0)
			{
				this.HandleServerCd(skillCdData.ServerSkillCd, shareGroupId, groupSkillCdInfo, num);
			}
			else
			{
				this.HandleServerCd(skillCdData.ServerSkillCd, num, groupSkillCdInfo, num);
			}
			return true;
		}

		// Token: 0x0603BC96 RID: 244886 RVA: 0x00E47FC8 File Offset: 0x00E461C8
		private void SaveServerSkillCd(SkillCdInfo skillCdInfo, long curTimeMs, Dictionary<int, List<long>> saveMap, int key)
		{
			List<long> list = new List<long>();
			foreach (long num in skillCdInfo.CdEndTimeList)
			{
				if (num > curTimeMs)
				{
					list.Add(num);
				}
			}
			if (list.Count > 0)
			{
				if (list.Count > 1)
				{
					list.Sort((long a, long b) => a.CompareTo(b));
				}
				saveMap[key] = list;
			}
		}

		// Token: 0x0603BC97 RID: 244887 RVA: 0x00E48060 File Offset: 0x00E46260
		[NullableContext(2)]
		private SkillCdData FindSkillCdDataByRoleId(long roleId)
		{
			SkillCdData result;
			if (this.OffRoleSkillCdMap.TryGetValue(roleId, out result))
			{
				return result;
			}
			foreach (KeyValuePair<int, SkillCdData> keyValuePair in this.EntitySkillCdMap)
			{
				int num;
				SkillCdData skillCdData;
				keyValuePair.Deconstruct(out num, out skillCdData);
				int id = num;
				SkillCdData skillCdData2 = skillCdData;
				EntityHandle handle = CharacterModel.Instance.GetHandle(id);
				if (handle != null && handle.Valid)
				{
					WorldEntity entity = handle.Entity;
					if (skillCdData2 != null)
					{
						CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
						if (component.IsRole() && (long)component.GetPbDataId() == roleId)
						{
							return skillCdData2;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0401F222 RID: 127522
		private const int MIN_SHARE_GROUP_ID = 1000;

		// Token: 0x0401F223 RID: 127523
		public readonly Dictionary<int, SkillCdData> EntitySkillCdMap = new Dictionary<int, SkillCdData>();

		// Token: 0x0401F224 RID: 127524
		public readonly SkillCdData AllShareSkillCdData = new SkillCdData();

		// Token: 0x0401F225 RID: 127525
		public readonly Dictionary<long, SkillCdData> OffRoleSkillCdMap = new Dictionary<long, SkillCdData>();

		// Token: 0x0401F226 RID: 127526
		public readonly Dictionary<int, MultiSkillData> MultiSkillMap = new Dictionary<int, MultiSkillData>();
	}
}
