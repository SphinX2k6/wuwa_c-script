using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F4 RID: 500
	public class ConfigDangoTrashTalkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BBB RID: 3003 RVA: 0x0009C02F File Offset: 0x0009A22F
		static ConfigDangoTrashTalkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoTrashTalkById.CreateStaticDefaultValue), new Action(ConfigDangoTrashTalkById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0009C050 File Offset: 0x0009A250
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoTrashTalkById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoTrashTalkById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoTrashTalk"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoTrashTalk` where Id=?")
			});
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0009C0CF File Offset: 0x0009A2CF
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoTrashTalkById.LogPair = null;
			ConfigDangoTrashTalkById.HandleId = 0;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0009C0DD File Offset: 0x0009A2DD
		public static void Init()
		{
			ConfigDangoTrashTalkById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoTrashTalkById.HandleId, "db_dangobrawl.db", "select BinData from `DangoTrashTalk` where Id=?");
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0009C0F8 File Offset: 0x0009A2F8
		public static DangoTrashTalk? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoTrashTalkById.HandleId, ConfigDangoTrashTalkById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoTrashTalkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoTrashTalk?(DangoTrashTalk.GetRootAsDangoTrashTalk(configBuffer));
				}
			}
			ConfigDangoTrashTalkById.LogPair.Clear();
			ConfigDangoTrashTalkById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoTrashTalkById.HandleId, 1, p0Id, ConfigDangoTrashTalkById.LogPair) || ConfigCommon.Step(ConfigDangoTrashTalkById.HandleId, true, ConfigDangoTrashTalkById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoTrashTalkById.HandleId, ConfigDangoTrashTalkById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoTrashTalkById.HandleId, 0, ConfigDangoTrashTalkById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoTrashTalkById.HandleId, ConfigDangoTrashTalkById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoTrashTalk rootAsDangoTrashTalk = DangoTrashTalk.GetRootAsDangoTrashTalk(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoTrashTalkById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoTrashTalkById.HandleId, ConfigDangoTrashTalkById.LogPair);
			return new DangoTrashTalk?(rootAsDangoTrashTalk);
		}

		// Token: 0x04000D90 RID: 3472
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D91 RID: 3473
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D92 RID: 3474
		private const string TABLE = "DangoTrashTalk";

		// Token: 0x04000D93 RID: 3475
		private const string COMMAND = "select BinData from `DangoTrashTalk` where Id=?";

		// Token: 0x04000D94 RID: 3476
		private const string KEY_PREFIX = "DangoTrashTalkById";

		// Token: 0x04000D95 RID: 3477
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D96 RID: 3478
		private static int HandleId;
	}
}
