using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000F98 RID: 3992
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchActionDataBase : FloroRanchAsyncActionBase
{
	// Token: 0x0600A001 RID: 40961 RVA: 0x002F3D99 File Offset: 0x002F1F99
	[NullableContext(1)]
	public FloroRanchActionDataBase(FloroRanchUnitActionMsg actionData)
	{
		this.ActionType = actionData.UnitActionType;
		this.CasterEntityId = actionData.Caster;
	}

	// Token: 0x0600A002 RID: 40962 RVA: 0x002F3DB9 File Offset: 0x002F1FB9
	public void SetIgnoreCasterEntityAnim(int entityId)
	{
		this.IsIgnoreCasterAnim = (entityId == this.CasterEntity.EntityId);
	}

	// Token: 0x170010FB RID: 4347
	// (get) Token: 0x0600A003 RID: 40963 RVA: 0x002F3DCF File Offset: 0x002F1FCF
	public FloroRanchEntityBase CasterEntity
	{
		get
		{
			return FloroRanchGamePlayModel.Instance.GetEntity(this.CasterEntityId);
		}
	}

	// Token: 0x04005E8F RID: 24207
	public FloroRanchUnitActionType ActionType;

	// Token: 0x04005E90 RID: 24208
	protected bool IsIgnoreCasterAnim;

	// Token: 0x04005E91 RID: 24209
	private readonly int CasterEntityId;
}
