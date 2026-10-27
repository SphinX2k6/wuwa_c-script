using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02000070 RID: 112
[NullableContext(1)]
[Nullable(0)]
public class EffectEnvironment : Singleton
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000317 RID: 791 RVA: 0x00013074 File Offset: 0x00011274
	// (set) Token: 0x06000318 RID: 792 RVA: 0x0001307C File Offset: 0x0001127C
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

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000319 RID: 793 RVA: 0x00013094 File Offset: 0x00011294
	// (set) Token: 0x0600031A RID: 794 RVA: 0x0001309C File Offset: 0x0001129C
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

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600031B RID: 795 RVA: 0x000130B4 File Offset: 0x000112B4
	// (set) Token: 0x0600031C RID: 796 RVA: 0x000130BC File Offset: 0x000112BC
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

	// Token: 0x0600031D RID: 797 RVA: 0x000130D5 File Offset: 0x000112D5
	public void Initialize()
	{
		this.UseLog = Info.Instance.IsBuildDevelopmentOrDebug;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x000130E8 File Offset: 0x000112E8
	public void Tick(float delta, UWorld world)
	{
		float num = delta * 0.001f;
		this.GameTimeInSeconds += (double)num;
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x0600031F RID: 799 RVA: 0x0001310C File Offset: 0x0001130C
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

	// Token: 0x06000320 RID: 800 RVA: 0x0001312F File Offset: 0x0001132F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00013131 File Offset: 0x00011331
	public static void ResetStaticDefaultValue()
	{
		EffectEnvironment instance = EffectEnvironment._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		EffectEnvironment._instance = null;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x0001314A File Offset: 0x0001134A
	static EffectEnvironment()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EffectEnvironment.CreateStaticDefaultValue), new Action(EffectEnvironment.ResetStaticDefaultValue));
	}

	// Token: 0x04000332 RID: 818
	public double GameTimeInSeconds;

	// Token: 0x04000333 RID: 819
	private float GlobalTimeScaleInternal = 1f;

	// Token: 0x04000334 RID: 820
	public bool UseLog = true;

	// Token: 0x04000335 RID: 821
	private bool DisableOtherEffectInternal;

	// Token: 0x04000336 RID: 822
	public bool UsePool = true;

	// Token: 0x04000337 RID: 823
	private int EffectQualityBiasRemoteInternal = -1;

	// Token: 0x04000338 RID: 824
	public bool CloseEffectSubStat = true;

	// Token: 0x04000339 RID: 825
	public readonly bool OpenVisibilityOptimize = true;

	// Token: 0x0400033A RID: 826
	public readonly bool OpenDistanceOptimize = true;

	// Token: 0x0400033B RID: 827
	[Nullable(2)]
	private static EffectEnvironment _instance;
}
