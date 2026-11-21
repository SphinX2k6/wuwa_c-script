using System;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using CSharpScript.Core.Common;

// Token: 0x02000296 RID: 662
public class KuroSdkJsonOptions : IStaticVariableResetter
{
	// Token: 0x060029BD RID: 10685 RVA: 0x00100653 File Offset: 0x000FE853
	static KuroSdkJsonOptions()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KuroSdkJsonOptions.CreateStaticDefaultValue), new Action(KuroSdkJsonOptions.ResetStaticDefaultValue));
	}

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x060029BE RID: 10686 RVA: 0x00100672 File Offset: 0x000FE872
	[Nullable(1)]
	public static JsonSerializerOptions Unescaped
	{
		[NullableContext(1)]
		get
		{
			return KuroSdkJsonOptions._unescaped;
		}
	}

	// Token: 0x060029BF RID: 10687 RVA: 0x00100679 File Offset: 0x000FE879
	public static void CreateStaticDefaultValue()
	{
		KuroSdkJsonOptions._unescaped = new JsonSerializerOptions(JsonSettings.EncodeOptions)
		{
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};
	}

	// Token: 0x060029C0 RID: 10688 RVA: 0x00100695 File Offset: 0x000FE895
	public static void ResetStaticDefaultValue()
	{
		KuroSdkJsonOptions._unescaped = null;
	}

	// Token: 0x04002763 RID: 10083
	[Nullable(2)]
	private static JsonSerializerOptions _unescaped;
}
