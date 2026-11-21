using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02003795 RID: 14229
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WeatherModel : ModelBase
	{
		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x06024FE8 RID: 151528 RVA: 0x00A73898 File Offset: 0x00A71A98
		public int CurrentWeatherId
		{
			get
			{
				return this.WeatherId;
			}
		}

		// Token: 0x06024FE9 RID: 151529 RVA: 0x00A738A0 File Offset: 0x00A71AA0
		public WeatherDefines.EWeatherType GetCurrentWeatherType()
		{
			if (this.WeatherId == 0)
			{
				return WeatherDefines.EWeatherType.None;
			}
			return WeatherModuleConfig.Instance.GetWeatherType(this.WeatherId);
		}

		// Token: 0x06024FEA RID: 151530 RVA: 0x00A738BC File Offset: 0x00A71ABC
		public void SetCurrentWeatherId(int id)
		{
			this.WeatherId = id;
		}

		// Token: 0x06024FEB RID: 151531 RVA: 0x00A738C5 File Offset: 0x00A71AC5
		public WeatherActor GetWorldWeatherActor()
		{
			return this.WorldWeatherActor;
		}

		// Token: 0x06024FEC RID: 151532 RVA: 0x00A738CD File Offset: 0x00A71ACD
		private ServerStorageSet GetClickedWeatherSwitchConfigIdStorage()
		{
			ServerStorageUtil.OverrideLocalListToServerSet(ELocalStoragePlayerKey.WeatherCentralClicked, EClientStorageSystemIdType.WeatherCentralClicked, true);
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.WeatherCentralClicked) as ServerStorageSet;
		}

		// Token: 0x06024FED RID: 151533 RVA: 0x00A738F0 File Offset: 0x00A71AF0
		public int GetSwitchConfigIdByWeatherId(int weatherId)
		{
			if (this.WeatherIdToWeatherSwitchConfigIdMap == null)
			{
				this.WeatherIdToWeatherSwitchConfigIdMap = new Dictionary<int, int>();
				foreach (WeatherSwitch weatherSwitch in WeatherModuleConfig.Instance.GetWeatherSwitchConfigAll())
				{
					foreach (DicIntInt dicIntInt in weatherSwitch.WeatherIter())
					{
						this.WeatherIdToWeatherSwitchConfigIdMap[dicIntInt.Value] = weatherSwitch.Id;
					}
				}
			}
			int result;
			if (!this.WeatherIdToWeatherSwitchConfigIdMap.TryGetValue(weatherId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x06024FEE RID: 151534 RVA: 0x00A739B0 File Offset: 0x00A71BB0
		public int GetCurrentWeatherSwitchConfigId()
		{
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(currentAreaId);
			if (!this.IsInValidArea(levelOneAreaId))
			{
				return 0;
			}
			return this.GetSwitchConfigIdByWeatherId(this.CurrentWeatherId);
		}

		// Token: 0x06024FEF RID: 151535 RVA: 0x00A739F4 File Offset: 0x00A71BF4
		public bool IsInValidArea(int levelOneAreaId)
		{
			if (this.ValidAreaIdSet == null)
			{
				this.ValidAreaIdSet = new HashSet<int>();
				foreach (Observatory observatory in ConfigObservatoryAll.GetConfigList(true))
				{
					this.ValidAreaIdSet.Add(observatory.AreaId);
				}
			}
			return this.ValidAreaIdSet.Contains(levelOneAreaId);
		}

		// Token: 0x06024FF0 RID: 151536 RVA: 0x00A73A6C File Offset: 0x00A71C6C
		public bool IsWeatherBanArea(int weatherSwitchConfigId, int areaId)
		{
			WeatherSwitch? weatherSwitchConfig = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(weatherSwitchConfigId);
			return weatherSwitchConfig != null && Array.IndexOf<int>(weatherSwitchConfig.Value.BanAreaList(), areaId) >= 0;
		}

		// Token: 0x06024FF1 RID: 151537 RVA: 0x00A73AAC File Offset: 0x00A71CAC
		public bool IsCurrentTimeInValidTime(int id)
		{
			double hour = TimeOfDayModel.Instance.GameTime.Hour;
			int[] array = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(id).Value.ValidTime();
			int num = array[0];
			int num2 = array[1];
			if (num <= num2)
			{
				return hour >= (double)num && hour <= (double)num2;
			}
			return hour >= (double)num || hour <= (double)num2;
		}

		// Token: 0x06024FF2 RID: 151538 RVA: 0x00A73B10 File Offset: 0x00A71D10
		public int GetAccelerateWeatherTime(int id)
		{
			if (this.IsCurrentTimeInValidTime(id))
			{
				return 0;
			}
			int num = (int)TimeOfDayModel.Instance.GameTime.Hour;
			int num2 = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(id).Value.ValidTime()[0];
			int num3 = num2 - num;
			if (num3 < 0)
			{
				num3 += 24;
			}
			Log.Instance.Info(ELogModule.Weather, ELogAuthor.LJ, string.Concat(new string[]
			{
				"当前小时:",
				num.ToString(),
				" 目标小时:",
				num2.ToString(),
				" 相差小时数:",
				num3.ToString()
			}), default(ReadOnlySpan<ValueTuple<string, object>>));
			return num3 * 3600;
		}

		// Token: 0x06024FF3 RID: 151539 RVA: 0x00A73BC8 File Offset: 0x00A71DC8
		public void SetUnlockedWeatherSwitchConfigIdList(IEnumerable<int> list)
		{
			this.UnlockedWeatherSwitchConfigIdSet.Clear();
			foreach (int item in list)
			{
				this.UnlockedWeatherSwitchConfigIdSet.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06024FF4 RID: 151540 RVA: 0x00A73C34 File Offset: 0x00A71E34
		public void AddUnlockedWeatherSwitchConfigId(int id)
		{
			this.UnlockedWeatherSwitchConfigIdSet.Add(id);
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06024FF5 RID: 151541 RVA: 0x00A73C53 File Offset: 0x00A71E53
		public bool IsWeatherSwitchConfigUnlocked(int id)
		{
			return this.UnlockedWeatherSwitchConfigIdSet.Contains(id);
		}

		// Token: 0x06024FF6 RID: 151542 RVA: 0x00A73C64 File Offset: 0x00A71E64
		public bool HasAnyNewWeather()
		{
			HashSet<int> unlockedWeatherSwitchConfigIdSet = this.UnlockedWeatherSwitchConfigIdSet;
			int num = (unlockedWeatherSwitchConfigIdSet != null) ? unlockedWeatherSwitchConfigIdSet.Count : 0;
			int num2 = this.GetClickedWeatherSwitchConfigIdStorage().Size();
			return num > num2;
		}

		// Token: 0x06024FF7 RID: 151543 RVA: 0x00A73C92 File Offset: 0x00A71E92
		public bool IsWeatherClicked(int weatherSwitchConfigId)
		{
			return this.GetClickedWeatherSwitchConfigIdStorage().Has(weatherSwitchConfigId);
		}

		// Token: 0x06024FF8 RID: 151544 RVA: 0x00A73CA0 File Offset: 0x00A71EA0
		public void RecordWeatherClicked(int weatherSwitchConfigId)
		{
			this.GetClickedWeatherSwitchConfigIdStorage().Add(weatherSwitchConfigId);
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06024FF9 RID: 151545 RVA: 0x00A73CBE File Offset: 0x00A71EBE
		public void RecordSwitchTime()
		{
			this.LastSwitchTime = Time.Instance.WorldTime;
		}

		// Token: 0x06024FFA RID: 151546 RVA: 0x00A73CD0 File Offset: 0x00A71ED0
		public int GetRemainCoolDownTime()
		{
			double num = (Time.Instance.WorldTime - this.LastSwitchTime) * 0.0010000000474974513;
			return (int)Math.Ceiling((double)ConfigCommonParamById.GetIntConfig("WeatherControlCoolDown").Value - num);
		}

		// Token: 0x06024FFB RID: 151547 RVA: 0x00A73D14 File Offset: 0x00A71F14
		public bool CanSwitchWeather()
		{
			return this.GetRemainCoolDownTime() <= 0;
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x06024FFC RID: 151548 RVA: 0x00A73D22 File Offset: 0x00A71F22
		public ObservatoryModule ObservatoryModule
		{
			get
			{
				if (this.ObservatoryModuleInternal == null)
				{
					this.ObservatoryModuleInternal = new ObservatoryModule();
				}
				return this.ObservatoryModuleInternal;
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x06024FFD RID: 151549 RVA: 0x00A73D40 File Offset: 0x00A71F40
		public int? TargetWeatherSwitchConfigId
		{
			get
			{
				if (this.TargetWeatherSwitchConfigIdInternal != null)
				{
					int value = this.TargetWeatherSwitchConfigIdInternal.Value;
					this.TargetWeatherSwitchConfigIdInternal = null;
					return new int?(value);
				}
				return null;
			}
		}

		// Token: 0x06024FFE RID: 151550 RVA: 0x00A73D80 File Offset: 0x00A71F80
		public void SetTargetWeatherSwitchConfigId(int weatherSwitchConfigId)
		{
			this.TargetWeatherSwitchConfigIdInternal = new int?(weatherSwitchConfigId);
		}

		// Token: 0x17004BE4 RID: 19428
		// (get) Token: 0x06024FFF RID: 151551 RVA: 0x00A73D8E File Offset: 0x00A71F8E
		public static WeatherModel Instance
		{
			get
			{
				return WeatherModel._Instance;
			}
		}

		// Token: 0x06025000 RID: 151552 RVA: 0x00A73D95 File Offset: 0x00A71F95
		public static WeatherModel GetOrCreateInstance()
		{
			if (WeatherModel._Instance == null)
			{
				WeatherModel.CreateInstance();
			}
			return WeatherModel._Instance;
		}

		// Token: 0x06025001 RID: 151553 RVA: 0x00A73DA9 File Offset: 0x00A71FA9
		public static bool CreateInstance()
		{
			if (WeatherModel._Instance != null)
			{
				return true;
			}
			WeatherModel._Instance = new WeatherModel();
			return true;
		}

		// Token: 0x06025002 RID: 151554 RVA: 0x00A73DBF File Offset: 0x00A71FBF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025003 RID: 151555 RVA: 0x00A73DC1 File Offset: 0x00A71FC1
		public static void ResetStaticDefaultValue()
		{
			WeatherModel._Instance = null;
		}

		// Token: 0x06025004 RID: 151556 RVA: 0x00A73DC9 File Offset: 0x00A71FC9
		static WeatherModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeatherModel.CreateStaticDefaultValue), new Action(WeatherModel.ResetStaticDefaultValue));
		}

		// Token: 0x04014793 RID: 83859
		private readonly WeatherActor WorldWeatherActor = new WeatherActor();

		// Token: 0x04014794 RID: 83860
		private int WeatherId;

		// Token: 0x04014795 RID: 83861
		private readonly HashSet<int> UnlockedWeatherSwitchConfigIdSet = new HashSet<int>();

		// Token: 0x04014796 RID: 83862
		[Nullable(2)]
		private Dictionary<int, int> WeatherIdToWeatherSwitchConfigIdMap;

		// Token: 0x04014797 RID: 83863
		[Nullable(2)]
		private HashSet<int> ValidAreaIdSet;

		// Token: 0x04014798 RID: 83864
		public double LastSwitchTime;

		// Token: 0x04014799 RID: 83865
		public bool TimeSwitchConfirmNeedShow = true;

		// Token: 0x0401479A RID: 83866
		[Nullable(2)]
		private ObservatoryModule ObservatoryModuleInternal;

		// Token: 0x0401479B RID: 83867
		private int? TargetWeatherSwitchConfigIdInternal;

		// Token: 0x0401479C RID: 83868
		[Nullable(2)]
		private static WeatherModel _Instance;
	}
}
