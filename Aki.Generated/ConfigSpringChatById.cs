using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000972 RID: 2418
	public class ConfigSpringChatById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038C0 RID: 14528 RVA: 0x0019A720 File Offset: 0x00198920
		static ConfigSpringChatById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringChatById.CreateStaticDefaultValue), new Action(ConfigSpringChatById.ResetStaticDefaultValue));
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x0019A740 File Offset: 0x00198940
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

		// Token: 0x060038C2 RID: 14530 RVA: 0x0019A7BF File Offset: 0x001989BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringChatById.LogPair = null;
			ConfigSpringChatById.HandleId = 0;
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0019A7CD File Offset: 0x001989CD
		public static void Init()
		{
			ConfigSpringChatById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringChatById.HandleId, "db_sprintsign.db", "select BinData from `SpringChat` where Id=?");
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0019A7E8 File Offset: 0x001989E8
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

		// Token: 0x04004204 RID: 16900
		private const string DB = "db_sprintsign.db";

		// Token: 0x04004205 RID: 16901
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04004206 RID: 16902
		private const string TABLE = "SpringChat";

		// Token: 0x04004207 RID: 16903
		private const string COMMAND = "select BinData from `SpringChat` where Id=?";

		// Token: 0x04004208 RID: 16904
		private const string KEY_PREFIX = "SpringChatById";

		// Token: 0x04004209 RID: 16905
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400420A RID: 16906
		private static int HandleId;
	}
}
