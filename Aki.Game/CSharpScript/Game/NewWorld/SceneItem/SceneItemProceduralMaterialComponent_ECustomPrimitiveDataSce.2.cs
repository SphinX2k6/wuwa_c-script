using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006252 RID: 25170
	public class SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeJsonConverter : JsonConverter<SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType>
	{
		// Token: 0x0603CBA0 RID: 248736 RVA: 0x0116F338 File Offset: 0x0116D538
		public override SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair;
			}
			return SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0603CBA1 RID: 248737 RVA: 0x0116F35C File Offset: 0x0116D55C
		public override void Write(Utf8JsonWriter writer, SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
