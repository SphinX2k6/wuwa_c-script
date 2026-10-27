using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02004864 RID: 18532
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class WeatherModel : ModelBase
	{
		// Token: 0x17007924 RID: 31012
		// (get) Token: 0x06030818 RID: 198680 RVA: 0x00B43610 File Offset: 0x00B41810
		public int CurrentWeatherId
		{
			get
			{
				return this.WeatherId;
			}
		}

		// Token: 0x06030819 RID: 198681 RVA: 0x00B43618 File Offset: 0x00B41818
		public WeatherDefines.EWeatherType GetCurrentWeatherType()
		{
			if (this.WeatherId == 0)
			{
				return WeatherDefines.EWeatherType.None;
			}
			return WeatherModuleConfig.Instance.GetWeatherType(this.WeatherId);
		}

		// Token: 0x0603081A RID: 198682 RVA: 0x00B43634 File Offset: 0x00B41834
		public void SetCurrentWeatherId(int id)
		{
			this.WeatherId = id;
		}

		// Token: 0x0603081B RID: 198683 RVA: 0x00B4363D File Offset: 0x00B4183D
		public WeatherActor GetWorldWeatherActor()
		{
			return this.WorldWeatherActor;
		}

		// Token: 0x17007925 RID: 31013
		// (get) Token: 0x0603081C RID: 198684 RVA: 0x00B43648 File Offset: 0x00B41848
		private HashSet<int> ClickedWeatherSwitchConfigIdSet
		{
			get
			{
				if (this.ClickedWeatherSwitchConfigIdSetInternal == null)
				{
					this.ClickedWeatherSwitchConfigIdSetInternal = new HashSet<int>();
					foreach (int item in (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.WeatherCentralClicked, null) ?? new List<int>()))
					{
						this.ClickedWeatherSwitchConfigIdSetInternal.Add(item);
					}
				}
				return this.ClickedWeatherSwitchConfigIdSetInternal;
			}
		}

		// Token: 0x0603081D RID: 198685 RVA: 0x00B436C8 File Offset: 0x00B418C8
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

		// Token: 0x0603081E RID: 198686 RVA: 0x00B43788 File Offset: 0x00B41988
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

		// Token: 0x0603081F RID: 198687 RVA: 0x00B437CC File Offset: 0x00B419CC
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

		// Token: 0x06030820 RID: 198688 RVA: 0x00B43844 File Offset: 0x00B41A44
		public bool IsWeatherBanArea(int weatherSwitchConfigId, int areaId)
		{
			WeatherSwitch? weatherSwitchConfig = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(weatherSwitchConfigId);
			return weatherSwitchConfig != null && weatherSwitchConfig.Value.BanAreaList().Contains(areaId);
		}

		// Token: 0x06030821 RID: 198689 RVA: 0x00B43880 File Offset: 0x00B41A80
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

		// Token: 0x06030822 RID: 198690 RVA: 0x00B438E4 File Offset: 0x00B41AE4
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

		// Token: 0x06030823 RID: 198691 RVA: 0x00B4399C File Offset: 0x00B41B9C
		public void SetUnlockedWeatherSwitchConfigIdList(IEnumerable<int> list)
		{
			this.UnlockedWeatherSwitchConfigIdSet.Clear();
			foreach (int item in list)
			{
				this.UnlockedWeatherSwitchConfigIdSet.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06030824 RID: 198692 RVA: 0x00B43A08 File Offset: 0x00B41C08
		public void AddUnlockedWeatherSwitchConfigId(int id)
		{
			this.UnlockedWeatherSwitchConfigIdSet.Add(id);
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06030825 RID: 198693 RVA: 0x00B43A27 File Offset: 0x00B41C27
		public bool IsWeatherSwitchConfigUnlocked(int id)
		{
			return this.UnlockedWeatherSwitchConfigIdSet.Contains(id);
		}

		// Token: 0x06030826 RID: 198694 RVA: 0x00B43A38 File Offset: 0x00B41C38
		public bool HasAnyNewWeather()
		{
			HashSet<int> unlockedWeatherSwitchConfigIdSet = this.UnlockedWeatherSwitchConfigIdSet;
			int num = (unlockedWeatherSwitchConfigIdSet != null) ? unlockedWeatherSwitchConfigIdSet.Count : 0;
			int count = this.ClickedWeatherSwitchConfigIdSet.Count;
			return num > count;
		}

		// Token: 0x06030827 RID: 198695 RVA: 0x00B43A66 File Offset: 0x00B41C66
		public bool IsWeatherClicked(int weatherSwitchConfigId)
		{
			return this.ClickedWeatherSwitchConfigIdSet.Contains(weatherSwitchConfigId);
		}

		// Token: 0x06030828 RID: 198696 RVA: 0x00B43A74 File Offset: 0x00B41C74
		public void RecordWeatherClicked(int weatherSwitchConfigId)
		{
			this.ClickedWeatherSwitchConfigIdSet.Add(weatherSwitchConfigId);
			LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.WeatherCentralClicked, this.ClickedWeatherSwitchConfigIdSet.ToList<int>());
			EventSystem.Instance.Emit(EEventName.OnWeatherCentralRedDotUpdate);
		}

		// Token: 0x06030829 RID: 198697 RVA: 0x00B43AA9 File Offset: 0x00B41CA9
		public void RecordSwitchTime()
		{
			this.LastSwitchTime = Time.Instance.WorldTime;
		}

		// Token: 0x0603082A RID: 198698 RVA: 0x00B43ABC File Offset: 0x00B41CBC
		public int GetRemainCoolDownTime()
		{
			double num = (Time.Instance.WorldTime - this.LastSwitchTime) * 0.0010000000474974513;
			return (int)Math.Ceiling((double)ConfigCommonParamById.GetIntConfig("WeatherControlCoolDown").Value - num);
		}

		// Token: 0x0603082B RID: 198699 RVA: 0x00B43B00 File Offset: 0x00B41D00
		public bool CanSwitchWeather()
		{
			return this.GetRemainCoolDownTime() <= 0;
		}

		// Token: 0x17007926 RID: 31014
		// (get) Token: 0x0603082C RID: 198700 RVA: 0x00B43B0E File Offset: 0x00B41D0E
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

		// Token: 0x17007927 RID: 31015
		// (get) Token: 0x0603082D RID: 198701 RVA: 0x00B43B2C File Offset: 0x00B41D2C
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

		// Token: 0x0603082E RID: 198702 RVA: 0x00B43B6C File Offset: 0x00B41D6C
		public void SetTargetWeatherSwitchConfigId(int weatherSwitchConfigId)
		{
			this.TargetWeatherSwitchConfigIdInternal = new int?(weatherSwitchConfigId);
		}

		// Token: 0x17007928 RID: 31016
		// (get) Token: 0x0603082F RID: 198703 RVA: 0x00B43B7A File Offset: 0x00B41D7A
		public static WeatherModel Instance
		{
			get
			{
				return WeatherModel._Instance;
			}
		}

		// Token: 0x06030830 RID: 198704 RVA: 0x00B43B81 File Offset: 0x00B41D81
		public static WeatherModel GetOrCreateInstance()
		{
			if (WeatherModel._Instance == null)
			{
				WeatherModel.CreateInstance();
			}
			return WeatherModel._Instance;
		}

		// Token: 0x06030831 RID: 198705 RVA: 0x00B43B95 File Offset: 0x00B41D95
		public static bool CreateInstance()
		{
			if (WeatherModel._Instance != null)
			{
				return true;
			}
			WeatherModel._Instance = new WeatherModel();
			return true;
		}

		// Token: 0x06030832 RID: 198706 RVA: 0x00B43BAB File Offset: 0x00B41DAB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06030833 RID: 198707 RVA: 0x00B43BAD File Offset: 0x00B41DAD
		public static void ResetStaticDefaultValue()
		{
			WeatherModel._Instance = null;
		}

		// Token: 0x06030834 RID: 198708 RVA: 0x00B43BB5 File Offset: 0x00B41DB5
		static WeatherModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WeatherModel.CreateStaticDefaultValue), new Action(WeatherModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401A0DF RID: 106719
		private readonly WeatherActor WorldWeatherActor = new WeatherActor();

		// Token: 0x0401A0E0 RID: 106720
		private int WeatherId;

		// Token: 0x0401A0E1 RID: 106721
		private readonly HashSet<int> UnlockedWeatherSwitchConfigIdSet = new HashSet<int>();

		// Token: 0x0401A0E2 RID: 106722
		[Nullable(2)]
		private HashSet<int> ClickedWeatherSwitchConfigIdSetInternal;

		// Token: 0x0401A0E3 RID: 106723
		[Nullable(2)]
		private Dictionary<int, int> WeatherIdToWeatherSwitchConfigIdMap;

		// Token: 0x0401A0E4 RID: 106724
		[Nullable(2)]
		private HashSet<int> ValidAreaIdSet;

		// Token: 0x0401A0E5 RID: 106725
		public double LastSwitchTime;

		// Token: 0x0401A0E6 RID: 106726
		public bool TimeSwitchConfirmNeedShow = true;

		// Token: 0x0401A0E7 RID: 106727
		[Nullable(2)]
		private ObservatoryModule ObservatoryModuleInternal;

		// Token: 0x0401A0E8 RID: 106728
		private int? TargetWeatherSwitchConfigIdInternal;

		// Token: 0x0401A0E9 RID: 106729
		[Nullable(2)]
		private static WeatherModel _Instance;
	}
}
