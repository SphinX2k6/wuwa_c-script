using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x020060A2 RID: 24738
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelPrefabConfigModel : ModelBase
	{
		// Token: 0x0603B55A RID: 243034 RVA: 0x010CBACC File Offset: 0x010C9CCC
		protected override bool OnInit()
		{
			string text = "";
			string configPath = this.GetConfigPath();
			UKuroStaticLibrary.LoadFileToString(ref text, configPath);
			if (StringUtils.IsNothing(text))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Config;
				ELogAuthor author = ELogAuthor.CH;
				string message = "LoadFileToString returned empty content";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			LevelPrefabConfig levelPrefabConfig = Json.Parse<LevelPrefabConfig>(text, null);
			if (levelPrefabConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Config;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "Failed to parse LevelPrefabConfig.json";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", configPath);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return true;
			}
			this.Config = levelPrefabConfig;
			return true;
		}

		// Token: 0x0603B55B RID: 243035 RVA: 0x010CBB5C File Offset: 0x010C9D5C
		private string GetConfigPath()
		{
			if (this.ConfigPath == null)
			{
				string str = UKismetSystemLibrary.ConvertToAbsolutePath(UBlueprintPathsLibrary.ProjectContentDir());
				this.ConfigPath = UKismetSystemLibrary.ConvertToAbsolutePath(str + "Aki/Config/Json/NewKuroLevelPrefabConfig.json");
			}
			return this.ConfigPath;
		}

		// Token: 0x0603B55C RID: 243036 RVA: 0x010CBB98 File Offset: 0x010C9D98
		public bool IsCloseUroPrefab(string prefabName)
		{
			return this.Config != null && Array.Exists<string>(this.Config.CloseUroPrefab, (string x) => x == prefabName);
		}

		// Token: 0x1700704A RID: 28746
		// (get) Token: 0x0603B55D RID: 243037 RVA: 0x010CBBD8 File Offset: 0x010C9DD8
		public static LevelPrefabConfigModel Instance
		{
			get
			{
				return LevelPrefabConfigModel._Instance;
			}
		}

		// Token: 0x0603B55E RID: 243038 RVA: 0x010CBBDF File Offset: 0x010C9DDF
		public static LevelPrefabConfigModel GetOrCreateInstance()
		{
			if (LevelPrefabConfigModel._Instance == null)
			{
				LevelPrefabConfigModel.CreateInstance();
			}
			return LevelPrefabConfigModel._Instance;
		}

		// Token: 0x0603B55F RID: 243039 RVA: 0x010CBBF3 File Offset: 0x010C9DF3
		public static bool CreateInstance()
		{
			if (LevelPrefabConfigModel._Instance != null)
			{
				return true;
			}
			LevelPrefabConfigModel._Instance = new LevelPrefabConfigModel();
			return true;
		}

		// Token: 0x0603B560 RID: 243040 RVA: 0x010CBC09 File Offset: 0x010C9E09
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B561 RID: 243041 RVA: 0x010CBC0B File Offset: 0x010C9E0B
		public static void ResetStaticDefaultValue()
		{
			LevelPrefabConfigModel._Instance = null;
		}

		// Token: 0x0603B562 RID: 243042 RVA: 0x010CBC13 File Offset: 0x010C9E13
		static LevelPrefabConfigModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelPrefabConfigModel.CreateStaticDefaultValue), new Action(LevelPrefabConfigModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F43B RID: 128059
		[Nullable(2)]
		private LevelPrefabConfig Config;

		// Token: 0x0401F43C RID: 128060
		[Nullable(2)]
		private string ConfigPath;

		// Token: 0x0401F43D RID: 128061
		[Nullable(2)]
		private static LevelPrefabConfigModel _Instance;
	}
}
