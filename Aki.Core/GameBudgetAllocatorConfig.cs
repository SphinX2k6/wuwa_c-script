using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020000A9 RID: 169
[NullableContext(1)]
[Nullable(0)]
public class GameBudgetAllocatorConfig
{
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001BC36 File Offset: 0x00019E36
	// (set) Token: 0x0600052E RID: 1326 RVA: 0x0001BC3E File Offset: 0x00019E3E
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

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001BC58 File Offset: 0x00019E58
	// (set) Token: 0x06000530 RID: 1328 RVA: 0x0001BC60 File Offset: 0x00019E60
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

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001BC7A File Offset: 0x00019E7A
	// (set) Token: 0x06000532 RID: 1330 RVA: 0x0001BC82 File Offset: 0x00019E82
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

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001BC9C File Offset: 0x00019E9C
	// (set) Token: 0x06000534 RID: 1332 RVA: 0x0001BCA4 File Offset: 0x00019EA4
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

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001BCBE File Offset: 0x00019EBE
	// (set) Token: 0x06000536 RID: 1334 RVA: 0x0001BCC6 File Offset: 0x00019EC6
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

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000537 RID: 1335 RVA: 0x0001BCE0 File Offset: 0x00019EE0
	// (set) Token: 0x06000538 RID: 1336 RVA: 0x0001BCE8 File Offset: 0x00019EE8
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

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000539 RID: 1337 RVA: 0x0001BD02 File Offset: 0x00019F02
	// (set) Token: 0x0600053A RID: 1338 RVA: 0x0001BD0A File Offset: 0x00019F0A
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

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001BD24 File Offset: 0x00019F24
	// (set) Token: 0x0600053C RID: 1340 RVA: 0x0001BD2C File Offset: 0x00019F2C
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

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001BD46 File Offset: 0x00019F46
	// (set) Token: 0x0600053E RID: 1342 RVA: 0x0001BD4E File Offset: 0x00019F4E
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

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001BD68 File Offset: 0x00019F68
	// (set) Token: 0x06000540 RID: 1344 RVA: 0x0001BD70 File Offset: 0x00019F70
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

	// Token: 0x170000BF RID: 191
	public TsGameBudgetAllocatorTickIntervalDetailConfig this[string key]
	{
		get
		{
			return this.ConfigMap[key];
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001BD98 File Offset: 0x00019F98
	public Dictionary<string, TsGameBudgetAllocatorTickIntervalDetailConfig>.KeyCollection Keys
	{
		get
		{
			return this.ConfigMap.Keys;
		}
	}

	// Token: 0x0400043D RID: 1085
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Default;

	// Token: 0x0400043E RID: 1086
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Normal_Render;

	// Token: 0x0400043F RID: 1087
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Normal_NotRendered;

	// Token: 0x04000440 RID: 1088
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Normal_Fighting;

	// Token: 0x04000441 RID: 1089
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Fighting_Rendered;

	// Token: 0x04000442 RID: 1090
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Fighting_NotRendered;

	// Token: 0x04000443 RID: 1091
	[Nullable(2)]
	private TsGameBudgetAllocatorTickIntervalDetailConfig _Fighting_Fighting;

	// Token: 0x04000444 RID: 1092
	[Nullable(2)]
	public TsGameBudgetAllocatorTickIntervalDetailConfig _Cutscene_Rendered;

	// Token: 0x04000445 RID: 1093
	[Nullable(2)]
	public TsGameBudgetAllocatorTickIntervalDetailConfig _Cutscene_NotRendered;

	// Token: 0x04000446 RID: 1094
	[Nullable(2)]
	public TsGameBudgetAllocatorTickIntervalDetailConfig _Cutscene_Fighting;

	// Token: 0x04000447 RID: 1095
	private readonly Dictionary<string, TsGameBudgetAllocatorTickIntervalDetailConfig> ConfigMap = new Dictionary<string, TsGameBudgetAllocatorTickIntervalDetailConfig>();
}
