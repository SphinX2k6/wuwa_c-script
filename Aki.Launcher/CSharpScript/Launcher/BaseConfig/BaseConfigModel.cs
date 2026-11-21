using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025C RID: 604
	[NullableContext(1)]
	[Nullable(0)]
	public class BaseConfigModel : Singleton
	{
		// Token: 0x06000F5C RID: 3932 RVA: 0x0005B569 File Offset: 0x00059769
		[NullableContext(2)]
		private void parseGrayBox(IGrayBoxConfig grayBoxConfig)
		{
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0005B56C File Offset: 0x0005976C
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0005B608 File Offset: 0x00059808
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

		// Token: 0x06000F5F RID: 3935 RVA: 0x0005B62B File Offset: 0x0005982B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0005B62D File Offset: 0x0005982D
		public static void ResetStaticDefaultValue()
		{
			BaseConfigModel instance = BaseConfigModel._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			BaseConfigModel._instance = null;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0005B646 File Offset: 0x00059846
		static BaseConfigModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BaseConfigModel.CreateStaticDefaultValue), new Action(BaseConfigModel.ResetStaticDefaultValue));
		}

		// Token: 0x040009F2 RID: 2546
		public Dictionary<string, string> BaseConfig = new Dictionary<string, string>();

		// Token: 0x040009F3 RID: 2547
		public bool PublicConfigLoaded;

		// Token: 0x040009F4 RID: 2548
		public Dictionary<string, string> BuildInfoMap = new Dictionary<string, string>();

		// Token: 0x040009F5 RID: 2549
		public Dictionary<string, string> ConfigVersionMap = new Dictionary<string, string>();

		// Token: 0x040009F6 RID: 2550
		public bool ParamsConfigInited;

		// Token: 0x040009F7 RID: 2551
		[Nullable(2)]
		public EntryJson EntryJson;

		// Token: 0x040009F8 RID: 2552
		public readonly Dictionary<string, IGrayBoxItem> GrayBoxConfigMap = new Dictionary<string, IGrayBoxItem>();

		// Token: 0x040009F9 RID: 2553
		public readonly Dictionary<string, EHitResult> BoxResultMap = new Dictionary<string, EHitResult>();

		// Token: 0x040009FA RID: 2554
		[Nullable(2)]
		private static BaseConfigModel _instance;
	}
}
