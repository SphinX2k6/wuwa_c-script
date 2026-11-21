using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200618D RID: 24973
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTouchUiEditConfig : ConfigBase
	{
		// Token: 0x0603BE80 RID: 245376 RVA: 0x01105BA5 File Offset: 0x01103DA5
		[NullableContext(2)]
		public IReadOnlyList<CommonTouchUiEdit> GetConfigListByEditGroup(int group)
		{
			return ConfigCommonTouchUiEditByEditGroup.GetConfigList(group, true);
		}

		// Token: 0x0603BE81 RID: 245377 RVA: 0x01105BAE File Offset: 0x01103DAE
		public CommonTouchUiEdit? GetConfigById(int id)
		{
			return ConfigCommonTouchUiEditById.GetConfig(id, true);
		}

		// Token: 0x0603BE82 RID: 245378 RVA: 0x01105BB7 File Offset: 0x01103DB7
		[return: Nullable(2)]
		public IReadOnlyList<CommonTouchUiEdit> GetConfigListByPanelResId(string resId)
		{
			return ConfigCommonTouchUiEditByPanelResId.GetConfigList(resId, true);
		}

		// Token: 0x0603BE83 RID: 245379 RVA: 0x01105BC0 File Offset: 0x01103DC0
		public CommonTouchUiEditGroup? GetGroupConfigById(int id)
		{
			return ConfigCommonTouchUiEditGroupById.GetConfig(id, true);
		}

		// Token: 0x170070DB RID: 28891
		// (get) Token: 0x0603BE84 RID: 245380 RVA: 0x01105BC9 File Offset: 0x01103DC9
		public static CommonTouchUiEditConfig Instance
		{
			get
			{
				return CommonTouchUiEditConfig._Instance;
			}
		}

		// Token: 0x0603BE85 RID: 245381 RVA: 0x01105BD0 File Offset: 0x01103DD0
		public static CommonTouchUiEditConfig GetOrCreateInstance()
		{
			if (CommonTouchUiEditConfig._Instance == null)
			{
				CommonTouchUiEditConfig.CreateInstance();
			}
			return CommonTouchUiEditConfig._Instance;
		}

		// Token: 0x0603BE86 RID: 245382 RVA: 0x01105BE4 File Offset: 0x01103DE4
		public static bool CreateInstance()
		{
			if (CommonTouchUiEditConfig._Instance != null)
			{
				return true;
			}
			CommonTouchUiEditConfig._Instance = new CommonTouchUiEditConfig();
			return true;
		}

		// Token: 0x0603BE87 RID: 245383 RVA: 0x01105BFA File Offset: 0x01103DFA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BE88 RID: 245384 RVA: 0x01105BFC File Offset: 0x01103DFC
		public static void ResetStaticDefaultValue()
		{
			CommonTouchUiEditConfig._Instance = null;
		}

		// Token: 0x0603BE89 RID: 245385 RVA: 0x01105C04 File Offset: 0x01103E04
		static CommonTouchUiEditConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonTouchUiEditConfig.CreateStaticDefaultValue), new Action(CommonTouchUiEditConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401FAB9 RID: 129721
		[Nullable(2)]
		private static CommonTouchUiEditConfig _Instance;
	}
}
