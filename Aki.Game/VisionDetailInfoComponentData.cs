using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Phantom.Vision.View;

// Token: 0x0200249C RID: 9372
[NullableContext(1)]
[Nullable(0)]
public class VisionDetailInfoComponentData
{
	// Token: 0x06012D16 RID: 77078 RVA: 0x004A51A8 File Offset: 0x004A33A8
	public List<AttrListScrollData> GetMainPropData(bool needAddType = false)
	{
		return this.DataBase.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, needAddType);
	}

	// Token: 0x06012D17 RID: 77079 RVA: 0x004A51B7 File Offset: 0x004A33B7
	public List<VisionSubPropData> GetSubPropData()
	{
		return this.DataBase.GetEquipmentViewPreviewData();
	}

	// Token: 0x06012D18 RID: 77080 RVA: 0x004A51C4 File Offset: 0x004A33C4
	public void AddDescData(VisionDetailDesc data)
	{
		if (this.DescData == null)
		{
			this.DescData = new List<VisionDetailDesc>();
		}
		this.DescData.Add(data);
	}

	// Token: 0x04008DB3 RID: 36275
	public int RoleId;

	// Token: 0x04008DB4 RID: 36276
	public int Cost;

	// Token: 0x04008DB5 RID: 36277
	[Nullable(2)]
	public PhantomBattleData DataBase;

	// Token: 0x04008DB6 RID: 36278
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<VisionDetailDesc> DescData;
}
