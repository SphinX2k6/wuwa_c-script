using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E1 RID: 2529
	public class ConfigTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B5A RID: 15194 RVA: 0x001A967D File Offset: 0x001A787D
		static ConfigTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTextById.CreateStaticDefaultValue), new Action(ConfigTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x001A969C File Offset: 0x001A789C
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

		// Token: 0x06003B5C RID: 15196 RVA: 0x001A971B File Offset: 0x001A791B
		public static void ResetStaticDefaultValue()
		{
			ConfigTextById.LogPair = null;
			ConfigTextById.HandleId = 0;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x001A9729 File Offset: 0x001A7929
		public static void Init()
		{
			ConfigTextById.HandleId = ConfigCommon.InitDataStatement(ConfigTextById.HandleId, "db_text.db", "select BinData from `Text` where Id = ?");
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x001A9744 File Offset: 0x001A7944
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

		// Token: 0x0400450D RID: 17677
		private const string DB = "db_text.db";

		// Token: 0x0400450E RID: 17678
		private const string FILE = "w.文本(通用).xlsx";

		// Token: 0x0400450F RID: 17679
		private const string TABLE = "Text";

		// Token: 0x04004510 RID: 17680
		private const string COMMAND = "select BinData from `Text` where Id = ?";

		// Token: 0x04004511 RID: 17681
		private const string KEY_PREFIX = "TextById";

		// Token: 0x04004512 RID: 17682
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004513 RID: 17683
		private static int HandleId;
	}
}
