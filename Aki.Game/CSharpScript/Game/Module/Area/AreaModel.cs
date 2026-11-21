using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02004E87 RID: 20103
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AreaModel : ModelBase
	{
		// Token: 0x060329DA RID: 207322 RVA: 0x00E33AE4 File Offset: 0x00E31CE4
		protected override bool OnInit()
		{
			this.SetAreaInfo(1);
			this.TipsShowCd = ConfigCommonParamById.GetIntConfig("AreaTipsShowCd").GetValueOrDefault();
			return true;
		}

		// Token: 0x060329DB RID: 207323 RVA: 0x00E33B11 File Offset: 0x00E31D11
		protected override bool OnClear()
		{
			this.AreaStates.Clear();
			this.Areas.Clear();
			this.TipsLastShowTime.Clear();
			this.StreamingBlockedAreas.Clear();
			return true;
		}

		// Token: 0x1700627A RID: 25210
		// (get) Token: 0x060329DC RID: 207324 RVA: 0x00E33B40 File Offset: 0x00E31D40
		[Nullable(2)]
		public string AreaName
		{
			[NullableContext(2)]
			get
			{
				if (this.CurAreaInfo != null)
				{
					return AreaConfig.Instance.GetAreaLocalName(this.CurAreaInfo.Value.Title);
				}
				return null;
			}
		}

		// Token: 0x1700627B RID: 25211
		// (get) Token: 0x060329DD RID: 207325 RVA: 0x00E33B7C File Offset: 0x00E31D7C
		[Nullable(2)]
		public string AreaHintName
		{
			[NullableContext(2)]
			get
			{
				if (this.CurAreaInfo == null)
				{
					return null;
				}
				if (string.IsNullOrEmpty(this.CurAreaDisplayNameId))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Area;
					ELogAuthor author = ELogAuthor.YZH;
					string message = "[区域.xlsx]当前需要显示的区域提示没有配置对应文本";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("区域id", this.CurAreaInfo.Value.AreaId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return null;
				}
				return AreaConfig.Instance.GetAreaLocalName(this.CurAreaDisplayNameId);
			}
		}

		// Token: 0x060329DE RID: 207326 RVA: 0x00E33BF7 File Offset: 0x00E31DF7
		public void SetEnableAreaNamePrompt(bool disable)
		{
			this.EnableAreaNamePrompt = !disable;
		}

		// Token: 0x1700627C RID: 25212
		// (get) Token: 0x060329DF RID: 207327 RVA: 0x00E33C03 File Offset: 0x00E31E03
		public Area? AreaInfo
		{
			get
			{
				return this.CurAreaInfo;
			}
		}

		// Token: 0x1700627D RID: 25213
		// (get) Token: 0x060329E0 RID: 207328 RVA: 0x00E33C0B File Offset: 0x00E31E0B
		public Dictionary<int, TsTriggerVolume> AllAreas
		{
			get
			{
				return this.Areas;
			}
		}

		// Token: 0x060329E1 RID: 207329 RVA: 0x00E33C13 File Offset: 0x00E31E13
		public int GetCurrentAreaId(EAreaLevel? areaLevel = null)
		{
			return this.GetAreaId(this.CurAreaInfo.Value, areaLevel);
		}

		// Token: 0x060329E2 RID: 207330 RVA: 0x00E33C28 File Offset: 0x00E31E28
		public int GetAreaId(Area targetAreaInfo, EAreaLevel? areaLevel = null)
		{
			if (areaLevel == null)
			{
				return targetAreaInfo.AreaId;
			}
			AreaConfig instance = AreaConfig.Instance;
			int num = targetAreaInfo.AreaId;
			Area? areaInfo = instance.GetAreaInfo(num);
			while (areaInfo != null && areaInfo.Value.Level != (int)areaLevel.Value)
			{
				num = areaInfo.Value.Father;
				areaInfo = instance.GetAreaInfo(num);
			}
			return num;
		}

		// Token: 0x060329E3 RID: 207331 RVA: 0x00E33C98 File Offset: 0x00E31E98
		public List<int> GetAllAreaIdInheritable(Area targetAreaInfo)
		{
			List<int> list = new List<int>();
			list.Add(targetAreaInfo.AreaId);
			AreaConfig instance = AreaConfig.Instance;
			int num = targetAreaInfo.Father;
			Area? area = (num == 0) ? null : instance.GetAreaInfo(num);
			while (num != 0 && area != null)
			{
				list.Add(num);
				int father = area.Value.Father;
				if (num == father || father == 0)
				{
					break;
				}
				num = father;
				area = instance.GetAreaInfo(num);
			}
			return list;
		}

		// Token: 0x060329E4 RID: 207332 RVA: 0x00E33D1C File Offset: 0x00E31F1C
		public List<int> GetAllAreaIdInheritableById(int targetAreaId)
		{
			List<int> list = new List<int>();
			AreaConfig instance = AreaConfig.Instance;
			Area? areaInfo = instance.GetAreaInfo(targetAreaId);
			if (areaInfo == null)
			{
				return list;
			}
			list.Add(targetAreaId);
			int num = areaInfo.Value.Father;
			Area? area = (num == 0) ? null : instance.GetAreaInfo(num);
			while (num != 0 && area != null)
			{
				list.Add(num);
				int father = area.Value.Father;
				if (num == father || father == 0)
				{
					break;
				}
				num = father;
				area = instance.GetAreaInfo(num);
			}
			return list;
		}

		// Token: 0x060329E5 RID: 207333 RVA: 0x00E33DB8 File Offset: 0x00E31FB8
		public void SetAreaInfo(int areaId)
		{
			if (areaId == 0)
			{
				return;
			}
			if (this.CurAreaInfo != null && this.CurAreaInfo.Value.Level == 2)
			{
				MapModel.Instance.LastHighLevelArea = new int?(this.CurAreaInfo.Value.AreaId);
			}
			this.CurAreaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			PlayerInfoModel instance = PlayerInfoModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetNumberPropById(EPlayerInfoNumber.AreaId, areaId);
		}

		// Token: 0x060329E6 RID: 207334 RVA: 0x00E33E30 File Offset: 0x00E32030
		public void SetAreaName(int areaId, bool timerIgnore = false)
		{
			int? p = (this.CurAreaInfo != null) ? new int?(this.CurAreaInfo.GetValueOrDefault().AreaId) : null;
			this.SetAreaInfo(areaId);
			if (this.CurAreaInfo.Value.Tips == 0)
			{
				EventSystem.Instance.Emit<int?, int>(EEventName.ChangeArea, p, areaId);
				return;
			}
			this.CurAreaDisplayNameId = this.CurAreaInfo.Value.Title;
			int num;
			this.TipsLastShowTime.TryGetValue(areaId, out num);
			if ((!this.TipsLastShowTime.ContainsKey(areaId) || timerIgnore || Time.Instance.PlayerTime - (double)num > (double)this.TipsShowCd) && this.EnableAreaNamePrompt)
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.AreaView))
				{
					EventSystem.Instance.Emit(EEventName.UpdateAreaView);
				}
				else
				{
					UiManager.Instance.OpenView(EUiViewName.AreaView, null, null);
				}
				this.TipsLastShowTime[areaId] = (int)Time.Instance.PlayerTime;
			}
			EventSystem.Instance.Emit<int?, int>(EEventName.ChangeArea, p, areaId);
		}

		// Token: 0x060329E7 RID: 207335 RVA: 0x00E33F50 File Offset: 0x00E32150
		public unsafe void AddArea(int inAreaId, TsTriggerVolume inArea)
		{
			if (this.Areas.ContainsKey(inAreaId))
			{
				return;
			}
			if (this.StreamingBlockedAreas.Contains(inAreaId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Area;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "传送时应该完成流送的Volume加载完成并触发BeginPlay";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurAreaId", (this.CurAreaInfo != null) ? new int?(this.CurAreaInfo.GetValueOrDefault().AreaId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BlockedAreaId", inAreaId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StreamingBlockedAreas", this.StreamingBlockedAreas);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.StreamingBlockedAreas.Remove(inAreaId);
			}
			this.Areas[inAreaId] = inArea;
		}

		// Token: 0x060329E8 RID: 207336 RVA: 0x00E34040 File Offset: 0x00E32240
		public unsafe void AddWatchArea(int inAreaId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Area;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "传送时应该完成流送的Volume实际上没有加载出来";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurAreaId", (this.CurAreaInfo != null) ? new int?(this.CurAreaInfo.GetValueOrDefault().AreaId) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BlockedAreaId", inAreaId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StreamingBlockedAreas", this.StreamingBlockedAreas);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.StreamingBlockedAreas.Add(inAreaId);
		}

		// Token: 0x060329E9 RID: 207337 RVA: 0x00E34104 File Offset: 0x00E32304
		[NullableContext(2)]
		public TsTriggerVolume GetArea(int inAreaId)
		{
			TsTriggerVolume result;
			this.Areas.TryGetValue(inAreaId, out result);
			return result;
		}

		// Token: 0x060329EA RID: 207338 RVA: 0x00E34124 File Offset: 0x00E32324
		public unsafe void RemoveArea(int inAreaId)
		{
			this.Areas.Remove(inAreaId);
			if (this.StreamingBlockedAreas.Contains(inAreaId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Area;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "传送时应该完成流送的Volume触发了EndPlay";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurAreaId", (this.CurAreaInfo != null) ? new int?(this.CurAreaInfo.GetValueOrDefault().AreaId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BlockedAreaId", inAreaId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StreamingBlockedAreas", this.StreamingBlockedAreas);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.StreamingBlockedAreas.Remove(inAreaId);
			}
		}

		// Token: 0x060329EB RID: 207339 RVA: 0x00E34204 File Offset: 0x00E32404
		public bool? GetAreaState(int inAreaId)
		{
			bool value;
			if (this.AreaStates.TryGetValue(inAreaId, out value))
			{
				return new bool?(value);
			}
			return null;
		}

		// Token: 0x060329EC RID: 207340 RVA: 0x00E34234 File Offset: 0x00E32434
		public void ToggleAreaState(int inAreaId, bool inEnable)
		{
			TsTriggerVolume tsTriggerVolume2;
			TsTriggerVolume tsTriggerVolume = this.Areas.TryGetValue(inAreaId, out tsTriggerVolume2) ? tsTriggerVolume2 : null;
			bool value;
			bool? flag = this.AreaStates.TryGetValue(inAreaId, out value) ? new bool?(value) : null;
			if (flag.GetValueOrDefault() == inEnable & flag != null)
			{
				return;
			}
			this.AreaStates[inAreaId] = inEnable;
			if (tsTriggerVolume != null)
			{
				tsTriggerVolume.ToggleArea(inEnable);
			}
		}

		// Token: 0x060329ED RID: 207341 RVA: 0x00E342A8 File Offset: 0x00E324A8
		public void InitAreaStates(IReadOnlyList<Area> defaultAreaInfos, IReadOnlyList<SceneAreaState> modifiedAreaStates)
		{
			this.AreaStates.Clear();
			foreach (Area area in defaultAreaInfos)
			{
				this.AreaStates[area.AreaId] = area.IsInitActived;
			}
			foreach (SceneAreaState sceneAreaState in modifiedAreaStates)
			{
				this.AreaStates[sceneAreaState.AreaId] = sceneAreaState.State;
			}
		}

		// Token: 0x060329EE RID: 207342 RVA: 0x00E34354 File Offset: 0x00E32554
		public void InitArea(IReadOnlyList<SceneAreaState> initModifiedAreaStates)
		{
			List<Area> defaultAreaInfos = AreaConfig.Instance.GetAllAreaInfo() ?? new List<Area>();
			this.InitAreaStates(defaultAreaInfos, initModifiedAreaStates);
			int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.AreaId);
			if (numberPropById != null && numberPropById.GetValueOrDefault() != 0)
			{
				AreaController.Instance.EnterAreaRequest(new int?(1), numberPropById.Value, false, "AreaModel.InitArea");
			}
		}

		// Token: 0x060329EF RID: 207343 RVA: 0x00E343B8 File Offset: 0x00E325B8
		public IReadOnlyDictionary<int, bool> GetAreaStates()
		{
			return this.AreaStates;
		}

		// Token: 0x060329F0 RID: 207344 RVA: 0x00E343C0 File Offset: 0x00E325C0
		public int? GetAreaCountryId()
		{
			if (this.CurAreaInfo == null)
			{
				Log.Instance.Error(ELogModule.Area, ELogAuthor.XXJ, "区域数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (this.CurAreaInfo.Value.CountryId == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Area;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[区域.xlsx]当前区域没有配置所属国家id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("区域id", this.CurAreaInfo.Value.AreaId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new int?(this.CurAreaInfo.Value.CountryId);
		}

		// Token: 0x060329F1 RID: 207345 RVA: 0x00E3447C File Offset: 0x00E3267C
		public AreaModel.EAreaDangerLevel GetAreaDangerLevel()
		{
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			int num = 0;
			foreach (RoleInstance roleInstance in roleList)
			{
				if (num < roleInstance.GetLevelData().GetLevel())
				{
					num = roleInstance.GetLevelData().GetLevel();
				}
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("HighDangerLevelOffset");
			int? intConfig2 = ConfigCommonParamById.GetIntConfig("MidDangerLevelOffset");
			int? num2 = null;
			if (this.CurAreaInfo != null)
			{
				int? num3 = this.CurAreaInfo.Value.GetWorldMonsterLevelMax(WorldLevelModel.Instance.CurWorldLevel);
				if (num3 != null)
				{
					int valueOrDefault = num3.GetValueOrDefault();
					num2 = new int?(valueOrDefault);
				}
			}
			if (num2 != null)
			{
				int? num3 = num2;
				int i = 0;
				if (!(num3.GetValueOrDefault() == i & num3 != null))
				{
					int num4 = num - num2.Value;
					if (num4 < intConfig2.Value && num4 >= intConfig.Value)
					{
						return AreaModel.EAreaDangerLevel.Mid;
					}
					if (num4 < intConfig.Value)
					{
						return AreaModel.EAreaDangerLevel.High;
					}
				}
			}
			return AreaModel.EAreaDangerLevel.Normal;
		}

		// Token: 0x060329F2 RID: 207346 RVA: 0x00E34588 File Offset: 0x00E32788
		public string GetAreaDangerText(AreaModel.EAreaDangerLevel dangerLevel)
		{
			if (dangerLevel == AreaModel.EAreaDangerLevel.High)
			{
				return TextConfig.Instance.GetTextById("AreaHighDangerText");
			}
			if (dangerLevel != AreaModel.EAreaDangerLevel.Mid)
			{
				return "";
			}
			return TextConfig.Instance.GetTextById("AreaHighMidText");
		}

		// Token: 0x060329F3 RID: 207347 RVA: 0x00E345B8 File Offset: 0x00E327B8
		public bool IsExistRecommendPlayPoint()
		{
			ExploreAreaData currentExploreAreaData = this.GetCurrentExploreAreaData();
			return currentExploreAreaData != null && currentExploreAreaData.IsShowRecommendPlayPoint();
		}

		// Token: 0x060329F4 RID: 207348 RVA: 0x00E345CC File Offset: 0x00E327CC
		[NullableContext(2)]
		public ExploreAreaData GetCurrentExploreAreaData()
		{
			int worldMapLevelOneAreaId = MapUtil.GetWorldMapLevelOneAreaId();
			return ExploreProgressModel.Instance.GetExploreAreaData(worldMapLevelOneAreaId);
		}

		// Token: 0x060329F5 RID: 207349 RVA: 0x00E345EC File Offset: 0x00E327EC
		public string GetDebugString()
		{
			string text = "";
			Area? areaInfo = this.AreaInfo;
			int? num = (areaInfo != null) ? new int?(areaInfo.GetValueOrDefault().AreaId) : null;
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("当前区域:");
			defaultInterpolatedStringHandler.AppendFormatted<int?>(num);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			string str2 = text;
			string str3 = "\t关联区块:";
			areaInfo = this.AreaInfo;
			text = str2 + str3 + ((areaInfo != null) ? areaInfo.GetValueOrDefault().AreaName : null) + "\n";
			while (num != null && num.GetValueOrDefault() > 0)
			{
				num = new int?(AreaConfig.Instance.GetParentAreaId(num.Value));
				if (!(num > 0))
				{
					break;
				}
				string str4 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("父级区域:");
				defaultInterpolatedStringHandler.AppendFormatted<int?>(num);
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
				string str5 = text;
				string str6 = "\t关联区块:";
				areaInfo = AreaConfig.Instance.GetAreaInfo(num.Value);
				text = str5 + str6 + ((areaInfo != null) ? areaInfo.GetValueOrDefault().AreaName : null) + "\n";
			}
			return text;
		}

		// Token: 0x1700627E RID: 25214
		// (get) Token: 0x060329F6 RID: 207350 RVA: 0x00E34757 File Offset: 0x00E32957
		public static AreaModel Instance
		{
			get
			{
				return AreaModel._Instance;
			}
		}

		// Token: 0x060329F7 RID: 207351 RVA: 0x00E3475E File Offset: 0x00E3295E
		public static AreaModel GetOrCreateInstance()
		{
			if (AreaModel._Instance == null)
			{
				AreaModel.CreateInstance();
			}
			return AreaModel._Instance;
		}

		// Token: 0x060329F8 RID: 207352 RVA: 0x00E34772 File Offset: 0x00E32972
		public static bool CreateInstance()
		{
			if (AreaModel._Instance != null)
			{
				return true;
			}
			AreaModel._Instance = new AreaModel();
			return true;
		}

		// Token: 0x060329F9 RID: 207353 RVA: 0x00E34788 File Offset: 0x00E32988
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060329FA RID: 207354 RVA: 0x00E3478A File Offset: 0x00E3298A
		public static void ResetStaticDefaultValue()
		{
			AreaModel._Instance = null;
		}

		// Token: 0x060329FB RID: 207355 RVA: 0x00E34792 File Offset: 0x00E32992
		static AreaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AreaModel.CreateStaticDefaultValue), new Action(AreaModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AD57 RID: 109911
		private const int DEFAULT_AREA_ID = 1;

		// Token: 0x0401AD58 RID: 109912
		private Area? CurAreaInfo;

		// Token: 0x0401AD59 RID: 109913
		private string CurAreaDisplayNameId = "";

		// Token: 0x0401AD5A RID: 109914
		private readonly Dictionary<int, TsTriggerVolume> Areas = new Dictionary<int, TsTriggerVolume>();

		// Token: 0x0401AD5B RID: 109915
		private readonly Dictionary<int, bool> AreaStates = new Dictionary<int, bool>();

		// Token: 0x0401AD5C RID: 109916
		private readonly Dictionary<int, int> TipsLastShowTime = new Dictionary<int, int>();

		// Token: 0x0401AD5D RID: 109917
		private int TipsShowCd;

		// Token: 0x0401AD5E RID: 109918
		private readonly HashSet<int> StreamingBlockedAreas = new HashSet<int>();

		// Token: 0x0401AD5F RID: 109919
		private bool EnableAreaNamePrompt = true;

		// Token: 0x0401AD60 RID: 109920
		[Nullable(2)]
		private static AreaModel _Instance;

		// Token: 0x0200AC22 RID: 44066
		[NullableContext(0)]
		public enum EAreaDangerLevel
		{
			// Token: 0x04035437 RID: 218167
			High,
			// Token: 0x04035438 RID: 218168
			Mid,
			// Token: 0x04035439 RID: 218169
			Normal
		}
	}
}
