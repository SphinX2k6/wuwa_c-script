using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200268B RID: 9867
	public class ERoadNetworkNavigationTargetJsonConverter : JsonConverter<ERoadNetworkNavigationTarget>
	{
		// Token: 0x0600D4CD RID: 54477 RVA: 0x001EE894 File Offset: 0x001ECA94
		public override ERoadNetworkNavigationTarget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoadNetworkNavigationTarget.SceneItem;
			}
			return ERoadNetworkNavigationTargetExtensions.FromString(@string);
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x001EE8B8 File Offset: 0x001ECAB8
		public override void Write(Utf8JsonWriter writer, ERoadNetworkNavigationTarget value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
