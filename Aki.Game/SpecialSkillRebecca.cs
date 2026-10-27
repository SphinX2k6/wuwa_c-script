using System;
using System.Runtime.CompilerServices;

// Token: 0x0200319A RID: 12698
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillRebecca : SpecialSkillAimingBase
{
	// Token: 0x170025D1 RID: 9681
	// (get) Token: 0x0601B58C RID: 112012 RVA: 0x007786CA File Offset: 0x007768CA
	protected override int AimingTagId
	{
		get
		{
			return GameplayTagDefine.EGameplayTagId["角色.Common.瞄准镜头.Rebecca瞄准"];
		}
	}

	// Token: 0x170025D2 RID: 9682
	// (get) Token: 0x0601B58D RID: 112013 RVA: 0x007786DB File Offset: 0x007768DB
	protected override EEventName SwitchLockTargetEventName
	{
		get
		{
			return EEventName.SpecialSkillRebeccaSwitchLockTarget;
		}
	}

	// Token: 0x0601B58E RID: 112014 RVA: 0x007786DF File Offset: 0x007768DF
	public SpecialSkillRebecca(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B58F RID: 112015 RVA: 0x007786FE File Offset: 0x007768FE
	public override void OnStart()
	{
		this.SkillComp = this.SpecialSkillComponent.Entity.GetComponent<CharacterSkillComponent>();
		this.LockOnComp = this.SpecialSkillComponent.Entity.GetComponent<BaseLockOnComponent>();
		base.OnStart();
	}

	// Token: 0x0601B590 RID: 112016 RVA: 0x00778732 File Offset: 0x00776932
	protected override void OnAimingStart()
	{
		if (this.SkillComp != null)
		{
			this.SkillComp.SkillTarget = null;
			this.SkillComp.SkillTargetSocket = "";
		}
		this.LockOn();
	}

	// Token: 0x0601B591 RID: 112017 RVA: 0x0077875E File Offset: 0x0077695E
	protected override void LockOn()
	{
		base.LockOnRect(this.Distance, this.HalfWidth, this.HalfHeight);
	}

	// Token: 0x0601B592 RID: 112018 RVA: 0x00778778 File Offset: 0x00776978
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

	// Token: 0x0601B593 RID: 112019 RVA: 0x007787DC File Offset: 0x007769DC
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

	// Token: 0x0601B594 RID: 112020 RVA: 0x0077882C File Offset: 0x00776A2C
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

	// Token: 0x0601B595 RID: 112021 RVA: 0x007788B5 File Offset: 0x00776AB5
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

	// Token: 0x0400D5F5 RID: 54773
	private const long REBECCA_AIM_MARK_CUE_ID = 1308503001L;

	// Token: 0x0400D5F6 RID: 54774
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400D5F7 RID: 54775
	private readonly int HalfWidth = 750;

	// Token: 0x0400D5F8 RID: 54776
	private readonly int HalfHeight = 400;

	// Token: 0x0400D5F9 RID: 54777
	[Nullable(2)]
	private BaseLockOnComponent LockOnComp;

	// Token: 0x0400D5FA RID: 54778
	private int AimMarkCueHandle;

	// Token: 0x0400D5FB RID: 54779
	[Nullable(2)]
	private GameplayCueEffect AimMarkCue;

	// Token: 0x0400D5FC RID: 54780
	[Nullable(2)]
	private CharacterGameplayCueComponent TargetCueComp;
}
