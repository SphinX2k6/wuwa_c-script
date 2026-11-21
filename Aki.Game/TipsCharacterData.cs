using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02000D94 RID: 3476
[NullableContext(1)]
[Nullable(0)]
public class TipsCharacterData : ItemTipsData
{
	// Token: 0x06008E8D RID: 36493 RVA: 0x002AF1E8 File Offset: 0x002AD3E8
	public TipsCharacterData(ItemTipsParam data) : base(data)
	{
		this.ItemType = EItemTipsType.Character;
		RoleConfig instance = RoleConfig.Instance;
		RoleInfo? roleConfig = instance.GetRoleConfig(this.ConfigId);
		int parentId = roleConfig.Value.ParentId;
		if (parentId > 0)
		{
			roleConfig = instance.GetRoleConfig(parentId);
		}
		int elementId = roleConfig.Value.ElementId;
		this.RoleName = roleConfig.Value.Name;
		this.ElementConfig = ElementInfoConfig.Instance.GetElementInfo(elementId);
		this.RoleHeadTexturePath = roleConfig.Value.RoleHeadIconBig;
		this.RoleIntroduction = roleConfig.Value.Introduction;
	}

	// Token: 0x06008E8E RID: 36494 RVA: 0x002AF2B8 File Offset: 0x002AD4B8
	public string GetRoleName()
	{
		return this.RoleName;
	}

	// Token: 0x06008E8F RID: 36495 RVA: 0x002AF2C0 File Offset: 0x002AD4C0
	public ElementInfo GetElementConfig()
	{
		return this.ElementConfig.Value;
	}

	// Token: 0x06008E90 RID: 36496 RVA: 0x002AF2CD File Offset: 0x002AD4CD
	public string GetHeadTexutePath()
	{
		return this.RoleHeadTexturePath;
	}

	// Token: 0x06008E91 RID: 36497 RVA: 0x002AF2D5 File Offset: 0x002AD4D5
	public string GetRoleIntroduction()
	{
		return this.RoleIntroduction;
	}

	// Token: 0x04005571 RID: 21873
	private readonly string RoleName = "";

	// Token: 0x04005572 RID: 21874
	private readonly ElementInfo? ElementConfig;

	// Token: 0x04005573 RID: 21875
	private readonly string RoleHeadTexturePath = "";

	// Token: 0x04005574 RID: 21876
	private readonly string RoleIntroduction = "";
}
