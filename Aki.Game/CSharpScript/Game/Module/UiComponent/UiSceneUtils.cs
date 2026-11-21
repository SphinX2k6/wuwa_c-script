using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiComponent
{
	// Token: 0x02003985 RID: 14725
	public class UiSceneUtils : IStaticVariableResetter
	{
		// Token: 0x06025E40 RID: 155200 RVA: 0x00AA3D01 File Offset: 0x00AA1F01
		static UiSceneUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiSceneUtils.CreateStaticDefaultValue), new Action(UiSceneUtils.ResetStaticDefaultValue));
		}

		// Token: 0x06025E41 RID: 155201 RVA: 0x00AA3D20 File Offset: 0x00AA1F20
		public static void CreateStaticDefaultValue()
		{
			UiSceneUtils.SavedSceneFloorReflectionValue = null;
			UiSceneUtils.SceneFloorReflectionValue = 1f;
		}

		// Token: 0x06025E42 RID: 155202 RVA: 0x00AA3D37 File Offset: 0x00AA1F37
		public static void ResetStaticDefaultValue()
		{
			UiSceneUtils.SavedSceneFloorReflectionValue = null;
			UiSceneUtils.SceneFloorReflectionValue = 1f;
		}

		// Token: 0x06025E43 RID: 155203 RVA: 0x00AA3D4E File Offset: 0x00AA1F4E
		public static void RecordSceneFloorReflection()
		{
			if (UiSceneUtils.SavedSceneFloorReflectionValue != null)
			{
				return;
			}
			UiSceneUtils.SceneFloorReflectionValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.EnablePlanarReflection");
			UiSceneUtils.SavedSceneFloorReflectionValue = new float?(UiSceneUtils.SceneFloorReflectionValue);
		}

		// Token: 0x06025E44 RID: 155204 RVA: 0x00AA3D7C File Offset: 0x00AA1F7C
		public static void RestoreSceneFloorReflection()
		{
			if (UiSceneUtils.SavedSceneFloorReflectionValue == null)
			{
				return;
			}
			float value = UiSceneUtils.SavedSceneFloorReflectionValue.Value;
			UiSceneUtils.SavedSceneFloorReflectionValue = null;
			if (UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.EnablePlanarReflection") == UiSceneUtils.SceneFloorReflectionValue)
			{
				UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("r.Kuro.EnablePlanarReflection", value);
			}
		}

		// Token: 0x06025E45 RID: 155205 RVA: 0x00AA3DC8 File Offset: 0x00AA1FC8
		public static void SetSceneFloorReflection(bool isShow, bool isForce)
		{
			if (UiSceneUtils.SavedSceneFloorReflectionValue == null)
			{
				return;
			}
			if (GameSettingsDeviceRender.Instance.IsQualcommGpu() && Info.Instance.IsPcPlatform())
			{
				isShow = false;
			}
			float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.EnablePlanarReflection");
			if (consoleVariableFloatValue != UiSceneUtils.SceneFloorReflectionValue)
			{
				UiSceneUtils.SavedSceneFloorReflectionValue = new float?(consoleVariableFloatValue);
			}
			UiSceneUtils.SceneFloorReflectionValue = (isShow ? 1f : 0f);
			if (consoleVariableFloatValue == UiSceneUtils.SceneFloorReflectionValue && !isForce)
			{
				return;
			}
			UKuroStaticLibrary.SetConsoleVariableWithCurrentPriority_Float("r.Kuro.EnablePlanarReflection", UiSceneUtils.SceneFloorReflectionValue);
		}

		// Token: 0x04014D73 RID: 85363
		[Nullable(1)]
		private const string SceneFloorReflectionCVar = "r.Kuro.EnablePlanarReflection";

		// Token: 0x04014D74 RID: 85364
		private static float? SavedSceneFloorReflectionValue;

		// Token: 0x04014D75 RID: 85365
		private static float SceneFloorReflectionValue;
	}
}
