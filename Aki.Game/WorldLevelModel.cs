using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002D70 RID: 11632
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class WorldLevelModel : ModelBase
{
	// Token: 0x1700210B RID: 8459
	// (get) Token: 0x0601876F RID: 100207 RVA: 0x0063A2A4 File Offset: 0x006384A4
	public string WorldLevelMultilingualText
	{
		get
		{
			return TextConfig.Instance.GetTextById("WorldLevel") ?? "";
		}
	}

	// Token: 0x1700210C RID: 8460
	// (get) Token: 0x06018770 RID: 100208 RVA: 0x0063A2BE File Offset: 0x006384BE
	// (set) Token: 0x06018771 RID: 100209 RVA: 0x0063A2C6 File Offset: 0x006384C6
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

	// Token: 0x1700210D RID: 8461
	// (get) Token: 0x06018772 RID: 100210 RVA: 0x0063A2E8 File Offset: 0x006384E8
	// (set) Token: 0x06018773 RID: 100211 RVA: 0x0063A2F0 File Offset: 0x006384F0
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

	// Token: 0x1700210E RID: 8462
	// (get) Token: 0x06018774 RID: 100212 RVA: 0x0063A314 File Offset: 0x00638514
	// (set) Token: 0x06018775 RID: 100213 RVA: 0x0063A31C File Offset: 0x0063851C
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

	// Token: 0x06018776 RID: 100214 RVA: 0x0063A325 File Offset: 0x00638525
	protected override bool OnInit()
	{
		this.LastChangeWorldLevelTimeStamp = 0;
		return true;
	}

	// Token: 0x06018777 RID: 100215 RVA: 0x0063A32F File Offset: 0x0063852F
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x1700210F RID: 8463
	// (get) Token: 0x06018778 RID: 100216 RVA: 0x0063A332 File Offset: 0x00638532
	public static WorldLevelModel Instance
	{
		get
		{
			return WorldLevelModel._Instance;
		}
	}

	// Token: 0x06018779 RID: 100217 RVA: 0x0063A339 File Offset: 0x00638539
	public static WorldLevelModel GetOrCreateInstance()
	{
		if (WorldLevelModel._Instance == null)
		{
			WorldLevelModel.CreateInstance();
		}
		return WorldLevelModel._Instance;
	}

	// Token: 0x0601877A RID: 100218 RVA: 0x0063A34D File Offset: 0x0063854D
	public static bool CreateInstance()
	{
		if (WorldLevelModel._Instance != null)
		{
			return true;
		}
		WorldLevelModel._Instance = new WorldLevelModel();
		return true;
	}

	// Token: 0x0601877B RID: 100219 RVA: 0x0063A363 File Offset: 0x00638563
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601877C RID: 100220 RVA: 0x0063A365 File Offset: 0x00638565
	public static void ResetStaticDefaultValue()
	{
		WorldLevelModel._Instance = null;
	}

	// Token: 0x0601877D RID: 100221 RVA: 0x0063A36D File Offset: 0x0063856D
	static WorldLevelModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WorldLevelModel.CreateStaticDefaultValue), new Action(WorldLevelModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B557 RID: 46423
	private int OriginWorldLevelInner;

	// Token: 0x0400B558 RID: 46424
	private int CurWorldLevelInner;

	// Token: 0x0400B559 RID: 46425
	public int LastChangeWorldLevelTimeStamp;

	// Token: 0x0400B55A RID: 46426
	private int SexInner;

	// Token: 0x0400B55B RID: 46427
	public int WorldLevelChangeTarget;

	// Token: 0x0400B55C RID: 46428
	public bool TsFightState;

	// Token: 0x0400B55D RID: 46429
	[Nullable(2)]
	private static WorldLevelModel _Instance;
}
