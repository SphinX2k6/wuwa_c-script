using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200220B RID: 8715
public class UiRoleMorphComponent : UiModelMorphComponent
{
	// Token: 0x060156F9 RID: 87801 RVA: 0x0063982E File Offset: 0x00637A2E
	protected override void OnStart()
	{
		base.OnStart();
		this.UiRoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
	}

	// Token: 0x060156FA RID: 87802 RVA: 0x00639847 File Offset: 0x00637A47
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiRoleDataComponent = null;
	}

	// Token: 0x060156FB RID: 87803 RVA: 0x00639858 File Offset: 0x00637A58
	protected override void PreloadMorphId()
	{
		this.MorphIdMap = UiModelUtil.Instance.GetRoleMorphConfigMap(this.UiRoleDataComponent.RoleConfigId, this.UiRoleDataComponent.RoleSkinId);
		Dictionary<EUiModelMorphType, IUiMorphId> morphIdMap = this.MorphIdMap;
		this.IsEnableMorphInternal = (morphIdMap == null || morphIdMap.Count != 0);
	}

	// Token: 0x060156FC RID: 87804 RVA: 0x006398A8 File Offset: 0x00637AA8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override List<string> GetAllMorphPathList()
	{
		this.PreloadMorphId();
		if (this.MorphIdMap == null || this.MorphIdMap.Count == 0)
		{
			return null;
		}
		List<string> list = new List<string>();
		foreach (IUiMorphId uiMorphId in this.MorphIdMap.Values)
		{
			if (!string.IsNullOrEmpty(uiMorphId.MainMeshPath))
			{
				list.Add(uiMorphId.MainMeshPath);
			}
			if (!string.IsNullOrEmpty(uiMorphId.AnimPath))
			{
				list.Add(uiMorphId.AnimPath);
			}
			if (uiMorphId.ChildMeshPathList != null && uiMorphId.ChildMeshPathList.Count > 0)
			{
				list.AddRange(uiMorphId.ChildMeshPathList);
			}
		}
		return list;
	}

	// Token: 0x060156FD RID: 87805 RVA: 0x00639974 File Offset: 0x00637B74
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override List<IUiMorphId> GetSpecialMorphIdList()
	{
		Dictionary<EUiModelMorphType, IUiMorphId> roleMorphConfigMap = UiModelUtil.Instance.GetRoleMorphConfigMap(this.UiRoleDataComponent.RoleConfigId, this.UiRoleDataComponent.RoleSkinId);
		if (roleMorphConfigMap == null || roleMorphConfigMap.Count == 0)
		{
			return null;
		}
		List<IUiMorphId> list = new List<IUiMorphId>();
		foreach (KeyValuePair<EUiModelMorphType, IUiMorphId> keyValuePair in roleMorphConfigMap)
		{
			if (keyValuePair.Key != EUiModelMorphType.默认形态)
			{
				list.Add(keyValuePair.Value);
			}
		}
		return list;
	}

	// Token: 0x0400B5A8 RID: 46504
	[Nullable(2)]
	private UiRoleDataComponent UiRoleDataComponent;
}
