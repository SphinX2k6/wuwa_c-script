using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;

// Token: 0x020004FC RID: 1276
[NullableContext(2)]
[Nullable(0)]
public class GuessJokerController : UiControllerBase
{
	// Token: 0x06003E89 RID: 16009 RVA: 0x001610B0 File Offset: 0x0015F2B0
	public void RequestJokerGuessStartNew(int levelId, Action sucCallback = null)
	{
		JokerGuessStartNewRequest jokerGuessStartNewRequest = JokerGuessStartNewRequest.Create();
		jokerGuessStartNewRequest.LevelId = levelId;
		string serverTime = TimeUtil.Instance.GetServerTimeStamp().ToString();
		jokerGuessStartNewRequest.TraceId = serverTime;
		Net.Instance.Call(ERequestMessageId.JokerGuessStartNewRequest, jokerGuessStartNewRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			JokerGuessStartNewResponse jokerGuessStartNewResponse = (JokerGuessStartNewResponse)msg;
			if (jokerGuessStartNewResponse == null)
			{
				return;
			}
			if (jokerGuessStartNewResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessStartNewResponse.ErrorCode, 18171, null, true, true);
				return;
			}
			GuessJokerGamePlayModel.Instance.EnterGame(jokerGuessStartNewResponse.InitData, levelId, serverTime);
			GuessJokerGamePlayModel.Instance.UpdateTaskData(jokerGuessStartNewResponse.Cmd);
			Action sucCallback2 = sucCallback;
			if (sucCallback2 == null)
			{
				return;
			}
			sucCallback2();
		}, 0);
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x00161124 File Offset: 0x0015F324
	public void RequestJokerGuessRematch(int levelId, Action sucCallback = null)
	{
		GuessJokerController.<>c__DisplayClass1_0 CS$<>8__locals1 = new GuessJokerController.<>c__DisplayClass1_0();
		CS$<>8__locals1.levelId = levelId;
		CS$<>8__locals1.sucCallback = sucCallback;
		JokerGuessStartNewRequest jokerGuessStartNewRequest = JokerGuessStartNewRequest.Create();
		jokerGuessStartNewRequest.LevelId = CS$<>8__locals1.levelId;
		CS$<>8__locals1.serverTime = TimeUtil.Instance.GetServerTimeStamp().ToString();
		jokerGuessStartNewRequest.TraceId = CS$<>8__locals1.serverTime;
		Net.Instance.Call(ERequestMessageId.JokerGuessStartNewRequest, jokerGuessStartNewRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GuessJokerController.<>c__DisplayClass1_1 CS$<>8__locals2 = new GuessJokerController.<>c__DisplayClass1_1();
			CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
			CS$<>8__locals2.response = (JokerGuessStartNewResponse)msg;
			if (CS$<>8__locals2.response == null)
			{
				return;
			}
			if (CS$<>8__locals2.response.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(CS$<>8__locals2.response.ErrorCode, 18171, null, true, true);
				return;
			}
			CS$<>8__locals2.<RequestJokerGuessRematch>g__DoRematch|1().Forget();
		}, 0);
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x00161198 File Offset: 0x0015F398
	[NullableContext(1)]
	public void RequestJokerGuessPlayCard(IEnumerable<int> cardIdList, [Nullable(2)] Action callback = null)
	{
		JokerGuessPlayCardRequest jokerGuessPlayCardRequest = JokerGuessPlayCardRequest.Create();
		JokerGuessCard jokerGuessCard = new JokerGuessCard();
		jokerGuessCard.CardIds.AddRange(cardIdList);
		jokerGuessPlayCardRequest.PlayCard = jokerGuessCard;
		Net.Instance.Call(ERequestMessageId.JokerGuessPlayCardRequest, jokerGuessPlayCardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			JokerGuessPlayCardResponse jokerGuessPlayCardResponse = (JokerGuessPlayCardResponse)msg;
			if (jokerGuessPlayCardResponse == null)
			{
				return;
			}
			if (jokerGuessPlayCardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessPlayCardResponse.ErrorCode, 19352, null, true, true);
				return;
			}
			GuessJokerGamePlayModel.Instance.UpdateTaskData(jokerGuessPlayCardResponse.Cmd);
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x001611F0 File Offset: 0x0015F3F0
	public void RequestJokerGuessDrawCard(int cardId, Action<int> callback = null)
	{
		JokerGuessDrawCardRequest jokerGuessDrawCardRequest = JokerGuessDrawCardRequest.Create();
		jokerGuessDrawCardRequest.TargetCardId = cardId;
		Net.Instance.Call(ERequestMessageId.JokerGuessDrawCardRequest, jokerGuessDrawCardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			JokerGuessDrawCardResponse jokerGuessDrawCardResponse = (JokerGuessDrawCardResponse)msg;
			if (jokerGuessDrawCardResponse == null)
			{
				return;
			}
			if (jokerGuessDrawCardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessDrawCardResponse.ErrorCode, 27976, null, true, true);
				return;
			}
			GuessJokerGamePlayModel.Instance.UpdateTaskData(jokerGuessDrawCardResponse.Cmd);
			int drawCardResult = jokerGuessDrawCardResponse.DrawCardResult;
			Action<int> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(drawCardResult);
		}, 0);
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00161234 File Offset: 0x0015F434
	public void JokerGuessUseSkillRequest(int skillId, bool isUse, Action callback = null)
	{
		JokerGuessUseSkillRequest jokerGuessUseSkillRequest = Aki.Protocol.JokerGuessUseSkillRequest.Create();
		jokerGuessUseSkillRequest.SkillId = skillId;
		jokerGuessUseSkillRequest.Op = ((!isUse) ? JokerGuessSkillOp.GiveUp : JokerGuessSkillOp.Use);
		Net.Instance.Call(ERequestMessageId.JokerGuessUseSkillRequest, jokerGuessUseSkillRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			JokerGuessUseSkillResponse jokerGuessUseSkillResponse = (JokerGuessUseSkillResponse)msg;
			if (jokerGuessUseSkillResponse == null)
			{
				return;
			}
			if (jokerGuessUseSkillResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessUseSkillResponse.ErrorCode, 28232, null, true, true);
				return;
			}
			GuessJokerGamePlayModel.Instance.UpdateTaskData(jokerGuessUseSkillResponse.Cmd);
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x00161284 File Offset: 0x0015F484
	public void JokerGuessRewardRequest(int levelId, Action callback = null)
	{
		JokerGuessRewardRequest jokerGuessRewardRequest = Aki.Protocol.JokerGuessRewardRequest.Create();
		jokerGuessRewardRequest.LevelId = levelId;
		Net.Instance.Call(ERequestMessageId.JokerGuessRewardRequest, jokerGuessRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			JokerGuessRewardResponse jokerGuessRewardResponse = (JokerGuessRewardResponse)msg;
			if (jokerGuessRewardResponse == null)
			{
				return;
			}
			if (jokerGuessRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessRewardResponse.ErrorCode, 20099, null, true, true);
				return;
			}
			SpringManorData activityData = SpringManorModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateLevelGetReward(levelId);
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x06003E8F RID: 16015 RVA: 0x001612D4 File Offset: 0x0015F4D4
	[NullableContext(1)]
	public void OpenGuessJokerFloatTipsView(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] string[] textParam = null)
	{
		GuessJokerTipsData param = new GuessJokerTipsData
		{
			TextId = textId,
			TextParam = textParam
		};
		UiManager.Instance.OpenView(EUiViewName.GuessJokerFloatTipsView, param, null);
	}

	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x06003E90 RID: 16016 RVA: 0x00161306 File Offset: 0x0015F506
	[Nullable(1)]
	public static GuessJokerController Instance
	{
		[NullableContext(1)]
		get
		{
			return GuessJokerController._Instance;
		}
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x0016130D File Offset: 0x0015F50D
	[NullableContext(1)]
	public static GuessJokerController GetOrCreateInstance()
	{
		if (GuessJokerController._Instance == null)
		{
			GuessJokerController.CreateInstance();
		}
		return GuessJokerController._Instance;
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x00161321 File Offset: 0x0015F521
	public static bool CreateInstance()
	{
		if (GuessJokerController._Instance != null)
		{
			return true;
		}
		GuessJokerController._Instance = new GuessJokerController();
		return true;
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x00161337 File Offset: 0x0015F537
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003E94 RID: 16020 RVA: 0x00161339 File Offset: 0x0015F539
	public static void ResetStaticDefaultValue()
	{
		GuessJokerController._Instance = null;
	}

	// Token: 0x06003E95 RID: 16021 RVA: 0x00161341 File Offset: 0x0015F541
	static GuessJokerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerController.CreateStaticDefaultValue), new Action(GuessJokerController.ResetStaticDefaultValue));
	}

	// Token: 0x040031D2 RID: 12754
	private static GuessJokerController _Instance;
}
