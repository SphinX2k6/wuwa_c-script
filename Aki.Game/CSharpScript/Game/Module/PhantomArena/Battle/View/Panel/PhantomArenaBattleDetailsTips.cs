using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005254 RID: 21076
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsTips : UiPanelBase
	{
		// Token: 0x06035DA6 RID: 220582 RVA: 0x00CBE5B0 File Offset: 0x00CBC7B0
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

		// Token: 0x06035DA7 RID: 220583 RVA: 0x00CBE6A0 File Offset: 0x00CBC8A0
		protected UniTask InitDetailsItem()
		{
			PhantomArenaBattleDetailsTips.<InitDetailsItem>d__15 <InitDetailsItem>d__;
			<InitDetailsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsItem>d__.<>4__this = this;
			<InitDetailsItem>d__.<>1__state = -1;
			<InitDetailsItem>d__.<>t__builder.Start<PhantomArenaBattleDetailsTips.<InitDetailsItem>d__15>(ref <InitDetailsItem>d__);
			return <InitDetailsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035DA8 RID: 220584 RVA: 0x00CBE6E4 File Offset: 0x00CBC8E4
		protected UniTask InitMaskButton()
		{
			PhantomArenaBattleDetailsTips.<InitMaskButton>d__16 <InitMaskButton>d__;
			<InitMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMaskButton>d__.<>4__this = this;
			<InitMaskButton>d__.<>1__state = -1;
			<InitMaskButton>d__.<>t__builder.Start<PhantomArenaBattleDetailsTips.<InitMaskButton>d__16>(ref <InitMaskButton>d__);
			return <InitMaskButton>d__.<>t__builder.Task;
		}

		// Token: 0x06035DA9 RID: 220585 RVA: 0x00CBE728 File Offset: 0x00CBC928
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsTips.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsTips.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035DAA RID: 220586 RVA: 0x00CBE76C File Offset: 0x00CBC96C
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

		// Token: 0x06035DAB RID: 220587 RVA: 0x00CBE7DA File Offset: 0x00CBC9DA
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

		// Token: 0x06035DAC RID: 220588 RVA: 0x00CBE7FF File Offset: 0x00CBC9FF
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035DAD RID: 220589 RVA: 0x00CBE818 File Offset: 0x00CBCA18
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
				DescriptionParams = phantomBattleCardConfig.CardEffectDescriptionParams().ToList<string>()
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

		// Token: 0x06035DAE RID: 220590 RVA: 0x00CBE984 File Offset: 0x00CBCB84
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

		// Token: 0x06035DAF RID: 220591 RVA: 0x00CBEA5C File Offset: 0x00CBCC5C
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

		// Token: 0x06035DB0 RID: 220592 RVA: 0x00CBEAA8 File Offset: 0x00CBCCA8
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
				DescriptionParams = phantomBattleCardConfig.CardEffectDescriptionParams().ToList<string>()
			};
		}

		// Token: 0x06035DB1 RID: 220593 RVA: 0x00CBEAF4 File Offset: 0x00CBCCF4
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

		// Token: 0x06035DB2 RID: 220594 RVA: 0x00CBEB3C File Offset: 0x00CBCD3C
		private CardDetailActiveSkillData GetActiveSkillData(PhantomCardData cardData)
		{
			if (cardData.HasClickActiveSkill)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardData.ConfigId);
				return new CardDetailActiveSkillData
				{
					Desc = phantomBattleCardConfig.DurableSkillDescription,
					Params = phantomBattleCardConfig.DurableSkillDescriptionParams().ToList<string>()
				};
			}
			return null;
		}

		// Token: 0x06035DB3 RID: 220595 RVA: 0x00CBEB88 File Offset: 0x00CBCD88
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
					Params = (cardData.HasCountSkill ? phantomBattleCardConfig.CountSkillDescriptionParams().ToList<string>() : phantomBattleCardConfig.CardEffectDescriptionParams().ToList<string>()),
					FieldData = fieldData,
					EffectCountData = effectCountData
				};
			}
			return null;
		}

		// Token: 0x06035DB4 RID: 220596 RVA: 0x00CBEC94 File Offset: 0x00CBCE94
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
					Params = phantomBattleCardConfig.CountSkillDescriptionParams().ToList<string>(),
					EffectCountData = effectCountData
				};
			}
			return null;
		}

		// Token: 0x06035DB5 RID: 220597 RVA: 0x00CBED05 File Offset: 0x00CBCF05
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

		// Token: 0x06035DB6 RID: 220598 RVA: 0x00CBED20 File Offset: 0x00CBCF20
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

		// Token: 0x06035DB7 RID: 220599 RVA: 0x00CBEDDC File Offset: 0x00CBCFDC
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

		// Token: 0x06035DB8 RID: 220600 RVA: 0x00CBEE44 File Offset: 0x00CBD044
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

		// Token: 0x06035DB9 RID: 220601 RVA: 0x00CBEEB4 File Offset: 0x00CBD0B4
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

		// Token: 0x06035DBA RID: 220602 RVA: 0x00CBEF5E File Offset: 0x00CBD15E
		private void AddTimeHandler()
		{
			this.RemoveTimeHandler();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.CheckMouseInTip();
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x06035DBB RID: 220603 RVA: 0x00CBEF8F File Offset: 0x00CBD18F
		private void RemoveTimeHandler()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06035DBC RID: 220604 RVA: 0x00CBEFB4 File Offset: 0x00CBD1B4
		private void ShowTips()
		{
			this.RemoveTimeHandler();
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06035DBD RID: 220605 RVA: 0x00CBEFF8 File Offset: 0x00CBD1F8
		private void HideTips()
		{
			this.RemoveTimeHandler();
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Close", false, null);
			this.ShowType = EPhantomArenaBattleDetailsTipsShowType.None;
		}

		// Token: 0x06035DBE RID: 220606 RVA: 0x00CBF03C File Offset: 0x00CBD23C
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

		// Token: 0x06035DBF RID: 220607 RVA: 0x00CBF081 File Offset: 0x00CBD281
		public void RefreshByCardData(PhantomCardData cardData)
		{
			if (cardData.IsField)
			{
				this.RefreshByFieldCardData(cardData);
				return;
			}
			this.RefreshByNormalCardData(cardData);
		}

		// Token: 0x06035DC0 RID: 220608 RVA: 0x00CBF09A File Offset: 0x00CBD29A
		public void SetTipsPositionByAttachItem(IPhantomArenaBattleDetailsTipsData tipsData)
		{
			UUIItem originalItem = this.GetOriginalItem();
			if (originalItem != null)
			{
				originalItem.SetUIParent(tipsData.AttachItem, false);
			}
			this.RefreshPivotAndOffset(tipsData);
		}

		// Token: 0x06035DC1 RID: 220609 RVA: 0x00CBF0BB File Offset: 0x00CBD2BB
		public void SetTipsPositionByTriggerItem(IPhantomArenaBattleDetailsTipsData tipsData)
		{
			this.RefreshPivotAndOffset(tipsData);
			this.CalculateTriggerItemPosition(tipsData.TriggerItem);
		}

		// Token: 0x06035DC2 RID: 220610 RVA: 0x00CBF0D0 File Offset: 0x00CBD2D0
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

		// Token: 0x06035DC3 RID: 220611 RVA: 0x00CBF12C File Offset: 0x00CBD32C
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

		// Token: 0x06035DC4 RID: 220612 RVA: 0x00CBF165 File Offset: 0x00CBD365
		private void ShowMaskButton()
		{
			this.MaskButton.SetActive(true);
		}

		// Token: 0x06035DC5 RID: 220613 RVA: 0x00CBF173 File Offset: 0x00CBD373
		private void HideMaskButton()
		{
			this.MaskButton.SetActive(false);
		}

		// Token: 0x06035DC6 RID: 220614 RVA: 0x00CBF181 File Offset: 0x00CBD381
		public void SetMaskAttach(UUIItem uiItem)
		{
			this.MaskAttach = uiItem;
		}

		// Token: 0x06035DC7 RID: 220615 RVA: 0x00CBF18A File Offset: 0x00CBD38A
		public void ShowEntry()
		{
			if (this.IsEntryShow)
			{
				return;
			}
			this.IsEntryShow = true;
			this.RefreshEntryShowState();
		}

		// Token: 0x06035DC8 RID: 220616 RVA: 0x00CBF1A2 File Offset: 0x00CBD3A2
		public void HideEntry()
		{
			if (!this.IsEntryShow)
			{
				return;
			}
			this.IsEntryShow = false;
			this.RefreshEntryShowState();
		}

		// Token: 0x06035DC9 RID: 220617 RVA: 0x00CBF1BA File Offset: 0x00CBD3BA
		public void RefreshEntryShowState()
		{
			base.GetItem(1).SetUIActive(this.IsEntryShow);
		}

		// Token: 0x06035DCA RID: 220618 RVA: 0x00CBF1CE File Offset: 0x00CBD3CE
		private void OnCardDescBtnClick()
		{
			this.ShowEntry();
			this.ShowMaskButton();
		}

		// Token: 0x06035DCB RID: 220619 RVA: 0x00CBF1DC File Offset: 0x00CBD3DC
		private void OnMaskBtnClick()
		{
			this.HideEntry();
			this.HideMaskButton();
		}

		// Token: 0x06035DCC RID: 220620 RVA: 0x00CBF1EC File Offset: 0x00CBD3EC
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

		// Token: 0x06035DCD RID: 220621 RVA: 0x00CBF21F File Offset: 0x00CBD41F
		private void OnClickBottomMask()
		{
			Action btnBottomCb = this.BtnBottomCb;
			if (btnBottomCb == null)
			{
				return;
			}
			btnBottomCb();
		}

		// Token: 0x06035DCE RID: 220622 RVA: 0x00CBF234 File Offset: 0x00CBD434
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

		// Token: 0x0401C8AC RID: 116908
		protected CardDetailItem DetailItem;

		// Token: 0x0401C8AD RID: 116909
		protected CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x0401C8AE RID: 116910
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8AF RID: 116911
		protected DynamicMaskButton MaskButton;

		// Token: 0x0401C8B0 RID: 116912
		protected UUIItem MaskAttach;

		// Token: 0x0401C8B1 RID: 116913
		protected bool IsEntryShow;

		// Token: 0x0401C8B2 RID: 116914
		public EPhantomArenaBattleShowTipsType ShowTipsType;

		// Token: 0x0401C8B3 RID: 116915
		public bool IsInActive;

		// Token: 0x0401C8B4 RID: 116916
		public EPhantomArenaBattleDetailsTipsShowType ShowType;

		// Token: 0x0401C8B5 RID: 116917
		protected Action BtnBottomCb;

		// Token: 0x0401C8B6 RID: 116918
		protected readonly global::Vector TempWorldPos = global::Vector.Create();

		// Token: 0x0401C8B7 RID: 116919
		protected readonly global::Transform ItemWorldTrans = global::Transform.Create();

		// Token: 0x0401C8B8 RID: 116920
		protected TimerHandle TimerHandle;

		// Token: 0x0200B40A RID: 46090
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040368DF RID: 223455
			public const int DescRootItem = 0;

			// Token: 0x040368E0 RID: 223456
			public const int EntryRootItem = 1;

			// Token: 0x040368E1 RID: 223457
			public const int CardDetailsItem = 2;

			// Token: 0x040368E2 RID: 223458
			public const int EntryDescLayout = 3;

			// Token: 0x040368E3 RID: 223459
			public const int EntryDescLayoutItem = 4;

			// Token: 0x040368E4 RID: 223460
			public const int CardDescBtn = 5;

			// Token: 0x040368E5 RID: 223461
			public const int BtnMask = 6;
		}
	}
}
