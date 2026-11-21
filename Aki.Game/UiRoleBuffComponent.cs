using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002203 RID: 8707
public class UiRoleBuffComponent : UiModelBuffComponent
{
	// Token: 0x060156C0 RID: 87744 RVA: 0x00638B12 File Offset: 0x00636D12
	protected override void OnInit()
	{
		base.OnInit();
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
	}

	// Token: 0x060156C1 RID: 87745 RVA: 0x00638B2C File Offset: 0x00636D2C
	protected override void OnStart()
	{
		base.OnStart();
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
	}

	// Token: 0x060156C2 RID: 87746 RVA: 0x00638B84 File Offset: 0x00636D84
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
		base.OnEnd();
	}

	// Token: 0x060156C3 RID: 87747 RVA: 0x00638BDB File Offset: 0x00636DDB
	private void OnBeforeUiModelLoadStart()
	{
		base.RemoveAllBuffId();
	}

	// Token: 0x060156C4 RID: 87748 RVA: 0x00638BE4 File Offset: 0x00636DE4
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

	// Token: 0x0400B590 RID: 46480
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;
}
