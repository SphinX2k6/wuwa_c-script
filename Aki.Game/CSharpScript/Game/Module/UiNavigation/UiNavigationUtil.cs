using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049F5 RID: 18933
	public class UiNavigationUtil : IStaticVariableResetter
	{
		// Token: 0x06031284 RID: 201348 RVA: 0x00B6714E File Offset: 0x00B6534E
		static UiNavigationUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationUtil.CreateStaticDefaultValue), new Action(UiNavigationUtil.ResetStaticDefaultValue));
		}

		// Token: 0x06031285 RID: 201349 RVA: 0x00B67170 File Offset: 0x00B65370
		[NullableContext(1)]
		public static string GetFullPathOfActor([Nullable(2)] AActor actor)
		{
			if (actor == null)
			{
				return "null";
			}
			string result = "";
			ULGUIBPLibrary.GetFullPathOfActor(GlobalData.World, actor, ref result);
			return result;
		}

		// Token: 0x06031286 RID: 201350 RVA: 0x00B6719B File Offset: 0x00B6539B
		public static void CreateStaticDefaultValue()
		{
			UiNavigationUtil.IncId = 0;
		}

		// Token: 0x06031287 RID: 201351 RVA: 0x00B671A3 File Offset: 0x00B653A3
		public static void ResetStaticDefaultValue()
		{
			UiNavigationUtil.IncId = 0;
		}

		// Token: 0x06031288 RID: 201352 RVA: 0x00B671AC File Offset: 0x00B653AC
		[NullableContext(1)]
		public static IReadOnlyList<string> GetKeyNameListByConfig(HotKeyMap config)
		{
			string actionName = config.ActionName;
			string axisName = config.AxisName;
			if (!string.IsNullOrEmpty(actionName))
			{
				ValueTuple<IReadOnlyList<string>, bool>? platformKeyNameDataByActionName = UiNavigationModel.Instance.GetPlatformKeyNameDataByActionName(actionName);
				if (platformKeyNameDataByActionName != null)
				{
					if (!platformKeyNameDataByActionName.Value.Item2)
					{
						return new <>z__ReadOnlySingleElementList<string>(platformKeyNameDataByActionName.Value.Item1[0]);
					}
					return platformKeyNameDataByActionName.Value.Item1;
				}
			}
			else if (!string.IsNullOrEmpty(axisName))
			{
				IReadOnlyList<string> platformKeyNameListByAxisName = UiNavigationModel.Instance.GetPlatformKeyNameListByAxisName(axisName);
				if (platformKeyNameListByAxisName == null)
				{
					return Array.Empty<string>();
				}
				return new <>z__ReadOnlySingleElementList<string>(platformKeyNameListByAxisName[0]);
			}
			return Array.Empty<string>();
		}

		// Token: 0x0401A4E7 RID: 107751
		public static int IncId;
	}
}
