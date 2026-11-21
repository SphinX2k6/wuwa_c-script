using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200034D RID: 845
public class GenerateGroup
{
	// Token: 0x06002F40 RID: 12096 RVA: 0x001134D8 File Offset: 0x001116D8
	public bool IsGenerateFinish()
	{
		return this.CurGenerateIndex >= this.GenerateList.Count;
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x001134F0 File Offset: 0x001116F0
	public bool IsFinish()
	{
		return this.IsGenerateFinish() && this.AliveEntityMap.Count == 0;
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x0011350C File Offset: 0x0011170C
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

	// Token: 0x06002F43 RID: 12099 RVA: 0x00113570 File Offset: 0x00111770
	public float GetEndDistance()
	{
		IGenerate generate = (this.GenerateList.Count > 0) ? this.GenerateList[this.GenerateList.Count - 1] : null;
		float num = (generate != null) ? generate.BornDistance : 0f;
		return this.GroupStartDistance + num;
	}

	// Token: 0x04002A68 RID: 10856
	[Nullable(1)]
	public List<IGenerate> GenerateList = new List<IGenerate>();

	// Token: 0x04002A69 RID: 10857
	public int CurGenerateIndex;

	// Token: 0x04002A6A RID: 10858
	public float GroupStartDistance;

	// Token: 0x04002A6B RID: 10859
	public float GroupEndDistance;

	// Token: 0x04002A6C RID: 10860
	public int WaveGroupIndex;

	// Token: 0x04002A6D RID: 10861
	public int WaveGroupId;

	// Token: 0x04002A6E RID: 10862
	public int BossFightTime;

	// Token: 0x04002A6F RID: 10863
	[Nullable(1)]
	public Dictionary<long, int> AliveEntityMap = new Dictionary<long, int>();
}
