using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x0200320B RID: 12811
[NullableContext(1)]
[Nullable(0)]
public class InterestItemEntity : InterestItemBase
{
	// Token: 0x17002639 RID: 9785
	// (get) Token: 0x0601BA35 RID: 113205 RVA: 0x00797C9D File Offset: 0x00795E9D
	public override EInterestItemType Type
	{
		get
		{
			return EInterestItemType.Entity;
		}
	}

	// Token: 0x0601BA36 RID: 113206 RVA: 0x00797CA0 File Offset: 0x00795EA0
	public override bool GetLocation(Vector outVector)
	{
		Entity entity = this.GetEntity();
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return false;
		}
		outVector.DeepCopy(baseActorComponent.ActorLocationProxy);
		return true;
	}

	// Token: 0x0601BA37 RID: 113207 RVA: 0x00797CD2 File Offset: 0x00795ED2
	public override string GetDebugInfo()
	{
		return this.PbDataId.ToString();
	}

	// Token: 0x0601BA38 RID: 113208 RVA: 0x00797CDF File Offset: 0x00795EDF
	[NullableContext(2)]
	public Entity GetEntity()
	{
		if (this.PbDataId == -1)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return null;
			}
			return baseCharacter.GetEntityNoBlueprint();
		}
		else
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.PbDataId);
			if (entityByPbDataId == null)
			{
				return null;
			}
			return entityByPbDataId.Entity;
		}
	}

	// Token: 0x0400D957 RID: 55639
	public int PbDataId;
}
