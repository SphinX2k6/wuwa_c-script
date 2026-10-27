using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200700C RID: 28684
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTouchUiEditConfig : ConfigBase
	{
		// Token: 0x06045CCA RID: 285898 RVA: 0x0115B799 File Offset: 0x01159999
		[NullableContext(2)]
		public IReadOnlyList<CommonTouchUiEdit> GetConfigListByEditGroup(int group)
		{
			return ConfigCommonTouchUiEditByEditGroup.GetConfigList(group, true);
		}

		// Token: 0x06045CCB RID: 285899 RVA: 0x0115B7A2 File Offset: 0x011599A2
		public CommonTouchUiEdit? GetConfigById(int id)
		{
			return ConfigCommonTouchUiEditById.GetConfig(id, true);
		}

		// Token: 0x06045CCC RID: 285900 RVA: 0x0115B7AB File Offset: 0x011599AB
		[return: Nullable(2)]
		public IReadOnlyList<CommonTouchUiEdit> GetConfigListByPanelResId(string resId)
		{
			return ConfigCommonTouchUiEditByPanelResId.GetConfigList(resId, true);
		}

		// Token: 0x06045CCD RID: 285901 RVA: 0x0115B7B4 File Offset: 0x011599B4
		public CommonTouchUiEditGroup? GetGroupConfigById(int id)
		{
			return ConfigCommonTouchUiEditGroupById.GetConfig(id, true);
		}

		// Token: 0x17009B9B RID: 39835
		// (get) Token: 0x06045CCE RID: 285902 RVA: 0x0115B7BD File Offset: 0x011599BD
		public static CommonTouchUiEditConfig Instance
		{
			get
			{
				return CommonTouchUiEditConfig._Instance;
			}
		}

		// Token: 0x06045CCF RID: 285903 RVA: 0x0115B7C4 File Offset: 0x011599C4
		public static CommonTouchUiEditConfig GetOrCreateInstance()
		{
			if (CommonTouchUiEditConfig._Instance == null)
			{
				CommonTouchUiEditConfig.CreateInstance();
			}
			return CommonTouchUiEditConfig._Instance;
		}

		// Token: 0x06045CD0 RID: 285904 RVA: 0x0115B7D8 File Offset: 0x011599D8
		public static bool CreateInstance()
		{
			if (CommonTouchUiEditConfig._Instance != null)
			{
				return true;
			}
			CommonTouchUiEditConfig._Instance = new CommonTouchUiEditConfig();
			return true;
		}

		// Token: 0x06045CD1 RID: 285905 RVA: 0x0115B7EE File Offset: 0x011599EE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045CD2 RID: 285906 RVA: 0x0115B7F0 File Offset: 0x011599F0
		public static void ResetStaticDefaultValue()
		{
			CommonTouchUiEditConfig._Instance = null;
		}

		// Token: 0x06045CD3 RID: 285907 RVA: 0x0115B7F8 File Offset: 0x011599F8
		static CommonTouchUiEditConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonTouchUiEditConfig.CreateStaticDefaultValue), new Action(CommonTouchUiEditConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04024803 RID: 149507
		[Nullable(2)]
		private static CommonTouchUiEditConfig _Instance;
	}
}
