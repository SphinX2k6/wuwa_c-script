using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020018DB RID: 6363
[NullableContext(1)]
[Nullable(0)]
public class TipsCharacterData : ItemTipsData
{
	// Token: 0x0600BAA4 RID: 47780 RVA: 0x002A4A6C File Offset: 0x002A2C6C
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

	// Token: 0x0600BAA5 RID: 47781 RVA: 0x002A4B3C File Offset: 0x002A2D3C
	public string GetRoleName()
	{
		return this.RoleName;
	}

	// Token: 0x0600BAA6 RID: 47782 RVA: 0x002A4B44 File Offset: 0x002A2D44
	public ElementInfo GetElementConfig()
	{
		return this.ElementConfig.Value;
	}

	// Token: 0x0600BAA7 RID: 47783 RVA: 0x002A4B51 File Offset: 0x002A2D51
	public string GetHeadTexutePath()
	{
		return this.RoleHeadTexturePath;
	}

	// Token: 0x0600BAA8 RID: 47784 RVA: 0x002A4B59 File Offset: 0x002A2D59
	public string GetRoleIntroduction()
	{
		return this.RoleIntroduction;
	}

	// Token: 0x040054C6 RID: 21702
	private readonly string RoleName = "";

	// Token: 0x040054C7 RID: 21703
	private readonly ElementInfo? ElementConfig;

	// Token: 0x040054C8 RID: 21704
	private readonly string RoleHeadTexturePath = "";

	// Token: 0x040054C9 RID: 21705
	private readonly string RoleIntroduction = "";
}
