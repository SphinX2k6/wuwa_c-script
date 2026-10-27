using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001AD9 RID: 6873
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchActionDataBase : FloroRanchAsyncActionBase
{
	// Token: 0x0600CBF0 RID: 52208 RVA: 0x002E8C05 File Offset: 0x002E6E05
	[NullableContext(1)]
	public FloroRanchActionDataBase(FloroRanchUnitActionMsg actionData)
	{
		this.ActionType = actionData.UnitActionType;
		this.CasterEntityId = actionData.Caster;
	}

	// Token: 0x0600CBF1 RID: 52209 RVA: 0x002E8C25 File Offset: 0x002E6E25
	public void SetIgnoreCasterEntityAnim(int entityId)
	{
		this.IsIgnoreCasterAnim = (entityId == this.CasterEntity.EntityId);
	}

	// Token: 0x170010D6 RID: 4310
	// (get) Token: 0x0600CBF2 RID: 52210 RVA: 0x002E8C3B File Offset: 0x002E6E3B
	public FloroRanchEntityBase CasterEntity
	{
		get
		{
			return FloroRanchGamePlayModel.Instance.GetEntity(this.CasterEntityId);
		}
	}

	// Token: 0x04005DC0 RID: 24000
	public FloroRanchUnitActionType ActionType;

	// Token: 0x04005DC1 RID: 24001
	protected bool IsIgnoreCasterAnim;

	// Token: 0x04005DC2 RID: 24002
	private readonly int CasterEntityId;
}
