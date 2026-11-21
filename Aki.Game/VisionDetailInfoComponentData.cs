using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Phantom.Vision.View;

// Token: 0x02001983 RID: 6531
[NullableContext(1)]
[Nullable(0)]
public class VisionDetailInfoComponentData
{
	// Token: 0x060101D7 RID: 66007 RVA: 0x004B2CB0 File Offset: 0x004B0EB0
	public List<AttrListScrollData> GetMainPropData(bool needAddType = false)
	{
		return this.DataBase.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, needAddType);
	}

	// Token: 0x060101D8 RID: 66008 RVA: 0x004B2CBF File Offset: 0x004B0EBF
	public List<VisionSubPropData> GetSubPropData()
	{
		return this.DataBase.GetEquipmentViewPreviewData();
	}

	// Token: 0x060101D9 RID: 66009 RVA: 0x004B2CCC File Offset: 0x004B0ECC
	public void AddDescData(VisionDetailDesc data)
	{
		if (this.DescData == null)
		{
			this.DescData = new List<VisionDetailDesc>();
		}
		this.DescData.Add(data);
	}

	// Token: 0x04008EFD RID: 36605
	public int RoleId;

	// Token: 0x04008EFE RID: 36606
	public int Cost;

	// Token: 0x04008EFF RID: 36607
	[Nullable(2)]
	public PhantomBattleData DataBase;

	// Token: 0x04008F00 RID: 36608
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionDetailDesc> DescData;
}
