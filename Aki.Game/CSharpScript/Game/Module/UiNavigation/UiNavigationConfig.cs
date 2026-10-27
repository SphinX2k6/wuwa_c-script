using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049F4 RID: 18932
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class UiNavigationConfig : ConfigBase
	{
		// Token: 0x06031273 RID: 201331 RVA: 0x00B66E04 File Offset: 0x00B65004
		public bool GetHighlightWhenMouseMoveOut()
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("highlight_when_mouse_moveout");
			if (boolConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "鼠标移出button表现参数找不到, 请检测c.参数字段\"highlight_when_mouse_moveout\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return boolConfig.GetValueOrDefault();
		}

		// Token: 0x06031274 RID: 201332 RVA: 0x00B66E4C File Offset: 0x00B6504C
		public bool GetMobileHighlight()
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("mobile_highlight");
			if (boolConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "移动端是否显示按钮高亮参数找不到, 请检测c.参数字段\"mobile_highlight\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return boolConfig.GetValueOrDefault();
		}

		// Token: 0x06031275 RID: 201333 RVA: 0x00B66E94 File Offset: 0x00B65094
		public bool GetPcPress()
		{
			bool? boolConfig = ConfigCommonParamById.GetBoolConfig("pc_press");
			if (boolConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "PC端是否显示按钮按下参数找不到, 请检测c.参数字段\"pc_press\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return boolConfig.GetValueOrDefault();
		}

		// Token: 0x06031276 RID: 201334 RVA: 0x00B66EDC File Offset: 0x00B650DC
		public float GetNavigateTolerance()
		{
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("navigate_tolerance");
			if (floatConfig == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "导航组同向误差找不到, 请检测c.参数字段\"navigate_tolerance\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return floatConfig.GetValueOrDefault();
		}

		// Token: 0x06031277 RID: 201335 RVA: 0x00B66F24 File Offset: 0x00B65124
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

		// Token: 0x06031278 RID: 201336 RVA: 0x00B66F74 File Offset: 0x00B65174
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

		// Token: 0x06031279 RID: 201337 RVA: 0x00B66FD4 File Offset: 0x00B651D4
		public HotKeyType? GetHotKeyTypeConfig(int id)
		{
			return ConfigHotKeyTypeById.GetConfig(id, true);
		}

		// Token: 0x0603127A RID: 201338 RVA: 0x00B66FE0 File Offset: 0x00B651E0
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

		// Token: 0x0603127B RID: 201339 RVA: 0x00B67058 File Offset: 0x00B65258
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

		// Token: 0x0603127C RID: 201340 RVA: 0x00B670BC File Offset: 0x00B652BC
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

		// Token: 0x170079DD RID: 31197
		// (get) Token: 0x0603127D RID: 201341 RVA: 0x00B670EC File Offset: 0x00B652EC
		public static UiNavigationConfig Instance
		{
			get
			{
				return UiNavigationConfig._Instance;
			}
		}

		// Token: 0x0603127E RID: 201342 RVA: 0x00B670F3 File Offset: 0x00B652F3
		public static UiNavigationConfig GetOrCreateInstance()
		{
			if (UiNavigationConfig._Instance == null)
			{
				UiNavigationConfig.CreateInstance();
			}
			return UiNavigationConfig._Instance;
		}

		// Token: 0x0603127F RID: 201343 RVA: 0x00B67107 File Offset: 0x00B65307
		public static bool CreateInstance()
		{
			if (UiNavigationConfig._Instance != null)
			{
				return true;
			}
			UiNavigationConfig._Instance = new UiNavigationConfig();
			return true;
		}

		// Token: 0x06031280 RID: 201344 RVA: 0x00B6711D File Offset: 0x00B6531D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031281 RID: 201345 RVA: 0x00B6711F File Offset: 0x00B6531F
		public static void ResetStaticDefaultValue()
		{
			UiNavigationConfig._Instance = null;
		}

		// Token: 0x06031282 RID: 201346 RVA: 0x00B67127 File Offset: 0x00B65327
		static UiNavigationConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationConfig.CreateStaticDefaultValue), new Action(UiNavigationConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401A4E6 RID: 107750
		[Nullable(2)]
		private static UiNavigationConfig _Instance;
	}
}
