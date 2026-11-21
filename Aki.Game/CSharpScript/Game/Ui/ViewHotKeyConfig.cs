using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E6 RID: 13798
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ViewHotKeyConfig : ConfigBase
	{
		// Token: 0x06023236 RID: 143926 RVA: 0x009FC87D File Offset: 0x009FAA7D
		[NullableContext(2)]
		public IReadOnlyList<OpenAndCloseViewHotKey> GetAllOpenAndCloseViewHotKeyConfig()
		{
			return ConfigOpenAndCloseViewHotKeyAll.GetConfigList(true);
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x06023237 RID: 143927 RVA: 0x009FC885 File Offset: 0x009FAA85
		public static ViewHotKeyConfig Instance
		{
			get
			{
				return ViewHotKeyConfig._Instance;
			}
		}

		// Token: 0x06023238 RID: 143928 RVA: 0x009FC88C File Offset: 0x009FAA8C
		public static ViewHotKeyConfig GetOrCreateInstance()
		{
			if (ViewHotKeyConfig._Instance == null)
			{
				ViewHotKeyConfig.CreateInstance();
			}
			return ViewHotKeyConfig._Instance;
		}

		// Token: 0x06023239 RID: 143929 RVA: 0x009FC8A0 File Offset: 0x009FAAA0
		public static bool CreateInstance()
		{
			if (ViewHotKeyConfig._Instance != null)
			{
				return true;
			}
			ViewHotKeyConfig._Instance = new ViewHotKeyConfig();
			return true;
		}

		// Token: 0x0602323A RID: 143930 RVA: 0x009FC8B6 File Offset: 0x009FAAB6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602323B RID: 143931 RVA: 0x009FC8B8 File Offset: 0x009FAAB8
		public static void ResetStaticDefaultValue()
		{
			ViewHotKeyConfig._Instance = null;
		}

		// Token: 0x0602323C RID: 143932 RVA: 0x009FC8C0 File Offset: 0x009FAAC0
		static ViewHotKeyConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ViewHotKeyConfig.CreateStaticDefaultValue), new Action(ViewHotKeyConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04013D53 RID: 81235
		[Nullable(2)]
		private static ViewHotKeyConfig _Instance;
	}
}
