using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02004224 RID: 16932
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsTips : UiPanelBase
	{
		// Token: 0x0602ACA1 RID: 175265 RVA: 0x00C0BC40 File Offset: 0x00C09E40
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnCardDescBtnClick)),
				new ValueTuple<int, Delegate>(6, new Action(this.OnClickBottomMask))
			};
		}

		// Token: 0x0602ACA2 RID: 175266 RVA: 0x00C0BD30 File Offset: 0x00C09F30
		protected UniTask InitDetailsItem()
		{
			PhantomArenaBattleDetailsTips.<InitDetailsItem>d__15 <InitDetailsItem>d__;
			<InitDetailsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsItem>d__.<>4__this = this;
			<InitDetailsItem>d__.<>1__state = -1;
			<InitDetailsItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsTips.<InitDetailsItem>d__15>(ref <InitDetailsItem>d__);
			return <InitDetailsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACA3 RID: 175267 RVA: 0x00C0BD74 File Offset: 0x00C09F74
		protected UniTask InitMaskButton()
		{
			PhantomArenaBattleDetailsTips.<InitMaskButton>d__16 <InitMaskButton>d__;
			<InitMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMaskButton>d__.<>4__this = this;
			<InitMaskButton>d__.<>1__state = -1;
			<InitMaskButton>d__.<>t__builder.Start<PhantomArenaBattleDetailsTips.<InitMaskButton>d__16>(ref <InitMaskButton>d__);
			return <InitMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACA4 RID: 175268 RVA: 0x00C0BDB8 File Offset: 0x00C09FB8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsTips.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsTips.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACA5 RID: 175269 RVA: 0x00C0BDFC File Offset: 0x00C09FFC
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
			this.EntryDescLayoutItem = new CardDetailEntryDescLayoutItem(base.GetLayoutBase(3), base.GetItem(4));
		}

		// Token: 0x0602ACA6 RID: 175270 RVA: 0x00C0BE6A File Offset: 0x00C0A06A
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			DynamicMaskButton maskButton = this.MaskButton;
			if (maskButton != null)
			{
				maskButton.Destroy(null);
			}
			this.RemoveTimeHandler();
		}

		// Token: 0x0602ACA7 RID: 175271 RVA: 0x00C0BE8F File Offset: 0x00C0A08F
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602ACA8 RID: 175272 RVA: 0x00C0BEA8 File Offset: 0x00C0A0A8
		public unsafe void RefreshByTaskData(PhantomArenaCardTaskData taskData)
		{
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(taskData.TaskCardConfigId);
			Dictionary<int, int> dictionary = phantomBattleCardConfig.InitAttack();
			int num;
			int attack = dictionary.TryGetValue(0, out num) ? num : 0;
			int num2;
			int life = dictionary.TryGetValue(1, out num2) ? num2 : 0;
			List<CardDetailFactorDescItemData> list = new List<CardDetailFactorDescItemData>();
			Span<int> cardFactorIdBytes = phantomBattleCardConfig.GetCardFactorIdBytes();
			for (int i = 0; i < cardFactorIdBytes.Length; i++)
			{
				int factorConfigId = *cardFactorIdBytes[i];
				list.Add(new CardDetailFactorDescItemData
				{
					FactorConfigId = factorConfigId,
					IsActive = false
				});
			}
			PhantomBattleFourCTask phantomArenaFourTask = PhantomArenaConfig.Instance.GetPhantomArenaFourTask(taskData.TaskCardConfigId);
			int conditionDescCurrentProgress = taskData.GetConditionDescCurrentProgress(phantomArenaFourTask.TaskDescConditionId);
			CardDetailTaskData taskData2 = new CardDetailTaskData
			{
				Desc = phantomArenaFourTask.TaskDesc,
				CurrentProgress = conditionDescCurrentProgress
			};
			CardAttributeData attributeData = new CardAttributeData
			{
				Cost = phantomBattleCardConfig.Cost,
				Attack = attack,
				Life = life
			};
			CardDescriptionData cardDescriptionData = new CardDescriptionData
			{
				Description = phantomBattleCardConfig.CardEffectDescription,
				DescriptionParams = new List<string>(phantomBattleCardConfig.CardEffectDescriptionParams())
			};
			CardDetailItemData data = new CardDetailItemData
			{
				Name = phantomBattleCardConfig.Name,
				AttributeData = attributeData,
				CardDescriptionData = cardDescriptionData,
				FactorDataList = list,
				TaskData = taskData2
			};
			this.DetailItem.Refresh(data);
			this.EntryDescLayoutItem.RefreshByCardConfig(phantomBattleCardConfig);
		}

		// Token: 0x0602ACA9 RID: 175273 RVA: 0x00C0C014 File Offset: 0x00C0A214
		private List<CardDetailFactorDescItemData> GetFactorDataList(PhantomCardData cardData)
		{
			if (cardData.IsTool)
			{
				return new List<CardDetailFactorDescItemData>();
			}
			List<CardDetailFactorDescItemData> list = new List<CardDetailFactorDescItemData>();
			foreach (int factorConfigId in cardData.ExtraFactors)
			{
				list.Add(new CardDetailFactorDescItemData
				{
					FactorConfigId = factorConfigId,
					IsActive = true
				});
			}
			foreach (int factorConfigId2 in cardData.UnActiveFactors)
			{
				list.Add(new CardDetailFactorDescItemData
				{
					FactorConfigId = factorConfigId2,
					IsActive = false
				});
			}
			return list;
		}

		// Token: 0x0602ACAA RID: 175274 RVA: 0x00C0C0EC File Offset: 0x00C0A2EC
		private CardAttributeData GetAttributeData(PhantomCardData cardData)
		{
			if (cardData.IsTool)
			{
				return null;
			}
			int fightValueByAttr = cardData.GetFightValueByAttr(PhantomBattleCardAttr.AttackAbility);
			int fightValueByAttr2 = cardData.GetFightValueByAttr(PhantomBattleCardAttr.LifeAbility);
			int fightValueByAttr3 = cardData.GetFightValueByAttr(PhantomBattleCardAttr.CostAbility);
			return new CardAttributeData
			{
				Cost = fightValueByAttr3,
				Attack = fightValueByAttr,
				Life = fightValueByAttr2
			};
		}

		// Token: 0x0602ACAB RID: 175275 RVA: 0x00C0C138 File Offset: 0x00C0A338
		private CardDescriptionData GetCardDescriptionData(PhantomCardData cardData)
		{
			if (cardData.IsTool)
			{
				return null;
			}
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
			return new CardDescriptionData
			{
				Description = phantomBattleCardConfig.CardEffectDescription,
				DescriptionParams = new List<string>(phantomBattleCardConfig.CardEffectDescriptionParams())
			};
		}

		// Token: 0x0602ACAC RID: 175276 RVA: 0x00C0C184 File Offset: 0x00C0A384
		private CardDetailDurationData GetDurationData(PhantomCardData cardData)
		{
			if (cardData.HasDurability)
			{
				return new CardDetailDurationData
				{
					DurationDesc = cardData.Durable.ToString() + "/" + cardData.DurableMax.ToString()
				};
			}
			return null;
		}

		// Token: 0x0602ACAD RID: 175277 RVA: 0x00C0C1CC File Offset: 0x00C0A3CC
		private CardDetailActiveSkillData GetActiveSkillData(PhantomCardData cardData)
		{
			if (cardData.HasClickActiveSkill)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
				return new CardDetailActiveSkillData
				{
					Desc = phantomBattleCardConfig.DurableSkillDescription,
					Params = new List<string>(phantomBattleCardConfig.DurableSkillDescriptionParams())
				};
			}
			return null;
		}

		// Token: 0x0602ACAE RID: 175278 RVA: 0x00C0C218 File Offset: 0x00C0A418
		private CardDetailPassiveSkillData GetPassiveSkillData(PhantomCardData cardData)
		{
			if (cardData.IsField)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
				string textKey = (!(cardData.IsNpcCard ? PhantomArenaBattleModel.Instance.OpponentData.IsFieldActive : PhantomArenaBattleModel.Instance.OwnData.IsFieldActive)) ? "PhantomBattle_1143" : "PhantomBattle_1144";
				CardDetailConditionInData inData = new CardDetailConditionInData
				{
					TextArg = new TableTextArgNew(textKey, Array.Empty<object>())
				};
				CardDetailPassiveSkillFieldData fieldData = new CardDetailPassiveSkillFieldData
				{
					InData = inData
				};
				CardDetailEffectCountData effectCountData = null;
				if (cardData.HasCountSkill)
				{
					effectCountData = new CardDetailEffectCountData
					{
						CurrentEffectCount = cardData.CurEffectCount,
						TotalEffectCount = cardData.MaxEffectCount
					};
				}
				return new CardDetailPassiveSkillData
				{
					Desc = (cardData.HasCountSkill ? phantomBattleCardConfig.CountSkillDescription : phantomBattleCardConfig.CardEffectDescription),
					Params = (cardData.HasCountSkill ? new List<string>(phantomBattleCardConfig.CountSkillDescriptionParams()) : new List<string>(phantomBattleCardConfig.CardEffectDescriptionParams())),
					FieldData = fieldData,
					EffectCountData = effectCountData
				};
			}
			return null;
		}

		// Token: 0x0602ACAF RID: 175279 RVA: 0x00C0C324 File Offset: 0x00C0A524
		private CardDetailPassiveSkillData GetCountSkillData(PhantomCardData cardData)
		{
			if (cardData.HasCountSkill)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
				CardDetailEffectCountData effectCountData = new CardDetailEffectCountData
				{
					CurrentEffectCount = cardData.CurEffectCount,
					TotalEffectCount = cardData.MaxEffectCount
				};
				return new CardDetailPassiveSkillData
				{
					Desc = phantomBattleCardConfig.CountSkillDescription,
					Params = new List<string>(phantomBattleCardConfig.CountSkillDescriptionParams()),
					EffectCountData = effectCountData
				};
			}
			return null;
		}

		// Token: 0x0602ACB0 RID: 175280 RVA: 0x00C0C395 File Offset: 0x00C0A595
		private CardDetailRemainRoundData GetRemainRoundData(PhantomCardData cardData)
		{
			if (cardData.IsCopy)
			{
				return new CardDetailRemainRoundData
				{
					RemainRound = 1
				};
			}
			return null;
		}

		// Token: 0x0602ACB1 RID: 175281 RVA: 0x00C0C3B0 File Offset: 0x00C0A5B0
		private void RefreshByNormalCardData(PhantomCardData cardData)
		{
			List<CardDetailFactorDescItemData> factorDataList = this.GetFactorDataList(cardData);
			CardAttributeData attributeData = this.GetAttributeData(cardData);
			CardDescriptionData cardDescriptionData = this.GetCardDescriptionData(cardData);
			CardDetailDurationData durationData = this.GetDurationData(cardData);
			CardDetailActiveSkillData activeSkillData = this.GetActiveSkillData(cardData);
			CardDetailPassiveSkillData countSkillData = this.GetCountSkillData(cardData);
			CardDetailRemainRoundData remainRoundData = this.GetRemainRoundData(cardData);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
			CardDetailItemData data = new CardDetailItemData
			{
				Name = phantomBattleCardConfig.Name,
				AttributeData = attributeData,
				CardDescriptionData = cardDescriptionData,
				FactorDataList = factorDataList,
				DurationData = durationData,
				ActiveSkillData = activeSkillData,
				PassiveSkillData = countSkillData,
				RemainRoundData = remainRoundData
			};
			this.DetailItem.Refresh(data);
			this.EntryDescLayoutItem.RefreshByCardConfig(phantomBattleCardConfig);
		}

		// Token: 0x0602ACB2 RID: 175282 RVA: 0x00C0C46C File Offset: 0x00C0A66C
		private void RefreshByFieldCardData(PhantomCardData cardData)
		{
			CardDetailActiveSkillData activeSkillData = this.GetActiveSkillData(cardData);
			CardDetailPassiveSkillData passiveSkillData = this.GetPassiveSkillData(cardData);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
			CardDetailItemData data = new CardDetailItemData
			{
				Name = phantomBattleCardConfig.Name,
				ActiveSkillData = activeSkillData,
				PassiveSkillData = passiveSkillData
			};
			this.DetailItem.Refresh(data);
			this.EntryDescLayoutItem.RefreshByCardConfig(phantomBattleCardConfig);
		}

		// Token: 0x0602ACB3 RID: 175283 RVA: 0x00C0C4D4 File Offset: 0x00C0A6D4
		private void CalculateTriggerItemPosition(UUIItem triggerItem)
		{
			if (triggerItem != null)
			{
				global::Vector tempWorldPos = this.TempWorldPos;
				FVectorDouble fvectorDouble = triggerItem.D_K2_GetComponentLocation();
				tempWorldPos.FromUeVector(fvectorDouble);
				global::Transform itemWorldTrans = this.ItemWorldTrans;
				FTransform ftransform = this.ParentUiItem.K2_GetComponentToWorld();
				itemWorldTrans.FromUeTransform(ftransform);
				this.ItemWorldTrans.InverseTransformPosition(this.TempWorldPos, this.TempWorldPos);
				UUIItem originalItem = this.GetOriginalItem();
				if (originalItem == null)
				{
					return;
				}
				originalItem.SetUIRelativeLocation(this.TempWorldPos.ToUeVectorOld());
			}
		}

		// Token: 0x0602ACB4 RID: 175284 RVA: 0x00C0C544 File Offset: 0x00C0A744
		private void RefreshPivotAndOffset(IPhantomArenaBattleDetailsTipsData tipsData)
		{
			this.ShowType = tipsData.ShowType;
			if (tipsData.PositionType == EPhantomArenaBattleDetailsPositionType.LeftTop)
			{
				base.GetItem(0).SetHierarchyIndex(0);
				this.SetPivotAndResetOffset(0f, 1f);
				return;
			}
			if (tipsData.PositionType == EPhantomArenaBattleDetailsPositionType.RightTop)
			{
				base.GetItem(1).SetHierarchyIndex(0);
				this.SetPivotAndResetOffset(1f, 1f);
				return;
			}
			if (tipsData.PositionType == EPhantomArenaBattleDetailsPositionType.LeftBottom)
			{
				base.GetItem(0).SetHierarchyIndex(0);
				this.SetPivotAndResetOffset(0f, 0f);
				return;
			}
			base.GetItem(1).SetHierarchyIndex(0);
			this.SetPivotAndResetOffset(1f, 0f);
		}

		// Token: 0x0602ACB5 RID: 175285 RVA: 0x00C0C5EE File Offset: 0x00C0A7EE
		private void AddTimeHandler()
		{
			this.RemoveTimeHandler();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.CheckMouseInTip();
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x0602ACB6 RID: 175286 RVA: 0x00C0C61F File Offset: 0x00C0A81F
		private void RemoveTimeHandler()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602ACB7 RID: 175287 RVA: 0x00C0C644 File Offset: 0x00C0A844
		private void ShowTips()
		{
			this.RemoveTimeHandler();
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Start", false, null);
		}

		// Token: 0x0602ACB8 RID: 175288 RVA: 0x00C0C688 File Offset: 0x00C0A888
		private void HideTips()
		{
			this.RemoveTimeHandler();
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Close", false, null);
			this.ShowType = EPhantomArenaBattleDetailsTipsShowType.None;
		}

		// Token: 0x0602ACB9 RID: 175289 RVA: 0x00C0C6CC File Offset: 0x00C0A8CC
		private void CheckMouseInTip()
		{
			if (this.RootItem == null)
			{
				this.RemoveTimeHandler();
				return;
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, true);
			if (pointerEventData == null || !pointerEventData.enterComponentStack.Contains(this.RootItem))
			{
				this.HideTips();
			}
		}

		// Token: 0x0602ACBA RID: 175290 RVA: 0x00C0C711 File Offset: 0x00C0A911
		public void RefreshByCardData(PhantomCardData cardData)
		{
			if (cardData.IsField)
			{
				this.RefreshByFieldCardData(cardData);
				return;
			}
			this.RefreshByNormalCardData(cardData);
		}

		// Token: 0x0602ACBB RID: 175291 RVA: 0x00C0C72A File Offset: 0x00C0A92A
		public void SetTipsPositionByAttachItem(IPhantomArenaBattleDetailsTipsData tipsData)
		{
			UUIItem originalItem = this.GetOriginalItem();
			if (originalItem != null)
			{
				originalItem.SetUIParent(tipsData.AttachItem, false);
			}
			this.RefreshPivotAndOffset(tipsData);
		}

		// Token: 0x0602ACBC RID: 175292 RVA: 0x00C0C74B File Offset: 0x00C0A94B
		public void SetTipsPositionByTriggerItem(IPhantomArenaBattleDetailsTipsData tipsData)
		{
			this.RefreshPivotAndOffset(tipsData);
			this.CalculateTriggerItemPosition(tipsData.TriggerItem);
		}

		// Token: 0x0602ACBD RID: 175293 RVA: 0x00C0C760 File Offset: 0x00C0A960
		public void SetTipsActive(EPhantomArenaBattleShowTipsType showType)
		{
			bool flag = showType == EPhantomArenaBattleShowTipsType.DetailsTips || showType == EPhantomArenaBattleShowTipsType.FieldDetailsTips;
			if (this.IsInActive == flag)
			{
				return;
			}
			this.IsInActive = flag;
			EPhantomArenaBattleShowTipsType showTipsType = this.ShowTipsType;
			this.ShowTipsType = showType;
			if (this.IsInActive)
			{
				this.ShowTips();
				return;
			}
			if (showTipsType == EPhantomArenaBattleShowTipsType.DetailsTips)
			{
				this.HideTips();
				return;
			}
			if (showTipsType == EPhantomArenaBattleShowTipsType.FieldDetailsTips)
			{
				this.AddTimeHandler();
			}
		}

		// Token: 0x0602ACBE RID: 175294 RVA: 0x00C0C7BC File Offset: 0x00C0A9BC
		public void SetPivotAndResetOffset(float pivotX, float pivotY)
		{
			UUIItem originalItem = this.GetOriginalItem();
			if (originalItem != null)
			{
				originalItem.SetPivot(new FVector2D(pivotX, pivotY));
			}
			UUIItem originalItem2 = this.GetOriginalItem();
			if (originalItem2 == null)
			{
				return;
			}
			originalItem2.SetAnchorOffset(new FVector2D(0f, 0f));
		}

		// Token: 0x0602ACBF RID: 175295 RVA: 0x00C0C7F5 File Offset: 0x00C0A9F5
		private void ShowMaskButton()
		{
			this.MaskButton.SetActive(true);
		}

		// Token: 0x0602ACC0 RID: 175296 RVA: 0x00C0C803 File Offset: 0x00C0AA03
		private void HideMaskButton()
		{
			this.MaskButton.SetActive(false);
		}

		// Token: 0x0602ACC1 RID: 175297 RVA: 0x00C0C811 File Offset: 0x00C0AA11
		public void SetMaskAttach(UUIItem uiItem)
		{
			this.MaskAttach = uiItem;
		}

		// Token: 0x0602ACC2 RID: 175298 RVA: 0x00C0C81A File Offset: 0x00C0AA1A
		public void ShowEntry()
		{
			if (this.IsEntryShow)
			{
				return;
			}
			this.IsEntryShow = true;
			this.RefreshEntryShowState();
		}

		// Token: 0x0602ACC3 RID: 175299 RVA: 0x00C0C832 File Offset: 0x00C0AA32
		public void HideEntry()
		{
			if (!this.IsEntryShow)
			{
				return;
			}
			this.IsEntryShow = false;
			this.RefreshEntryShowState();
		}

		// Token: 0x0602ACC4 RID: 175300 RVA: 0x00C0C84A File Offset: 0x00C0AA4A
		public void RefreshEntryShowState()
		{
			base.GetItem(1).SetUIActive(this.IsEntryShow);
		}

		// Token: 0x0602ACC5 RID: 175301 RVA: 0x00C0C85E File Offset: 0x00C0AA5E
		private void OnCardDescBtnClick()
		{
			this.ShowEntry();
			this.ShowMaskButton();
		}

		// Token: 0x0602ACC6 RID: 175302 RVA: 0x00C0C86C File Offset: 0x00C0AA6C
		private void OnMaskBtnClick()
		{
			this.HideEntry();
			this.HideMaskButton();
		}

		// Token: 0x0602ACC7 RID: 175303 RVA: 0x00C0C87C File Offset: 0x00C0AA7C
		public void SetBtnMaskCallback(Action cb)
		{
			this.BtnBottomCb = cb;
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0602ACC8 RID: 175304 RVA: 0x00C0C8AF File Offset: 0x00C0AAAF
		private void OnClickBottomMask()
		{
			Action btnBottomCb = this.BtnBottomCb;
			if (btnBottomCb == null)
			{
				return;
			}
			btnBottomCb();
		}

		// Token: 0x0602ACC9 RID: 175305 RVA: 0x00C0C8C4 File Offset: 0x00C0AAC4
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "CardEffect" || a == "CardAttr" || a == "Task")
			{
				CardDetailItem detailItem = this.DetailItem;
				if (detailItem == null)
				{
					return null;
				}
				return detailItem.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(a == "CardFullInfo"))
				{
					return null;
				}
				UUIItem item = base.GetItem(0);
				if (item == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					item,
					item
				};
			}
		}

		// Token: 0x040172E1 RID: 94945
		protected CardDetailItem DetailItem;

		// Token: 0x040172E2 RID: 94946
		protected CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x040172E3 RID: 94947
		protected UiSequencePlayer Sequence;

		// Token: 0x040172E4 RID: 94948
		protected DynamicMaskButton MaskButton;

		// Token: 0x040172E5 RID: 94949
		protected UUIItem MaskAttach;

		// Token: 0x040172E6 RID: 94950
		protected bool IsEntryShow;

		// Token: 0x040172E7 RID: 94951
		public EPhantomArenaBattleShowTipsType ShowTipsType;

		// Token: 0x040172E8 RID: 94952
		public bool IsInActive;

		// Token: 0x040172E9 RID: 94953
		public EPhantomArenaBattleDetailsTipsShowType ShowType;

		// Token: 0x040172EA RID: 94954
		protected Action BtnBottomCb;

		// Token: 0x040172EB RID: 94955
		protected readonly global::Vector TempWorldPos = global::Vector.Create();

		// Token: 0x040172EC RID: 94956
		protected readonly global::Transform ItemWorldTrans = global::Transform.Create();

		// Token: 0x040172ED RID: 94957
		protected TimerHandle TimerHandle;

		// Token: 0x02009E42 RID: 40514
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031332 RID: 201522
			public const int DescRootItem = 0;

			// Token: 0x04031333 RID: 201523
			public const int EntryRootItem = 1;

			// Token: 0x04031334 RID: 201524
			public const int CardDetailsItem = 2;

			// Token: 0x04031335 RID: 201525
			public const int EntryDescLayout = 3;

			// Token: 0x04031336 RID: 201526
			public const int EntryDescLayoutItem = 4;

			// Token: 0x04031337 RID: 201527
			public const int CardDescBtn = 5;

			// Token: 0x04031338 RID: 201528
			public const int BtnMask = 6;
		}
	}
}
