using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001474 RID: 5236
public abstract class AttributeItemData : ItemDataBase
{
	// Token: 0x0600D18A RID: 53642 RVA: 0x003E44D6 File Offset: 0x003E26D6
	public AttributeItemData(int configId, int uniqueId, int functionValue, InventoryDefine.EItemDataType itemDataType) : base(configId, 1, itemDataType)
	{
		this.UniqueId = uniqueId;
		this.FunctionValue = functionValue;
	}

	// Token: 0x0600D18B RID: 53643 RVA: 0x003E44F0 File Offset: 0x003E26F0
	public override int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600D18C RID: 53644 RVA: 0x003E44F8 File Offset: 0x003E26F8
	public void SetFunctionValue(int functionValue)
	{
		this.FunctionValue = functionValue;
		this.OnSetFunctionValue(functionValue);
	}

	// Token: 0x0600D18D RID: 53645 RVA: 0x003E4508 File Offset: 0x003E2708
	protected virtual void OnSetFunctionValue(int functionValue)
	{
	}

	// Token: 0x0600D18E RID: 53646 RVA: 0x003E450A File Offset: 0x003E270A
	public bool IsFunctionValue(InventoryDefine.EItemDataFunctionType functionType)
	{
		return (this.FunctionValue & 1 << (int)functionType) > 0;
	}

	// Token: 0x0600D18F RID: 53647 RVA: 0x003E451C File Offset: 0x003E271C
	public override bool GetIsLock()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Lock);
	}

	// Token: 0x0600D190 RID: 53648 RVA: 0x003E4525 File Offset: 0x003E2725
	public override bool GetIsDeprecated()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Deprecate);
	}

	// Token: 0x0600D191 RID: 53649 RVA: 0x003E452E File Offset: 0x003E272E
	public InventoryDefine.EItemDataFunctionValue GetFunctionValueType()
	{
		return (InventoryDefine.EItemDataFunctionValue)this.FunctionValue;
	}

	// Token: 0x0600D192 RID: 53650 RVA: 0x003E4536 File Offset: 0x003E2736
	[NullableContext(1)]
	public virtual string GetDefaultDownText()
	{
		return "";
	}

	// Token: 0x0600D193 RID: 53651 RVA: 0x003E453D File Offset: 0x003E273D
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x0600D194 RID: 53652 RVA: 0x003E4540 File Offset: 0x003E2740
	public override bool HasRedDot()
	{
		int uniqueId = this.GetUniqueId();
		return InventoryModel.Instance.IsAttributeItemHasRedDot(uniqueId);
	}

	// Token: 0x0600D195 RID: 53653 RVA: 0x003E455F File Offset: 0x003E275F
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x0400766D RID: 30317
	private const int ATTRIBUTE_ITEM_DEFAULT_COUNT = 1;

	// Token: 0x0400766E RID: 30318
	protected readonly int UniqueId;

	// Token: 0x0400766F RID: 30319
	private int FunctionValue;
}
