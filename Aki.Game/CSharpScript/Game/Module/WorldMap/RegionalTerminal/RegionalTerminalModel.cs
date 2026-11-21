using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal
{
	// Token: 0x02003785 RID: 14213
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalModel : ModelBase
	{
		// Token: 0x17004BCE RID: 19406
		// (get) Token: 0x06024EF8 RID: 151288 RVA: 0x00A6F8E9 File Offset: 0x00A6DAE9
		// (set) Token: 0x06024EF9 RID: 151289 RVA: 0x00A6F8F1 File Offset: 0x00A6DAF1
		public int CurrentAreaMapGroupId
		{
			get
			{
				return this.CurrentAreaMapGroupIdInternal;
			}
			set
			{
				int currentAreaMapGroupIdInternal = this.CurrentAreaMapGroupIdInternal;
				this.CurrentAreaMapGroupIdInternal = value;
				if (currentAreaMapGroupIdInternal != value)
				{
					EventSystem.Instance.Emit(EEventName.AreaMapGroupIdChanged);
				}
			}
		}

		// Token: 0x17004BCF RID: 19407
		// (get) Token: 0x06024EFA RID: 151290 RVA: 0x00A6F913 File Offset: 0x00A6DB13
		public int CurrentUnlockAreaMapGroupId
		{
			get
			{
				if (this.UnlockAreaMapGroupId.Contains(this.CurrentAreaMapGroupIdInternal))
				{
					return this.CurrentAreaMapGroupIdInternal;
				}
				return 0;
			}
		}

		// Token: 0x06024EFB RID: 151291 RVA: 0x00A6F930 File Offset: 0x00A6DB30
		protected override bool OnInit()
		{
			foreach (AreaTerminal config in RegionalTerminalConfig.Instance.GetAllAreaTerminal())
			{
				RegionalTerminalGameplayData item = this.CreateGameplayData(config);
				RegionalTerminalGroupData regionalTerminalGroupData;
				if (!this.GroupDataMap.TryGetValue(config.GroupId, out regionalTerminalGroupData))
				{
					AreaTerminalGroup? areaTerminalGroup = RegionalTerminalConfig.Instance.GetAreaTerminalGroup(config.GroupId);
					if (areaTerminalGroup == null)
					{
						continue;
					}
					regionalTerminalGroupData = new RegionalTerminalGroupData();
					regionalTerminalGroupData.GroupId = config.GroupId;
					regionalTerminalGroupData.SortId = areaTerminalGroup.Value.SortId;
					this.GroupDataMap[config.GroupId] = regionalTerminalGroupData;
				}
				regionalTerminalGroupData.GameplayDataList.Add(item);
			}
			return true;
		}

		// Token: 0x06024EFC RID: 151292 RVA: 0x00A6FA04 File Offset: 0x00A6DC04
		protected override bool OnClear()
		{
			this.GroupDataMap.Clear();
			this.GameplayDataMap.Clear();
			this.InstanceId2AreaMapGroupId.Clear();
			this.InstanceId2AreaMapGroupIdInit = false;
			return true;
		}

		// Token: 0x06024EFD RID: 151293 RVA: 0x00A6FA30 File Offset: 0x00A6DC30
		private RegionalTerminalGameplayData CreateGameplayData(AreaTerminal config)
		{
			RegionalTerminalGameplayData regionalTerminalGameplayData = this.Type2GameplayDataCtor[(ETerminalGameplayType)config.GamePlayType]();
			regionalTerminalGameplayData.Id = config.Id;
			regionalTerminalGameplayData.GameplayId = config.GamePlayId;
			regionalTerminalGameplayData.SortId = config.SortId;
			regionalTerminalGameplayData.GroupId = config.GroupId;
			this.GameplayDataMap[config.Id] = regionalTerminalGameplayData;
			foreach (int key in config.AreaMapGroup())
			{
				List<int> list;
				if (!this.AreaMapGroupId2GameplayIdList.TryGetValue(key, out list))
				{
					list = new List<int>();
					this.AreaMapGroupId2GameplayIdList[key] = list;
				}
				list.Add(config.Id);
			}
			return regionalTerminalGameplayData;
		}

		// Token: 0x06024EFE RID: 151294 RVA: 0x00A6FAEC File Offset: 0x00A6DCEC
		public List<RegionalTerminalGameplayData> GetGameplayDataList(bool withPinGameplay = true)
		{
			HashSet<int> hashSet = new HashSet<int>();
			List<RegionalTerminalGameplayData> list = new List<RegionalTerminalGameplayData>();
			if (withPinGameplay)
			{
				foreach (int item in this.GetPinnedGameplayIds())
				{
					hashSet.Add(item);
				}
			}
			foreach (int item2 in this.AreaMapGroupId2GameplayIdList.GetValueOrDefault(this.CurrentUnlockAreaMapGroupId, new List<int>()))
			{
				hashSet.Add(item2);
			}
			foreach (int key in hashSet)
			{
				RegionalTerminalGameplayData regionalTerminalGameplayData;
				if (this.GameplayDataMap.TryGetValue(key, out regionalTerminalGameplayData) && regionalTerminalGameplayData.GetShowState())
				{
					list.Add(regionalTerminalGameplayData);
				}
			}
			list.Sort(new Comparison<RegionalTerminalGameplayData>(this.SortGameplayData));
			return list;
		}

		// Token: 0x06024EFF RID: 151295 RVA: 0x00A6FC14 File Offset: 0x00A6DE14
		public int SortGameplayData(RegionalTerminalGameplayData a, RegionalTerminalGameplayData b)
		{
			bool flag = this.IsGameplayPin(a.Id);
			bool flag2 = this.IsGameplayPin(b.Id);
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				bool flag3 = !a.GetLockState();
				bool flag4 = !b.GetLockState();
				if (flag3 != flag4)
				{
					if (!flag3)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.SortId != b.SortId)
					{
						return b.SortId.CompareTo(a.SortId);
					}
					return b.Id.CompareTo(a.Id);
				}
			}
		}

		// Token: 0x06024F00 RID: 151296 RVA: 0x00A6FC98 File Offset: 0x00A6DE98
		public unsafe int? GetAreaMapGroupIdByInstanceId(int instanceId)
		{
			if (!this.InstanceId2AreaMapGroupIdInit)
			{
				foreach (AreaMapGroup areaMapGroup in RegionalTerminalConfig.Instance.GetAllAreaMapGroup())
				{
					Span<int> instanceDungeonBytes = areaMapGroup.GetInstanceDungeonBytes();
					for (int i = 0; i < instanceDungeonBytes.Length; i++)
					{
						int key = *instanceDungeonBytes[i];
						this.InstanceId2AreaMapGroupId[key] = areaMapGroup.Id;
					}
				}
				this.InstanceId2AreaMapGroupIdInit = true;
			}
			return this.InstanceId2AreaMapGroupId.GetValueOrNull(instanceId);
		}

		// Token: 0x06024F01 RID: 151297 RVA: 0x00A6FD38 File Offset: 0x00A6DF38
		public void SetUnlockAreaMapGroupId(int areaMapGroupId)
		{
			this.UnlockAreaMapGroupId.Add(areaMapGroupId);
		}

		// Token: 0x06024F02 RID: 151298 RVA: 0x00A6FD48 File Offset: 0x00A6DF48
		public void InitGameplayPin(RepeatedField<int> gameplayIdList)
		{
			this.PinnedGameplayIds = new List<int>(gameplayIdList);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Map;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[RegionalTerminal] 初始化终端信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PinnedIdList", gameplayIdList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06024F03 RID: 151299 RVA: 0x00A6FD88 File Offset: 0x00A6DF88
		public void UpdateGameplayPin(int gameplayId, bool isPin)
		{
			int num = this.PinnedGameplayIds.IndexOf(gameplayId);
			if (isPin)
			{
				if (num == -1)
				{
					this.PinnedGameplayIds.Add(gameplayId);
				}
			}
			else if (num != -1)
			{
				this.PinnedGameplayIds.RemoveAt(num);
			}
			EventSystem.Instance.Emit<int, bool>(EEventName.RegionalTerminalGameplayPinUpdate, gameplayId, isPin);
		}

		// Token: 0x06024F04 RID: 151300 RVA: 0x00A6FDD9 File Offset: 0x00A6DFD9
		public bool IsGameplayPin(int gameplayId)
		{
			return this.PinnedGameplayIds.Contains(gameplayId);
		}

		// Token: 0x06024F05 RID: 151301 RVA: 0x00A6FDE7 File Offset: 0x00A6DFE7
		public List<int> GetPinnedGameplayIds()
		{
			return new List<int>(this.PinnedGameplayIds);
		}

		// Token: 0x06024F06 RID: 151302 RVA: 0x00A6FDF4 File Offset: 0x00A6DFF4
		public void StartPinCdTimer()
		{
			this.ClearPinCdTimer();
			this.PinCdTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ClearPinCdTimer();
			}, 1000f, null, null, true, 1f);
		}

		// Token: 0x06024F07 RID: 151303 RVA: 0x00A6FE25 File Offset: 0x00A6E025
		public void ClearPinCdTimer()
		{
			if (this.PinCdTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.PinCdTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.PinCdTimerHandle);
			}
			this.PinCdTimerHandle = null;
		}

		// Token: 0x17004BD0 RID: 19408
		// (get) Token: 0x06024F08 RID: 151304 RVA: 0x00A6FE59 File Offset: 0x00A6E059
		public bool IsInPinCd
		{
			get
			{
				return this.PinCdTimerHandle != null;
			}
		}

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x06024F09 RID: 151305 RVA: 0x00A6FE64 File Offset: 0x00A6E064
		// (set) Token: 0x06024F0A RID: 151306 RVA: 0x00A6FE71 File Offset: 0x00A6E071
		public bool BarFoldState
		{
			get
			{
				return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.RegionalTerminalBarFoldState, false);
			}
			set
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.RegionalTerminalBarFoldState, value);
			}
		}

		// Token: 0x06024F0B RID: 151307 RVA: 0x00A6FE7F File Offset: 0x00A6E07F
		public void UpdateFuncIdConditionFinishedState(int funcId, RepeatedField<int> conditionIdList)
		{
			this.FunctionConditionFinishedStateMap[funcId] = new List<int>(conditionIdList);
		}

		// Token: 0x06024F0C RID: 151308 RVA: 0x00A6FE93 File Offset: 0x00A6E093
		public bool GetFuncIdConditionFinishedState(int funcId, int conditionId)
		{
			List<int> valueOrDefault = this.FunctionConditionFinishedStateMap.GetValueOrDefault(funcId);
			return valueOrDefault != null && valueOrDefault.Contains(conditionId);
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x06024F0D RID: 151309 RVA: 0x00A6FEAD File Offset: 0x00A6E0AD
		public static RegionalTerminalModel Instance
		{
			get
			{
				return RegionalTerminalModel._Instance;
			}
		}

		// Token: 0x06024F0E RID: 151310 RVA: 0x00A6FEB4 File Offset: 0x00A6E0B4
		public static RegionalTerminalModel GetOrCreateInstance()
		{
			if (RegionalTerminalModel._Instance == null)
			{
				RegionalTerminalModel.CreateInstance();
			}
			return RegionalTerminalModel._Instance;
		}

		// Token: 0x06024F0F RID: 151311 RVA: 0x00A6FEC8 File Offset: 0x00A6E0C8
		public static bool CreateInstance()
		{
			if (RegionalTerminalModel._Instance != null)
			{
				return true;
			}
			RegionalTerminalModel._Instance = new RegionalTerminalModel();
			return true;
		}

		// Token: 0x06024F10 RID: 151312 RVA: 0x00A6FEDE File Offset: 0x00A6E0DE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06024F11 RID: 151313 RVA: 0x00A6FEE0 File Offset: 0x00A6E0E0
		public static void ResetStaticDefaultValue()
		{
			RegionalTerminalModel._Instance = null;
		}

		// Token: 0x06024F12 RID: 151314 RVA: 0x00A6FEE8 File Offset: 0x00A6E0E8
		static RegionalTerminalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RegionalTerminalModel.CreateStaticDefaultValue), new Action(RegionalTerminalModel.ResetStaticDefaultValue));
		}

		// Token: 0x06024F13 RID: 151315 RVA: 0x00A6FF08 File Offset: 0x00A6E108
		public RegionalTerminalModel()
		{
			Dictionary<ETerminalGameplayType, Func<RegionalTerminalGameplayData>> dictionary = new Dictionary<ETerminalGameplayType, Func<RegionalTerminalGameplayData>>();
			dictionary[ETerminalGameplayType.Activity] = (() => new RegionalTerminalActivityData());
			dictionary[ETerminalGameplayType.Function] = (() => new RegionalTerminalFunctionData());
			this.Type2GameplayDataCtor = dictionary;
			this.PinnedGameplayIds = new List<int>();
			this.FunctionConditionFinishedStateMap = new Dictionary<int, List<int>>();
			base..ctor();
		}

		// Token: 0x04014736 RID: 83766
		public Dictionary<int, RegionalTerminalGroupData> GroupDataMap = new Dictionary<int, RegionalTerminalGroupData>();

		// Token: 0x04014737 RID: 83767
		public Dictionary<int, RegionalTerminalGameplayData> GameplayDataMap = new Dictionary<int, RegionalTerminalGameplayData>();

		// Token: 0x04014738 RID: 83768
		private readonly Dictionary<int, List<int>> AreaMapGroupId2GameplayIdList = new Dictionary<int, List<int>>();

		// Token: 0x04014739 RID: 83769
		private int CurrentAreaMapGroupIdInternal;

		// Token: 0x0401473A RID: 83770
		private readonly Dictionary<int, int> InstanceId2AreaMapGroupId = new Dictionary<int, int>();

		// Token: 0x0401473B RID: 83771
		private bool InstanceId2AreaMapGroupIdInit;

		// Token: 0x0401473C RID: 83772
		private readonly HashSet<int> UnlockAreaMapGroupId = new HashSet<int>();

		// Token: 0x0401473D RID: 83773
		private readonly Dictionary<ETerminalGameplayType, Func<RegionalTerminalGameplayData>> Type2GameplayDataCtor;

		// Token: 0x0401473E RID: 83774
		private List<int> PinnedGameplayIds;

		// Token: 0x0401473F RID: 83775
		private readonly Dictionary<int, List<int>> FunctionConditionFinishedStateMap;

		// Token: 0x04014740 RID: 83776
		[Nullable(2)]
		private TimerHandle PinCdTimerHandle;

		// Token: 0x04014741 RID: 83777
		[Nullable(2)]
		private static RegionalTerminalModel _Instance;
	}
}
