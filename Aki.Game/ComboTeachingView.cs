using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C9C RID: 3228
[NullableContext(1)]
[Nullable(0)]
public class ComboTeachingView : UiTickViewBase
{
	// Token: 0x060086AE RID: 34478 RVA: 0x00290A54 File Offset: 0x0028EC54
	public ComboTeachingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060086AF RID: 34479 RVA: 0x00290A78 File Offset: 0x0028EC78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x060086B0 RID: 34480 RVA: 0x00290B14 File Offset: 0x0028ED14
	protected override void OnStart()
	{
		ComboTeachingModel.Instance.IsClose = false;
		string startSequenceName = ComboTeachingModel.Instance.InitStart ? "Start" : "Start01";
		this.UiViewSequence.StartSequenceName = startSequenceName;
		this.InitDraggablePanel();
		this.RefreshComboList((int)this.OpenParam);
		this.InitComboInputHandler();
	}

	// Token: 0x060086B1 RID: 34481 RVA: 0x00290B6E File Offset: 0x0028ED6E
	protected override void OnBeforeShow()
	{
		this.OnSelectedUpdate();
	}

	// Token: 0x060086B2 RID: 34482 RVA: 0x00290B76 File Offset: 0x0028ED76
	protected override void OnAddEventListener()
	{
		this.AddTeachingEventListener();
		EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
	}

