using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.MailBind;
using CSharpScript.Game.Module.RecallQuest.Model;

// Token: 0x02001108 RID: 4360
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FunctionModel : ModelBase
{
	// Token: 0x0600AE6B RID: 44651 RVA: 0x003369A4 File Offset: 0x00334BA4
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

	// Token: 0x0600AE6C RID: 44652 RVA: 0x00336A5A File Offset: 0x00334C5A
	private bool CheckActivityOpen()
	{
		return ActivityModel.Instance.GetIfShowActivity();
	}

	// Token: 0x0600AE6D RID: 44653 RVA: 0x00336A66 File Offset: 0x00334C66
	private bool CheckCustomerServiceOpen()
	{
		return KuroSdkController.Instance.NeedShowCustomerService();
	}

	// Token: 0x0600AE6E RID: 44654 RVA: 0x00336A72 File Offset: 0x00334C72
	private bool CheckKuroStreetOpen()
	{
		return ChannelController.Instance.CheckKuroStreetOpen();
	}

	// Token: 0x0600AE6F RID: 44655 RVA: 0x00336A7E File Offset: 0x00334C7E
	private bool CheckMailBindOpen()
	{
		return MailBindModel.Instance.CheckGlobalMailBindOpen();
	}

	// Token: 0x0600AE70 RID: 44656 RVA: 0x00336A8A File Offset: 0x00334C8A
	private bool CheckDirectTrainProOpen()
	{
		return ActivityDirectTrainHelper.IsProOpen;
	}

	// Token: 0x0600AE71 RID: 44657 RVA: 0x00336A91 File Offset: 0x00334C91
	private bool CheckPioneerClientLimit()
	{
		return !FeatureRestrictionTemplate.TemplateForPioneerClient.Check();
	}

	// Token: 0x0600AE72 RID: 44658 RVA: 0x00336AA0 File Offset: 0x00334CA0
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

	// Token: 0x0600AE73 RID: 44659 RVA: 0x00336B3C File Offset: 0x00334D3C
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

	// Token: 0x0600AE74 RID: 44660 RVA: 0x00336CD8 File Offset: 0x00334ED8
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

	// Token: 0x0600AE75 RID: 44661 RVA: 0x00336D88 File Offset: 0x00334F88
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

	// Token: 0x0600AE76 RID: 44662 RVA: 0x00336E84 File Offset: 0x00335084
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

	// Token: 0x0600AE77 RID: 44663 RVA: 0x00336EC0 File Offset: 0x003350C0
	public bool IsExistNewOpenFunction()
	{
		return this.NewOpenFunctionList.Count > 0;
	}

	// Token: 0x0600AE78 RID: 44664 RVA: 0x00336ED0 File Offset: 0x003350D0
	public void ClearNewOpenFunctionList()
	{
		this.NewOpenFunctionList = new List<FunctionCondition>();
	}

	// Token: 0x0600AE79 RID: 44665 RVA: 0x00336EE0 File Offset: 0x003350E0
	public List<int> GetNewOpenFunctionIdList()
	{
		List<int> list = new List<int>();
		foreach (FunctionCondition functionCondition in this.NewOpenFunctionList)
		{
			list.Add(functionCondition.FunctionId);
		}
		return list;
	}

	// Token: 0x170011FE RID: 4606
	// (get) Token: 0x0600AE7A RID: 44666 RVA: 0x00336F40 File Offset: 0x00335140
	public int PlayerId
	{
		get
		{
			return PlayerInfoModel.Instance.GetId().GetValueOrDefault();
		}
	}

	// Token: 0x0600AE7B RID: 44667 RVA: 0x00336F60 File Offset: 0x00335160
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

	// Token: 0x0600AE7C RID: 44668 RVA: 0x00336F8F File Offset: 0x0033518F
	public int? GetPlayerLevel()
	{
		return PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Level);
	}

	// Token: 0x0600AE7D RID: 44669 RVA: 0x00336F9C File Offset: 0x0033519C
	public int? GetPlayerExp()
	{
		return PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Experience);
	}

	// Token: 0x0600AE7E RID: 44670 RVA: 0x00336FAC File Offset: 0x003351AC
	public string GetPlayerCashCoin()
	{
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.CashCoin);
		if (numberPropById == null)
		{
			return "0";
		}
		return numberPropById.Value.ToString();
	}

	// Token: 0x0600AE7F RID: 44671 RVA: 0x00336FE4 File Offset: 0x003351E4
	public int? GetWorldPermission()
	{
		return PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.WorldPermission);
	}

	// Token: 0x0600AE80 RID: 44672 RVA: 0x00336FF4 File Offset: 0x003351F4
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

	// Token: 0x0600AE81 RID: 44673 RVA: 0x0033702D File Offset: 0x0033522D
	public bool IsOpen(EFunctionType functionId)
	{
		return this.IsOpen((int)functionId);
	}

	// Token: 0x0600AE82 RID: 44674 RVA: 0x00337038 File Offset: 0x00335238
	public bool IsOpen(int functionId)
	{
		FunctionInstance functionInstance;
		return functionId == 0 || (this.FunctionMap.TryGetValue(functionId, out functionInstance) && functionInstance.GetIsOpen());
	}

	// Token: 0x0600AE83 RID: 44675 RVA: 0x00337064 File Offset: 0x00335264
	public bool IsLimit(int functionId)
	{
		FunctionInstance valueOrDefault = this.FunctionMap.GetValueOrDefault(functionId);
		int instanceId = CreatureModel.Instance.GetInstanceId();
		if (instanceId != 0 && valueOrDefault != null)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			int[] array = (config != null) ? config.GetValueOrDefault().FuncLimit() : null;
			if (array != null)
			{
				int[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == functionId)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600AE84 RID: 44676 RVA: 0x003370DC File Offset: 0x003352DC
	public bool IsShow(int functionId)
	{
		FunctionInstance functionInstance;
		return this.FunctionMap.TryGetValue(functionId, out functionInstance) && functionInstance.GetIsShow();
	}

	// Token: 0x0600AE85 RID: 44677 RVA: 0x00337104 File Offset: 0x00335304
	public bool IsLockByBehaviorTree(int functionId)
	{
		FunctionInstance functionInstance;
		return functionId != 0 && this.FunctionMap.TryGetValue(functionId, out functionInstance) && functionInstance.GetIsLockByBehaviorTree();
	}

	// Token: 0x0600AE86 RID: 44678 RVA: 0x00337130 File Offset: 0x00335330
	[NullableContext(2)]
	public FunctionInstance GetFunctionInstance(int functionId)
	{
		FunctionInstance result;
		this.FunctionMap.TryGetValue(functionId, out result);
		return result;
	}

	// Token: 0x0600AE87 RID: 44679 RVA: 0x00337150 File Offset: 0x00335350
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

	// Token: 0x0600AE88 RID: 44680 RVA: 0x00337234 File Offset: 0x00335434
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

	// Token: 0x0600AE89 RID: 44681 RVA: 0x003374A4 File Offset: 0x003356A4
	public bool RedDotFunctionPhantomCondition()
	{
		return false;
	}

	// Token: 0x170011FF RID: 4607
	// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x003374A7 File Offset: 0x003356A7
	public static FunctionModel Instance
	{
		get
		{
			return FunctionModel._Instance;
		}
	}

	// Token: 0x0600AE8B RID: 44683 RVA: 0x003374AE File Offset: 0x003356AE
	public static FunctionModel GetOrCreateInstance()
	{
		if (FunctionModel._Instance == null)
		{
			FunctionModel.CreateInstance();
		}
		return FunctionModel._Instance;
	}

	// Token: 0x0600AE8C RID: 44684 RVA: 0x003374C2 File Offset: 0x003356C2
	public static bool CreateInstance()
	{
		if (FunctionModel._Instance != null)
		{
			return true;
		}
		FunctionModel._Instance = new FunctionModel();
		return true;
	}

	// Token: 0x0600AE8D RID: 44685 RVA: 0x003374D8 File Offset: 0x003356D8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AE8E RID: 44686 RVA: 0x003374DA File Offset: 0x003356DA
	public static void ResetStaticDefaultValue()
	{
		FunctionModel._Instance = null;
	}

	// Token: 0x0600AE8F RID: 44687 RVA: 0x003374E2 File Offset: 0x003356E2
	static FunctionModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FunctionModel.CreateStaticDefaultValue), new Action(FunctionModel.ResetStaticDefaultValue));
	}

	// Token: 0x040064C6 RID: 25798
	private readonly Dictionary<int, FunctionInstance> FunctionMap = new Dictionary<int, FunctionInstance>();

	// Token: 0x040064C7 RID: 25799
	private List<FunctionCondition> NewOpenFunctionList = new List<FunctionCondition>();

	// Token: 0x040064C8 RID: 25800
	private readonly Dictionary<EFunctionType, Func<bool>> ExCheckConditionMap = new Dictionary<EFunctionType, Func<bool>>();

	// Token: 0x040064C9 RID: 25801
	[Nullable(2)]
	private static FunctionModel _Instance;
}
