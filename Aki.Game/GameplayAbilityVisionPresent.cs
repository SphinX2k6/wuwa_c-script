using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200271A RID: 10010
[NullableContext(1)]
[Nullable(0)]
public class GameplayAbilityVisionPresent : GameplayAbilityVisionMorph
{
	// Token: 0x060191B1 RID: 102833 RVA: 0x007A6A37 File Offset: 0x007A4C37
	public GameplayAbilityVisionPresent(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x060191B2 RID: 102834 RVA: 0x007A6A58 File Offset: 0x007A4C58
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

	// Token: 0x060191B3 RID: 102835 RVA: 0x007A6B56 File Offset: 0x007A4D56
	protected override bool NeedNoAi()
	{
		return false;
	}

	// Token: 0x060191B4 RID: 102836 RVA: 0x007A6B59 File Offset: 0x007A4D59
	protected override bool NeedNoActive()
	{
		return false;
	}

	// Token: 0x060191B5 RID: 102837 RVA: 0x007A6B5C File Offset: 0x007A4D5C
	protected override void OnTeleportStart()
	{
		this.NeedResetLocation = false;
	}

	// Token: 0x0400DB3E RID: 56126
	private readonly Vector DangoOriginalPosition = Vector.Create();

	// Token: 0x0400DB3F RID: 56127
	private readonly Rotator DangoOriginalRotation = Rotator.Create();

	// Token: 0x0400DB40 RID: 56128
	private bool NeedResetLocation;
}
