using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200505A RID: 20570
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeInstanceData
	{
		// Token: 0x1700648C RID: 25740
		// (get) Token: 0x060337BC RID: 210876 RVA: 0x00E6AABB File Offset: 0x00E68CBB
		public int CurLayer
		{
			get
			{
				return this.CurLayerInternal;
			}
		}

		// Token: 0x1700648D RID: 25741
		// (get) Token: 0x060337BD RID: 210877 RVA: 0x00E6AAC3 File Offset: 0x00E68CC3
		public int MaxLayer
		{
			get
			{
				return this.MaxLayerInternal;
			}
		}

		// Token: 0x1700648E RID: 25742
		// (get) Token: 0x060337BE RID: 210878 RVA: 0x00E6AACB File Offset: 0x00E68CCB
		public int CurRoomId
		{
			get
			{
				return this.CurRoomIdInternal;
			}
		}

		// Token: 0x1700648F RID: 25743
		// (get) Token: 0x060337BF RID: 210879 RVA: 0x00E6AAD3 File Offset: 0x00E68CD3
		public int CurRoomTypeId
		{
			get
			{
				return this.CurRoomTypeIdInternal;
			}
		}

		// Token: 0x060337C0 RID: 210880 RVA: 0x00E6AADB File Offset: 0x00E68CDB
		public static RoverlikeInstanceData Create()
		{
			return new RoverlikeInstanceData();
		}

		// Token: 0x060337C1 RID: 210881 RVA: 0x00E6AAE4 File Offset: 0x00E68CE4
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

		// Token: 0x060337C2 RID: 210882 RVA: 0x00E6ACB0 File Offset: 0x00E68EB0
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

		// Token: 0x060337C3 RID: 210883 RVA: 0x00E6AD0C File Offset: 0x00E68F0C
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

		// Token: 0x060337C4 RID: 210884 RVA: 0x00E6ADEA File Offset: 0x00E68FEA
		public void Clear()
		{
			this.BlessMap.Clear();
			this.RoleEnhanceMap.Clear();
			this.LootItemMap.Clear();
			this.ItemMap.Clear();
			this.BlessVoicePool.Clear();
			this.StopAudio();
		}

		// Token: 0x060337C5 RID: 210885 RVA: 0x00E6AE2C File Offset: 0x00E6902C
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

		// Token: 0x060337C6 RID: 210886 RVA: 0x00E6AEF0 File Offset: 0x00E690F0
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

		// Token: 0x060337C7 RID: 210887 RVA: 0x00E6AFAE File Offset: 0x00E691AE
		public void PlayAudio(string eventPath, [Nullable(2)] Action finishCallback = null)
		{
			this.DialogLogic.PlayAudio(eventPath, finishCallback);
		}

		// Token: 0x060337C8 RID: 210888 RVA: 0x00E6AFBD File Offset: 0x00E691BD
		public void StopAudio()
		{
			this.DialogLogic.Stop();
		}

		// Token: 0x060337C9 RID: 210889 RVA: 0x00E6AFCC File Offset: 0x00E691CC
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

		// Token: 0x060337CA RID: 210890 RVA: 0x00E6B1B4 File Offset: 0x00E693B4
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

		// Token: 0x060337CB RID: 210891 RVA: 0x00E6B20C File Offset: 0x00E6940C
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

		// Token: 0x060337CC RID: 210892 RVA: 0x00E6B267 File Offset: 0x00E69467
		private RoverlikeGainEntry CreateGainEntry(RoverRogueGainEntry proto, RoverRogueGainDataType? type)
		{
			if (type.GetValueOrDefault() == RoverRogueGainDataType.RoverRogueGainLootItem)
			{
				return new RoverlikeLootGainEntry(proto);
			}
			return new RoverlikeGainEntry(proto);
		}

		// Token: 0x060337CD RID: 210893 RVA: 0x00E6B280 File Offset: 0x00E69480
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

		// Token: 0x060337CE RID: 210894 RVA: 0x00E6B2D8 File Offset: 0x00E694D8
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

		// Token: 0x060337CF RID: 210895 RVA: 0x00E6B388 File Offset: 0x00E69588
		public List<RoverlikeGainEntry> GetBlessList()
		{
			return new List<RoverlikeGainEntry>(this.BlessMap.Values);
		}

		// Token: 0x060337D0 RID: 210896 RVA: 0x00E6B39C File Offset: 0x00E6959C
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
			int[] array;
			if (instance == null)
			{
				array = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				RoverRogueActivity? roverRogueActivity;
				array = ((currentActivityData != null) ? ((currentActivityData.GetParamConfig() != null) ? roverRogueActivity.GetValueOrDefault().SlotList() : null) : null);
			}
			int[] array2 = array;
			if (!((array2 != null) ? new List<int>(array2) : new List<int>()).Contains(slotId))
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

		// Token: 0x060337D1 RID: 210897 RVA: 0x00E6B4B8 File Offset: 0x00E696B8
		public List<RoverlikeGainEntry> GetRoleEnhanceList()
		{
			return new List<RoverlikeGainEntry>(this.RoleEnhanceMap.Values);
		}

		// Token: 0x060337D2 RID: 210898 RVA: 0x00E6B4CC File Offset: 0x00E696CC
		public List<RoverlikeLootGainEntry> GetLootItemList()
		{
			List<RoverlikeLootGainEntry> list = new List<RoverlikeLootGainEntry>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in this.LootItemMap.Values)
			{
				list.Add((RoverlikeLootGainEntry)roverlikeGainEntry);
			}
			return list;
		}

		// Token: 0x060337D3 RID: 210899 RVA: 0x00E6B530 File Offset: 0x00E69730
		public List<RoverlikeGainEntry> GetItemList()
		{
			return new List<RoverlikeGainEntry>(this.ItemMap.Values);
		}

		// Token: 0x060337D4 RID: 210900 RVA: 0x00E6B544 File Offset: 0x00E69744
		public int GetGainCountByType(RoverRogueGainDataType type)
		{
			Dictionary<int, RoverlikeGainEntry> gainMapByType = this.GetGainMapByType(new RoverRogueGainDataType?(type));
			if (gainMapByType == null)
			{
				return 0;
			}
			return gainMapByType.Count;
		}

		// Token: 0x060337D5 RID: 210901 RVA: 0x00E6B56C File Offset: 0x00E6976C
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

		// Token: 0x060337D6 RID: 210902 RVA: 0x00E6B5D2 File Offset: 0x00E697D2
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

		// Token: 0x060337D7 RID: 210903 RVA: 0x00E6B5FC File Offset: 0x00E697FC
		public static List<int> SortGainConfigIds(IEnumerable<int> ids, RoverRogueGainDataType type)
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

		// Token: 0x0401B57E RID: 111998
		public int RoadTypeId;

		// Token: 0x0401B57F RID: 111999
		public List<int> RoadLayerIndexList = new List<int>();

		// Token: 0x0401B580 RID: 112000
		private int CurLayerInternal;

		// Token: 0x0401B581 RID: 112001
		private int MaxLayerInternal;

		// Token: 0x0401B582 RID: 112002
		private int CurRoomIdInternal;

		// Token: 0x0401B583 RID: 112003
		private int CurRoomTypeIdInternal;

		// Token: 0x0401B584 RID: 112004
		private readonly Dictionary<int, RoverlikeGainEntry> BlessMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x0401B585 RID: 112005
		private readonly Dictionary<int, RoverlikeGainEntry> RoleEnhanceMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x0401B586 RID: 112006
		private readonly Dictionary<int, RoverlikeGainEntry> LootItemMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x0401B587 RID: 112007
		private readonly Dictionary<int, RoverlikeGainEntry> ItemMap = new Dictionary<int, RoverlikeGainEntry>();

		// Token: 0x0401B588 RID: 112008
		private readonly Dictionary<int, RoverRogueGainDataType> IncIdToGainTypeMap = new Dictionary<int, RoverRogueGainDataType>();

		// Token: 0x0401B589 RID: 112009
		public int RoleType;

		// Token: 0x0401B58A RID: 112010
		private readonly RoverlikeDialogLogic DialogLogic = new RoverlikeDialogLogic();

		// Token: 0x0401B58B RID: 112011
		private readonly Dictionary<int, List<int>> BlessVoicePool = new Dictionary<int, List<int>>();
	}
}
