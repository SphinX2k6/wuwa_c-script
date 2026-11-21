using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200396E RID: 14702
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class UiNavigationConfig : ConfigBase
	{
		// Token: 0x06025DA9 RID: 155049 RVA: 0x00AA1DC0 File Offset: 0x00A9FFC0
		public bool GetHighlightWhenMouseMoveOut()
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("highlight_when_mouse_moveout");
			if (boolConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "鼠标移出button表现参数找不到, 请检测c.参数字段\"highlight_when_mouse_moveout\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return boolConfig.GetValueOrDefault();
		}

		// Token: 0x06025DAA RID: 155050 RVA: 0x00AA1E08 File Offset: 0x00AA0008
		public bool GetMobileHighlight()
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("mobile_highlight");
			if (boolConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "移动端是否显示按钮高亮参数找不到, 请检测c.参数字段\"mobile_highlight\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return boolConfig.GetValueOrDefault();
		}

		// Token: 0x06025DAB RID: 155051 RVA: 0x00AA1E50 File Offset: 0x00AA0050
		public bool GetPcPress()
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("pc_press");
			if (boolConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "PC端是否显示按钮按下参数找不到, 请检测c.参数字段\"pc_press\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return boolConfig.GetValueOrDefault();
		}

		// Token: 0x06025DAC RID: 155052 RVA: 0x00AA1E98 File Offset: 0x00AA0098
		public float GetNavigateTolerance()
		{
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("navigate_tolerance");
			if (floatConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "导航组同向误差找不到, 请检测c.参数字段\"navigate_tolerance\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return floatConfig.GetValueOrDefault();
		}

		// Token: 0x06025DAD RID: 155053 RVA: 0x00AA1EE0 File Offset: 0x00AA00E0
		public HotKeyView? GetHotKeyViewConfig(int id)
		{
			HotKeyView? config = ConfigHotKeyViewById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "热键界面配置找不到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06025DAE RID: 155054 RVA: 0x00AA1F30 File Offset: 0x00AA0130
		public HotKeyMap? GetHotKeyMapConfig(int id)
		{
			if (id == -1)
			{
				return null;
			}
			HotKeyMap? config = ConfigHotKeyMapById.GetConfig(id, true);
			if (config == null && id != -1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "热键映射配置找不到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06025DAF RID: 155055 RVA: 0x00AA1F90 File Offset: 0x00AA0190
		public HotKeyType? GetHotKeyTypeConfig(int id)
		{
			return ConfigHotKeyTypeById.GetConfig(id, true);
		}

		// Token: 0x06025DB0 RID: 155056 RVA: 0x00AA1F9C File Offset: 0x00AA019C
		public HotKeyIcon? GetHotKeyIconConfig(string keyName, bool warnOnly = false)
		{
			HotKeyIcon? config = ConfigHotKeyIconByKeyName.GetConfig(keyName, true);
			if (config == null)
			{
				if (warnOnly)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiNavigation;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "快捷键图标配置找不到";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("keyName", keyName);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiNavigation;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "快捷键图标配置找不到";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("keyName", keyName);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			return config;
		}

		// Token: 0x06025DB1 RID: 155057 RVA: 0x00AA2014 File Offset: 0x00AA0214
		[return: Nullable(2)]
		public string GetHotKeyText(string id)
		{
			HotKeyText? config = ConfigHotKeyTextByTextId.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "快捷键文本配置找不到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TextId", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (config == null)
			{
				return null;
			}
			return config.GetValueOrDefault().Name;
		}

		// Token: 0x06025DB2 RID: 155058 RVA: 0x00AA2078 File Offset: 0x00AA0278
		[return: Nullable(2)]
		public string GetHotKeyIcon(string keyName, bool warnOnly = false)
		{
			HotKeyIcon? hotKeyIconConfig = this.GetHotKeyIconConfig(keyName, warnOnly);
			if (hotKeyIconConfig == null)
			{
				return null;
			}
			return hotKeyIconConfig.GetValueOrDefault().Icon;
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x06025DB3 RID: 155059 RVA: 0x00AA20A8 File Offset: 0x00AA02A8
		public static UiNavigationConfig Instance
		{
			get
			{
				return UiNavigationConfig._Instance;
			}
		}

		// Token: 0x06025DB4 RID: 155060 RVA: 0x00AA20AF File Offset: 0x00AA02AF
		public static UiNavigationConfig GetOrCreateInstance()
		{
			if (UiNavigationConfig._Instance == null)
			{
				UiNavigationConfig.CreateInstance();
			}
			return UiNavigationConfig._Instance;
		}

		// Token: 0x06025DB5 RID: 155061 RVA: 0x00AA20C3 File Offset: 0x00AA02C3
		public static bool CreateInstance()
		{
			if (UiNavigationConfig._Instance != null)
			{
				return true;
			}
			UiNavigationConfig._Instance = new UiNavigationConfig();
			return true;
		}

		// Token: 0x06025DB6 RID: 155062 RVA: 0x00AA20D9 File Offset: 0x00AA02D9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06025DB7 RID: 155063 RVA: 0x00AA20DB File Offset: 0x00AA02DB
		public static void ResetStaticDefaultValue()
		{
			UiNavigationConfig._Instance = null;
		}

		// Token: 0x06025DB8 RID: 155064 RVA: 0x00AA20E3 File Offset: 0x00AA02E3
		static UiNavigationConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationConfig.CreateStaticDefaultValue), new Action(UiNavigationConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04014D58 RID: 85336
		[Nullable(2)]
		private static UiNavigationConfig _Instance;
	}
}
