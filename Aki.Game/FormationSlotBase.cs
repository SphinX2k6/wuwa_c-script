using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C0F RID: 7183
[NullableContext(2)]
[Nullable(0)]
public abstract class FormationSlotBase : UiPanelBase, IDraggableSlot, IRoleSlotView, ISlotMountPoint
{
	// Token: 0x170011B0 RID: 4528
	// (get) Token: 0x0600D73C RID: 55100
	[Nullable(1)]
	protected abstract string LogTag { [NullableContext(1)] get; }

	// Token: 0x0600D73D RID: 55101 RVA: 0x0031DF2E File Offset: 0x0031C12E
	[NullableContext(1)]
	protected FormationSlotBase(int position, IFormationProvider provider)
	{
		this.Position = position;
		this.Provider = provider;
	}

	// Token: 0x0600D73E RID: 55102 RVA: 0x0031DF4F File Offset: 0x0031C14F
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
	}

	// Token: 0x0600D73F RID: 55103 RVA: 0x0031DF6D File Offset: 0x0031C16D
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
	}

	// Token: 0x0600D740 RID: 55104 RVA: 0x0031DF8B File Offset: 0x0031C18B
	protected override void OnBeforeDestroy()
	{
		SlotExtensionRegistry.DetachAll(this.Extensions);
		this.Extensions = new List<ISlotExtension>();
	}

	// Token: 0x0600D741 RID: 55105 RVA: 0x0031DFA3 File Offset: 0x0031C1A3
	protected void OnClickChooseButton()
	{
		if (this.StartDragTime > 250f)
		{
			return;
		}
		if (FormationViewDragController.DraggingIndex != 0)
		{
			return;
		}
		Action<int> onSelectRole = this.OnSelectRole;
		if (onSelectRole == null)
		{
			return;
		}
		onSelectRole(this.Position);
	}

	// Token: 0x0600D742 RID: 55106 RVA: 0x0031DFD1 File Offset: 0x0031C1D1
	[NullableContext(1)]
	public void BindOnSelectRole(Action<int> onSelectRole)
	{
		this.OnSelectRole = onSelectRole;
	}

	// Token: 0x0600D743 RID: 55107 RVA: 0x0031DFDA File Offset: 0x0031C1DA
	public int? GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600D744 RID: 55108 RVA: 0x0031DFE2 File Offset: 0x0031C1E2
	public int? GetPlayer()
	{
		return this.PlayerInternal;
	}

	// Token: 0x0600D745 RID: 55109 RVA: 0x0031DFEA File Offset: 0x0031C1EA
	public int GetPlayerId()
	{
		return this.PlayerInternal.GetValueOrDefault();
	}

	// Token: 0x0600D746 RID: 55110 RVA: 0x0031DFF7 File Offset: 0x0031C1F7
	public int? GetOnlineIndex()
	{
		return this.OnlineIndex;
	}

	// Token: 0x0600D747 RID: 55111 RVA: 0x0031E000 File Offset: 0x0031C200
	[NullableContext(1)]
	protected void BindDragCallbacks(UUIDraggableComponent draggableComponent)
	{
		draggableComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		draggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		draggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
		draggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
	}

	// Token: 0x0600D748 RID: 55112 RVA: 0x0031E069 File Offset: 0x0031C269
	private void OnPointerUp(ULGUIPointerEventData eventData)
	{
		if (FormationViewDragController.DraggingIndex != this.Position)
		{
			return;
		}
		FormationViewDragController.DraggingIndex = 0;
		this.NeedTick = false;
		this.EndShowDragItem();
		this.StopMove(false);
	}

	// Token: 0x0600D749 RID: 55113 RVA: 0x0031E094 File Offset: 0x0031C294
	private void OnPointerDown(ULGUIPointerEventData eventData)
	{
		this.StartDragTime = 0f;
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null) && this.IsSelfSlot)
			{
				if (this.IsDragDisabled)
				{
					return;
				}
				if (FormationViewDragController.DraggingIndex != 0)
				{
					Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, this.LogTag + "-CanDragStart-false", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				FormationViewDragController.DraggingIndex = this.Position;
				this.NeedTick = true;
				Action<ULGUIPointerEventData, int, int, int> onPointDown = this.OnPointDown;
				if (onPointDown == null)
				{
					return;
				}
				onPointDown(eventData, this.ConfigId.GetValueOrDefault(), this.SkinId.GetValueOrDefault(), this.Position);
				return;
			}
		}
	}

	// Token: 0x0600D74A RID: 55114 RVA: 0x0031E156 File Offset: 0x0031C356
	private void OnPointerDrag(ULGUIPointerEventData eventData)
	{
		if (eventData == null || !this.StartDrag)
		{
			return;
		}
		Action<ULGUIPointerEventData> onDragMove = this.OnDragMove;
		if (onDragMove == null)
		{
			return;
		}
		onDragMove(eventData);
	}

	// Token: 0x0600D74B RID: 55115 RVA: 0x0031E178 File Offset: 0x0031C378
	public void GamePadPress()
	{
		this.StartDragTime = 0f;
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null) && this.IsSelfSlot)
			{
				if (this.IsDragDisabled)
				{
					return;
				}
				this.NeedTick = true;
				Action<UUIItem, int, int, int> onGamePadDown = this.OnGamePadDown;
				if (onGamePadDown == null)
				{
					return;
				}
				onGamePadDown(base.GetRootItem(), this.ConfigId.GetValueOrDefault(), this.SkinId.GetValueOrDefault(), this.Position);
				return;
			}
		}
	}

	// Token: 0x0600D74C RID: 55116 RVA: 0x0031E205 File Offset: 0x0031C405
	public void GamePadRelease()
	{
		if (!this.StartDrag)
		{
			if (this.StartDragTime <= 250f)
			{
				Action<int> onSelectRole = this.OnSelectRole;
				if (onSelectRole != null)
				{
					onSelectRole(this.Position);
				}
			}
			this.GamePadUp(false);
			return;
		}
	}

	// Token: 0x0600D74D RID: 55117 RVA: 0x0031E23C File Offset: 0x0031C43C
	public void GamePadUp(bool isCancel = false)
	{
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null))
			{
				this.NeedTick = false;
				this.EndShowDragItem();
				this.StopMove(isCancel);
				return;
			}
		}
	}

	// Token: 0x0600D74E RID: 55118 RVA: 0x0031E288 File Offset: 0x0031C488
	public void MouseCancelDrag()
	{
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null))
			{
				FormationViewDragController.DraggingIndex = 0;
				this.NeedTick = false;
				this.EndShowDragItem();
				this.StopMove(true);
				return;
			}
		}
	}

	// Token: 0x0600D74F RID: 55119 RVA: 0x0031E2DA File Offset: 0x0031C4DA
	public void OnTick(float delta)
	{
		if (!this.NeedTick)
		{
			return;
		}
		this.StartDragTime += delta;
		if (this.StartDragTime > 750f)
		{
			this.StartMoveDragItem();
			return;
		}
		if (this.StartDragTime > 250f)
		{
			this.StartShowDragItem();
		}
	}

	// Token: 0x0600D750 RID: 55120 RVA: 0x0031E31A File Offset: 0x0031C51A
	private void StartShowDragItem()
	{
		if (!this.HaveCustomShield)
		{
			FormationViewDragController.SetCustomShield(false);
			this.HaveCustomShield = true;
		}
		this.OnDragShowProgress((this.StartDragTime - 250f) / 500f);
	}

	// Token: 0x0600D751 RID: 55121 RVA: 0x0031E349 File Offset: 0x0031C549
	public void EndShowDragItem()
	{
		if (this.HaveCustomShield)
		{
			FormationViewDragController.SetCustomShield(true);
			this.HaveCustomShield = false;
		}
		this.OnDragShowEnd();
	}

	// Token: 0x0600D752 RID: 55122 RVA: 0x0031E368 File Offset: 0x0031C568
	private void StartMoveDragItem()
	{
		if (this.StartDrag)
		{
			return;
		}
		if (this.CanStartDrag != null && !this.CanStartDrag())
		{
			return;
		}
		this.StartDrag = true;
		SlotExtensionRegistry.InvokeStartMove(this.Extensions);
		this.EndShowDragItem();
		Action onDragStart = this.OnDragStart;
		if (onDragStart != null)
		{
			onDragStart();
		}
		this.OnEnterMoveState();
	}

	// Token: 0x0600D753 RID: 55123 RVA: 0x0031E3C4 File Offset: 0x0031C5C4
	private void StopMove(bool isCancel = false)
	{
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null) && this.StartDrag)
			{
				this.StartDrag = false;
				this.OnExitMoveState();
				SlotExtensionRegistry.InvokeStopMove(this.Extensions);
				Action<bool> onDragEnd = this.OnDragEnd;
				if (onDragEnd == null)
				{
					return;
				}
				onDragEnd(isCancel);
				return;
			}
		}
	}

	// Token: 0x0600D754 RID: 55124 RVA: 0x0031E42D File Offset: 0x0031C62D
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey key)
	{
		if (this.StartDrag && bPress && !Info.Instance.IsInGamepad())
		{
			this.MouseCancelDrag();
		}
	}

	// Token: 0x0600D755 RID: 55125
	protected abstract void OnDragShowProgress(float fill);

	// Token: 0x0600D756 RID: 55126
	protected abstract void OnDragShowEnd();

	// Token: 0x0600D757 RID: 55127 RVA: 0x0031E44B File Offset: 0x0031C64B
	protected virtual void OnEnterMoveState()
	{
	}

	// Token: 0x0600D758 RID: 55128 RVA: 0x0031E44D File Offset: 0x0031C64D
	protected virtual void OnExitMoveState()
	{
	}

	// Token: 0x0600D759 RID: 55129 RVA: 0x0031E450 File Offset: 0x0031C650
	[NullableContext(1)]
	protected void RefreshName(string name)
	{
		UUIText nameText = this.GetNameText();
		if (nameText == null)
		{
			return;
		}
		if (name == "")
		{
			nameText.SetUIActive(false);
			return;
		}
		nameText.SetUIActive(true);
		nameText.SetText(name, true);
	}

	// Token: 0x0600D75A RID: 55130 RVA: 0x0031E48C File Offset: 0x0031C68C
	protected void RefreshLevel(int level)
	{
		UUIArtText levelArtText = this.GetLevelArtText();
		if (levelArtText == null)
		{
			return;
		}
		levelArtText.SetText(level.ToString());
	}

	// Token: 0x0600D75B RID: 55131 RVA: 0x0031E4A8 File Offset: 0x0031C6A8
	public void RefreshPing(ENetPingState ping)
	{
		string text = null;
		if (ping != ENetPingState.Unknown)
		{
			if (ping == ENetPingState.Poor)
			{
				text = "SP_SignalPoor";
			}
		}
		else
		{
			text = "SP_SignalUnknown";
		}
		UUISprite pingSprite = this.GetPingSprite();
		if (text == null)
		{
			pingSprite.SetUIActive(false);
			return;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
		this.SetSpriteByPath(resourcePath, pingSprite, false, null, null);
		pingSprite.SetUIActive(true);
	}

	// Token: 0x0600D75C RID: 55132
	protected abstract UUISprite GetPingSprite();

	// Token: 0x0600D75D RID: 55133
	protected abstract UUIText GetNameText();

	// Token: 0x0600D75E RID: 55134
	protected abstract UUIArtText GetLevelArtText();

	// Token: 0x0600D75F RID: 55135
	[NullableContext(1)]
	public abstract void Refresh(IRoleSlotDisplayData data);

	// Token: 0x0600D760 RID: 55136
	public abstract void ResetRole();

	// Token: 0x0600D761 RID: 55137
	public abstract void ShowOtherItemUpState();

	// Token: 0x0600D762 RID: 55138
	public abstract void RefreshLockItemState(bool isDrag);

	// Token: 0x0600D763 RID: 55139 RVA: 0x0031E506 File Offset: 0x0031C706
	public virtual void Reset()
	{
		this.OnSelectRole = null;
		this.ResetRole();
	}

	// Token: 0x0600D764 RID: 55140 RVA: 0x0031E515 File Offset: 0x0031C715
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		return SlotExtensionRegistry.QueryGuideItem(this.Extensions, configParams);
	}

	// Token: 0x0600D765 RID: 55141
	[NullableContext(1)]
	public abstract AActor GetRoleItemOwner();

	// Token: 0x0600D766 RID: 55142 RVA: 0x0031E523 File Offset: 0x0031C723
	[NullableContext(1)]
	public virtual AActor GetPanelRoleItemOwner()
	{
		return this.GetRoleItemOwner();
	}

	// Token: 0x0600D767 RID: 55143
	public abstract AActor GetLikeItemOwner();

	// Token: 0x0600D768 RID: 55144
	public abstract AActor GetTrialRoleItemOwner();

	// Token: 0x0600D769 RID: 55145
	public abstract UUIItem GetChooseButtonRoot();

	// Token: 0x0600D76A RID: 55146
	public abstract AActor GetSkillBranchToggleItemOwner();

	// Token: 0x0600D76B RID: 55147 RVA: 0x0031E52B File Offset: 0x0031C72B
	[NullableContext(1)]
	public IFormationProvider GetProvider()
	{
		return this.Provider;
	}

	// Token: 0x0400625B RID: 25179
	public Action<ULGUIPointerEventData, int, int, int> OnPointDown;

	// Token: 0x0400625C RID: 25180
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIItem, int, int, int> OnGamePadDown;

	// Token: 0x0400625D RID: 25181
	public Func<bool> CanStartDrag;

	// Token: 0x0400625E RID: 25182
	public Action OnDragStart;

	// Token: 0x0400625F RID: 25183
	public Action<ULGUIPointerEventData> OnDragMove;

	// Token: 0x04006260 RID: 25184
	public Action<bool> OnDragEnd;

	// Token: 0x04006261 RID: 25185
	public bool IsDragDisabled;

	// Token: 0x04006262 RID: 25186
	protected Action<int> OnSelectRole;

	// Token: 0x04006263 RID: 25187
	protected int? ConfigId;

	// Token: 0x04006264 RID: 25188
	protected int? SkinId;

	// Token: 0x04006265 RID: 25189
	protected int? PlayerInternal;

	// Token: 0x04006266 RID: 25190
	protected int? OnlineIndex;

	// Token: 0x04006267 RID: 25191
	protected bool IsSelfSlot;

	// Token: 0x04006268 RID: 25192
	protected bool IsThirdPartyVisibleInternal;

	// Token: 0x04006269 RID: 25193
	[Nullable(1)]
	protected List<ISlotExtension> Extensions = new List<ISlotExtension>();

	// Token: 0x0400626A RID: 25194
	private bool NeedTick;

	// Token: 0x0400626B RID: 25195
	protected bool StartDrag;

	// Token: 0x0400626C RID: 25196
	private float StartDragTime;

	// Token: 0x0400626D RID: 25197
	private bool HaveCustomShield;

	// Token: 0x0400626E RID: 25198
	protected readonly int Position;

	// Token: 0x0400626F RID: 25199
	[Nullable(1)]
	protected readonly IFormationProvider Provider;
}