	// Token: 0x060086B3 RID: 34483 RVA: 0x00290B9A File Offset: 0x0028ED9A
	protected override void OnRemoveEventListener()
	{
		this.RemoveTeachingEventListener();
		EventSystem.Instance.Remove(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
	}

	// Token: 0x060086B4 RID: 34484 RVA: 0x00290BC0 File Offset: 0x0028EDC0
	protected void AddTeachingEventListener()
	{
		EventSystem.Instance.Add<EInputAction, float>(EEventName.ComboTeachingPress, new Action<EInputAction, float>(this.OnPress));
		EventSystem.Instance.Add<EInputAction, float>(EEventName.ComboTeachingRelease, new Action<EInputAction, float>(this.OnRelease));
		EventSystem.Instance.Add<EInputAction, float>(EEventName.ComboTeachingHold, new Action<EInputAction, float>(this.OnHold));
		EventSystem.Instance.Add<ComboTeachingNode, bool>(EEventName.ComboTeachingNodeEnd, new Action<ComboTeachingNode, bool>(this.OnNodeEnd));
		EventSystem.Instance.Add(EEventName.ComboTeachingIndexUpdate, new Action(this.OnSelectedUpdate));
		EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		EventSystem.Instance.Add<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnCharEndSkill));
		EventSystem.Instance.Add<int, int, bool>(EEventName.SkillAcceptChanged, new Action<int, int, bool>(this.OnNextAttrChanged));
		EventSystem.Instance.Add<global::HitInformation, IAttributeSet>(EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnHit));
		this.TeachingEventAdded = true;
	}

	// Token: 0x060086B5 RID: 34485 RVA: 0x00290CCC File Offset: 0x0028EECC
	protected void RemoveTeachingEventListener()
	{
		if (!this.TeachingEventAdded)
		{
			return;
		}
		this.TeachingEventAdded = false;
		EventSystem.Instance.Remove<EInputAction, float>(EEventName.ComboTeachingPress, new Action<EInputAction, float>(this.OnPress));
		EventSystem.Instance.Remove<EInputAction, float>(EEventName.ComboTeachingRelease, new Action<EInputAction, float>(this.OnRelease));
		EventSystem.Instance.Remove<EInputAction, float>(EEventName.ComboTeachingHold, new Action<EInputAction, float>(this.OnHold));
		EventSystem.Instance.Remove<ComboTeachingNode, bool>(EEventName.ComboTeachingNodeEnd, new Action<ComboTeachingNode, bool>(this.OnNodeEnd));
		EventSystem.Instance.Remove(EEventName.ComboTeachingIndexUpdate, new Action(this.OnSelectedUpdate));
		EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		EventSystem.Instance.Remove<int, int, bool>(EEventName.SkillAcceptChanged, new Action<int, int, bool>(this.OnNextAttrChanged));
		EventSystem.Instance.Remove<global::HitInformation, IAttributeSet>(EEventName.BulletHit, new Action<global::HitInformation, IAttributeSet>(this.OnHit));
		EventSystem.Instance.Remove<int, int>(EEventName.OnSkillEnd, new Action<int, int>(this.OnCharEndSkill));
	}

	// Token: 0x060086B6 RID: 34486 RVA: 0x00290DDF File Offset: 0x0028EFDF
	protected override void OnBeforeDestroy()
	{
		this.NoCircleAttachView = null;
		InputController.Instance.RemoveInputHandler(this.InputHandler);
		ComboTeachingModel.Instance.OnComboListEnd();
	}

	// Token: 0x060086B7 RID: 34487 RVA: 0x00290E04 File Offset: 0x0028F004
	private void InitDraggablePanel()
	{
		UUIItem item = base.GetItem(0);
		UUIItem item2 = base.GetItem(5);
		this.NoCircleAttachView = new NoCircleAttachView<IComboTeachingInfo, ComboTeachingNode>(item.GetOwner() as AUIBaseActor, false);
		this.NoCircleAttachView.SetControllerItem(item2);
		this.NoCircleAttachView.CreateItems(base.GetItem(3).GetOwner() as AUIBaseActor, -280f, new Func<AActor, int, int, ComboTeachingNode>(this.CreateNoCircleAttachItem), EAttachDirection.Horizontal);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x060086B8 RID: 34488 RVA: 0x00290E80 File Offset: 0x0028F080
	protected void RefreshComboList(int comboId)
	{
		ComboTeaching value = ComboTeachingConfig.Instance.GetComboTeachingConfig(comboId).Value;
		this.NextGuideId = value.NextRoleGuideID;
		foreach (int guideId in value.GuideIDIter())
		{
			GuideController.Instance.TryStartGuide(guideId);
		}
		int curComboId = this.CurComboId;
		if (comboId != this.CurComboId)
		{
			this.CurComboId = comboId;
			foreach (IComboTeachingInfo comboTeachingInfo in this.NodeList)
			{
				if (comboTeachingInfo.SuccessHandle != null)
				{
					if (TimerSystem.Instance.Has(comboTeachingInfo.SuccessHandle))
					{
						TimerSystem.Instance.Remove(comboTeachingInfo.SuccessHandle);
					}
					comboTeachingInfo.SuccessHandle = null;
				}
				if (comboTeachingInfo.FailHandle != null)
				{
					if (TimerSystem.Instance.Has(comboTeachingInfo.FailHandle))
					{
						TimerSystem.Instance.Remove(comboTeachingInfo.FailHandle);
					}
					comboTeachingInfo.FailHandle = null;
				}
			}
			this.NodeList.Clear();
			for (int i = 0; i < value.CommandIDLength; i++)
			{
				IComboTeachingInfo item = ComboTeachingModel.Instance.CreateComboNodeInfo(i, value);
				this.NodeList.Add(item);
			}
		}
		else
		{
			foreach (IComboTeachingInfo comboTeachingInfo2 in this.NodeList)
			{
				comboTeachingInfo2.IsEmit = false;
				comboTeachingInfo2.NeedTickSummon = true;
				if (comboTeachingInfo2.SuccessHandle != null)
				{
					if (TimerSystem.Instance.Has(comboTeachingInfo2.SuccessHandle))
					{
						TimerSystem.Instance.Remove(comboTeachingInfo2.SuccessHandle);
					}
					comboTeachingInfo2.SuccessHandle = null;
				}
				if (comboTeachingInfo2.FailHandle != null)
				{
					if (TimerSystem.Instance.Has(comboTeachingInfo2.FailHandle))
					{
						TimerSystem.Instance.Remove(comboTeachingInfo2.FailHandle);
					}
					comboTeachingInfo2.FailHandle = null;
				}
			}
		}
		this.NoCircleAttachView.ReloadView(this.NodeList.Count, this.NodeList.ToArray(), 0);
		ComboTeachingModel.Instance.RefreshComboList(comboId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.DescriptionTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.DescriptionContent, Array.Empty<object>());
	}

	// Token: 0x060086B9 RID: 34489 RVA: 0x00291120 File Offset: 0x0028F320
	protected void InitComboInputHandler()
	{
		this.InputHandler = new ComboTeachingInputHandler();
		InputController.Instance.AddInputHandler(this.InputHandler);
	}

	// Token: 0x060086BA RID: 34490 RVA: 0x00291140 File Offset: 0x0028F340
	protected void OnPress(EInputAction action, float time)
	{
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnPress(action, time);
	}

	// Token: 0x060086BB RID: 34491 RVA: 0x00291170 File Offset: 0x0028F370
	protected void OnRelease(EInputAction action, float time)
	{
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnRelease(action, time);
	}

	// Token: 0x060086BC RID: 34492 RVA: 0x002911A0 File Offset: 0x0028F3A0
	protected void OnHold(EInputAction action, float time)
	{
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnHold(action, time);
	}

	// Token: 0x060086BD RID: 34493 RVA: 0x002911D0 File Offset: 0x0028F3D0
	protected void OnNodeEnd(ComboTeachingNode node, bool isSuccess)
	{
		ComboTeachingModel.Instance.IsEmit = true;
		if (!isSuccess)
		{
			base.GetItem(4).SetUIActive(true);
			node.PlayFailAnimation();
			this.RemoveTeachingEventListener();
			TimerSystem.Instance.Delay(delegate(float _)
			{
				ComboTeachingModel.Instance.ResetComboConfig();
				ComboTeachingModel.Instance.IsClose = true;
				EventSystem.Instance.Emit(EEventName.ComboTeachingCloseGuide);
				ComboTeachingModel.Instance.OnComboListEnd();
				this.RefreshComboList(ComboTeachingModel.Instance.RecoveryComboId);
				this.AddTeachingEventListener();
				this.OnSelectedUpdate();
				base.GetItem(4).SetUIActive(false);
			}, 1000f, null, null, true, 1f);
			return;
		}
		ComboTeachingModel.Instance.CurrentNodeIndex = ComboTeachingModel.Instance.CurrentNodeIndex + 1;
		if (this.NodeList.Count > ComboTeachingModel.Instance.CurrentNodeIndex)
		{
			this.NoCircleAttachView.AttachToIndex(ComboTeachingModel.Instance.CurrentNodeIndex, false);
			return;
		}
		if (this.NextGuideId > 0)
		{
			this.UiViewSequence.CloseSequenceName = "Close01";
			if (ComboTeachingConfig.Instance.GetComboTeachingConfig(this.NextGuideId).Value.KeyIDLength == 0)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					this.OpenNextGuideView();
				}, 200f, null, null, true, 1f);
				return;
			}
			this.OpenNextGuideView();
			return;
		}
		else
		{
			if (this.IsSuccess)
			{
				return;
			}
			this.IsSuccess = true;
			ComboTeachingModel.Instance.ResetComboConfig();
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.NoCircleAttachView.Clear();
				GenericPrompt value = GenericPromptConfig.Instance.GetPromptInfoByRawId("12900001").Value;
				TableTextArgNew promptMainTextObjByRawId = GenericPromptConfig.Instance.GetPromptMainTextObjByRawId("12900001");
				GenericPromptController.Instance.ShowPromptByItsType<object>((EPromptSubViewType)value.TypeId, promptMainTextObjByRawId, null, null, null, new int?(int.Parse("12900001")), delegate()
				{
					EventSystem.Instance.Emit(EEventName.ComboTeachingFinish);
					if (UiManager.Instance.IsViewOpen(EUiViewName.ComboTeachingView) || UiManager.Instance.IsViewHide(EUiViewName.ComboTeachingView))
					{
						base.CloseMe(null);
					}
					ComboTeachingModel.Instance.IsClose = true;
					EventSystem.Instance.Emit(EEventName.ComboTeachingCloseGuide);
				}, null, null, false, null);
			}, 1000f, null, null, true, 1f);
			return;
		}
	}

	// Token: 0x060086BE RID: 34494 RVA: 0x00291318 File Offset: 0x0028F518
	protected void OnSelectedUpdate()
	{
		if (this.NoCircleAttachView == null)
		{
			return;
		}
		foreach (ComboTeachingNode comboTeachingNode in this.NoCircleAttachView.GetItems())
		{
			comboTeachingNode.Refresh();
		}
		int currentNodeIndex = ComboTeachingModel.Instance.CurrentNodeIndex;
		if (currentNodeIndex >= this.NodeList.Count)
		{
			return;
		}
		ComboTeachingModel.Instance.OnCurIndexChanged(this.NodeList[currentNodeIndex]);
	}

	// Token: 0x060086BF RID: 34495 RVA: 0x002913A8 File Offset: 0x0028F5A8
	protected void OnCharUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		if (this.IsSuccess)
		{
			return;
		}
		Entity entity = EntitySystem.Instance.Get(charId);
		if (entity != null)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null || component.GetEntityType() > EEntityType.Player)
			{
				return;
			}
		}
		ComboTeachingModel.Instance.IsEmit = false;
		ComboTeachingModel.Instance.UseSkillId = (long)skillId;
		ComboTeachingModel.Instance.PreNextAttr = false;
		ComboTeachingModel.Instance.NextAttr = false;
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnUseSkill(skillId);
	}

	// Token: 0x060086C0 RID: 34496 RVA: 0x00291434 File Offset: 0x0028F634
	protected void OnCharEndSkill(int charId, int skillId)
	{
		Entity entity = EntitySystem.Instance.Get(charId);
		if (entity != null)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null || component.GetEntityType() > EEntityType.Player)
			{
				return;
			}
		}
		ComboTeachingModel.Instance.UseSkillId = 0L;
		ComboTeachingModel.Instance.UseSkillTime = 0f;
	}

	// Token: 0x060086C1 RID: 34497 RVA: 0x00291484 File Offset: 0x0028F684
	protected void OnNextAttrChanged(int entityId, int skillId, bool nextAttr)
	{
		if (this.IsSuccess)
		{
			return;
		}
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null || component.GetEntityType() > EEntityType.Player)
			{
				return;
			}
		}
		ComboTeachingModel.Instance.NextAttr = nextAttr;
		ComboTeachingModel.Instance.NextAttrSkillId = (long)skillId;
	}

	// Token: 0x060086C2 RID: 34498 RVA: 0x002914D8 File Offset: 0x0028F6D8
	protected override void OnTick(float delta)
	{
		if (ComboTeachingModel.Instance.UseSkillId != 0L)
		{
			ComboTeachingModel.Instance.UseSkillTime += delta;
		}
		ComboTeachingModel.Instance.BeforeJumpTime -= delta;
		if (ComboTeachingModel.Instance.BeforeJumpTime < 0f)
		{
			ComboTeachingModel.Instance.BeforeJumpTime = 0f;
		}
		if (Global.BaseCharacter != null)
		{
			int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
			Entity entity = EntitySystem.Instance.Get(entityIdNoBlueprint);
			if (((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null).IsJump && ComboTeachingModel.Instance.BeforeJumpTime == 0f)
			{
				ComboTeachingModel.Instance.BeforeJumpTime = 100f;
			}
		}
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnTick(delta);
	}

	// Token: 0x060086C3 RID: 34499 RVA: 0x002915A8 File Offset: 0x0028F7A8
	public void OnHit(global::HitInformation hitData, [Nullable(2)] IAttributeSet attackerAttribute)
	{
		if (this.IsSuccess)
		{
			return;
		}
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnBulletHit(hitData);
	}

	// Token: 0x060086C4 RID: 34500 RVA: 0x002915DF File Offset: 0x0028F7DF
	public void OnOpenLoading()
	{
		base.CloseMe(null);
	}

	// Token: 0x060086C5 RID: 34501 RVA: 0x002915E8 File Offset: 0x0028F7E8
	private ComboTeachingNode CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		return new ComboTeachingNode(actor);
	}

	// Token: 0x060086C6 RID: 34502 RVA: 0x002915F0 File Offset: 0x0028F7F0
	private void OpenNextGuideView()
	{
		ComboTeachingModel.Instance.IsClose = true;
		EventSystem.Instance.Emit(EEventName.ComboTeachingCloseGuide);
		if (UiManager.Instance.IsViewOpen(EUiViewName.ComboTeachingView) || UiManager.Instance.IsViewHide(EUiViewName.ComboTeachingView))
		{
			base.CloseMe(delegate(bool success)
			{
				if (success)
				{
					UiManager.Instance.OpenView(EUiViewName.ComboTeachingView, this.NextGuideId, null);
				}
			});
		}
	}

	// Token: 0x040051B2 RID: 20914
	private const int DRAGITEM_INTERVAL = -280;

	// Token: 0x040051B3 RID: 20915
	private const string SHOW_TIP_ID = "12900001";

	// Token: 0x040051B4 RID: 20916
	private const int BEFORE_JUMP_TIME = 100;

	// Token: 0x040051B5 RID: 20917
	[Nullable(2)]
	private ComboTeachingInputHandler InputHandler;

	// Token: 0x040051B6 RID: 20918
	private int NextGuideId = -1;

	// Token: 0x040051B7 RID: 20919
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<IComboTeachingInfo, ComboTeachingNode> NoCircleAttachView;

	// Token: 0x040051B8 RID: 20920
	private bool IsSuccess;

	// Token: 0x040051B9 RID: 20921
	public List<IComboTeachingInfo> NodeList = new List<IComboTeachingInfo>();

	// Token: 0x040051BA RID: 20922
	private bool TeachingEventAdded;

	// Token: 0x040051BB RID: 20923
	private int CurComboId = -1;

	// Token: 0x02006F55 RID: 28501
	[NullableContext(0)]
	private enum EComboTeachingViewDefine
	{
		// Token: 0x0402461F RID: 149023
		DragPanel,
		// Token: 0x04024620 RID: 149024
		TextMain,
		// Token: 0x04024621 RID: 149025
		TextSub,
		// Token: 0x04024622 RID: 149026
		NodeItem,
		// Token: 0x04024623 RID: 149027
		MaskItem,
		// Token: 0x04024624 RID: 149028
		DragContent
	}
}
