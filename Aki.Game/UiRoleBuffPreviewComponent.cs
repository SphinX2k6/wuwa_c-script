using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02002204 RID: 8708
public class UiRoleBuffPreviewComponent : UiModelBuffComponent
{
	// Token: 0x060156C6 RID: 87750 RVA: 0x00638C60 File Offset: 0x00636E60
	protected override void OnStart()
	{
		base.OnStart();
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
	}

	// Token: 0x060156C7 RID: 87751 RVA: 0x00638CB8 File Offset: 0x00636EB8
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.BeforeUiModelLoadStart, new Action(this.OnBeforeUiModelLoadStart));
		base.OnEnd();
	}

	// Token: 0x060156C8 RID: 87752 RVA: 0x00638D0F File Offset: 0x00636F0F
	private void OnBeforeUiModelLoadStart()
	{
		base.RemoveAllBuffId();
	}

	// Token: 0x060156C9 RID: 87753 RVA: 0x00638D18 File Offset: 0x00636F18
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
