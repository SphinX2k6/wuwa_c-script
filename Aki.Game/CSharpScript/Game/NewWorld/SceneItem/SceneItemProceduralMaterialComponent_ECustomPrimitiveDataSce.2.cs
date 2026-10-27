using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200719D RID: 29085
	public class SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeJsonConverter : JsonConverter<SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType>
	{
		// Token: 0x060472AA RID: 291498 RVA: 0x0121531C File Offset: 0x0121351C
		public override SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair;
			}
			return SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeExtensions.FromString(@string);
		}

		// Token: 0x060472AB RID: 291499 RVA: 0x01215340 File Offset: 0x01213540
		public override void Write(Utf8JsonWriter writer, SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
