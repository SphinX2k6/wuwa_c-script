using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002CAA RID: 11434
public class UiRoleBuffComponent : UiModelBuffComponent
{
	// Token: 0x06017E4C RID: 97868 RVA: 0x00612F8E File Offset: 0x0061118E
	protected override void OnInit()
	{
		base.OnInit();
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
	}

	// Token: 0x06017E4D RID: 97869 RVA: 0x00612FA8 File Offset: 0x006111A8
	protected override void OnStart()
	{
		base.OnStart();
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
	}

	// Token: 0x06017E4E RID: 97870 RVA: 0x00613000 File Offset: 0x00611200
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
		base.OnEnd();
	}

	// Token: 0x06017E4F RID: 97871 RVA: 0x00613057 File Offset: 0x00611257
	private void OnBeforeUiModelLoadStart()
	{
		base.RemoveAllBuffId();
	}

	// Token: 0x06017E50 RID: 97872 RVA: 0x00613060 File Offset: 0x00611260
	private void OnRoleMeshLoadComplete()
	{
		int roleDataId = this.RoleDataComponent.RoleDataId;
		List<long> equippedBuffsByRoleId = BuffItemModel.Instance.GetEquippedBuffsByRoleId(roleDataId, false);
		if (equippedBuffsByRoleId == null || equippedBuffsByRoleId.Count == 0)
		{
			return;
		}
		foreach (long buffId in equippedBuffsByRoleId)
		{
			base.AddBuffByBuffId(buffId);
		}
	}

	// Token: 0x0400B225 RID: 45605
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;
}
