using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010CE RID: 4302
[NullableContext(2)]
[Nullable(0)]
public abstract class FormationSlotBase : UiPanelBase, IDraggableSlot, IRoleSlotView, ISlotMountPoint
{
	// Token: 0x170011D6 RID: 4566
	// (get) Token: 0x0600AB50 RID: 43856
	[Nullable(1)]
	protected abstract string LogTag { [NullableContext(1)] get; }

	// Token: 0x0600AB51 RID: 43857 RVA: 0x0032927E File Offset: 0x0032747E
	[NullableContext(1)]
	protected FormationSlotBase(int position, IFormationProvider provider)
	{
		this.Position = position;
		this.Provider = provider;
	}

	// Token: 0x0600AB52 RID: 43858 RVA: 0x0032929F File Offset: 0x0032749F
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
	}

	// Token: 0x0600AB53 RID: 43859 RVA: 0x003292BD File Offset: 0x003274BD
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
	}

	// Token: 0x0600AB54 RID: 43860 RVA: 0x003292DB File Offset: 0x003274DB
	protected override void OnBeforeDestroy()
	{
		SlotExtensionRegistry.DetachAll(this.Extensions);
		this.Extensions = new List<ISlotExtension>();
	}

	// Token: 0x0600AB55 RID: 43861 RVA: 0x003292F3 File Offset: 0x003274F3
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

	// Token: 0x0600AB56 RID: 43862 RVA: 0x00329321 File Offset: 0x00327521
	[NullableContext(1)]
	public void BindOnSelectRole(Action<int> onSelectRole)
	{
		this.OnSelectRole = onSelectRole;
	}

	// Token: 0x0600AB57 RID: 43863 RVA: 0x0032932A File Offset: 0x0032752A
	public int? GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600AB58 RID: 43864 RVA: 0x00329332 File Offset: 0x00327532
	public int? GetPlayer()
	{
		return this.PlayerInternal;
	}

	// Token: 0x0600AB59 RID: 43865 RVA: 0x0032933A File Offset: 0x0032753A
	public int GetPlayerId()
	{
		return this.PlayerInternal.GetValueOrDefault();
	}

	// Token: 0x0600AB5A RID: 43866 RVA: 0x00329347 File Offset: 0x00327547
	public int? GetOnlineIndex()
	{
		return this.OnlineIndex;
	}

	// Token: 0x0600AB5B RID: 43867 RVA: 0x00329350 File Offset: 0x00327550
	[NullableContext(1)]
	protected void BindDragCallbacks(UUIDraggableComponent draggableComponent)
	{
		draggableComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		draggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
		draggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
		draggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
	}

	// Token: 0x0600AB5C RID: 43868 RVA: 0x003293B9 File Offset: 0x003275B9
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

	// Token: 0x0600AB5D RID: 43869 RVA: 0x003293E4 File Offset: 0x003275E4
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

	// Token: 0x0600AB5E RID: 43870 RVA: 0x003294A6 File Offset: 0x003276A6
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

	// Token: 0x0600AB5F RID: 43871 RVA: 0x003294C8 File Offset: 0x003276C8
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

	// Token: 0x0600AB60 RID: 43872 RVA: 0x00329555 File Offset: 0x00327755
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

	// Token: 0x0600AB61 RID: 43873 RVA: 0x0032958C File Offset: 0x0032778C
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

	// Token: 0x0600AB62 RID: 43874 RVA: 0x003295D8 File Offset: 0x003277D8
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

	// Token: 0x0600AB63 RID: 43875 RVA: 0x0032962A File Offset: 0x0032782A
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

	// Token: 0x0600AB64 RID: 43876 RVA: 0x0032966A File Offset: 0x0032786A
	private void StartShowDragItem()
	{
		if (!this.HaveCustomShield)
		{
			FormationViewDragController.SetCustomShield(false);
			this.HaveCustomShield = true;
		}
		this.OnDragShowProgress((this.StartDragTime - 250f) / 500f);
	}

	// Token: 0x0600AB65 RID: 43877 RVA: 0x00329699 File Offset: 0x00327899
	public void EndShowDragItem()
	{
		if (this.HaveCustomShield)
		{
			FormationViewDragController.SetCustomShield(true);
			this.HaveCustomShield = false;
		}
		this.OnDragShowEnd();
	}

	// Token: 0x0600AB66 RID: 43878 RVA: 0x003296B8 File Offset: 0x003278B8
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

	// Token: 0x0600AB67 RID: 43879 RVA: 0x00329714 File Offset: 0x00327914
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

	// Token: 0x0600AB68 RID: 43880 RVA: 0x0032977D File Offset: 0x0032797D
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey key)
	{
		if (this.StartDrag && bPress && !Info.Instance.IsInGamepad())
		{
			this.MouseCancelDrag();
		}
	}

	// Token: 0x0600AB69 RID: 43881
	protected abstract void OnDragShowProgress(float fill);

	// Token: 0x0600AB6A RID: 43882
	protected abstract void OnDragShowEnd();

	// Token: 0x0600AB6B RID: 43883 RVA: 0x0032979B File Offset: 0x0032799B
	protected virtual void OnEnterMoveState()
	{
	}

	// Token: 0x0600AB6C RID: 43884 RVA: 0x0032979D File Offset: 0x0032799D
	protected virtual void OnExitMoveState()
	{
	}

	// Token: 0x0600AB6D RID: 43885 RVA: 0x003297A0 File Offset: 0x003279A0
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

	// Token: 0x0600AB6E RID: 43886 RVA: 0x003297DC File Offset: 0x003279DC
	protected void RefreshLevel(int level)
	{
		UUIArtText levelArtText = this.GetLevelArtText();
		if (levelArtText == null)
		{
			return;
		}
		levelArtText.SetText(level.ToString());
	}

	// Token: 0x0600AB6F RID: 43887 RVA: 0x003297F8 File Offset: 0x003279F8
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

	// Token: 0x0600AB70 RID: 43888
	protected abstract UUISprite GetPingSprite();

	// Token: 0x0600AB71 RID: 43889
	protected abstract UUIText GetNameText();

	// Token: 0x0600AB72 RID: 43890
	protected abstract UUIArtText GetLevelArtText();

	// Token: 0x0600AB73 RID: 43891
	[NullableContext(1)]
	public abstract void Refresh(IRoleSlotDisplayData data);

	// Token: 0x0600AB74 RID: 43892
	public abstract void ResetRole();

	// Token: 0x0600AB75 RID: 43893
	public abstract void ShowOtherItemUpState();

	// Token: 0x0600AB76 RID: 43894
	public abstract void RefreshLockItemState(bool isDrag);

	// Token: 0x0600AB77 RID: 43895 RVA: 0x00329856 File Offset: 0x00327A56
	public virtual void Reset()
	{
		this.OnSelectRole = null;
		this.ResetRole();
	}

	// Token: 0x0600AB78 RID: 43896 RVA: 0x00329865 File Offset: 0x00327A65
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

	// Token: 0x0600AB79 RID: 43897
	[NullableContext(1)]
	public abstract AActor GetRoleItemOwner();

	// Token: 0x0600AB7A RID: 43898 RVA: 0x00329873 File Offset: 0x00327A73
	[NullableContext(1)]
	public virtual AActor GetPanelRoleItemOwner()
	{
		return this.GetRoleItemOwner();
	}

	// Token: 0x0600AB7B RID: 43899
	public abstract AActor GetLikeItemOwner();

	// Token: 0x0600AB7C RID: 43900
	public abstract AActor GetTrialRoleItemOwner();

	// Token: 0x0600AB7D RID: 43901
	public abstract UUIItem GetChooseButtonRoot();

	// Token: 0x0600AB7E RID: 43902
	public abstract AActor GetSkillBranchToggleItemOwner();

	// Token: 0x0600AB7F RID: 43903 RVA: 0x0032987B File Offset: 0x00327A7B
	[NullableContext(1)]
	public IFormationProvider GetProvider()
	{
		return this.Provider;
	}

	// Token: 0x0400632D RID: 25389
	public Action<ULGUIPointerEventData, int, int, int> OnPointDown;

	// Token: 0x0400632E RID: 25390
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIItem, int, int, int> OnGamePadDown;

	// Token: 0x0400632F RID: 25391
	public Func<bool> CanStartDrag;

	// Token: 0x04006330 RID: 25392
	public Action OnDragStart;

	// Token: 0x04006331 RID: 25393
	public Action<ULGUIPointerEventData> OnDragMove;

	// Token: 0x04006332 RID: 25394
	public Action<bool> OnDragEnd;

	// Token: 0x04006333 RID: 25395
	public bool IsDragDisabled;

	// Token: 0x04006334 RID: 25396
	protected Action<int> OnSelectRole;

	// Token: 0x04006335 RID: 25397
	protected int? ConfigId;

	// Token: 0x04006336 RID: 25398
	protected int? SkinId;

	// Token: 0x04006337 RID: 25399
	protected int? PlayerInternal;

	// Token: 0x04006338 RID: 25400
	protected int? OnlineIndex;

	// Token: 0x04006339 RID: 25401
	protected bool IsSelfSlot;

	// Token: 0x0400633A RID: 25402
	protected bool IsThirdPartyVisibleInternal;

	// Token: 0x0400633B RID: 25403
	[Nullable(1)]
	protected List<ISlotExtension> Extensions = new List<ISlotExtension>();

	// Token: 0x0400633C RID: 25404
	private bool NeedTick;

	// Token: 0x0400633D RID: 25405
	protected bool StartDrag;

	// Token: 0x0400633E RID: 25406
	private float StartDragTime;

	// Token: 0x0400633F RID: 25407
	private bool HaveCustomShield;

	// Token: 0x04006340 RID: 25408
	protected readonly int Position;

	// Token: 0x04006341 RID: 25409
	[Nullable(1)]
	protected readonly IFormationProvider Provider;
}
