using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E75 RID: 7797
[NullableContext(1)]
[Nullable(0)]
public class RoleAttrListScrollData : AttrListScrollData
{
	// Token: 0x0601347D RID: 78973 RVA: 0x005A27B2 File Offset: 0x005A09B2
	public RoleAttrListScrollData(int id, double baseValue, double addValue, int priority, bool isRatio, CommonComponentDefine.EAttributeType attributeType) : base(id, baseValue, addValue, priority, isRatio, attributeType)
	{
	}

	// Token: 0x0601347E RID: 78974 RVA: 0x005A27C4 File Offset: 0x005A09C4
	private PropertyIndex GetConfig()
	{
		return PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.Id).Value;
	}

	// Token: 0x0601347F RID: 78975 RVA: 0x005A27EC File Offset: 0x005A09EC
	public override string GetName()
	{
		return this.GetConfig().Name;
	}

	// Token: 0x06013480 RID: 78976 RVA: 0x005A2808 File Offset: 0x005A0A08
	public override string GetIcon()
	{
		return this.GetConfig().Icon;
	}

	// Token: 0x06013481 RID: 78977 RVA: 0x005A2824 File Offset: 0x005A0A24
	public override string GetDesc()
	{
		return this.GetConfig().Dec;
	}
}
