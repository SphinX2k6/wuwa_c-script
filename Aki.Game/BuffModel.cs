using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002406 RID: 9222
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BuffModel : ModelBase
{
	// Token: 0x06017158 RID: 94552 RVA: 0x006BFA34 File Offset: 0x006BDC34
	protected override bool OnClear()
	{
		this.BuffDefMaps.Clear();
		return true;
	}

	// Token: 0x170023DB RID: 9179
	// (get) Token: 0x06017159 RID: 94553 RVA: 0x006BFA42 File Offset: 0x006BDC42
	// (set) Token: 0x0601715A RID: 94554 RVA: 0x006BFA4A File Offset: 0x006BDC4A
	public int HandlePrefix { get; set; }

	// Token: 0x170023DC RID: 9180
	// (get) Token: 0x0601715B RID: 94555 RVA: 0x006BFA53 File Offset: 0x006BDC53
	// (set) Token: 0x0601715C RID: 94556 RVA: 0x006BFA5B File Offset: 0x006BDC5B
	public int LastHandle { get; set; } = 1;

	// Token: 0x0601715D RID: 94557 RVA: 0x006BFA64 File Offset: 0x006BDC64
	public void Add(long buffId, BuffDefinition buffDefinition)
	{
		this.BuffDefMaps[buffId] = buffDefinition;
	}

	// Token: 0x0601715E RID: 94558 RVA: 0x006BFA73 File Offset: 0x006BDC73
	[NullableContext(2)]
	public BuffDefinition Get(long buffId)
	{
		return this.BuffDefMaps.GetValueOrDefault(buffId);
	}

	// Token: 0x0601715F RID: 94559 RVA: 0x006BFA84 File Offset: 0x006BDC84
	public void ClearAllDefs()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.CombatInfo;
		ELogAuthor author = ELogAuthor.GHY;
		string message = "[热更][db_buff.db] 清空解析后缓存";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("清空前条数", this.BuffDefMaps.Count);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.BuffDefMaps.Clear();
	}

	// Token: 0x170023DD RID: 9181
	// (get) Token: 0x06017160 RID: 94560 RVA: 0x006BFAD5 File Offset: 0x006BDCD5
	public static BuffModel Instance
	{
		get
		{
			return BuffModel._Instance;
		}
	}

	// Token: 0x06017161 RID: 94561 RVA: 0x006BFADC File Offset: 0x006BDCDC
	public static BuffModel GetOrCreateInstance()
	{
		if (BuffModel._Instance == null)
		{
			BuffModel.CreateInstance();
		}
		return BuffModel._Instance;
	}

	// Token: 0x06017162 RID: 94562 RVA: 0x006BFAF0 File Offset: 0x006BDCF0
	public static bool CreateInstance()
	{
		if (BuffModel._Instance != null)
		{
			return true;
		}
		BuffModel._Instance = new BuffModel();
		return true;
	}

	// Token: 0x06017163 RID: 94563 RVA: 0x006BFB06 File Offset: 0x006BDD06
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017164 RID: 94564 RVA: 0x006BFB08 File Offset: 0x006BDD08
	public static void ResetStaticDefaultValue()
	{
		BuffModel._Instance = null;
	}

	// Token: 0x06017165 RID: 94565 RVA: 0x006BFB10 File Offset: 0x006BDD10
	static BuffModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffModel.CreateStaticDefaultValue), new Action(BuffModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400C23E RID: 49726
	private readonly Dictionary<long, BuffDefinition> BuffDefMaps = new Dictionary<long, BuffDefinition>();

	// Token: 0x0400C23F RID: 49727
	[Nullable(2)]
	private static BuffModel _Instance;
}
