using System;
using System.Runtime.CompilerServices;

// Token: 0x02003193 RID: 12691
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillKanteleila : SpecialSkillBase
{
	// Token: 0x0601B53D RID: 111933 RVA: 0x00776714 File Offset: 0x00774914
	public SpecialSkillKanteleila(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B53E RID: 111934 RVA: 0x00776740 File Offset: 0x00774940
	public override void OnTick(float delta)
	{
		if (this.EnableAddMoveByInputDirect)
		{
			delta *= (float)TimeUtil.Instance.Millisecond;
			CharacterActorComponent component = this.SpecialSkillComponent.Entity.GetComponent<CharacterActorComponent>();
			BaseMoveComponent component2 = this.SpecialSkillComponent.Entity.GetComponent<BaseMoveComponent>();
			Vector moveDirectionCache = this.SpecialSkillComponent.Entity.GetComponent<CharacterInputComponent>().GetMoveDirectionCache();
			Vector offset = this.GetOffset(component.InputDirectProxy, moveDirectionCache, delta);
			if (!offset.IsNearlyZero(9.999999747378752E-05) && component2 != null)
			{
				component2.MoveCharacter(offset, delta, "SpecialSkillKanteleila");
			}
		}
	}

	// Token: 0x0601B53F RID: 111935 RVA: 0x007767CC File Offset: 0x007749CC
	public void BeginAddMoveByInputDirect(float maxSpeed, float accelerationTime, float decelerationTime, float delayTime)
	{
		this.EnableAddMoveByInputDirect = true;
		this.CurrentSpeed = 0f;
		this.TotalTime = 0f;
		this.DelayTime = delayTime;
		this.InputDirectCache.Reset();
		this.MoveDirCache.Reset();
		this.MaxSpeed = ((maxSpeed > 0f) ? maxSpeed : 0f);
		this.Acceleration = ((accelerationTime > 0f) ? (this.MaxSpeed / accelerationTime) : 0f);
		this.Deceleration = ((decelerationTime > 0f) ? (this.MaxSpeed / decelerationTime) : 0f);
	}

	// Token: 0x0601B540 RID: 111936 RVA: 0x00776864 File Offset: 0x00774A64
	public override void EndAddMoveByInputDirect()
	{
		this.EnableAddMoveByInputDirect = false;
	}

	// Token: 0x0601B541 RID: 111937 RVA: 0x00776870 File Offset: 0x00774A70
	private Vector GetOffset(Vector inputDirect, Vector moveDirect, float delta)
	{
		if (!this.MoveDirCache.Equals(moveDirect, 9.999999747378752E-05))
		{
			this.TotalTime = 0f;
		}
		this.MoveDirCache.DeepCopy(moveDirect);
		this.TotalTime += delta;
		if (this.TotalTime < this.DelayTime || inputDirect.IsNearlyZero(9.999999747378752E-05))
		{
			this.CurrentSpeed -= this.Deceleration * delta;
			this.CurrentSpeed = MathF.Max(this.CurrentSpeed, 0f);
		}
		else
		{
			this.CurrentSpeed += this.Acceleration * delta;
			this.CurrentSpeed = MathF.Min(this.CurrentSpeed, this.MaxSpeed);
			this.InputDirectCache.DeepCopy(inputDirect);
		}
		this.TmpVector.DeepCopy(this.InputDirectCache);
		this.TmpVector.Normalize(9.99999993922529E-09);
		this.TmpVector.MultiplyEqual((double)(this.CurrentSpeed * delta));
		return this.TmpVector;
	}

	// Token: 0x0400D5B0 RID: 54704
	private bool EnableAddMoveByInputDirect;

	// Token: 0x0400D5B1 RID: 54705
	private float MaxSpeed;

	// Token: 0x0400D5B2 RID: 54706
	private float Acceleration;

	// Token: 0x0400D5B3 RID: 54707
	private float Deceleration;

	// Token: 0x0400D5B4 RID: 54708
	private float CurrentSpeed;

	// Token: 0x0400D5B5 RID: 54709
	private float TotalTime;

	// Token: 0x0400D5B6 RID: 54710
	private float DelayTime;

	// Token: 0x0400D5B7 RID: 54711
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400D5B8 RID: 54712
	private readonly Vector InputDirectCache = Vector.Create();

	// Token: 0x0400D5B9 RID: 54713
	private readonly Vector MoveDirCache = Vector.Create();
}
