using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

// Token: 0x0200140C RID: 5132
public class LockCursorUnit : HudUnitBase
{
	// Token: 0x0600CBC1 RID: 52161 RVA: 0x003CA100 File Offset: 0x003C8300
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

	// Token: 0x0600CBC2 RID: 52162 RVA: 0x003CA1F0 File Offset: 0x003C83F0
	protected override void OnStart()
	{
		this.RootItem.SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
		base.GetItem(1).SetUIActive(true);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		this.SetBarPercent(1f);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600CBC3 RID: 52163 RVA: 0x003CA250 File Offset: 0x003C8450
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

	// Token: 0x0600CBC4 RID: 52164 RVA: 0x003CA2A8 File Offset: 0x003C84A8
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer.Clear();
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600CBC5 RID: 52165 RVA: 0x003CA2BC File Offset: 0x003C84BC
	public void Activate()
	{
		base.SetVisible(true, 0);
	}

	// Token: 0x0600CBC6 RID: 52166 RVA: 0x003CA2C6 File Offset: 0x003C84C6
	public void Deactivate()
	{
		this.SetLockState(LockCursorUnit.ELockState.None);
		base.SetVisible(false, 0);
	}

	// Token: 0x0600CBC7 RID: 52167 RVA: 0x003CA2D8 File Offset: 0x003C84D8
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

	// Token: 0x0600CBC8 RID: 52168 RVA: 0x003CA32E File Offset: 0x003C852E
	public bool IsForceLockState()
	{
		return this.LockState == LockCursorUnit.ELockState.ForceLock;
	}

	// Token: 0x0600CBC9 RID: 52169 RVA: 0x003CA339 File Offset: 0x003C8539
	public void ActivateUnlockTimeDown(float time)
	{
		this.UnlockTimeDown = time;
		this.CurrentTime = 0f;
	}

	// Token: 0x0600CBCA RID: 52170 RVA: 0x003CA34D File Offset: 0x003C854D
	public void DeactivateUnlockTimeDown()
	{
		this.UnlockTimeDown = -1f;
		this.CurrentTime = 0f;
		this.SetBarPercent(1f);
	}

	// Token: 0x0600CBCB RID: 52171 RVA: 0x003CA370 File Offset: 0x003C8570
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

	// Token: 0x0600CBCC RID: 52172 RVA: 0x003CA438 File Offset: 0x003C8638
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

	// Token: 0x0600CBCD RID: 52173 RVA: 0x003CA4A8 File Offset: 0x003C86A8
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

	// Token: 0x0600CBCE RID: 52174 RVA: 0x003CA4F8 File Offset: 0x003C86F8
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

	// Token: 0x0600CBCF RID: 52175 RVA: 0x003CA584 File Offset: 0x003C8784
	private void SetBarSpriteVisible(bool bVisible)
	{
		UUISprite sprite = base.GetSprite(3);
		if (sprite.IsUIActiveSelf() == bVisible)
		{
			return;
		}
		sprite.SetUIActive(bVisible);
	}

	// Token: 0x0600CBD0 RID: 52176 RVA: 0x003CA5AA File Offset: 0x003C87AA
	public void SetBarPercent(float percent)
	{
		base.GetSprite(3).SetFillAmount(percent);
	}

	// Token: 0x0600CBD1 RID: 52177 RVA: 0x003CA5BC File Offset: 0x003C87BC
	private void PlayStartSequence()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600CBD2 RID: 52178 RVA: 0x003CA5E8 File Offset: 0x003C87E8
	private void PlayLookAtLockSequence()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Lock", false, false, null, null, false);
	}

	// Token: 0x0600CBD3 RID: 52179 RVA: 0x003CA614 File Offset: 0x003C8814
	private void PlayLookAtUnlockSequence()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Unlock", false, false, null, null, false);
	}

	// Token: 0x0600CBD4 RID: 52180 RVA: 0x003CA63E File Offset: 0x003C883E
	private void PlayForceLockAudio()
	{
		BattleUiAudioData audioData = BattleUiModel.Instance.AudioData;
		if (audioData == null)
		{
			return;
		}
		audioData.PlayAudio(EBattleUiAudioType.ForceLock, EBattleUiChild.BattleHud);
	}

	// Token: 0x0600CBD5 RID: 52181 RVA: 0x003CA657 File Offset: 0x003C8857
	private void PlaySwitchForceLockAudio()
	{
		BattleUiAudioData audioData = BattleUiModel.Instance.AudioData;
		if (audioData == null)
		{
			return;
		}
		audioData.PlayAudio(EBattleUiAudioType.SwitchForceLock, EBattleUiChild.BattleHud);
	}

	// Token: 0x040073B8 RID: 29624
	private float UnlockTimeDown = -1f;

	// Token: 0x040073B9 RID: 29625
	private float CurrentTime;

	// Token: 0x040073BA RID: 29626
	private LockCursorUnit.ELockState LockState;

	// Token: 0x040073BB RID: 29627
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040073BC RID: 29628
	private bool HasHiddenTag;

	// Token: 0x040073BD RID: 29629
	private int LockEntityId;

	// Token: 0x040073BE RID: 29630
	private int LockAudioEntityId;

	// Token: 0x020076C2 RID: 30402
	private enum EChildType
	{
		// Token: 0x0402692F RID: 157999
		Item1,
		// Token: 0x04026930 RID: 158000
		Item2,
		// Token: 0x04026931 RID: 158001
		Item3,
		// Token: 0x04026932 RID: 158002
		BarSprite,
		// Token: 0x04026933 RID: 158003
		AnimSprite,
		// Token: 0x04026934 RID: 158004
		Item4
	}

	// Token: 0x020076C3 RID: 30403
	private enum ELockState
	{
		// Token: 0x04026936 RID: 158006
		None,
		// Token: 0x04026937 RID: 158007
		ForceLock,
		// Token: 0x04026938 RID: 158008
		LookAt,
		// Token: 0x04026939 RID: 158009
		NormalLock
	}

	// Token: 0x020076C4 RID: 30404
	private enum EVisibleReason
	{
		// Token: 0x0402693B RID: 158011
		Default,
		// Token: 0x0402693C RID: 158012
		Tag = 2
	}
}
