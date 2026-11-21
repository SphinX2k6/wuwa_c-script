using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020022CA RID: 8906
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WorldLevelModel : ModelBase
{
	// Token: 0x17002166 RID: 8550
	// (get) Token: 0x06016011 RID: 90129 RVA: 0x006602BC File Offset: 0x0065E4BC
	public string WorldLevelMultilingualText
	{
		get
		{
			return TextConfig.Instance.GetTextById("WorldLevel") ?? "";
		}
	}

	// Token: 0x17002167 RID: 8551
	// (get) Token: 0x06016012 RID: 90130 RVA: 0x006602D6 File Offset: 0x0065E4D6
	// (set) Token: 0x06016013 RID: 90131 RVA: 0x006602DE File Offset: 0x0065E4DE
	public int CurWorldLevel
	{
		get
		{
			return this.CurWorldLevelInner;
		}
		set
		{
			if (this.CurWorldLevelInner != value)
			{
				this.CurWorldLevelInner = value;
				EventSystem.Instance.Emit(EEventName.CurWorldLevelChange);
			}
		}
	}

	// Token: 0x17002168 RID: 8552
	// (get) Token: 0x06016014 RID: 90132 RVA: 0x00660300 File Offset: 0x0065E500
	// (set) Token: 0x06016015 RID: 90133 RVA: 0x00660308 File Offset: 0x0065E508
	public int OriginWorldLevel
	{
		get
		{
			return this.OriginWorldLevelInner;
		}
		set
		{
			bool flag = value > this.OriginWorldLevelInner;
			this.OriginWorldLevelInner = value;
			if (flag)
			{
				EventSystem.Instance.Emit(EEventName.OriginWorldLevelUp);
			}
		}
	}

	// Token: 0x17002169 RID: 8553
	// (get) Token: 0x06016016 RID: 90134 RVA: 0x0066032C File Offset: 0x0065E52C
	// (set) Token: 0x06016017 RID: 90135 RVA: 0x00660334 File Offset: 0x0065E534
	public int Sex
	{
		get
		{
			return this.SexInner;
		}
		set
		{
			this.SexInner = value;
		}
	}

	// Token: 0x06016018 RID: 90136 RVA: 0x0066033D File Offset: 0x0065E53D
	protected override bool OnInit()
	{
		this.LastChangeWorldLevelTimeStamp = 0;
		return true;
	}

	// Token: 0x06016019 RID: 90137 RVA: 0x00660347 File Offset: 0x0065E547
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x1700216A RID: 8554
	// (get) Token: 0x0601601A RID: 90138 RVA: 0x0066034A File Offset: 0x0065E54A
	public static WorldLevelModel Instance
	{
		get
		{
			return WorldLevelModel._Instance;
		}
	}

	// Token: 0x0601601B RID: 90139 RVA: 0x00660351 File Offset: 0x0065E551
	public static WorldLevelModel GetOrCreateInstance()
	{
		if (WorldLevelModel._Instance == null)
		{
			WorldLevelModel.CreateInstance();
		}
		return WorldLevelModel._Instance;
	}

	// Token: 0x0601601C RID: 90140 RVA: 0x00660365 File Offset: 0x0065E565
	public static bool CreateInstance()
	{
		if (WorldLevelModel._Instance != null)
		{
			return true;
		}
		WorldLevelModel._Instance = new WorldLevelModel();
		return true;
	}

	// Token: 0x0601601D RID: 90141 RVA: 0x0066037B File Offset: 0x0065E57B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601601E RID: 90142 RVA: 0x0066037D File Offset: 0x0065E57D
	public static void ResetStaticDefaultValue()
	{
		WorldLevelModel._Instance = null;
	}

	// Token: 0x0601601F RID: 90143 RVA: 0x00660385 File Offset: 0x0065E585
	static WorldLevelModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldLevelModel.CreateStaticDefaultValue), new Action(WorldLevelModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B8CC RID: 47308
	private int OriginWorldLevelInner;

	// Token: 0x0400B8CD RID: 47309
	private int CurWorldLevelInner;

	// Token: 0x0400B8CE RID: 47310
	public int LastChangeWorldLevelTimeStamp;

	// Token: 0x0400B8CF RID: 47311
	private int SexInner;

	// Token: 0x0400B8D0 RID: 47312
	public int WorldLevelChangeTarget;

	// Token: 0x0400B8D1 RID: 47313
	public bool TsFightState;

	// Token: 0x0400B8D2 RID: 47314
	[Nullable(2)]
	private static WorldLevelModel _Instance;
}
