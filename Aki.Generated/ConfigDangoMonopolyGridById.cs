using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001EB RID: 491
	public class ConfigDangoMonopolyGridById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B85 RID: 2949 RVA: 0x0009AC7B File Offset: 0x00098E7B
		static ConfigDangoMonopolyGridById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyGridById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyGridById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0009AC9C File Offset: 0x00098E9C
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

		// Token: 0x06000B87 RID: 2951 RVA: 0x0009AD1B File Offset: 0x00098F1B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyGridById.LogPair = null;
			ConfigDangoMonopolyGridById.HandleId = 0;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0009AD29 File Offset: 0x00098F29
		public static void Init()
		{
			ConfigDangoMonopolyGridById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyGridById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyGrid` where GridId=?");
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0009AD44 File Offset: 0x00098F44
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

		// Token: 0x04000D51 RID: 3409
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D52 RID: 3410
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D53 RID: 3411
		private const string TABLE = "DangoMonopolyGrid";

		// Token: 0x04000D54 RID: 3412
		private const string COMMAND = "select BinData from `DangoMonopolyGrid` where GridId=?";

		// Token: 0x04000D55 RID: 3413
		private const string KEY_PREFIX = "DangoMonopolyGridById";

		// Token: 0x04000D56 RID: 3414
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D57 RID: 3415
		private static int HandleId;
	}
}
