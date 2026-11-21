using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E74 RID: 7796
[NullableContext(1)]
[Nullable(0)]
public class FormationAttrListScrollData : AttrListScrollData
{
	// Token: 0x06013478 RID: 78968 RVA: 0x005A26CB File Offset: 0x005A08CB
	public FormationAttrListScrollData(int id, double baseValue, double addValue, int priority, bool isRatio, CommonComponentDefine.EAttributeType attributeType) : base(id, baseValue, addValue, priority, isRatio, attributeType)
	{
	}

	// Token: 0x06013479 RID: 78969 RVA: 0x005A26DC File Offset: 0x005A08DC
	private FormationProperty? GetFormationPropertyConfig()
	{
		FormationProperty? config = ConfigFormationPropertyById.GetConfig(this.Id, true);
		if (config == null)
		{
			return null;
		}
		return new FormationProperty?(config.Value);
	}

	// Token: 0x0601347A RID: 78970 RVA: 0x005A2718 File Offset: 0x005A0918
	public override string GetName()
	{
		FormationProperty? formationPropertyConfig = this.GetFormationPropertyConfig();
		if (formationPropertyConfig == null)
		{
			return "";
		}
		return formationPropertyConfig.Value.Name;
	}

	// Token: 0x0601347B RID: 78971 RVA: 0x005A274C File Offset: 0x005A094C
	public override string GetIcon()
	{
		FormationProperty? formationPropertyConfig = this.GetFormationPropertyConfig();
		if (formationPropertyConfig == null)
		{
			return "";
		}
		return formationPropertyConfig.Value.Icon;
	}

	// Token: 0x0601347C RID: 78972 RVA: 0x005A2780 File Offset: 0x005A0980
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
