using System;
using System.Runtime.CompilerServices;

// Token: 0x02002708 RID: 9992
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillRebecca : SpecialSkillAimingBase
{
	// Token: 0x170027C2 RID: 10178
	// (get) Token: 0x060190AC RID: 102572 RVA: 0x007A0956 File Offset: 0x0079EB56
	protected override int AimingTagId
	{
		get
		{
			return GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.Rebecca瞄准"];
		}
	}

	// Token: 0x170027C3 RID: 10179
	// (get) Token: 0x060190AD RID: 102573 RVA: 0x007A0967 File Offset: 0x0079EB67
	protected override EEventName SwitchLockTargetEventName
	{
		get
		{
			return EEventName.SpecialSkillRebeccaSwitchLockTarget;
		}
	}

	// Token: 0x060190AE RID: 102574 RVA: 0x007A096B File Offset: 0x0079EB6B
	public SpecialSkillRebecca(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x060190AF RID: 102575 RVA: 0x007A098A File Offset: 0x0079EB8A
	public override void OnStart()
	{
		this.SkillComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterSkillComponent>();
		this.LockOnComp = this.SpecialSkillComponent.Entity.GetComponent<BaseLockOnComponent>();
		base.OnStart();
	}

	// Token: 0x060190B0 RID: 102576 RVA: 0x007A09BE File Offset: 0x0079EBBE
	protected override void OnAimingStart()
	{
		if (this.SkillComp != null)
		{
			this.SkillComp.SkillTarget = null;
			this.SkillComp.SkillTargetSocket = "";
		}
		this.LockOn();
	}

	// Token: 0x060190B1 RID: 102577 RVA: 0x007A09EA File Offset: 0x0079EBEA
	protected override void LockOn()
	{
		base.LockOnRect(this.Distance, this.HalfWidth, this.HalfHeight);
	}

	// Token: 0x060190B2 RID: 102578 RVA: 0x007A0A04 File Offset: 0x0079EC04
	protected override void DoOnTargetLocked(EntityHandle target, string socketName)
	{
		BaseLockOnComponent lockOnComp = this.LockOnComp;
		if (lockOnComp != null)
		{
			lockOnComp.LockOnSpecifyTarget(target, socketName);
		}
		if (this.SkillComp != null && this.LockOnComp != null)
		{
			this.SkillComp.SkillTarget = this.LockOnComp.GetCurrentTarget();
			this.SkillComp.SkillTargetSocket = this.LockOnComp.GetCurrentTargetSocketName();
		}
		this.AddAimMarkCue(target, socketName);
	}

	// Token: 0x060190B3 RID: 102579 RVA: 0x007A0A68 File Offset: 0x0079EC68
	protected override void DoOnTargetUnlocked(EntityHandle target, string socketName)
	{
		BaseLockOnComponent lockOnComp = this.LockOnComp;
		if (lockOnComp != null)
		{
			lockOnComp.LockOnSpecifyTarget(null, "");
		}
		if (this.SkillComp != null)
		{
			this.SkillComp.SkillTarget = null;
			this.SkillComp.SkillTargetSocket = "";
		}
		this.RemoveAimMarkCue();
	}

	// Token: 0x060190B4 RID: 102580 RVA: 0x007A0AB8 File Offset: 0x0079ECB8
	private void AddAimMarkCue(EntityHandle target, string socketName)
	{
		this.RemoveAimMarkCue();
		WorldEntity entity = target.Entity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null;
		if (characterGameplayCueComponent == null)
		{
			return;
		}
		this.TargetCueComp = characterGameplayCueComponent;
		this.AimMarkCueHandle = characterGameplayCueComponent.AddCue(1308503001L, null);
		if (this.AimMarkCueHandle == 0)
		{
			return;
		}
		this.AimMarkCue = (characterGameplayCueComponent.GetCueByHandle((long)this.AimMarkCueHandle) as GameplayCueEffect);
		if (this.AimMarkCue != null && !string.IsNullOrEmpty(socketName))
		{
			this.AimMarkCue.SetSocketAndReattach(socketName);
		}
	}

	// Token: 0x060190B5 RID: 102581 RVA: 0x007A0B41 File Offset: 0x0079ED41
	private void RemoveAimMarkCue()
	{
		if (this.TargetCueComp != null && this.AimMarkCueHandle != 0)
		{
			this.TargetCueComp.RemoveCueByHandle((long)this.AimMarkCueHandle);
		}
		this.AimMarkCueHandle = 0;
		this.AimMarkCue = null;
		this.TargetCueComp = null;
	}

	// Token: 0x0400DA78 RID: 55928
	private const long REBECCA_AIM_MARK_CUE_ID = 1308503001L;

	// Token: 0x0400DA79 RID: 55929
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400DA7A RID: 55930
	private readonly int HalfWidth = 750;

	// Token: 0x0400DA7B RID: 55931
	private readonly int HalfHeight = 400;

	// Token: 0x0400DA7C RID: 55932
	[Nullable(2)]
	private BaseLockOnComponent LockOnComp;

	// Token: 0x0400DA7D RID: 55933
	private int AimMarkCueHandle;

	// Token: 0x0400DA7E RID: 55934
	[Nullable(2)]
	private GameplayCueEffect AimMarkCue;

	// Token: 0x0400DA7F RID: 55935
	[Nullable(2)]
	private CharacterGameplayCueComponent TargetCueComp;
}
