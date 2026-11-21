using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000FAE RID: 4014
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchBuffData
{
	// Token: 0x0600A0B3 RID: 41139 RVA: 0x002F7008 File Offset: 0x002F5208
	public void RefreshBuffData(FloroRanchPlayBuff buff)
	{
		this.InstanceId = buff.PlayIncId;
		this.ConfigId = buff.Id;
		this.Day = buff.Day;
		this.Plies = buff.Plies;
		this.BuffConfig = FloroRanchConfig.Instance.GetFloroRanchBuffById(this.ConfigId).Value;
	}

	// Token: 0x0600A0B4 RID: 41140 RVA: 0x002F7063 File Offset: 0x002F5263
	public string GetBuffName()
	{
		return this.BuffConfig.Name ?? "";
	}

	// Token: 0x170010FE RID: 4350
	// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x002F7079 File Offset: 0x002F5279
	public int RemindDay
	{
		get
		{
			return this.Day;
		}
	}

	// Token: 0x0600A0B6 RID: 41142 RVA: 0x002F7081 File Offset: 0x002F5281
	public int GetPlies()
	{
		return this.Plies;
	}

	// Token: 0x0600A0B7 RID: 41143 RVA: 0x002F7089 File Offset: 0x002F5289
	public int GetInstanceId()
	{
		return this.InstanceId;
	}

	// Token: 0x0600A0B8 RID: 41144 RVA: 0x002F7091 File Offset: 0x002F5291
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x170010FF RID: 4351
	// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x002F7099 File Offset: 0x002F5299
	public bool IsShowOnTip
	{
		get
		{
			return this.BuffConfig.IsShowOnTip;
		}
	}

	// Token: 0x17001100 RID: 4352
	// (get) Token: 0x0600A0BA RID: 41146 RVA: 0x002F70A6 File Offset: 0x002F52A6
	public bool IsShowEffect
	{
		get
		{
			return this.BuffConfig.IsShowEffect;
		}
	}

	// Token: 0x04005EC6 RID: 24262
	private int InstanceId;

	// Token: 0x04005EC7 RID: 24263
	private int ConfigId;

	// Token: 0x04005EC8 RID: 24264
	private int Day;

	// Token: 0x04005EC9 RID: 24265
	private int Plies;

	// Token: 0x04005ECA RID: 24266
	private FloroRanchBuff BuffConfig;
}
