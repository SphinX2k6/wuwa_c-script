using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A7 RID: 167
	public class ConfigAreaAtmosphereInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00073263 File Offset: 0x00071463
		static ConfigAreaAtmosphereInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaAtmosphereInfoById.CreateStaticDefaultValue), new Action(ConfigAreaAtmosphereInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00073284 File Offset: 0x00071484
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaAtmosphereInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaAtmosphereInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "AreaAtmosphereInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaAtmosphereInfo` where Id=?")
			});
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00073303 File Offset: 0x00071503
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaAtmosphereInfoById.LogPair = null;
			ConfigAreaAtmosphereInfoById.HandleId = 0;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00073311 File Offset: 0x00071511
		public static void Init()
		{
			ConfigAreaAtmosphereInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaAtmosphereInfoById.HandleId, "db_area.db", "select BinData from `AreaAtmosphereInfo` where Id=?");
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0007332C File Offset: 0x0007152C
		public static AreaAtmosphereInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaAtmosphereInfoById.HandleId, ConfigAreaAtmosphereInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaAtmosphereInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaAtmosphereInfo?(AreaAtmosphereInfo.GetRootAsAreaAtmosphereInfo(configBuffer));
				}
			}
			ConfigAreaAtmosphereInfoById.LogPair.Clear();
			ConfigAreaAtmosphereInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaAtmosphereInfoById.HandleId, 1, p0Id, ConfigAreaAtmosphereInfoById.LogPair) || ConfigCommon.Step(ConfigAreaAtmosphereInfoById.HandleId, true, ConfigAreaAtmosphereInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaAtmosphereInfoById.HandleId, ConfigAreaAtmosphereInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaAtmosphereInfoById.HandleId, 0, ConfigAreaAtmosphereInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaAtmosphereInfoById.HandleId, ConfigAreaAtmosphereInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaAtmosphereInfo rootAsAreaAtmosphereInfo = AreaAtmosphereInfo.GetRootAsAreaAtmosphereInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaAtmosphereInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaAtmosphereInfoById.HandleId, ConfigAreaAtmosphereInfoById.LogPair);
			return new AreaAtmosphereInfo?(rootAsAreaAtmosphereInfo);
		}

		// Token: 0x04000475 RID: 1141
		private const string DB = "db_area.db";

		// Token: 0x04000476 RID: 1142
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000477 RID: 1143
		private const string TABLE = "AreaAtmosphereInfo";

		// Token: 0x04000478 RID: 1144
		private const string COMMAND = "select BinData from `AreaAtmosphereInfo` where Id=?";

		// Token: 0x04000479 RID: 1145
		private const string KEY_PREFIX = "AreaAtmosphereInfoById";

		// Token: 0x0400047A RID: 1146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400047B RID: 1147
		private static int HandleId;
	}
}
