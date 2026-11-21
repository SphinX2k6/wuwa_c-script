using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200396F RID: 14703
	public class UiNavigationUtil : IStaticVariableResetter
	{
		// Token: 0x06025DBA RID: 155066 RVA: 0x00AA210A File Offset: 0x00AA030A
		static UiNavigationUtil()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationUtil.CreateStaticDefaultValue), new Action(UiNavigationUtil.ResetStaticDefaultValue));
		}

		// Token: 0x06025DBB RID: 155067 RVA: 0x00AA212C File Offset: 0x00AA032C
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

		// Token: 0x06025DBC RID: 155068 RVA: 0x00AA2157 File Offset: 0x00AA0357
		public static void CreateStaticDefaultValue()
		{
			UiNavigationUtil.IncId = 0;
		}

		// Token: 0x06025DBD RID: 155069 RVA: 0x00AA215F File Offset: 0x00AA035F
		public static void ResetStaticDefaultValue()
		{
			UiNavigationUtil.IncId = 0;
		}

		// Token: 0x06025DBE RID: 155070 RVA: 0x00AA2168 File Offset: 0x00AA0368
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

		// Token: 0x04014D59 RID: 85337
		public static int IncId;
	}
}
