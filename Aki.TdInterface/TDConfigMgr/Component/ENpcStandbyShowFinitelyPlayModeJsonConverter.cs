using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B7 RID: 2487
	public class ENpcStandbyShowFinitelyPlayModeJsonConverter : JsonConverter<ENpcStandbyShowFinitelyPlayMode>
	{
		// Token: 0x0600376A RID: 14186 RVA: 0x00090170 File Offset: 0x0008E370
		public override ENpcStandbyShowFinitelyPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcStandbyShowFinitelyPlayMode.Randomly;
			}
			return ENpcStandbyShowFinitelyPlayModeExtensions.FromString(@string);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00090194 File Offset: 0x0008E394
		public override void Write(Utf8JsonWriter writer, ENpcStandbyShowFinitelyPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
