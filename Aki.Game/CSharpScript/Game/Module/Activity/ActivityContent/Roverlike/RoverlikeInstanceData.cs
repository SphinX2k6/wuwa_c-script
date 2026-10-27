using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060DC RID: 24796
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeInstanceData
	{
		// Token: 0x1700912A RID: 37162
		// (get) Token: 0x0603EAF8 RID: 256760 RVA: 0x00F23CCB File Offset: 0x00F21ECB
		public int CurLayer
		{
			get
			{
				return this.CurLayerInternal;
			}
		}

		// Token: 0x1700912B RID: 37163
		// (get) Token: 0x0603EAF9 RID: 256761 RVA: 0x00F23CD3 File Offset: 0x00F21ED3
		public int MaxLayer
		{
			get
			{
				return this.MaxLayerInternal;
			}
		}

		// Token: 0x1700912C RID: 37164
		// (get) Token: 0x0603EAFA RID: 256762 RVA: 0x00F23CDB File Offset: 0x00F21EDB
		public int CurRoomId
		{
			get
			{
				return this.CurRoomIdInternal;
			}
		}

		// Token: 0x1700912D RID: 37165
		// (get) Token: 0x0603EAFB RID: 256763 RVA: 0x00F23CE3 File Offset: 0x00F21EE3
		public int CurRoomTypeId
		{
			get
			{
				return this.CurRoomTypeIdInternal;
			}
		}

		// Token: 0x0603EAFC RID: 256764 RVA: 0x00F23CEB File Offset: 0x00F21EEB
		public static RoverlikeInstanceData Create()
		{
			return new RoverlikeInstanceData();
		}

		// Token: 0x0603EAFD RID: 256765 RVA: 0x00F23CF4 File Offset: 0x00F21EF4
		public void InitFromNotify(RoverRogueInfoNotify notify)
		{
			this.Clear();
			if (notify.Bless != null)
			{
				foreach (RoverRogueGainEntry roverRogueGainEntry in notify.Bless)
				{
					this.IncIdToGainTypeMap[roverRogueGainEntry.IncId] = RoverRogueGainDataType.RoverRogueGainBless;
					this.BlessMap[roverRogueGainEntry.IncId] = new RoverlikeGainEntry(roverRogueGainEntry);
				}
			}
			if (notify.RoleEnhance != null)
			{
				foreach (RoverRogueGainEntry roverRogueGainEntry2 in notify.RoleEnhance)
				{
					this.IncIdToGainTypeMap[roverRogueGainEntry2.IncId] = RoverRogueGainDataType.RoverRogueGainRoleEnhance;
					this.RoleEnhanceMap[roverRogueGainEntry2.IncId] = new RoverlikeGainEntry(roverRogueGainEntry2);
				}
			}
			if (notify.LootItem != null)
			{
				foreach (RoverRogueGainEntry roverRogueGainEntry3 in notify.LootItem)
				{
					this.IncIdToGainTypeMap[roverRogueGainEntry3.IncId] = RoverRogueGainDataType.RoverRogueGainLootItem;
					this.LootItemMap[roverRogueGainEntry3.IncId] = new RoverlikeLootGainEntry(roverRogueGainEntry3);
				}
			}
			if (notify.Item != null)
			{
				foreach (RoverRogueGainEntry roverRogueGainEntry4 in notify.Item)
				{
					this.IncIdToGainTypeMap[roverRogueGainEntry4.IncId] = RoverRogueGainDataType.RoverRogueGainItem;
					this.ItemMap[roverRogueGainEntry4.IncId] = new RoverlikeGainEntry(roverRogueGainEntry4);
				}
			}
			this.RoleType = notify.RoverType;
			this.InitRoadType(notify.RoverRogueRoadType);
		}

		// Token: 0x0603EAFE RID: 256766 RVA: 0x00F23EC0 File Offset: 0x00F220C0
		private void InitRoadType(int roadType)
		{
			this.RoadTypeId = roadType;
			IReadOnlyList<RoverRogueRoad> roadByRoadType = RoverlikeConfig.Instance.GetRoadByRoadType(roadType);
			int num = -1;
			for (int i = 0; i < roadByRoadType.Count; i++)
			{
				RoverRogueRoad roverRogueRoad = roadByRoadType[i];
				if (roverRogueRoad.Floor != num)
				{
					num = roverRogueRoad.Floor;
					this.RoadLayerIndexList.Add(i);
				}
			}
		}

		// Token: 0x0603EAFF RID: 256767 RVA: 0x00F23F1C File Offset: 0x00F2211C
		public unsafe void UpdateRoomUpdateInfo(RoverRogueRoomInfoNotify notify)
		{
			this.CurLayerInternal = notify.CurLayer;
			this.MaxLayerInternal = notify.MaxLayer;
			this.CurRoomIdInternal = notify.RoomId;
			this.CurRoomTypeIdInternal = notify.RoomTypeId;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Roverlike;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[俯视角肉鸽] 房间信息变更";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoomId", this.CurRoomIdInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoomTypeId", this.CurRoomTypeIdInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Progress", this.CurLayerInternal.ToString() + "/" + this.MaxLayerInternal.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0603EB00 RID: 256768 RVA: 0x00F23FFA File Offset: 0x00F221FA
		public void Clear()
		{
			this.BlessMap.Clear();
			this.RoleEnhanceMap.Clear();
			this.LootItemMap.Clear();
			this.ItemMap.Clear();
			this.BlessVoicePool.Clear();
			this.StopAudio();
		}

		// Token: 0x0603EB01 RID: 256769 RVA: 0x00F2403C File Offset: 0x00F2223C
		public unsafe void PlayBlessRoleVoice(int roleId)
		{
			int? num = this.DrawBlessVoiceId(roleId);
			if (num == null)
			{
				return;
			}
			FavorWord? favorWordConfigById = RoleFavorConfig.Instance.GetFavorWordConfigById(num.Value);
			if (favorWordConfigById == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Roverlike;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[俯视角肉鸽] 祝福角色语音播放";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VoiceId", num.Value);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			string voice = favorWordConfigById.Value.Voice;
			if (StringUtils.IsEmpty(voice))
			{
				return;
			}
			this.PlayAudio(voice, null);
		}

		// Token: 0x0603EB02 RID: 256770 RVA: 0x00F24100 File Offset: 0x00F22300
		private int? DrawBlessVoiceId(int roleId)
		{
			List<int> list;
			this.BlessVoicePool.TryGetValue(roleId, out list);
			if (list == null || list.Count == 0)
			{
				RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(roleId);
				int[] array = (blessRoleConfig != null) ? blessRoleConfig.GetValueOrDefault().BlessVoice() : null;
				if (array == null || array.Length == 0)
				{
					return null;
				}
				list = new List<int>();
				foreach (int item in array)
				{
					list.Add(item);
				}
				this.BlessVoicePool[roleId] = list;
			}
			int index = Random.Shared.Next(list.Count);
			int value = list[index];
			list.RemoveAt(index);
			return new int?(value);
		}

		// Token: 0x0603EB03 RID: 256771 RVA: 0x00F241BE File Offset: 0x00F223BE
		public void PlayAudio(string eventPath, [Nullable(2)] Action finishCallback = null)
		{
			this.DialogLogic.PlayAudio(eventPath, finishCallback);
		}

		// Token: 0x0603EB04 RID: 256772 RVA: 0x00F241CD File Offset: 0x00F223CD
		public void StopAudio()
		{
			this.DialogLogic.Stop();
		}

		// Token: 0x0603EB05 RID: 256773 RVA: 0x00F241DC File Offset: 0x00F223DC
		public void ApplyGainDataUpdate(RoverRogueGainDataUpdateNotify notify)
		{
			foreach (int key in notify.RemoveIncIds)
			{
				RoverRogueGainDataType value;
				RoverRogueGainDataType? type = this.IncIdToGainTypeMap.TryGetValue(key, out value) ? new RoverRogueGainDataType?(value) : null;
				Dictionary<int, RoverlikeGainEntry> gainMapByType = this.GetGainMapByType(type);
				if (gainMapByType != null)
				{
					gainMapByType.Remove(key);
				}
				this.IncIdToGainTypeMap.Remove(key);
			}
			foreach (RoverRogueGainEntry roverRogueGainEntry in notify.Adds)
			{
				RoverRogueGainDataType type2 = roverRogueGainEntry.Type;
				Dictionary<int, RoverlikeGainEntry> gainMapByType2 = this.GetGainMapByType(new RoverRogueGainDataType?(type2));
				RoverlikeGainEntry roverlikeGainEntry = this.CreateGainEntry(roverRogueGainEntry, new RoverRogueGainDataType?(type2));
				if (gainMapByType2 != null)
				{
					gainMapByType2[roverRogueGainEntry.IncId] = roverlikeGainEntry;
				}
				this.IncIdToGainTypeMap[roverRogueGainEntry.IncId] = type2;
				this.ExtraGainNewTipsCheck(roverlikeGainEntry);
			}
			foreach (RoverRogueGainEntry roverRogueGainEntry2 in notify.Updates)
			{
				RoverRogueGainDataType value2;
				RoverRogueGainDataType? type3 = this.IncIdToGainTypeMap.TryGetValue(roverRogueGainEntry2.IncId, out value2) ? new RoverRogueGainDataType?(value2) : null;
				Dictionary<int, RoverlikeGainEntry> gainMapByType3 = this.GetGainMapByType(type3);
				if (gainMapByType3 != null)
				{
					RoverlikeGainEntry roverlikeGainEntry2;
					RoverlikeGainEntry lastEntry = gainMapByType3.TryGetValue(roverRogueGainEntry2.IncId, out roverlikeGainEntry2) ? roverlikeGainEntry2 : null;
					RoverlikeGainEntry roverlikeGainEntry3 = this.CreateGainEntry(roverRogueGainEntry2, type3);
					gainMapByType3[roverRogueGainEntry2.IncId] = roverlikeGainEntry3;
					this.ExtraGainUpdateTipsCheck(lastEntry, roverlikeGainEntry3);
				}
			}
			EventSystem.Instance.Emit(EEventName.RoverlikeGainDataUpdate);
		}

		// Token: 0x0603EB06 RID: 256774 RVA: 0x00F243C4 File Offset: 0x00F225C4
		private void ExtraGainNewTipsCheck(RoverlikeGainEntry newEntry)
		{
			if (newEntry.Type == RoverRogueGainDataType.RoverRogueGainBless)
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(newEntry.ConfigId);
				if (blessConfig != null && !StringUtils.IsEmpty(blessConfig.Value.TriggerRoleInfo))
				{
					UiManager.Instance.OpenView(EUiViewName.RoverlikeRoleBlessingTips, newEntry, null);
				}
			}
		}

		// Token: 0x0603EB07 RID: 256775 RVA: 0x00F2441C File Offset: 0x00F2261C
		private void ExtraGainUpdateTipsCheck([Nullable(2)] RoverlikeGainEntry lastEntry, RoverlikeGainEntry newEntry)
		{
			if (lastEntry == null)
			{
				return;
			}
			if (newEntry.Type == RoverRogueGainDataType.RoverRogueGainLootItem && newEntry.ConfigId == lastEntry.ConfigId)
			{
				RoverlikeLootGainEntry roverlikeLootGainEntry = newEntry as RoverlikeLootGainEntry;
				RoverlikeLootGainEntry roverlikeLootGainEntry2 = lastEntry as RoverlikeLootGainEntry;
				if (roverlikeLootGainEntry != null && roverlikeLootGainEntry2 != null && roverlikeLootGainEntry.LootLv > roverlikeLootGainEntry2.LootLv)
				{
					UiManager.Instance.OpenView(EUiViewName.RoverlikeLootTipsView, roverlikeLootGainEntry, null);
				}
			}
		}

		// Token: 0x0603EB08 RID: 256776 RVA: 0x00F24477 File Offset: 0x00F22677
		private RoverlikeGainEntry CreateGainEntry(RoverRogueGainEntry proto, RoverRogueGainDataType? type)
		{
			if (type.GetValueOrDefault() == RoverRogueGainDataType.RoverRogueGainLootItem)
			{
				return new RoverlikeLootGainEntry(proto);
			}
			return new RoverlikeGainEntry(proto);
		}

		// Token: 0x0603EB09 RID: 256777 RVA: 0x00F24490 File Offset: 0x00F22690
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, RoverlikeGainEntry> GetGainMapByType(RoverRogueGainDataType? type)
		{
			if (type != null)
			{
				switch (type.GetValueOrDefault())
				{
				case RoverRogueGainDataType.RoverRogueGainBless:
					return this.BlessMap;
				case RoverRogueGainDataType.RoverRogueGainRoleEnhance:
					return this.RoleEnhanceMap;
				case RoverRogueGainDataType.RoverRogueGainLootItem:
					return this.LootItemMap;
				case RoverRogueGainDataType.RoverRogueGainItem:
					return this.ItemMap;
				}
			}
			return null;
		}

		// Token: 0x0603EB0A RID: 256778 RVA: 0x00F244E8 File Offset: 0x00F226E8
		[NullableContext(2)]
		public RoverlikeGainEntry GetGainByIncId(int incId)
		{
			RoverRogueGainDataType value;
			RoverRogueGainDataType? roverRogueGainDataType = this.IncIdToGainTypeMap.TryGetValue(incId, out value) ? new RoverRogueGainDataType?(value) : null;
			if (roverRogueGainDataType != null)
			{
				switch (roverRogueGainDataType.GetValueOrDefault())
				{
				case RoverRogueGainDataType.RoverRogueGainBless:
				{
					RoverlikeGainEntry result;
					if (!this.BlessMap.TryGetValue(incId, out result))
					{
						return null;
					}
					return result;
				}
				case RoverRogueGainDataType.RoverRogueGainRoleEnhance:
				{
					RoverlikeGainEntry result2;
					if (!this.RoleEnhanceMap.TryGetValue(incId, out result2))
					{
						return null;
					}
					return result2;
				}
				case RoverRogueGainDataType.RoverRogueGainLootItem:
				{
					RoverlikeGainEntry result3;
					if (!this.LootItemMap.TryGetValue(incId, out result3))
					{
						return null;
					}
					return result3;
				}
				case RoverRogueGainDataType.RoverRogueGainItem:
				{
					RoverlikeGainEntry result4;
					if (!this.ItemMap.TryGetValue(incId, out result4))
					{
						return null;
					}
					return result4;
				}
				}
			}
			return null;
		}

		// Token: 0x0603EB0B RID: 256779 RVA: 0x00F24598 File Offset: 0x00F22798
		public List<RoverlikeGainEntry> GetBlessList()
		{
			return new List<RoverlikeGainEntry>(this.BlessMap.Values);
		}

		// Token: 0x0603EB0C RID: 256780 RVA: 0x00F245AC File Offset: 0x00F227AC
		[NullableContext(2)]
		public RoverlikeGainEntry GetSameSlotIdBless(int configId)
		{
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(configId);
			if (blessConfig == null || blessConfig.Value.SlotId == 0)
			{
				return null;
			}
			int slotId = blessConfig.Value.SlotId;
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			List<int> list;
			if (instance == null)
			{
				list = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				RoverRogueActivity? roverRogueActivity;
				list = ((currentActivityData != null) ? ((currentActivityData.GetParamConfig() != null) ? roverRogueActivity.GetValueOrDefault().SlotList().ToList<int>() : null) : null);
			}
			if (!(list ?? new List<int>()).Contains(slotId))
			{
				return null;
			}
			foreach (RoverlikeGainEntry roverlikeGainEntry in this.BlessMap.Values)
			{
				RoverRogueBless? blessConfig2 = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
				if (blessConfig2 != null && blessConfig2.Value.SlotId == slotId)
				{
					return roverlikeGainEntry;
				}
			}
			return null;
		}

		// Token: 0x0603EB0D RID: 256781 RVA: 0x00F246C4 File Offset: 0x00F228C4
		public List<RoverlikeGainEntry> GetRoleEnhanceList()
		{
			return new List<RoverlikeGainEntry>(this.RoleEnhanceMap.Values);
		}

		// Token: 0x0603EB0E RID: 256782 RVA: 0x00F246D8 File Offset: 0x00F228D8
		public List<RoverlikeLootGainEntry> GetLootItemList()
		{
			List<RoverlikeLootGainEntry> list = new List<RoverlikeLootGainEntry>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in this.LootItemMap.Values)
			{
				list.Add((RoverlikeLootGainEntry)roverlikeGainEntry);
			}
			return list;
		}

		// Token: 0x0603EB0F RID: 256783 RVA: 0x00F2473C File Offset: 0x00F2293C
		public List<RoverlikeGainEntry> GetItemList()
		{
			return new List<RoverlikeGainEntry>(this.ItemMap.Values);
		}

		// Token: 0x0603EB10 RID: 256784 RVA: 0x00F24750 File Offset: 0x00F22950
		public int GetGainCountByType(RoverRogueGainDataType type)
		{
			Dictionary<int, RoverlikeGainEntry> gainMapByType = this.GetGainMapByType(new RoverRogueGainDataType?(type));
			if (gainMapByType == null)
			{
				return 0;
			}
			return gainMapByType.Count;
		}

		// Token: 0x0603EB11 RID: 256785 RVA: 0x00F24778 File Offset: 0x00F22978
		private static int GetGainQuality(int configId, RoverRogueGainDataType type)
		{
			if (type != RoverRogueGainDataType.RoverRogueGainBless)
			{
				if (type != RoverRogueGainDataType.RoverRogueGainItem)
				{
					return 0;
				}
				if (RoverlikeConfig.Instance.GetItemConfig(configId) == null)
				{
					return 0;
				}
				RoverRogueItem? roverRogueItem;
				return roverRogueItem.GetValueOrDefault().Quality;
			}
			else
			{
				if (RoverlikeConfig.Instance.GetBlessConfig(configId) == null)
				{
					return 0;
				}
				RoverRogueBless? roverRogueBless;
				return roverRogueBless.GetValueOrDefault().Quality;
			}
		}

		// Token: 0x0603EB12 RID: 256786 RVA: 0x00F247DE File Offset: 0x00F229DE
		public static void SortGainEntryList(List<RoverlikeGainEntry> list)
		{
			list.Sort(delegate(RoverlikeGainEntry a, RoverlikeGainEntry b)
			{
				int gainQuality = RoverlikeInstanceData.GetGainQuality(a.ConfigId, a.Type);
				int gainQuality2 = RoverlikeInstanceData.GetGainQuality(b.ConfigId, b.Type);
				if (gainQuality != gainQuality2)
				{
					return gainQuality2 - gainQuality;
				}
				if (a.ItemRemainingRooms != b.ItemRemainingRooms)
				{
					return b.ItemRemainingRooms - a.ItemRemainingRooms;
				}
				return a.ConfigId - b.ConfigId;
			});
		}

		// Token: 0x0603EB13 RID: 256787 RVA: 0x00F24808 File Offset: 0x00F22A08
		public static List<int> SortGainConfigIds(List<int> ids, RoverRogueGainDataType type)
		{
			List<int> list = new List<int>(ids);
			list.Sort(delegate(int a, int b)
			{
				int gainQuality = RoverlikeInstanceData.GetGainQuality(a, type);
				int gainQuality2 = RoverlikeInstanceData.GetGainQuality(b, type);
				if (gainQuality != gainQuality2)
				{
					return gainQuality2 - gainQuality;
				}
				return a - b;
			});
			return list;
		}

		// Token: 0x04020C51 RID: 134225
		public int RoadTypeId;

		// Token: 0x04020C52 RID: 134226
		public List<int> RoadLayerIndexList = new List<int>();

		// Token: 0x04020C53 RID: 134227
		private int CurLayerInternal;

		// Token: 0x04020C54 RID: 134228
		private int MaxLayerInternal;

		// Token: 0x04020C55 RID: 134229
		private int CurRoomIdInternal;

		// Token: 0x04020C56 RID: 134230
		private int CurRoomTypeIdInternal;

		// Token: 0x04020C57 RID: 134231
		private readonly Dictionary<int, RoverlikeGainEntry> BlessMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x04020C58 RID: 134232
		private readonly Dictionary<int, RoverlikeGainEntry> RoleEnhanceMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x04020C59 RID: 134233
		private readonly Dictionary<int, RoverlikeGainEntry> LootItemMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x04020C5A RID: 134234
		private readonly Dictionary<int, RoverlikeGainEntry> ItemMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x04020C5B RID: 134235
		private readonly Dictionary<int, RoverRogueGainDataType> IncIdToGainTypeMap = new Dictionary<int, RoverRogueGainDataType>();

		// Token: 0x04020C5C RID: 134236
		public int RoleType;

		// Token: 0x04020C5D RID: 134237
		private readonly RoverlikeDialogLogic DialogLogic = new RoverlikeDialogLogic();

		// Token: 0x04020C5E RID: 134238
		private readonly Dictionary<int, List<int>> BlessVoicePool = new Dictionary<int, List<int>>();
	}
}
