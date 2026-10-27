using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x02006F21 RID: 28449
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LevelPrefabConfigModel : ModelBase
	{
		// Token: 0x060453AC RID: 283564 RVA: 0x01121B20 File Offset: 0x0111FD20
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

		// Token: 0x060453AD RID: 283565 RVA: 0x01121BB0 File Offset: 0x0111FDB0
		private string GetConfigPath()
		{
			if (this.ConfigPath == null)
			{
				string str = UKismetSystemLibrary.ConvertToAbsolutePath(UBlueprintPathsLibrary.ProjectContentDir());
				this.ConfigPath = UKismetSystemLibrary.ConvertToAbsolutePath(str + "Aki/Config/Json/NewKuroLevelPrefabConfig.json");
			}
			return this.ConfigPath;
		}

		// Token: 0x060453AE RID: 283566 RVA: 0x01121BEC File Offset: 0x0111FDEC
		public bool IsCloseUroPrefab(string prefabName)
		{
			return this.Config != null && Array.Exists<string>(this.Config.CloseUroPrefab, (string x) => x == prefabName);
		}

		// Token: 0x17009B0B RID: 39691
		// (get) Token: 0x060453AF RID: 283567 RVA: 0x01121C2C File Offset: 0x0111FE2C
		public static LevelPrefabConfigModel Instance
		{
			get
			{
				return LevelPrefabConfigModel._Instance;
			}
		}

		// Token: 0x060453B0 RID: 283568 RVA: 0x01121C33 File Offset: 0x0111FE33
		public static LevelPrefabConfigModel GetOrCreateInstance()
		{
			if (LevelPrefabConfigModel._Instance == null)
			{
				LevelPrefabConfigModel.CreateInstance();
			}
			return LevelPrefabConfigModel._Instance;
		}

		// Token: 0x060453B1 RID: 283569 RVA: 0x01121C47 File Offset: 0x0111FE47
		public static bool CreateInstance()
		{
			if (LevelPrefabConfigModel._Instance != null)
			{
				return true;
			}
			LevelPrefabConfigModel._Instance = new LevelPrefabConfigModel();
			return true;
		}

		// Token: 0x060453B2 RID: 283570 RVA: 0x01121C5D File Offset: 0x0111FE5D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060453B3 RID: 283571 RVA: 0x01121C5F File Offset: 0x0111FE5F
		public static void ResetStaticDefaultValue()
		{
			LevelPrefabConfigModel._Instance = null;
		}

		// Token: 0x060453B4 RID: 283572 RVA: 0x01121C67 File Offset: 0x0111FE67
		static LevelPrefabConfigModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelPrefabConfigModel.CreateStaticDefaultValue), new Action(LevelPrefabConfigModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024186 RID: 147846
		[Nullable(2)]
		private LevelPrefabConfig Config;

		// Token: 0x04024187 RID: 147847
		[Nullable(2)]
		private string ConfigPath;

		// Token: 0x04024188 RID: 147848
		[Nullable(2)]
		private static LevelPrefabConfigModel _Instance;
	}
}
