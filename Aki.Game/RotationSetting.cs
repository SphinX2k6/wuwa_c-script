using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x0200258C RID: 9612
public class RotationSetting : IClear
{
	// Token: 0x06017BBC RID: 97212 RVA: 0x007068C4 File Offset: 0x00704AC4
	public bool ClearObject()
	{
		this.MinSpeed = 360f;
		this.MaxSpeed = 600f;
		this.MinOffset = 0f;
		this.MaxOffset = 180f;
		this.Curve = CurveUtils.DefaultLinear;
		return true;
	}

	// Token: 0x06017BBD RID: 97213 RVA: 0x00706900 File Offset: 0x00704B00
	[NullableContext(1)]
	public void UpdateSettings(SMovementRotationSetting setting)
	{
		this.MinSpeed = setting.最小旋转速度;
		this.MaxSpeed = setting.最大旋转速度;
		this.MinOffset = setting.最小角度差;
		this.MaxOffset = setting.最大角度差;
		this.Curve = CurveUtils.CreateCurveByStruct(setting.渐变曲线);
	}

	// Token: 0x06017BBE RID: 97214 RVA: 0x0070694E File Offset: 0x00704B4E
	public float GetMaxSpeed()
	{
		return this.MaxSpeed;
	}

	// Token: 0x06017BBF RID: 97215 RVA: 0x00706956 File Offset: 0x00704B56
	public float GetMaxOffset()
	{
		return this.MaxOffset;
	}

	// Token: 0x06017BC0 RID: 97216 RVA: 0x00706960 File Offset: 0x00704B60
	public float GetSpeed(float offset)
	{
		float key = (offset - this.MinOffset) / (this.MaxOffset - this.MinOffset);
		return this.MinSpeed + this.Curve.GetCurrentValue(key) * (this.MaxSpeed - this.MinSpeed);
	}

	// Token: 0x0400CA75 RID: 51829
	protected float MinSpeed = 360f;

	// Token: 0x0400CA76 RID: 51830
	protected float MaxSpeed = 600f;

	// Token: 0x0400CA77 RID: 51831
	protected float MinOffset;

	// Token: 0x0400CA78 RID: 51832
	protected float MaxOffset = 180f;

	// Token: 0x0400CA79 RID: 51833
	[Nullable(1)]
	protected CurveBase Curve = CurveUtils.DefaultLinear;
}
