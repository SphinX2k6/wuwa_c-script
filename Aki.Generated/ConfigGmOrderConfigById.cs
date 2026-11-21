using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BA RID: 954
	public class ConfigGmOrderConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001663 RID: 5731 RVA: 0x000DB9FB File Offset: 0x000D9BFB
		static ConfigGmOrderConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderConfigById.CreateStaticDefaultValue), new Action(ConfigGmOrderConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000DBA1C File Offset: 0x000D9C1C
		public static void CreateStaticDefaultValue()
		{
			ConfigGmOrderConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmOrderConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmOrderConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GmOrderConfig` where Id=?")
			});
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000DBA9B File Offset: 0x000D9C9B
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderConfigById.LogPair = null;
			ConfigGmOrderConfigById.HandleId = 0;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000DBAA9 File Offset: 0x000D9CA9
		public static void Init()
		{
			ConfigGmOrderConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderConfigById.HandleId, "db_gm.db", "select BinData from `GmOrderConfig` where Id=?");
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000DBAC4 File Offset: 0x000D9CC4
		public static GmOrderConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmOrderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GmOrderConfig?(GmOrderConfig.GetRootAsGmOrderConfig(configBuffer));
				}
			}
			ConfigGmOrderConfigById.LogPair.Clear();
			ConfigGmOrderConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGmOrderConfigById.HandleId, 1, p0Id, ConfigGmOrderConfigById.LogPair) || ConfigCommon.Step(ConfigGmOrderConfigById.HandleId, true, ConfigGmOrderConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmOrderConfigById.HandleId, 0, ConfigGmOrderConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GmOrderConfig rootAsGmOrderConfig = GmOrderConfig.GetRootAsGmOrderConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmOrderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair);
			return new GmOrderConfig?(rootAsGmOrderConfig);
		}

		// Token: 0x040019FA RID: 6650
		private const string DB = "db_gm.db";

		// Token: 0x040019FB RID: 6651
		private const string FILE = "g.GM.xlsx";

		// Token: 0x040019FC RID: 6652
		private const string TABLE = "GmOrderConfig";

		// Token: 0x040019FD RID: 6653
		private const string COMMAND = "select BinData from `GmOrderConfig` where Id=?";

		// Token: 0x040019FE RID: 6654
		private const string KEY_PREFIX = "GmOrderConfigById";

		// Token: 0x040019FF RID: 6655
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A00 RID: 6656
		private static int HandleId;
	}
}
