using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

// Token: 0x02001F4A RID: 8010
public class LockCursorUnit : HudUnitBase
{
	// Token: 0x0600F7A2 RID: 63394 RVA: 0x003BE614 File Offset: 0x003BC814
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F7A3 RID: 63395 RVA: 0x003BE704 File Offset: 0x003BC904
	protected override void OnStart()
	{
		this.RootItem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		base.GetItem(1).SetUIActive(true);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		this.SetBarPercent(1f);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600F7A4 RID: 63396 RVA: 0x003BE764 File Offset: 0x003BC964
	public override void Tick(float delta)
	{
		if (this.UnlockTimeDown < 0f)
		{
			return;
		}
		if (this.CurrentTime > this.UnlockTimeDown)
		{
			this.SetBarPercent(1f);
			return;
		}
		float barPercent = this.CurrentTime / this.UnlockTimeDown;
		this.SetBarPercent(barPercent);
		this.CurrentTime += delta;
	}

	// Token: 0x0600F7A5 RID: 63397 RVA: 0x003BE7BC File Offset: 0x003BC9BC
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600F7A6 RID: 63398 RVA: 0x003BE7D0 File Offset: 0x003BC9D0
	public void Activate()
	{
		base.SetVisible(true, 0);
	}

	// Token: 0x0600F7A7 RID: 63399 RVA: 0x003BE7DA File Offset: 0x003BC9DA
	public void Deactivate()
	{
		this.SetLockState(LockCursorUnit.ELockState.None);
		base.SetVisible(false, 0);
	}

	// Token: 0x0600F7A8 RID: 63400 RVA: 0x003BE7EC File Offset: 0x003BC9EC
	public override void SetActive(bool visibility)
	{
		if (!visibility)
		{
			this.DeactivateUnlockTimeDown();
		}
		this.SetBarSpriteVisible(!this.HasHiddenTag);
		base.GetItem(1).SetUIActive(!this.HasHiddenTag);
		base.GetSprite(4).SetUIActive(!this.HasHiddenTag);
		base.SetActive(visibility);
	}

	// Token: 0x0600F7A9 RID: 63401 RVA: 0x003BE842 File Offset: 0x003BCA42
	public bool IsForceLockState()
	{
		return this.LockState == LockCursorUnit.ELockState.ForceLock;
	}

	// Token: 0x0600F7AA RID: 63402 RVA: 0x003BE84D File Offset: 0x003BCA4D
	public void ActivateUnlockTimeDown(float time)
	{
		this.UnlockTimeDown = time;
		this.CurrentTime = 0f;
	}

	// Token: 0x0600F7AB RID: 63403 RVA: 0x003BE861 File Offset: 0x003BCA61
	public void DeactivateUnlockTimeDown()
	{
		this.UnlockTimeDown = -1f;
		this.CurrentTime = 0f;
		this.SetBarPercent(1f);
	}

	// Token: 0x0600F7AC RID: 63404 RVA: 0x003BE884 File Offset: 0x003BCA84
	[NullableContext(2)]
	public void Refresh(EntityHandle lockTarget, EntityHandle selfEntity, bool isPlayerLock)
	{
		int? num;
		if (lockTarget == null)
		{
			num = null;
		}
		else
		{
			WorldEntity entity = lockTarget.Entity;
			num = ((entity != null) ? new int?(entity.Id) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		this.LockEntityId = valueOrDefault;
		BaseTagComponent baseTagComponent;
		if (lockTarget == null)
		{
			baseTagComponent = null;
		}
		else
		{
			WorldEntity entity2 = lockTarget.Entity;
			baseTagComponent = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		this.HasHiddenTag = (baseTagComponent2 != null && (baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.隐藏锁定UI"]) || baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏界面功能.隐藏锁定UI"])));
		base.SetVisible(!this.HasHiddenTag, 2);
		LockCursorUnit.ELockState lockState = this.RefreshLockState(selfEntity, isPlayerLock);
		this.RefreshLockAudio(lockState);
		this.SetLockState(lockState);
	}

	// Token: 0x0600F7AD RID: 63405 RVA: 0x003BE94C File Offset: 0x003BCB4C
	[NullableContext(2)]
	private LockCursorUnit.ELockState RefreshLockState(EntityHandle selfEntity, bool isPlayerLock)
	{
		if (this.HasHiddenTag)
		{
			return LockCursorUnit.ELockState.None;
		}
		if (!isPlayerLock)
		{
			return LockCursorUnit.ELockState.NormalLock;
		}
		if (selfEntity == null || !selfEntity.Valid)
		{
			return LockCursorUnit.ELockState.None;
		}
		BaseTagComponent component = selfEntity.Entity.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.注视方向"]))
		{
			return LockCursorUnit.ELockState.ForceLock;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.看向方向"]))
		{
			return LockCursorUnit.ELockState.LookAt;
		}
		return LockCursorUnit.ELockState.NormalLock;
	}

	// Token: 0x0600F7AE RID: 63406 RVA: 0x003BE9BC File Offset: 0x003BCBBC
	private void RefreshLockAudio(LockCursorUnit.ELockState lockState)
	{
		if (lockState != LockCursorUnit.ELockState.ForceLock)
		{
			return;
		}
		if (lockState != this.LockState)
		{
			this.PlayForceLockAudio();
			this.LockAudioEntityId = this.LockEntityId;
			return;
		}
		if (this.LockAudioEntityId != this.LockEntityId)
		{
			this.LockAudioEntityId = this.LockEntityId;
			this.PlaySwitchForceLockAudio();
		}
	}

	// Token: 0x0600F7AF RID: 63407 RVA: 0x003BEA0C File Offset: 0x003BCC0C
	private void SetLockState(LockCursorUnit.ELockState lockState)
	{
		if (lockState != this.LockState)
		{
			if (this.LockState == LockCursorUnit.ELockState.None)
			{
				this.PlayStartSequence();
			}
			else if (this.LockState == LockCursorUnit.ELockState.LookAt)
			{
				this.PlayLookAtUnlockSequence();
			}
			if (lockState == LockCursorUnit.ELockState.LookAt)
			{
				this.PlayLookAtLockSequence();
			}
			this.LockState = lockState;
			UUIItem item = base.GetItem(2);
			UUIItem item2 = base.GetItem(5);
			if (lockState == LockCursorUnit.ELockState.ForceLock)
			{
				item.SetUIActive(true);
				item2.SetUIActive(false);
				return;
			}
			if (lockState == LockCursorUnit.ELockState.LookAt)
			{
				item.SetUIActive(false);
				item2.SetUIActive(true);
				return;
			}
			item.SetUIActive(false);
			item2.SetUIActive(false);
		}
	}

	// Token: 0x0600F7B0 RID: 63408 RVA: 0x003BEA98 File Offset: 0x003BCC98
	private void SetBarSpriteVisible(bool bVisible)
	{
		UUISprite sprite = base.GetSprite(3);
		if (sprite.IsUIActiveSelf() == bVisible)
		{
			return;
		}
		sprite.SetUIActive(bVisible);
	}

	// Token: 0x0600F7B1 RID: 63409 RVA: 0x003BEABE File Offset: 0x003BCCBE
	public void SetBarPercent(float percent)
	{
		base.GetSprite(3).SetFillAmount(percent);
	}

	// Token: 0x0600F7B2 RID: 63410 RVA: 0x003BEAD0 File Offset: 0x003BCCD0
	private void PlayStartSequence()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600F7B3 RID: 63411 RVA: 0x003BEAFC File Offset: 0x003BCCFC
	private void PlayLookAtLockSequence()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Lock", false, false, null, null, false);
	}

	// Token: 0x0600F7B4 RID: 63412 RVA: 0x003BEB28 File Offset: 0x003BCD28
	private void PlayLookAtUnlockSequence()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Unlock", false, false, null, null, false);
	}

	// Token: 0x0600F7B5 RID: 63413 RVA: 0x003BEB52 File Offset: 0x003BCD52
	private void PlayForceLockAudio()
	{
		BattleUiAudioData audioData = BattleUiModel.Instance.AudioData;
		if (audioData == null)
		{
			return;
		}
		audioData.PlayAudio(EBattleUiAudioType.ForceLock, EBattleUiChild.BattleHud);
	}

	// Token: 0x0600F7B6 RID: 63414 RVA: 0x003BEB6B File Offset: 0x003BCD6B
	private void PlaySwitchForceLockAudio()
	{
		BattleUiAudioData audioData = BattleUiModel.Instance.AudioData;
		if (audioData == null)
		{
			return;
		}
		audioData.PlayAudio(EBattleUiAudioType.SwitchForceLock, EBattleUiChild.BattleHud);
	}

	// Token: 0x040072D7 RID: 29399
	private float UnlockTimeDown = -1f;

	// Token: 0x040072D8 RID: 29400
	private float CurrentTime;

	// Token: 0x040072D9 RID: 29401
	private LockCursorUnit.ELockState LockState;

	// Token: 0x040072DA RID: 29402
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040072DB RID: 29403
	private bool HasHiddenTag;

	// Token: 0x040072DC RID: 29404
	private int LockEntityId;

	// Token: 0x040072DD RID: 29405
	private int LockAudioEntityId;

	// Token: 0x0200853D RID: 34109
	private enum EChildType
	{
		// Token: 0x0402B60B RID: 177675
		Item1,
		// Token: 0x0402B60C RID: 177676
		Item2,
		// Token: 0x0402B60D RID: 177677
		Item3,
		// Token: 0x0402B60E RID: 177678
		BarSprite,
		// Token: 0x0402B60F RID: 177679
		AnimSprite,
		// Token: 0x0402B610 RID: 177680
		Item4
	}

	// Token: 0x0200853E RID: 34110
	private enum ELockState
	{
		// Token: 0x0402B612 RID: 177682
		None,
		// Token: 0x0402B613 RID: 177683
		ForceLock,
		// Token: 0x0402B614 RID: 177684
		LookAt,
		// Token: 0x0402B615 RID: 177685
		NormalLock
	}

	// Token: 0x0200853F RID: 34111
	private enum EVisibleReason
	{
		// Token: 0x0402B617 RID: 177687
		Default,
		// Token: 0x0402B618 RID: 177688
		Tag = 2
	}
}
