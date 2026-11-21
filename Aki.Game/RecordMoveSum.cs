using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002418 RID: 9240
[NullableContext(1)]
[Nullable(0)]
public class RecordMoveSum
{
	// Token: 0x060171D1 RID: 94673 RVA: 0x006C25A4 File Offset: 0x006C07A4
	public string[] ToCsv()
	{
		List<string> list = new List<string>();
		list.Add(this.ConfigId.ToString());
		list.Add(this.Name);
		list.Add(this.TargetUniqueId.ToString());
		for (int i = 0; i < 15; i++)
		{
			list.Add((this.RecordNum.ContainsKey((ESkillGenre)i) ? this.RecordNum[(ESkillGenre)i] : 0).ToString());
		}
		return list.ToArray();
	}

	// Token: 0x0400C2B4 RID: 49844
	public string Name = "";

	// Token: 0x0400C2B5 RID: 49845
	public int ConfigId;

	// Token: 0x0400C2B6 RID: 49846
	public int TargetUniqueId;

	// Token: 0x0400C2B7 RID: 49847
	public Dictionary<ESkillGenre, int> RecordNum = new Dictionary<ESkillGenre, int>();
}
