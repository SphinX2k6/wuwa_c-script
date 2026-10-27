using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FB2 RID: 8114
public abstract class AttributeItemData : ItemDataBase
{
	// Token: 0x0600FD64 RID: 64868 RVA: 0x003D8AFA File Offset: 0x003D6CFA
	public AttributeItemData(int configId, int uniqueId, int functionValue, InventoryDefine.EItemDataType itemDataType) : base(configId, 1, itemDataType)
	{
		this.UniqueId = uniqueId;
		this.FunctionValue = functionValue;
	}

	// Token: 0x0600FD65 RID: 64869 RVA: 0x003D8B14 File Offset: 0x003D6D14
	public override int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600FD66 RID: 64870 RVA: 0x003D8B1C File Offset: 0x003D6D1C
	public void SetFunctionValue(int functionValue)
	{
		this.FunctionValue = functionValue;
		this.OnSetFunctionValue(functionValue);
	}

	// Token: 0x0600FD67 RID: 64871 RVA: 0x003D8B2C File Offset: 0x003D6D2C
	protected virtual void OnSetFunctionValue(int functionValue)
	{
	}

	// Token: 0x0600FD68 RID: 64872 RVA: 0x003D8B2E File Offset: 0x003D6D2E
	public bool IsFunctionValue(InventoryDefine.EItemDataFunctionType functionType)
	{
		return (this.FunctionValue & 1 << (int)functionType) > 0;
	}

	// Token: 0x0600FD69 RID: 64873 RVA: 0x003D8B40 File Offset: 0x003D6D40
	public override bool GetIsLock()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Lock);
	}

	// Token: 0x0600FD6A RID: 64874 RVA: 0x003D8B49 File Offset: 0x003D6D49
	public override bool GetIsDeprecated()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Deprecate);
	}

	// Token: 0x0600FD6B RID: 64875 RVA: 0x003D8B52 File Offset: 0x003D6D52
	public InventoryDefine.EItemDataFunctionValue GetFunctionValueType()
	{
		return (InventoryDefine.EItemDataFunctionValue)this.FunctionValue;
	}

	// Token: 0x0600FD6C RID: 64876 RVA: 0x003D8B5A File Offset: 0x003D6D5A
	[NullableContext(1)]
	public virtual string GetDefaultDownText()
	{
		return "";
	}

	// Token: 0x0600FD6D RID: 64877 RVA: 0x003D8B61 File Offset: 0x003D6D61
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x0600FD6E RID: 64878 RVA: 0x003D8B64 File Offset: 0x003D6D64
	public override bool HasRedDot()
	{
		int uniqueId = this.GetUniqueId();
		return InventoryModel.Instance.IsAttributeItemHasRedDot(uniqueId);
	}

	// Token: 0x0600FD6F RID: 64879 RVA: 0x003D8B83 File Offset: 0x003D6D83
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x0400758B RID: 30091
	private const int ATTRIBUTE_ITEM_DEFAULT_COUNT = 1;

	// Token: 0x0400758C RID: 30092
	protected readonly int UniqueId;

	// Token: 0x0400758D RID: 30093
	private int FunctionValue;
}
