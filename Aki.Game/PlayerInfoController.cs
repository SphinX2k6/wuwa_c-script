using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MingSu;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020025ED RID: 9709
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PlayerInfoController : UiControllerBase
{
	// Token: 0x06013BDD RID: 80861 RVA: 0x004F3521 File Offset: 0x004F1721
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BasicInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.BasicInfoNotifyHandle));
		Net.Instance.Register(ENotifyMessageId.PlayerAttrNotify, new Action<IMessage, Net.CallbackStatus>(this.PlayerAttrNotifyHandle));
	}

	// Token: 0x06013BDE RID: 80862 RVA: 0x004F355B File Offset: 0x004F175B
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BasicInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerAttrNotify);
	}

	// Token: 0x06013BDF RID: 80863 RVA: 0x004F3580 File Offset: 0x004F1780
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
		PersonalModel.Instance.SetRoleShowList(basicInfoNotify.RoleShowList.ToList<Aki.Protocol.RoleShowEntry>());
		PersonalModel.Instance.SetCurCardId(basicInfoNotify.CurCardId);
		PersonalModel.Instance.SetBirthday(basicInfoNotify.Birthday);
		PersonalModel.Instance.SetBirthdayDisplay(basicInfoNotify.DisplayBirthDay);
		PersonalModel.Instance.SetCardUnlockList(basicInfoNotify.CardUnlockList.ToArray<CardShowEntry>());
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

	// Token: 0x06013BE0 RID: 80864 RVA: 0x004F38D0 File Offset: 0x004F1AD0
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

	// Token: 0x06013BE1 RID: 80865 RVA: 0x004F3990 File Offset: 0x004F1B90
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

	// Token: 0x1700194F RID: 6479
	// (get) Token: 0x06013BE2 RID: 80866 RVA: 0x004F39F2 File Offset: 0x004F1BF2
	public static PlayerInfoController Instance
	{
		get
		{
			return PlayerInfoController._Instance;
		}
	}

	// Token: 0x06013BE3 RID: 80867 RVA: 0x004F39F9 File Offset: 0x004F1BF9
	public static PlayerInfoController GetOrCreateInstance()
	{
		if (PlayerInfoController._Instance == null)
		{
			PlayerInfoController.CreateInstance();
		}
		return PlayerInfoController._Instance;
	}

	// Token: 0x06013BE4 RID: 80868 RVA: 0x004F3A0D File Offset: 0x004F1C0D
	public static bool CreateInstance()
	{
		if (PlayerInfoController._Instance != null)
		{
			return true;
		}
		PlayerInfoController._Instance = new PlayerInfoController();
		return true;
	}

	// Token: 0x06013BE5 RID: 80869 RVA: 0x004F3A23 File Offset: 0x004F1C23
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013BE6 RID: 80870 RVA: 0x004F3A25 File Offset: 0x004F1C25
	public static void ResetStaticDefaultValue()
	{
		PlayerInfoController._Instance = null;
	}

	// Token: 0x06013BE7 RID: 80871 RVA: 0x004F3A2D File Offset: 0x004F1C2D
	static PlayerInfoController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlayerInfoController.CreateStaticDefaultValue), new Action(PlayerInfoController.ResetStaticDefaultValue));
	}

	// Token: 0x040094CE RID: 38094
	[Nullable(2)]
	private static PlayerInfoController _Instance;
}
