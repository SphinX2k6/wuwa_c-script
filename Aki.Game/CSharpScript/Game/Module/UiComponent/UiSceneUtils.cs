using System;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiComponent
{
	// Token: 0x02004A09 RID: 18953
	public class UiSceneUtils : IStaticVariableResetter
	{
		// Token: 0x060312F2 RID: 201458 RVA: 0x00B685A7 File Offset: 0x00B667A7
		static UiSceneUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiSceneUtils.CreateStaticDefaultValue), new Action(UiSceneUtils.ResetStaticDefaultValue));
		}

		// Token: 0x060312F3 RID: 201459 RVA: 0x00B685C6 File Offset: 0x00B667C6
		public static void CreateStaticDefaultValue()
		{
			UiSceneUtils.SceneFloorReflection = true;
		}

		// Token: 0x060312F4 RID: 201460 RVA: 0x00B685CE File Offset: 0x00B667CE
		public static void ResetStaticDefaultValue()
		{
			UiSceneUtils.SceneFloorReflection = true;
		}

		// Token: 0x060312F5 RID: 201461 RVA: 0x00B685D8 File Offset: 0x00B667D8
		public static void SetSceneFloorReflection(bool isShow, bool isForce)
		{
			if (GameSettingsDeviceRender.Instance.IsQualcommGpu() && Info.Instance.IsPcPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.EnablePlanarReflection 0", null);
				return;
			}
			if (UiSceneUtils.SceneFloorReflection == isShow && !isForce)
			{
				return;
			}
			UiSceneUtils.SceneFloorReflection = isShow;
			if (isShow)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.EnablePlanarReflection 1", null);
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.EnablePlanarReflection 0", null);
		}

		// Token: 0x0401A4EF RID: 107759
		private static bool SceneFloorReflection;
	}
}
