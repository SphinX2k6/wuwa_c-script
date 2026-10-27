using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000257 RID: 599
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseConfigModel : Singleton
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x0005873B File Offset: 0x0005693B
		[NullableContext(2)]
		private void parseGrayBox(IGrayBoxConfig grayBoxConfig)
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00058740 File Offset: 0x00056940
		public void parseClientEntryJson(string parallelName, Dictionary<string, EntryJson> jsonFileData)
		{
			EntryJson defaultObject = null;
			EntryJson overrideObj = null;
			foreach (KeyValuePair<string, EntryJson> keyValuePair in jsonFileData)
			{
				string key = keyValuePair.Key;
				EntryJson value = keyValuePair.Value;
				if (key == "default")
				{
					defaultObject = value;
				}
				else if (key == parallelName)
				{
					overrideObj = value;
				}
			}
			EntryJson entryJson = new EntryJson(defaultObject, overrideObj);
			this.EntryJson = entryJson;
			this.parseGrayBox(entryJson.GrayBox);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000587DC File Offset: 0x000569DC
		public static BaseConfigModel Instance
		{
			get
			{
				if (BaseConfigModel._instance == null)
				{
					BaseConfigModel._instance = new BaseConfigModel();
					BaseConfigModel._instance.OnInit();
				}
				return BaseConfigModel._instance;
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000587FF File Offset: 0x000569FF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00058801 File Offset: 0x00056A01
		public static void ResetStaticDefaultValue()
		{
			BaseConfigModel instance = BaseConfigModel._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BaseConfigModel._instance = null;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0005881A File Offset: 0x00056A1A
		static BaseConfigModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BaseConfigModel.CreateStaticDefaultValue), new Action(BaseConfigModel.ResetStaticDefaultValue));
		}

		// Token: 0x040009A8 RID: 2472
		public Dictionary<string, string> BaseConfig = new Dictionary<string, string>();

		// Token: 0x040009A9 RID: 2473
		public bool PublicConfigLoaded;

		// Token: 0x040009AA RID: 2474
		public Dictionary<string, string> BuildInfoMap = new Dictionary<string, string>();

		// Token: 0x040009AB RID: 2475
		public Dictionary<string, string> ConfigVersionMap = new Dictionary<string, string>();

		// Token: 0x040009AC RID: 2476
		public bool ParamsConfigInited;

		// Token: 0x040009AD RID: 2477
		[Nullable(2)]
		public EntryJson EntryJson;

		// Token: 0x040009AE RID: 2478
		public readonly Dictionary<string, IGrayBoxItem> GrayBoxConfigMap = new Dictionary<string, IGrayBoxItem>();

		// Token: 0x040009AF RID: 2479
		public readonly Dictionary<string, EHitResult> BoxResultMap = new Dictionary<string, EHitResult>();

		// Token: 0x040009B0 RID: 2480
		[Nullable(2)]
		private static BaseConfigModel _instance;
	}
}
