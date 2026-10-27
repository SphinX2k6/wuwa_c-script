using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000539 RID: 1337
	public class ConfigMaterialReplaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F61 RID: 8033 RVA: 0x0010AB10 File Offset: 0x00108D10
		static ConfigMaterialReplaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMaterialReplaceAll.CreateStaticDefaultValue), new Action(ConfigMaterialReplaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0010AB30 File Offset: 0x00108D30
		public static void CreateStaticDefaultValue()
		{
			ConfigMaterialReplaceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMaterialReplaceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "MaterialReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `MaterialReplace`")
			});
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x0010ABAF File Offset: 0x00108DAF
		public static void ResetStaticDefaultValue()
		{
			ConfigMaterialReplaceAll.LogPair = null;
			ConfigMaterialReplaceAll.HandleId = 0;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0010ABBD File Offset: 0x00108DBD
		public static void Init()
		{
			ConfigMaterialReplaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigMaterialReplaceAll.HandleId, "db_compose.db", "select BinData from `MaterialReplace`");
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0010ABD8 File Offset: 0x00108DD8
		public static MaterialReplace? GetConfig(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("MaterialReplaceAll");
				if (configBuffer != null)
				{
					return new MaterialReplace?(MaterialReplace.GetRootAsMaterialReplace(configBuffer));
				}
			}
			if (ConfigCommon.Step(ConfigMaterialReplaceAll.HandleId, true, ConfigMaterialReplaceAll.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMaterialReplaceAll.HandleId, 0, ConfigMaterialReplaceAll.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MaterialReplace rootAsMaterialReplace = MaterialReplace.GetRootAsMaterialReplace(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("MaterialReplaceAll", byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair);
			return new MaterialReplace?(rootAsMaterialReplace);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x0010ACC0 File Offset: 0x00108EC0
		[NullableContext(2)]
		public static IReadOnlyList<MaterialReplace> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MaterialReplace> readOnlyList = (IReadOnlyList<MaterialReplace>)ConfigCommon.GetConfig("MaterialReplaceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MaterialReplace> list = new List<MaterialReplace>();
			while (ConfigCommon.Step(ConfigMaterialReplaceAll.HandleId, false, ConfigMaterialReplaceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMaterialReplaceAll.HandleId, 0, ConfigMaterialReplaceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair);
					return null;
				}
				MaterialReplace rootAsMaterialReplace = MaterialReplace.GetRootAsMaterialReplace(new ByteBuffer(item2));
				list.Add(rootAsMaterialReplace);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MaterialReplaceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMaterialReplaceAll.HandleId, ConfigMaterialReplaceAll.LogPair);
			return list;
		}

		// Token: 0x04002473 RID: 9331
		private const string DB = "db_compose.db";

		// Token: 0x04002474 RID: 9332
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04002475 RID: 9333
		private const string TABLE = "MaterialReplace";

		// Token: 0x04002476 RID: 9334
		private const string COMMAND = "select BinData from `MaterialReplace`";

		// Token: 0x04002477 RID: 9335
		private const string KEY_PREFIX = "MaterialReplaceAll";

		// Token: 0x04002478 RID: 9336
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002479 RID: 9337
		private static int HandleId;
	}
}
