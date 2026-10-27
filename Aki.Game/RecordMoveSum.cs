using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002EC5 RID: 11973
[NullableContext(1)]
[Nullable(0)]
public class RecordMoveSum
{
	// Token: 0x060198DE RID: 104670 RVA: 0x0069C364 File Offset: 0x0069A564
	public string[] ToCsv()
	{
		List<string> list = new List<string>();
		list.Add(this.ConfigId.ToString());
		list.Add(this.Name);
		list.Add(this.TargetUniqueId.ToString());
		for (int i = 0; i < 25; i++)
		{
			list.Add((this.RecordNum.ContainsKey((ESkillGenre)i) ? this.RecordNum[(ESkillGenre)i] : 0).ToString());
		}
		return list.ToArray();
	}

	// Token: 0x0400BF19 RID: 48921
	public string Name = "";

	// Token: 0x0400BF1A RID: 48922
	public int ConfigId;

	// Token: 0x0400BF1B RID: 48923
	public int TargetUniqueId;

	// Token: 0x0400BF1C RID: 48924
	public Dictionary<ESkillGenre, int> RecordNum = new Dictionary<ESkillGenre, int>();
}
