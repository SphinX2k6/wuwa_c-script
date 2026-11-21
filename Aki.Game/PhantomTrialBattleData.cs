using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020018E7 RID: 6375
[NullableContext(1)]
[Nullable(0)]
public class PhantomTrialBattleData : PhantomBattleData
{
	// Token: 0x0600FBBB RID: 64443 RVA: 0x00499E8E File Offset: 0x0049808E
	public PhantomTrialBattleData()
	{
		this.MainPropValue = new Dictionary<int, AttributeValueData>();
		this.SubPropValueMap = new Dictionary<int, AttributeValueData>();
	}

	// Token: 0x0600FBBC RID: 64444 RVA: 0x00499EAC File Offset: 0x004980AC
	public void SetMainPropValue(int propId, double propValue, bool isRadio)
	{
		AttributeValueData value = new AttributeValueData(propId, propValue, isRadio);
		this.MainPropValue[propId] = value;
	}

	// Token: 0x0600FBBD RID: 64445 RVA: 0x00499ED0 File Offset: 0x004980D0
	public void SetSubPropValue(int propId, double propValue, bool isRadio)
	{
		AttributeValueData value = new AttributeValueData(propId, propValue, isRadio);
		this.SubPropValueMap[propId] = value;
	}

	// Token: 0x0600FBBE RID: 64446 RVA: 0x00499EF3 File Offset: 0x004980F3
	public void SetFetterGroupId(int id)
	{
		this.TrailFetterGroup = id;
	}

	// Token: 0x0600FBBF RID: 64447 RVA: 0x00499EFC File Offset: 0x004980FC
	public override int GetFetterGroupId()
	{
		return this.TrailFetterGroup;
	}

	// Token: 0x0600FBC0 RID: 64448 RVA: 0x00499F04 File Offset: 0x00498104
	public void SetSlotIndex(int slot)
	{
		this.SlotIndex = slot;
	}

	// Token: 0x0600FBC1 RID: 64449 RVA: 0x00499F0D File Offset: 0x0049810D
	public bool GetIfMain()
	{
		return this.SlotIndex == 0;
	}

	// Token: 0x0600FBC2 RID: 64450 RVA: 0x00499F18 File Offset: 0x00498118
	public override int GetUniqueId()
	{
		return base.GetIncrId();
	}

	// Token: 0x0600FBC3 RID: 64451 RVA: 0x00499F20 File Offset: 0x00498120
	public Dictionary<int, AttributeValueData> GetMainTrailProp()
	{
		return this.MainPropValue;
	}

	// Token: 0x0600FBC4 RID: 64452 RVA: 0x00499F28 File Offset: 0x00498128
	public Dictionary<int, AttributeValueData> GetSubTrailPropMap()
	{
		return this.SubPropValueMap;
	}

	// Token: 0x0600FBC5 RID: 64453 RVA: 0x00499F30 File Offset: 0x00498130
	[NullableContext(2)]
	public AttributeValueData GetBreachProp()
	{
		return this.BreachPropValue;
	}

	// Token: 0x0600FBC6 RID: 64454 RVA: 0x00499F38 File Offset: 0x00498138
	public override bool IsBreach()
	{
		return true;
	}

	// Token: 0x04008CAA RID: 36010
	private readonly Dictionary<int, AttributeValueData> MainPropValue;

	// Token: 0x04008CAB RID: 36011
	[Nullable(2)]
	private readonly AttributeValueData BreachPropValue;

	// Token: 0x04008CAC RID: 36012
	private readonly Dictionary<int, AttributeValueData> SubPropValueMap;

	// Token: 0x04008CAD RID: 36013
	private int SlotIndex;

	// Token: 0x04008CAE RID: 36014
	private int TrailFetterGroup;
}
