using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000072 RID: 114
[NullableContext(1)]
[Nullable(0)]
public class EffectEnvironment : Singleton
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000352 RID: 850 RVA: 0x00013E5C File Offset: 0x0001205C
	// (set) Token: 0x06000353 RID: 851 RVA: 0x00013E64 File Offset: 0x00012064
	public float GlobalTimeScale
	{
		get
		{
			return this.GlobalTimeScaleInternal;
		}
		set
		{
			if (this.GlobalTimeScaleInternal != value)
			{
				this.GlobalTimeScaleInternal = value;
				UKuroEffectSystemFunctionLibrary.SetGlobalTimeScale(value);
			}
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000354 RID: 852 RVA: 0x00013E7C File Offset: 0x0001207C
	// (set) Token: 0x06000355 RID: 853 RVA: 0x00013E84 File Offset: 0x00012084
	public bool DisableOtherEffect
	{
		get
		{
			return this.DisableOtherEffectInternal;
		}
		set
		{
			if (this.DisableOtherEffectInternal != value)
			{
				this.DisableOtherEffectInternal = value;
				UKuroEffectSystemFunctionLibrary.OnDisableOtherEffectChange(value);
			}
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000356 RID: 854 RVA: 0x00013E9C File Offset: 0x0001209C
	// (set) Token: 0x06000357 RID: 855 RVA: 0x00013EA4 File Offset: 0x000120A4
	public int EffectQualityBiasRemote
	{
		get
		{
			return this.EffectQualityBiasRemoteInternal;
		}
		set
		{
			if (this.EffectQualityBiasRemoteInternal != value)
			{
				this.EffectQualityBiasRemoteInternal = value;
				UKuroEffectSystemFunctionLibrary.OnEffectQualityBiasRemoteChange((float)value);
			}
		}
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00013EBD File Offset: 0x000120BD
	public void Initialize()
	{
		this.UseLog = false;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00013EC8 File Offset: 0x000120C8
	public void Tick(float delta, UWorld world)
	{
		float num = delta * 0.001f;
		this.GameTimeInSeconds += (double)num;
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600035A RID: 858 RVA: 0x00013EEC File Offset: 0x000120EC
	public static EffectEnvironment Instance
	{
		get
		{
			if (EffectEnvironment._instance == null)
			{
				EffectEnvironment._instance = new EffectEnvironment();
				EffectEnvironment._instance.OnInit();
			}
			return EffectEnvironment._instance;
		}
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00013F0F File Offset: 0x0001210F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00013F11 File Offset: 0x00012111
	public static void ResetStaticDefaultValue()
	{
		EffectEnvironment instance = EffectEnvironment._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EffectEnvironment._instance = null;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00013F2A File Offset: 0x0001212A
	static EffectEnvironment()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EffectEnvironment.CreateStaticDefaultValue), new Action(EffectEnvironment.ResetStaticDefaultValue));
	}

	// Token: 0x0400034B RID: 843
	public double GameTimeInSeconds;

	// Token: 0x0400034C RID: 844
	private float GlobalTimeScaleInternal = 1f;

	// Token: 0x0400034D RID: 845
	public bool UseLog = true;

	// Token: 0x0400034E RID: 846
	private bool DisableOtherEffectInternal;

	// Token: 0x0400034F RID: 847
	public bool UsePool = true;

	// Token: 0x04000350 RID: 848
	private int EffectQualityBiasRemoteInternal = -1;

	// Token: 0x04000351 RID: 849
	public bool CloseEffectSubStat = true;

	// Token: 0x04000352 RID: 850
	public readonly bool OpenVisibilityOptimize = true;

	// Token: 0x04000353 RID: 851
	public readonly bool OpenDistanceOptimize = true;

	// Token: 0x04000354 RID: 852
	[Nullable(2)]
	private static EffectEnvironment _instance;
}
