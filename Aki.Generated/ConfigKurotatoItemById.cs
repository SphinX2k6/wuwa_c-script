using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000498 RID: 1176
	public class ConfigKurotatoItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x000F56DB File Offset: 0x000F38DB
		static ConfigKurotatoItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoItemById.CreateStaticDefaultValue), new Action(ConfigKurotatoItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000F56FC File Offset: 0x000F38FC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_道具.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoItem"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoItem` where Id=?")
			});
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000F577B File Offset: 0x000F397B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoItemById.LogPair = null;
			ConfigKurotatoItemById.HandleId = 0;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000F5789 File Offset: 0x000F3989
		public static void Init()
		{
			ConfigKurotatoItemById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoItemById.HandleId, "db_kurotato.db", "select BinData from `KurotatoItem` where Id=?");
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000F57A4 File Offset: 0x000F39A4
		public static KurotatoItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoItem?(KurotatoItem.GetRootAsKurotatoItem(configBuffer));
				}
			}
			ConfigKurotatoItemById.LogPair.Clear();
			ConfigKurotatoItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoItemById.HandleId, 1, p0Id, ConfigKurotatoItemById.LogPair) || ConfigCommon.Step(ConfigKurotatoItemById.HandleId, true, ConfigKurotatoItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoItemById.HandleId, 0, ConfigKurotatoItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoItem rootAsKurotatoItem = KurotatoItem.GetRootAsKurotatoItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair);
			return new KurotatoItem?(rootAsKurotatoItem);
		}

		// Token: 0x0400200C RID: 8204
		private const string DB = "db_kurotato.db";

		// Token: 0x0400200D RID: 8205
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x0400200E RID: 8206
		private const string TABLE = "KurotatoItem";

		// Token: 0x0400200F RID: 8207
		private const string COMMAND = "select BinData from `KurotatoItem` where Id=?";

		// Token: 0x04002010 RID: 8208
		private const string KEY_PREFIX = "KurotatoItemById";

		// Token: 0x04002011 RID: 8209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002012 RID: 8210
		private static int HandleId;
	}
}
