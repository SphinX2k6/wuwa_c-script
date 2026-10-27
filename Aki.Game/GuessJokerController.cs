using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;

// Token: 0x02001048 RID: 4168
[NullableContext(2)]
[Nullable(0)]
public class GuessJokerController : UiControllerBase
{
	// Token: 0x06006AF4 RID: 27380 RVA: 0x00158788 File Offset: 0x00156988
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessStartNewResponse.ErrorCode, 24323, null, true, true);
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

	// Token: 0x06006AF5 RID: 27381 RVA: 0x001587FC File Offset: 0x001569FC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(CS$<>8__locals2.response.ErrorCode, 24323, null, true, true);
				return;
			}
			CS$<>8__locals2.<RequestJokerGuessRematch>g__DoRematch|1().Forget();
		}, 0);
	}

	// Token: 0x06006AF6 RID: 27382 RVA: 0x00158870 File Offset: 0x00156A70
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessPlayCardResponse.ErrorCode, 15319, null, true, true);
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

	// Token: 0x06006AF7 RID: 27383 RVA: 0x001588C8 File Offset: 0x00156AC8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessDrawCardResponse.ErrorCode, 20858, null, true, true);
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

	// Token: 0x06006AF8 RID: 27384 RVA: 0x0015890C File Offset: 0x00156B0C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessUseSkillResponse.ErrorCode, 26805, null, true, true);
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

	// Token: 0x06006AF9 RID: 27385 RVA: 0x0015895C File Offset: 0x00156B5C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(jokerGuessRewardResponse.ErrorCode, 22205, null, true, true);
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

	// Token: 0x06006AFA RID: 27386 RVA: 0x001589AC File Offset: 0x00156BAC
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

	// Token: 0x1700089A RID: 2202
	// (get) Token: 0x06006AFB RID: 27387 RVA: 0x001589DE File Offset: 0x00156BDE
	[Nullable(1)]
	public static GuessJokerController Instance
	{
		[NullableContext(1)]
		get
		{
			return GuessJokerController._Instance;
		}
	}

	// Token: 0x06006AFC RID: 27388 RVA: 0x001589E5 File Offset: 0x00156BE5
	[NullableContext(1)]
	public static GuessJokerController GetOrCreateInstance()
	{
		if (GuessJokerController._Instance == null)
		{
			GuessJokerController.CreateInstance();
		}
		return GuessJokerController._Instance;
	}

	// Token: 0x06006AFD RID: 27389 RVA: 0x001589F9 File Offset: 0x00156BF9
	public static bool CreateInstance()
	{
		if (GuessJokerController._Instance != null)
		{
			return true;
		}
		GuessJokerController._Instance = new GuessJokerController();
		return true;
	}

	// Token: 0x06006AFE RID: 27390 RVA: 0x00158A0F File Offset: 0x00156C0F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006AFF RID: 27391 RVA: 0x00158A11 File Offset: 0x00156C11
	public static void ResetStaticDefaultValue()
	{
		GuessJokerController._Instance = null;
	}

	// Token: 0x06006B00 RID: 27392 RVA: 0x00158A19 File Offset: 0x00156C19
	static GuessJokerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerController.CreateStaticDefaultValue), new Action(GuessJokerController.ResetStaticDefaultValue));
	}

	// Token: 0x04003139 RID: 12601
	private static GuessJokerController _Instance;
}
