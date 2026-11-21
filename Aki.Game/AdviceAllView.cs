using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B82 RID: 2946
[NullableContext(2)]
[Nullable(0)]
public class AdviceAllView : UiViewBase
{
	// Token: 0x06007AA6 RID: 31398 RVA: 0x0026005E File Offset: 0x0025E25E
	[NullableContext(1)]
	public AdviceAllView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007AA7 RID: 31399 RVA: 0x00260074 File Offset: 0x0025E274
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

	// Token: 0x06007AA8 RID: 31400 RVA: 0x00260260 File Offset: 0x0025E460
	protected override void OnStart()
	{
		this.AdviceSelectItem = new AdivceSelectItem(base.GetItem(6));
		this.AdviceSelectMotionItem = new AdviceSelectMotionItem(base.GetItem(7));
		this.AdviceSelectMotionItem.SetClickChangeRoleCall(new Action(this.OnClickChangeRole));
		this.AdviceAllViewShowContent = new AdviceAllViewShowContent(base.GetItem(8));
		this.Timer = TimerSystem.Instance.Forever(new TTimerAction(this.OnTimer), 1000f, 1f, null, null, true);
		this.ListCurrentEntityBattleTag();
	}

	// Token: 0x06007AA9 RID: 31401 RVA: 0x002602E9 File Offset: 0x0025E4E9
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

