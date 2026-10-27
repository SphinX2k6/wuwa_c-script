using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002CB2 RID: 11442
public class UiRoleMorphComponent : UiModelMorphComponent
{
	// Token: 0x06017E85 RID: 97925 RVA: 0x00613CA2 File Offset: 0x00611EA2
	protected override void OnStart()
	{
		base.OnStart();
		this.UiRoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
	}

	// Token: 0x06017E86 RID: 97926 RVA: 0x00613CBB File Offset: 0x00611EBB
	protected override void OnEnd()
	{
		base.OnEnd();
		this.UiRoleDataComponent = null;
	}

	// Token: 0x06017E87 RID: 97927 RVA: 0x00613CCC File Offset: 0x00611ECC
	protected override void PreloadMorphId()
	{
		this.MorphIdMap = UiModelUtil.Instance.GetRoleMorphConfigMap(this.UiRoleDataComponent.RoleConfigId, this.UiRoleDataComponent.RoleSkinId);
		Dictionary<EUiModelMorphType, IUiMorphId> morphIdMap = this.MorphIdMap;
		this.IsEnableMorphInternal = (morphIdMap == null || morphIdMap.Count != 0);
	}

	// Token: 0x06017E88 RID: 97928 RVA: 0x00613D1C File Offset: 0x00611F1C
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

	// Token: 0x06017E89 RID: 97929 RVA: 0x00613DE8 File Offset: 0x00611FE8
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

	// Token: 0x0400B23D RID: 45629
	[Nullable(2)]
	private UiRoleDataComponent UiRoleDataComponent;
}
