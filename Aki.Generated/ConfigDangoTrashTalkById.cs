using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000206 RID: 518
	public class ConfigDangoTrashTalkById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C27 RID: 3111 RVA: 0x000A1F67 File Offset: 0x000A0167
		static ConfigDangoTrashTalkById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoTrashTalkById.CreateStaticDefaultValue), new Action(ConfigDangoTrashTalkById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000A1F88 File Offset: 0x000A0188
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

		// Token: 0x06000C29 RID: 3113 RVA: 0x000A2007 File Offset: 0x000A0207
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoTrashTalkById.LogPair = null;
			ConfigDangoTrashTalkById.HandleId = 0;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000A2015 File Offset: 0x000A0215
		public static void Init()
		{
			ConfigDangoTrashTalkById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoTrashTalkById.HandleId, "db_dangobrawl.db", "select BinData from `DangoTrashTalk` where Id=?");
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000A2030 File Offset: 0x000A0230
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

		// Token: 0x04000E0E RID: 3598
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000E0F RID: 3599
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000E10 RID: 3600
		private const string TABLE = "DangoTrashTalk";

		// Token: 0x04000E11 RID: 3601
		private const string COMMAND = "select BinData from `DangoTrashTalk` where Id=?";

		// Token: 0x04000E12 RID: 3602
		private const string KEY_PREFIX = "DangoTrashTalkById";

		// Token: 0x04000E13 RID: 3603
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E14 RID: 3604
		private static int HandleId;
	}
}
