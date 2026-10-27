using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C6 RID: 1222
	public class ConfigLangImageResourceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x000FB4B8 File Offset: 0x000F96B8
		static ConfigLangImageResourceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLangImageResourceById.CreateStaticDefaultValue), new Action(ConfigLangImageResourceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000FB4D8 File Offset: 0x000F96D8
		public static void CreateStaticDefaultValue()
		{
			ConfigLangImageResourceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLangImageResourceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_langimage.db"),
				new ValueTuple<string, object>("文件", "d.多语言图片资源.xlsx"),
				new ValueTuple<string, object>("表名", "LangImageResource"),
				new ValueTuple<string, object>("语句", "select BinData from `LangImageResource` where Id=?")
			});
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000FB557 File Offset: 0x000F9757
		public static void ResetStaticDefaultValue()
		{
			ConfigLangImageResourceById.LogPair = null;
			ConfigLangImageResourceById.HandleId = 0;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000FB565 File Offset: 0x000F9765
		public static void Init()
		{
			ConfigLangImageResourceById.HandleId = ConfigCommon.InitDataStatement(ConfigLangImageResourceById.HandleId, "db_langimage.db", "select BinData from `LangImageResource` where Id=?");
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000FB580 File Offset: 0x000F9780
		public static LangImageResource? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("LangImageResourceById#" + p0Id);
				if (configBuffer != null)
				{
					return new LangImageResource?(LangImageResource.GetRootAsLangImageResource(configBuffer));
				}
			}
			ConfigLangImageResourceById.LogPair.Clear();
			ConfigLangImageResourceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigLangImageResourceById.HandleId, 1, p0Id, ConfigLangImageResourceById.LogPair) || ConfigCommon.Step(ConfigLangImageResourceById.HandleId, true, ConfigLangImageResourceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLangImageResourceById.HandleId, 0, ConfigLangImageResourceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LangImageResource rootAsLangImageResource = LangImageResource.GetRootAsLangImageResource(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("LangImageResourceById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLangImageResourceById.HandleId, ConfigLangImageResourceById.LogPair);
			return new LangImageResource?(rootAsLangImageResource);
		}

		// Token: 0x0400214E RID: 8526
		private const string DB = "db_langimage.db";

		// Token: 0x0400214F RID: 8527
		private const string FILE = "d.多语言图片资源.xlsx";

		// Token: 0x04002150 RID: 8528
		private const string TABLE = "LangImageResource";

		// Token: 0x04002151 RID: 8529
		private const string COMMAND = "select BinData from `LangImageResource` where Id=?";

		// Token: 0x04002152 RID: 8530
		private const string KEY_PREFIX = "LangImageResourceById";

		// Token: 0x04002153 RID: 8531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002154 RID: 8532
		private static int HandleId;
	}
}
