using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x0200277A RID: 10106
[NullableContext(1)]
[Nullable(0)]
public class InterestItemEntity : InterestItemBase
{
	// Token: 0x1700287A RID: 10362
	// (get) Token: 0x060195BA RID: 103866 RVA: 0x007C03FD File Offset: 0x007BE5FD
	public override EInterestItemType Type
	{
		get
		{
			return EInterestItemType.Entity;
		}
	}

	// Token: 0x060195BB RID: 103867 RVA: 0x007C0400 File Offset: 0x007BE600
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

	// Token: 0x060195BC RID: 103868 RVA: 0x007C0432 File Offset: 0x007BE632
	public override string GetDebugInfo()
	{
		return this.PbDataId.ToString();
	}

	// Token: 0x060195BD RID: 103869 RVA: 0x007C043F File Offset: 0x007BE63F
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

	// Token: 0x0400DDF6 RID: 56822
	public int PbDataId;
}
