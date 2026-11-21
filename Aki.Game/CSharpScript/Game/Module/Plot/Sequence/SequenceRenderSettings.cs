using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FDF RID: 16351
	[NullableContext(2)]
	[Nullable(0)]
	public class SequenceRenderSettings : IStaticVariableResetter
	{
		// Token: 0x06029623 RID: 169507 RVA: 0x00BA718D File Offset: 0x00BA538D
		static SequenceRenderSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceRenderSettings.CreateStaticDefaultValue), new Action(SequenceRenderSettings.ResetStaticDefaultValue));
		}

		// Token: 0x06029624 RID: 169508 RVA: 0x00BA71AC File Offset: 0x00BA53AC
		public static void CreateStaticDefaultValue()
		{
			SequenceRenderSettings.TextureStreamingPC = new Dictionary<EGameQualitySettingLevel, bool>();
			SequenceRenderSettings.TextureStreamingAndroid = new Dictionary<EGameQualitySettingLevel, bool>();
			SequenceRenderSettings.TextureStreamingIOS = new Dictionary<EGameQualitySettingLevel, bool>();
			SequenceRenderSettings.TextureStreamingPS5 = new Dictionary<EGameQualitySettingLevel, bool>();
		}

		// Token: 0x06029625 RID: 169509 RVA: 0x00BA71D6 File Offset: 0x00BA53D6
		public static void ResetStaticDefaultValue()
		{
			SequenceRenderSettings.TextureStreamingPC = null;
			SequenceRenderSettings.TextureStreamingAndroid = null;
			SequenceRenderSettings.TextureStreamingIOS = null;
			SequenceRenderSettings.TextureStreamingPS5 = null;
		}

		// Token: 0x06029626 RID: 169510 RVA: 0x00BA71F0 File Offset: 0x00BA53F0
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

		// Token: 0x06029627 RID: 169511 RVA: 0x00BA7320 File Offset: 0x00BA5520
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

		// Token: 0x04016919 RID: 92441
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingPC;

		// Token: 0x0401691A RID: 92442
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingAndroid;

		// Token: 0x0401691B RID: 92443
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingIOS;

		// Token: 0x0401691C RID: 92444
		private static Dictionary<EGameQualitySettingLevel, bool> TextureStreamingPS5;
	}
}
