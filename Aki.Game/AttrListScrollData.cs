using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x020028F7 RID: 10487
[NullableContext(1)]
[Nullable(0)]
public class AttrListScrollData : ScrollViewDataBase
{
	// Token: 0x06015A6F RID: 88687 RVA: 0x00577776 File Offset: 0x00575976
	public AttrListScrollData(int id, double baseValue, double addValue, int priority, bool isRatio, CommonComponentDefine.EAttributeType attributeType)
	{
		this.Id = id;
		this.BaseValue = baseValue;
		this.AddValue = addValue;
		this.Priority = priority;
		this.IsRatio = isRatio;
		this.AttributeType = attributeType;
	}

	// Token: 0x06015A70 RID: 88688 RVA: 0x005777AB File Offset: 0x005759AB
	public virtual string GetName()
	{
		return "";
	}

	// Token: 0x06015A71 RID: 88689 RVA: 0x005777B2 File Offset: 0x005759B2
	public virtual string GetIcon()
	{
		return "";
	}

	// Token: 0x06015A72 RID: 88690 RVA: 0x005777B9 File Offset: 0x005759B9
	public virtual string GetDesc()
	{
		return "";
	}

	// Token: 0x0400A109 RID: 41225
	public int Id;

	// Token: 0x0400A10A RID: 41226
	public double BaseValue;

	// Token: 0x0400A10B RID: 41227
	public double AddValue;

	// Token: 0x0400A10C RID: 41228
	public int Priority;

	// Token: 0x0400A10D RID: 41229
	public bool IsRatio;

	// Token: 0x0400A10E RID: 41230
	public CommonComponentDefine.EAttributeType AttributeType;

	// Token: 0x0400A10F RID: 41231
	public bool IsUnknown;

	// Token: 0x0400A110 RID: 41232
	public int CombineNum;

	// Token: 0x0400A111 RID: 41233
	public bool NeedHighLight;
}
