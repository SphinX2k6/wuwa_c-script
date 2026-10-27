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
	// Token: 0x02004854 RID: 18516
	[NullableContext(1)]
	[Nullable(0)]
	public class RegionalTerminalModel : ModelBase
	{
		// Token: 0x17007911 RID: 30993
		// (get) Token: 0x06030729 RID: 198441 RVA: 0x00B3F6A5 File Offset: 0x00B3D8A5
		// (set) Token: 0x0603072A RID: 198442 RVA: 0x00B3F6AD File Offset: 0x00B3D8AD
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

		// Token: 0x17007912 RID: 30994
		// (get) Token: 0x0603072B RID: 198443 RVA: 0x00B3F6CF File Offset: 0x00B3D8CF
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

		// Token: 0x0603072C RID: 198444 RVA: 0x00B3F6EC File Offset: 0x00B3D8EC
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

		// Token: 0x0603072D RID: 198445 RVA: 0x00B3F7C0 File Offset: 0x00B3D9C0
		protected override bool OnClear()
		{
			this.GroupDataMap.Clear();
			this.GameplayDataMap.Clear();
			this.InstanceId2AreaMapGroupId.Clear();
			this.InstanceId2AreaMapGroupIdInit = false;
			return true;
		}

		// Token: 0x0603072E RID: 198446 RVA: 0x00B3F7EC File Offset: 0x00B3D9EC
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

		// Token: 0x0603072F RID: 198447 RVA: 0x00B3F8A8 File Offset: 0x00B3DAA8
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

		// Token: 0x06030730 RID: 198448 RVA: 0x00B3F9D0 File Offset: 0x00B3DBD0
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

		// Token: 0x06030731 RID: 198449 RVA: 0x00B3FA54 File Offset: 0x00B3DC54
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

		// Token: 0x06030732 RID: 198450 RVA: 0x00B3FAF4 File Offset: 0x00B3DCF4
		public void SetUnlockAreaMapGroupId(int areaMapGroupId)
		{
			this.UnlockAreaMapGroupId.Add(areaMapGroupId);
		}

		// Token: 0x06030733 RID: 198451 RVA: 0x00B3FB04 File Offset: 0x00B3DD04
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

		// Token: 0x06030734 RID: 198452 RVA: 0x00B3FB44 File Offset: 0x00B3DD44
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

		// Token: 0x06030735 RID: 198453 RVA: 0x00B3FB95 File Offset: 0x00B3DD95
		public bool IsGameplayPin(int gameplayId)
		{
			return this.PinnedGameplayIds.Contains(gameplayId);
		}

		// Token: 0x06030736 RID: 198454 RVA: 0x00B3FBA3 File Offset: 0x00B3DDA3
		public List<int> GetPinnedGameplayIds()
		{
			return new List<int>(this.PinnedGameplayIds);
		}

		// Token: 0x06030737 RID: 198455 RVA: 0x00B3FBB0 File Offset: 0x00B3DDB0
		public void StartPinCdTimer()
		{
			this.ClearPinCdTimer();
			this.PinCdTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ClearPinCdTimer();
			}, 1000f, null, null, true, 1f);
		}

		// Token: 0x06030738 RID: 198456 RVA: 0x00B3FBE1 File Offset: 0x00B3DDE1
		public void ClearPinCdTimer()
		{
			if (this.PinCdTimerHandle != null && TimerSystem.GameplayTimeInstance.Has(this.PinCdTimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.PinCdTimerHandle);
			}
			this.PinCdTimerHandle = null;
		}

		// Token: 0x17007913 RID: 30995
		// (get) Token: 0x06030739 RID: 198457 RVA: 0x00B3FC15 File Offset: 0x00B3DE15
		public bool IsInPinCd
		{
			get
			{
				return this.PinCdTimerHandle != null;
			}
		}

		// Token: 0x17007914 RID: 30996
		// (get) Token: 0x0603073A RID: 198458 RVA: 0x00B3FC20 File Offset: 0x00B3DE20
		// (set) Token: 0x0603073B RID: 198459 RVA: 0x00B3FC2D File Offset: 0x00B3DE2D
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

		// Token: 0x0603073C RID: 198460 RVA: 0x00B3FC3B File Offset: 0x00B3DE3B
		public void UpdateFuncIdConditionFinishedState(int funcId, RepeatedField<int> conditionIdList)
		{
			this.FunctionConditionFinishedStateMap[funcId] = new List<int>(conditionIdList);
		}

		// Token: 0x0603073D RID: 198461 RVA: 0x00B3FC4F File Offset: 0x00B3DE4F
		public bool GetFuncIdConditionFinishedState(int funcId, int conditionId)
		{
			List<int> valueOrDefault = this.FunctionConditionFinishedStateMap.GetValueOrDefault(funcId);
			return valueOrDefault != null && valueOrDefault.Contains(conditionId);
		}

		// Token: 0x17007915 RID: 30997
		// (get) Token: 0x0603073E RID: 198462 RVA: 0x00B3FC69 File Offset: 0x00B3DE69
		public static RegionalTerminalModel Instance
		{
			get
			{
				return RegionalTerminalModel._Instance;
			}
		}

		// Token: 0x0603073F RID: 198463 RVA: 0x00B3FC70 File Offset: 0x00B3DE70
		public static RegionalTerminalModel GetOrCreateInstance()
		{
			if (RegionalTerminalModel._Instance == null)
			{
				RegionalTerminalModel.CreateInstance();
			}
			return RegionalTerminalModel._Instance;
		}

		// Token: 0x06030740 RID: 198464 RVA: 0x00B3FC84 File Offset: 0x00B3DE84
		public static bool CreateInstance()
		{
			if (RegionalTerminalModel._Instance != null)
			{
				return true;
			}
			RegionalTerminalModel._Instance = new RegionalTerminalModel();
			return true;
		}

		// Token: 0x06030741 RID: 198465 RVA: 0x00B3FC9A File Offset: 0x00B3DE9A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030742 RID: 198466 RVA: 0x00B3FC9C File Offset: 0x00B3DE9C
		public static void ResetStaticDefaultValue()
		{
			RegionalTerminalModel._Instance = null;
		}

		// Token: 0x06030743 RID: 198467 RVA: 0x00B3FCA4 File Offset: 0x00B3DEA4
		static RegionalTerminalModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RegionalTerminalModel.CreateStaticDefaultValue), new Action(RegionalTerminalModel.ResetStaticDefaultValue));
		}

		// Token: 0x06030744 RID: 198468 RVA: 0x00B3FCC4 File Offset: 0x00B3DEC4
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

		// Token: 0x0401A082 RID: 106626
		public Dictionary<int, RegionalTerminalGroupData> GroupDataMap = new Dictionary<int, RegionalTerminalGroupData>();

		// Token: 0x0401A083 RID: 106627
		public Dictionary<int, RegionalTerminalGameplayData> GameplayDataMap = new Dictionary<int, RegionalTerminalGameplayData>();

		// Token: 0x0401A084 RID: 106628
		private readonly Dictionary<int, List<int>> AreaMapGroupId2GameplayIdList = new Dictionary<int, List<int>>();

		// Token: 0x0401A085 RID: 106629
		private int CurrentAreaMapGroupIdInternal;

		// Token: 0x0401A086 RID: 106630
		private readonly Dictionary<int, int> InstanceId2AreaMapGroupId = new Dictionary<int, int>();

		// Token: 0x0401A087 RID: 106631
		private bool InstanceId2AreaMapGroupIdInit;

		// Token: 0x0401A088 RID: 106632
		private readonly HashSet<int> UnlockAreaMapGroupId = new HashSet<int>();

		// Token: 0x0401A089 RID: 106633
		private readonly Dictionary<ETerminalGameplayType, Func<RegionalTerminalGameplayData>> Type2GameplayDataCtor;

		// Token: 0x0401A08A RID: 106634
		private List<int> PinnedGameplayIds;

		// Token: 0x0401A08B RID: 106635
		private readonly Dictionary<int, List<int>> FunctionConditionFinishedStateMap;

		// Token: 0x0401A08C RID: 106636
		[Nullable(2)]
		private TimerHandle PinCdTimerHandle;

		// Token: 0x0401A08D RID: 106637
		[Nullable(2)]
		private static RegionalTerminalModel _Instance;
	}
}
