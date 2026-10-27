using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BE RID: 1214
	public class ConfigKurotatoWaypointsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C7F RID: 7295 RVA: 0x000FA4A4 File Offset: 0x000F86A4
		static ConfigKurotatoWaypointsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaypointsById.CreateStaticDefaultValue), new Action(ConfigKurotatoWaypointsById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000FA4C4 File Offset: 0x000F86C4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWaypointsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWaypointsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWaypoints"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWaypoints` where Id=?")
			});
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000FA543 File Offset: 0x000F8743
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaypointsById.LogPair = null;
			ConfigKurotatoWaypointsById.HandleId = 0;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000FA551 File Offset: 0x000F8751
		public static void Init()
		{
			ConfigKurotatoWaypointsById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaypointsById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWaypoints` where Id=?");
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000FA56C File Offset: 0x000F876C
		public static KurotatoWaypoints? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaypointsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWaypoints?(KurotatoWaypoints.GetRootAsKurotatoWaypoints(configBuffer));
				}
			}
			ConfigKurotatoWaypointsById.LogPair.Clear();
			ConfigKurotatoWaypointsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWaypointsById.HandleId, 1, p0Id, ConfigKurotatoWaypointsById.LogPair) || ConfigCommon.Step(ConfigKurotatoWaypointsById.HandleId, true, ConfigKurotatoWaypointsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWaypointsById.HandleId, 0, ConfigKurotatoWaypointsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWaypoints rootAsKurotatoWaypoints = KurotatoWaypoints.GetRootAsKurotatoWaypoints(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaypointsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWaypointsById.HandleId, ConfigKurotatoWaypointsById.LogPair);
			return new KurotatoWaypoints?(rootAsKurotatoWaypoints);
		}

		// Token: 0x04002116 RID: 8470
		private const string DB = "db_kurotato.db";

		// Token: 0x04002117 RID: 8471
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002118 RID: 8472
		private const string TABLE = "KurotatoWaypoints";

		// Token: 0x04002119 RID: 8473
		private const string COMMAND = "select BinData from `KurotatoWaypoints` where Id=?";

		// Token: 0x0400211A RID: 8474
		private const string KEY_PREFIX = "KurotatoWaypointsById";

		// Token: 0x0400211B RID: 8475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400211C RID: 8476
		private static int HandleId;
	}
}
