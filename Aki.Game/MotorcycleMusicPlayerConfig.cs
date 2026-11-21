using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001797 RID: 6039
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorcycleMusicPlayerConfig : ConfigBase
{
	// Token: 0x0600EB3C RID: 60220 RVA: 0x00450C7C File Offset: 0x0044EE7C
	public int GetFavoriteAlbumId()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomMusicCollectAlbum").Value;
	}

	// Token: 0x0600EB3D RID: 60221 RVA: 0x00450C9C File Offset: 0x0044EE9C
	public int GetDefaultAlbumId()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomMusicDefaultAlbum").Value;
	}

	// Token: 0x0600EB3E RID: 60222 RVA: 0x00450CBC File Offset: 0x0044EEBC
	public int GetFavoriteCountLimit()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomMusicCollectMaxCount").Value;
	}

	// Token: 0x0600EB3F RID: 60223 RVA: 0x00450CDC File Offset: 0x0044EEDC
	public float GetAlbumVelocity()
	{
		return ConfigCommonParamById.GetFloatConfig("MotorMusicUIVelocity").GetValueOrDefault(1f);
	}

	// Token: 0x0600EB40 RID: 60224 RVA: 0x00450D00 File Offset: 0x0044EF00
	public float GetDragSwapSpeed()
	{
		return ConfigCommonParamById.GetFloatConfig("MotorMusicDragSwapSpeed").GetValueOrDefault(10f);
	}

	// Token: 0x0600EB41 RID: 60225 RVA: 0x00450D24 File Offset: 0x0044EF24
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

	// Token: 0x0600EB42 RID: 60226 RVA: 0x00450D6C File Offset: 0x0044EF6C
	public int GetStartDelay()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicStartDelay").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x0600EB43 RID: 60227 RVA: 0x00450DA0 File Offset: 0x0044EFA0
	public int GetFadeInTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicStartFadein").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x0600EB44 RID: 60228 RVA: 0x00450DD4 File Offset: 0x0044EFD4
	public int GetFadeOutTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicStartFadeout").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x0600EB45 RID: 60229 RVA: 0x00450E08 File Offset: 0x0044F008
	public int GetMusicUnlockTipTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicUnlockTipTime").GetValueOrDefault(3f) * 1000f));
	}

	// Token: 0x0600EB46 RID: 60230 RVA: 0x00450E3C File Offset: 0x0044F03C
	public int GetRestartFadeInTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicRestartFadein").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x0600EB47 RID: 60231 RVA: 0x00450E70 File Offset: 0x0044F070
	public int GetInterruptFadeOutTime()
	{
		return (int)Math.Round((double)(ConfigCommonParamById.GetFloatConfig("MotorMusicInterruptFadeout").GetValueOrDefault(1f) * 1000f));
	}

	// Token: 0x0600EB48 RID: 60232 RVA: 0x00450EA1 File Offset: 0x0044F0A1
	public string GetScaleCurvePath()
	{
		return UiResourceConfig.Instance.GetResourcePath("AlbumScaleCurve");
	}

	// Token: 0x0600EB49 RID: 60233 RVA: 0x00450EB2 File Offset: 0x0044F0B2
	public string GetAlphaCurvePath()
	{
		return UiResourceConfig.Instance.GetResourcePath("AlbumAlphaCurve");
	}

	// Token: 0x0600EB4A RID: 60234 RVA: 0x00450EC3 File Offset: 0x0044F0C3
	public string GetRotateCurvePath()
	{
		return UiResourceConfig.Instance.GetResourcePath("AlbumRotateCurve");
	}

	// Token: 0x1700165E RID: 5726
	// (get) Token: 0x0600EB4B RID: 60235 RVA: 0x00450ED4 File Offset: 0x0044F0D4
	public static MotorcycleMusicPlayerConfig Instance
	{
		get
		{
			return MotorcycleMusicPlayerConfig._Instance;
		}
	}

	// Token: 0x0600EB4C RID: 60236 RVA: 0x00450EDB File Offset: 0x0044F0DB
	public static MotorcycleMusicPlayerConfig GetOrCreateInstance()
	{
		if (MotorcycleMusicPlayerConfig._Instance == null)
		{
			MotorcycleMusicPlayerConfig.CreateInstance();
		}
		return MotorcycleMusicPlayerConfig._Instance;
	}

	// Token: 0x0600EB4D RID: 60237 RVA: 0x00450EEF File Offset: 0x0044F0EF
	public static bool CreateInstance()
	{
		if (MotorcycleMusicPlayerConfig._Instance != null)
		{
			return true;
		}
		MotorcycleMusicPlayerConfig._Instance = new MotorcycleMusicPlayerConfig();
		return true;
	}

	// Token: 0x0600EB4E RID: 60238 RVA: 0x00450F05 File Offset: 0x0044F105
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EB4F RID: 60239 RVA: 0x00450F07 File Offset: 0x0044F107
	public static void ResetStaticDefaultValue()
	{
		MotorcycleMusicPlayerConfig._Instance = null;
	}

	// Token: 0x0600EB50 RID: 60240 RVA: 0x00450F0F File Offset: 0x0044F10F
	static MotorcycleMusicPlayerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleMusicPlayerConfig.CreateStaticDefaultValue), new Action(MotorcycleMusicPlayerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400858C RID: 34188
	[Nullable(2)]
	private static MotorcycleMusicPlayerConfig _Instance;
}
