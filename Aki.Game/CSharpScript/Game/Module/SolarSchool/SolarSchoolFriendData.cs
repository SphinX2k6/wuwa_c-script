using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058CF RID: 22735
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolFriendData : SolarSchoolRecordBase
	{
		// Token: 0x17006B64 RID: 27492
		// (get) Token: 0x06037FB7 RID: 229303 RVA: 0x00FA5F19 File Offset: 0x00FA4119
		public IReadOnlyCollection<SolarSchoolRoleData> Roles
		{
			get
			{
				return this.RoleMap.Values;
			}
		}

		// Token: 0x06037FB8 RID: 229304 RVA: 0x00FA5F28 File Offset: 0x00FA4128
		public void InitRoles()
		{
			this.LastMaxFavorReachedOrder = 0;
			this.RoleMap.Clear();
			int activityId = SolarSchoolGamePlayModel.Instance.GetActivityId();
			IReadOnlyList<SolarSchoolRole> allRoles = SolarSchoolConfig.Instance.GetAllRoles(activityId, ESolarSchoolRoleClassify.Normal);
			if (allRoles == null)
			{
				return;
			}
			foreach (SolarSchoolRole config in allRoles)
			{
				this.RoleMap[config.Id] = new SolarSchoolRoleData(config);
			}
		}

		// Token: 0x06037FB9 RID: 229305 RVA: 0x00FA5FB0 File Offset: 0x00FA41B0
		[NullableContext(2)]
		public SolarSchoolRoleData GetRoleData(int roleId)
		{
			return this.RoleMap.GetValueOrDefault(roleId);
		}

		// Token: 0x06037FBA RID: 229306 RVA: 0x00FA5FC0 File Offset: 0x00FA41C0
		public void FillTodayOptions(int activityId, int instanceId)
		{
			Dictionary<int, List<SolarSchoolOptions>> dictionary = new Dictionary<int, List<SolarSchoolOptions>>();
			SolarSchoolUtils.CollectOptionRows(activityId, instanceId, ESolarSchoolOptionOwnerType.Role, dictionary);
			foreach (KeyValuePair<int, SolarSchoolRoleData> keyValuePair in this.RoleMap)
			{
				keyValuePair.Value.SetOptionRows(dictionary.GetValueOrDefault(keyValuePair.Key));
			}
		}

		// Token: 0x06037FBB RID: 229307 RVA: 0x00FA6034 File Offset: 0x00FA4234
		public List<SolarSchoolOptionInfo> GetRoleOptions(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData != null)
			{
				return roleData.GetOptions();
			}
			return new List<SolarSchoolOptionInfo>();
		}

		// Token: 0x06037FBC RID: 229308 RVA: 0x00FA6058 File Offset: 0x00FA4258
		public bool IsRoleUnlocked(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			return roleData != null && roleData.IsUnlocked;
		}

		// Token: 0x06037FBD RID: 229309 RVA: 0x00FA606C File Offset: 0x00FA426C
		public bool UnlockRole(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null || !roleData.Unlock())
			{
				return false;
			}
			SolarSchoolController.Instance.EnqueueUnlockNpc(roleId);
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolFavorChanged, roleId);
			return true;
		}

		// Token: 0x06037FBE RID: 229310 RVA: 0x00FA60AB File Offset: 0x00FA42AB
		public int GetFavor(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0;
			}
			return roleData.FavorValue;
		}

		// Token: 0x06037FBF RID: 229311 RVA: 0x00FA60C0 File Offset: 0x00FA42C0
		public unsafe int AddFavor(int roleId, int delta)
		{
			if (delta == 0)
			{
				return this.GetFavor(roleId);
			}
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null || !roleData.IsUnlocked)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 好感增减失败：角色未解锁";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("delta", delta);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return 0;
			}
			int favorValue = roleData.FavorValue;
			int num = roleData.AddFavor(delta);
			if (num == favorValue)
			{
				return favorValue;
			}
			SolarSchoolController.Instance.EnqueueNpcFavorChange(roleId, num, roleData.FavorLevel);
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolFavorChanged, roleId);
			return num;
		}

		// Token: 0x06037FC0 RID: 229312 RVA: 0x00FA6186 File Offset: 0x00FA4386
		public int GetFavorLevel(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0;
			}
			return roleData.FavorLevel;
		}

		// Token: 0x06037FC1 RID: 229313 RVA: 0x00FA619C File Offset: 0x00FA439C
		public string GetFavorLevelText(int roleId)
		{
			string textId;
			switch (Math.Max(this.GetFavorLevel(roleId), 1))
			{
			case 1:
				textId = "SolarSchool_humanitiesClassFavor_1";
				break;
			case 2:
				textId = "SolarSchool_humanitiesClassFavor_2";
				break;
			case 3:
				textId = "SolarSchool_humanitiesClassFavor_3";
				break;
			default:
				textId = "SolarSchool_humanitiesClassFavor_4";
				break;
			}
			return SolarSchoolUtils.GetTextWithPlaceholder(textId);
		}

		// Token: 0x06037FC2 RID: 229314 RVA: 0x00FA61F4 File Offset: 0x00FA43F4
		public SolarSchoolRoleTalkInfo PickTalk(int roleId)
		{
			SolarSchoolGamePlayModel model = SolarSchoolGamePlayModel.Instance;
			int unviewedTalkBehaviorIdByRole = SolarSchoolSpecialBehaviorCenter.Instance.GetUnviewedTalkBehaviorIdByRole(roleId);
			if (unviewedTalkBehaviorIdByRole != 0)
			{
				SolarSchoolRoleTalk? solarSchoolRoleTalk = this.PickTalkRow(roleId, ESolarSchoolRoleTalkType.Special, (SolarSchoolRoleTalk _) => true);
				if (solarSchoolRoleTalk != null)
				{
					return this.CreateTalkInfo(solarSchoolRoleTalk.Value, unviewedTalkBehaviorIdByRole);
				}
			}
			int locationId = model.MapData.CurrentLocationId;
			SolarSchoolLocationRole locationRole = model.MapData.GetLocationRole(locationId);
			SolarSchoolRoleTalk? solarSchoolRoleTalk2 = (locationRole.IsResident && locationRole.RoleId == roleId) ? this.PickTalkRow(roleId, ESolarSchoolRoleTalkType.Resident, (SolarSchoolRoleTalk talk) => this.MatchLocation(talk, locationId)) : this.PickTalkRow(roleId, ESolarSchoolRoleTalkType.NonResident, (SolarSchoolRoleTalk talk) => talk.StartDayIndex <= model.TimeData.DayIndex && model.TimeData.DayIndex <= talk.EndDayIndex);
			if (solarSchoolRoleTalk2 != null)
			{
				return this.CreateTalkInfo(solarSchoolRoleTalk2.Value, 0);
			}
			return default(SolarSchoolRoleTalkInfo);
		}

		// Token: 0x06037FC3 RID: 229315 RVA: 0x00FA62FC File Offset: 0x00FA44FC
		private SolarSchoolRoleTalkInfo CreateTalkInfo(SolarSchoolRoleTalk row, int specialBehaviorId)
		{
			SolarSchoolRoleSpine? roleSpine = SolarSchoolConfig.Instance.GetRoleSpine(row.RoleSpineId);
			if (roleSpine != null)
			{
				return new SolarSchoolRoleTalkInfo(roleSpine.Value, specialBehaviorId);
			}
			return default(SolarSchoolRoleTalkInfo);
		}

		// Token: 0x06037FC4 RID: 229316 RVA: 0x00FA633C File Offset: 0x00FA453C
		private bool MatchLocation(SolarSchoolRoleTalk talk, int locationId)
		{
			for (int i = 0; i < talk.LocationIdListLength; i++)
			{
				if (talk.LocationIdList(i) == locationId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037FC5 RID: 229317 RVA: 0x00FA636C File Offset: 0x00FA456C
		private SolarSchoolRoleTalk? PickTalkRow(int roleId, ESolarSchoolRoleTalkType talkType, Func<SolarSchoolRoleTalk, bool> match)
		{
			IReadOnlyList<SolarSchoolRoleTalk> roleTalkList = SolarSchoolConfig.Instance.GetRoleTalkList(SolarSchoolGamePlayModel.Instance.ActivityId, roleId, talkType);
			if (roleTalkList == null)
			{
				return null;
			}
			List<SolarSchoolRoleTalk> list = new List<SolarSchoolRoleTalk>();
			foreach (SolarSchoolRoleTalk solarSchoolRoleTalk in roleTalkList)
			{
				if (match(solarSchoolRoleTalk))
				{
					list.Add(solarSchoolRoleTalk);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return new SolarSchoolRoleTalk?(list[RandomSystem.GetRandomInteger() % list.Count]);
		}

		// Token: 0x06037FC6 RID: 229318 RVA: 0x00FA6414 File Offset: 0x00FA4614
		public bool IsFavorValueFull(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			return roleData != null && roleData.IsFavorValueFull();
		}

		// Token: 0x06037FC7 RID: 229319 RVA: 0x00FA6428 File Offset: 0x00FA4628
		public bool IsFavorFrozen(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			return roleData != null && roleData.IsFavorFrozen();
		}

		// Token: 0x06037FC8 RID: 229320 RVA: 0x00FA643C File Offset: 0x00FA463C
		public int GetNextLevelPreUnlockConditionId(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0;
			}
			return roleData.GetNextLevelPreUnlockConditionId();
		}

		// Token: 0x06037FC9 RID: 229321 RVA: 0x00FA6450 File Offset: 0x00FA4650
		public bool IsFavorLevelMaxed(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			return roleData != null && roleData.IsFavorLevelMaxed();
		}

		// Token: 0x06037FCA RID: 229322 RVA: 0x00FA6464 File Offset: 0x00FA4664
		public int GetMaxFavorReachedOrder(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0;
			}
			return roleData.MaxFavorReachedOrder;
		}

		// Token: 0x06037FCB RID: 229323 RVA: 0x00FA6478 File Offset: 0x00FA4678
		public int GetGiftReceivedCount(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0;
			}
			return roleData.GiftReceivedCount;
		}

		// Token: 0x06037FCC RID: 229324 RVA: 0x00FA648C File Offset: 0x00FA468C
		public void RecordGiftReceived(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return;
			}
			roleData.AddGiftReceivedCount();
		}

		// Token: 0x06037FCD RID: 229325 RVA: 0x00FA64A0 File Offset: 0x00FA46A0
		public List<int> GetMaxFavorRoleIds()
		{
			List<SolarSchoolRoleData> list = new List<SolarSchoolRoleData>();
			foreach (SolarSchoolRoleData solarSchoolRoleData in this.RoleMap.Values)
			{
				if (solarSchoolRoleData.MaxFavorReachedOrder > 0)
				{
					list.Add(solarSchoolRoleData);
				}
			}
			list.Sort((SolarSchoolRoleData left, SolarSchoolRoleData right) => left.MaxFavorReachedOrder.CompareTo(right.MaxFavorReachedOrder));
			List<int> list2 = new List<int>(list.Count);
			foreach (SolarSchoolRoleData solarSchoolRoleData2 in list)
			{
				list2.Add(solarSchoolRoleData2.RoleId);
			}
			return list2;
		}

		// Token: 0x06037FCE RID: 229326 RVA: 0x00FA6580 File Offset: 0x00FA4780
		public int GetCurrentLevelFavorCap(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null)
			{
				return 0;
			}
			return roleData.GetCurrentLevelFavorCap();
		}

		// Token: 0x06037FCF RID: 229327 RVA: 0x00FA6594 File Offset: 0x00FA4794
		public bool LevelUp(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null || !roleData.LevelUp())
			{
				return false;
			}
			this.OnFavorLevelChanged(roleData);
			return true;
		}

		// Token: 0x06037FD0 RID: 229328 RVA: 0x00FA65C0 File Offset: 0x00FA47C0
		public bool GmSetMaxFavorLevel(int roleId)
		{
			SolarSchoolRoleData roleData = this.GetRoleData(roleId);
			if (roleData == null || !roleData.GmSetMaxFavorLevel())
			{
				return false;
			}
			this.OnFavorLevelChanged(roleData);
			return true;
		}

		// Token: 0x06037FD1 RID: 229329 RVA: 0x00FA65EC File Offset: 0x00FA47EC
		private void OnFavorLevelChanged(SolarSchoolRoleData role)
		{
			if (role.IsFavorLevelMaxed())
			{
				this.LastMaxFavorReachedOrder++;
				role.TrySetMaxFavorReachedOrder(this.LastMaxFavorReachedOrder);
			}
			SolarSchoolController.Instance.EnqueueNpcFavorChange(role.RoleId, role.FavorValue, role.FavorLevel);
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolFavorChanged, role.RoleId);
		}

		// Token: 0x06037FD2 RID: 229330 RVA: 0x00FA6650 File Offset: 0x00FA4850
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolCharacterDataPb solarSchoolCharacterDataPb = SolarSchoolCharacterDataPb.Create();
			foreach (KeyValuePair<int, SolarSchoolRoleData> keyValuePair in this.RoleMap)
			{
				if (keyValuePair.Value.IsUnlocked)
				{
					SolarSchoolNpcPb solarSchoolNpcPb = SolarSchoolNpcPb.Create();
					solarSchoolNpcPb.NpcId = keyValuePair.Key;
					solarSchoolNpcPb.Favor = keyValuePair.Value.FavorValue;
					solarSchoolNpcPb.FavorLevel = keyValuePair.Value.FavorLevel;
					solarSchoolNpcPb.MaxFavorReachedOrder = keyValuePair.Value.MaxFavorReachedOrder;
					solarSchoolNpcPb.GiftReceivedCount = keyValuePair.Value.GiftReceivedCount;
					solarSchoolCharacterDataPb.Npc.Add(solarSchoolNpcPb);
				}
			}
			gameData.Character = solarSchoolCharacterDataPb;
		}

		// Token: 0x06037FD3 RID: 229331 RVA: 0x00FA6724 File Offset: 0x00FA4924
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.LastMaxFavorReachedOrder = 0;
			if (gameData.Character == null)
			{
				return;
			}
			foreach (SolarSchoolNpcPb solarSchoolNpcPb in gameData.Character.Npc)
			{
				SolarSchoolRoleData roleData = this.GetRoleData(solarSchoolNpcPb.NpcId);
				if (roleData == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 读档角色不在配表中，已跳过";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("npcId", solarSchoolNpcPb.NpcId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					roleData.RestoreFromSave(solarSchoolNpcPb.Favor, solarSchoolNpcPb.FavorLevel, solarSchoolNpcPb.MaxFavorReachedOrder, solarSchoolNpcPb.GiftReceivedCount);
					this.LastMaxFavorReachedOrder = Math.Max(this.LastMaxFavorReachedOrder, solarSchoolNpcPb.MaxFavorReachedOrder);
				}
			}
		}

		// Token: 0x0401D873 RID: 120947
		private int LastMaxFavorReachedOrder;

		// Token: 0x0401D874 RID: 120948
		private readonly Dictionary<int, SolarSchoolRoleData> RoleMap = new Dictionary<int, SolarSchoolRoleData>();
	}
}
