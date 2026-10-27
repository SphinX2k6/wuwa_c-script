using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020028FA RID: 10490
[NullableContext(1)]
[Nullable(0)]
public class RoleAttrListScrollData : AttrListScrollData
{
	// Token: 0x06015A79 RID: 88697 RVA: 0x005778E6 File Offset: 0x00575AE6
	public RoleAttrListScrollData(int id, double baseValue, double addValue, int priority, bool isRatio, CommonComponentDefine.EAttributeType attributeType) : base(id, baseValue, addValue, priority, isRatio, attributeType)
	{
	}

	// Token: 0x06015A7A RID: 88698 RVA: 0x005778F8 File Offset: 0x00575AF8
	private PropertyIndex GetConfig()
	{
		return PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.Id).Value;
	}

	// Token: 0x06015A7B RID: 88699 RVA: 0x00577920 File Offset: 0x00575B20
	public override string GetName()
	{
		return this.GetConfig().Name;
	}

	// Token: 0x06015A7C RID: 88700 RVA: 0x0057793C File Offset: 0x00575B3C
	public override string GetIcon()
	{
		return this.GetConfig().Icon;
	}

	// Token: 0x06015A7D RID: 88701 RVA: 0x00577958 File Offset: 0x00575B58
	public override string GetDesc()
	{
		return this.GetConfig().Dec;
	}
}
