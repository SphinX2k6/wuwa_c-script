using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using CSharpScript.Launcher.Util.Json;

namespace CSharpScript.Launcher.Util
{
	// Token: 0x0200006C RID: 108
	public class JsonSettings : IStaticVariableResetter
	{
		// Token: 0x060002DE RID: 734 RVA: 0x0000EF38 File Offset: 0x0000D138
		static JsonSettings()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JsonSettings.CreateStaticDefaultValue), new Action(JsonSettings.ResetStaticDefaultValue));
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000EF57 File Offset: 0x0000D157
		public static void CreateStaticDefaultValue()
		{
			JsonSerializerOptions options = LauncherJsonSettings.CreateOptions(JsonIgnoreCondition.WhenWritingNull);
			JsonSettings.EncodeOptions = LauncherJsonSettings.CreateOptionsWithMarkerConverters(options);
			JsonSettings.DecodeOptions = LauncherJsonSettings.CreateOptionsWithMarkerConverters(options);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000EF74 File Offset: 0x0000D174
		public static void ResetStaticDefaultValue()
		{
			JsonSettings.EncodeOptions = null;
			JsonSettings.DecodeOptions = null;
		}

		// Token: 0x040001CD RID: 461
		[Nullable(2)]
		public static JsonSerializerOptions EncodeOptions;

		// Token: 0x040001CE RID: 462
		[Nullable(2)]
		public static JsonSerializerOptions DecodeOptions;
	}
}
