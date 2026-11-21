using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A47 RID: 2631
	public class ConfigSpringChatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DBE RID: 15806 RVA: 0x001B9AB4 File Offset: 0x001B7CB4
		static ConfigSpringChatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringChatById.CreateStaticDefaultValue), new Action(ConfigSpringChatById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x001B9AD4 File Offset: 0x001B7CD4
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringChatById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringChatById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringChat"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringChat` where Id=?")
			});
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x001B9B53 File Offset: 0x001B7D53
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringChatById.LogPair = null;
			ConfigSpringChatById.HandleId = 0;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x001B9B61 File Offset: 0x001B7D61
		public static void Init()
		{
			ConfigSpringChatById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringChatById.HandleId, "db_sprintsign.db", "select BinData from `SpringChat` where Id=?");
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x001B9B7C File Offset: 0x001B7D7C
		public static SpringChat? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringChatById.HandleId, ConfigSpringChatById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringChatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringChat?(SpringChat.GetRootAsSpringChat(configBuffer));
				}
			}
			ConfigSpringChatById.LogPair.Clear();
			ConfigSpringChatById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringChatById.HandleId, 1, p0Id, ConfigSpringChatById.LogPair) || ConfigCommon.Step(ConfigSpringChatById.HandleId, true, ConfigSpringChatById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringChatById.HandleId, ConfigSpringChatById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringChatById.HandleId, 0, ConfigSpringChatById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringChatById.HandleId, ConfigSpringChatById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringChat rootAsSpringChat = SpringChat.GetRootAsSpringChat(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringChatById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringChatById.HandleId, ConfigSpringChatById.LogPair);
			return new SpringChat?(rootAsSpringChat);
		}

		// Token: 0x040047D7 RID: 18391
		private const string DB = "db_sprintsign.db";

		// Token: 0x040047D8 RID: 18392
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040047D9 RID: 18393
		private const string TABLE = "SpringChat";

		// Token: 0x040047DA RID: 18394
		private const string COMMAND = "select BinData from `SpringChat` where Id=?";

		// Token: 0x040047DB RID: 18395
		private const string KEY_PREFIX = "SpringChatById";

		// Token: 0x040047DC RID: 18396
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047DD RID: 18397
		private static int HandleId;
	}
}
