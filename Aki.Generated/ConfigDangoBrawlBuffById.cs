using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D6 RID: 470
	public class ConfigDangoBrawlBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x0009B7F7 File Offset: 0x000999F7
		static ConfigDangoBrawlBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlBuffById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0009B818 File Offset: 0x00099A18
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlBuff` where Id=?")
			});
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0009B897 File Offset: 0x00099A97
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlBuffById.LogPair = null;
			ConfigDangoBrawlBuffById.HandleId = 0;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0009B8A5 File Offset: 0x00099AA5
		public static void Init()
		{
			ConfigDangoBrawlBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlBuffById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlBuff` where Id=?");
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0009B8C0 File Offset: 0x00099AC0
		public static DangoBrawlBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlBuff?(DangoBrawlBuff.GetRootAsDangoBrawlBuff(configBuffer));
				}
			}
			ConfigDangoBrawlBuffById.LogPair.Clear();
			ConfigDangoBrawlBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlBuffById.HandleId, 1, p0Id, ConfigDangoBrawlBuffById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlBuffById.HandleId, true, ConfigDangoBrawlBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlBuffById.HandleId, 0, ConfigDangoBrawlBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlBuff rootAsDangoBrawlBuff = DangoBrawlBuff.GetRootAsDangoBrawlBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlBuffById.HandleId, ConfigDangoBrawlBuffById.LogPair);
			return new DangoBrawlBuff?(rootAsDangoBrawlBuff);
		}

		// Token: 0x04000CBE RID: 3262
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CBF RID: 3263
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000CC0 RID: 3264
		private const string TABLE = "DangoBrawlBuff";

		// Token: 0x04000CC1 RID: 3265
		private const string COMMAND = "select BinData from `DangoBrawlBuff` where Id=?";

		// Token: 0x04000CC2 RID: 3266
		private const string KEY_PREFIX = "DangoBrawlBuffById";

		// Token: 0x04000CC3 RID: 3267
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CC4 RID: 3268
		private static int HandleId;
	}
}
