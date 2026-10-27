using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020017CB RID: 6091
[NullableContext(1)]
[Nullable(0)]
public class BaseCheckCondition
{
	// Token: 0x17000EEB RID: 3819
	// (get) Token: 0x0600B215 RID: 45589 RVA: 0x00284285 File Offset: 0x00282485
	// (set) Token: 0x0600B216 RID: 45590 RVA: 0x0028428D File Offset: 0x0028248D
	public virtual EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000EEC RID: 3820
	// (get) Token: 0x0600B217 RID: 45591 RVA: 0x00284296 File Offset: 0x00282496
	// (set) Token: 0x0600B218 RID: 45592 RVA: 0x0028429E File Offset: 0x0028249E
	protected virtual EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.Base;

	// Token: 0x17000EED RID: 3821
	// (get) Token: 0x0600B219 RID: 45593 RVA: 0x002842A7 File Offset: 0x002824A7
	// (set) Token: 0x0600B21A RID: 45594 RVA: 0x002842AF File Offset: 0x002824AF
	protected virtual EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.Base;

	// Token: 0x0600B21B RID: 45595 RVA: 0x002842B8 File Offset: 0x002824B8
	public int GetConditionType()
	{
		if (!this.IsSuccessNode)
		{
			return (int)this.FailType;
		}
		return (int)this.SuccessType;
	}

	// Token: 0x0600B21C RID: 45596 RVA: 0x002842D0 File Offset: 0x002824D0
	public BaseCheckCondition(string paramsString, bool isSuccessNode)
	{
		this.OriginString = paramsString;
		this.IsSuccessNode = isSuccessNode;
		if (paramsString != null && paramsString.Length > 0)
		{
			if (isSuccessNode)
			{
				foreach (string text in paramsString.Substring(1, paramsString.Length - 2).Split('#', StringSplitOptions.None))
				{
					if (this.SuccessParamsArray == null)
					{
						this.SuccessParamsArray = new List<List<string>>();
					}
					string[] collection = text.Split(',', StringSplitOptions.None);
					this.SuccessParamsArray.Add(new List<string>(collection));
				}
				return;
			}
			this.ParamsArray = new List<string>(paramsString.Split('#', StringSplitOptions.None));
		}
	}

	// Token: 0x0600B21D RID: 45597 RVA: 0x00284384 File Offset: 0x00282584
	public virtual bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (!this.IsSuccessNode)
		{
			return this.CheckFail(data, param);
		}
		return this.CheckSuccess(data, param);
	}

	// Token: 0x0600B21E RID: 45598 RVA: 0x0028439F File Offset: 0x0028259F
	protected virtual bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return false;
	}

	// Token: 0x0600B21F RID: 45599 RVA: 0x002843A2 File Offset: 0x002825A2
	protected virtual bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return false;
	}

	// Token: 0x040050CD RID: 20685
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> ParamsArray;

	// Token: 0x040050CE RID: 20686
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public List<List<string>> SuccessParamsArray;

	// Token: 0x040050CF RID: 20687
	public string OriginString = "";

	// Token: 0x040050D1 RID: 20689
	protected bool IsSuccessNode;
}
