using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FD RID: 509
	public class ConfigDangoMonopolyGridById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x000A0BB3 File Offset: 0x0009EDB3
		static ConfigDangoMonopolyGridById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyGridById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyGridById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000A0BD4 File Offset: 0x0009EDD4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyGridById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyGridById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyGrid"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyGrid` where GridId=?")
			});
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000A0C53 File Offset: 0x0009EE53
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyGridById.LogPair = null;
			ConfigDangoMonopolyGridById.HandleId = 0;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000A0C61 File Offset: 0x0009EE61
		public static void Init()
		{
			ConfigDangoMonopolyGridById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyGridById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyGrid` where GridId=?");
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000A0C7C File Offset: 0x0009EE7C
		public static DangoMonopolyGrid? GetConfig(int p0GridId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyGridById.HandleId, ConfigDangoMonopolyGridById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyGridById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GridId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoMonopolyGrid?(DangoMonopolyGrid.GetRootAsDangoMonopolyGrid(configBuffer));
				}
			}
			ConfigDangoMonopolyGridById.LogPair.Clear();
			ConfigDangoMonopolyGridById.LogPair.Add(new ValueTuple<string, object>("GridId", p0GridId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyGridById.HandleId, 1, p0GridId, ConfigDangoMonopolyGridById.LogPair) || ConfigCommon.Step(ConfigDangoMonopolyGridById.HandleId, true, ConfigDangoMonopolyGridById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyGridById.HandleId, ConfigDangoMonopolyGridById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyGridById.HandleId, 0, ConfigDangoMonopolyGridById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyGridById.HandleId, ConfigDangoMonopolyGridById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoMonopolyGrid rootAsDangoMonopolyGrid = DangoMonopolyGrid.GetRootAsDangoMonopolyGrid(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyGridById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GridId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyGridById.HandleId, ConfigDangoMonopolyGridById.LogPair);
			return new DangoMonopolyGrid?(rootAsDangoMonopolyGrid);
		}

		// Token: 0x04000DCF RID: 3535
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DD0 RID: 3536
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DD1 RID: 3537
		private const string TABLE = "DangoMonopolyGrid";

		// Token: 0x04000DD2 RID: 3538
		private const string COMMAND = "select BinData from `DangoMonopolyGrid` where GridId=?";

		// Token: 0x04000DD3 RID: 3539
		private const string KEY_PREFIX = "DangoMonopolyGridById";

		// Token: 0x04000DD4 RID: 3540
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DD5 RID: 3541
		private static int HandleId;
	}
}
