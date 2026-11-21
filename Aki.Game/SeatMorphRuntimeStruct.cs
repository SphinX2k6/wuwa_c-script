using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;

// Token: 0x02000B9D RID: 2973
public class SeatMorphRuntimeStruct
{
	// Token: 0x06007BDE RID: 31710 RVA: 0x00265B6F File Offset: 0x00263D6F
	public void SetTargetSeatMorph(double v)
	{
		this.TargetSeatMorph = MathUtils.Instance.Clamp(v, 0.0, 1.0);
	}

	// Token: 0x06007BDF RID: 31711 RVA: 0x00265B94 File Offset: 0x00263D94
	[NullableContext(1)]
	public SeatMorphRuntimeStruct(Entity seatEntity, int charEntityId)
	{
		this.SeatEntityId = seatEntity.Id;
		this.CharEntityId = charEntityId;
		this.SceneItemProceduralMatComp = seatEntity.GetComponent<SceneItemProceduralMaterialComponent>();
	}

	// Token: 0x06007BE0 RID: 31712 RVA: 0x00265BBB File Offset: 0x00263DBB
	public bool TrySetTargetSeatMorph(int charEntityId, double v)
	{
		if (this.CharEntityId != charEntityId)
		{
			if (this.TargetSeatMorph != 0.0)
			{
				return false;
			}
			this.CharEntityId = charEntityId;
		}
		this.SetTargetSeatMorph(v);
		return true;
	}

	// Token: 0x06007BE1 RID: 31713 RVA: 0x00265BE8 File Offset: 0x00263DE8
	public bool Update(float delta)
	{
		if (EntitySystem.Instance.Get(this.SeatEntityId) == null)
		{
			return true;
		}
		if (EntitySystem.Instance.Get(this.CharEntityId) == null && this.TargetSeatMorph != 0.0)
		{
			this.TargetSeatMorph = 0.0;
		}
		if (this.SceneItemProceduralMatComp == null)
		{
			return this.TargetSeatMorph < 0.0001;
		}
		if (this.TargetSeatMorph > this.CurrentSeatMorph)
		{
			this.CurrentSeatMorph = this.TargetSeatMorph;
			this.SceneItemProceduralMatComp.SetCustomPrimitiveData(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair, (float)this.CurrentSeatMorph);
			return false;
		}
		if (this.CurrentSeatMorph - this.TargetSeatMorph < 0.0001)
		{
			return this.CurrentSeatMorph < 0.0001;
		}
		this.CurrentSeatMorph = MathUtils.Instance.InterpConstantTo(this.CurrentSeatMorph, this.TargetSeatMorph, (double)delta, 0.0005);
		this.SceneItemProceduralMatComp.SetCustomPrimitiveData(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair, (float)this.CurrentSeatMorph);
		return false;
	}

	// Token: 0x04004C57 RID: 19543
	private int SeatEntityId;

	// Token: 0x04004C58 RID: 19544
	private double TargetSeatMorph;

	// Token: 0x04004C59 RID: 19545
	private double CurrentSeatMorph;

	// Token: 0x04004C5A RID: 19546
	[Nullable(2)]
	private SceneItemProceduralMaterialComponent SceneItemProceduralMatComp;

	// Token: 0x04004C5B RID: 19547
	private int CharEntityId;
}
