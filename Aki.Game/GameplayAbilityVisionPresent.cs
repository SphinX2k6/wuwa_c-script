using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020031AB RID: 12715
[NullableContext(1)]
[Nullable(0)]
public class GameplayAbilityVisionPresent : GameplayAbilityVisionMorph
{
	// Token: 0x0601B67E RID: 112254 RVA: 0x0077E70B File Offset: 0x0077C90B
	public GameplayAbilityVisionPresent(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x0601B67F RID: 112255 RVA: 0x0077E72C File Offset: 0x0077C92C
	[NullableContext(2)]
	protected override void SetVisionEnable(bool enable, EntityHandle visionEntity = null)
	{
		if (visionEntity == null)
		{
			visionEntity = this.VisionEntity;
		}
		if (enable)
		{
			this.NeedResetLocation = true;
			this.DangoOriginalPosition.DeepCopy(this.VisionActorComponent.ActorLocationProxy);
			this.DangoOriginalRotation.DeepCopy(this.VisionActorComponent.ActorRotationProxy);
			CreatureController.Instance.SetEntityEnable(visionEntity.Entity, enable, "GameplayAbilityVisionPresent.SetVisionEnable", true);
		}
		else
		{
			this.VisionSkillComponent.StopGroup1Skill("驻场声骸技能结束");
			if (this.NeedResetLocation)
			{
				this.VisionActorComponent.SetActorLocationAndRotation(this.DangoOriginalPosition.ToUeVector(false), this.DangoOriginalRotation.ToUeRotator(), "驻场声骸消失时恢复原来的位置", false, null);
			}
			this.NeedResetLocation = true;
			this.VisionBuffComponent.AddBuff(1900000017L, new AddBuffParam
			{
				InstigatorId = this.VisionBuffComponent.CreatureDataId,
				Reason = "驻场声骸归位时的材质和粒子"
			});
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnPhantomEnableStateChange, enable);
	}

	// Token: 0x0601B680 RID: 112256 RVA: 0x0077E82A File Offset: 0x0077CA2A
	protected override bool NeedNoAi()
	{
		return false;
	}

	// Token: 0x0601B681 RID: 112257 RVA: 0x0077E82D File Offset: 0x0077CA2D
	protected override bool NeedNoActive()
	{
		return false;
	}

	// Token: 0x0601B682 RID: 112258 RVA: 0x0077E830 File Offset: 0x0077CA30
	protected override void OnTeleportStart()
	{
		this.NeedResetLocation = false;
	}

	// Token: 0x0400D6B7 RID: 54967
	private readonly Vector DangoOriginalPosition = Vector.Create();

	// Token: 0x0400D6B8 RID: 54968
	private readonly Rotator DangoOriginalRotation = Rotator.Create();

	// Token: 0x0400D6B9 RID: 54969
	private bool NeedResetLocation;
}
