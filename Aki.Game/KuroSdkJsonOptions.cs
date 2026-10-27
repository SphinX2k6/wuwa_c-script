using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;

// Token: 0x02000DE4 RID: 3556
public class KuroSdkJsonOptions : IStaticVariableResetter
{
	// Token: 0x0600562F RID: 22063 RVA: 0x000F8F03 File Offset: 0x000F7103
	static KuroSdkJsonOptions()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkJsonOptions.CreateStaticDefaultValue), new Action(KuroSdkJsonOptions.ResetStaticDefaultValue));
	}

	// Token: 0x170005FD RID: 1533
	// (get) Token: 0x06005630 RID: 22064 RVA: 0x000F8F22 File Offset: 0x000F7122
	[Nullable(1)]
	public static JsonSerializerOptions Unescaped
	{
		[NullableContext(1)]
		get
		{
			return KuroSdkJsonOptions._unescaped;
		}
	}

	// Token: 0x06005631 RID: 22065 RVA: 0x000F8F29 File Offset: 0x000F7129
	public static void CreateStaticDefaultValue()
	{
		KuroSdkJsonOptions._unescaped = new JsonSerializerOptions(JsonSettings.EncodeOptions)
		{
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x000F8F45 File Offset: 0x000F7145
	public static void ResetStaticDefaultValue()
	{
		KuroSdkJsonOptions._unescaped = null;
	}

	// Token: 0x040026DB RID: 9947
	[Nullable(2)]
	private static JsonSerializerOptions _unescaped;
}
