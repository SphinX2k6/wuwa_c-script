using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;

// Token: 0x020016C5 RID: 5829
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AdviceModel : ModelBase
{
	// Token: 0x0600A679 RID: 42617 RVA: 0x00253FB7 File Offset: 0x002521B7
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

	// Token: 0x0600A67A RID: 42618 RVA: 0x00253FE8 File Offset: 0x002521E8
	public void OnAdviceCreateActorDestroy()
	{
		this.AdviceCreateActorField = null;
	}

	// Token: 0x0600A67B RID: 42619 RVA: 0x00253FF4 File Offset: 0x002521F4
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

	// Token: 0x0600A67C RID: 42620 RVA: 0x00254054 File Offset: 0x00252254
	public void AddPlayingMotionEntity(int entityId, AdviceMotionActor actor)
	{
		this.PlayingAdviceMotionEntities[entityId] = actor;
	}

	// Token: 0x0600A67D RID: 42621 RVA: 0x00254063 File Offset: 0x00252263
	public void RemovePlayingMotionEntity(int entityId)
	{
		this.PlayingAdviceMotionEntities.Remove(entityId);
	}

	// Token: 0x0600A67E RID: 42622 RVA: 0x00254072 File Offset: 0x00252272
	public void RecycleMotionActor(AdviceMotionActor actor)
	{
		this.AdviceMotionActorStack.Add(actor);
	}

	// Token: 0x0600A67F RID: 42623 RVA: 0x00254080 File Offset: 0x00252280
	public void RemoveMotionActor(AdviceMotionActor actor)
	{
		this.AdviceMotionActorStack.Remove(actor);
	}

	// Token: 0x0600A680 RID: 42624 RVA: 0x00254090 File Offset: 0x00252290
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

	// Token: 0x0600A681 RID: 42625 RVA: 0x00254198 File Offset: 0x00252398
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

	// Token: 0x0600A682 RID: 42626 RVA: 0x002541F4 File Offset: 0x002523F4
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

	// Token: 0x0600A683 RID: 42627 RVA: 0x00254278 File Offset: 0x00252478
	public void ResetVoteIds()
	{
		this.UpVoteIds.Clear();
		EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
	}

	// Token: 0x0600A684 RID: 42628 RVA: 0x00254295 File Offset: 0x00252495
	public void OnRequestVote(long id, PbAdviceVoteType type)
	{
		this.UpVoteIds.Remove(id);
		if (type == PbAdviceVoteType.Up)
		{
			this.UpVoteIds.Add(id);
		}
		EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
	}

	// Token: 0x0600A685 RID: 42629 RVA: 0x002542C4 File Offset: 0x002524C4
	public void OnAdviceVoteUpdate(long id, AdviceVoteUpdateNotify notify)
	{
		AdviceData adviceData;
		if (this.AdviceDataMap.TryGetValue(id, out adviceData))
		{
			adviceData.PhraseUpDownData((long)notify.UpVote);
		}
	}

	// Token: 0x0600A686 RID: 42630 RVA: 0x002542F0 File Offset: 0x002524F0
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

	// Token: 0x0600A687 RID: 42631 RVA: 0x00254331 File Offset: 0x00252531
	public void OnDeleteAdvice(long id)
	{
		this.AdviceDataMap.Remove(id);
		this.DataMapChangeDirty = true;
		EventSystem.Instance.Emit(EEventName.OnDeleteAdviceSuccess);
	}

	// Token: 0x0600A688 RID: 42632 RVA: 0x00254358 File Offset: 0x00252558
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

	// Token: 0x0600A689 RID: 42633 RVA: 0x002543D8 File Offset: 0x002525D8
	public long[] GetUpVoteIds()
	{
		List<long> list = new List<long>();
		foreach (long item in this.UpVoteIds)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600A68A RID: 42634 RVA: 0x00254438 File Offset: 0x00252638
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

	// Token: 0x0600A68B RID: 42635 RVA: 0x002544D8 File Offset: 0x002526D8
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

	// Token: 0x0600A68C RID: 42636 RVA: 0x00254518 File Offset: 0x00252718
	[NullableContext(2)]
	public AdviceEntityData GetCurrentEntityAdviceData()
	{
		return this.CurrentEntityAdviceData;
	}

	// Token: 0x0600A68D RID: 42637 RVA: 0x00254520 File Offset: 0x00252720
	public int GetCurrentEntityId()
	{
		return this.CurrentInteractEntityId;
	}

	// Token: 0x0600A68E RID: 42638 RVA: 0x00254528 File Offset: 0x00252728
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

	// Token: 0x0600A68F RID: 42639 RVA: 0x0025463F File Offset: 0x0025283F
	public void SetAdviceShowSetting(bool state)
	{
		this.AdviceShowSetting = state;
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, EFunction.ADVICESETTING);
	}

	// Token: 0x0600A690 RID: 42640 RVA: 0x0025465A File Offset: 0x0025285A
	public bool GetAdviceShowSetting()
	{
		return this.AdviceShowSetting;
	}

	// Token: 0x0600A691 RID: 42641 RVA: 0x00254664 File Offset: 0x00252864
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

	// Token: 0x0600A692 RID: 42642 RVA: 0x002546EF File Offset: 0x002528EF
	public bool GetCreateConditionState()
	{
		return !AdviceController.Instance.CheckBehindAdviceActor() && !AdviceController.Instance.CheckInInValidArea() && !this.CheckIfMaxAdvice();
	}

	// Token: 0x0600A693 RID: 42643 RVA: 0x00254718 File Offset: 0x00252918
	public bool CheckIfMaxAdvice()
	{
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("AdviceCreateLimit").GetValueOrDefault();
		return AdviceModel.Instance.GetAdviceArray() != null && AdviceModel.Instance.GetAdviceArray().Length >= valueOrDefault;
	}

	// Token: 0x0600A694 RID: 42644 RVA: 0x00254758 File Offset: 0x00252958
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

	// Token: 0x0600A695 RID: 42645 RVA: 0x00254800 File Offset: 0x00252A00
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

	// Token: 0x0600A696 RID: 42646 RVA: 0x0025486A File Offset: 0x00252A6A
	private bool CheckIfSystemOpen()
	{
		return FunctionModel.Instance.IsOpen(EFunctionType.Advice) && FunctionModel.Instance.IsOpen(EFunctionType.AdvicePut);
	}

	// Token: 0x0600A697 RID: 42647 RVA: 0x00254891 File Offset: 0x00252A91
	public void OnChangeSentence(int sentenceKey)
	{
		AdviceModel.Instance.CurrentWordMap[sentenceKey] = 0;
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceWord);
	}

	// Token: 0x0600A698 RID: 42648 RVA: 0x002548B4 File Offset: 0x00252AB4
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

	// Token: 0x0600A699 RID: 42649 RVA: 0x00254948 File Offset: 0x00252B48
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

	// Token: 0x0600A69A RID: 42650 RVA: 0x002549E0 File Offset: 0x00252BE0
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

	// Token: 0x0600A69B RID: 42651 RVA: 0x00254A78 File Offset: 0x00252C78
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

	// Token: 0x0600A69C RID: 42652 RVA: 0x00254AD0 File Offset: 0x00252CD0
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

	// Token: 0x0600A69D RID: 42653 RVA: 0x00254B44 File Offset: 0x00252D44
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

	// Token: 0x0600A69E RID: 42654 RVA: 0x00254C1C File Offset: 0x00252E1C
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

	// Token: 0x17000DEB RID: 3563
	// (get) Token: 0x0600A69F RID: 42655 RVA: 0x00254D60 File Offset: 0x00252F60
	public static AdviceModel Instance
	{
		get
		{
			return AdviceModel._Instance;
		}
	}

	// Token: 0x0600A6A0 RID: 42656 RVA: 0x00254D67 File Offset: 0x00252F67
	public static AdviceModel GetOrCreateInstance()
	{
		if (AdviceModel._Instance == null)
		{
			AdviceModel.CreateInstance();
		}
		return AdviceModel._Instance;
	}

	// Token: 0x0600A6A1 RID: 42657 RVA: 0x00254D7B File Offset: 0x00252F7B
	public static bool CreateInstance()
	{
		if (AdviceModel._Instance != null)
		{
			return true;
		}
		AdviceModel._Instance = new AdviceModel();
		return true;
	}

	// Token: 0x0600A6A2 RID: 42658 RVA: 0x00254D91 File Offset: 0x00252F91
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A6A3 RID: 42659 RVA: 0x00254D93 File Offset: 0x00252F93
	public static void ResetStaticDefaultValue()
	{
		AdviceModel._Instance = null;
	}

	// Token: 0x0600A6A4 RID: 42660 RVA: 0x00254D9B File Offset: 0x00252F9B
	static AdviceModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdviceModel.CreateStaticDefaultValue), new Action(AdviceModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004B2A RID: 19242
	public Dictionary<int, int> CurrentSentenceWordMap = new Dictionary<int, int>();

	// Token: 0x04004B2B RID: 19243
	public Dictionary<int, int> CurrentPreSentenceWordMap = new Dictionary<int, int>();

	// Token: 0x04004B2C RID: 19244
	public int CurrentPreSelectWordId;

	// Token: 0x04004B2D RID: 19245
	public int CurrentSelectWordId;

	// Token: 0x04004B2E RID: 19246
	public int CurrentPreSelectSentenceIndex;

	// Token: 0x04004B2F RID: 19247
	public int CurrentConjunctionId;

	// Token: 0x04004B30 RID: 19248
	public EChangeWordType CurrentChangeWordType;

	// Token: 0x04004B31 RID: 19249
	public ELineMode CurrentLineModel;

	// Token: 0x04004B32 RID: 19250
	public int CurrentSentenceSelectIndex;

	// Token: 0x04004B33 RID: 19251
	private int CurrentRandomSecondLineId;

	// Token: 0x04004B34 RID: 19252
	public int PreSelectSortTypeId;

	// Token: 0x04004B35 RID: 19253
	public int PreSelectSortWordId;

	// Token: 0x04004B36 RID: 19254
	public int CurrentSelectSortWordId;

	// Token: 0x04004B37 RID: 19255
	public int CurrentSelectSortTypeId;

	// Token: 0x04004B38 RID: 19256
	public Dictionary<int, int> CurrentWordMap = new Dictionary<int, int>();

	// Token: 0x04004B39 RID: 19257
	public int CurrentSelectWordIndex;

	// Token: 0x04004B3A RID: 19258
	public int PreSelectExpressionId;

	// Token: 0x04004B3B RID: 19259
	public int CurrentExpressionId;

	// Token: 0x04004B3C RID: 19260
	public int CurrentSelectRoleId;

	// Token: 0x04004B3D RID: 19261
	public int PreSelectRoleId;

	// Token: 0x04004B3E RID: 19262
	public int CurrentSelectMotionId;

	// Token: 0x04004B3F RID: 19263
	public int PreSelectMotionId;

	// Token: 0x04004B40 RID: 19264
	public int PreSelectAdviceItemId;

	// Token: 0x04004B41 RID: 19265
	public long? AdviceViewShowId;

	// Token: 0x04004B42 RID: 19266
	private readonly HashSet<long> UpVoteIds = new HashSet<long>();

	// Token: 0x04004B43 RID: 19267
	private readonly Dictionary<long, AdviceData> AdviceDataMap = new Dictionary<long, AdviceData>();

	// Token: 0x04004B44 RID: 19268
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private AdviceData[] AdviceArray;

	// Token: 0x04004B45 RID: 19269
	private bool DataMapChangeDirty;

	// Token: 0x04004B46 RID: 19270
	private int CurrentInteractEntityId;

	// Token: 0x04004B47 RID: 19271
	[Nullable(2)]
	private AdviceEntityData CurrentEntityAdviceData;

	// Token: 0x04004B48 RID: 19272
	private bool AdviceShowSetting;

	// Token: 0x04004B49 RID: 19273
	private readonly List<AdviceMotionActor> AdviceMotionActorStack = new List<AdviceMotionActor>();

	// Token: 0x04004B4A RID: 19274
	private readonly Dictionary<int, AdviceMotionActor> PlayingAdviceMotionEntities = new Dictionary<int, AdviceMotionActor>();

	// Token: 0x04004B4B RID: 19275
	[Nullable(2)]
	private AdviceCreateActor AdviceCreateActorField;

	// Token: 0x04004B4C RID: 19276
	[Nullable(2)]
	private static AdviceModel _Instance;
}
