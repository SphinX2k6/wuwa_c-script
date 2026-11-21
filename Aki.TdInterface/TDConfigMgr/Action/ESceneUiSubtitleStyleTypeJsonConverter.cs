using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200269B RID: 9883
	public class ESceneUiSubtitleStyleTypeJsonConverter : JsonConverter<ESceneUiSubtitleStyleType>
	{
		// Token: 0x0600D515 RID: 54549 RVA: 0x001EF1B4 File Offset: 0x001ED3B4
		public override ESceneUiSubtitleStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
			}
			return ESceneUiSubtitleStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D516 RID: 54550 RVA: 0x001EF1D8 File Offset: 0x001ED3D8
		public override void Write(Utf8JsonWriter writer, ESceneUiSubtitleStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
