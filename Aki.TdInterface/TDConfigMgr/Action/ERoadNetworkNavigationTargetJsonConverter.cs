using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F4 RID: 9204
	public class ERoadNetworkNavigationTargetJsonConverter : JsonConverter<ERoadNetworkNavigationTarget>
	{
		// Token: 0x0600C84A RID: 51274 RVA: 0x001D50E8 File Offset: 0x001D32E8
		public override ERoadNetworkNavigationTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoadNetworkNavigationTarget.SceneItem;
			}
			return ERoadNetworkNavigationTargetExtensions.FromString(@string);
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x001D510C File Offset: 0x001D330C
		public override void Write(Utf8JsonWriter writer, ERoadNetworkNavigationTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
