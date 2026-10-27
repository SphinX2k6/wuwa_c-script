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

// Token: 0x020017E3 RID: 6115
[NullableContext(1)]
[Nullable(0)]
public class ComboTeachingView : UiTickViewBase
{
	// Token: 0x0600B2C4 RID: 45764 RVA: 0x00286387 File Offset: 0x00284587
	public ComboTeachingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B2C5 RID: 45765 RVA: 0x002863AC File Offset: 0x002845AC
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

	// Token: 0x0600B2C6 RID: 45766 RVA: 0x00286448 File Offset: 0x00284648
	protected override void OnStart()
	{
		ComboTeachingModel.Instance.IsClose = false;
		string startSequenceName = ComboTeachingModel.Instance.InitStart ? "Start" : "Start01";
		this.UiViewSequence.StartSequenceName = startSequenceName;
		this.InitDraggablePanel();
		this.RefreshComboList((int)this.OpenParam);
		this.InitComboInputHandler();
	}

	// Token: 0x0600B2C7 RID: 45767 RVA: 0x002864A2 File Offset: 0x002846A2
	protected override void OnBeforeShow()
	{
		this.OnSelectedUpdate();
	}

	// Token: 0x0600B2C8 RID: 45768 RVA: 0x002864AA File Offset: 0x002846AA
	protected override void OnAddEventListener()
	{
		this.AddTeachingEventListener();
		EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
	}

	// Token: 0x0600B2C9 RID: 45769 RVA: 0x002864CE File Offset: 0x002846CE
	protected override void OnRemoveEventListener()
	{
		this.RemoveTeachingEventListener();
		EventSystem.Instance.Remove(EEventName.OnStartLoadingState, new Action(this.OnOpenLoading));
	}

	// Token: 0x0600B2CA RID: 45770 RVA: 0x002864F4 File Offset: 0x002846F4
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

	// Token: 0x0600B2CB RID: 45771 RVA: 0x00286600 File Offset: 0x00284800
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

	// Token: 0x0600B2CC RID: 45772 RVA: 0x00286713 File Offset: 0x00284913
	protected override void OnBeforeDestroy()
	{
		this.NoCircleAttachView = null;
		InputController.Instance.RemoveInputHandler(this.InputHandler);
		ComboTeachingModel.Instance.OnComboListEnd();
	}

	// Token: 0x0600B2CD RID: 45773 RVA: 0x00286738 File Offset: 0x00284938
	private void InitDraggablePanel()
	{
		UUIItem item = base.GetItem(0);
		UUIItem item2 = base.GetItem(5);
		this.NoCircleAttachView = new NoCircleAttachView<IComboTeachingInfo, ComboTeachingNode>(item.GetOwner() as AUIBaseActor, false);
		this.NoCircleAttachView.SetControllerItem(item2);
		this.NoCircleAttachView.CreateItems(base.GetItem(3).GetOwner() as AUIBaseActor, -280f, new Func<AActor, int, int, ComboTeachingNode>(this.CreateNoCircleAttachItem), EAttachDirection.Horizontal);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x0600B2CE RID: 45774 RVA: 0x002867B4 File Offset: 0x002849B4
	protected void RefreshComboList(int comboId)
	{
		ComboTeaching value = ComboTeachingConfig.Instance.GetComboTeachingConfig(comboId).Value;
		this.NextGuideId = value.NextRoleGuideID;
		foreach (int guideId in value.GuideIDIter())
		{
			GuideController.Instance.TryStartGuide(guideId);
		}
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

	// Token: 0x0600B2CF RID: 45775 RVA: 0x00286A4C File Offset: 0x00284C4C
	protected void InitComboInputHandler()
	{
		this.InputHandler = new ComboTeachingInputHandler();
		InputController.Instance.AddInputHandler(this.InputHandler);
	}

	// Token: 0x0600B2D0 RID: 45776 RVA: 0x00286A6C File Offset: 0x00284C6C
	protected void OnPress(EInputAction action, float time)
	{
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnPress(action, time);
	}

	// Token: 0x0600B2D1 RID: 45777 RVA: 0x00286A9C File Offset: 0x00284C9C
	protected void OnRelease(EInputAction action, float time)
	{
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnRelease(action, time);
	}

	// Token: 0x0600B2D2 RID: 45778 RVA: 0x00286ACC File Offset: 0x00284CCC
	protected void OnHold(EInputAction action, float time)
	{
		ComboTeachingNode itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(ComboTeachingModel.Instance.CurrentNodeIndex);
		if (itemByShowIndex == null)
		{
			return;
		}
		itemByShowIndex.OnHold(action, time);
	}

	// Token: 0x0600B2D3 RID: 45779 RVA: 0x00286AFC File Offset: 0x00284CFC
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

	// Token: 0x0600B2D4 RID: 45780 RVA: 0x00286C44 File Offset: 0x00284E44
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

	// Token: 0x0600B2D5 RID: 45781 RVA: 0x00286CD4 File Offset: 0x00284ED4
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

	// Token: 0x0600B2D6 RID: 45782 RVA: 0x00286D60 File Offset: 0x00284F60
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

	// Token: 0x0600B2D7 RID: 45783 RVA: 0x00286DB0 File Offset: 0x00284FB0
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

	// Token: 0x0600B2D8 RID: 45784 RVA: 0x00286E04 File Offset: 0x00285004
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

	// Token: 0x0600B2D9 RID: 45785 RVA: 0x00286ED4 File Offset: 0x002850D4
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

	// Token: 0x0600B2DA RID: 45786 RVA: 0x00286F0B File Offset: 0x0028510B
	public void OnOpenLoading()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600B2DB RID: 45787 RVA: 0x00286F14 File Offset: 0x00285114
	private ComboTeachingNode CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		return new ComboTeachingNode(actor);
	}

	// Token: 0x0600B2DC RID: 45788 RVA: 0x00286F1C File Offset: 0x0028511C
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

	// Token: 0x04005107 RID: 20743
	private const int DRAGITEM_INTERVAL = -280;

	// Token: 0x04005108 RID: 20744
	private const string SHOW_TIP_ID = "12900001";

	// Token: 0x04005109 RID: 20745
	private const int BEFORE_JUMP_TIME = 100;

	// Token: 0x0400510A RID: 20746
	[Nullable(2)]
	private ComboTeachingInputHandler InputHandler;

	// Token: 0x0400510B RID: 20747
	private int NextGuideId = -1;

	// Token: 0x0400510C RID: 20748
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<IComboTeachingInfo, ComboTeachingNode> NoCircleAttachView;

	// Token: 0x0400510D RID: 20749
	private bool IsSuccess;

	// Token: 0x0400510E RID: 20750
	public List<IComboTeachingInfo> NodeList = new List<IComboTeachingInfo>();

	// Token: 0x0400510F RID: 20751
	private bool TeachingEventAdded;

	// Token: 0x04005110 RID: 20752
	private int CurComboId = -1;

	// Token: 0x02007DCF RID: 32207
	[NullableContext(0)]
	private enum EComboTeachingViewDefine
	{
		// Token: 0x040292F4 RID: 168692
		DragPanel,
		// Token: 0x040292F5 RID: 168693
		TextMain,
		// Token: 0x040292F6 RID: 168694
		TextSub,
		// Token: 0x040292F7 RID: 168695
		NodeItem,
		// Token: 0x040292F8 RID: 168696
		MaskItem,
		// Token: 0x040292F9 RID: 168697
		DragContent
	}
}
