using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009F RID: 159
	public class ConfigAreaAtmosphereInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003BA RID: 954 RVA: 0x0006E9AF File Offset: 0x0006CBAF
		static ConfigAreaAtmosphereInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaAtmosphereInfoById.CreateStaticDefaultValue), new Action(ConfigAreaAtmosphereInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0006E9D0 File Offset: 0x0006CBD0
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

		// Token: 0x060003BC RID: 956 RVA: 0x0006EA4F File Offset: 0x0006CC4F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaAtmosphereInfoById.LogPair = null;
			ConfigAreaAtmosphereInfoById.HandleId = 0;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0006EA5D File Offset: 0x0006CC5D
		public static void Init()
		{
			ConfigAreaAtmosphereInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaAtmosphereInfoById.HandleId, "db_area.db", "select BinData from `AreaAtmosphereInfo` where Id=?");
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0006EA78 File Offset: 0x0006CC78
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

		// Token: 0x0400043D RID: 1085
		private const string DB = "db_area.db";

		// Token: 0x0400043E RID: 1086
		private const string FILE = "q.区域.xlsx";

		// Token: 0x0400043F RID: 1087
		private const string TABLE = "AreaAtmosphereInfo";

		// Token: 0x04000440 RID: 1088
		private const string COMMAND = "select BinData from `AreaAtmosphereInfo` where Id=?";

		// Token: 0x04000441 RID: 1089
		private const string KEY_PREFIX = "AreaAtmosphereInfoById";

		// Token: 0x04000442 RID: 1090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000443 RID: 1091
		private static int HandleId;
	}
}
