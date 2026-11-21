using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B0A RID: 2826
	public class ETurntableConnectorDiskJsonConverter : JsonConverter<ETurntableConnectorDisk>
	{
		// Token: 0x06003DC1 RID: 15809 RVA: 0x0009DEA8 File Offset: 0x0009C0A8
		public override ETurntableConnectorDisk Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETurntableConnectorDisk.Disk0;
			}
			return ETurntableConnectorDiskExtensions.FromString(@string);
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x0009DECC File Offset: 0x0009C0CC
		public override void Write(Utf8JsonWriter writer, ETurntableConnectorDisk value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
