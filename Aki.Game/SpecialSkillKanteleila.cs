using System;
using System.Runtime.CompilerServices;

// Token: 0x02002700 RID: 9984
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillKanteleila : SpecialSkillBase
{
	// Token: 0x06019041 RID: 102465 RVA: 0x0079E08C File Offset: 0x0079C28C
	public SpecialSkillKanteleila(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x06019042 RID: 102466 RVA: 0x0079E0B8 File Offset: 0x0079C2B8
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

	// Token: 0x06019043 RID: 102467 RVA: 0x0079E144 File Offset: 0x0079C344
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

	// Token: 0x06019044 RID: 102468 RVA: 0x0079E1DC File Offset: 0x0079C3DC
	public override void EndAddMoveByInputDirect()
	{
		this.EnableAddMoveByInputDirect = false;
	}

	// Token: 0x06019045 RID: 102469 RVA: 0x0079E1E8 File Offset: 0x0079C3E8
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

	// Token: 0x0400DA13 RID: 55827
	private bool EnableAddMoveByInputDirect;

	// Token: 0x0400DA14 RID: 55828
	private float MaxSpeed;

	// Token: 0x0400DA15 RID: 55829
	private float Acceleration;

	// Token: 0x0400DA16 RID: 55830
	private float Deceleration;

	// Token: 0x0400DA17 RID: 55831
	private float CurrentSpeed;

	// Token: 0x0400DA18 RID: 55832
	private float TotalTime;

	// Token: 0x0400DA19 RID: 55833
	private float DelayTime;

	// Token: 0x0400DA1A RID: 55834
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400DA1B RID: 55835
	private readonly Vector InputDirectCache = Vector.Create();

	// Token: 0x0400DA1C RID: 55836
	private readonly Vector MoveDirCache = Vector.Create();
}
