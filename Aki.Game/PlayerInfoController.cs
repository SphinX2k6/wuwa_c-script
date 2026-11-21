using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MingSu;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001AD8 RID: 6872
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PlayerInfoController : UiControllerBase
{
	// Token: 0x060110BF RID: 69823 RVA: 0x00502299 File Offset: 0x00500499
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BasicInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BasicInfoNotifyHandle));
		Net.Instance.Register(ENotifyMessageId.PlayerAttrNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerAttrNotifyHandle));
	}

	// Token: 0x060110C0 RID: 69824 RVA: 0x005022D3 File Offset: 0x005004D3
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BasicInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerAttrNotify);
	}

	// Token: 0x060110C1 RID: 69825 RVA: 0x005022F8 File Offset: 0x005004F8
	[NullableContext(2)]
	private void BasicInfoNotifyHandle(IMessage msg, Net.CallbackStatus status)
	{
		BasicInfoNotify basicInfoNotify = (BasicInfoNotify)msg;
		if (basicInfoNotify == null)
		{
			return;
		}
		WorldLevelController.Instance.OnBasicInfoNotify(basicInfoNotify.Attributes);
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SetId(basicInfoNotify.Id);
		LogAnalyzer.Instance.SetPlayerId(basicInfoNotify.Id);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
		foreach (PlayerAttr playerAttr in basicInfoNotify.Attributes)
		{
			if (playerAttr.ValueType == PlayerAttrType.Int32)
			{
				dictionary[(int)playerAttr.Key] = playerAttr.Int32Value;
			}
			else
			{
				dictionary2[(int)playerAttr.Key] = playerAttr.StringValue;
			}
		}
		instance.SetNumberProp(dictionary);
		instance.SetStringProp(dictionary2);
		instance.RandomSeed = basicInfoNotify.RandomSeed;
		MingSuModel.Instance.UpdateDragonPoolInfoMap(basicInfoNotify.DragonPoolInfos);
		PersonalModel.Instance.SetRoleShowList(basicInfoNotify.RoleShowList);
		PersonalModel.Instance.SetCurCardId(basicInfoNotify.CurCardId);
		PersonalModel.Instance.SetBirthday(basicInfoNotify.Birthday);
		PersonalModel.Instance.SetBirthdayDisplay(basicInfoNotify.DisplayBirthDay);
		CardShowEntry[] array = new CardShowEntry[basicInfoNotify.CardUnlockList.Count];
		basicInfoNotify.CardUnlockList.CopyTo(array, 0);
		PersonalModel.Instance.SetCardUnlockList(array);
		PersonalModel.Instance.SetName(FunctionModel.Instance.GetPlayerName());
		PersonalModel.Instance.SetPlayerId(PlayerInfoModel.Instance.GetId().Value);
		PersonalModel.Instance.SetModifyNameInfo(basicInfoNotify.LastModifyNameTime, basicInfoNotify.ModifyName);
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		PersonalModel.Instance.SetHeadPhotoId(numberPropById.GetValueOrDefault());
		this.SetAudioPlayerGenderState();
		LoginController.Instance.SetIfFirstTimeLogin();
		if (CloudGameManager.Instance.IsCloudGame)
		{
			UKuroStaticLibrary.SetThreadAffinity("GameThread", 65535, 65280);
			UKuroStaticLibrary.SetThreadAffinity("RenderThread", 65535, 65520);
			UKuroStaticLibrary.SetThreadAffinity("RHIThread", 65535, 65520);
			Log.Instance.Info(ELogModule.Game, ELogAuthor.WY, "IsCloudGame affinity set", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (Info.Instance.PlatformType == ESourcePlatformType.Android && basicInfoNotify.Id % 10 == 1)
		{
			string deviceCPU = UKuroStaticLibrary.GetDeviceCPU();
			if (deviceCPU.Contains("SM8475") || deviceCPU.Contains("SM8550") || deviceCPU.Contains("SM8650"))
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Game;
				ELogAuthor author = ELogAuthor.WY;
				string message = "Disable affinity set";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("cpu", deviceCPU);
				instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UKuroStaticLibrary.SetThreadAffinity("GameThread", 65535, 65535);
				UKuroStaticLibrary.SetThreadAffinity("RenderThread", 65535, 65535);
				UKuroStaticLibrary.SetThreadAffinity("RHIThread", 65535, 65535);
				if (PerfSight.Instance.IsEnable)
				{
					PerfSight.Instance.PostEvent(500, "0");
				}
			}
		}
		else if (PerfSight.Instance.IsEnable)
		{
			PerfSight.Instance.PostEvent(500, "1");
		}
		PayShopModel.Instance.BusinessCompliance = basicInfoNotify.BusinessCompliance;
		instance.NewbieGuideV2 = basicInfoNotify.NewbieGuideV2;
		EventSystem.Instance.Emit(EEventName.OnGetPlayerBasicInfo);
	}

	// Token: 0x060110C2 RID: 69826 RVA: 0x0050265C File Offset: 0x0050085C
	[NullableContext(2)]
	private void PlayerAttrNotifyHandle(IMessage msg, Net.CallbackStatus status)
	{
		PlayerAttrNotify playerAttrNotify = (PlayerAttrNotify)msg;
		if (playerAttrNotify == null)
		{
			return;
		}
		WorldLevelController.Instance.OnPlayerAttrNotify(playerAttrNotify.Attributes);
		if (PlayerInfoModel.Instance == null)
		{
			return;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
		foreach (PlayerAttr playerAttr in playerAttrNotify.Attributes)
		{
			if (playerAttr.ValueType == PlayerAttrType.Int32)
			{
				dictionary[(int)playerAttr.Key] = playerAttr.Int32Value;
			}
			else
			{
				dictionary2[(int)playerAttr.Key] = playerAttr.StringValue;
			}
		}
		PlayerInfoModel.Instance.UpdatePlayerAttributeNumberInfo(dictionary);
		PlayerInfoModel.Instance.UpdatePlayerAttributeStringInfo(dictionary2);
	}

	// Token: 0x060110C3 RID: 69827 RVA: 0x0050271C File Offset: 0x0050091C
	private void SetAudioPlayerGenderState()
	{
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.Sex);
		if (numberPropById == null)
		{
			return;
		}
		if (!(numberPropById != 1))
		{
			AudioSystem.Instance.SetState("player_rover_gender", "male", true);
			return;
		}
		AudioSystem.Instance.SetState("player_rover_gender", "female", true);
	}

	// Token: 0x17001987 RID: 6535
	// (get) Token: 0x060110C4 RID: 69828 RVA: 0x0050277E File Offset: 0x0050097E
	public static PlayerInfoController Instance
	{
		get
		{
			return PlayerInfoController._Instance;
		}
	}

	// Token: 0x060110C5 RID: 69829 RVA: 0x00502785 File Offset: 0x00500985
	public static PlayerInfoController GetOrCreateInstance()
	{
		if (PlayerInfoController._Instance == null)
		{
			PlayerInfoController.CreateInstance();
		}
		return PlayerInfoController._Instance;
	}

	// Token: 0x060110C6 RID: 69830 RVA: 0x00502799 File Offset: 0x00500999
	public static bool CreateInstance()
	{
		if (PlayerInfoController._Instance != null)
		{
			return true;
		}
		PlayerInfoController._Instance = new PlayerInfoController();
		return true;
	}

	// Token: 0x060110C7 RID: 69831 RVA: 0x005027AF File Offset: 0x005009AF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060110C8 RID: 69832 RVA: 0x005027B1 File Offset: 0x005009B1
	public static void ResetStaticDefaultValue()
	{
		PlayerInfoController._Instance = null;
	}

	// Token: 0x060110C9 RID: 69833 RVA: 0x005027B9 File Offset: 0x005009B9
	static PlayerInfoController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlayerInfoController.CreateStaticDefaultValue), new Action(PlayerInfoController.ResetStaticDefaultValue));
	}

	// Token: 0x04009625 RID: 38437
	[Nullable(2)]
	private static PlayerInfoController _Instance;
}
