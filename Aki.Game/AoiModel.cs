using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003519 RID: 13593
[NullableContext(1)]
[Nullable(0)]
public class AoiModel : ModelBase
{
	// Token: 0x1700290F RID: 10511
	// (get) Token: 0x0601DCD2 RID: 122066 RVA: 0x0085A082 File Offset: 0x00858282
	// (set) Token: 0x0601DCD3 RID: 122067 RVA: 0x0085A08A File Offset: 0x0085828A
	public FVector? MinCoordinate
	{
		get
		{
			return this.MinCoordinateInternal;
		}
		set
		{
			this.MinCoordinateInternal = value;
		}
	}

	// Token: 0x17002910 RID: 10512
	// (get) Token: 0x0601DCD4 RID: 122068 RVA: 0x0085A093 File Offset: 0x00858293
	// (set) Token: 0x0601DCD5 RID: 122069 RVA: 0x0085A09B File Offset: 0x0085829B
	public FVector? MaxCoordinate
	{
		get
		{
			return this.MaxCoordinateInternal;
		}
		set
		{
			this.MaxCoordinateInternal = value;
		}
	}

	// Token: 0x0601DCD6 RID: 122070 RVA: 0x0085A0A4 File Offset: 0x008582A4
	protected override bool OnInit()
	{
		this.MinCoordinateInternal = new FVector?(new FVector());
		this.MaxCoordinateInternal = new FVector?(new FVector());
		return true;
	}

	// Token: 0x0601DCD7 RID: 122071 RVA: 0x0085A0C7 File Offset: 0x008582C7
	protected override bool OnClear()
	{
		this.MinCoordinateInternal = null;
		this.MaxCoordinateInternal = null;
		return true;
	}

	// Token: 0x0601DCD8 RID: 122072 RVA: 0x0085A0E2 File Offset: 0x008582E2
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x17002911 RID: 10513
	// (get) Token: 0x0601DCD9 RID: 122073 RVA: 0x0085A0E5 File Offset: 0x008582E5
	public static AoiModel Instance
	{
		get
		{
			return AoiModel._Instance;
		}
	}

	// Token: 0x0601DCDA RID: 122074 RVA: 0x0085A0EC File Offset: 0x008582EC
	public static AoiModel GetOrCreateInstance()
	{
		if (AoiModel._Instance == null)
		{
			AoiModel.CreateInstance();
		}
		return AoiModel._Instance;
	}

	// Token: 0x0601DCDB RID: 122075 RVA: 0x0085A100 File Offset: 0x00858300
	public static bool CreateInstance()
	{
		if (AoiModel._Instance != null)
		{
			return true;
		}
		AoiModel._Instance = new AoiModel();
		return true;
	}

	// Token: 0x0601DCDC RID: 122076 RVA: 0x0085A116 File Offset: 0x00858316
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DCDD RID: 122077 RVA: 0x0085A118 File Offset: 0x00858318
	public static void ResetStaticDefaultValue()
	{
		AoiModel._Instance = null;
	}

	// Token: 0x0601DCDE RID: 122078 RVA: 0x0085A120 File Offset: 0x00858320
	static AoiModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AoiModel.CreateStaticDefaultValue), new Action(AoiModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400E9EC RID: 59884
	private FVector? MinCoordinateInternal;

	// Token: 0x0400E9ED RID: 59885
	private FVector? MaxCoordinateInternal;

	// Token: 0x0400E9EE RID: 59886
	[Nullable(2)]
	private static AoiModel _Instance;
}
