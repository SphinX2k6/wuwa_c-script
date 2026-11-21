using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006E RID: 110
	public class JsonSettings : IStaticVariableResetter
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0000F460 File Offset: 0x0000D660
		static JsonSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JsonSettings.CreateStaticDefaultValue), new Action(JsonSettings.ResetStaticDefaultValue));
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000F47F File Offset: 0x0000D67F
		public static void CreateStaticDefaultValue()
		{
			JsonSerializerOptions options = LauncherJsonSettings.CreateOptions(JsonIgnoreCondition.WhenWritingNull);
			JsonSettings.EncodeOptions = LauncherJsonSettings.CreateOptionsWithMarkerConverters(options);
			JsonSettings.DecodeOptions = LauncherJsonSettings.CreateOptionsWithMarkerConverters(options);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000F49C File Offset: 0x0000D69C
		public static void ResetStaticDefaultValue()
		{
			JsonSettings.EncodeOptions = null;
			JsonSettings.DecodeOptions = null;
		}

		// Token: 0x040001F5 RID: 501
		[Nullable(2)]
		public static JsonSerializerOptions EncodeOptions;

		// Token: 0x040001F6 RID: 502
		[Nullable(2)]
		public static JsonSerializerOptions DecodeOptions;
	}
}
