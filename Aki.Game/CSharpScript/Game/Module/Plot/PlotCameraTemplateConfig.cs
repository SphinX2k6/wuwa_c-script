using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA6 RID: 16294
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotCameraTemplateConfig : ConfigBase
	{
		// Token: 0x0602939C RID: 168860 RVA: 0x00B93CE8 File Offset: 0x00B91EE8
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

		// Token: 0x17005374 RID: 21364
		// (get) Token: 0x0602939D RID: 168861 RVA: 0x00B93D48 File Offset: 0x00B91F48
		public static PlotCameraTemplateConfig Instance
		{
			get
			{
				return PlotCameraTemplateConfig._Instance;
			}
		}

		// Token: 0x0602939E RID: 168862 RVA: 0x00B93D4F File Offset: 0x00B91F4F
		public static PlotCameraTemplateConfig GetOrCreateInstance()
		{
			if (PlotCameraTemplateConfig._Instance == null)
			{
				PlotCameraTemplateConfig.CreateInstance();
			}
			return PlotCameraTemplateConfig._Instance;
		}

		// Token: 0x0602939F RID: 168863 RVA: 0x00B93D63 File Offset: 0x00B91F63
		public static bool CreateInstance()
		{
			if (PlotCameraTemplateConfig._Instance != null)
			{
				return true;
			}
			PlotCameraTemplateConfig._Instance = new PlotCameraTemplateConfig();
			return true;
		}

		// Token: 0x060293A0 RID: 168864 RVA: 0x00B93D79 File Offset: 0x00B91F79
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060293A1 RID: 168865 RVA: 0x00B93D7B File Offset: 0x00B91F7B
		public static void ResetStaticDefaultValue()
		{
			PlotCameraTemplateConfig._Instance = null;
		}

		// Token: 0x060293A2 RID: 168866 RVA: 0x00B93D83 File Offset: 0x00B91F83
		static PlotCameraTemplateConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotCameraTemplateConfig.CreateStaticDefaultValue), new Action(PlotCameraTemplateConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016704 RID: 91908
		[Nullable(2)]
		private static PlotCameraTemplateConfig _Instance;
	}
}
