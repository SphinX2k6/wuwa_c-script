using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CB RID: 459
	public class ConfigDangoBrawlItemComposeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0009674F File Offset: 0x0009494F
		static ConfigDangoBrawlItemComposeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemComposeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemComposeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00096770 File Offset: 0x00094970
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemComposeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemCompose"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemCompose` where Id=?")
			});
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000967EF File Offset: 0x000949EF
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeById.LogPair = null;
			ConfigDangoBrawlItemComposeById.HandleId = 0;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000967FD File Offset: 0x000949FD
		public static void Init()
		{
			ConfigDangoBrawlItemComposeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemComposeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemCompose` where Id=?");
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00096818 File Offset: 0x00094A18
		public static DangoBrawlItemCompose? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemComposeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItemCompose?(DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(configBuffer));
				}
			}
			ConfigDangoBrawlItemComposeById.LogPair.Clear();
			ConfigDangoBrawlItemComposeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemComposeById.HandleId, 1, p0Id, ConfigDangoBrawlItemComposeById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemComposeById.HandleId, true, ConfigDangoBrawlItemComposeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemComposeById.HandleId, 0, ConfigDangoBrawlItemComposeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItemCompose rootAsDangoBrawlItemCompose = DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemComposeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair);
			return new DangoBrawlItemCompose?(rootAsDangoBrawlItemCompose);
		}

		// Token: 0x04000C71 RID: 3185
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C72 RID: 3186
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000C73 RID: 3187
		private const string TABLE = "DangoBrawlItemCompose";

		// Token: 0x04000C74 RID: 3188
		private const string COMMAND = "select BinData from `DangoBrawlItemCompose` where Id=?";

		// Token: 0x04000C75 RID: 3189
		private const string KEY_PREFIX = "DangoBrawlItemComposeById";

		// Token: 0x04000C76 RID: 3190
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C77 RID: 3191
		private static int HandleId;
	}
}
