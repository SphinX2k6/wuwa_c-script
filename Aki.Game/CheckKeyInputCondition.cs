using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C93 RID: 3219
[NullableContext(1)]
[Nullable(0)]
public class CheckKeyInputCondition : BaseCheckCondition
{
	// Token: 0x06008666 RID: 34406 RVA: 0x0028F568 File Offset: 0x0028D768
	public CheckKeyInputCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.FailType = EComboTeachingFailCondition.PressKey;
		this.SuccessType = EComboTeachingSuccessCondition.PressKey;
	}

	// Token: 0x17000F30 RID: 3888
	// (get) Token: 0x06008667 RID: 34407 RVA: 0x0028F597 File Offset: 0x0028D797
	// (set) Token: 0x06008668 RID: 34408 RVA: 0x0028F59F File Offset: 0x0028D79F
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F31 RID: 3889
	// (get) Token: 0x06008669 RID: 34409 RVA: 0x0028F5A8 File Offset: 0x0028D7A8
	// (set) Token: 0x0600866A RID: 34410 RVA: 0x0028F5B0 File Offset: 0x0028D7B0
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.PressKey;

	// Token: 0x17000F32 RID: 3890
	// (get) Token: 0x0600866B RID: 34411 RVA: 0x0028F5B9 File Offset: 0x0028D7B9
	// (set) Token: 0x0600866C RID: 34412 RVA: 0x0028F5C1 File Offset: 0x0028D7C1
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.PressKey;

	// Token: 0x0600866D RID: 34413 RVA: 0x0028F5CC File Offset: 0x0028D7CC
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

	// Token: 0x0600866E RID: 34414 RVA: 0x0028F654 File Offset: 0x0028D854
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
