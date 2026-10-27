using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02002CAB RID: 11435
public class UiRoleBuffPreviewComponent : UiModelBuffComponent
{
	// Token: 0x06017E52 RID: 97874 RVA: 0x006130DC File Offset: 0x006112DC
	protected override void OnStart()
	{
		base.OnStart();
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
	}

	// Token: 0x06017E53 RID: 97875 RVA: 0x00613134 File Offset: 0x00611334
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
		base.OnEnd();
	}

	// Token: 0x06017E54 RID: 97876 RVA: 0x0061318B File Offset: 0x0061138B
	private void OnBeforeUiModelLoadStart()
	{
		base.RemoveAllBuffId();
	}

	// Token: 0x06017E55 RID: 97877 RVA: 0x00613194 File Offset: 0x00611394
	private void OnRoleMeshLoadComplete()
	{
		List<long> currentPreviewItemBuffList = BuffItemModel.Instance.GetCurrentPreviewItemBuffList();
		if (currentPreviewItemBuffList == null || currentPreviewItemBuffList.Count == 0)
		{
			return;
		}
		foreach (long buffId in currentPreviewItemBuffList)
		{
			base.AddBuffByBuffId(buffId);
		}
	}
}
