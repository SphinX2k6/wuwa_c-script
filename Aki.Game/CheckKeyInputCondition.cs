using System;
using System.Runtime.CompilerServices;

// Token: 0x020017DA RID: 6106
[NullableContext(1)]
[Nullable(0)]
public class CheckKeyInputCondition : BaseCheckCondition
{
	// Token: 0x0600B27D RID: 45693 RVA: 0x00284FBC File Offset: 0x002831BC
	public CheckKeyInputCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.FailType = EComboTeachingFailCondition.PressKey;
		this.SuccessType = EComboTeachingSuccessCondition.PressKey;
	}

	// Token: 0x17000F0D RID: 3853
	// (get) Token: 0x0600B27E RID: 45694 RVA: 0x00284FEB File Offset: 0x002831EB
	// (set) Token: 0x0600B27F RID: 45695 RVA: 0x00284FF3 File Offset: 0x002831F3
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F0E RID: 3854
	// (get) Token: 0x0600B280 RID: 45696 RVA: 0x00284FFC File Offset: 0x002831FC
	// (set) Token: 0x0600B281 RID: 45697 RVA: 0x00285004 File Offset: 0x00283204
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.PressKey;

	// Token: 0x17000F0F RID: 3855
	// (get) Token: 0x0600B282 RID: 45698 RVA: 0x0028500D File Offset: 0x0028320D
	// (set) Token: 0x0600B283 RID: 45699 RVA: 0x00285015 File Offset: 0x00283215
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.PressKey;

	// Token: 0x0600B284 RID: 45700 RVA: 0x00285020 File Offset: 0x00283220
	protected override bool CheckFail(IComboTeachingInfo node, [Nullable(2)] IBaseCheckConditionInfo extra = null)
	{
		ICheckKeyCondition checkKeyCondition = extra as ICheckKeyCondition;
		if (this.ParamsArray == null || checkKeyCondition == null || checkKeyCondition.ActionType == EComboKeyType.Hold)
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
		return this.ParamsArray[0] == b;
	}

	// Token: 0x0600B285 RID: 45701 RVA: 0x002850A8 File Offset: 0x002832A8
	protected override bool CheckSuccess(IComboTeachingInfo node, [Nullable(2)] IBaseCheckConditionInfo extra = null)
	{
		ICheckKeyCondition checkKeyCondition = extra as ICheckKeyCondition;
		if (checkKeyCondition == null || checkKeyCondition.ActionType == EComboKeyType.Hold)
		{
			return false;
		}
		if (this.SuccessParamsArray == null)
		{
			if (checkKeyCondition.ActionType != EComboKeyType.Press)
			{
				return false;
			}
		}
		else if (checkKeyCondition.ActionType != (EComboKeyType)int.Parse(this.SuccessParamsArray[0][0]))
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
		return a == node.ActionInfo;
	}
}
