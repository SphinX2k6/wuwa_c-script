using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A8E RID: 10894
[NullableContext(1)]
[Nullable(0)]
public class AoiModel : ModelBase
{
	// Token: 0x17002CA8 RID: 11432
	// (get) Token: 0x0601B9EC RID: 113132 RVA: 0x0088262A File Offset: 0x0088082A
	// (set) Token: 0x0601B9ED RID: 113133 RVA: 0x00882632 File Offset: 0x00880832
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

	// Token: 0x17002CA9 RID: 11433
	// (get) Token: 0x0601B9EE RID: 113134 RVA: 0x0088263B File Offset: 0x0088083B
	// (set) Token: 0x0601B9EF RID: 113135 RVA: 0x00882643 File Offset: 0x00880843
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

	// Token: 0x0601B9F0 RID: 113136 RVA: 0x0088264C File Offset: 0x0088084C
	protected override bool OnInit()
	{
		this.MinCoordinateInternal = new FVector?(new FVector());
		this.MaxCoordinateInternal = new FVector?(new FVector());
		return true;
	}

	// Token: 0x0601B9F1 RID: 113137 RVA: 0x0088266F File Offset: 0x0088086F
	protected override bool OnClear()
	{
		this.MinCoordinateInternal = null;
		this.MaxCoordinateInternal = null;
		return true;
	}

	// Token: 0x0601B9F2 RID: 113138 RVA: 0x0088268A File Offset: 0x0088088A
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x17002CAA RID: 11434
	// (get) Token: 0x0601B9F3 RID: 113139 RVA: 0x0088268D File Offset: 0x0088088D
	public static AoiModel Instance
	{
		get
		{
			return AoiModel._Instance;
		}
	}

	// Token: 0x0601B9F4 RID: 113140 RVA: 0x00882694 File Offset: 0x00880894
	public static AoiModel GetOrCreateInstance()
	{
		if (AoiModel._Instance == null)
		{
			AoiModel.CreateInstance();
		}
		return AoiModel._Instance;
	}

	// Token: 0x0601B9F5 RID: 113141 RVA: 0x008826A8 File Offset: 0x008808A8
	public static bool CreateInstance()
	{
		if (AoiModel._Instance != null)
		{
			return true;
		}
		AoiModel._Instance = new AoiModel();
		return true;
	}

	// Token: 0x0601B9F6 RID: 113142 RVA: 0x008826BE File Offset: 0x008808BE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B9F7 RID: 113143 RVA: 0x008826C0 File Offset: 0x008808C0
	public static void ResetStaticDefaultValue()
	{
		AoiModel._Instance = null;
	}

	// Token: 0x0601B9F8 RID: 113144 RVA: 0x008826C8 File Offset: 0x008808C8
	static AoiModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AoiModel.CreateStaticDefaultValue), new Action(AoiModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EEA7 RID: 61095
	private FVector? MinCoordinateInternal;

	// Token: 0x0400EEA8 RID: 61096
	private FVector? MaxCoordinateInternal;

	// Token: 0x0400EEA9 RID: 61097
	[Nullable(2)]
	private static AoiModel _Instance;
}
