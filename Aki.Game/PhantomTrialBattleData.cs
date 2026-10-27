using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002402 RID: 9218
[NullableContext(1)]
[Nullable(0)]
public class PhantomTrialBattleData : PhantomBattleData
{
	// Token: 0x06012709 RID: 75529 RVA: 0x0048C97E File Offset: 0x0048AB7E
	public PhantomTrialBattleData()
	{
		this.MainPropValue = new Dictionary<int, AttributeValueData>();
		this.SubPropValueMap = new Dictionary<int, AttributeValueData>();
	}

	// Token: 0x0601270A RID: 75530 RVA: 0x0048C99C File Offset: 0x0048AB9C
	public void SetMainPropValue(int propId, double propValue, bool isRadio)
	{
		AttributeValueData value = new AttributeValueData(propId, propValue, isRadio);
		this.MainPropValue[propId] = value;
	}

	// Token: 0x0601270B RID: 75531 RVA: 0x0048C9C0 File Offset: 0x0048ABC0
	public void SetSubPropValue(int propId, double propValue, bool isRadio)
	{
		AttributeValueData value = new AttributeValueData(propId, propValue, isRadio);
		this.SubPropValueMap[propId] = value;
	}

	// Token: 0x0601270C RID: 75532 RVA: 0x0048C9E3 File Offset: 0x0048ABE3
	public void SetFetterGroupId(int id)
	{
		this.TrailFetterGroup = id;
	}

	// Token: 0x0601270D RID: 75533 RVA: 0x0048C9EC File Offset: 0x0048ABEC
	public override int GetFetterGroupId()
	{
		return this.TrailFetterGroup;
	}

	// Token: 0x0601270E RID: 75534 RVA: 0x0048C9F4 File Offset: 0x0048ABF4
	public void SetSlotIndex(int slot)
	{
		this.SlotIndex = slot;
	}

	// Token: 0x0601270F RID: 75535 RVA: 0x0048C9FD File Offset: 0x0048ABFD
	public bool GetIfMain()
	{
		return this.SlotIndex == 0;
	}

	// Token: 0x06012710 RID: 75536 RVA: 0x0048CA08 File Offset: 0x0048AC08
	public override int GetUniqueId()
	{
		return base.GetIncrId();
	}

	// Token: 0x06012711 RID: 75537 RVA: 0x0048CA10 File Offset: 0x0048AC10
	public Dictionary<int, AttributeValueData> GetMainTrailProp()
	{
		return this.MainPropValue;
	}

	// Token: 0x06012712 RID: 75538 RVA: 0x0048CA18 File Offset: 0x0048AC18
	public Dictionary<int, AttributeValueData> GetSubTrailPropMap()
	{
		return this.SubPropValueMap;
	}

	// Token: 0x06012713 RID: 75539 RVA: 0x0048CA20 File Offset: 0x0048AC20
	[NullableContext(2)]
	public AttributeValueData GetBreachProp()
	{
		return this.BreachPropValue;
	}

	// Token: 0x06012714 RID: 75540 RVA: 0x0048CA28 File Offset: 0x0048AC28
	public override bool IsBreach()
	{
		return true;
	}

	// Token: 0x04008B63 RID: 35683
	private readonly Dictionary<int, AttributeValueData> MainPropValue;

	// Token: 0x04008B64 RID: 35684
	[Nullable(2)]
	private readonly AttributeValueData BreachPropValue;

	// Token: 0x04008B65 RID: 35685
	private readonly Dictionary<int, AttributeValueData> SubPropValueMap;

	// Token: 0x04008B66 RID: 35686
	private int SlotIndex;

	// Token: 0x04008B67 RID: 35687
	private int TrailFetterGroup;
}
