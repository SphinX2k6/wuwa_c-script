using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005015 RID: 20501
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceRenderSettings : IStaticVariableResetter
	{
		// Token: 0x06034780 RID: 214912 RVA: 0x00C5BC4D File Offset: 0x00C59E4D
		static SequenceRenderSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceRenderSettings.CreateStaticDefaultValue), new Action(SequenceRenderSettings.ResetStaticDefaultValue));
		}

		// Token: 0x06034781 RID: 214913 RVA: 0x00C5BC6C File Offset: 0x00C59E6C
		public static void CreateStaticDefaultValue()
		{
			SequenceRenderSettings.TextureStreamingPC = new Dictionary<EGameQualitySettingLevel, bool>();
			SequenceRenderSettings.TextureStreamingAndroid = new Dictionary<EGameQualitySettingLevel, bool>();
			SequenceRenderSettings.TextureStreamingIOS = new Dictionary<EGameQualitySettingLevel, bool>();
			SequenceRenderSettings.TextureStreamingPS5 = new Dictionary<EGameQualitySettingLevel, bool>();
		}

		// Token: 0x06034782 RID: 214914 RVA: 0x00C5BC96 File Offset: 0x00C59E96
		public static void ResetStaticDefaultValue()
		{
			SequenceRenderSettings.TextureStreamingPC = null;
			SequenceRenderSettings.TextureStreamingAndroid = null;
			SequenceRenderSettings.TextureStreamingIOS = null;
			SequenceRenderSettings.TextureStreamingPS5 = null;
		}

		// Token: 0x06034783 RID: 214915 RVA: 0x00C5BCB0 File Offset: 0x00C59EB0
		public static void SetupSequenceSetting()
		{
			SequenceRenderSettings.TextureStreamingAndroid[EGameQualitySettingLevel.VeryLow] = true;
			SequenceRenderSettings.TextureStreamingAndroid[EGameQualitySettingLevel.Low] = true;
			SequenceRenderSettings.TextureStreamingAndroid[EGameQualitySettingLevel.Middle] = true;
			SequenceRenderSettings.TextureStreamingAndroid[EGameQualitySettingLevel.High] = true;
			SequenceRenderSettings.TextureStreamingAndroid[EGameQualitySettingLevel.VeryHigh] = true;
			SequenceRenderSettings.TextureStreamingAndroid[EGameQualitySettingLevel.Highest] = true;
			SequenceRenderSettings.TextureStreamingPC[EGameQualitySettingLevel.VeryLow] = false;
			SequenceRenderSettings.TextureStreamingPC[EGameQualitySettingLevel.Low] = true;
			SequenceRenderSettings.TextureStreamingPC[EGameQualitySettingLevel.Middle] = true;
			SequenceRenderSettings.TextureStreamingPC[EGameQualitySettingLevel.High] = true;
			SequenceRenderSettings.TextureStreamingPC[EGameQualitySettingLevel.VeryHigh] = true;
			SequenceRenderSettings.TextureStreamingPC[EGameQualitySettingLevel.Highest] = true;
			SequenceRenderSettings.TextureStreamingIOS[EGameQualitySettingLevel.VeryLow] = false;
			SequenceRenderSettings.TextureStreamingIOS[EGameQualitySettingLevel.Low] = true;
			SequenceRenderSettings.TextureStreamingIOS[EGameQualitySettingLevel.Middle] = true;
			SequenceRenderSettings.TextureStreamingIOS[EGameQualitySettingLevel.High] = true;
			SequenceRenderSettings.TextureStreamingIOS[EGameQualitySettingLevel.VeryHigh] = true;
			SequenceRenderSettings.TextureStreamingIOS[EGameQualitySettingLevel.Highest] = true;
			SequenceRenderSettings.TextureStreamingPS5[EGameQualitySettingLevel.VeryLow] = true;
			SequenceRenderSettings.TextureStreamingPS5[EGameQualitySettingLevel.Low] = true;
			SequenceRenderSettings.TextureStreamingPS5[EGameQualitySettingLevel.Middle] = true;
			SequenceRenderSettings.TextureStreamingPS5[EGameQualitySettingLevel.High] = true;
			SequenceRenderSettings.TextureStreamingPS5[EGameQualitySettingLevel.VeryHigh] = true;
			SequenceRenderSettings.TextureStreamingPS5[EGameQualitySettingLevel.Highest] = true;
		}

		// Token: 0x06034784 RID: 214916 RVA: 0x00C5BDE0 File Offset: 0x00C59FE0
		public static bool GetTexureStreamingEnable(EGameQualitySettingLevel level)
		{
			if (Info.Instance.IsPcPlatform())
			{
				bool flag;
				return !SequenceRenderSettings.TextureStreamingPC.TryGetValue(level, out flag) || flag;
			}
			if (Info.Instance.IsAndroidPlatform())
			{
				bool flag2;
				if (SequenceRenderSettings.TextureStreamingAndroid.TryGetValue(level, out flag2))
				{
					return !UKuroStaticLibrary.IsLowMemoryDevice() && flag2;
				}
				return !UKuroStaticLibrary.IsLowMemoryDevice();
			}
			else
			{
				if (!Info.Instance.IsIosPlatform())
				{
					bool flag3;
					return !Info.Instance.IsGamepadPlatform() || !SequenceRenderSettings.TextureStreamingPS5.TryGetValue(level, out flag3) || flag3;
				}
				bool flag4;
				if (SequenceRenderSettings.TextureStreamingIOS.TryGetValue(level, out flag4))
				{
					return !UKuroStaticLibrary.IsLowMemoryDevice() && flag4;
				}
				return !UKuroStaticLibrary.IsLowMemoryDevice();
			}
		}

		// Token: 0x0401BF30 RID: 114480
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingPC;

		// Token: 0x0401BF31 RID: 114481
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingAndroid;

		// Token: 0x0401BF32 RID: 114482
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingIOS;

		// Token: 0x0401BF33 RID: 114483
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingPS5;
	}
}
