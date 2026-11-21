using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004617 RID: 17943
	public class EMapRogueSpineAnimJsonConverter : JsonConverter<EMapRogueSpineAnim>
	{
		// Token: 0x0602D13F RID: 184639 RVA: 0x00C9A324 File Offset: 0x00C98524
		public override EMapRogueSpineAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMapRogueSpineAnim.Idle;
			}
			return EMapRogueSpineAnimExtensions.FromString(@string);
		}

		// Token: 0x0602D140 RID: 184640 RVA: 0x00C9A348 File Offset: 0x00C98548
		public override void Write(Utf8JsonWriter writer, EMapRogueSpineAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
