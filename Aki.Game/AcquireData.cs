using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x020003EB RID: 1003
[NullableContext(2)]
[Nullable(0)]
public class AcquireData : UiPopViewData
{
	// Token: 0x06003670 RID: 13936 RVA: 0x0013E490 File Offset: 0x0013C690
	public void SetAcquireViewType(EAcquireViewType acquireViewType)
	{
		this.AcquireViewType = acquireViewType;
	}

	// Token: 0x06003671 RID: 13937 RVA: 0x0013E499 File Offset: 0x0013C699
	public EAcquireViewType GetAcquireViewType()
	{
		return this.AcquireViewType;
	}

	// Token: 0x06003672 RID: 13938 RVA: 0x0013E4A1 File Offset: 0x0013C6A1
	public void SetAmount(int amount)
	{
		this.Amount = amount;
	}

	// Token: 0x06003673 RID: 13939 RVA: 0x0013E4AA File Offset: 0x0013C6AA
	public int GetAmount()
	{
		return this.Amount;
	}

	// Token: 0x06003674 RID: 13940 RVA: 0x0013E4B2 File Offset: 0x0013C6B2
	public void SetMaxAmount(int maxAmount)
	{
		this.MaxAmount = maxAmount;
	}

	// Token: 0x06003675 RID: 13941 RVA: 0x0013E4BB File Offset: 0x0013C6BB
	public void SetConfigId(int id)
	{
		this.ConfigId = id;
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x0013E4C4 File Offset: 0x0013C6C4
	public int GetMaxAmount()
	{
		return this.MaxAmount;
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x0013E4CC File Offset: 0x0013C6CC
	[NullableContext(1)]
	public void SetLeftButtonFunction(Func<UniTask> leftButtonFunction)
	{
		this.LeftButtonFunction = leftButtonFunction;
	}

	// Token: 0x06003678 RID: 13944 RVA: 0x0013E4D5 File Offset: 0x0013C6D5
	[NullableContext(1)]
	public void SetRightButtonFunction(Func<UniTask> rightButtonFunction)
	{
		this.RightButtonFunction = rightButtonFunction;
	}

	// Token: 0x06003679 RID: 13945 RVA: 0x0013E4DE File Offset: 0x0013C6DE
	[NullableContext(1)]
	public void SetMidButtonFunction(Func<UniTask> midButtonFunction)
	{
		this.MidButtonFunction = midButtonFunction;
	}

	// Token: 0x0600367A RID: 13946 RVA: 0x0013E4E7 File Offset: 0x0013C6E7
	public Func<UniTask> GetLeftButtonFunction()
	{
		return this.LeftButtonFunction;
	}

	// Token: 0x0600367B RID: 13947 RVA: 0x0013E4EF File Offset: 0x0013C6EF
	public Func<UniTask> GetRightButtonFunction()
	{
		return this.RightButtonFunction;
	}

	// Token: 0x0600367C RID: 13948 RVA: 0x0013E4F7 File Offset: 0x0013C6F7
	public Func<UniTask> GetMidButtonFunction()
	{
		return this.MidButtonFunction;
	}

	// Token: 0x0600367D RID: 13949 RVA: 0x0013E4FF File Offset: 0x0013C6FF
	[NullableContext(1)]
	public void SetItemData(List<TItem> itemDataList)
	{
		this.ItemDataList = itemDataList;
	}

	// Token: 0x0600367E RID: 13950 RVA: 0x0013E508 File Offset: 0x0013C708
	public List<TItem> GetItemData()
	{
		return this.ItemDataList;
	}

	// Token: 0x0600367F RID: 13951 RVA: 0x0013E510 File Offset: 0x0013C710
	[NullableContext(1)]
	public void SetLeftButtonTextTableId(string id)
	{
		this.LeftButtonTextTableId = id;
	}

	// Token: 0x06003680 RID: 13952 RVA: 0x0013E519 File Offset: 0x0013C719
	[NullableContext(1)]
	public string GetLeftButtonTextTableId()
	{
		return this.LeftButtonTextTableId;
	}

	// Token: 0x06003681 RID: 13953 RVA: 0x0013E521 File Offset: 0x0013C721
	[NullableContext(1)]
	public void SetRightButtonTextTableId(string id)
	{
		this.RightButtonTextTableId = id;
	}

	// Token: 0x06003682 RID: 13954 RVA: 0x0013E52A File Offset: 0x0013C72A
	[NullableContext(1)]
	public string GetRightButtonTextTableId()
	{
		return this.RightButtonTextTableId;
	}

	// Token: 0x06003683 RID: 13955 RVA: 0x0013E532 File Offset: 0x0013C732
	public void SetRemainItemCount(int count)
	{
		this.RemainItemCount = count;
	}

	// Token: 0x06003684 RID: 13956 RVA: 0x0013E53B File Offset: 0x0013C73B
	public int GetRemainItemCount()
	{
		return this.RemainItemCount;
	}

	// Token: 0x06003685 RID: 13957 RVA: 0x0013E543 File Offset: 0x0013C743
	[NullableContext(1)]
	public void SetNameText(string name)
	{
		this.NameText = name;
	}

	// Token: 0x06003686 RID: 13958 RVA: 0x0013E54C File Offset: 0x0013C74C
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x06003687 RID: 13959 RVA: 0x0013E554 File Offset: 0x0013C754
	[NullableContext(1)]
	public string GetNameText()
	{
		return this.NameText;
	}

	// Token: 0x04002D6A RID: 11626
	private EAcquireViewType AcquireViewType;

	// Token: 0x04002D6B RID: 11627
	private int Amount;

	// Token: 0x04002D6C RID: 11628
	private int MaxAmount;

	// Token: 0x04002D6D RID: 11629
	private Func<UniTask> LeftButtonFunction;

	// Token: 0x04002D6E RID: 11630
	private Func<UniTask> RightButtonFunction;

	// Token: 0x04002D6F RID: 11631
	private Func<UniTask> MidButtonFunction;

	// Token: 0x04002D70 RID: 11632
	private string LeftButtonTextTableId;

	// Token: 0x04002D71 RID: 11633
	private string RightButtonTextTableId;

	// Token: 0x04002D72 RID: 11634
	private List<TItem> ItemDataList;

	// Token: 0x04002D73 RID: 11635
	private int RemainItemCount;

	// Token: 0x04002D74 RID: 11636
	private string NameText;

	// Token: 0x04002D75 RID: 11637
	private int ConfigId;
}
