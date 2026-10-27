using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020028F9 RID: 10489
[NullableContext(1)]
[Nullable(0)]
public class FormationAttrListScrollData : AttrListScrollData
{
	// Token: 0x06015A74 RID: 88692 RVA: 0x005777FF File Offset: 0x005759FF
	public FormationAttrListScrollData(int id, double baseValue, double addValue, int priority, bool isRatio, CommonComponentDefine.EAttributeType attributeType) : base(id, baseValue, addValue, priority, isRatio, attributeType)
	{
	}

	// Token: 0x06015A75 RID: 88693 RVA: 0x00577810 File Offset: 0x00575A10
	private FormationProperty? GetFormationPropertyConfig()
	{
		FormationProperty? config = ConfigFormationPropertyById.GetConfig(this.Id, true);
		if (config == null)
		{
			return null;
		}
		return new FormationProperty?(config.Value);
	}

	// Token: 0x06015A76 RID: 88694 RVA: 0x0057784C File Offset: 0x00575A4C
	public override string GetName()
	{
		FormationProperty? formationPropertyConfig = this.GetFormationPropertyConfig();
		if (formationPropertyConfig == null)
		{
			return "";
		}
		return formationPropertyConfig.Value.Name;
	}

	// Token: 0x06015A77 RID: 88695 RVA: 0x00577880 File Offset: 0x00575A80
	public override string GetIcon()
	{
		FormationProperty? formationPropertyConfig = this.GetFormationPropertyConfig();
		if (formationPropertyConfig == null)
		{
			return "";
		}
		return formationPropertyConfig.Value.Icon;
	}

	// Token: 0x06015A78 RID: 88696 RVA: 0x005778B4 File Offset: 0x00575AB4
	public override string GetDesc()
	{
		FormationProperty? formationPropertyConfig = this.GetFormationPropertyConfig();
		if (formationPropertyConfig == null)
		{
			return "";
		}
		return formationPropertyConfig.Value.Dec;
	}
}
