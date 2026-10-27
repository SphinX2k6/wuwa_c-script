using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02005001 RID: 20481
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotMontageConfig : ConfigBase
	{
		// Token: 0x06034668 RID: 214632 RVA: 0x00C52040 File Offset: 0x00C50240
		public MontageData? GetPlotMontageConfig(int id)
		{
			MontageData? config = ConfigMontageDataById.GetConfig(id, false);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "找不到剧情蒙太奇配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Montage ID", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x06034669 RID: 214633 RVA: 0x00C52098 File Offset: 0x00C50298
		public AbpMontageData? GetPlotAbpMontageConfig(int id)
		{
			AbpMontageData? config = ConfigAbpMontageDataById.GetConfig(id, false);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.ZWY;
				string message = "找不到剧情ABP蒙太奇配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Montage ID", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603466A RID: 214634 RVA: 0x00C520F0 File Offset: 0x00C502F0
		public OverlayAbpMontageData? GetOverlayAbpMontageConfig(int id)
		{
			OverlayAbpMontageData? config = ConfigOverlayAbpMontageDataById.GetConfig(id, false);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "找不到剧情叠加ABP蒙太奇配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Montage ID", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603466B RID: 214635 RVA: 0x00C52148 File Offset: 0x00C50348
		public AbpState? GetAbpStateConfig(string path)
		{
			AbpState? config = ConfigAbpStateByAbp.GetConfig(path, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "多状态ABP找不到状态定义";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ABP Path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x17007FE8 RID: 32744
		// (get) Token: 0x0603466C RID: 214636 RVA: 0x00C52198 File Offset: 0x00C50398
		public static PlotMontageConfig Instance
		{
			get
			{
				return PlotMontageConfig._Instance;
			}
		}

		// Token: 0x0603466D RID: 214637 RVA: 0x00C5219F File Offset: 0x00C5039F
		public static PlotMontageConfig GetOrCreateInstance()
		{
			if (PlotMontageConfig._Instance == null)
			{
				PlotMontageConfig.CreateInstance();
			}
			return PlotMontageConfig._Instance;
		}

		// Token: 0x0603466E RID: 214638 RVA: 0x00C521B3 File Offset: 0x00C503B3
		public static bool CreateInstance()
		{
			if (PlotMontageConfig._Instance != null)
			{
				return true;
			}
			PlotMontageConfig._Instance = new PlotMontageConfig();
			return true;
		}

		// Token: 0x0603466F RID: 214639 RVA: 0x00C521C9 File Offset: 0x00C503C9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034670 RID: 214640 RVA: 0x00C521CB File Offset: 0x00C503CB
		public static void ResetStaticDefaultValue()
		{
			PlotMontageConfig._Instance = null;
		}

		// Token: 0x06034671 RID: 214641 RVA: 0x00C521D3 File Offset: 0x00C503D3
		static PlotMontageConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotMontageConfig.CreateStaticDefaultValue), new Action(PlotMontageConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BE7B RID: 114299
		[Nullable(2)]
		private static PlotMontageConfig _Instance;
	}
}
