using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;

// Token: 0x02000B7D RID: 2941
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AdviceModel : ModelBase
{
	// Token: 0x06007A59 RID: 31321 RVA: 0x0025E3C7 File Offset: 0x0025C5C7
	public AdviceCreateActor GetAdviceCreateActor()
	{
		if (this.AdviceCreateActorField == null)
		{
			this.AdviceCreateActorField = new AdviceCreateActor();
			this.AdviceCreateActorField.Init();
		}
		this.AdviceCreateActorField.RefreshPosition();
		return this.AdviceCreateActorField;
	}

	// Token: 0x06007A5A RID: 31322 RVA: 0x0025E3F8 File Offset: 0x0025C5F8
	public void OnAdviceCreateActorDestroy()
	{
		this.AdviceCreateActorField = null;
	}

	// Token: 0x06007A5B RID: 31323 RVA: 0x0025E404 File Offset: 0x0025C604
	public AdviceMotionActor GetAdviceMotionActor(int entityId)
	{
		AdviceMotionActor result;
		if (this.PlayingAdviceMotionEntities.TryGetValue(entityId, out result))
		{
			return result;
		}
		AdviceMotionActor adviceMotionActor = null;
		if (this.AdviceMotionActorStack.Count > 0)
		{
			int index = this.AdviceMotionActorStack.Count - 1;
			adviceMotionActor = this.AdviceMotionActorStack[index];
			this.AdviceMotionActorStack.RemoveAt(index);
		}
		if (adviceMotionActor == null)
		{
			return new AdviceMotionActor();
		}
		return adviceMotionActor;
	}

	// Token: 0x06007A5C RID: 31324 RVA: 0x0025E464 File Offset: 0x0025C664
	public void AddPlayingMotionEntity(int entityId, AdviceMotionActor actor)
	{
		this.PlayingAdviceMotionEntities[entityId] = actor;
	}

	// Token: 0x06007A5D RID: 31325 RVA: 0x0025E473 File Offset: 0x0025C673
	public void RemovePlayingMotionEntity(int entityId)
	{
		this.PlayingAdviceMotionEntities.Remove(entityId);
	}

	// Token: 0x06007A5E RID: 31326 RVA: 0x0025E482 File Offset: 0x0025C682
	public void RecycleMotionActor(AdviceMotionActor actor)
	{
		this.AdviceMotionActorStack.Add(actor);
	}

	// Token: 0x06007A5F RID: 31327 RVA: 0x0025E490 File Offset: 0x0025C690
	public void RemoveMotionActor(AdviceMotionActor actor)
	{
		this.AdviceMotionActorStack.Remove(actor);
	}

	// Token: 0x06007A60 RID: 31328 RVA: 0x0025E4A0 File Offset: 0x0025C6A0
	public void PhraseAdviceData(AdviceResponse response)
	{
		this.UpVoteIds.Clear();
		if (response.UpVoteIds != null)
		{
			foreach (long value in response.UpVoteIds)
			{
				long item = MathUtils.Instance.LongToBigInt(value);
				this.UpVoteIds.Add(item);
			}
		}
		this.AdviceDataMap.Clear();
		if (response.Advices != null)
		{
			foreach (PbAdvice data in response.Advices)
			{
				AdviceData adviceData = new AdviceData();
				adviceData.Phrase(data);
				long? adviceBigId = adviceData.GetAdviceBigId();
				if (adviceBigId != null)
				{
					this.AdviceDataMap[adviceBigId.Value] = adviceData;
				}
			}
		}
		this.DataMapChangeDirty = true;
		EventSystem.Instance.Emit(EEventName.OnReceiveAdviceData);
	}

	// Token: 0x06007A61 RID: 31329 RVA: 0x0025E5A8 File Offset: 0x0025C7A8
	public void PhraseAdviceCreateData(AdviceCreateResponse response)
	{
		AdviceData adviceData = new AdviceData();
		adviceData.Phrase(response.Advice);
		long? adviceBigId = adviceData.GetAdviceBigId();
		if (adviceBigId != null)
		{
			this.AdviceDataMap[adviceBigId.Value] = adviceData;
		}
		this.DataMapChangeDirty = true;
		EventSystem.Instance.Emit(EEventName.OnCreateAdviceSuccess);
	}

	// Token: 0x06007A62 RID: 31330 RVA: 0x0025E604 File Offset: 0x0025C804
	public void OnAdviceUpdateNotify(AdviceUpdateNotify response)
	{
		this.UpVoteIds.Clear();
		if (response.UpVoteIds != null)
		{
			foreach (long value in response.UpVoteIds)
			{
				long item = MathUtils.Instance.LongToBigInt(value);
				this.UpVoteIds.Add(item);
			}
		}
		EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
	}

	// Token: 0x06007A63 RID: 31331 RVA: 0x0025E688 File Offset: 0x0025C888
	public void ResetVoteIds()
	{
		this.UpVoteIds.Clear();
		EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
	}

	// Token: 0x06007A64 RID: 31332 RVA: 0x0025E6A5 File Offset: 0x0025C8A5
	public void OnRequestVote(long id, PbAdviceVoteType type)
	{
		this.UpVoteIds.Remove(id);
		if (type == PbAdviceVoteType.Up)
		{
			this.UpVoteIds.Add(id);
		}
		EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
	}

	// Token: 0x06007A65 RID: 31333 RVA: 0x0025E6D4 File Offset: 0x0025C8D4
	public void OnAdviceVoteUpdate(long id, AdviceVoteUpdateNotify notify)
	{
		AdviceData adviceData;
		if (this.AdviceDataMap.TryGetValue(id, out adviceData))
		{
			adviceData.PhraseUpDownData((long)notify.UpVote);
		}
	}

	// Token: 0x06007A66 RID: 31334 RVA: 0x0025E700 File Offset: 0x0025C900
	public void OnModifyAdvice(long id, AdviceContentData[] adviceContent)
	{
		AdviceData adviceData;
		if (this.AdviceDataMap.TryGetValue(id, out adviceData))
		{
			adviceData.PhraseData(new List<AdviceContentData>(adviceContent));
		}
		this.DataMapChangeDirty = true;
		EventSystem.Instance.Emit<long>(EEventName.OnModifyAdviceSuccess, id);
	}

	// Token: 0x06007A67 RID: 31335 RVA: 0x0025E741 File Offset: 0x0025C941
	public void OnDeleteAdvice(long id)
	{
		this.AdviceDataMap.Remove(id);
		this.DataMapChangeDirty = true;
		EventSystem.Instance.Emit(EEventName.OnDeleteAdviceSuccess);
	}

	// Token: 0x06007A68 RID: 31336 RVA: 0x0025E768 File Offset: 0x0025C968
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public AdviceData[] GetAdviceArray()
	{
		if (this.DataMapChangeDirty)
		{
			List<AdviceData> list = new List<AdviceData>();
			foreach (AdviceData item in this.AdviceDataMap.Values)
			{
				list.Add(item);
			}
			this.AdviceArray = list.ToArray();
			this.DataMapChangeDirty = false;
		}
		return this.AdviceArray;
	}

	// Token: 0x06007A69 RID: 31337 RVA: 0x0025E7E8 File Offset: 0x0025C9E8
	public long[] GetUpVoteIds()
	{
		List<long> list = new List<long>();
		foreach (long item in this.UpVoteIds)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06007A6A RID: 31338 RVA: 0x0025E848 File Offset: 0x0025CA48
	public bool GetIfCanCreateAdvice(ELineMode mode)
	{
		Dictionary<int, int> currentSentenceWordMap = this.CurrentSentenceWordMap;
		int currentConjunctionId = this.CurrentConjunctionId;
		Dictionary<int, int> currentWordMap = this.CurrentWordMap;
		foreach (KeyValuePair<int, int> keyValuePair in currentSentenceWordMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			int num;
			if ((mode != ELineMode.SingleLine || key != 1) && value > 0 && (!currentWordMap.TryGetValue(key, out num) || num <= 0))
			{
				return false;
			}
		}
		return mode != ELineMode.MutiLine || currentConjunctionId > 0;
	}

	// Token: 0x06007A6B RID: 31339 RVA: 0x0025E8E8 File Offset: 0x0025CAE8
	public void SetCurrentEntityId(int entityId)
	{
		this.CurrentInteractEntityId = entityId;
		this.CurrentEntityAdviceData = null;
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component != null)
			{
				this.CurrentEntityAdviceData = component.GetAdviceInfo();
			}
		}
	}

	// Token: 0x06007A6C RID: 31340 RVA: 0x0025E928 File Offset: 0x0025CB28
	[NullableContext(2)]
	public AdviceEntityData GetCurrentEntityAdviceData()
	{
		return this.CurrentEntityAdviceData;
	}

	// Token: 0x06007A6D RID: 31341 RVA: 0x0025E930 File Offset: 0x0025CB30
	public int GetCurrentEntityId()
	{
		return this.CurrentInteractEntityId;
	}

	// Token: 0x06007A6E RID: 31342 RVA: 0x0025E938 File Offset: 0x0025CB38
	public void ResetWordData()
	{
		this.CurrentWordMap.Clear();
		this.CurrentSentenceWordMap.Clear();
		this.CurrentConjunctionId = 0;
		this.CurrentSelectMotionId = 0;
		this.CurrentSelectSortWordId = 0;
		this.CurrentSelectSortTypeId = 0;
		this.CurrentSelectWordIndex = 0;
		this.CurrentExpressionId = 0;
		this.CurrentSelectRoleId = 0;
		this.CurrentLineModel = ELineMode.SingleLine;
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		int? num;
		if (getCurrentEntity == null)
		{
			num = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new int?(component.GetRoleId()) : null);
			}
		}
		int? num2 = num;
		this.PreSelectRoleId = num2.GetValueOrDefault();
		this.CurrentSelectMotionId = 0;
		this.PreSelectMotionId = AdviceConfig.Instance.GetAdviceMotionDefaultConfigId();
		IReadOnlyList<AdviceSentence> adviceSentenceConfigs = AdviceConfig.Instance.GetAdviceSentenceConfigs();
		int index = (int)MathUtils.Instance.GetRandomRange(0.0, (double)(adviceSentenceConfigs.Count - 1));
		this.CurrentSentenceWordMap[0] = adviceSentenceConfigs[index].Id;
		this.RandomSecondSentenceWord();
	}

	// Token: 0x06007A6F RID: 31343 RVA: 0x0025EA4F File Offset: 0x0025CC4F
	public void SetAdviceShowSetting(bool state)
	{
		this.AdviceShowSetting = state;
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.ADVICESETTING);
	}

	// Token: 0x06007A70 RID: 31344 RVA: 0x0025EA6A File Offset: 0x0025CC6A
	public bool GetAdviceShowSetting()
	{
		return this.AdviceShowSetting;
	}

	// Token: 0x06007A71 RID: 31345 RVA: 0x0025EA74 File Offset: 0x0025CC74
	public bool GetCreateAdvicePreConditionState()
	{
		bool flag = true;
		if (!this.CheckIfSystemOpen())
		{
			return false;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			return false;
		}
		if (!CreatureModel.Instance.IsMyWorld())
		{
			return false;
		}
		if (!AdviceController.Instance.CheckIfStandAndInValidActor())
		{
			return false;
		}
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		return !component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]) && component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.站立"]) && flag;
	}

	// Token: 0x06007A72 RID: 31346 RVA: 0x0025EAFF File Offset: 0x0025CCFF
	public bool GetCreateConditionState()
	{
		return !AdviceController.Instance.CheckBehindAdviceActor() && !AdviceController.Instance.CheckInInValidArea() && !this.CheckIfMaxAdvice();
	}

	// Token: 0x06007A73 RID: 31347 RVA: 0x0025EB28 File Offset: 0x0025CD28
	public bool CheckIfMaxAdvice()
	{
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("AdviceCreateLimit").GetValueOrDefault();
		return AdviceModel.Instance.GetAdviceArray() != null && AdviceModel.Instance.GetAdviceArray().Length >= valueOrDefault;
	}

	// Token: 0x06007A74 RID: 31348 RVA: 0x0025EB68 File Offset: 0x0025CD68
	public string GetCreatePreConditionFailText()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			return "CannotPutAdviceInInstanceDungeon";
		}
		if (!this.CheckIfSystemOpen())
		{
			return "FunctionDisable";
		}
		if (!CreatureModel.Instance.IsMyWorld())
		{
			return "CannotPutAdviceWhenInOtherWorld";
		}
		if (!AdviceController.Instance.CheckIfStandAndInValidActor())
		{
			return "CurrentStateCannotPutAdvice";
		}
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			return "AdviceCannotOpenOnBattle";
		}
		if (!component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.站立"]))
		{
			return "AdviceJustCanPutWhenStand";
		}
		return "CurrentStateCannotPutAdvice";
	}

	// Token: 0x06007A75 RID: 31349 RVA: 0x0025EC10 File Offset: 0x0025CE10
	public string GetCreateConditionFailText()
	{
		if (AdviceController.Instance.CheckBehindAdviceActor())
		{
			return "AdviceTooClose";
		}
		if (AdviceController.Instance.CheckInInValidArea())
		{
			return "AdviceAreaCannotPut";
		}
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("AdviceCreateLimit").GetValueOrDefault();
		if (AdviceModel.Instance.GetAdviceArray() != null && AdviceModel.Instance.GetAdviceArray().Length >= valueOrDefault)
		{
			return "OverCreateAdviceMax";
		}
		return "CurrentStateCannotPutAdvice";
	}

	// Token: 0x06007A76 RID: 31350 RVA: 0x0025EC7A File Offset: 0x0025CE7A
	private bool CheckIfSystemOpen()
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.Advice) && FunctionModel.Instance.IsOpen(EFunctionType.AdvicePut);
	}

	// Token: 0x06007A77 RID: 31351 RVA: 0x0025ECA1 File Offset: 0x0025CEA1
	public void OnChangeSentence(int sentenceKey)
	{
		AdviceModel.Instance.CurrentWordMap[sentenceKey] = 0;
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceWord);
	}

	// Token: 0x06007A78 RID: 31352 RVA: 0x0025ECC4 File Offset: 0x0025CEC4
	public AdviceMotionSelectData[] GetMotionSelectData()
	{
		List<AdviceMotionSelectData> list = new List<AdviceMotionSelectData>();
		int preSelectRoleId = AdviceModel.Instance.PreSelectRoleId;
		AdviceMotionSelectData item = new AdviceMotionSelectData(AdviceConfig.Instance.GetAdviceMotionDefaultConfigId());
		list.Add(item);
		if (preSelectRoleId > 0)
		{
			foreach (Motion motion in MotionConfig.Instance.GetMotionConfigsByRoleId(preSelectRoleId))
			{
				AdviceMotionSelectData item2 = new AdviceMotionSelectData(motion.Id);
				list.Add(item2);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06007A79 RID: 31353 RVA: 0x0025ED58 File Offset: 0x0025CF58
	public AdviceSelectItemData[] GetAdviceSelectData(ELineMode selectModel)
	{
		List<AdviceSelectItemData> list = new List<AdviceSelectItemData>();
		if (selectModel == ELineMode.SingleLine)
		{
			AdviceSelectItemData item = new AdviceSelectItemData(EAdviceSelectItemEnum.SelectWord1);
			list.Add(item);
		}
		else
		{
			AdviceSelectItemData item2 = new AdviceSelectItemData(EAdviceSelectItemEnum.SelectWord1);
			list.Add(item2);
			AdviceSelectItemData item3 = new AdviceSelectItemData(EAdviceSelectItemEnum.Conjunction);
			list.Add(item3);
			AdviceSelectItemData item4 = new AdviceSelectItemData(EAdviceSelectItemEnum.SelectWord2);
			list.Add(item4);
		}
		AdviceSelectItemData item5 = new AdviceSelectItemData(EAdviceSelectItemEnum.AddExpression);
		list.Add(item5);
		AdviceSelectItemData item6 = new AdviceSelectItemData(EAdviceSelectItemEnum.CutLine);
		list.Add(item6);
		AdviceSelectItemData item7 = new AdviceSelectItemData(EAdviceSelectItemEnum.ChangeWordBtn);
		list.Add(item7);
		AdviceSelectItemData item8 = new AdviceSelectItemData(EAdviceSelectItemEnum.AddOrDecreaseBtn);
		list.Add(item8);
		return list.ToArray();
	}

	// Token: 0x06007A7A RID: 31354 RVA: 0x0025EDF0 File Offset: 0x0025CFF0
	public void RandomSecondSentenceWord()
	{
		IReadOnlyList<AdviceSentence> adviceSentenceConfigs = AdviceConfig.Instance.GetAdviceSentenceConfigs();
		int num = (int)MathUtils.Instance.GetRandomRange(0.0, (double)(adviceSentenceConfigs.Count - 1));
		int num2 = AdviceModel.Instance.CurrentSentenceWordMap[0];
		while (num == num2)
		{
			num = (int)MathUtils.Instance.GetRandomRange(0.0, (double)(adviceSentenceConfigs.Count - 1));
		}
		this.CurrentRandomSecondLineId = num;
		AdviceModel.Instance.CurrentSentenceWordMap[1] = adviceSentenceConfigs[this.CurrentRandomSecondLineId].Id;
	}

	// Token: 0x06007A7B RID: 31355 RVA: 0x0025EE88 File Offset: 0x0025D088
	public string GetFirstLineText()
	{
		List<AdviceContentData> list = new List<AdviceContentData>();
		AdviceContentData adviceContentData = new AdviceContentData();
		adviceContentData.SetData(this.CurrentSentenceWordMap[0], this.CurrentWordMap[0], PbAdviceContentType.Sentence);
		list.Add(adviceContentData);
		AdviceData adviceData = new AdviceData();
		adviceData.PhraseShowText(new List<AdviceContentData>(list), 0L);
		return adviceData.GetAdviceShowText();
	}

	// Token: 0x06007A7C RID: 31356 RVA: 0x0025EEE0 File Offset: 0x0025D0E0
	public string GetSecondLineText()
	{
		List<AdviceContentData> list = new List<AdviceContentData>();
		AdviceContentData adviceContentData = new AdviceContentData();
		adviceContentData.SetData(this.CurrentConjunctionId, 0, PbAdviceContentType.Conjunction);
		list.Add(adviceContentData);
		AdviceContentData adviceContentData2 = new AdviceContentData();
		adviceContentData2.SetData(this.CurrentSentenceWordMap[1], this.CurrentWordMap[1], PbAdviceContentType.Sentence);
		list.Add(adviceContentData2);
		AdviceData adviceData = new AdviceData();
		adviceData.PhraseShowText(new List<AdviceContentData>(list), 1L);
		return adviceData.GetAdviceShowText();
	}

	// Token: 0x06007A7D RID: 31357 RVA: 0x0025EF54 File Offset: 0x0025D154
	public string GetCurrentShowText()
	{
		List<AdviceContentData> list = new List<AdviceContentData>();
		if (this.CurrentLineModel == ELineMode.SingleLine)
		{
			AdviceContentData adviceContentData = new AdviceContentData();
			adviceContentData.SetData(this.CurrentSentenceWordMap[0], this.CurrentWordMap[0], PbAdviceContentType.Sentence);
			list.Add(adviceContentData);
		}
		else
		{
			AdviceContentData adviceContentData2 = new AdviceContentData();
			adviceContentData2.SetData(this.CurrentSentenceWordMap[0], this.CurrentWordMap[0], PbAdviceContentType.Sentence);
			list.Add(adviceContentData2);
			AdviceContentData adviceContentData3 = new AdviceContentData();
			adviceContentData3.SetData(this.CurrentConjunctionId, 0, PbAdviceContentType.Conjunction);
			list.Add(adviceContentData3);
			AdviceContentData adviceContentData4 = new AdviceContentData();
			adviceContentData4.SetData(this.CurrentSentenceWordMap[1], this.CurrentWordMap[1], PbAdviceContentType.Sentence);
			list.Add(adviceContentData4);
		}
		AdviceData adviceData = new AdviceData();
		adviceData.PhraseShowText(new List<AdviceContentData>(list), 0L);
		return adviceData.GetAdviceShowText();
	}

	// Token: 0x06007A7E RID: 31358 RVA: 0x0025F02C File Offset: 0x0025D22C
	public AdviceContentData[] GetCreateAdviceContent()
	{
		List<AdviceContentData> list = new List<AdviceContentData>();
		AdviceModel instance = AdviceModel.Instance;
		Dictionary<int, int> currentSentenceWordMap = instance.CurrentSentenceWordMap;
		int currentConjunctionId = instance.CurrentConjunctionId;
		Dictionary<int, int> currentWordMap = instance.CurrentWordMap;
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in currentSentenceWordMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (value > 0 && (this.CurrentLineModel != ELineMode.SingleLine || key != 1))
			{
				int num2 = currentWordMap[key];
				if (num2 > 0)
				{
					num++;
					AdviceContentData adviceContentData = new AdviceContentData();
					adviceContentData.SetData(value, num2, PbAdviceContentType.Sentence);
					list.Add(adviceContentData);
				}
				if (num == 1 && this.CurrentLineModel != ELineMode.SingleLine && currentConjunctionId > 0)
				{
					AdviceContentData adviceContentData2 = new AdviceContentData();
					adviceContentData2.SetData(currentConjunctionId, 0, PbAdviceContentType.Conjunction);
					list.Add(adviceContentData2);
				}
			}
		}
		if (instance.CurrentExpressionId > 0)
		{
			AdviceContentData adviceContentData3 = new AdviceContentData();
			adviceContentData3.SetData(instance.CurrentExpressionId, 0, PbAdviceContentType.Expression);
			list.Add(adviceContentData3);
		}
		if (instance.CurrentSelectMotionId > 0)
		{
			AdviceContentData adviceContentData4 = new AdviceContentData();
			adviceContentData4.SetData(instance.CurrentSelectMotionId, 0, PbAdviceContentType.Motion);
			list.Add(adviceContentData4);
		}
		return list.ToArray();
	}

	// Token: 0x17000E0C RID: 3596
	// (get) Token: 0x06007A7F RID: 31359 RVA: 0x0025F170 File Offset: 0x0025D370
	public static AdviceModel Instance
	{
		get
		{
			return AdviceModel._Instance;
		}
	}

	// Token: 0x06007A80 RID: 31360 RVA: 0x0025F177 File Offset: 0x0025D377
	public static AdviceModel GetOrCreateInstance()
	{
		if (AdviceModel._Instance == null)
		{
			AdviceModel.CreateInstance();
		}
		return AdviceModel._Instance;
	}

	// Token: 0x06007A81 RID: 31361 RVA: 0x0025F18B File Offset: 0x0025D38B
	public static bool CreateInstance()
	{
		if (AdviceModel._Instance != null)
		{
			return true;
		}
		AdviceModel._Instance = new AdviceModel();
		return true;
	}

	// Token: 0x06007A82 RID: 31362 RVA: 0x0025F1A1 File Offset: 0x0025D3A1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007A83 RID: 31363 RVA: 0x0025F1A3 File Offset: 0x0025D3A3
	public static void ResetStaticDefaultValue()
	{
		AdviceModel._Instance = null;
	}

	// Token: 0x06007A84 RID: 31364 RVA: 0x0025F1AB File Offset: 0x0025D3AB
	static AdviceModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdviceModel.CreateStaticDefaultValue), new Action(AdviceModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004BD1 RID: 19409
	public Dictionary<int, int> CurrentSentenceWordMap = new Dictionary<int, int>();

	// Token: 0x04004BD2 RID: 19410
	public Dictionary<int, int> CurrentPreSentenceWordMap = new Dictionary<int, int>();

	// Token: 0x04004BD3 RID: 19411
	public int CurrentPreSelectWordId;

	// Token: 0x04004BD4 RID: 19412
	public int CurrentSelectWordId;

	// Token: 0x04004BD5 RID: 19413
	public int CurrentPreSelectSentenceIndex;

	// Token: 0x04004BD6 RID: 19414
	public int CurrentConjunctionId;

	// Token: 0x04004BD7 RID: 19415
	public EChangeWordType CurrentChangeWordType;

	// Token: 0x04004BD8 RID: 19416
	public ELineMode CurrentLineModel;

	// Token: 0x04004BD9 RID: 19417
	public int CurrentSentenceSelectIndex;

	// Token: 0x04004BDA RID: 19418
	private int CurrentRandomSecondLineId;

	// Token: 0x04004BDB RID: 19419
	public int PreSelectSortTypeId;

	// Token: 0x04004BDC RID: 19420
	public int PreSelectSortWordId;

	// Token: 0x04004BDD RID: 19421
	public int CurrentSelectSortWordId;

	// Token: 0x04004BDE RID: 19422
	public int CurrentSelectSortTypeId;

	// Token: 0x04004BDF RID: 19423
	public Dictionary<int, int> CurrentWordMap = new Dictionary<int, int>();

	// Token: 0x04004BE0 RID: 19424
	public int CurrentSelectWordIndex;

	// Token: 0x04004BE1 RID: 19425
	public int PreSelectExpressionId;

	// Token: 0x04004BE2 RID: 19426
	public int CurrentExpressionId;

	// Token: 0x04004BE3 RID: 19427
	public int CurrentSelectRoleId;

	// Token: 0x04004BE4 RID: 19428
	public int PreSelectRoleId;

	// Token: 0x04004BE5 RID: 19429
	public int CurrentSelectMotionId;

	// Token: 0x04004BE6 RID: 19430
	public int PreSelectMotionId;

	// Token: 0x04004BE7 RID: 19431
	public int PreSelectAdviceItemId;

	// Token: 0x04004BE8 RID: 19432
	public long? AdviceViewShowId;

	// Token: 0x04004BE9 RID: 19433
	private readonly HashSet<long> UpVoteIds = new HashSet<long>();

	// Token: 0x04004BEA RID: 19434
	private readonly Dictionary<long, AdviceData> AdviceDataMap = new Dictionary<long, AdviceData>();

	// Token: 0x04004BEB RID: 19435
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private AdviceData[] AdviceArray;

	// Token: 0x04004BEC RID: 19436
	private bool DataMapChangeDirty;

	// Token: 0x04004BED RID: 19437
	private int CurrentInteractEntityId;

	// Token: 0x04004BEE RID: 19438
	[Nullable(2)]
	private AdviceEntityData CurrentEntityAdviceData;

	// Token: 0x04004BEF RID: 19439
	private bool AdviceShowSetting;

	// Token: 0x04004BF0 RID: 19440
	private readonly List<AdviceMotionActor> AdviceMotionActorStack = new List<AdviceMotionActor>();

	// Token: 0x04004BF1 RID: 19441
	private readonly Dictionary<int, AdviceMotionActor> PlayingAdviceMotionEntities = new Dictionary<int, AdviceMotionActor>();

	// Token: 0x04004BF2 RID: 19442
	[Nullable(2)]
	private AdviceCreateActor AdviceCreateActorField;

	// Token: 0x04004BF3 RID: 19443
	[Nullable(2)]
	private static AdviceModel _Instance;
}
