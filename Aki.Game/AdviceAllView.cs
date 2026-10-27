using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016CA RID: 5834
[NullableContext(2)]
[Nullable(0)]
public class AdviceAllView : UiViewBase
{
	// Token: 0x0600A6C6 RID: 42694 RVA: 0x00255C4E File Offset: 0x00253E4E
	[NullableContext(1)]
	public AdviceAllView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A6C7 RID: 42695 RVA: 0x00255C64 File Offset: 0x00253E64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickChangeBtn)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickChangeBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickSwitchButton)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickCreateButton))
		};
	}

	// Token: 0x0600A6C8 RID: 42696 RVA: 0x00255E50 File Offset: 0x00254050
	protected override void OnStart()
	{
		this.AdviceSelectItem = new AdivceSelectItem(base.GetItem(6));
		this.AdviceSelectMotionItem = new AdviceSelectMotionItem(base.GetItem(7));
		this.AdviceSelectMotionItem.SetClickChangeRoleCall(new Action(this.OnClickChangeRole));
		this.AdviceAllViewShowContent = new AdviceAllViewShowContent(base.GetItem(8));
		this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimer), 1000f, 1f, null, null, true);
		this.ListCurrentEntityBattleTag();
	}

	// Token: 0x0600A6C9 RID: 42697 RVA: 0x00255ED9 File Offset: 0x002540D9
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		CommonPopViewBase popItem = childPopView.PopItem;
		if (popItem == null)
		{
			return;
		}
		popItem.SetHelpButtonActive(false);
	}

	// Token: 0x0600A6CA RID: 42698 RVA: 0x00255EF8 File Offset: 0x002540F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSelectItem, new Action(this.OnClickAdviceSelectItem));
		EventSystem.Instance.Add(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
		EventSystem.Instance.Add(EEventName.OnDeleteAdviceSuccess, new Action(this.OnDeleteAdvice));
		EventSystem.Instance.Add(EEventName.OnSelectAdviceWord, new Action(this.RefreshConfirmBtn));
		EventSystem.Instance.Add(EEventName.OnChangeAdviceWord, new Action(this.RefreshConfirmBtn));
	}

	// Token: 0x0600A6CB RID: 42699 RVA: 0x00255F94 File Offset: 0x00254194
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSelectItem, new Action(this.OnClickAdviceSelectItem));
		EventSystem.Instance.Remove(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
		EventSystem.Instance.Remove(EEventName.OnDeleteAdviceSuccess, new Action(this.OnDeleteAdvice));
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceWord, new Action(this.RefreshConfirmBtn));
		EventSystem.Instance.Remove(EEventName.OnChangeAdviceWord, new Action(this.RefreshConfirmBtn));
	}

	// Token: 0x0600A6CC RID: 42700 RVA: 0x00256030 File Offset: 0x00254230
	private void ListCurrentEntityBattleTag()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			WorldEntity entity = getCurrentEntity.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				this.IsPlayerEnterFight = baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]);
				this.RemoveEnterFightTask();
				if (this.IsPlayerEnterFight)
				{
					base.CloseMe(null);
					return;
				}
				this.ListenPlayerEnterFight(getCurrentEntity);
			}
		}
	}

	// Token: 0x0600A6CD RID: 42701 RVA: 0x002560A1 File Offset: 0x002542A1
	private void RemoveEnterFightTask()
	{
		if (this.EnterFightTask != null)
		{
			((ITagTask)this.EnterFightTask).EndTask();
			this.EnterFightTask = null;
		}
	}

	// Token: 0x0600A6CE RID: 42702 RVA: 0x002560C4 File Offset: 0x002542C4
	[NullableContext(1)]
	private void ListenPlayerEnterFight(EntityHandle playerEntity)
	{
		WorldEntity entity = playerEntity.Entity;
		BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			this.EnterFightTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]), new BaseTagComponent.TTagSwitchedCallback(this.OnPlayerEnterFight), null);
		}
	}

	// Token: 0x0600A6CF RID: 42703 RVA: 0x00256114 File Offset: 0x00254314
	private void OnPlayerEnterFight(int tagId, bool tagExists)
	{
		this.IsPlayerEnterFight = tagExists;
		if (tagExists)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600A6D0 RID: 42704 RVA: 0x00256127 File Offset: 0x00254327
	private void OnClickSwitchButton()
	{
		AdviceController.Instance.OpenAdviceView();
	}

	// Token: 0x0600A6D1 RID: 42705 RVA: 0x00256134 File Offset: 0x00254334
	private void OnClickCreateButton()
	{
		if (AdviceModel.Instance.GetIfCanCreateAdvice(AdviceModel.Instance.CurrentLineModel))
		{
			global::Vector vector = global::Vector.Create();
			Rotator rotator = Rotator.Create();
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) != null)
			{
				vector.DeepCopy(baseCharacter.CharacterActorComponent.ActorLocationProxy);
				global::Vector vector2 = vector;
				double z = vector2.Z;
				UCapsuleComponent capsuleComponent = baseCharacter.CharacterActorComponent.Actor.CapsuleComponent;
				vector2.Z = z - (double)((capsuleComponent != null) ? capsuleComponent.GetScaledCapsuleHalfHeight() : 0f);
				rotator.DeepCopy(baseCharacter.CharacterActorComponent.ActorRotationProxy);
				AActor currentCameraActor = CameraModel.Instance.MainModel.CurrentCameraActor;
				if (currentCameraActor != null)
				{
					rotator.Yaw = currentCameraActor.D_GetTransform().Rotator().Yaw + 90f;
				}
				AdviceController.Instance.RequestCreateAdvice(vector, rotator, AdviceModel.Instance.GetCreateAdviceContent(), delegate
				{
					base.CloseMe(null);
				});
				return;
			}
		}
		else
		{
			GenericPromptController.Instance.ShowPromptByCode("AdviceNeedFull", Array.Empty<object>());
		}
	}

	// Token: 0x0600A6D2 RID: 42706 RVA: 0x00256237 File Offset: 0x00254437
	private void OnEnsureRole(int roleId)
	{
		this.RoleSelectionSelectedEvent(roleId);
	}

	// Token: 0x0600A6D3 RID: 42707 RVA: 0x00256240 File Offset: 0x00254440
	private void OnClickChangeRole()
	{
		int preSelectRoleId = AdviceModel.Instance.PreSelectRoleId;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(preSelectRoleId);
		if (roleInstanceById == null)
		{
			return;
		}
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		TeamRoleSelectViewData data = new TeamRoleSelectViewData(EFilterSortGroupId.Role, roleInstanceById.GetRoleId(), roleList.Cast<RoleDataBase>().ToList<RoleDataBase>(), new Action<int>(this.OnEnsureRole), null, null, null);
		RoleController.Instance.OpenTeamRoleSelectView(data);
	}

	// Token: 0x0600A6D4 RID: 42708 RVA: 0x002562B8 File Offset: 0x002544B8
	private void OnClickAdviceSelectItem()
	{
		EAdviceSelectItemEnum preSelectAdviceItemId = (EAdviceSelectItemEnum)AdviceModel.Instance.PreSelectAdviceItemId;
		if (preSelectAdviceItemId == EAdviceSelectItemEnum.SelectWord1)
		{
			this.OnClickSelectWordBtn(0);
		}
		else if (preSelectAdviceItemId == EAdviceSelectItemEnum.Conjunction)
		{
			this.OnClickChangeConjunctionBtn();
		}
		else if (preSelectAdviceItemId == EAdviceSelectItemEnum.SelectWord2)
		{
			this.OnClickSelectWordBtn(1);
		}
		else if (preSelectAdviceItemId == EAdviceSelectItemEnum.AddExpression)
		{
			this.OnClickCurrentEmojiBtn();
		}
		else if (preSelectAdviceItemId == EAdviceSelectItemEnum.ChangeWordBtn)
		{
			this.OnClickChangeWordBtn();
		}
		else if (preSelectAdviceItemId == EAdviceSelectItemEnum.AddOrDecreaseBtn)
		{
			this.ChangeLineMode();
		}
		this.RefreshConfirmBtn();
	}

	// Token: 0x0600A6D5 RID: 42709 RVA: 0x0025631D File Offset: 0x0025451D
	private void OnClickSelectWordBtn(int wordIndex)
	{
		AdviceController.Instance.OpenAdviceWordSelectView(wordIndex);
	}

	// Token: 0x0600A6D6 RID: 42710 RVA: 0x0025632A File Offset: 0x0025452A
	private void OnClickChangeWordBtn()
	{
		AdviceController.Instance.OpenAdviceSentenceSelectView();
	}

	// Token: 0x0600A6D7 RID: 42711 RVA: 0x00256336 File Offset: 0x00254536
	private void OnClickChangeConjunctionBtn()
	{
		AdviceController.Instance.OpenAdviceConjunctionSelectView();
	}

	// Token: 0x0600A6D8 RID: 42712 RVA: 0x00256344 File Offset: 0x00254544
	private void ChangeLineMode()
	{
		if (AdviceModel.Instance.CurrentLineModel == ELineMode.SingleLine)
		{
			AdviceModel.Instance.CurrentLineModel = ELineMode.MutiLine;
		}
		else
		{
			AdviceModel.Instance.CurrentLineModel = ELineMode.SingleLine;
			AdviceModel.Instance.OnChangeSentence(1);
			AdviceModel.Instance.CurrentConjunctionId = 0;
		}
		this.RefreshView();
	}

	// Token: 0x0600A6D9 RID: 42713 RVA: 0x00256391 File Offset: 0x00254591
	private void OnClickCurrentEmojiBtn()
	{
		AdviceController.Instance.OpenAdviceExpressionView();
	}

	// Token: 0x0600A6DA RID: 42714 RVA: 0x0025639D File Offset: 0x0025459D
	protected override void OnAfterShow()
	{
		this.CurrentViewState = new int?(0);
		AdviceModel.Instance.CurrentLineModel = ELineMode.SingleLine;
		this.RefreshView();
		this.ShowAdviceModel();
		this.RefreshTitle();
	}

	// Token: 0x0600A6DB RID: 42715 RVA: 0x002563C8 File Offset: 0x002545C8
	private void RefreshTitle()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.SetTitleByTextIdAndArg("AdviceName", Array.Empty<object>());
	}

	// Token: 0x0600A6DC RID: 42716 RVA: 0x002563E4 File Offset: 0x002545E4
	private void OnTimer(float deltaTime)
	{
		this.CurrentRunningTime += 1000;
		if (this.CurrentRunningTime >= 5000)
		{
			int? currentViewState = this.CurrentViewState;
			int num = 0;
			if (!(currentViewState.GetValueOrDefault() == num & currentViewState != null))
			{
				this.OnClickMotion();
			}
		}
	}

	// Token: 0x0600A6DD RID: 42717 RVA: 0x00256434 File Offset: 0x00254634
	private void ShowAdviceModel()
	{
		this.TryEnableEntity();
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (((getCurrentEntity != null) ? getCurrentEntity.Entity : null) != null)
		{
			this.EntityDisableHandle = getCurrentEntity.Entity.Disable("[AdviceCreate DisableCharacter]");
		}
		this.AdviceCreateActor = AdviceModel.Instance.GetAdviceCreateActor();
	}

	// Token: 0x0600A6DE RID: 42718 RVA: 0x00256486 File Offset: 0x00254686
	private void TryEnableEntity()
	{
		if (this.EntityDisableHandle > 0)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null)
			{
				WorldEntity entity = getCurrentEntity.Entity;
				if (entity != null)
				{
					entity.Enable(this.EntityDisableHandle, "AdviceAllView.TryEnableEntity");
				}
			}
			this.EntityDisableHandle = 0;
		}
	}

	// Token: 0x0600A6DF RID: 42719 RVA: 0x002564C4 File Offset: 0x002546C4
	private void OnClickMotion()
	{
		this.CurrentRunningTime = 0;
		if (AdviceModel.Instance.PreSelectMotionId == AdviceConfig.Instance.GetAdviceMotionDefaultConfigId())
		{
			AdviceCreateActor adviceCreateActor = this.AdviceCreateActor;
			if (adviceCreateActor == null)
			{
				return;
			}
			adviceCreateActor.HideAnimation();
			return;
		}
		else
		{
			AdviceCreateActor adviceCreateActor2 = this.AdviceCreateActor;
			if (adviceCreateActor2 == null)
			{
				return;
			}
			adviceCreateActor2.PlayAnimation(AdviceModel.Instance.PreSelectMotionId);
			return;
		}
	}

	// Token: 0x0600A6E0 RID: 42720 RVA: 0x00256519 File Offset: 0x00254719
	private void OnDeleteAdvice()
	{
		this.RefreshView();
		this.RefreshSwitchBtnRedPoint();
		this.RefreshConfirmBtn();
	}

	// Token: 0x0600A6E1 RID: 42721 RVA: 0x00256530 File Offset: 0x00254730
	private void RoleSelectionSelectedEvent(int roleId)
	{
		AdviceModel.Instance.PreSelectRoleId = roleId;
		AdviceModel.Instance.PreSelectMotionId = AdviceConfig.Instance.GetAdviceMotionDefaultConfigId();
		AdviceModel.Instance.CurrentSelectMotionId = AdviceConfig.Instance.GetAdviceMotionDefaultConfigId();
		AdviceSelectMotionItem adviceSelectMotionItem = this.AdviceSelectMotionItem;
		if (adviceSelectMotionItem != null)
		{
			adviceSelectMotionItem.RefreshView(AdviceModel.Instance.GetMotionSelectData());
		}
		this.OnClickMotion();
		EventSystem.Instance.Emit(EEventName.OnChangeAdviceRole);
		EventSystem.Instance.Emit(EEventName.OnClickAdviceMotion);
	}

	// Token: 0x0600A6E2 RID: 42722 RVA: 0x002565B4 File Offset: 0x002547B4
	private void OnClickChangeBtn()
	{
		int? currentViewState = this.CurrentViewState;
		int num = 0;
		if (currentViewState.GetValueOrDefault() == num & currentViewState != null)
		{
			this.CurrentViewState = new int?(1);
		}
		else
		{
			this.CurrentViewState = new int?(0);
		}
		currentViewState = this.CurrentViewState;
		num = 0;
		if (currentViewState.GetValueOrDefault() == num & currentViewState != null)
		{
			AdviceCreateActor adviceCreateActor = this.AdviceCreateActor;
			if (adviceCreateActor != null)
			{
				adviceCreateActor.HideAnimation();
			}
		}
		else
		{
			this.OnClickMotion();
		}
		this.RefreshView();
	}

	// Token: 0x0600A6E3 RID: 42723 RVA: 0x00256634 File Offset: 0x00254834
	private void RefreshView()
	{
		this.RefreshContentView();
		this.RefreshStateText();
		this.RefreshSwitchBtnRedPoint();
		this.RefreshConfirmBtn();
		AdviceAllViewShowContent adviceAllViewShowContent = this.AdviceAllViewShowContent;
		if (adviceAllViewShowContent == null)
		{
			return;
		}
		adviceAllViewShowContent.RefreshView();
	}

	// Token: 0x0600A6E4 RID: 42724 RVA: 0x00256660 File Offset: 0x00254860
	private void RefreshStateText()
	{
		if (this.CurrentViewState.GetValueOrDefault() == 1)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(3), "Motion", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(3), "TextAndExpression", Array.Empty<object>());
	}

	// Token: 0x0600A6E5 RID: 42725 RVA: 0x002566B4 File Offset: 0x002548B4
	private void RefreshContentView()
	{
		bool flag = false;
		if (!AdviceModel.Instance.GetCreateConditionState())
		{
			if (AdviceModel.Instance.CheckIfMaxAdvice())
			{
				flag = false;
			}
			else
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(9);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(12);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUIButtonComponent button = base.GetButton(4);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				AdviceAllViewShowContent adviceAllViewShowContent = this.AdviceAllViewShowContent;
				if (adviceAllViewShowContent != null)
				{
					adviceAllViewShowContent.SetActive(false);
				}
				this.RefreshCreateLimitText();
				flag = true;
			}
		}
		if (!flag)
		{
			UUIItem item4 = base.GetItem(12);
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
			UUIItem item5 = base.GetItem(0);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(9);
			if (item6 != null)
			{
				item6.SetUIActive(true);
			}
			UUIButtonComponent button2 = base.GetButton(4);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(true);
			}
			AdviceAllViewShowContent adviceAllViewShowContent2 = this.AdviceAllViewShowContent;
			if (adviceAllViewShowContent2 != null)
			{
				adviceAllViewShowContent2.SetActive(true);
			}
			if (this.CurrentViewState.GetValueOrDefault() == 1)
			{
				AdivceSelectItem adviceSelectItem = this.AdviceSelectItem;
				if (adviceSelectItem != null)
				{
					adviceSelectItem.SetActive(false);
				}
				AdviceSelectMotionItem adviceSelectMotionItem = this.AdviceSelectMotionItem;
				if (adviceSelectMotionItem != null)
				{
					adviceSelectMotionItem.SetActive(true);
				}
				UUIItem item7 = base.GetItem(13);
				if (item7 != null)
				{
					item7.SetUIActive(true);
				}
				AdviceSelectMotionItem adviceSelectMotionItem2 = this.AdviceSelectMotionItem;
				if (adviceSelectMotionItem2 == null)
				{
					return;
				}
				adviceSelectMotionItem2.RefreshView(AdviceModel.Instance.GetMotionSelectData());
				return;
			}
			else
			{
				UUIItem item8 = base.GetItem(13);
				if (item8 != null)
				{
					item8.SetUIActive(false);
				}
				AdviceSelectMotionItem adviceSelectMotionItem3 = this.AdviceSelectMotionItem;
				if (adviceSelectMotionItem3 != null)
				{
					adviceSelectMotionItem3.SetActive(false);
				}
				AdivceSelectItem adviceSelectItem2 = this.AdviceSelectItem;
				if (adviceSelectItem2 != null)
				{
					adviceSelectItem2.SetActive(true);
				}
				AdivceSelectItem adviceSelectItem3 = this.AdviceSelectItem;
				if (adviceSelectItem3 == null)
				{
					return;
				}
				adviceSelectItem3.RefreshView(AdviceModel.Instance.GetAdviceSelectData(AdviceModel.Instance.CurrentLineModel));
			}
		}
	}

	// Token: 0x0600A6E6 RID: 42726 RVA: 0x00256887 File Offset: 0x00254A87
	private void RefreshCreateLimitText()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(14), AdviceModel.Instance.GetCreateConditionFailText(), Array.Empty<object>());
	}

	// Token: 0x0600A6E7 RID: 42727 RVA: 0x002568AC File Offset: 0x00254AAC
	private void RefreshSwitchBtnRedPoint()
	{
		AdviceData[] adviceArray = AdviceModel.Instance.GetAdviceArray();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("AdviceCreateLimit").GetValueOrDefault();
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(adviceArray != null && adviceArray.Length >= valueOrDefault);
	}

	// Token: 0x0600A6E8 RID: 42728 RVA: 0x002568F8 File Offset: 0x00254AF8
	private void RefreshConfirmBtn()
	{
		AdviceData[] adviceArray = AdviceModel.Instance.GetAdviceArray();
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("AdviceCreateLimit").GetValueOrDefault();
		object obj = adviceArray != null && adviceArray.Length >= valueOrDefault;
		bool ifCanCreateAdvice = AdviceModel.Instance.GetIfCanCreateAdvice(AdviceModel.Instance.CurrentLineModel);
		object obj2 = obj;
		if (obj2 != null || !ifCanCreateAdvice)
		{
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
		}
		else
		{
			UUIButtonComponent button2 = base.GetButton(4);
			if (button2 != null)
			{
				button2.SetSelfInteractive(true);
			}
		}
		if (obj2 != null)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(11), "Advice_Max", Array.Empty<object>());
			return;
		}
		if (!ifCanCreateAdvice)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(11), "AdviceNotFull", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(11), "Advice_Publish", Array.Empty<object>());
	}

	// Token: 0x0600A6E9 RID: 42729 RVA: 0x002569D0 File Offset: 0x00254BD0
	protected override void OnBeforeDestroy()
	{
		AdviceCreateActor adviceCreateActor = this.AdviceCreateActor;
		if (adviceCreateActor != null)
		{
			adviceCreateActor.Destroy();
		}
		this.TryEnableEntity();
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
		}
	}

	// Token: 0x04004B5F RID: 19295
	private const int CHECKTIMEER = 1000;

	// Token: 0x04004B60 RID: 19296
	private const int ANIMATIONGAP = 5000;

	// Token: 0x04004B61 RID: 19297
	private int EntityDisableHandle;

	// Token: 0x04004B62 RID: 19298
	private int? CurrentViewState = new int?(0);

	// Token: 0x04004B63 RID: 19299
	private AdivceSelectItem AdviceSelectItem;

	// Token: 0x04004B64 RID: 19300
	private AdviceSelectMotionItem AdviceSelectMotionItem;

	// Token: 0x04004B65 RID: 19301
	private AdviceAllViewShowContent AdviceAllViewShowContent;

	// Token: 0x04004B66 RID: 19302
	private AdviceCreateActor AdviceCreateActor;

	// Token: 0x04004B67 RID: 19303
	private TimerHandle Timer;

	// Token: 0x04004B68 RID: 19304
	private int CurrentRunningTime;

	// Token: 0x04004B69 RID: 19305
	private object EnterFightTask;

	// Token: 0x04004B6A RID: 19306
	private bool IsPlayerEnterFight;

	// Token: 0x02007C9E RID: 31902
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E03 RID: 167427
		public const int CanNotCreateTips = 0;

		// Token: 0x04028E04 RID: 167428
		public const int LeftBtn = 1;

		// Token: 0x04028E05 RID: 167429
		public const int RightBtn = 2;

		// Token: 0x04028E06 RID: 167430
		public const int BtnText = 3;

		// Token: 0x04028E07 RID: 167431
		public const int CreateBtn = 4;

		// Token: 0x04028E08 RID: 167432
		public const int SwitchBtn = 5;

		// Token: 0x04028E09 RID: 167433
		public const int SelectItem = 6;

		// Token: 0x04028E0A RID: 167434
		public const int MotionItem = 7;

		// Token: 0x04028E0B RID: 167435
		public const int WordItem = 8;

		// Token: 0x04028E0C RID: 167436
		public const int ContentItem = 9;

		// Token: 0x04028E0D RID: 167437
		public const int SwitchBtnRedPoint = 10;

		// Token: 0x04028E0E RID: 167438
		public const int ConfirmBtnText = 11;

		// Token: 0x04028E0F RID: 167439
		public const int SwitchContainer = 12;

		// Token: 0x04028E10 RID: 167440
		public const int RoleContainer = 13;

		// Token: 0x04028E11 RID: 167441
		public const int CreateLimitText = 14;

		// Token: 0x04028E12 RID: 167442
		public const int CreateLimitTipsText = 15;
	}

	// Token: 0x02007C9F RID: 31903
	[NullableContext(0)]
	private static class EViewState
	{
		// Token: 0x04028E13 RID: 167443
		public const int Normal = 0;

		// Token: 0x04028E14 RID: 167444
		public const int Motion = 1;
	}
}
