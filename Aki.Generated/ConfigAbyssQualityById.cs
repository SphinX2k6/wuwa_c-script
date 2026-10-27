using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200001C RID: 28
	public class ConfigAbyssQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0005D9BF File Offset: 0x0005BBBF
		static ConfigAbyssQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssQualityById.CreateStaticDefaultValue), new Action(ConfigAbyssQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0005D9E0 File Offset: 0x0005BBE0
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssQuality` where Id=?")
			});
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0005DA5F File Offset: 0x0005BC5F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssQualityById.LogPair = null;
			ConfigAbyssQualityById.HandleId = 0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0005DA6D File Offset: 0x0005BC6D
		public static void Init()
		{
			ConfigAbyssQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssQualityById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssQuality` where Id=?");
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0005DA88 File Offset: 0x0005BC88
		public static AbyssQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssQualityById.HandleId, ConfigAbyssQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssQuality?(AbyssQuality.GetRootAsAbyssQuality(configBuffer));
				}
			}
			ConfigAbyssQualityById.LogPair.Clear();
			ConfigAbyssQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssQualityById.HandleId, 1, p0Id, ConfigAbyssQualityById.LogPair) || ConfigCommon.Step(ConfigAbyssQualityById.HandleId, true, ConfigAbyssQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssQualityById.HandleId, ConfigAbyssQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssQualityById.HandleId, 0, ConfigAbyssQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssQualityById.HandleId, ConfigAbyssQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssQuality rootAsAbyssQuality = AbyssQuality.GetRootAsAbyssQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssQualityById.HandleId, ConfigAbyssQualityById.LogPair);
			return new AbyssQuality?(rootAsAbyssQuality);
		}

		// Token: 0x040000A8 RID: 168
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000A9 RID: 169
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000AA RID: 170
		private const string TABLE = "AbyssQuality";

		// Token: 0x040000AB RID: 171
		private const string COMMAND = "select BinData from `AbyssQuality` where Id=?";

		// Token: 0x040000AC RID: 172
		private const string KEY_PREFIX = "AbyssQualityById";

		// Token: 0x040000AD RID: 173
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000AE RID: 174
		private static int HandleId;
	}
}
