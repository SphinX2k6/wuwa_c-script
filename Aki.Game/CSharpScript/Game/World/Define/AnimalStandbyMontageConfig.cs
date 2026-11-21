using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02003454 RID: 13396
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class AnimalStandbyMontageConfig : ConfigBase
	{
		// Token: 0x060222C8 RID: 139976 RVA: 0x009AE11D File Offset: 0x009AC31D
		protected override bool OnInit()
		{
			this.ConfigDataMap = new Dictionary<string, List<AnimalStandbyMontage>>();
			return true;
		}

		// Token: 0x060222C9 RID: 139977 RVA: 0x009AE12B File Offset: 0x009AC32B
		protected override bool OnClear()
		{
			this.ConfigDataMap = null;
			return true;
		}

		// Token: 0x060222CA RID: 139978 RVA: 0x009AE138 File Offset: 0x009AC338
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

		// Token: 0x060222CB RID: 139979 RVA: 0x009AE194 File Offset: 0x009AC394
		[return: Nullable(2)]
		public List<AnimalStandbyMontage> GetAnimalStandbyMontageData(string bpPath)
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

		// Token: 0x060222CC RID: 139980 RVA: 0x009AE1E4 File Offset: 0x009AC3E4
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

		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x060222CD RID: 139981 RVA: 0x009AE2DB File Offset: 0x009AC4DB
		public static AnimalStandbyMontageConfig Instance
		{
			get
			{
				return AnimalStandbyMontageConfig._Instance;
			}
		}

		// Token: 0x060222CE RID: 139982 RVA: 0x009AE2E2 File Offset: 0x009AC4E2
		public static AnimalStandbyMontageConfig GetOrCreateInstance()
		{
			if (AnimalStandbyMontageConfig._Instance == null)
			{
				AnimalStandbyMontageConfig.CreateInstance();
			}
			return AnimalStandbyMontageConfig._Instance;
		}

		// Token: 0x060222CF RID: 139983 RVA: 0x009AE2F6 File Offset: 0x009AC4F6
		public static bool CreateInstance()
		{
			if (AnimalStandbyMontageConfig._Instance != null)
			{
				return true;
			}
			AnimalStandbyMontageConfig._Instance = new AnimalStandbyMontageConfig();
			return true;
		}

		// Token: 0x060222D0 RID: 139984 RVA: 0x009AE30C File Offset: 0x009AC50C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060222D1 RID: 139985 RVA: 0x009AE30E File Offset: 0x009AC50E
		public static void ResetStaticDefaultValue()
		{
			AnimalStandbyMontageConfig._Instance = null;
		}

		// Token: 0x060222D2 RID: 139986 RVA: 0x009AE316 File Offset: 0x009AC516
		static AnimalStandbyMontageConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AnimalStandbyMontageConfig.CreateStaticDefaultValue), new Action(AnimalStandbyMontageConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04012CF3 RID: 77043
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, List<AnimalStandbyMontage>> ConfigDataMap;

		// Token: 0x04012CF4 RID: 77044
		[Nullable(2)]
		private static AnimalStandbyMontageConfig _Instance;
	}
}
