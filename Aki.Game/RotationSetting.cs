using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02003036 RID: 12342
public class RotationSetting : IClear
{
	// Token: 0x0601A25E RID: 107102 RVA: 0x006DEBD0 File Offset: 0x006DCDD0
	public bool ClearObject()
	{
		this.MinSpeed = 360f;
		this.MaxSpeed = 600f;
		this.MinOffset = 0f;
		this.MaxOffset = 180f;
		this.Curve = CurveUtils.DefaultLinear;
		return true;
	}

	// Token: 0x0601A25F RID: 107103 RVA: 0x006DEC0C File Offset: 0x006DCE0C
	[NullableContext(1)]
	public void UpdateSettings(SMovementRotationSetting setting)
	{
		this.MinSpeed = setting.最小旋转速度;
		this.MaxSpeed = setting.最大旋转速度;
		this.MinOffset = setting.最小角度差;
		this.MaxOffset = setting.最大角度差;
		this.Curve = CurveUtils.CreateCurveByStruct(setting.渐变曲线);
	}

	// Token: 0x0601A260 RID: 107104 RVA: 0x006DEC5A File Offset: 0x006DCE5A
	public float GetMaxSpeed()
	{
		return this.MaxSpeed;
	}

	// Token: 0x0601A261 RID: 107105 RVA: 0x006DEC62 File Offset: 0x006DCE62
	public float GetMaxOffset()
	{
		return this.MaxOffset;
	}

	// Token: 0x0601A262 RID: 107106 RVA: 0x006DEC6C File Offset: 0x006DCE6C
	public float GetSpeed(float offset)
	{
		float key = (offset - this.MinOffset) / (this.MaxOffset - this.MinOffset);
		return this.MinSpeed + this.Curve.GetCurrentValue(key) * (this.MaxSpeed - this.MinSpeed);
	}

	// Token: 0x0400C6A6 RID: 50854
	protected float MinSpeed = 360f;

	// Token: 0x0400C6A7 RID: 50855
	protected float MaxSpeed = 600f;

	// Token: 0x0400C6A8 RID: 50856
	protected float MinOffset;

	// Token: 0x0400C6A9 RID: 50857
	protected float MaxOffset = 180f;

	// Token: 0x0400C6AA RID: 50858
	[Nullable(1)]
	protected CurveBase Curve = CurveUtils.DefaultLinear;
}
