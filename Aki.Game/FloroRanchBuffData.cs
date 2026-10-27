using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001AEF RID: 6895
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchBuffData
{
	// Token: 0x0600CCA2 RID: 52386 RVA: 0x002EBF1C File Offset: 0x002EA11C
	public void RefreshBuffData(FloroRanchPlayBuff buff)
	{
		this.InstanceId = buff.PlayIncId;
		this.ConfigId = buff.Id;
		this.Day = buff.Day;
		this.Plies = buff.Plies;
		this.BuffConfig = FloroRanchConfig.Instance.GetFloroRanchBuffById(this.ConfigId).Value;
	}

	// Token: 0x0600CCA3 RID: 52387 RVA: 0x002EBF77 File Offset: 0x002EA177
	public string GetBuffName()
	{
		return this.BuffConfig.Name ?? "";
	}

	// Token: 0x170010D9 RID: 4313
	// (get) Token: 0x0600CCA4 RID: 52388 RVA: 0x002EBF8D File Offset: 0x002EA18D
	public int RemindDay
	{
		get
		{
			return this.Day;
		}
	}

	// Token: 0x0600CCA5 RID: 52389 RVA: 0x002EBF95 File Offset: 0x002EA195
	public int GetPlies()
	{
		return this.Plies;
	}

	// Token: 0x0600CCA6 RID: 52390 RVA: 0x002EBF9D File Offset: 0x002EA19D
	public int GetInstanceId()
	{
		return this.InstanceId;
	}

	// Token: 0x0600CCA7 RID: 52391 RVA: 0x002EBFA5 File Offset: 0x002EA1A5
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x170010DA RID: 4314
	// (get) Token: 0x0600CCA8 RID: 52392 RVA: 0x002EBFAD File Offset: 0x002EA1AD
	public bool IsShowOnTip
	{
		get
		{
			return this.BuffConfig.IsShowOnTip;
		}
	}

	// Token: 0x170010DB RID: 4315
	// (get) Token: 0x0600CCA9 RID: 52393 RVA: 0x002EBFBA File Offset: 0x002EA1BA
	public bool IsShowEffect
	{
		get
		{
			return this.BuffConfig.IsShowEffect;
		}
	}

	// Token: 0x04005DF7 RID: 24055
	private int InstanceId;

	// Token: 0x04005DF8 RID: 24056
	private int ConfigId;

	// Token: 0x04005DF9 RID: 24057
	private int Day;

	// Token: 0x04005DFA RID: 24058
	private int Plies;

	// Token: 0x04005DFB RID: 24059
	private FloroRanchBuff BuffConfig;
}
