using System;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006251 RID: 25169
	public static class SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeExtensions
	{
		// Token: 0x0603CB9A RID: 248730 RVA: 0x0116F298 File Offset: 0x0116D498
		public static string ToEnumString(this SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType value)
		{
			string result;
			if (value == SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair)
			{
				result = "Chair";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0603CB9B RID: 248731 RVA: 0x0116F2C0 File Offset: 0x0116D4C0
		public static SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType FromString(string name)
		{
			SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType result;
			if (!SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603CB9C RID: 248732 RVA: 0x0116F2E9 File Offset: 0x0116D4E9
		public static bool TryFromString(string name, out SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair;
				return false;
			}
			if (name == "Chair")
			{
				value = SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair;
				return true;
			}
			value = SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair;
			return false;
		}

		// Token: 0x0603CB9D RID: 248733 RVA: 0x0116F30E File Offset: 0x0116D50E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Chair"
			};
		}

		// Token: 0x0603CB9E RID: 248734 RVA: 0x0116F31E File Offset: 0x0116D51E
		public static SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType[] GetValues()
		{
			return new SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType[1];
		}

		// Token: 0x0603CB9F RID: 248735 RVA: 0x0116F326 File Offset: 0x0116D526
		public static string[] GetNames()
		{
			return new string[]
			{
				"Chair"
			};
		}
	}
}
