using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E98 RID: 3736
public class GenerateGroup
{
	// Token: 0x06005BA9 RID: 23465 RVA: 0x0010B840 File Offset: 0x00109A40
	public bool IsGenerateFinish()
	{
		return this.CurGenerateIndex >= this.GenerateList.Count;
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x0010B858 File Offset: 0x00109A58
	public bool IsFinish()
	{
		return this.IsGenerateFinish() && this.AliveEntityMap.Count == 0;
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x0010B874 File Offset: 0x00109A74
	public ValueTuple<EGenerateType, int, int> OnEntityRemove(long creatureId)
	{
		int index;
		if (!this.AliveEntityMap.TryGetValue(creatureId, out index))
		{
			return new ValueTuple<EGenerateType, int, int>(EGenerateType.None, 0, 0);
		}
		this.AliveEntityMap.Remove(creatureId);
		IGenerate generate = this.GenerateList[index];
		if (generate == null)
		{
			return new ValueTuple<EGenerateType, int, int>(EGenerateType.None, 0, 0);
		}
		return new ValueTuple<EGenerateType, int, int>(generate.GenerateType, generate.RefreshId, generate.BuffGateBornGroup);
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x0010B8D8 File Offset: 0x00109AD8
	public float GetEndDistance()
	{
		IGenerate generate = (this.GenerateList.Count > 0) ? this.GenerateList[this.GenerateList.Count - 1] : null;
		float num = (generate != null) ? generate.BornDistance : 0f;
		return this.GroupStartDistance + num;
	}

	// Token: 0x040029CD RID: 10701
	[Nullable(1)]
	public List<IGenerate> GenerateList = new List<IGenerate>();

	// Token: 0x040029CE RID: 10702
	public int CurGenerateIndex;

	// Token: 0x040029CF RID: 10703
	public float GroupStartDistance;

	// Token: 0x040029D0 RID: 10704
	public float GroupEndDistance;

	// Token: 0x040029D1 RID: 10705
	public int WaveGroupIndex;

	// Token: 0x040029D2 RID: 10706
	public int WaveGroupId;

	// Token: 0x040029D3 RID: 10707
	public int BossFightTime;

	// Token: 0x040029D4 RID: 10708
	[Nullable(1)]
	public Dictionary<long, int> AliveEntityMap = new Dictionary<long, int>();
}
