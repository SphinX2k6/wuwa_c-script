using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B5 RID: 18101
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ViewHotKeyConfig : ConfigBase
	{
		// Token: 0x0602EAEA RID: 191210 RVA: 0x00ACDFA9 File Offset: 0x00ACC1A9
		[NullableContext(2)]
		public IReadOnlyList<OpenAndCloseViewHotKey> GetAllOpenAndCloseViewHotKeyConfig()
		{
			return ConfigOpenAndCloseViewHotKeyAll.GetConfigList(true);
		}

		// Token: 0x17007660 RID: 30304
		// (get) Token: 0x0602EAEB RID: 191211 RVA: 0x00ACDFB1 File Offset: 0x00ACC1B1
		public static ViewHotKeyConfig Instance
		{
			get
			{
				return ViewHotKeyConfig._Instance;
			}
		}

		// Token: 0x0602EAEC RID: 191212 RVA: 0x00ACDFB8 File Offset: 0x00ACC1B8
		public static ViewHotKeyConfig GetOrCreateInstance()
		{
			if (ViewHotKeyConfig._Instance == null)
			{
				ViewHotKeyConfig.CreateInstance();
			}
			return ViewHotKeyConfig._Instance;
		}

		// Token: 0x0602EAED RID: 191213 RVA: 0x00ACDFCC File Offset: 0x00ACC1CC
		public static bool CreateInstance()
		{
			if (ViewHotKeyConfig._Instance != null)
			{
				return true;
			}
			ViewHotKeyConfig._Instance = new ViewHotKeyConfig();
			return true;
		}

		// Token: 0x0602EAEE RID: 191214 RVA: 0x00ACDFE2 File Offset: 0x00ACC1E2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EAEF RID: 191215 RVA: 0x00ACDFE4 File Offset: 0x00ACC1E4
		public static void ResetStaticDefaultValue()
		{
			ViewHotKeyConfig._Instance = null;
		}

		// Token: 0x0602EAF0 RID: 191216 RVA: 0x00ACDFEC File Offset: 0x00ACC1EC
		static ViewHotKeyConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ViewHotKeyConfig.CreateStaticDefaultValue), new Action(ViewHotKeyConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040196AE RID: 104110
		[Nullable(2)]
		private static ViewHotKeyConfig _Instance;
	}
}