	// Token: 0x06007AAA RID: 31402 RVA: 0x00260308 File Offset: 0x0025E508
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSelectItem, new Action(this.OnClickAdviceSelectItem));
		EventSystem.Instance.Add(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
		EventSystem.Instance.Add(EEventName.OnDeleteAdviceSuccess, new Action(this.OnDeleteAdvice));
		EventSystem.Instance.Add(EEventName.OnSelectAdviceWord, new Action(this.RefreshConfirmBtn));
		EventSystem.Instance.Add(EEventName.OnChangeAdviceWord, new Action(this.RefreshConfirmBtn));
	}

	// Token: 0x06007AAB RID: 31403 RVA: 0x002603A4 File Offset: 0x0025E5A4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSelectItem, new Action(this.OnClickAdviceSelectItem));
		EventSystem.Instance.Remove(EEventName.OnClickAdviceMotion, new Action(this.OnClickMotion));
		EventSystem.Instance.Remove(EEventName.OnDeleteAdviceSuccess, new Action(this.OnDeleteAdvice));
		EventSystem.Instance.Remove(EEventName.OnSelectAdviceWord, new Action(this.RefreshConfirmBtn));
		EventSystem.Instance.Remove(EEventName.OnChangeAdviceWord, new Action(this.RefreshConfirmBtn));
	}

	// Token: 0x06007AAC RID: 31404 RVA: 0x00260440 File Offset: 0x0025E640
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

	// Token: 0x06007AAD RID: 31405 RVA: 0x002604B1 File Offset: 0x0025E6B1
	private void RemoveEnterFightTask()
	{
		if (this.EnterFightTask != null)
		{
			((ITagTask)this.EnterFightTask).EndTask();
			this.EnterFightTask = null;
		}
	}

	// Token: 0x06007AAE RID: 31406 RVA: 0x002604D4 File Offset: 0x0025E6D4
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

	// Token: 0x06007AAF RID: 31407 RVA: 0x00260524 File Offset: 0x0025E724
	private void OnPlayerEnterFight(int tagId, bool tagExists)
	{
		this.IsPlayerEnterFight = tagExists;
		if (tagExists)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06007AB0 RID: 31408 RVA: 0x00260537 File Offset: 0x0025E737
	private void OnClickSwitchButton()
	{
		AdviceController.Instance.OpenAdviceView();
	}

	// Token: 0x06007AB1 RID: 31409 RVA: 0x00260544 File Offset: 0x0025E744
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

	// Token: 0x06007AB2 RID: 31410 RVA: 0x00260647 File Offset: 0x0025E847
	private void OnEnsureRole(int roleId)
	{
		this.RoleSelectionSelectedEvent(roleId);
	}

	// Token: 0x06007AB3 RID: 31411 RVA: 0x00260650 File Offset: 0x0025E850
	private void OnClickChangeRole()
	{
		int preSelectRoleId = AdviceModel.Instance.PreSelectRoleId;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(preSelectRoleId);
		if (roleInstanceById == null)
		{
			return;
		}
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		TeamRoleSelectViewData data = new TeamRoleSelectViewData(EFilterSortGroupId.Role, roleInstanceById.GetRoleId(), new List<RoleDataBase>(roleList), new Action<int>(this.OnEnsureRole), null, null, null);
		RoleController.Instance.OpenTeamRoleSelectView(data);
	}

	// Token: 0x06007AB4 RID: 31412 RVA: 0x002606C4 File Offset: 0x0025E8C4
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

	// Token: 0x06007AB5 RID: 31413 RVA: 0x00260729 File Offset: 0x0025E929
	private void OnClickSelectWordBtn(int wordIndex)
	{
		AdviceController.Instance.OpenAdviceWordSelectView(wordIndex);
	}

	// Token: 0x06007AB6 RID: 31414 RVA: 0x00260736 File Offset: 0x0025E936
	private void OnClickChangeWordBtn()
	{
		AdviceController.Instance.OpenAdviceSentenceSelectView();
	}

	// Token: 0x06007AB7 RID: 31415 RVA: 0x00260742 File Offset: 0x0025E942
	private void OnClickChangeConjunctionBtn()
	{
		AdviceController.Instance.OpenAdviceConjunctionSelectView();
	}

	// Token: 0x06007AB8 RID: 31416 RVA: 0x00260750 File Offset: 0x0025E950
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

	// Token: 0x06007AB9 RID: 31417 RVA: 0x0026079D File Offset: 0x0025E99D
	private void OnClickCurrentEmojiBtn()
	{
		AdviceController.Instance.OpenAdviceExpressionView();
	}

	// Token: 0x06007ABA RID: 31418 RVA: 0x002607A9 File Offset: 0x0025E9A9
	protected override void OnAfterShow()
	{
		this.CurrentViewState = new int?(0);
		AdviceModel.Instance.CurrentLineModel = ELineMode.SingleLine;
		this.RefreshView();
		this.ShowAdviceModel();
		this.RefreshTitle();
	}

	// Token: 0x06007ABB RID: 31419 RVA: 0x002607D4 File Offset: 0x0025E9D4
	private void RefreshTitle()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView == null)
		{
			return;
		}
		childPopView.SetTitleByTextIdAndArg("AdviceName", Array.Empty<object>());
	}

	// Token: 0x06007ABC RID: 31420 RVA: 0x002607F0 File Offset: 0x0025E9F0
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

	// Token: 0x06007ABD RID: 31421 RVA: 0x00260840 File Offset: 0x0025EA40
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

	// Token: 0x06007ABE RID: 31422 RVA: 0x00260892 File Offset: 0x0025EA92
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

	// Token: 0x06007ABF RID: 31423 RVA: 0x002608D0 File Offset: 0x0025EAD0
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

	// Token: 0x06007AC0 RID: 31424 RVA: 0x00260925 File Offset: 0x0025EB25
	private void OnDeleteAdvice()
	{
		this.RefreshView();
		this.RefreshSwitchBtnRedPoint();
		this.RefreshConfirmBtn();
	}

	// Token: 0x06007AC1 RID: 31425 RVA: 0x0026093C File Offset: 0x0025EB3C
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

	// Token: 0x06007AC2 RID: 31426 RVA: 0x002609C0 File Offset: 0x0025EBC0
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

	// Token: 0x06007AC3 RID: 31427 RVA: 0x00260A40 File Offset: 0x0025EC40
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

	// Token: 0x06007AC4 RID: 31428 RVA: 0x00260A6C File Offset: 0x0025EC6C
	private void RefreshStateText()
	{
		if (this.CurrentViewState.GetValueOrDefault() == 1)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(3), "Motion", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(3), "TextAndExpression", Array.Empty<object>());
	}

	// Token: 0x06007AC5 RID: 31429 RVA: 0x00260AC0 File Offset: 0x0025ECC0
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

	// Token: 0x06007AC6 RID: 31430 RVA: 0x00260C93 File Offset: 0x0025EE93
	private void RefreshCreateLimitText()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(14), AdviceModel.Instance.GetCreateConditionFailText(), Array.Empty<object>());
	}

	// Token: 0x06007AC7 RID: 31431 RVA: 0x00260CB8 File Offset: 0x0025EEB8
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

	// Token: 0x06007AC8 RID: 31432 RVA: 0x00260D04 File Offset: 0x0025EF04
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

	// Token: 0x06007AC9 RID: 31433 RVA: 0x00260DDC File Offset: 0x0025EFDC
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

	// Token: 0x04004C06 RID: 19462
	private const int CHECKTIMEER = 1000;

	// Token: 0x04004C07 RID: 19463
	private const int ANIMATIONGAP = 5000;

	// Token: 0x04004C08 RID: 19464
	private int EntityDisableHandle;

	// Token: 0x04004C09 RID: 19465
	private int? CurrentViewState = new int?(0);

	// Token: 0x04004C0A RID: 19466
	private AdivceSelectItem AdviceSelectItem;

	// Token: 0x04004C0B RID: 19467
	private AdviceSelectMotionItem AdviceSelectMotionItem;

	// Token: 0x04004C0C RID: 19468
	private AdviceAllViewShowContent AdviceAllViewShowContent;

	// Token: 0x04004C0D RID: 19469
	private AdviceCreateActor AdviceCreateActor;

	// Token: 0x04004C0E RID: 19470
	private TimerHandle Timer;

	// Token: 0x04004C0F RID: 19471
	private int CurrentRunningTime;

	// Token: 0x04004C10 RID: 19472
	private object EnterFightTask;

	// Token: 0x04004C11 RID: 19473
	private bool IsPlayerEnterFight;

	// Token: 0x02006E23 RID: 28195
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402412C RID: 147756
		public const int CanNotCreateTips = 0;

		// Token: 0x0402412D RID: 147757
		public const int LeftBtn = 1;

		// Token: 0x0402412E RID: 147758
		public const int RightBtn = 2;

		// Token: 0x0402412F RID: 147759
		public const int BtnText = 3;

		// Token: 0x04024130 RID: 147760
		public const int CreateBtn = 4;

		// Token: 0x04024131 RID: 147761
		public const int SwitchBtn = 5;

		// Token: 0x04024132 RID: 147762
		public const int SelectItem = 6;

		// Token: 0x04024133 RID: 147763
		public const int MotionItem = 7;

		// Token: 0x04024134 RID: 147764
		public const int WordItem = 8;

		// Token: 0x04024135 RID: 147765
		public const int ContentItem = 9;

		// Token: 0x04024136 RID: 147766
		public const int SwitchBtnRedPoint = 10;

		// Token: 0x04024137 RID: 147767
		public const int ConfirmBtnText = 11;

		// Token: 0x04024138 RID: 147768
		public const int SwitchContainer = 12;

		// Token: 0x04024139 RID: 147769
		public const int RoleContainer = 13;

		// Token: 0x0402413A RID: 147770
		public const int CreateLimitText = 14;

		// Token: 0x0402413B RID: 147771
		public const int CreateLimitTipsText = 15;
	}

	// Token: 0x02006E24 RID: 28196
	[NullableContext(0)]
	private static class EViewState
	{
		// Token: 0x0402413C RID: 147772
		public const int Normal = 0;

		// Token: 0x0402413D RID: 147773
		public const int Motion = 1;
	}
}
