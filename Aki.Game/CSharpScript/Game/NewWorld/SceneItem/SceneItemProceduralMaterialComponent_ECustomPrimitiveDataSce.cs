using System;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200719C RID: 29084
	public static class SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeExtensions
	{
		// Token: 0x060472A4 RID: 291492 RVA: 0x0121527C File Offset: 0x0121347C
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

		// Token: 0x060472A5 RID: 291493 RVA: 0x012152A4 File Offset: 0x012134A4
		public static SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType FromString(string name)
		{
			SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType result;
			if (!SceneItemProceduralMaterialComponent_ECustomPrimitiveDataSceneItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060472A6 RID: 291494 RVA: 0x012152CD File Offset: 0x012134CD
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

		// Token: 0x060472A7 RID: 291495 RVA: 0x012152F2 File Offset: 0x012134F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Chair"
			};
		}

		// Token: 0x060472A8 RID: 291496 RVA: 0x01215302 File Offset: 0x01213502
		public static SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType[] GetValues()
		{
			return new SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType[1];
		}

		// Token: 0x060472A9 RID: 291497 RVA: 0x0121530A File Offset: 0x0121350A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Chair"
			};
		}
	}
}
