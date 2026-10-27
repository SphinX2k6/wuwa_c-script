using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x0200452F RID: 17711
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class AnimalStandbyMontageConfig : ConfigBase
	{
		// Token: 0x0602DC00 RID: 187392 RVA: 0x00A82EB8 File Offset: 0x00A810B8
		protected override bool OnInit()
		{
			this.ConfigDataMap = new Dictionary<string, List<AnimalStandbyMontage>>();
			return true;
		}

		// Token: 0x0602DC01 RID: 187393 RVA: 0x00A82EC6 File Offset: 0x00A810C6
		protected override bool OnClear()
		{
			this.ConfigDataMap = null;
			return true;
		}

		// Token: 0x0602DC02 RID: 187394 RVA: 0x00A82ED0 File Offset: 0x00A810D0
		private bool GetAnimalStandbyMontageConfig(string bpPath, List<AnimalStandbyMontage> @out)
		{
			IReadOnlyList<AnimalStandbyMontage> configList = ConfigAnimalStandbyMontageByBp.GetConfigList(bpPath, false);
			if (configList == null)
			{
				return false;
			}
			@out.Clear();
			foreach (AnimalStandbyMontage item in configList)
			{
				@out.Add(item);
			}
			return true;
		}

		// Token: 0x0602DC03 RID: 187395 RVA: 0x00A82F2C File Offset: 0x00A8112C
		[return: Nullable(2)]
		public List<AnimalStandbyMontage> GetAnimalStandbyMontageData(string bpPath)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (!this.ConfigDataMap.ContainsKey(bpPath))
				{
					List<AnimalStandbyMontage> list = new List<AnimalStandbyMontage>();
					if (!this.GetAnimalStandbyMontageConfig(bpPath, list))
					{
						return null;
					}
					this.ConfigDataMap.Add(bpPath, list);
				}
				List<AnimalStandbyMontage> valueOrDefault = this.ConfigDataMap.GetValueOrDefault(bpPath);
				if (valueOrDefault == null)
				{
					return null;
				}
				return valueOrDefault;
			}
			else
			{
				this.ParseConfigFromJsonFile();
				List<AnimalStandbyMontage> valueOrDefault2 = this.ConfigDataMap.GetValueOrDefault(bpPath);
				if (valueOrDefault2 == null)
				{
					return null;
				}
				return valueOrDefault2;
			}
		}

		// Token: 0x0602DC04 RID: 187396 RVA: 0x00A82FA0 File Offset: 0x00A811A0
		private void ParseConfigFromJsonFile()
		{
			string configPath = PublicUtil.Instance.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/AnimalStandbyTag.json");
			if (!PublicUtil.Instance.IsUseTempData())
			{
				configPath = PublicUtil.Instance.GetConfigPath("Content/Aki/UniverseEditorConfig/Json/AnimalStandbyTag.json");
			}
			if (!UBlueprintPathsLibrary.FileExists(configPath))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "不存在AnimalStandbyTag.json文件。";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", configPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string text = "";
			UKuroStaticLibrary.LoadFileToString(ref text, configPath);
			AnimalStandbyMontage[] array = Json.Parse<AnimalStandbyMontage[]>(text, null);
			if (array == null)
			{
				return;
			}
			foreach (AnimalStandbyMontage item in array)
			{
				if (!string.IsNullOrEmpty(item.Bp))
				{
					if (!this.ConfigDataMap.ContainsKey(item.Bp))
					{
						this.ConfigDataMap.Add(item.Bp, new List<AnimalStandbyMontage>());
					}
					this.ConfigDataMap.GetValueOrDefault(item.Bp).Add(item);
				}
			}
		}

		// Token: 0x1700751B RID: 29979
		// (get) Token: 0x0602DC05 RID: 187397 RVA: 0x00A83097 File Offset: 0x00A81297
		public static AnimalStandbyMontageConfig Instance
		{
			get
			{
				return AnimalStandbyMontageConfig._Instance;
			}
		}

		// Token: 0x0602DC06 RID: 187398 RVA: 0x00A8309E File Offset: 0x00A8129E
		public static AnimalStandbyMontageConfig GetOrCreateInstance()
		{
			if (AnimalStandbyMontageConfig._Instance == null)
			{
				AnimalStandbyMontageConfig.CreateInstance();
			}
			return AnimalStandbyMontageConfig._Instance;
		}

		// Token: 0x0602DC07 RID: 187399 RVA: 0x00A830B2 File Offset: 0x00A812B2
		public static bool CreateInstance()
		{
			if (AnimalStandbyMontageConfig._Instance != null)
			{
				return true;
			}
			AnimalStandbyMontageConfig._Instance = new AnimalStandbyMontageConfig();
			return true;
		}

		// Token: 0x0602DC08 RID: 187400 RVA: 0x00A830C8 File Offset: 0x00A812C8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DC09 RID: 187401 RVA: 0x00A830CA File Offset: 0x00A812CA
		public static void ResetStaticDefaultValue()
		{
			AnimalStandbyMontageConfig._Instance = null;
		}

		// Token: 0x0602DC0A RID: 187402 RVA: 0x00A830D2 File Offset: 0x00A812D2
		static AnimalStandbyMontageConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnimalStandbyMontageConfig.CreateStaticDefaultValue), new Action(AnimalStandbyMontageConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040186CE RID: 100046
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, List<AnimalStandbyMontage>> ConfigDataMap;

		// Token: 0x040186CF RID: 100047
		[Nullable(2)]
		private static AnimalStandbyMontageConfig _Instance;
	}
}
