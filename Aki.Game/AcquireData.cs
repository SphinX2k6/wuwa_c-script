using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02000F36 RID: 3894
[NullableContext(2)]
[Nullable(0)]
public class AcquireData : UiPopViewData
{
	// Token: 0x060062D8 RID: 25304 RVA: 0x00135B68 File Offset: 0x00133D68
	public void SetAcquireViewType(EAcquireViewType acquireViewType)
	{
		this.AcquireViewType = acquireViewType;
	}

	// Token: 0x060062D9 RID: 25305 RVA: 0x00135B71 File Offset: 0x00133D71
	public EAcquireViewType GetAcquireViewType()
	{
		return this.AcquireViewType;
	}

	// Token: 0x060062DA RID: 25306 RVA: 0x00135B79 File Offset: 0x00133D79
	public void SetAmount(int amount)
	{
		this.Amount = amount;
	}

	// Token: 0x060062DB RID: 25307 RVA: 0x00135B82 File Offset: 0x00133D82
	public int GetAmount()
	{
		return this.Amount;
	}

	// Token: 0x060062DC RID: 25308 RVA: 0x00135B8A File Offset: 0x00133D8A
	public void SetMaxAmount(int maxAmount)
	{
		this.MaxAmount = maxAmount;
	}

	// Token: 0x060062DD RID: 25309 RVA: 0x00135B93 File Offset: 0x00133D93
	public void SetConfigId(int id)
	{
		this.ConfigId = id;
	}

	// Token: 0x060062DE RID: 25310 RVA: 0x00135B9C File Offset: 0x00133D9C
	public int GetMaxAmount()
	{
		return this.MaxAmount;
	}

	// Token: 0x060062DF RID: 25311 RVA: 0x00135BA4 File Offset: 0x00133DA4
	[NullableContext(1)]
	public void SetLeftButtonFunction(Func<UniTask> leftButtonFunction)
	{
		this.LeftButtonFunction = leftButtonFunction;
	}

	// Token: 0x060062E0 RID: 25312 RVA: 0x00135BAD File Offset: 0x00133DAD
	[NullableContext(1)]
	public void SetRightButtonFunction(Func<UniTask> rightButtonFunction)
	{
		this.RightButtonFunction = rightButtonFunction;
	}

	// Token: 0x060062E1 RID: 25313 RVA: 0x00135BB6 File Offset: 0x00133DB6
	[NullableContext(1)]
	public void SetMidButtonFunction(Func<UniTask> midButtonFunction)
	{
		this.MidButtonFunction = midButtonFunction;
	}

	// Token: 0x060062E2 RID: 25314 RVA: 0x00135BBF File Offset: 0x00133DBF
	public Func<UniTask> GetLeftButtonFunction()
	{
		return this.LeftButtonFunction;
	}

	// Token: 0x060062E3 RID: 25315 RVA: 0x00135BC7 File Offset: 0x00133DC7
	public Func<UniTask> GetRightButtonFunction()
	{
		return this.RightButtonFunction;
	}

	// Token: 0x060062E4 RID: 25316 RVA: 0x00135BCF File Offset: 0x00133DCF
	public Func<UniTask> GetMidButtonFunction()
	{
		return this.MidButtonFunction;
	}

	// Token: 0x060062E5 RID: 25317 RVA: 0x00135BD7 File Offset: 0x00133DD7
	[NullableContext(1)]
	public void SetItemData(List<TItem> itemDataList)
	{
		this.ItemDataList = itemDataList;
	}

	// Token: 0x060062E6 RID: 25318 RVA: 0x00135BE0 File Offset: 0x00133DE0
	public List<TItem> GetItemData()
	{
		return this.ItemDataList;
	}

	// Token: 0x060062E7 RID: 25319 RVA: 0x00135BE8 File Offset: 0x00133DE8
	[NullableContext(1)]
	public void SetLeftButtonTextTableId(string id)
	{
		this.LeftButtonTextTableId = id;
	}

	// Token: 0x060062E8 RID: 25320 RVA: 0x00135BF1 File Offset: 0x00133DF1
	[NullableContext(1)]
	public string GetLeftButtonTextTableId()
	{
		return this.LeftButtonTextTableId;
	}

	// Token: 0x060062E9 RID: 25321 RVA: 0x00135BF9 File Offset: 0x00133DF9
	[NullableContext(1)]
	public void SetRightButtonTextTableId(string id)
	{
		this.RightButtonTextTableId = id;
	}

	// Token: 0x060062EA RID: 25322 RVA: 0x00135C02 File Offset: 0x00133E02
	[NullableContext(1)]
	public string GetRightButtonTextTableId()
	{
		return this.RightButtonTextTableId;
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x00135C0A File Offset: 0x00133E0A
	public void SetRemainItemCount(int count)
	{
		this.RemainItemCount = count;
	}

	// Token: 0x060062EC RID: 25324 RVA: 0x00135C13 File Offset: 0x00133E13
	public int GetRemainItemCount()
	{
		return this.RemainItemCount;
	}

	// Token: 0x060062ED RID: 25325 RVA: 0x00135C1B File Offset: 0x00133E1B
	[NullableContext(1)]
	public void SetNameText(string name)
	{
		this.NameText = name;
	}

	// Token: 0x060062EE RID: 25326 RVA: 0x00135C24 File Offset: 0x00133E24
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x060062EF RID: 25327 RVA: 0x00135C2C File Offset: 0x00133E2C
	[NullableContext(1)]
	public string GetNameText()
	{
		return this.NameText;
	}

	// Token: 0x04002CD1 RID: 11473
	private EAcquireViewType AcquireViewType;

	// Token: 0x04002CD2 RID: 11474
	private int Amount;

	// Token: 0x04002CD3 RID: 11475
	private int MaxAmount;

	// Token: 0x04002CD4 RID: 11476
	private Func<UniTask> LeftButtonFunction;

	// Token: 0x04002CD5 RID: 11477
	private Func<UniTask> RightButtonFunction;

	// Token: 0x04002CD6 RID: 11478
	private Func<UniTask> MidButtonFunction;

	// Token: 0x04002CD7 RID: 11479
	private string LeftButtonTextTableId;

	// Token: 0x04002CD8 RID: 11480
	private string RightButtonTextTableId;

	// Token: 0x04002CD9 RID: 11481
	private List<TItem> ItemDataList;

	// Token: 0x04002CDA RID: 11482
	private int RemainItemCount;

	// Token: 0x04002CDB RID: 11483
	private string NameText;

	// Token: 0x04002CDC RID: 11484
	private int ConfigId;
}
