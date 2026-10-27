using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000A7 RID: 167
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetAllocatorConfig
{
	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060004EC RID: 1260 RVA: 0x0001B54E File Offset: 0x0001974E
	// (set) Token: 0x060004ED RID: 1261 RVA: 0x0001B556 File Offset: 0x00019756
	public TsGameBudgetAllocatorTickIntervalDetailConfig Default
	{
		get
		{
			return this._Default;
		}
		set
		{
			this._Default = value;
			this.ConfigMap["Default"] = value;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060004EE RID: 1262 RVA: 0x0001B570 File Offset: 0x00019770
	// (set) Token: 0x060004EF RID: 1263 RVA: 0x0001B578 File Offset: 0x00019778
	public TsGameBudgetAllocatorTickIntervalDetailConfig Normal_Render
	{
		get
		{
			return this._Normal_Render;
		}
		set
		{
			this._Normal_Render = value;
			this.ConfigMap["Normal_Render"] = value;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001B592 File Offset: 0x00019792
	// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0001B59A File Offset: 0x0001979A
	public TsGameBudgetAllocatorTickIntervalDetailConfig Normal_NotRendered
	{
		get
		{
			return this._Normal_NotRendered;
		}
		set
		{
			this._Normal_NotRendered = value;
			this.ConfigMap["Normal_NotRendered"] = value;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0001B5B4 File Offset: 0x000197B4
	// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0001B5BC File Offset: 0x000197BC
	public TsGameBudgetAllocatorTickIntervalDetailConfig Normal_Fighting
	{
		get
		{
			return this._Normal_Fighting;
		}
		set
		{
			this._Normal_Fighting = value;
			this.ConfigMap["Normal_Fighting"] = value;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0001B5D6 File Offset: 0x000197D6
	// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0001B5DE File Offset: 0x000197DE
	public TsGameBudgetAllocatorTickIntervalDetailConfig Fighting_Rendered
	{
		get
		{
			return this._Fighting_Rendered;
		}
		set
		{
			this._Fighting_Rendered = value;
			this.ConfigMap["Fighting_Rendered"] = value;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001B5F8 File Offset: 0x000197F8
	// (set) Token: 0x060004F7 RID: 1271 RVA: 0x0001B600 File Offset: 0x00019800
	public TsGameBudgetAllocatorTickIntervalDetailConfig Fighting_NotRendered
	{
		get
		{
			return this._Fighting_NotRendered;
		}
		set
		{
			this._Fighting_NotRendered = value;
			this.ConfigMap["Fighting_NotRendered"] = value;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001B61A File Offset: 0x0001981A
	// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0001B622 File Offset: 0x00019822
	public TsGameBudgetAllocatorTickIntervalDetailConfig Fighting_Fighting
	{
		get
		{
			return this._Fighting_Fighting;
		}
		set
		{
			this._Fighting_Fighting = value;
			this.ConfigMap["Fighting_Fighting"] = value;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001B63C File Offset: 0x0001983C
	// (set) Token: 0x060004FB RID: 1275 RVA: 0x0001B644 File Offset: 0x00019844
	public TsGameBudgetAllocatorTickIntervalDetailConfig Cutscene_Rendered
	{
		get
		{
			return this._Cutscene_Rendered;
		}
		set
		{
			this._Cutscene_Rendered = value;
			this.ConfigMap["Cutscene_Rendered"] = value;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060004FC RID: 1276 RVA: 0x0001B65E File Offset: 0x0001985E
	// (set) Token: 0x060004FD RID: 1277 RVA: 0x0001B666 File Offset: 0x00019866
	public TsGameBudgetAllocatorTickIntervalDetailConfig Cutscene_NotRendered
	{
		get
		{
			return this._Cutscene_NotRendered;
		}
		set
		{
			this._Cutscene_NotRendered = value;
			this.ConfigMap["Cutscene_NotRendered"] = value;
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060004FE RID: 1278 RVA: 0x0001B680 File Offset: 0x00019880
	// (set) Token: 0x060004FF RID: 1279 RVA: 0x0001B688 File Offset: 0x00019888
	public TsGameBudgetAllocatorTickIntervalDetailConfig Cutscene_Fighting
	{
		get
		{
			return this._Cutscene_Fighting;
		}
		set
		{
			this._Cutscene_Fighting = value;
			this.ConfigMap["Cutscene_Fighting"] = value;
		}
	}

	// Token: 0x170000AD RID: 173
	public TsGameBudgetAllocatorTickIntervalDetailConfig this[string key]
	{
		get
		{
			return this.ConfigMap[key];
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001B6B0 File Offset: 0x000198B0
	public Dictionary<string, TsGameBudgetAllocatorTickIntervalDetailConfig>.KeyCollection Keys
	{
		get
		{
			return this.ConfigMap.Keys;
		}
	}

	// Token: 0x0400042F RID: 1071
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Default;

	// Token: 0x04000430 RID: 1072
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Normal_Render;

	// Token: 0x04000431 RID: 1073
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Normal_NotRendered;

	// Token: 0x04000432 RID: 1074
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Normal_Fighting;

	// Token: 0x04000433 RID: 1075
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Fighting_Rendered;

	// Token: 0x04000434 RID: 1076
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Fighting_NotRendered;

	// Token: 0x04000435 RID: 1077
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Fighting_Fighting;

	// Token: 0x04000436 RID: 1078
	[Nullable(2)]
	public TsGameBudgetAllocatorTickIntervalDetailConfig _Cutscene_Rendered;

	// Token: 0x04000437 RID: 1079
	[Nullable(2)]
	public TsGameBudgetAllocatorTickIntervalDetailConfig _Cutscene_NotRendered;

	// Token: 0x04000438 RID: 1080
	[Nullable(2)]
	public TsGameBudgetAllocatorTickIntervalDetailConfig _Cutscene_Fighting;

	// Token: 0x04000439 RID: 1081
	private readonly Dictionary<string, TsGameBudgetAllocatorTickIntervalDetailConfig> ConfigMap = new Dictionary<string, TsGameBudgetAllocatorTickIntervalDetailConfig>();
}
