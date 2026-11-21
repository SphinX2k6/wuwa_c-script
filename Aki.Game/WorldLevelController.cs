using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x020022C9 RID: 8905
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WorldLevelController : UiControllerBase
{
	// Token: 0x06015FF7 RID: 90103 RVA: 0x0065FD18 File Offset: 0x0065DF18
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OriginWorldLevelUp, new Action(this.OnOriginWorldLevelUp));
		EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<bool>(EEventName.TsResponseWorldLevelChangeInFight, new Action<bool>(this.OnTsResponseWorldLevelChangeInFight));
		EventSystem.Instance.Add(EEventName.TsSyncWorldLevelChangeEvent, new Action(this.TsSyncWorldLevelChangeEvent));
		EventSystem.Instance.Add(EEventName.TsSyncOriginWorldLevelUpEvent, new Action(this.TsSyncOriginWorldLevelUpEvent));
	}

	// Token: 0x06015FF8 RID: 90104 RVA: 0x0065FDCC File Offset: 0x0065DFCC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OriginWorldLevelUp, new Action(this.OnOriginWorldLevelUp));
		EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove(EEventName.TsResponseWorldLevelChangeInFight, new Action<bool>(this.OnTsResponseWorldLevelChangeInFight));
		EventSystem.Instance.Remove(EEventName.TsSyncWorldLevelChangeEvent, new Action(this.TsSyncWorldLevelChangeEvent));
		EventSystem.Instance.Remove(EEventName.TsSyncOriginWorldLevelUpEvent, new Action(this.TsSyncOriginWorldLevelUpEvent));
	}

	// Token: 0x06015FF9 RID: 90105 RVA: 0x0065FE7E File Offset: 0x0065E07E
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06015FFA RID: 90106 RVA: 0x0065FE80 File Offset: 0x0065E080
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06015FFB RID: 90107 RVA: 0x0065FE82 File Offset: 0x0065E082
	public void OnBasicInfoNotify(RepeatedField<PlayerAttr> attributes)
	{
		this.SetWorldLevelAttributes(attributes);
	}

	// Token: 0x06015FFC RID: 90108 RVA: 0x0065FE8B File Offset: 0x0065E08B
	public void OnPlayerAttrNotify(RepeatedField<PlayerAttr> attributes)
	{
		this.SetWorldLevelAttributes(attributes);
	}

	// Token: 0x06015FFD RID: 90109 RVA: 0x0065FE94 File Offset: 0x0065E094
	public void SetWorldLevelAttributes(RepeatedField<PlayerAttr> attributes)
	{
		foreach (PlayerAttr playerAttr in attributes)
		{
			if (playerAttr.Key == PlayerAttrKey.OriginWorldLevel)
			{
				WorldLevelModel.Instance.OriginWorldLevel = playerAttr.Int32Value;
			}
			if (playerAttr.Key == PlayerAttrKey.CurWorldLevel)
			{
				WorldLevelModel.Instance.CurWorldLevel = playerAttr.Int32Value;
			}
			if (playerAttr.Key == PlayerAttrKey.WorldLevelTimeStamp)
			{
				WorldLevelModel.Instance.LastChangeWorldLevelTimeStamp = playerAttr.Int32Value;
			}
			if (playerAttr.Key == PlayerAttrKey.Sex)
			{
				WorldLevelModel.Instance.Sex = playerAttr.Int32Value;
				PersonalModel.Instance.SetSex(playerAttr.Int32Value);
			}
			if (playerAttr.Key == PlayerAttrKey.Sign)
			{
				PersonalModel.Instance.SetSignature(playerAttr.StringValue);
			}
			if (playerAttr.Key == PlayerAttrKey.PlayerTitle)
			{
				string[] array = playerAttr.StringValue.Split('_', StringSplitOptions.None);
				int? starLevel = (array.Length == 2) ? new int?(int.Parse(array[1])) : null;
				int playerTitleId;
				if (!int.TryParse(array[0], out playerTitleId))
				{
					playerTitleId = 0;
				}
				PersonalModel.Instance.SetDressedPlayerTitle(playerTitleId, starLevel);
			}
		}
	}

	// Token: 0x06015FFE RID: 90110 RVA: 0x0065FFC4 File Offset: 0x0065E1C4
	public void OnOriginWorldLevelUp()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.WorldLevelUpView))
		{
			EventSystem.Instance.Emit(EEventName.WorldLevelUpViewRefresh);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.WorldLevelUpView, null, null);
	}

	// Token: 0x06015FFF RID: 90111 RVA: 0x0065FFF9 File Offset: 0x0065E1F9
	public void OpenWorldLevelInfoView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.WorldLevelInfoView))
		{
			UiManager.Instance.OpenView(EUiViewName.WorldLevelInfoView, null, null);
		}
	}

	// Token: 0x06016000 RID: 90112 RVA: 0x00660020 File Offset: 0x0065E220
	public void SendWorldLevelDownRequest()
	{
		WorldLevelDownRequest message = WorldLevelDownRequest.Create();
		Net.Instance.Call(ERequestMessageId.WorldLevelDownRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WorldLevelDownResponse worldLevelDownResponse = (WorldLevelDownResponse)msg;
			if (worldLevelDownResponse == null)
			{
				return;
			}
			if (worldLevelDownResponse.ErrorCode == ErrorCode.Success)
			{
				WorldLevelModel.Instance.OriginWorldLevel = worldLevelDownResponse.OriginWorldLevel;
				WorldLevelModel.Instance.CurWorldLevel = worldLevelDownResponse.CurWorldLevel;
				WorldLevelModel.Instance.LastChangeWorldLevelTimeStamp = worldLevelDownResponse.WorldLevelTimeStamp;
				ScrollingTipsController.Instance.ShowTipsByText(this.GetLocalText("WorldLevelAdjustTo", WorldLevelModel.Instance.CurWorldLevel.ToString()));
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(worldLevelDownResponse.ErrorCode, 28190, null, true, true);
		}, 0);
	}

	// Token: 0x06016001 RID: 90113 RVA: 0x00660050 File Offset: 0x0065E250
	public void SendWorldLevelRegainRequest()
	{
		WorldLevelRegainRequest message = WorldLevelRegainRequest.Create();
		Net.Instance.Call(ERequestMessageId.WorldLevelRegainRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			WorldLevelRegainResponse worldLevelRegainResponse = (WorldLevelRegainResponse)msg;
			if (worldLevelRegainResponse == null)
			{
				return;
			}
			if (worldLevelRegainResponse.ErrorCode == ErrorCode.Success)
			{
				WorldLevelModel.Instance.OriginWorldLevel = worldLevelRegainResponse.OriginWorldLevel;
				WorldLevelModel.Instance.CurWorldLevel = worldLevelRegainResponse.CurWorldLevel;
				WorldLevelModel.Instance.LastChangeWorldLevelTimeStamp = worldLevelRegainResponse.WorldLevelTimeStamp;
				ScrollingTipsController.Instance.ShowTipsByText(this.GetLocalText("WorldLevelAdjustTo", WorldLevelModel.Instance.CurWorldLevel.ToString()));
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(worldLevelRegainResponse.ErrorCode, 23479, null, true, true);
		}, 0);
	}

	// Token: 0x06016002 RID: 90114 RVA: 0x00660080 File Offset: 0x0065E280
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.FunctionView && UiManager.Instance.IsViewShow(EUiViewName.WorldLevelInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.WorldLevelInfoView, null);
		}
	}

	// Token: 0x06016003 RID: 90115 RVA: 0x006600B0 File Offset: 0x0065E2B0
	private void OnBackLoginView()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.WorldLevelInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.WorldLevelInfoView, null);
		}
	}

	// Token: 0x06016004 RID: 90116 RVA: 0x006600D4 File Offset: 0x0065E2D4
	public string GetLocalText(string textId, string param1)
	{
		string textById = TextConfig.Instance.GetTextById(textId);
		TArray<string> tarray = new TArray<string>();
		tarray.Add(param1);
		return UKuroStaticLibrary.KuroFormatText(textById ?? "", tarray);
	}

	// Token: 0x06016005 RID: 90117 RVA: 0x00660108 File Offset: 0x0065E308
	private void OnTsResponseWorldLevelChangeInFight(bool state)
	{
		WorldLevelModel.Instance.TsFightState = state;
	}

	// Token: 0x06016006 RID: 90118 RVA: 0x00660115 File Offset: 0x0065E315
	private void TsSyncWorldLevelChangeEvent()
	{
		EventSystem.Instance.Emit(EEventName.CurWorldLevelChange);
	}

	// Token: 0x06016007 RID: 90119 RVA: 0x00660127 File Offset: 0x0065E327
	private void TsSyncOriginWorldLevelUpEvent()
	{
		EventSystem.Instance.Emit(EEventName.OriginWorldLevelUp);
	}

	// Token: 0x17002165 RID: 8549
	// (get) Token: 0x06016008 RID: 90120 RVA: 0x00660139 File Offset: 0x0065E339
	public static WorldLevelController Instance
	{
		get
		{
			return WorldLevelController._Instance;
		}
	}

	// Token: 0x06016009 RID: 90121 RVA: 0x00660140 File Offset: 0x0065E340
	public static WorldLevelController GetOrCreateInstance()
	{
		if (WorldLevelController._Instance == null)
		{
			WorldLevelController.CreateInstance();
		}
		return WorldLevelController._Instance;
	}

	// Token: 0x0601600A RID: 90122 RVA: 0x00660154 File Offset: 0x0065E354
	public static bool CreateInstance()
	{
		if (WorldLevelController._Instance != null)
		{
			return true;
		}
		WorldLevelController._Instance = new WorldLevelController();
		return true;
	}

	// Token: 0x0601600B RID: 90123 RVA: 0x0066016A File Offset: 0x0065E36A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601600C RID: 90124 RVA: 0x0066016C File Offset: 0x0065E36C
	public static void ResetStaticDefaultValue()
	{
		WorldLevelController._Instance = null;
	}

	// Token: 0x0601600D RID: 90125 RVA: 0x00660174 File Offset: 0x0065E374
	static WorldLevelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldLevelController.CreateStaticDefaultValue), new Action(WorldLevelController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B8CB RID: 47307
	[Nullable(2)]
	private static WorldLevelController _Instance;
}
