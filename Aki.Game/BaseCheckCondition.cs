using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;

// Token: 0x02000C84 RID: 3204
[NullableContext(1)]
[Nullable(0)]
public class BaseCheckCondition
{
	// Token: 0x17000F0E RID: 3854
	// (get) Token: 0x060085FD RID: 34301 RVA: 0x0028E971 File Offset: 0x0028CB71
	// (set) Token: 0x060085FE RID: 34302 RVA: 0x0028E979 File Offset: 0x0028CB79
	public virtual EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F0F RID: 3855
	// (get) Token: 0x060085FF RID: 34303 RVA: 0x0028E982 File Offset: 0x0028CB82
	// (set) Token: 0x06008600 RID: 34304 RVA: 0x0028E98A File Offset: 0x0028CB8A
	protected virtual EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.Base;

	// Token: 0x17000F10 RID: 3856
	// (get) Token: 0x06008601 RID: 34305 RVA: 0x0028E993 File Offset: 0x0028CB93
	// (set) Token: 0x06008602 RID: 34306 RVA: 0x0028E99B File Offset: 0x0028CB9B
	protected virtual EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.Base;

	// Token: 0x06008603 RID: 34307 RVA: 0x0028E9A4 File Offset: 0x0028CBA4
	public int GetConditionType()
	{
		if (!this.IsSuccessNode)
		{
			return (int)this.FailType;
		}
		return (int)this.SuccessType;
	}

	// Token: 0x06008604 RID: 34308 RVA: 0x0028E9BC File Offset: 0x0028CBBC
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

	// Token: 0x06008605 RID: 34309 RVA: 0x0028EA70 File Offset: 0x0028CC70
	public virtual bool Check(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		if (!this.IsSuccessNode)
		{
			return this.CheckFail(data, param);
		}
		return this.CheckSuccess(data, param);
	}

	// Token: 0x06008606 RID: 34310 RVA: 0x0028EA8B File Offset: 0x0028CC8B
	protected virtual bool CheckSuccess(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return false;
	}

	// Token: 0x06008607 RID: 34311 RVA: 0x0028EA8E File Offset: 0x0028CC8E
	protected virtual bool CheckFail(IComboTeachingInfo data, [Nullable(2)] IBaseCheckConditionInfo param = null)
	{
		return false;
	}

	// Token: 0x06008608 RID: 34312 RVA: 0x0028EA94 File Offset: 0x0028CC94
	[NullableContext(0)]
	[return: Nullable(2)]
	protected static T GetPlayerComponent<T>() where T : EntityComponent
	{
		int entityIdNoBlueprint = Global.BaseCharacter.GetEntityIdNoBlueprint();
		return EntitySystem.Instance.GetComponent<T>(entityIdNoBlueprint);
	}

	// Token: 0x04005178 RID: 20856
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> ParamsArray;

	// Token: 0x04005179 RID: 20857
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public List<List<string>> SuccessParamsArray;

	// Token: 0x0400517A RID: 20858
	public string OriginString = "";

	// Token: 0x0400517C RID: 20860
	protected bool IsSuccessNode;
}
