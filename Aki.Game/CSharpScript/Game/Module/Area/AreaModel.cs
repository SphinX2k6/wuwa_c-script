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
	// Token: 0x02005EA2 RID: 24226
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AreaModel : ModelBase
	{
		// Token: 0x0603DA4A RID: 252490 RVA: 0x00EE25AC File Offset: 0x00EE07AC
		protected override bool OnInit()
		{
			this.SetAreaInfo(1);
			this.TipsShowCd = ConfigCommonParamById.GetIntConfig("AreaTipsShowCd").GetValueOrDefault();
			return true;
		}

		// Token: 0x0603DA4B RID: 252491 RVA: 0x00EE25D9 File Offset: 0x00EE07D9
		protected override bool OnClear()
		{
			this.AreaStates.Clear();
			this.Areas.Clear();
			this.TipsLastShowTime.Clear();
			this.StreamingBlockedAreas.Clear();
			return true;
		}

		// Token: 0x17008EA8 RID: 36520
		// (get) Token: 0x0603DA4C RID: 252492 RVA: 0x00EE2608 File Offset: 0x00EE0808
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

		// Token: 0x17008EA9 RID: 36521
		// (get) Token: 0x0603DA4D RID: 252493 RVA: 0x00EE2644 File Offset: 0x00EE0844
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

		// Token: 0x0603DA4E RID: 252494 RVA: 0x00EE26BF File Offset: 0x00EE08BF
		public void SetEnableAreaNamePrompt(bool disable)
		{
			this.EnableAreaNamePrompt = !disable;
		}

		// Token: 0x17008EAA RID: 36522
		// (get) Token: 0x0603DA4F RID: 252495 RVA: 0x00EE26CB File Offset: 0x00EE08CB
		public Area? AreaInfo
		{
			get
			{
				return this.CurAreaInfo;
			}
		}

		// Token: 0x17008EAB RID: 36523
		// (get) Token: 0x0603DA50 RID: 252496 RVA: 0x00EE26D3 File Offset: 0x00EE08D3
		public Dictionary<int, TsTriggerVolume> AllAreas
		{
			get
			{
				return this.Areas;
			}
		}

		// Token: 0x0603DA51 RID: 252497 RVA: 0x00EE26DB File Offset: 0x00EE08DB
		public int GetCurrentAreaId(EAreaLevel? areaLevel = null)
		{
			return this.GetAreaId(this.CurAreaInfo.Value, areaLevel);
		}

		// Token: 0x0603DA52 RID: 252498 RVA: 0x00EE26F0 File Offset: 0x00EE08F0
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

		// Token: 0x0603DA53 RID: 252499 RVA: 0x00EE2760 File Offset: 0x00EE0960
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

		// Token: 0x0603DA54 RID: 252500 RVA: 0x00EE27E4 File Offset: 0x00EE09E4
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

		// Token: 0x0603DA55 RID: 252501 RVA: 0x00EE2880 File Offset: 0x00EE0A80
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

		// Token: 0x0603DA56 RID: 252502 RVA: 0x00EE28F8 File Offset: 0x00EE0AF8
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

		// Token: 0x0603DA57 RID: 252503 RVA: 0x00EE2A18 File Offset: 0x00EE0C18
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

		// Token: 0x0603DA58 RID: 252504 RVA: 0x00EE2B08 File Offset: 0x00EE0D08
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

		// Token: 0x0603DA59 RID: 252505 RVA: 0x00EE2BCC File Offset: 0x00EE0DCC
		[NullableContext(2)]
		public TsTriggerVolume GetArea(int inAreaId)
		{
			TsTriggerVolume result;
			this.Areas.TryGetValue(inAreaId, out result);
			return result;
		}

		// Token: 0x0603DA5A RID: 252506 RVA: 0x00EE2BEC File Offset: 0x00EE0DEC
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

		// Token: 0x0603DA5B RID: 252507 RVA: 0x00EE2CCC File Offset: 0x00EE0ECC
		public bool? GetAreaState(int inAreaId)
		{
			bool value;
			if (this.AreaStates.TryGetValue(inAreaId, out value))
			{
				return new bool?(value);
			}
			return null;
		}

		// Token: 0x0603DA5C RID: 252508 RVA: 0x00EE2CFC File Offset: 0x00EE0EFC
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

		// Token: 0x0603DA5D RID: 252509 RVA: 0x00EE2D70 File Offset: 0x00EE0F70
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

		// Token: 0x0603DA5E RID: 252510 RVA: 0x00EE2E1C File Offset: 0x00EE101C
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

		// Token: 0x0603DA5F RID: 252511 RVA: 0x00EE2E80 File Offset: 0x00EE1080
		public IReadOnlyDictionary<int, bool> GetAreaStates()
		{
			return this.AreaStates;
		}

		// Token: 0x0603DA60 RID: 252512 RVA: 0x00EE2E88 File Offset: 0x00EE1088
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

		// Token: 0x0603DA61 RID: 252513 RVA: 0x00EE2F44 File Offset: 0x00EE1144
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

		// Token: 0x0603DA62 RID: 252514 RVA: 0x00EE3050 File Offset: 0x00EE1250
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

		// Token: 0x0603DA63 RID: 252515 RVA: 0x00EE3080 File Offset: 0x00EE1280
		public bool IsExistRecommendPlayPoint()
		{
			ExploreAreaData currentExploreAreaData = this.GetCurrentExploreAreaData();
			return currentExploreAreaData != null && currentExploreAreaData.IsShowRecommendPlayPoint();
		}

		// Token: 0x0603DA64 RID: 252516 RVA: 0x00EE3094 File Offset: 0x00EE1294
		[NullableContext(2)]
		public ExploreAreaData GetCurrentExploreAreaData()
		{
			int worldMapLevelOneAreaId = MapUtil.GetWorldMapLevelOneAreaId();
			return ExploreProgressModel.Instance.GetExploreAreaData(worldMapLevelOneAreaId);
		}

		// Token: 0x0603DA65 RID: 252517 RVA: 0x00EE30B4 File Offset: 0x00EE12B4
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
			while (num != null)
			{
				num = new int?(AreaConfig.Instance.GetParentAreaId(num.Value));
				int? num2 = num;
				if (num2 == null)
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

		// Token: 0x17008EAC RID: 36524
		// (get) Token: 0x0603DA66 RID: 252518 RVA: 0x00EE320B File Offset: 0x00EE140B
		public static AreaModel Instance
		{
			get
			{
				return AreaModel._Instance;
			}
		}

		// Token: 0x0603DA67 RID: 252519 RVA: 0x00EE3212 File Offset: 0x00EE1412
		public static AreaModel GetOrCreateInstance()
		{
			if (AreaModel._Instance == null)
			{
				AreaModel.CreateInstance();
			}
			return AreaModel._Instance;
		}

		// Token: 0x0603DA68 RID: 252520 RVA: 0x00EE3226 File Offset: 0x00EE1426
		public static bool CreateInstance()
		{
			if (AreaModel._Instance != null)
			{
				return true;
			}
			AreaModel._Instance = new AreaModel();
			return true;
		}

		// Token: 0x0603DA69 RID: 252521 RVA: 0x00EE323C File Offset: 0x00EE143C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DA6A RID: 252522 RVA: 0x00EE323E File Offset: 0x00EE143E
		public static void ResetStaticDefaultValue()
		{
			AreaModel._Instance = null;
		}

		// Token: 0x0603DA6B RID: 252523 RVA: 0x00EE3246 File Offset: 0x00EE1446
		static AreaModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AreaModel.CreateStaticDefaultValue), new Action(AreaModel.ResetStaticDefaultValue));
		}

		// Token: 0x04020290 RID: 131728
		private const int DEFAULT_AREA_ID = 1;

		// Token: 0x04020291 RID: 131729
		private Area? CurAreaInfo;

		// Token: 0x04020292 RID: 131730
		private string CurAreaDisplayNameId = "";

		// Token: 0x04020293 RID: 131731
		private readonly Dictionary<int, TsTriggerVolume> Areas = new Dictionary<int, TsTriggerVolume>();

		// Token: 0x04020294 RID: 131732
		private readonly Dictionary<int, bool> AreaStates = new Dictionary<int, bool>();

		// Token: 0x04020295 RID: 131733
		private readonly Dictionary<int, int> TipsLastShowTime = new Dictionary<int, int>();

		// Token: 0x04020296 RID: 131734
		private int TipsShowCd;

		// Token: 0x04020297 RID: 131735
		private readonly HashSet<int> StreamingBlockedAreas = new HashSet<int>();

		// Token: 0x04020298 RID: 131736
		private bool EnableAreaNamePrompt = true;

		// Token: 0x04020299 RID: 131737
		[Nullable(2)]
		private static AreaModel _Instance;

		// Token: 0x0200C213 RID: 49683
		[NullableContext(0)]
		public enum EAreaDangerLevel
		{
			// Token: 0x0403AA45 RID: 240197
			High,
			// Token: 0x0403AA46 RID: 240198
			Mid,
			// Token: 0x0403AA47 RID: 240199
			Normal
		}
	}
}
