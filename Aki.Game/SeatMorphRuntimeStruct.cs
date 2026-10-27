using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;

// Token: 0x020016E5 RID: 5861
public class SeatMorphRuntimeStruct
{
	// Token: 0x0600A7FE RID: 43006 RVA: 0x0025B767 File Offset: 0x00259967
	public void SetTargetSeatMorph(double v)
	{
		this.TargetSeatMorph = MathUtils.Instance.Clamp(v, 0.0, 1.0);
	}

	// Token: 0x0600A7FF RID: 43007 RVA: 0x0025B78C File Offset: 0x0025998C
	[NullableContext(1)]
	public SeatMorphRuntimeStruct(Entity seatEntity, int charEntityId)
	{
		this.SeatEntityId = seatEntity.Id;
		this.CharEntityId = charEntityId;
		this.SceneItemProceduralMatComp = seatEntity.GetComponent<SceneItemProceduralMaterialComponent>();
	}

	// Token: 0x0600A800 RID: 43008 RVA: 0x0025B7B3 File Offset: 0x002599B3
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

	// Token: 0x0600A801 RID: 43009 RVA: 0x0025B7E0 File Offset: 0x002599E0
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

	// Token: 0x04004BB0 RID: 19376
	private int SeatEntityId;

	// Token: 0x04004BB1 RID: 19377
	private double TargetSeatMorph;

	// Token: 0x04004BB2 RID: 19378
	private double CurrentSeatMorph;

	// Token: 0x04004BB3 RID: 19379
	[Nullable(2)]
	private SceneItemProceduralMaterialComponent SceneItemProceduralMatComp;

	// Token: 0x04004BB4 RID: 19380
	private int CharEntityId;
}
