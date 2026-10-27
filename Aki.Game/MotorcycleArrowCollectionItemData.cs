using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001CD5 RID: 7381
public class MotorcycleArrowCollectionItemData
{
	// Token: 0x0600DF8D RID: 57229 RVA: 0x00345C92 File Offset: 0x00343E92
	[NullableContext(1)]
	public static MotorcycleArrowCollectionItemData Create(MotorFightItem config, int pos)
	{
		return new MotorcycleArrowCollectionItemData(config.Id)
		{
			Config = config,
			Pos = pos,
			Num = 1
		};
	}

	// Token: 0x0600DF8E RID: 57230 RVA: 0x00345CB5 File Offset: 0x00343EB5
	private MotorcycleArrowCollectionItemData(int id)
	{
		this.Id = id;
	}

	// Token: 0x0600DF8F RID: 57231 RVA: 0x00345CCB File Offset: 0x00343ECB
	public void SetIsShowStrengthen(bool show)
	{
		this.IsShowStrengthen = show;
	}

	// Token: 0x040066D6 RID: 26326
	public int Id;

	// Token: 0x040066D7 RID: 26327
	public MotorFightItem Config;

	// Token: 0x040066D8 RID: 26328
	public bool IsShowStrengthen;

	// Token: 0x040066D9 RID: 26329
	public bool IsUnlock = true;

	// Token: 0x040066DA RID: 26330
	public int Pos;

	// Token: 0x040066DB RID: 26331
	public int Num;
}
