using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.MailBind;
using CSharpScript.Game.Module.RecallQuest.Model;

// Token: 0x02001C49 RID: 7241
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FunctionModel : ModelBase
{
	// Token: 0x0600DA55 RID: 55893 RVA: 0x0032B598 File Offset: 0x00329798
	protected override bool OnInit()
	{
		this.ExCheckConditionMap[EFunctionType.Activity] = new Func<bool>(this.CheckActivityOpen);
		this.ExCheckConditionMap[EFunctionType.UserFeedback] = new Func<bool>(this.CheckCustomerServiceOpen);
		this.ExCheckConditionMap[EFunctionType.KuroStreet] = new Func<bool>(this.CheckKuroStreetOpen);
		this.ExCheckConditionMap[EFunctionType.MailBind] = new Func<bool>(this.CheckMailBindOpen);
		this.ExCheckConditionMap[EFunctionType.DirectTrainPro] = new Func<bool>(this.CheckDirectTrainProOpen);
		this.ExCheckConditionMap[EFunctionType.GameIntroduction] = new Func<bool>(this.CheckPioneerClientLimit);
		return true;
	}

	// Token: 0x0600DA56 RID: 55894 RVA: 0x0032B64E File Offset: 0x0032984E
	private bool CheckActivityOpen()
	{
		return ActivityModel.Instance.GetIfShowActivity();
	}

	// Token: 0x0600DA57 RID: 55895 RVA: 0x0032B65A File Offset: 0x0032985A
	private bool CheckCustomerServiceOpen()
	{
		return KuroSdkController.Instance.NeedShowCustomerService();
	}

	// Token: 0x0600DA58 RID: 55896 RVA: 0x0032B666 File Offset: 0x00329866
	private bool CheckKuroStreetOpen()
	{
		return ChannelController.Instance.CheckKuroStreetOpen();
	}

	// Token: 0x0600DA59 RID: 55897 RVA: 0x0032B672 File Offset: 0x00329872
	private bool CheckMailBindOpen()
	{
		return MailBindModel.Instance.CheckGlobalMailBindOpen();
	}

	// Token: 0x0600DA5A RID: 55898 RVA: 0x0032B67E File Offset: 0x0032987E
	private bool CheckDirectTrainProOpen()
	{
		return ActivityDirectTrainHelper.IsProOpen;
	}

	// Token: 0x0600DA5B RID: 55899 RVA: 0x0032B685 File Offset: 0x00329885
	private bool CheckPioneerClientLimit()
	{
		return !FeatureRestrictionTemplate.TemplateForPioneerClient.Check();
	}

	// Token: 0x0600DA5C RID: 55900 RVA: 0x0032B694 File Offset: 0x00329894
	[NullableContext(2)]
	public void SetFunctionOpenInfo(FuncOpenNotify funcOpenNotify)
	{
		if (funcOpenNotify == null)
		{
			return;
		}
		foreach (Function function in funcOpenNotify.Func)
		{
			FunctionInstance functionInstance = new FunctionInstance(function.Flag, (EFunctionType)function.Id);
			this.FunctionMap[function.Id] = new FunctionInstance(function.Flag, (EFunctionType)function.Id);
			bool isOpen = functionInstance.GetIsOpen();
			EventSystem.Instance.Emit<EFunctionType, bool>(EEventName.OnFunctionOpenSet, (EFunctionType)function.Id, isOpen);
		}
	}

	// Token: 0x0600DA5D RID: 55901 RVA: 0x0032B730 File Offset: 0x00329930
	[NullableContext(2)]
	public void UpdateFunctionOpenInfo(FuncOpenUpdateNotify functionOpenUpdateNotify)
	{
		if (functionOpenUpdateNotify == null)
		{
			return;
		}
		foreach (Function function in functionOpenUpdateNotify.Func)
		{
			FunctionInstance functionInstance;
			if (!this.FunctionMap.TryGetValue(function.Id, out functionInstance))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Functional;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "当前刷新的功能id不在功能列表中";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("功能Id", function.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				functionInstance.SetFlag(function.Flag);
				bool isOpen = functionInstance.GetIsOpen();
				if (isOpen)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Functional;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "功能数据更新";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", function.Id);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				EventSystem.Instance.Emit<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, (EFunctionType)function.Id, isOpen);
				FunctionCondition? config = ConfigFunctionConditionByFunctionId.GetConfig(function.Id, true);
				if (isOpen && (config != null && config.GetValueOrDefault().ShowUIType == 1) && !SundryModel.Instance.IsBlockTips && !functionOpenUpdateNotify.Silent)
				{
					this.NewOpenFunctionList.Add(config.Value);
				}
				if (SundryModel.Instance.IsBlockTips)
				{
					Log.Instance.Info(ELogModule.Functional, ELogAuthor.XXJ, "[UpdateFunctionOpenInfo]用了GM屏蔽功能开启界面显示", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}
		EventSystem.Instance.Emit(EEventName.OnFunctionOpenUpdateNotify);
	}

	// Token: 0x0600DA5E RID: 55902 RVA: 0x0032B8CC File Offset: 0x00329ACC
	public unsafe void UpdateFunctionOpenLockByBehaviorTree(int functionId, bool isLockByBehaviorTree)
	{
		FunctionInstance functionInstance;
		if (!this.FunctionMap.TryGetValue(functionId, out functionInstance))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[BehaviorTree]当前的功能id不在功能列表中";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("功能Id", functionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		functionInstance.SetIsLockByBehaviorTree(isLockByBehaviorTree);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Functional;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "[UpdateFunctionOpenLockByBehaviorTree]行为树执行了系统功能的启用/禁用";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("功能ID", functionId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否禁用", isLockByBehaviorTree);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600DA5F RID: 55903 RVA: 0x0032B97C File Offset: 0x00329B7C
	public void RefreshInfoManualState(int[] functionIdList)
	{
		foreach (int num in functionIdList)
		{
			FunctionInstance functionInstance;
			if (!this.FunctionMap.TryGetValue(num, out functionInstance))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Functional;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "当前刷新的功能id不在功能列表中";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("功能Id", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				FunctionCondition? config = ConfigFunctionConditionByFunctionId.GetConfig(num, true);
				if (functionInstance.GetIsOpen() && !SundryModel.Instance.IsBlockTips && config != null)
				{
					this.NewOpenFunctionList.Add(config.Value);
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Functional;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "手动开启功能开启界面成功";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("FunctionId", num);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				if (SundryModel.Instance.IsBlockTips)
				{
					Log.Instance.Info(ELogModule.Functional, ELogAuthor.XXJ, "[RefreshInfoManualState]用了GM屏蔽功能开启界面显示", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}
	}

	// Token: 0x0600DA60 RID: 55904 RVA: 0x0032BA78 File Offset: 0x00329C78
	public FunctionCondition? PopNewOpenFunctionList()
	{
		if (this.IsExistNewOpenFunction())
		{
			FunctionCondition value = this.NewOpenFunctionList[0];
			this.NewOpenFunctionList.RemoveAt(0);
			return new FunctionCondition?(value);
		}
		return null;
	}

	// Token: 0x0600DA61 RID: 55905 RVA: 0x0032BAB4 File Offset: 0x00329CB4
	public bool IsExistNewOpenFunction()
	{
		return this.NewOpenFunctionList.Count > 0;
	}

	// Token: 0x0600DA62 RID: 55906 RVA: 0x0032BAC4 File Offset: 0x00329CC4
	public void ClearNewOpenFunctionList()
	{
		this.NewOpenFunctionList = new List<FunctionCondition>();
	}

	// Token: 0x0600DA63 RID: 55907 RVA: 0x0032BAD4 File Offset: 0x00329CD4
	public List<int> GetNewOpenFunctionIdList()
	{
		List<int> list = new List<int>();
		foreach (FunctionCondition functionCondition in this.NewOpenFunctionList)
		{
			list.Add(functionCondition.FunctionId);
		}
		return list;
	}

	// Token: 0x170011D8 RID: 4568
	// (get) Token: 0x0600DA64 RID: 55908 RVA: 0x0032BB34 File Offset: 0x00329D34
	public int PlayerId
	{
		get
		{
			return PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		}
	}

	// Token: 0x0600DA65 RID: 55909 RVA: 0x0032BB54 File Offset: 0x00329D54
	[NullableContext(2)]
	public string GetPlayerName()
	{
		if (GlobalData.IsPlayInEditor)
		{
			string text = UiBlueprintFunctionLibrary.TestSceneLoadPlayer();
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return PlayerInfoModel.Instance.GetStringPropById(EPlayerInfoNumber.Name);
	}

	// Token: 0x0600DA66 RID: 55910 RVA: 0x0032BB83 File Offset: 0x00329D83
	public int? GetPlayerLevel()
	{
		return PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Level);
	}

	// Token: 0x0600DA67 RID: 55911 RVA: 0x0032BB90 File Offset: 0x00329D90
	public int? GetPlayerExp()
	{
		return PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Experience);
	}

	// Token: 0x0600DA68 RID: 55912 RVA: 0x0032BBA0 File Offset: 0x00329DA0
	public string GetPlayerCashCoin()
	{
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.CashCoin);
		if (numberPropById == null)
		{
			return "0";
		}
		return numberPropById.Value.ToString();
	}

	// Token: 0x0600DA69 RID: 55913 RVA: 0x0032BBD8 File Offset: 0x00329DD8
	public int? GetWorldPermission()
	{
		return PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.WorldPermission);
	}

	// Token: 0x0600DA6A RID: 55914 RVA: 0x0032BBE8 File Offset: 0x00329DE8
	[NullableContext(2)]
	public string GetFunctionHitTextId(int functionId)
	{
		FunctionCondition? config = ConfigFunctionConditionByFunctionId.GetConfig(functionId, true);
		if (config != null)
		{
			int openConditionId = config.Value.OpenConditionId;
			if (openConditionId != 0)
			{
				return LevelGeneralCommons.GetConditionGroupHintText(openConditionId);
			}
		}
		return null;
	}

	// Token: 0x0600DA6B RID: 55915 RVA: 0x0032BC21 File Offset: 0x00329E21
	public bool IsOpen(EFunctionType functionId)
	{
		return this.IsOpen((int)functionId);
	}

	// Token: 0x0600DA6C RID: 55916 RVA: 0x0032BC2C File Offset: 0x00329E2C
	public bool IsOpen(int functionId)
	{
		FunctionInstance functionInstance;
		return functionId == 0 || (this.FunctionMap.TryGetValue(functionId, out functionInstance) && functionInstance.GetIsOpen());
	}

	// Token: 0x0600DA6D RID: 55917 RVA: 0x0032BC58 File Offset: 0x00329E58
	public bool IsLimit(int functionId)
	{
		FunctionInstance valueOrDefault = this.FunctionMap.GetValueOrDefault(functionId);
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId != 0 && valueOrDefault != null)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				int[] array = config.GetValueOrDefault().FuncLimit();
				flag = ((array != null) ? new bool?(array.Contains(functionId)) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600DA6E RID: 55918 RVA: 0x0032BCD4 File Offset: 0x00329ED4
	public bool IsShow(int functionId)
	{
		FunctionInstance functionInstance;
		return this.FunctionMap.TryGetValue(functionId, out functionInstance) && functionInstance.GetIsShow();
	}

	// Token: 0x0600DA6F RID: 55919 RVA: 0x0032BCFC File Offset: 0x00329EFC
	public bool IsLockByBehaviorTree(int functionId)
	{
		FunctionInstance functionInstance;
		return functionId != 0 && this.FunctionMap.TryGetValue(functionId, out functionInstance) && functionInstance.GetIsLockByBehaviorTree();
	}

	// Token: 0x0600DA70 RID: 55920 RVA: 0x0032BD28 File Offset: 0x00329F28
	[NullableContext(2)]
	public FunctionInstance GetFunctionInstance(int functionId)
	{
		FunctionInstance result;
		this.FunctionMap.TryGetValue(functionId, out result);
		return result;
	}

	// Token: 0x0600DA71 RID: 55921 RVA: 0x0032BD48 File Offset: 0x00329F48
	public int[] GetShowFunctionIdList()
	{
		List<int> list = new List<int>();
		List<FunctionMenu> list2 = ConfigCommon.ToList<FunctionMenu>(FunctionConfig.Instance.GetAllFunctionList());
		if (list2 != null)
		{
			list2.Sort(delegate(FunctionMenu aConfig, FunctionMenu bConfig)
			{
				int num = aConfig.SortIndex - bConfig.SortIndex;
				if (num == 0)
				{
					return aConfig.FunctionId - bConfig.FunctionId;
				}
				return num;
			});
			foreach (FunctionMenu functionMenu in list2)
			{
				FunctionInstance functionInstance;
				if (this.FunctionMap.TryGetValue(functionMenu.FunctionId, out functionInstance))
				{
					Func<bool> func;
					this.ExCheckConditionMap.TryGetValue((EFunctionType)functionMenu.FunctionId, out func);
					bool flag = func == null || func();
					if (functionInstance.GetIsOpen() && flag)
					{
						list.Add(functionMenu.FunctionId);
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600DA72 RID: 55922 RVA: 0x0032BE2C File Offset: 0x0032A02C
	public ERedDotName? GetFunctionItemRedDotName(int functionId)
	{
		if (RecallQuestModel.Instance.IsInRecallInstance())
		{
			return null;
		}
		if (functionId <= 10072)
		{
			if (functionId <= 10040)
			{
				switch (functionId)
				{
				case 10001:
					return new ERedDotName?(ERedDotName.FunctionRole);
				case 10002:
					return new ERedDotName?(ERedDotName.FunctionInventory);
				case 10003:
					return new ERedDotName?(ERedDotName.FunctionCalabash);
				case 10004:
					return new ERedDotName?(ERedDotName.FunctionViewQuestBtn);
				case 10005:
				case 10006:
				case 10007:
				case 10008:
				case 10012:
				case 10014:
					break;
				case 10009:
					return new ERedDotName?(ERedDotName.FunctionGacha);
				case 10010:
					return new ERedDotName?(ERedDotName.FunctionPayShop);
				case 10011:
					return new ERedDotName?(ERedDotName.FunctionFriend);
				case 10013:
					return new ERedDotName?(ERedDotName.Achievement);
				case 10015:
					return new ERedDotName?(ERedDotName.FunctionMap);
				default:
					switch (functionId)
					{
					case 10022:
						return new ERedDotName?(ERedDotName.FunctionTutorial);
					case 10023:
						return new ERedDotName?(ERedDotName.FunctionAdventure);
					case 10024:
					case 10025:
					case 10027:
						break;
					case 10026:
						return new ERedDotName?(ERedDotName.FunctionPhantomExploreSet);
					case 10028:
						return new ERedDotName?(ERedDotName.CustomerService);
					case 10029:
						return new ERedDotName?(ERedDotName.InfluenceReputation);
					default:
						if (functionId == 10040)
						{
							return new ERedDotName?(ERedDotName.BattlePass);
						}
						break;
					}
					break;
				}
			}
			else if (functionId <= 10053)
			{
				if (functionId == 10041)
				{
					return new ERedDotName?(ERedDotName.RoleHandBook);
				}
				if (functionId == 10053)
				{
					return new ERedDotName?(ERedDotName.ActivityEntrance);
				}
			}
			else
			{
				if (functionId == 10058)
				{
					return new ERedDotName?(ERedDotName.FunctionKuroStreet);
				}
				if (functionId == 10072)
				{
					return new ERedDotName?(ERedDotName.FunctionMailBind);
				}
			}
		}
		else if (functionId <= 10098)
		{
			if (functionId == 10086)
			{
				return new ERedDotName?(ERedDotName.Introduction);
			}
			if (functionId == 10095)
			{
				return new ERedDotName?(ERedDotName.ActivityDirectTrainProEntry);
			}
			if (functionId == 10098)
			{
				return new ERedDotName?(ERedDotName.FunctionMotorDevelop);
			}
		}
		else if (functionId <= 10140)
		{
			switch (functionId)
			{
			case 10130:
				return new ERedDotName?(ERedDotName.FunctionPhoneMsg);
			case 10131:
				return new ERedDotName?(ERedDotName.Infrastructure);
			case 10132:
				break;
			case 10133:
				return new ERedDotName?(ERedDotName.FunctionWeatherCentral);
			default:
				if (functionId == 10140)
				{
					return new ERedDotName?(ERedDotName.FeedbackReward);
				}
				break;
			}
		}
		else
		{
			if (functionId == 10150)
			{
				return new ERedDotName?(ERedDotName.VillageInfr);
			}
			if (functionId == 10156)
			{
				return new ERedDotName?(ERedDotName.SheriffMap);
			}
		}
		return null;
	}

	// Token: 0x0600DA73 RID: 55923 RVA: 0x0032C09C File Offset: 0x0032A29C
	public bool RedDotFunctionPhantomCondition()
	{
		return false;
	}

	// Token: 0x170011D9 RID: 4569
	// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x0032C09F File Offset: 0x0032A29F
	public static FunctionModel Instance
	{
		get
		{
			return FunctionModel._Instance;
		}
	}

	// Token: 0x0600DA75 RID: 55925 RVA: 0x0032C0A6 File Offset: 0x0032A2A6
	public static FunctionModel GetOrCreateInstance()
	{
		if (FunctionModel._Instance == null)
		{
			FunctionModel.CreateInstance();
		}
		return FunctionModel._Instance;
	}

	// Token: 0x0600DA76 RID: 55926 RVA: 0x0032C0BA File Offset: 0x0032A2BA
	public static bool CreateInstance()
	{
		if (FunctionModel._Instance != null)
		{
			return true;
		}
		FunctionModel._Instance = new FunctionModel();
		return true;
	}

	// Token: 0x0600DA77 RID: 55927 RVA: 0x0032C0D0 File Offset: 0x0032A2D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA78 RID: 55928 RVA: 0x0032C0D2 File Offset: 0x0032A2D2
	public static void ResetStaticDefaultValue()
	{
		FunctionModel._Instance = null;
	}

	// Token: 0x0600DA79 RID: 55929 RVA: 0x0032C0DA File Offset: 0x0032A2DA
	static FunctionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FunctionModel.CreateStaticDefaultValue), new Action(FunctionModel.ResetStaticDefaultValue));
	}

	// Token: 0x040063F4 RID: 25588
	private readonly Dictionary<int, FunctionInstance> FunctionMap = new Dictionary<int, FunctionInstance>();

	// Token: 0x040063F5 RID: 25589
	private List<FunctionCondition> NewOpenFunctionList = new List<FunctionCondition>();

	// Token: 0x040063F6 RID: 25590
	private readonly Dictionary<EFunctionType, Func<bool>> ExCheckConditionMap = new Dictionary<EFunctionType, Func<bool>>();

	// Token: 0x040063F7 RID: 25591
	[Nullable(2)]
	private static FunctionModel _Instance;
}
