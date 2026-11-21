using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB6 RID: 2742
	public class ConfigTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004058 RID: 16472 RVA: 0x001C8A11 File Offset: 0x001C6C11
		static ConfigTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTextById.CreateStaticDefaultValue), new Action(ConfigTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x001C8A30 File Offset: 0x001C6C30
		public static void CreateStaticDefaultValue()
		{
			ConfigTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_text.db"),
				new ValueTuple<string, object>("文件", "w.文本(通用).xlsx"),
				new ValueTuple<string, object>("表名", "Text"),
				new ValueTuple<string, object>("语句", "select BinData from `Text` where Id = ?")
			});
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x001C8AAF File Offset: 0x001C6CAF
		public static void ResetStaticDefaultValue()
		{
			ConfigTextById.LogPair = null;
			ConfigTextById.HandleId = 0;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x001C8ABD File Offset: 0x001C6CBD
		public static void Init()
		{
			ConfigTextById.HandleId = ConfigCommon.InitDataStatement(ConfigTextById.HandleId, "db_text.db", "select BinData from `Text` where Id = ?");
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x001C8AD8 File Offset: 0x001C6CD8
		public static Text? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTextById.HandleId, ConfigTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("TextById#" + p0Id);
				if (configBuffer != null)
				{
					return new Text?(Text.GetRootAsText(configBuffer));
				}
			}
			ConfigTextById.LogPair.Clear();
			ConfigTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigTextById.HandleId, 1, p0Id, ConfigTextById.LogPair) || ConfigCommon.Step(ConfigTextById.HandleId, true, ConfigTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTextById.HandleId, ConfigTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTextById.HandleId, 0, ConfigTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTextById.HandleId, ConfigTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Text rootAsText = Text.GetRootAsText(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("TextById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTextById.HandleId, ConfigTextById.LogPair);
			return new Text?(rootAsText);
		}

		// Token: 0x04004AE0 RID: 19168
		private const string DB = "db_text.db";

		// Token: 0x04004AE1 RID: 19169
		private const string FILE = "w.文本(通用).xlsx";

		// Token: 0x04004AE2 RID: 19170
		private const string TABLE = "Text";

		// Token: 0x04004AE3 RID: 19171
		private const string COMMAND = "select BinData from `Text` where Id = ?";

		// Token: 0x04004AE4 RID: 19172
		private const string KEY_PREFIX = "TextById";

		// Token: 0x04004AE5 RID: 19173
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AE6 RID: 19174
		private static int HandleId;
	}
}
