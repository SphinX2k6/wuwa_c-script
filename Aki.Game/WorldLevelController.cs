using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002D6F RID: 11631
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WorldLevelController : UiControllerBase
{
	// Token: 0x06018755 RID: 100181 RVA: 0x00639D00 File Offset: 0x00637F00
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OriginWorldLevelUp, new Action(this.OnOriginWorldLevelUp));
		EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<bool>(EEventName.TsResponseWorldLevelChangeInFight, new Action<bool>(this.OnTsResponseWorldLevelChangeInFight));
		EventSystem.Instance.Add(EEventName.TsSyncWorldLevelChangeEvent, new Action(this.TsSyncWorldLevelChangeEvent));
		EventSystem.Instance.Add(EEventName.TsSyncOriginWorldLevelUpEvent, new Action(this.TsSyncOriginWorldLevelUpEvent));
	}

	// Token: 0x06018756 RID: 100182 RVA: 0x00639DB4 File Offset: 0x00637FB4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OriginWorldLevelUp, new Action(this.OnOriginWorldLevelUp));
		EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.OnBackLoginView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove(EEventName.TsResponseWorldLevelChangeInFight, new Action<bool>(this.OnTsResponseWorldLevelChangeInFight));
		EventSystem.Instance.Remove(EEventName.TsSyncWorldLevelChangeEvent, new Action(this.TsSyncWorldLevelChangeEvent));
		EventSystem.Instance.Remove(EEventName.TsSyncOriginWorldLevelUpEvent, new Action(this.TsSyncOriginWorldLevelUpEvent));
	}

	// Token: 0x06018757 RID: 100183 RVA: 0x00639E66 File Offset: 0x00638066
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06018758 RID: 100184 RVA: 0x00639E68 File Offset: 0x00638068
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06018759 RID: 100185 RVA: 0x00639E6A File Offset: 0x0063806A
	public void OnBasicInfoNotify(RepeatedField<PlayerAttr> attributes)
	{
		this.SetWorldLevelAttributes(attributes);
	}

	// Token: 0x0601875A RID: 100186 RVA: 0x00639E73 File Offset: 0x00638073
	public void OnPlayerAttrNotify(RepeatedField<PlayerAttr> attributes)
	{
		this.SetWorldLevelAttributes(attributes);
	}

	// Token: 0x0601875B RID: 100187 RVA: 0x00639E7C File Offset: 0x0063807C
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

	// Token: 0x0601875C RID: 100188 RVA: 0x00639FAC File Offset: 0x006381AC
	public void OnOriginWorldLevelUp()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.WorldLevelUpView))
		{
			EventSystem.Instance.Emit(EEventName.WorldLevelUpViewRefresh);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.WorldLevelUpView, null, null);
	}

	// Token: 0x0601875D RID: 100189 RVA: 0x00639FE1 File Offset: 0x006381E1
	public void OpenWorldLevelInfoView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.WorldLevelInfoView))
		{
			UiManager.Instance.OpenView(EUiViewName.WorldLevelInfoView, null, null);
		}
	}

	// Token: 0x0601875E RID: 100190 RVA: 0x0063A008 File Offset: 0x00638208
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(worldLevelDownResponse.ErrorCode, 27079, null, true, true);
		}, 0);
	}

	// Token: 0x0601875F RID: 100191 RVA: 0x0063A038 File Offset: 0x00638238
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(worldLevelRegainResponse.ErrorCode, 22321, null, true, true);
		}, 0);
	}

	// Token: 0x06018760 RID: 100192 RVA: 0x0063A068 File Offset: 0x00638268
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.FunctionView && UiManager.Instance.IsViewShow(EUiViewName.WorldLevelInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.WorldLevelInfoView, null);
		}
	}

	// Token: 0x06018761 RID: 100193 RVA: 0x0063A098 File Offset: 0x00638298
	private void OnBackLoginView()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.WorldLevelInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.WorldLevelInfoView, null);
		}
	}

	// Token: 0x06018762 RID: 100194 RVA: 0x0063A0BC File Offset: 0x006382BC
	public string GetLocalText(string textId, string param1)
	{
		string textById = TextConfig.Instance.GetTextById(textId);
		TArray<string> tarray = new TArray<string>();
		tarray.Add(param1);
		return UKuroStaticLibrary.KuroFormatText(textById ?? "", tarray);
	}

	// Token: 0x06018763 RID: 100195 RVA: 0x0063A0F0 File Offset: 0x006382F0
	private void OnTsResponseWorldLevelChangeInFight(bool state)
	{
		WorldLevelModel.Instance.TsFightState = state;
	}

	// Token: 0x06018764 RID: 100196 RVA: 0x0063A0FD File Offset: 0x006382FD
	private void TsSyncWorldLevelChangeEvent()
	{
		EventSystem.Instance.Emit(EEventName.CurWorldLevelChange);
	}

	// Token: 0x06018765 RID: 100197 RVA: 0x0063A10F File Offset: 0x0063830F
	private void TsSyncOriginWorldLevelUpEvent()
	{
		EventSystem.Instance.Emit(EEventName.OriginWorldLevelUp);
	}

	// Token: 0x1700210A RID: 8458
	// (get) Token: 0x06018766 RID: 100198 RVA: 0x0063A121 File Offset: 0x00638321
	public static WorldLevelController Instance
	{
		get
		{
			return WorldLevelController._Instance;
		}
	}

	// Token: 0x06018767 RID: 100199 RVA: 0x0063A128 File Offset: 0x00638328
	public static WorldLevelController GetOrCreateInstance()
	{
		if (WorldLevelController._Instance == null)
		{
			WorldLevelController.CreateInstance();
		}
		return WorldLevelController._Instance;
	}

	// Token: 0x06018768 RID: 100200 RVA: 0x0063A13C File Offset: 0x0063833C
	public static bool CreateInstance()
	{
		if (WorldLevelController._Instance != null)
		{
			return true;
		}
		WorldLevelController._Instance = new WorldLevelController();
		return true;
	}

	// Token: 0x06018769 RID: 100201 RVA: 0x0063A152 File Offset: 0x00638352
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601876A RID: 100202 RVA: 0x0063A154 File Offset: 0x00638354
	public static void ResetStaticDefaultValue()
	{
		WorldLevelController._Instance = null;
	}

	// Token: 0x0601876B RID: 100203 RVA: 0x0063A15C File Offset: 0x0063835C
	static WorldLevelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldLevelController.CreateStaticDefaultValue), new Action(WorldLevelController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B556 RID: 46422
	[Nullable(2)]
	private static WorldLevelController _Instance;
}
