using System;
using System.Runtime.CompilerServices;

// Token: 0x020017DB RID: 6107
[NullableContext(1)]
[Nullable(0)]
public class CheckKeyHoldingCondition : BaseCheckCondition
{
	// Token: 0x0600B286 RID: 45702 RVA: 0x00285153 File Offset: 0x00283353
	public CheckKeyHoldingCondition(string paramsString, bool isSuccessNode) : base(paramsString, isSuccessNode)
	{
		this.Type = EComboTeachingCheckType.Event;
		this.FailType = EComboTeachingFailCondition.HoldKey;
		this.SuccessType = EComboTeachingSuccessCondition.HoldKey;
	}

	// Token: 0x17000F10 RID: 3856
	// (get) Token: 0x0600B287 RID: 45703 RVA: 0x00285182 File Offset: 0x00283382
	// (set) Token: 0x0600B288 RID: 45704 RVA: 0x0028518A File Offset: 0x0028338A
	public override EComboTeachingCheckType Type { get; set; }

	// Token: 0x17000F11 RID: 3857
	// (get) Token: 0x0600B289 RID: 45705 RVA: 0x00285193 File Offset: 0x00283393
	// (set) Token: 0x0600B28A RID: 45706 RVA: 0x0028519B File Offset: 0x0028339B
	protected override EComboTeachingFailCondition FailType { get; set; } = EComboTeachingFailCondition.HoldKey;

	// Token: 0x17000F12 RID: 3858
	// (get) Token: 0x0600B28B RID: 45707 RVA: 0x002851A4 File Offset: 0x002833A4
	// (set) Token: 0x0600B28C RID: 45708 RVA: 0x002851AC File Offset: 0x002833AC
	protected override EComboTeachingSuccessCondition SuccessType { get; set; } = EComboTeachingSuccessCondition.HoldKey;

	// Token: 0x0600B28D RID: 45709 RVA: 0x002851B8 File Offset: 0x002833B8
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

	// Token: 0x0600B28E RID: 45710 RVA: 0x00285274 File Offset: 0x00283474
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
