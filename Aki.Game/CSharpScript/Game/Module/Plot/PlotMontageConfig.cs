using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FCB RID: 16331
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotMontageConfig : ConfigBase
	{
		// Token: 0x060294F5 RID: 169205 RVA: 0x00B9BDC4 File Offset: 0x00B99FC4
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

		// Token: 0x060294F6 RID: 169206 RVA: 0x00B9BE1C File Offset: 0x00B9A01C
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

		// Token: 0x060294F7 RID: 169207 RVA: 0x00B9BE74 File Offset: 0x00B9A074
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

		// Token: 0x060294F8 RID: 169208 RVA: 0x00B9BECC File Offset: 0x00B9A0CC
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

		// Token: 0x1700539D RID: 21405
		// (get) Token: 0x060294F9 RID: 169209 RVA: 0x00B9BF1C File Offset: 0x00B9A11C
		public static PlotMontageConfig Instance
		{
			get
			{
				return PlotMontageConfig._Instance;
			}
		}

		// Token: 0x060294FA RID: 169210 RVA: 0x00B9BF23 File Offset: 0x00B9A123
		public static PlotMontageConfig GetOrCreateInstance()
		{
			if (PlotMontageConfig._Instance == null)
			{
				PlotMontageConfig.CreateInstance();
			}
			return PlotMontageConfig._Instance;
		}

		// Token: 0x060294FB RID: 169211 RVA: 0x00B9BF37 File Offset: 0x00B9A137
		public static bool CreateInstance()
		{
			if (PlotMontageConfig._Instance != null)
			{
				return true;
			}
			PlotMontageConfig._Instance = new PlotMontageConfig();
			return true;
		}

		// Token: 0x060294FC RID: 169212 RVA: 0x00B9BF4D File Offset: 0x00B9A14D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060294FD RID: 169213 RVA: 0x00B9BF4F File Offset: 0x00B9A14F
		public static void ResetStaticDefaultValue()
		{
			PlotMontageConfig._Instance = null;
		}

		// Token: 0x060294FE RID: 169214 RVA: 0x00B9BF57 File Offset: 0x00B9A157
		static PlotMontageConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotMontageConfig.CreateStaticDefaultValue), new Action(PlotMontageConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016858 RID: 92248
		[Nullable(2)]
		private static PlotMontageConfig _Instance;
	}
}
