using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C94 RID: 3220
[NullableContext(1)]
[Nullable(0)]
public class CheckKeyHoldingCondition : BaseCheckCondition
{
	// Token: 0x0600866F RID: 34415 RVA: 0x0028F6FF File Offset: 0x0028D8FF
	public CheckKeyHoldingCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.FailType = EComboTeachingFailCondition.HoldKey;
		this.SuccessType = EComboTeachingSuccessCondition.HoldKey;
	}

	// Token: 0x17000F33 RID: 3891
	// (get) Token: 0x06008670 RID: 34416 RVA: 0x0028F72E File Offset: 0x0028D92E
	// (set) Token: 0x06008671 RID: 34417 RVA: 0x0028F736 File Offset: 0x0028D936
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F34 RID: 3892
	// (get) Token: 0x06008672 RID: 34418 RVA: 0x0028F73F File Offset: 0x0028D93F
	// (set) Token: 0x06008673 RID: 34419 RVA: 0x0028F747 File Offset: 0x0028D947
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.HoldKey;

	// Token: 0x17000F35 RID: 3893
	// (get) Token: 0x06008674 RID: 34420 RVA: 0x0028F750 File Offset: 0x0028D950
	// (set) Token: 0x06008675 RID: 34421 RVA: 0x0028F758 File Offset: 0x0028D958
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.HoldKey;

	// Token: 0x06008676 RID: 34422 RVA: 0x0028F764 File Offset: 0x0028D964
	protected override bool CheckFail(IComboTeachingInfo node, [Nullable(2)] IBaseCheckConditionInfo extra = null)
	{
		ICheckKeyCondition checkKeyCondition = extra as ICheckKeyCondition;
		if (this.ParamsArray == null || checkKeyCondition == null)
		{
			return false;
		}
		string b;
		if (!ComboTeachingDefine.inputActionMap.TryGetValue(checkKeyCondition.ActionKey, out b))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ComboTeaching;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "未找到按键条件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionKey", checkKeyCondition.ActionKey);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return int.Parse(this.ParamsArray[1]) == 2 && this.ParamsArray[0] == b && float.Parse(this.ParamsArray[2]) <= checkKeyCondition.HoldTime.GetValueOrDefault();
	}

	// Token: 0x06008677 RID: 34423 RVA: 0x0028F820 File Offset: 0x0028DA20
	protected override bool CheckSuccess(IComboTeachingInfo node, [Nullable(2)] IBaseCheckConditionInfo extra = null)
	{
		ICheckKeyCondition checkKeyCondition = extra as ICheckKeyCondition;
		if (checkKeyCondition == null)
		{
			return false;
		}
		string a;
		if (!ComboTeachingDefine.inputActionMap.TryGetValue(checkKeyCondition.ActionKey, out a))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ComboTeaching;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "未找到按键条件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionKey", checkKeyCondition.ActionKey);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return a == node.ActionInfo && node.HoldTotalTime <= checkKeyCondition.HoldTime.GetValueOrDefault();
	}
}
