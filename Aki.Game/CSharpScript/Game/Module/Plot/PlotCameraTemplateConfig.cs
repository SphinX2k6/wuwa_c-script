using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FDC RID: 20444
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotCameraTemplateConfig : ConfigBase
	{
		// Token: 0x06034513 RID: 214291 RVA: 0x00C49CA0 File Offset: 0x00C47EA0
		public FlowTemplateData? GetCameraTemplateConfig(int id)
		{
			FlowTemplateData? config = ConfigFlowTemplateDataById.GetConfig(id, false);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "找不到相机模板配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CameraTemplate ID", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return new FlowTemplateData?(config.Value);
		}

		// Token: 0x17007FC0 RID: 32704
		// (get) Token: 0x06034514 RID: 214292 RVA: 0x00C49D00 File Offset: 0x00C47F00
		public static PlotCameraTemplateConfig Instance
		{
			get
			{
				return PlotCameraTemplateConfig._Instance;
			}
		}

		// Token: 0x06034515 RID: 214293 RVA: 0x00C49D07 File Offset: 0x00C47F07
		public static PlotCameraTemplateConfig GetOrCreateInstance()
		{
			if (PlotCameraTemplateConfig._Instance == null)
			{
				PlotCameraTemplateConfig.CreateInstance();
			}
			return PlotCameraTemplateConfig._Instance;
		}

		// Token: 0x06034516 RID: 214294 RVA: 0x00C49D1B File Offset: 0x00C47F1B
		public static bool CreateInstance()
		{
			if (PlotCameraTemplateConfig._Instance != null)
			{
				return true;
			}
			PlotCameraTemplateConfig._Instance = new PlotCameraTemplateConfig();
			return true;
		}

		// Token: 0x06034517 RID: 214295 RVA: 0x00C49D31 File Offset: 0x00C47F31
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034518 RID: 214296 RVA: 0x00C49D33 File Offset: 0x00C47F33
		public static void ResetStaticDefaultValue()
		{
			PlotCameraTemplateConfig._Instance = null;
		}

		// Token: 0x06034519 RID: 214297 RVA: 0x00C49D3B File Offset: 0x00C47F3B
		static PlotCameraTemplateConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotCameraTemplateConfig.CreateStaticDefaultValue), new Action(PlotCameraTemplateConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD29 RID: 113961
		[Nullable(2)]
		private static PlotCameraTemplateConfig _Instance;
	}
}
