using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002EB3 RID: 11955
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BuffModel : ModelBase
{
	// Token: 0x06019872 RID: 104562 RVA: 0x00699774 File Offset: 0x00697974
	protected override bool OnClear()
	{
		this.BuffDefMaps.Clear();
		return true;
	}

	// Token: 0x1700233F RID: 9023
	// (get) Token: 0x06019873 RID: 104563 RVA: 0x00699782 File Offset: 0x00697982
	// (set) Token: 0x06019874 RID: 104564 RVA: 0x0069978A File Offset: 0x0069798A
	public int HandlePrefix { get; set; }

	// Token: 0x17002340 RID: 9024
	// (get) Token: 0x06019875 RID: 104565 RVA: 0x00699793 File Offset: 0x00697993
	// (set) Token: 0x06019876 RID: 104566 RVA: 0x0069979B File Offset: 0x0069799B
	public int LastHandle { get; set; } = 1;

	// Token: 0x06019877 RID: 104567 RVA: 0x006997A4 File Offset: 0x006979A4
	public void Add(long buffId, BuffDefinition buffDefinition)
	{
		this.BuffDefMaps[buffId] = buffDefinition;
	}

	// Token: 0x06019878 RID: 104568 RVA: 0x006997B3 File Offset: 0x006979B3
	[NullableContext(2)]
	public BuffDefinition Get(long buffId)
	{
		return this.BuffDefMaps.GetValueOrDefault(buffId);
	}

	// Token: 0x06019879 RID: 104569 RVA: 0x006997C4 File Offset: 0x006979C4
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

	// Token: 0x17002341 RID: 9025
	// (get) Token: 0x0601987A RID: 104570 RVA: 0x00699815 File Offset: 0x00697A15
	public static BuffModel Instance
	{
		get
		{
			return BuffModel._Instance;
		}
	}

	// Token: 0x0601987B RID: 104571 RVA: 0x0069981C File Offset: 0x00697A1C
	public static BuffModel GetOrCreateInstance()
	{
		if (BuffModel._Instance == null)
		{
			BuffModel.CreateInstance();
		}
		return BuffModel._Instance;
	}

	// Token: 0x0601987C RID: 104572 RVA: 0x00699830 File Offset: 0x00697A30
	public static bool CreateInstance()
	{
		if (BuffModel._Instance != null)
		{
			return true;
		}
		BuffModel._Instance = new BuffModel();
		return true;
	}

	// Token: 0x0601987D RID: 104573 RVA: 0x00699846 File Offset: 0x00697A46
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601987E RID: 104574 RVA: 0x00699848 File Offset: 0x00697A48
	public static void ResetStaticDefaultValue()
	{
		BuffModel._Instance = null;
	}

	// Token: 0x0601987F RID: 104575 RVA: 0x00699850 File Offset: 0x00697A50
	static BuffModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffModel.CreateStaticDefaultValue), new Action(BuffModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400BEA3 RID: 48803
	private readonly Dictionary<long, BuffDefinition> BuffDefMaps = new Dictionary<long, BuffDefinition>();

	// Token: 0x0400BEA4 RID: 48804
	[Nullable(2)]
	private static BuffModel _Instance;
}
