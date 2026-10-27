using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020022B3 RID: 8883
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorcycleMusicPlayerConfig : ConfigBase
{
	// Token: 0x060116A4 RID: 71332 RVA: 0x00444098 File Offset: 0x00442298
	public int GetFavoriteAlbumId()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomMusicCollectAlbum").Value;
	}

	// Token: 0x060116A5 RID: 71333 RVA: 0x004440B8 File Offset: 0x004422B8
	public int GetDefaultAlbumId()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomMusicDefaultAlbum").Value;
	}

	// Token: 0x060116A6 RID: 71334 RVA: 0x004440D8 File Offset: 0x004422D8
	public int GetFavoriteCountLimit()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomMusicCollectMaxCount").Value;
	}

	// Token: 0x060116A7 RID: 71335 RVA: 0x004440F8 File Offset: 0x004422F8
	public float GetAlbumVelocity()
	{
		return ConfigCommonParamById.GetFloatConfig("MotorMusicUIVelocity").GetValueOrDefault(1f);
	}

	// Token: 0x060116A8 RID: 71336 RVA: 0x0044411C File Offset: 0x0044231C
	public float GetDragSwapSpeed()
	{
		return ConfigCommonParamById.GetFloatConfig("MotorMusicDragSwapSpeed").GetValueOrDefault(10f);
	}

	// Token: 0x060116A9 RID: 71337 RVA: 0x00444140 File Offset: 0x00442340
	[NullableContext(0)]
	public ValueTuple<float, float> GetDragScrollSpeedRange()
	{
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("MotorMusicSortScrollSpeedRange");
		if (floatArrayConfig != null && floatArrayConfig.Count >= 2)
		{
			return new ValueTuple<float, float>(floatArrayConfig[0], floatArrayConfig[1]);
		}
		return new ValueTuple<float, float>(0.001f, 0.01f);
	}

	// Token: 0x060116AA RID: 71338 RVA: 0x00444188 File Offset: 0x00442388
	public int GetStartDelay()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicStartDelay").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x060116AB RID: 71339 RVA: 0x004441BC File Offset: 0x004423BC
	public int GetFadeInTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicStartFadein").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x060116AC RID: 71340 RVA: 0x004441F0 File Offset: 0x004423F0
	public int GetFadeOutTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicStartFadeout").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x060116AD RID: 71341 RVA: 0x00444224 File Offset: 0x00442424
	public int GetMusicUnlockTipTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicUnlockTipTime").GetValueOrDefault(3f) * 1000f));
	}

	// Token: 0x060116AE RID: 71342 RVA: 0x00444258 File Offset: 0x00442458
	public int GetRestartFadeInTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicRestartFadein").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x060116AF RID: 71343 RVA: 0x0044428C File Offset: 0x0044248C
	public int GetInterruptFadeOutTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicInterruptFadeout").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x060116B0 RID: 71344 RVA: 0x004442BD File Offset: 0x004424BD
	public string GetScaleCurvePath()
	{
		return UiResourceConfig.Instance.GetResourcePath("AlbumScaleCurve");
	}

	// Token: 0x060116B1 RID: 71345 RVA: 0x004442CE File Offset: 0x004424CE
	public string GetAlphaCurvePath()
	{
		return UiResourceConfig.Instance.GetResourcePath("AlbumAlphaCurve");
	}

	// Token: 0x060116B2 RID: 71346 RVA: 0x004442DF File Offset: 0x004424DF
	public string GetRotateCurvePath()
	{
		return UiResourceConfig.Instance.GetResourcePath("AlbumRotateCurve");
	}

	// Token: 0x17001627 RID: 5671
	// (get) Token: 0x060116B3 RID: 71347 RVA: 0x004442F0 File Offset: 0x004424F0
	public static MotorcycleMusicPlayerConfig Instance
	{
		get
		{
			return MotorcycleMusicPlayerConfig._Instance;
		}
	}

	// Token: 0x060116B4 RID: 71348 RVA: 0x004442F7 File Offset: 0x004424F7
	public static MotorcycleMusicPlayerConfig GetOrCreateInstance()
	{
		if (MotorcycleMusicPlayerConfig._Instance == null)
		{
			MotorcycleMusicPlayerConfig.CreateInstance();
		}
		return MotorcycleMusicPlayerConfig._Instance;
	}

	// Token: 0x060116B5 RID: 71349 RVA: 0x0044430B File Offset: 0x0044250B
	public static bool CreateInstance()
	{
		if (MotorcycleMusicPlayerConfig._Instance != null)
		{
			return true;
		}
		MotorcycleMusicPlayerConfig._Instance = new MotorcycleMusicPlayerConfig();
		return true;
	}

	// Token: 0x060116B6 RID: 71350 RVA: 0x00444321 File Offset: 0x00442521
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060116B7 RID: 71351 RVA: 0x00444323 File Offset: 0x00442523
	public static void ResetStaticDefaultValue()
	{
		MotorcycleMusicPlayerConfig._Instance = null;
	}

	// Token: 0x060116B8 RID: 71352 RVA: 0x0044432B File Offset: 0x0044252B
	static MotorcycleMusicPlayerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleMusicPlayerConfig.CreateStaticDefaultValue), new Action(MotorcycleMusicPlayerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400844E RID: 33870
	[Nullable(2)]
	private static MotorcycleMusicPlayerConfig _Instance;
}
