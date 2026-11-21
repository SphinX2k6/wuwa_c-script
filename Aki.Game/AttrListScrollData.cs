using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x02001E72 RID: 7794
[NullableContext(1)]
[Nullable(0)]
public class AttrListScrollData : ScrollViewDataBase
{
	// Token: 0x06013473 RID: 78963 RVA: 0x005A2642 File Offset: 0x005A0842
	public AttrListScrollData(int id, double baseValue, double addValue, int priority, bool isRatio, CommonComponentDefine.EAttributeType attributeType)
	{
		this.Id = id;
		this.BaseValue = baseValue;
		this.AddValue = addValue;
		this.Priority = priority;
		this.IsRatio = isRatio;
		this.AttributeType = attributeType;
	}

	// Token: 0x06013474 RID: 78964 RVA: 0x005A2677 File Offset: 0x005A0877
	public virtual string GetName()
	{
		return "";
	}

	// Token: 0x06013475 RID: 78965 RVA: 0x005A267E File Offset: 0x005A087E
	public virtual string GetIcon()
	{
		return "";
	}

	// Token: 0x06013476 RID: 78966 RVA: 0x005A2685 File Offset: 0x005A0885
	public virtual string GetDesc()
	{
		return "";
	}

	// Token: 0x0400A4F4 RID: 42228
	public int Id;

	// Token: 0x0400A4F5 RID: 42229
	public double BaseValue;

	// Token: 0x0400A4F6 RID: 42230
	public double AddValue;

	// Token: 0x0400A4F7 RID: 42231
	public int Priority;

	// Token: 0x0400A4F8 RID: 42232
	public bool IsRatio;

	// Token: 0x0400A4F9 RID: 42233
	public CommonComponentDefine.EAttributeType AttributeType;

	// Token: 0x0400A4FA RID: 42234
	public bool IsUnknown;

	// Token: 0x0400A4FB RID: 42235
	public int CombineNum;

	// Token: 0x0400A4FC RID: 42236
	public bool NeedHighLight;
}
